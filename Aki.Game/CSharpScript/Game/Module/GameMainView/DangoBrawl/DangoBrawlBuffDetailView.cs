using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.GameMainView.DangoBrawl.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl
{
	// Token: 0x02005A06 RID: 23046
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBuffDetailView : UiViewBase
	{
		// Token: 0x0603A694 RID: 239252 RVA: 0x00DE4F04 File Offset: 0x00DE3104
		private int GetBuffTypeIndex(EDangoBrawlBuffType buffType)
		{
			int num = Array.IndexOf<EDangoBrawlBuffType>(this.BuffTypeList, buffType);
			if (num < 0)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x0603A695 RID: 239253 RVA: 0x00DE4F25 File Offset: 0x00DE3125
		private List<DangoBrawlBattleBuffDetailItemData> GetSideBuffList(EDangoBrawlBuffDetailSide side)
		{
			return ((side == EDangoBrawlBuffDetailSide.Self) ? this.ViewOpenData.SelfSide : this.ViewOpenData.OpponentSide).BuffDetailDataList;
		}

		// Token: 0x0603A696 RID: 239254 RVA: 0x00DE4F48 File Offset: 0x00DE3148
		private List<DangoBrawlBattleBuffDetailItemData> GetBuffDetailDataListByType(EDangoBrawlBuffType buffType)
		{
			return this.BuffDetailDataList.Where(delegate(DangoBrawlBattleBuffDetailItemData data)
			{
				DangoBrawlBuff? buffConfigById = DangoBrawlConfig.Instance.GetBuffConfigById(data.BaseData.ConfigId);
				return buffConfigById != null && buffConfigById.Value.BuffType == (int)buffType && buffConfigById.Value.IsShow;
			}).ToList<DangoBrawlBattleBuffDetailItemData>();
		}

		// Token: 0x0603A697 RID: 239255 RVA: 0x00DE4F7E File Offset: 0x00DE317E
		private int GetTargetScrollIndex(EDangoBrawlBuffType buffType)
		{
			return this.GetBuffDetailDataListByType(buffType).FindIndex((DangoBrawlBattleBuffDetailItemData data) => data.IsSelected);
		}

		// Token: 0x0603A698 RID: 239256 RVA: 0x00DE4FAB File Offset: 0x00DE31AB
		public DangoBrawlBuffDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A699 RID: 239257 RVA: 0x00DE4FD4 File Offset: 0x00DE31D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickBtnReviewSelfBuff));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickBtnReviewOpponentBuff));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603A69A RID: 239258 RVA: 0x00DE51CC File Offset: 0x00DE33CC
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlBuffDetailView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlBuffDetailView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A69B RID: 239259 RVA: 0x00DE520F File Offset: 0x00DE340F
		protected override void OnBeforeShow()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView == null)
			{
				return;
			}
			childPopView.SetTitleByTextIdAndArg("DangoBrawlBattleUIText_035", Array.Empty<object>());
		}

		// Token: 0x0603A69C RID: 239260 RVA: 0x00DE522B File Offset: 0x00DE342B
		private DangoBrawlBattleBuffDetailTogItem CreateTogItem()
		{
			return new DangoBrawlBattleBuffDetailTogItem
			{
				OnClickType = new Action<EDangoBrawlBuffType>(this.OnClickBuffType)
			};
		}

		// Token: 0x0603A69D RID: 239261 RVA: 0x00DE5244 File Offset: 0x00DE3444
		private void RefreshRoleDisplay()
		{
			DangoBrawlBuffSideDetailData selfSide = this.ViewOpenData.SelfSide;
			DangoBrawlBuffSideDetailData opponentSide = this.ViewOpenData.OpponentSide;
			if (!string.IsNullOrEmpty(selfSide.RoleIcon))
			{
				base.SetTextureByPath(selfSide.RoleIcon, base.GetTexture(6), null, null);
			}
			if (!string.IsNullOrEmpty(selfSide.RoleNameKey))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(7), selfSide.RoleNameKey, Array.Empty<object>());
			}
			if (!string.IsNullOrEmpty(opponentSide.RoleIcon))
			{
				base.SetTextureByPath(opponentSide.RoleIcon, base.GetTexture(9), null, null);
			}
			if (!string.IsNullOrEmpty(opponentSide.RoleNameKey))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(10), opponentSide.RoleNameKey, Array.Empty<object>());
			}
		}

		// Token: 0x0603A69E RID: 239262 RVA: 0x00DE5314 File Offset: 0x00DE3514
		private void RefreshSideButtonState()
		{
			bool flag = this.CurrentSide == EDangoBrawlBuffDetailSide.Self;
			UUIButtonComponent button = base.GetButton(5);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(!flag);
				}
			}
			UUIButtonComponent button2 = base.GetButton(8);
			if (button2 == null)
			{
				return;
			}
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 == null)
			{
				return;
			}
			uuiitem2.SetUIActive(flag);
		}

		// Token: 0x0603A69F RID: 239263 RVA: 0x00DE5378 File Offset: 0x00DE3578
		private void SwitchSide(EDangoBrawlBuffDetailSide side)
		{
			if (this.CurrentSide == side)
			{
				return;
			}
			this.CurrentSide = side;
			this.BuffDetailDataList = this.GetSideBuffList(side);
			this.RefreshSideButtonState();
			this.RefreshBuffScroll(this.CurrentBuffType, this.GetTargetScrollIndex(this.CurrentBuffType));
		}

		// Token: 0x0603A6A0 RID: 239264 RVA: 0x00DE53B8 File Offset: 0x00DE35B8
		private void RefreshBuffScroll(EDangoBrawlBuffType buffType, int scrollIndex = -1)
		{
			List<DangoBrawlBattleBuffDetailItemData> buffDetailDataListByType = this.GetBuffDetailDataListByType(buffType);
			this.RefreshBuffScrollAsync(buffDetailDataListByType, scrollIndex).Forget();
		}

		// Token: 0x0603A6A1 RID: 239265 RVA: 0x00DE53DC File Offset: 0x00DE35DC
		private UniTask RefreshBuffScrollAsync(List<DangoBrawlBattleBuffDetailItemData> dataList, int scrollIndex = -1)
		{
			DangoBrawlBuffDetailView.<RefreshBuffScrollAsync>d__21 <RefreshBuffScrollAsync>d__;
			<RefreshBuffScrollAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshBuffScrollAsync>d__.<>4__this = this;
			<RefreshBuffScrollAsync>d__.dataList = dataList;
			<RefreshBuffScrollAsync>d__.scrollIndex = scrollIndex;
			<RefreshBuffScrollAsync>d__.<>1__state = -1;
			<RefreshBuffScrollAsync>d__.<>t__builder.Start<DangoBrawlBuffDetailView.<RefreshBuffScrollAsync>d__21>(ref <RefreshBuffScrollAsync>d__);
			return <RefreshBuffScrollAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A6A2 RID: 239266 RVA: 0x00DE542F File Offset: 0x00DE362F
		private void OnClickBuffType(EDangoBrawlBuffType buffType)
		{
			this.CurrentBuffType = buffType;
			GenericLayout<DangoBrawlBattleBuffDetailTogItem, EDangoBrawlBuffType> togLayout = this.TogLayout;
			if (togLayout != null)
			{
				togLayout.SelectGridProxy(this.GetBuffTypeIndex(buffType), false);
			}
			this.RefreshBuffScroll(buffType, this.GetTargetScrollIndex(buffType));
		}

		// Token: 0x0603A6A3 RID: 239267 RVA: 0x00DE5460 File Offset: 0x00DE3660
		private void OnClickBtnReviewSelfBuff()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequence("Switch_Blue", false, null);
			}
			this.SwitchSide(EDangoBrawlBuffDetailSide.Self);
		}

		// Token: 0x0603A6A4 RID: 239268 RVA: 0x00DE5494 File Offset: 0x00DE3694
		private void OnClickBtnReviewOpponentBuff()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequence("Switch_Red", false, null);
			}
			this.SwitchSide(EDangoBrawlBuffDetailSide.Opponent);
		}

		// Token: 0x0401E716 RID: 124694
		private readonly EDangoBrawlBuffType[] BuffTypeList = new EDangoBrawlBuffType[]
		{
			EDangoBrawlBuffType.Buff,
			EDangoBrawlBuffType.DeBuff
		};

		// Token: 0x0401E717 RID: 124695
		[Nullable(2)]
		private DangoBrawlBuffDetailViewOpenData ViewOpenData;

		// Token: 0x0401E718 RID: 124696
		private EDangoBrawlBuffDetailSide CurrentSide;

		// Token: 0x0401E719 RID: 124697
		private EDangoBrawlBuffType CurrentBuffType;

		// Token: 0x0401E71A RID: 124698
		private List<DangoBrawlBattleBuffDetailItemData> BuffDetailDataList = new List<DangoBrawlBattleBuffDetailItemData>();

		// Token: 0x0401E71B RID: 124699
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<DangoBrawlBattleBuffDetailTogItem, EDangoBrawlBuffType> TogLayout;

		// Token: 0x0401E71C RID: 124700
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DangoBrawlBattleBuffDetailItem, DangoBrawlBattleBuffDetailItemData> BuffScrollView;

		// Token: 0x0200BC57 RID: 48215
		[NullableContext(0)]
		private enum EBuffComponent
		{
			// Token: 0x04038D20 RID: 232736
			TogLayout,
			// Token: 0x04038D21 RID: 232737
			TogItem,
			// Token: 0x04038D22 RID: 232738
			BuffScrollView,
			// Token: 0x04038D23 RID: 232739
			BuffLayout,
			// Token: 0x04038D24 RID: 232740
			BuffItem,
			// Token: 0x04038D25 RID: 232741
			BtnReviewSelfBuff,
			// Token: 0x04038D26 RID: 232742
			TexRoleSelf,
			// Token: 0x04038D27 RID: 232743
			TxtRoleSelf,
			// Token: 0x04038D28 RID: 232744
			BtnReviewOpponentBuff,
			// Token: 0x04038D29 RID: 232745
			TexRoleOpponent,
			// Token: 0x04038D2A RID: 232746
			TxtRoleOpponent
		}
	}
}
