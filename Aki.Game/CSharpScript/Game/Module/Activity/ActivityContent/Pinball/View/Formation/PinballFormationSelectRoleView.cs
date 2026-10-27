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
	// Token: 0x02006369 RID: 25449
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballFormationSelectRoleView : UiViewBase
	{
		// Token: 0x06040048 RID: 262216 RVA: 0x00F7C57D File Offset: 0x00F7A77D
		public PinballFormationSelectRoleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06040049 RID: 262217 RVA: 0x00F7C588 File Offset: 0x00F7A788
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

		// Token: 0x0604004A RID: 262218 RVA: 0x00F7C80C File Offset: 0x00F7AA0C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballFormationSelectRoleView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballFormationSelectRoleView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604004B RID: 262219 RVA: 0x00F7C84F File Offset: 0x00F7AA4F
		private RoleTagItem CreateTagItem()
		{
			return new RoleTagItem();
		}

		// Token: 0x0604004C RID: 262220 RVA: 0x00F7C856 File Offset: 0x00F7AA56
		private RoleSkillItem CreateSkillItem()
		{
			return new RoleSkillItem();
		}

		// Token: 0x0604004D RID: 262221 RVA: 0x00F7C860 File Offset: 0x00F7AA60
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

		// Token: 0x0604004E RID: 262222 RVA: 0x00F7C891 File Offset: 0x00F7AA91
		protected override void OnBeforeDestroy()
		{
			PinballModel.Instance.SelectRoleHandleList = new List<int>();
		}

		// Token: 0x0604004F RID: 262223 RVA: 0x00F7C8A4 File Offset: 0x00F7AAA4
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

		// Token: 0x06040050 RID: 262224 RVA: 0x00F7C8FC File Offset: 0x00F7AAFC
		protected override void OnBeforeShow()
		{
			base.GetButton(9).RootUIComp.Get().SetUIActive(PinballModel.Instance.IsRoleFunctionOpen());
			this.RefreshRoleScrollView();
		}

		// Token: 0x06040051 RID: 262225 RVA: 0x00F7C934 File Offset: 0x00F7AB34
		private void OnFilterSortRefresh(List<int> list, bool isOutSideChange, EFilterSortType operationType)
		{
			this.RefreshRoleList(new List<int>(list));
		}

		// Token: 0x06040052 RID: 262226 RVA: 0x00F7C94F File Offset: 0x00F7AB4F
		private PinballFormationSelectRoleItem OnGridProxyCreate()
		{
			PinballFormationSelectRoleItem pinballFormationSelectRoleItem = new PinballFormationSelectRoleItem();
			pinballFormationSelectRoleItem.BindOnStateChangeCallback(new Action<IPinballItemToggleCallback>(this.OnClickRoleItem));
			pinballFormationSelectRoleItem.BindOnCanExecuteChangeCallback(new Func<IPinballItemToggleCallback, bool>(this.CanExecuteChange));
			return pinballFormationSelectRoleItem;
		}

		// Token: 0x06040053 RID: 262227 RVA: 0x00F7C97A File Offset: 0x00F7AB7A
		private void RefreshRoleList(List<int> roleIdList)
		{
			this.RoleList = roleIdList;
			this.RecommendRoleList = (this.OpenParam as IPinballFormationSelectRoleViewData).RecommendRoleList;
			this.RefreshRoleScrollView();
		}

		// Token: 0x06040054 RID: 262228 RVA: 0x00F7C9A0 File Offset: 0x00F7ABA0
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

		// Token: 0x06040055 RID: 262229 RVA: 0x00F7CAAC File Offset: 0x00F7ACAC
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

		// Token: 0x06040056 RID: 262230 RVA: 0x00F7CD04 File Offset: 0x00F7AF04
		private void OnClickLeftBtn()
		{
			PinballRoleViewOpenParam param = new PinballRoleViewOpenParam
			{
				RoleId = ((this.CurrentShowRoleId > 0) ? new int?(this.CurrentShowRoleId) : null),
				FormationRoleIds = PinballModel.Instance.SelectRoleHandleList.ToArray()
			};
			UiManager.Instance.OpenView(EUiViewName.PinballRoleView, param, null);
		}

		// Token: 0x06040057 RID: 262231 RVA: 0x00F7CD62 File Offset: 0x00F7AF62
		private void OnClickRightBtn()
		{
			Action<List<int>> onConfirm = this.OnConfirm;
			if (onConfirm != null)
			{
				onConfirm(PinballModel.Instance.SelectRoleHandleList);
			}
			base.CloseMe(null);
		}

		// Token: 0x06040058 RID: 262232 RVA: 0x00F7CD86 File Offset: 0x00F7AF86
		private void OnClickCloseBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06040059 RID: 262233 RVA: 0x00F7CD90 File Offset: 0x00F7AF90
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

		// Token: 0x0604005A RID: 262234 RVA: 0x00F7CE80 File Offset: 0x00F7B080
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

		// Token: 0x0604005B RID: 262235 RVA: 0x00F7CEBC File Offset: 0x00F7B0BC
		private void RefreshConfirmBtn()
		{
			List<int> selectRoleHandleList = PinballModel.Instance.SelectRoleHandleList;
			base.GetButton(10).SetSelfInteractive(selectRoleHandleList.Count > 0 && selectRoleHandleList.Count <= 3);
		}

		// Token: 0x0604005C RID: 262236 RVA: 0x00F7CEFC File Offset: 0x00F7B0FC
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

		// Token: 0x040215E7 RID: 136679
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040215E8 RID: 136680
		private List<int> RoleList;

		// Token: 0x040215E9 RID: 136681
		private List<int> RecommendRoleList;

		// Token: 0x040215EA RID: 136682
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected LoopScrollView<PinballFormationSelectRoleItem, IPinballItemDataRole> RoleScrollView;

		// Token: 0x040215EB RID: 136683
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<List<int>> OnConfirm;

		// Token: 0x040215EC RID: 136684
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoleTagItem, IRoleTagItemData> RoleTagLayout;

		// Token: 0x040215ED RID: 136685
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoleSkillItem, IRoleSkillItemData> RoleSkillScrollView;

		// Token: 0x040215EE RID: 136686
		[Nullable(2)]
		private FilterSortEntrance<int> FilterSortComponent;

		// Token: 0x040215EF RID: 136687
		private int CurrentShowRoleId;

		// Token: 0x0200C582 RID: 50562
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B9D2 RID: 244178
			CaptionItem,
			// Token: 0x0403B9D3 RID: 244179
			RoleLoopScrollView,
			// Token: 0x0403B9D4 RID: 244180
			RoleItem,
			// Token: 0x0403B9D5 RID: 244181
			SortFilterItem,
			// Token: 0x0403B9D6 RID: 244182
			NumberSprite,
			// Token: 0x0403B9D7 RID: 244183
			RoleTagLayout,
			// Token: 0x0403B9D8 RID: 244184
			RoleTagItem,
			// Token: 0x0403B9D9 RID: 244185
			RoleDesScrollView,
			// Token: 0x0403B9DA RID: 244186
			RoleDesItem,
			// Token: 0x0403B9DB RID: 244187
			LeftBtn,
			// Token: 0x0403B9DC RID: 244188
			RightBtn,
			// Token: 0x0403B9DD RID: 244189
			CloseBtn,
			// Token: 0x0403B9DE RID: 244190
			RoleNameText,
			// Token: 0x0403B9DF RID: 244191
			EmptyItem
		}
	}
}
