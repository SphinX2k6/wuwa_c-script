using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.Skin.Skip;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin
{
	// Token: 0x02004BE4 RID: 19428
	[NullableContext(1)]
	[Nullable(0)]
	public class SkinRootViewModel : ViewModelBase<ESkinRootViewData>
	{
		// Token: 0x060323A5 RID: 205733 RVA: 0x00BAB090 File Offset: 0x00BA9290
		public SkinRootViewModel()
		{
			this.DataMap.Add(ESkinRootViewData.CurSelectTabViewName, null);
			this.DataMap.Add(ESkinRootViewData.RootUiVisible, true);
			this.DataMap.Add(ESkinRootViewData.MoveGamepadKeyTipActive, true);
			this.DataMap.Add(ESkinRootViewData.GamePadKeyTipRefresh, true);
			this.DataMap.Add(ESkinRootViewData.ModelState, null);
			this.DataMap.Add(ESkinRootViewData.SelectTabViewName, null);
		}

		// Token: 0x17007C65 RID: 31845
		// (get) Token: 0x060323A6 RID: 205734 RVA: 0x00BAB146 File Offset: 0x00BA9346
		public ISkinViewData ViewData
		{
			get
			{
				return this.ViewDataInternal;
			}
		}

		// Token: 0x17007C66 RID: 31846
		// (get) Token: 0x060323A7 RID: 205735 RVA: 0x00BAB14E File Offset: 0x00BA934E
		public int RoleId
		{
			get
			{
				return this.RoleIdInternal;
			}
		}

		// Token: 0x17007C67 RID: 31847
		// (get) Token: 0x060323A8 RID: 205736 RVA: 0x00BAB156 File Offset: 0x00BA9356
		public int WeaponIncId
		{
			get
			{
				return this.WeaponIncIdInternal;
			}
		}

		// Token: 0x17007C68 RID: 31848
		// (get) Token: 0x060323A9 RID: 205737 RVA: 0x00BAB15E File Offset: 0x00BA935E
		public bool NeedLoadRole
		{
			get
			{
				return this.NeedLoadRoleInternal;
			}
		}

		// Token: 0x060323AA RID: 205738 RVA: 0x00BAB166 File Offset: 0x00BA9366
		public void SetCurSelectTabViewName(EUiTabViewName curSelectTabViewName, bool notNotify = false)
		{
			base.SetData(ESkinRootViewData.CurSelectTabViewName, curSelectTabViewName, notNotify);
		}

		// Token: 0x060323AB RID: 205739 RVA: 0x00BAB176 File Offset: 0x00BA9376
		public EUiTabViewName GetCurSelectTabViewName()
		{
			return (EUiTabViewName)base.GetData(ESkinRootViewData.CurSelectTabViewName);
		}

		// Token: 0x060323AC RID: 205740 RVA: 0x00BAB184 File Offset: 0x00BA9384
		public void SetRootUiVisible(bool visible, bool notNotify = false)
		{
			base.SetData(ESkinRootViewData.RootUiVisible, visible, notNotify);
		}

		// Token: 0x060323AD RID: 205741 RVA: 0x00BAB194 File Offset: 0x00BA9394
		public bool GetRootUiVisible()
		{
			return (bool)base.GetData(ESkinRootViewData.RootUiVisible);
		}

		// Token: 0x060323AE RID: 205742 RVA: 0x00BAB1A2 File Offset: 0x00BA93A2
		public void SetMoveGamepadKeyTipActive(bool isMoveGamepadKeyTipActive, bool notNotify = false)
		{
			base.SetData(ESkinRootViewData.MoveGamepadKeyTipActive, isMoveGamepadKeyTipActive, notNotify);
		}

		// Token: 0x060323AF RID: 205743 RVA: 0x00BAB1B2 File Offset: 0x00BA93B2
		public bool GetMoveGamepadKeyTipActive()
		{
			return (bool)base.GetData(ESkinRootViewData.MoveGamepadKeyTipActive);
		}

		// Token: 0x060323B0 RID: 205744 RVA: 0x00BAB1C0 File Offset: 0x00BA93C0
		public void SetSelectTabViewName(EUiTabViewName curSelectTabViewName, bool notNotify = false)
		{
			base.SetData(ESkinRootViewData.SelectTabViewName, curSelectTabViewName, notNotify);
		}

		// Token: 0x060323B1 RID: 205745 RVA: 0x00BAB1D0 File Offset: 0x00BA93D0
		public EUiTabViewName? GetSelectTabViewName()
		{
			return (EUiTabViewName?)base.GetData(ESkinRootViewData.SelectTabViewName);
		}

		// Token: 0x060323B2 RID: 205746 RVA: 0x00BAB1E0 File Offset: 0x00BA93E0
		public void SetModelState(EModelStateInSkinView modelState, bool notNotify = false)
		{
			EModelStateInSkinView? modelState2 = this.GetModelState();
			if (modelState2.GetValueOrDefault() == modelState & modelState2 != null)
			{
				return;
			}
			base.SetData(ESkinRootViewData.ModelState, modelState, notNotify);
		}

		// Token: 0x060323B3 RID: 205747 RVA: 0x00BAB219 File Offset: 0x00BA9419
		public EModelStateInSkinView? GetModelState()
		{
			return (EModelStateInSkinView?)base.GetData(ESkinRootViewData.ModelState);
		}

		// Token: 0x060323B4 RID: 205748 RVA: 0x00BAB227 File Offset: 0x00BA9427
		public void NotifyGamePadKeyTipRefresh()
		{
			base.SetData(ESkinRootViewData.GamePadKeyTipRefresh, true, false);
		}

		// Token: 0x060323B5 RID: 205749 RVA: 0x00BAB238 File Offset: 0x00BA9438
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

		// Token: 0x060323B6 RID: 205750 RVA: 0x00BAB2C0 File Offset: 0x00BA94C0
		public void SetGetDragItemFunc(Func<UUIDraggableComponent> getDragItemFunc)
		{
			this.GetDragItemFunc = getDragItemFunc;
		}

		// Token: 0x060323B7 RID: 205751 RVA: 0x00BAB2C9 File Offset: 0x00BA94C9
		public UUIDraggableComponent GetDragItem()
		{
			Func<UUIDraggableComponent> getDragItemFunc = this.GetDragItemFunc;
			if (getDragItemFunc == null)
			{
				return null;
			}
			return getDragItemFunc();
		}

		// Token: 0x17007C69 RID: 31849
		// (get) Token: 0x060323B8 RID: 205752 RVA: 0x00BAB2DC File Offset: 0x00BA94DC
		public bool IsMainRole
		{
			get
			{
				return RoleModel.Instance.IsMainRole(this.RoleIdInternal);
			}
		}

		// Token: 0x060323B9 RID: 205753 RVA: 0x00BAB2EE File Offset: 0x00BA94EE
		public bool IsShowHelpBtn(EUiTabViewName viewName)
		{
			return this.HelpIdMapInternal.ContainsKey(viewName);
		}

		// Token: 0x060323BA RID: 205754 RVA: 0x00BAB2FC File Offset: 0x00BA94FC
		public int? GetHelpId(EUiTabViewName viewName)
		{
			int value;
			if (this.HelpIdMapInternal.TryGetValue(viewName, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x060323BB RID: 205755 RVA: 0x00BAB32C File Offset: 0x00BA952C
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

		// Token: 0x060323BC RID: 205756 RVA: 0x00BAB410 File Offset: 0x00BA9610
		public void SetCaptionItemActive(bool state)
		{
			if (state)
			{
				this.SetRootUiVisible(true, false);
				return;
			}
			this.SetRootUiVisible(false, false);
		}

		// Token: 0x060323BD RID: 205757 RVA: 0x00BAB428 File Offset: 0x00BA9628
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

		// Token: 0x060323BE RID: 205758 RVA: 0x00BAB480 File Offset: 0x00BA9680
		public int? GetTabRedDotUid(EUiTabViewName tabViewName)
		{
			if (tabViewName == EUiTabViewName.RoleOrnamentTabView)
			{
				return new int?(this.RoleIdInternal);
			}
			return null;
		}

		// Token: 0x060323BF RID: 205759 RVA: 0x00BAB4AF File Offset: 0x00BA96AF
		public void SetTabViewParam(SkinTabViewParam value)
		{
			this.TabViewParam = value;
		}

		// Token: 0x060323C0 RID: 205760 RVA: 0x00BAB4B8 File Offset: 0x00BA96B8
		[NullableContext(2)]
		public SkinTabViewParam GetTabViewParam()
		{
			SkinTabViewParam tabViewParam = this.TabViewParam;
			this.TabViewParam = null;
			return tabViewParam;
		}

		// Token: 0x060323C1 RID: 205761 RVA: 0x00BAB4C8 File Offset: 0x00BA96C8
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

		// Token: 0x060323C2 RID: 205762 RVA: 0x00BAB4FC File Offset: 0x00BA96FC
		public void StartCameraInput(IUiCameraInputComponentData data, bool? canCameraInput = null, bool forceActivate = false)
		{
			if (this.HasCameraInputComponentStartInternal)
			{
				this.CameraInputComponent.TryDeActivate();
				this.CameraInputComponent.UpdateData(data);
				if (canCameraInput != null)
				{
					this.CameraInputComponent.CanCameraInput = canCameraInput.Value;
				}
				this.CameraInputComponent.TryActivate();
				return;
			}
			this.HasCameraInputComponentStartInternal = true;
			this.CameraInputComponent.InitData(data);
			if (canCameraInput != null)
			{
				this.CameraInputComponent.CanCameraInput = canCameraInput.Value;
			}
			this.CameraInputComponent.Start();
			if (forceActivate)
			{
				this.CameraInputComponent.Activate();
				return;
			}
			this.CameraInputComponent.TryActivate();
		}

		// Token: 0x060323C3 RID: 205763 RVA: 0x00BAB5A5 File Offset: 0x00BA97A5
		public void EndCameraInput()
		{
			if (!this.HasCameraInputComponentStartInternal)
			{
				return;
			}
			this.HasCameraInputComponentStartInternal = false;
			this.CameraInputComponent.End();
		}

		// Token: 0x060323C4 RID: 205764 RVA: 0x00BAB5C2 File Offset: 0x00BA97C2
		public void SetCameraInputCanInput(bool canCameraInput)
		{
			this.CameraInputComponent.CanCameraInput = canCameraInput;
		}

		// Token: 0x0401ABAD RID: 109485
		private ISkinViewData ViewDataInternal;

		// Token: 0x0401ABAE RID: 109486
		private int WeaponIncIdInternal;

		// Token: 0x0401ABAF RID: 109487
		private int RoleIdInternal;

		// Token: 0x0401ABB0 RID: 109488
		private Func<UUIDraggableComponent> GetDragItemFunc;

		// Token: 0x0401ABB1 RID: 109489
		private bool NeedLoadRoleInternal;

		// Token: 0x0401ABB2 RID: 109490
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

		// Token: 0x0401ABB3 RID: 109491
		public TsUiSceneRoleActor TsUiSceneRoleActor;

		// Token: 0x0401ABB4 RID: 109492
		public UiCameraInputComponent CameraInputComponent = new UiCameraInputComponent();

		// Token: 0x0401ABB5 RID: 109493
		[Nullable(2)]
		private SkinTabViewParam TabViewParam;

		// Token: 0x0401ABB6 RID: 109494
		private bool HasCameraInputComponentStartInternal;
	}
}
