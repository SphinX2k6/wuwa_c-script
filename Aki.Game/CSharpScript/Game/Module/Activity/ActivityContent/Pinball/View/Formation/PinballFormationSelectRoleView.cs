using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x020052E7 RID: 21223
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballFormationSelectRoleView : UiViewBase
	{
		// Token: 0x06034D09 RID: 216329 RVA: 0x00EC34DD File Offset: 0x00EC16DD
		public PinballFormationSelectRoleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06034D0A RID: 216330 RVA: 0x00EC34E8 File Offset: 0x00EC16E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIMultiTemplateLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickLeftBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickRightBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickCloseBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06034D0B RID: 216331 RVA: 0x00EC376C File Offset: 0x00EC196C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballFormationSelectRoleView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballFormationSelectRoleView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034D0C RID: 216332 RVA: 0x00EC37AF File Offset: 0x00EC19AF
		private RoleTagItem CreateTagItem()
		{
			return new RoleTagItem();
		}

		// Token: 0x06034D0D RID: 216333 RVA: 0x00EC37B6 File Offset: 0x00EC19B6
		private RoleSkillItem CreateSkillItem()
		{
			return new RoleSkillItem();
		}

		// Token: 0x06034D0E RID: 216334 RVA: 0x00EC37C0 File Offset: 0x00EC19C0
		private void InitFilterSortEntrance()
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			this.FilterSortComponent = new FilterSortEntrance<int>(item, delegate(List<int> list, bool isOutSideChange, EFilterSortType operationType)
			{
				this.OnFilterSortRefresh(list, isOutSideChange, operationType);
			});
		}

		// Token: 0x06034D0F RID: 216335 RVA: 0x00EC37F1 File Offset: 0x00EC19F1
		protected override void OnBeforeDestroy()
		{
			PinballModel.Instance.SelectRoleHandleList = new List<int>();
		}

		// Token: 0x06034D10 RID: 216336 RVA: 0x00EC3804 File Offset: 0x00EC1A04
		protected override void OnStart()
		{
			IPinballFormationSelectRoleViewData pinballFormationSelectRoleViewData = this.OpenParam as IPinballFormationSelectRoleViewData;
			this.OnConfirm = pinballFormationSelectRoleViewData.OnConfirm;
			this.RefreshRoleInfo(pinballFormationSelectRoleViewData.OpenRole.GetValueOrDefault());
			FilterSortEntrance<int> filterSortComponent = this.FilterSortComponent;
			if (filterSortComponent == null)
			{
				return;
			}
			filterSortComponent.UpdateData(EFilterSortGroupId.PinballFormation, pinballFormationSelectRoleViewData.RoleList, Array.Empty<object>());
		}

		// Token: 0x06034D11 RID: 216337 RVA: 0x00EC385C File Offset: 0x00EC1A5C
		protected override void OnBeforeShow()
		{
			base.GetButton(9).RootUIComp.Get().SetUIActive(PinballModel.Instance.IsRoleFunctionOpen());
			this.RefreshRoleScrollView();
		}

		// Token: 0x06034D12 RID: 216338 RVA: 0x00EC3894 File Offset: 0x00EC1A94
		private void OnFilterSortRefresh(List<int> list, bool isOutSideChange, EFilterSortType operationType)
		{
			this.RefreshRoleList(new List<int>(list));
		}

		// Token: 0x06034D13 RID: 216339 RVA: 0x00EC38AF File Offset: 0x00EC1AAF
		private PinballFormationSelectRoleItem OnGridProxyCreate()
		{
			PinballFormationSelectRoleItem pinballFormationSelectRoleItem = new PinballFormationSelectRoleItem();
			pinballFormationSelectRoleItem.BindOnStateChangeCallback(new Action<IPinballItemToggleCallback>(this.OnClickRoleItem));
			pinballFormationSelectRoleItem.BindOnCanExecuteChangeCallback(new Func<IPinballItemToggleCallback, bool>(this.CanExecuteChange));
			return pinballFormationSelectRoleItem;
		}

		// Token: 0x06034D14 RID: 216340 RVA: 0x00EC38DA File Offset: 0x00EC1ADA
		private void RefreshRoleList(List<int> roleIdList)
		{
			this.RoleList = roleIdList;
			this.RecommendRoleList = (this.OpenParam as IPinballFormationSelectRoleViewData).RecommendRoleList;
			this.RefreshRoleScrollView();
		}

		// Token: 0x06034D15 RID: 216341 RVA: 0x00EC3900 File Offset: 0x00EC1B00
		private void RefreshRoleScrollView()
		{
			List<IPinballItemDataRole> list = new List<IPinballItemDataRole>();
			foreach (int num in this.RoleList)
			{
				PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(num);
				PinballItemDataRole item = new PinballItemDataRole
				{
					Type = EPinballItemType.Role,
					Id = num,
					IsRecommend = new bool?(this.RecommendRoleList.Contains(num)),
					BdId = new int?(pinballRoleConfigById.Value.Bd),
					BottomPlainText = "Lv." + PinballModel.Instance.GetRoleLevel(num).ToString(),
					ClassId = new int?(pinballRoleConfigById.Value.PinballClass(0))
				};
				list.Add(item);
			}
			LoopScrollView<PinballFormationSelectRoleItem, IPinballItemDataRole> roleScrollView = this.RoleScrollView;
			if (roleScrollView == null)
			{
				return;
			}
			roleScrollView.RefreshByDataAsync(list, false, true).Forget();
		}

		// Token: 0x06034D16 RID: 216342 RVA: 0x00EC3A0C File Offset: 0x00EC1C0C
		private void RefreshRoleInfo(int roleId)
		{
			this.CurrentShowRoleId = roleId;
			if (roleId == 0)
			{
				base.GetText(12).SetUIActive(false);
				base.GetSprite(4).SetUIActive(false);
				base.GetItem(13).SetUIActive(true);
				return;
			}
			base.GetItem(13).SetUIActive(false);
			PinballConfig instance = PinballConfig.Instance;
			PinballRoleConfig? pinballRoleConfig = (instance != null) ? instance.GetPinballRoleConfigById(roleId) : null;
			if (pinballRoleConfig == null)
			{
				return;
			}
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(pinballRoleConfig.Value.RoleId);
			if (roleConfig == null)
			{
				return;
			}
			base.GetText(12).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), roleConfig.Value.Name, Array.Empty<object>());
			int selectRoleFormationNumber = PinballModel.Instance.GetSelectRoleFormationNumber(roleId);
			if (selectRoleFormationNumber == 0)
			{
				base.GetSprite(4).SetUIActive(false);
			}
			else
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_ComItemNum0" + selectRoleFormationNumber.ToString());
				this.SetSpriteByPath(resourcePath, base.GetSprite(4), true, null, delegate(bool _)
				{
					base.GetSprite(4).SetUIActive(true);
				});
			}
			List<IRoleTagItemData> list = new List<IRoleTagItemData>();
			list.Add(new RoleTagItemData
			{
				Type = ETagType.BD,
				ConfigId = pinballRoleConfig.Value.Bd
			});
			int pinballClassLength = pinballRoleConfig.Value.PinballClassLength;
			for (int i = 0; i < pinballClassLength; i++)
			{
				int configId = pinballRoleConfig.Value.PinballClass(i);
				list.Add(new RoleTagItemData
				{
					Type = ETagType.Class,
					ConfigId = configId
				});
			}
			GenericLayout<RoleTagItem, IRoleTagItemData> roleTagLayout = this.RoleTagLayout;
			if (roleTagLayout != null)
			{
				roleTagLayout.RefreshByData(list, null, false);
			}
			List<IRoleSkillItemData> list2 = new List<IRoleSkillItemData>();
			bool flag = true;
			int skillDisplayListLength = pinballRoleConfig.Value.SkillDisplayListLength;
			for (int j = 0; j < skillDisplayListLength; j++)
			{
				int configId2 = pinballRoleConfig.Value.SkillDisplayList(j);
				list2.Add(new RoleSkillItemData
				{
					IsLeader = (selectRoleFormationNumber == 1 && flag),
					ConfigId = configId2
				});
				flag = false;
			}
			base.GetScrollViewWithScrollbar(7).RootUIComp.Get().SetUIActive(true);
			GenericScrollViewNew<RoleSkillItem, IRoleSkillItemData> roleSkillScrollView = this.RoleSkillScrollView;
			if (roleSkillScrollView == null)
			{
				return;
			}
			roleSkillScrollView.RefreshByData(list2, null, false);
		}

		// Token: 0x06034D17 RID: 216343 RVA: 0x00EC3C64 File Offset: 0x00EC1E64
		private void OnClickLeftBtn()
		{
			PinballRoleViewOpenParam param = new PinballRoleViewOpenParam
			{
				RoleId = ((this.CurrentShowRoleId > 0) ? new int?(this.CurrentShowRoleId) : null),
				FormationRoleIds = PinballModel.Instance.SelectRoleHandleList.ToArray()
			};
			UiManager.Instance.OpenView(EUiViewName.PinballRoleView, param, null);
		}

		// Token: 0x06034D18 RID: 216344 RVA: 0x00EC3CC2 File Offset: 0x00EC1EC2
		private void OnClickRightBtn()
		{
			Action<List<int>> onConfirm = this.OnConfirm;
			if (onConfirm != null)
			{
				onConfirm(PinballModel.Instance.SelectRoleHandleList);
			}
			base.CloseMe(null);
		}

		// Token: 0x06034D19 RID: 216345 RVA: 0x00EC3CE6 File Offset: 0x00EC1EE6
		private void OnClickCloseBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06034D1A RID: 216346 RVA: 0x00EC3CF0 File Offset: 0x00EC1EF0
		private void OnClickRoleItem(IPinballItemToggleCallback @params)
		{
			int id = (@params.Data as IPinballItemDataRole).Id;
			if (@params.State == EToggleState.ETT_UnChecked)
			{
				PinballModel.Instance.UnSelectRoleInHandleList(id);
				int gridIndex = this.RoleList.IndexOf(id);
				this.RoleScrollView.RefreshGridProxy(gridIndex);
			}
			else if (@params.State == EToggleState.ETT_Checked)
			{
				PinballModel.Instance.SelectRoleInHandleList(id);
			}
			this.RefreshRoleInfo(id);
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequence("Switch", false, null);
			}
			foreach (int item in PinballModel.Instance.SelectRoleHandleList)
			{
				int gridIndex2 = this.RoleList.IndexOf(item);
				this.RoleScrollView.RefreshGridProxy(gridIndex2);
			}
			this.RefreshConfirmBtn();
		}

		// Token: 0x06034D1B RID: 216347 RVA: 0x00EC3DE0 File Offset: 0x00EC1FE0
		protected bool CanExecuteChange(IPinballItemToggleCallback @params)
		{
			if (@params.State != EToggleState.ETT_UnChecked)
			{
				return true;
			}
			if (PinballModel.Instance.SelectRoleHandleList.Count >= 3)
			{
				ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamRoleFull", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x06034D1C RID: 216348 RVA: 0x00EC3E1C File Offset: 0x00EC201C
		private void RefreshConfirmBtn()
		{
			List<int> selectRoleHandleList = PinballModel.Instance.SelectRoleHandleList;
			base.GetButton(10).SetSelfInteractive(selectRoleHandleList.Count > 0 && selectRoleHandleList.Count <= 3);
		}

		// Token: 0x06034D1D RID: 216349 RVA: 0x00EC3E5C File Offset: 0x00EC205C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length < 2 || configParams[0] != "Role")
			{
				return null;
			}
			int num = int.Parse(configParams[1]);
			if (num < 0 || num >= this.RoleList.Count)
			{
				return null;
			}
			LoopScrollView<PinballFormationSelectRoleItem, IPinballItemDataRole> roleScrollView = this.RoleScrollView;
			if (roleScrollView != null)
			{
				roleScrollView.ScrollToGridIndex(num, false);
			}
			LoopScrollView<PinballFormationSelectRoleItem, IPinballItemDataRole> roleScrollView2 = this.RoleScrollView;
			PinballFormationSelectRoleItem pinballFormationSelectRoleItem = (roleScrollView2 != null) ? roleScrollView2.UnsafeGetGridProxy(num, false) : null;
			UUIItem uuiitem = (pinballFormationSelectRoleItem != null) ? pinballFormationSelectRoleItem.GetRoleItemToggleRootUiItem() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x0401BF16 RID: 114454
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BF17 RID: 114455
		private List<int> RoleList;

		// Token: 0x0401BF18 RID: 114456
		private List<int> RecommendRoleList;

		// Token: 0x0401BF19 RID: 114457
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected LoopScrollView<PinballFormationSelectRoleItem, IPinballItemDataRole> RoleScrollView;

		// Token: 0x0401BF1A RID: 114458
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<List<int>> OnConfirm;

		// Token: 0x0401BF1B RID: 114459
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoleTagItem, IRoleTagItemData> RoleTagLayout;

		// Token: 0x0401BF1C RID: 114460
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoleSkillItem, IRoleSkillItemData> RoleSkillScrollView;

		// Token: 0x0401BF1D RID: 114461
		[Nullable(2)]
		private FilterSortEntrance<int> FilterSortComponent;

		// Token: 0x0401BF1E RID: 114462
		private int CurrentShowRoleId;

		// Token: 0x0200AF69 RID: 44905
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036334 RID: 222004
			CaptionItem,
			// Token: 0x04036335 RID: 222005
			RoleLoopScrollView,
			// Token: 0x04036336 RID: 222006
			RoleItem,
			// Token: 0x04036337 RID: 222007
			SortFilterItem,
			// Token: 0x04036338 RID: 222008
			NumberSprite,
			// Token: 0x04036339 RID: 222009
			RoleTagLayout,
			// Token: 0x0403633A RID: 222010
			RoleTagItem,
			// Token: 0x0403633B RID: 222011
			RoleDesScrollView,
			// Token: 0x0403633C RID: 222012
			RoleDesItem,
			// Token: 0x0403633D RID: 222013
			LeftBtn,
			// Token: 0x0403633E RID: 222014
			RightBtn,
			// Token: 0x0403633F RID: 222015
			CloseBtn,
			// Token: 0x04036340 RID: 222016
			RoleNameText,
			// Token: 0x04036341 RID: 222017
			EmptyItem
		}
	}
}
