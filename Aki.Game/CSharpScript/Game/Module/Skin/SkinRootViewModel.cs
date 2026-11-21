using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Skin.Skip;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin
{
	// Token: 0x02003B91 RID: 15249
	[NullableContext(1)]
	[Nullable(0)]
	public class SkinRootViewModel : ViewModelBase<ESkinRootViewData>
	{
		// Token: 0x06027137 RID: 160055 RVA: 0x00AEF47C File Offset: 0x00AED67C
		public SkinRootViewModel()
		{
			this.DataMap.Add(ESkinRootViewData.CurSelectTabViewName, null);
			this.DataMap.Add(ESkinRootViewData.RootUiVisible, true);
			this.DataMap.Add(ESkinRootViewData.MoveGamepadKeyTipActive, true);
			this.DataMap.Add(ESkinRootViewData.GamePadKeyTipRefresh, true);
			this.DataMap.Add(ESkinRootViewData.ModelState, null);
			this.DataMap.Add(ESkinRootViewData.SelectTabViewName, null);
		}

		// Token: 0x1700500F RID: 20495
		// (get) Token: 0x06027138 RID: 160056 RVA: 0x00AEF532 File Offset: 0x00AED732
		public ISkinViewData ViewData
		{
			get
			{
				return this.ViewDataInternal;
			}
		}

		// Token: 0x17005010 RID: 20496
		// (get) Token: 0x06027139 RID: 160057 RVA: 0x00AEF53A File Offset: 0x00AED73A
		public int RoleId
		{
			get
			{
				return this.RoleIdInternal;
			}
		}

		// Token: 0x17005011 RID: 20497
		// (get) Token: 0x0602713A RID: 160058 RVA: 0x00AEF542 File Offset: 0x00AED742
		public int WeaponIncId
		{
			get
			{
				return this.WeaponIncIdInternal;
			}
		}

		// Token: 0x17005012 RID: 20498
		// (get) Token: 0x0602713B RID: 160059 RVA: 0x00AEF54A File Offset: 0x00AED74A
		public bool NeedLoadRole
		{
			get
			{
				return this.NeedLoadRoleInternal;
			}
		}

		// Token: 0x0602713C RID: 160060 RVA: 0x00AEF552 File Offset: 0x00AED752
		public void SetCurSelectTabViewName(EUiTabViewName curSelectTabViewName, bool notNotify = false)
		{
			base.SetData(ESkinRootViewData.CurSelectTabViewName, curSelectTabViewName, notNotify);
		}

		// Token: 0x0602713D RID: 160061 RVA: 0x00AEF562 File Offset: 0x00AED762
		public EUiTabViewName GetCurSelectTabViewName()
		{
			return (EUiTabViewName)base.GetData(ESkinRootViewData.CurSelectTabViewName);
		}

		// Token: 0x0602713E RID: 160062 RVA: 0x00AEF570 File Offset: 0x00AED770
		public void SetRootUiVisible(bool visible, bool notNotify = false)
		{
			base.SetData(ESkinRootViewData.RootUiVisible, visible, notNotify);
		}

		// Token: 0x0602713F RID: 160063 RVA: 0x00AEF580 File Offset: 0x00AED780
		public bool GetRootUiVisible()
		{
			return (bool)base.GetData(ESkinRootViewData.RootUiVisible);
		}

		// Token: 0x06027140 RID: 160064 RVA: 0x00AEF58E File Offset: 0x00AED78E
		public void SetMoveGamepadKeyTipActive(bool isMoveGamepadKeyTipActive, bool notNotify = false)
		{
			base.SetData(ESkinRootViewData.MoveGamepadKeyTipActive, isMoveGamepadKeyTipActive, notNotify);
		}

		// Token: 0x06027141 RID: 160065 RVA: 0x00AEF59E File Offset: 0x00AED79E
		public bool GetMoveGamepadKeyTipActive()
		{
			return (bool)base.GetData(ESkinRootViewData.MoveGamepadKeyTipActive);
		}

		// Token: 0x06027142 RID: 160066 RVA: 0x00AEF5AC File Offset: 0x00AED7AC
		public void SetSelectTabViewName(EUiTabViewName curSelectTabViewName, bool notNotify = false)
		{
			base.SetData(ESkinRootViewData.SelectTabViewName, curSelectTabViewName, notNotify);
		}

		// Token: 0x06027143 RID: 160067 RVA: 0x00AEF5BC File Offset: 0x00AED7BC
		public EUiTabViewName? GetSelectTabViewName()
		{
			return (EUiTabViewName?)base.GetData(ESkinRootViewData.SelectTabViewName);
		}

		// Token: 0x06027144 RID: 160068 RVA: 0x00AEF5CC File Offset: 0x00AED7CC
		public void SetModelState(EModelStateInSkinView modelState, bool notNotify = false)
		{
			EModelStateInSkinView? modelState2 = this.GetModelState();
			if (modelState2.GetValueOrDefault() == modelState & modelState2 != null)
			{
				return;
			}
			base.SetData(ESkinRootViewData.ModelState, modelState, notNotify);
		}

		// Token: 0x06027145 RID: 160069 RVA: 0x00AEF605 File Offset: 0x00AED805
		public EModelStateInSkinView? GetModelState()
		{
			return (EModelStateInSkinView?)base.GetData(ESkinRootViewData.ModelState);
		}

		// Token: 0x06027146 RID: 160070 RVA: 0x00AEF613 File Offset: 0x00AED813
		public void NotifyGamePadKeyTipRefresh()
		{
			base.SetData(ESkinRootViewData.GamePadKeyTipRefresh, true, false);
		}

		// Token: 0x06027147 RID: 160071 RVA: 0x00AEF624 File Offset: 0x00AED824
		public void Init(ISkinViewData viewData)
		{
			this.ViewDataInternal = viewData;
			this.RoleIdInternal = viewData.RoleId;
			this.WeaponIncIdInternal = viewData.WeaponId;
			this.NeedLoadRoleInternal = viewData.NeedLoadRole;
			this.SetCurSelectTabViewName(viewData.TabViewName, true);
			if (viewData.OrnamentSkinId != null || viewData.OrnamentId != null)
			{
				this.SetTabViewParam(new SkinTabViewParam
				{
					SkinId = viewData.OrnamentSkinId,
					OrnamentId = viewData.OrnamentId
				});
			}
		}

		// Token: 0x06027148 RID: 160072 RVA: 0x00AEF6AC File Offset: 0x00AED8AC
		public void SetGetDragItemFunc(Func<UUIDraggableComponent> getDragItemFunc)
		{
			this.GetDragItemFunc = getDragItemFunc;
		}

		// Token: 0x06027149 RID: 160073 RVA: 0x00AEF6B5 File Offset: 0x00AED8B5
		public UUIDraggableComponent GetDragItem()
		{
			Func<UUIDraggableComponent> getDragItemFunc = this.GetDragItemFunc;
			if (getDragItemFunc == null)
			{
				return null;
			}
			return getDragItemFunc();
		}

		// Token: 0x17005013 RID: 20499
		// (get) Token: 0x0602714A RID: 160074 RVA: 0x00AEF6C8 File Offset: 0x00AED8C8
		public bool IsMainRole
		{
			get
			{
				return RoleModel.Instance.IsMainRole(this.RoleIdInternal);
			}
		}

		// Token: 0x0602714B RID: 160075 RVA: 0x00AEF6DA File Offset: 0x00AED8DA
		public bool IsShowHelpBtn(EUiTabViewName viewName)
		{
			return this.HelpIdMapInternal.ContainsKey(viewName);
		}

		// Token: 0x0602714C RID: 160076 RVA: 0x00AEF6E8 File Offset: 0x00AED8E8
		public int? GetHelpId(EUiTabViewName viewName)
		{
			int value;
			if (this.HelpIdMapInternal.TryGetValue(viewName, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x0602714D RID: 160077 RVA: 0x00AEF718 File Offset: 0x00AED918
		public List<ISkinSkipData> GetSkinSkipDataList(int skinId, IReadOnlyList<int> itemAccess)
		{
			List<ISkinSkipData> list = new List<ISkinSkipData>();
			foreach (int num in itemAccess)
			{
				AccessPath? configById = GetWayConfig.Instance.GetConfigById(num);
				if (configById != null)
				{
					SkinSkipData item = new SkinSkipData
					{
						Id = num,
						ConfigId = skinId,
						Type = (ESkinSkipType)configById.Value.Type,
						Text = configById.Value.Description,
						SortIndex = configById.Value.SortIndex
					};
					list.Add(item);
				}
			}
			list.Sort(delegate(ISkinSkipData aSkipData, ISkinSkipData bSkipData)
			{
				int sortIndex = aSkipData.SortIndex;
				int sortIndex2 = bSkipData.SortIndex;
				if (sortIndex == sortIndex2)
				{
					return bSkipData.Id - aSkipData.Id;
				}
				return sortIndex2 - sortIndex;
			});
			return list;
		}

		// Token: 0x0602714E RID: 160078 RVA: 0x00AEF7FC File Offset: 0x00AED9FC
		public void SetCaptionItemActive(bool state)
		{
			if (state)
			{
				this.SetRootUiVisible(true, false);
				return;
			}
			this.SetRootUiVisible(false, false);
		}

		// Token: 0x0602714F RID: 160079 RVA: 0x00AEF814 File Offset: 0x00AEDA14
		public ERedDotName? GetTabRedDotName(EUiTabViewName tabViewName)
		{
			if (tabViewName == EUiTabViewName.FlySkinTabView)
			{
				return new ERedDotName?(ERedDotName.FlySkinTab);
			}
			if (tabViewName == EUiTabViewName.CalabashSkinTabView)
			{
				return new ERedDotName?(ERedDotName.HuluSkinTab);
			}
			if (tabViewName == EUiTabViewName.RoleOrnamentTabView)
			{
				return new ERedDotName?(ERedDotName.RoleOrnamentTab);
			}
			return null;
		}

		// Token: 0x06027150 RID: 160080 RVA: 0x00AEF86C File Offset: 0x00AEDA6C
		public int? GetTabRedDotUid(EUiTabViewName tabViewName)
		{
			if (tabViewName == EUiTabViewName.RoleOrnamentTabView)
			{
				return new int?(this.RoleIdInternal);
			}
			return null;
		}

		// Token: 0x06027151 RID: 160081 RVA: 0x00AEF89B File Offset: 0x00AEDA9B
		public void SetTabViewParam(SkinTabViewParam value)
		{
			this.TabViewParam = value;
		}

		// Token: 0x06027152 RID: 160082 RVA: 0x00AEF8A4 File Offset: 0x00AEDAA4
		[NullableContext(2)]
		public SkinTabViewParam GetTabViewParam()
		{
			SkinTabViewParam tabViewParam = this.TabViewParam;
			this.TabViewParam = null;
			return tabViewParam;
		}

		// Token: 0x06027153 RID: 160083 RVA: 0x00AEF8B4 File Offset: 0x00AEDAB4
		public void TryShowRoleSystemRoleActor()
		{
			if (this.TsUiSceneRoleActor == null)
			{
				return;
			}
			UiModelBase model = this.TsUiSceneRoleActor.Model;
			if (model == null)
			{
				return;
			}
			UiModelUtil.Instance.SetVisible(model, true);
		}

		// Token: 0x06027154 RID: 160084 RVA: 0x00AEF8E7 File Offset: 0x00AEDAE7
		public void ConfigureCameraInput(UiCameraInputBindingData data)
		{
			this.CameraInputBinding.Configure(data);
		}

		// Token: 0x06027155 RID: 160085 RVA: 0x00AEF8F5 File Offset: 0x00AEDAF5
		public void BindCameraInput()
		{
			this.CameraInputBinding.Bind();
		}

		// Token: 0x06027156 RID: 160086 RVA: 0x00AEF902 File Offset: 0x00AEDB02
		public void UnbindCameraInput()
		{
			this.CameraInputBinding.Unbind();
		}

		// Token: 0x04015509 RID: 87305
		private ISkinViewData ViewDataInternal;

		// Token: 0x0401550A RID: 87306
		private int WeaponIncIdInternal;

		// Token: 0x0401550B RID: 87307
		private int RoleIdInternal;

		// Token: 0x0401550C RID: 87308
		private Func<UUIDraggableComponent> GetDragItemFunc;

		// Token: 0x0401550D RID: 87309
		private bool NeedLoadRoleInternal;

		// Token: 0x0401550E RID: 87310
		private readonly Dictionary<EUiTabViewName, int> HelpIdMapInternal = new Dictionary<EUiTabViewName, int>
		{
			{
				EUiTabViewName.RoleSkinTabView,
				146
			},
			{
				EUiTabViewName.CalabashSkinTabView,
				387
			},
			{
				EUiTabViewName.RoleOrnamentTabView,
				571
			}
		};

		// Token: 0x0401550F RID: 87311
		public TsUiSceneRoleActor TsUiSceneRoleActor;

		// Token: 0x04015510 RID: 87312
		public UiCameraInputBinding CameraInputBinding = new UiCameraInputBinding();

		// Token: 0x04015511 RID: 87313
		[Nullable(2)]
		private SkinTabViewParam TabViewParam;
	}
}
