using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BA8 RID: 27560
	public class LevelEventToggleMapMarkState : LevelEventBase
	{
		// Token: 0x06044306 RID: 279302 RVA: 0x010CE617 File Offset: 0x010CC817
		public LevelEventToggleMapMarkState(int id) : base(id)
		{
		}

		// Token: 0x06044307 RID: 279303 RVA: 0x010CE620 File Offset: 0x010CC820
		private void OnCloseMapView(EUiViewName viewName, int viewId)
		{
			if (viewName == EUiViewName.WorldMapView)
			{
				base.Finish();
				EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseMapView));
			}
		}

		// Token: 0x06044308 RID: 279304 RVA: 0x010CE650 File Offset: 0x010CC850
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ToggleMapMarkState toggleMapMarkState = inParams as ToggleMapMarkState;
			if (toggleMapMarkState == null)
			{
				base.Finish();
				return;
			}
			EMapMarkState type = toggleMapMarkState.Type;
			if (type != EMapMarkState.Show)
			{
				if (type == EMapMarkState.Hide)
				{
					IHideMapMark hideMapMark = toggleMapMarkState as IHideMapMark;
					this.ConditionMarkId(hideMapMark.MarkId);
				}
			}
			else
			{
				IShowMapMark showMapMark = toggleMapMarkState as IShowMapMark;
				if (this.ConditionMarkId(showMapMark.MarkId) && showMapMark.IsFocusOnFirstShow.GetValueOrDefault())
				{
					IMarkShowState markExtraShowState = MapModel.Instance.GetMarkExtraShowState(showMapMark.MarkId);
					if (markExtraShowState.ShowFlag != MapMarkShowFlag.Hide && markExtraShowState.NeedFocus)
					{
						markExtraShowState.NeedFocus = false;
						MapMark? configMark = MapConfig.Instance.GetConfigMark(showMapMark.MarkId);
						if (configMark == null)
						{
							global::Log instance = global::Log.Instance;
							ELogModule module = ELogModule.Map;
							ELogAuthor author = ELogAuthor.LK;
							string message = "缺少MapMark表缺少地图配置";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", showMapMark.MarkId);
							instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
							base.Finish();
							return;
						}
						WorldMapViewOpenParams param = new WorldMapViewOpenParams
						{
							MarkId = new int?(showMapMark.MarkId),
							MarkType = (EMarkType)configMark.Value.ObjectType,
							IsNotFocusTween = new bool?(true)
						};
						UiManager.Instance.OpenView(EUiViewName.WorldMapView, param, delegate(bool _, int _)
						{
							LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, "LevelEventToggleMapMarkState", null, null);
							if (!this.IsAsync)
							{
								EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseMapView));
							}
						});
						if (!this.IsAsync)
						{
							return;
						}
					}
				}
			}
			base.Finish();
		}

		// Token: 0x06044309 RID: 279305 RVA: 0x010CE7B4 File Offset: 0x010CC9B4
		private bool ConditionMarkId(int markId)
		{
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markId);
			return configMark != null && configMark.GetValueOrDefault().ShowCondition == -1;
		}
	}
}
