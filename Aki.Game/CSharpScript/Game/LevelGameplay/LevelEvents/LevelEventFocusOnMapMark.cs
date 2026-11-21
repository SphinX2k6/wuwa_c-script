using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CA5 RID: 23717
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventFocusOnMapMark : LevelEventBase
	{
		// Token: 0x0603A269 RID: 238185 RVA: 0x0106620E File Offset: 0x0106440E
		public LevelEventFocusOnMapMark(int id) : base(id)
		{
		}

		// Token: 0x0603A26A RID: 238186 RVA: 0x01066218 File Offset: 0x01064418
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			FocusOnMapMarkAction focusOnMapMarkAction = inParams as FocusOnMapMarkAction;
			if (focusOnMapMarkAction == null)
			{
				base.Finish();
				return;
			}
			EMapMarkType type = focusOnMapMarkAction.MapMarkType.Type;
			if (type == EMapMarkType.Custom)
			{
				this.HandleCustomMapFocus(focusOnMapMarkAction.MapMarkType as IFocusOnCustomMapMark);
				return;
			}
			if (type != EMapMarkType.Quest)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "[LevelEventFocusOnMapMark]未定义类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MapMarkType", focusOnMapMarkAction.MapMarkType.Type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.Finish();
				return;
			}
			this.HandleQuestMapFocus(focusOnMapMarkAction.MapMarkType as IFocusOnQuestMapMark);
		}

		// Token: 0x0603A26B RID: 238187 RVA: 0x010662AC File Offset: 0x010644AC
		private void HandleCustomMapFocus(IFocusOnCustomMapMark param)
		{
			int markId = param.MarkId;
			OneOf<MapMark, DynamicMapMark>? oneOf = MapConfig.Instance.SearchMarkConfig(markId);
			if (oneOf == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "[LevelEventFocusOnMapMark]HandleCustomMapFocus->找不到对应的标记配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("markId", markId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				WorldMapViewOpenParams worldMapViewOpenParams = new WorldMapViewOpenParams();
				worldMapViewOpenParams.MarkId = new int?(markId);
				worldMapViewOpenParams.MarkType = (EMarkType)oneOf.Value.Match<int>((MapMark mark) => mark.ObjectType, (DynamicMapMark mark) => mark.ObjectType);
				WorldMapViewOpenParams data = worldMapViewOpenParams;
				WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
			}
			base.Finish();
		}

		// Token: 0x0603A26C RID: 238188 RVA: 0x01066380 File Offset: 0x01064580
		private void HandleQuestMapFocus(IFocusOnQuestMapMark param)
		{
			int questId = param.QuestId;
			QuestMarkCreateInfo markByQuestId = MapModel.Instance.GetMarkByQuestId(questId);
			if (markByQuestId == null)
			{
				WorldMapController.Instance.StartListenChildQuestNodeStatusChangedAndOpenWorldMap(questId);
				base.Finish();
				return;
			}
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = markByQuestId.MarkId,
				MarkType = markByQuestId.MarkType
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, delegate(bool _, int _)
			{
				EventSystem.Instance.Emit<int>(EEventName.WorldMapOpenedForQuestMapFocus, questId);
			});
			base.Finish();
		}
	}
}
