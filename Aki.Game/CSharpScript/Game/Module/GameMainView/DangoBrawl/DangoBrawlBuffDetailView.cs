using System;
using System.Collections.Generic;
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
	// Token: 0x020049E2 RID: 18914
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBuffDetailView : UiViewBase
	{
		// Token: 0x0602F5DD RID: 194013 RVA: 0x00D35454 File Offset: 0x00D33654
		private int GetBuffTypeIndex(EDangoBrawlBuffType buffType)
		{
			int num = Array.IndexOf<EDangoBrawlBuffType>(this.BuffTypeList, buffType);
			if (num < 0)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x0602F5DE RID: 194014 RVA: 0x00D35475 File Offset: 0x00D33675
		private List<DangoBrawlBattleBuffDetailItemData> GetSideBuffList(EDangoBrawlBuffDetailSide side)
		{
			return ((side == EDangoBrawlBuffDetailSide.Self) ? this.ViewOpenData.SelfSide : this.ViewOpenData.OpponentSide).BuffDetailDataList;
		}

		// Token: 0x0602F5DF RID: 194015 RVA: 0x00D35498 File Offset: 0x00D33698
		private List<DangoBrawlBattleBuffDetailItemData> GetBuffDetailDataListByType(EDangoBrawlBuffType buffType)
		{
			List<DangoBrawlBattleBuffDetailItemData> list = new List<DangoBrawlBattleBuffDetailItemData>();
			foreach (DangoBrawlBattleBuffDetailItemData dangoBrawlBattleBuffDetailItemData in this.BuffDetailDataList)
			{
				DangoBrawlBuff? buffConfigById = DangoBrawlConfig.Instance.GetBuffConfigById(dangoBrawlBattleBuffDetailItemData.BaseData.ConfigId);
				if (buffConfigById != null && buffConfigById.Value.BuffType == (int)buffType && buffConfigById.Value.IsShow)
				{
					list.Add(dangoBrawlBattleBuffDetailItemData);
				}
			}
			return list;
		}

		// Token: 0x0602F5E0 RID: 194016 RVA: 0x00D35538 File Offset: 0x00D33738
		private int GetTargetScrollIndex(EDangoBrawlBuffType buffType)
		{
			return this.GetBuffDetailDataListByType(buffType).FindIndex((DangoBrawlBattleBuffDetailItemData data) => data.IsSelected);
		}

		// Token: 0x0602F5E1 RID: 194017 RVA: 0x00D35565 File Offset: 0x00D33765
		public DangoBrawlBuffDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F5E2 RID: 194018 RVA: 0x00D35590 File Offset: 0x00D33790
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

		// Token: 0x0602F5E3 RID: 194019 RVA: 0x00D35788 File Offset: 0x00D33988
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlBuffDetailView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlBuffDetailView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F5E4 RID: 194020 RVA: 0x00D357CB File Offset: 0x00D339CB
		protected override void OnBeforeShow()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView == null)
			{
				return;
			}
			childPopView.SetTitleByTextIdAndArg("DangoBrawlBattleUIText_035", Array.Empty<object>());
		}

		// Token: 0x0602F5E5 RID: 194021 RVA: 0x00D357E7 File Offset: 0x00D339E7
		private DangoBrawlBattleBuffDetailTogItem CreateTogItem()
		{
			return new DangoBrawlBattleBuffDetailTogItem
			{
				OnClickType = new Action<EDangoBrawlBuffType>(this.OnClickBuffType)
			};
		}

		// Token: 0x0602F5E6 RID: 194022 RVA: 0x00D35800 File Offset: 0x00D33A00
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

		// Token: 0x0602F5E7 RID: 194023 RVA: 0x00D358D0 File Offset: 0x00D33AD0
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

		// Token: 0x0602F5E8 RID: 194024 RVA: 0x00D35934 File Offset: 0x00D33B34
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

		// Token: 0x0602F5E9 RID: 194025 RVA: 0x00D35974 File Offset: 0x00D33B74
		private void RefreshBuffScroll(EDangoBrawlBuffType buffType, int scrollIndex = -1)
		{
			List<DangoBrawlBattleBuffDetailItemData> buffDetailDataListByType = this.GetBuffDetailDataListByType(buffType);
			this.RefreshBuffScrollAsync(buffDetailDataListByType, scrollIndex).Forget();
		}

		// Token: 0x0602F5EA RID: 194026 RVA: 0x00D35998 File Offset: 0x00D33B98
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

		// Token: 0x0602F5EB RID: 194027 RVA: 0x00D359EB File Offset: 0x00D33BEB
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

		// Token: 0x0602F5EC RID: 194028 RVA: 0x00D35A1C File Offset: 0x00D33C1C
		private void OnClickBtnReviewSelfBuff()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequence("Switch_Blue", false, null);
			}
			this.SwitchSide(EDangoBrawlBuffDetailSide.Self);
		}

		// Token: 0x0602F5ED RID: 194029 RVA: 0x00D35A50 File Offset: 0x00D33C50
		private void OnClickBtnReviewOpponentBuff()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequence("Switch_Red", false, null);
			}
			this.SwitchSide(EDangoBrawlBuffDetailSide.Opponent);
		}

		// Token: 0x040191BD RID: 102845
		private readonly EDangoBrawlBuffType[] BuffTypeList = new EDangoBrawlBuffType[]
		{
			EDangoBrawlBuffType.Buff,
			EDangoBrawlBuffType.DeBuff
		};

		// Token: 0x040191BE RID: 102846
		[Nullable(2)]
		private DangoBrawlBuffDetailViewOpenData ViewOpenData;

		// Token: 0x040191BF RID: 102847
		private EDangoBrawlBuffDetailSide CurrentSide;

		// Token: 0x040191C0 RID: 102848
		private EDangoBrawlBuffType CurrentBuffType;

		// Token: 0x040191C1 RID: 102849
		private List<DangoBrawlBattleBuffDetailItemData> BuffDetailDataList = new List<DangoBrawlBattleBuffDetailItemData>();

		// Token: 0x040191C2 RID: 102850
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<DangoBrawlBattleBuffDetailTogItem, EDangoBrawlBuffType> TogLayout;

		// Token: 0x040191C3 RID: 102851
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DangoBrawlBattleBuffDetailItem, DangoBrawlBattleBuffDetailItemData> BuffScrollView;

		// Token: 0x0200A661 RID: 42593
		[NullableContext(0)]
		private enum EBuffComponent
		{
			// Token: 0x040336ED RID: 210669
			TogLayout,
			// Token: 0x040336EE RID: 210670
			TogItem,
			// Token: 0x040336EF RID: 210671
			BuffScrollView,
			// Token: 0x040336F0 RID: 210672
			BuffLayout,
			// Token: 0x040336F1 RID: 210673
			BuffItem,
			// Token: 0x040336F2 RID: 210674
			BtnReviewSelfBuff,
			// Token: 0x040336F3 RID: 210675
			TexRoleSelf,
			// Token: 0x040336F4 RID: 210676
			TxtRoleSelf,
			// Token: 0x040336F5 RID: 210677
			BtnReviewOpponentBuff,
			// Token: 0x040336F6 RID: 210678
			TexRoleOpponent,
			// Token: 0x040336F7 RID: 210679
			TxtRoleOpponent
		}
	}
}
