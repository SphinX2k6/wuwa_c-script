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
	// Token: 0x02006B2D RID: 27437
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventFocusOnMapMark : LevelEventBase
	{
		// Token: 0x06044117 RID: 278807 RVA: 0x010BC982 File Offset: 0x010BAB82
		public LevelEventFocusOnMapMark(int id) : base(id)
		{
		}

		// Token: 0x06044118 RID: 278808 RVA: 0x010BC98C File Offset: 0x010BAB8C
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

		// Token: 0x06044119 RID: 278809 RVA: 0x010BCA20 File Offset: 0x010BAC20
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

		// Token: 0x0604411A RID: 278810 RVA: 0x010BCAF4 File Offset: 0x010BACF4
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
