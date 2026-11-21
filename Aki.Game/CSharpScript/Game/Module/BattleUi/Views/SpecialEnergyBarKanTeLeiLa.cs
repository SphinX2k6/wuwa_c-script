using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DC5 RID: 19909
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarKanTeLeiLa : SpecialEnergyBarBase
	{
		// Token: 0x060320F1 RID: 205041 RVA: 0x00E044D4 File Offset: 0x00E026D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 25;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060320F2 RID: 205042 RVA: 0x00E04848 File Offset: 0x00E02A48
		protected override void OnInitData()
		{
			this.NormalConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(160701);
			this.PinkConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(160702);
			this.ColorfulConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(160703);
		}

		// Token: 0x060320F3 RID: 205043 RVA: 0x00E048A4 File Offset: 0x00E02AA4
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1KanteleilaMd10011.状态标识.强化状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnDrownTagChange));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1KanteleilaMd10011.状态标识.普通状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnFinisherTagChange));
		}

		// Token: 0x060320F4 RID: 205044 RVA: 0x00E048F9 File Offset: 0x00E02AF9
		private void OnDrownTagChange(int tagId, bool tagExist)
		{
			this.NeedRefreshState = true;
		}

		// Token: 0x060320F5 RID: 205045 RVA: 0x00E04902 File Offset: 0x00E02B02
		private void OnFinisherTagChange(int tagId, bool tagExist)
		{
			this.NeedRefreshState = true;
		}

		// Token: 0x060320F6 RID: 205046 RVA: 0x00E0490C File Offset: 0x00E02B0C
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarKanTeLeiLa.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarKanTeLeiLa.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060320F7 RID: 205047 RVA: 0x00E04950 File Offset: 0x00E02B50
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarKanTeLeiLa.<InitBarItem>d__27 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarKanTeLeiLa.<InitBarItem>d__27>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x060320F8 RID: 205048 RVA: 0x00E04994 File Offset: 0x00E02B94
		protected override void OnStart()
		{
			base.InitTweenAnim(13);
			base.InitTweenAnim(14);
			base.InitTweenAnim(15);
			base.InitTweenAnim(16);
			base.InitTweenAnim(17);
			base.InitTweenAnim(18);
			base.InitTweenAnim(19);
			base.InitTweenAnim(20);
			base.InitTweenAnim(21);
			base.InitTweenAnim(22);
			base.InitTweenAnim(24);
			this.PointItemsA.Add(base.GetItem(0));
			this.PointItemsA.Add(base.GetItem(1));
			this.PointItemsA.Add(base.GetItem(2));
			this.PointItemsB.Add(base.GetItem(3));
			this.PointItemsB.Add(base.GetItem(4));
			this.PointItemsB.Add(base.GetItem(5));
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetAlpha(1f);
			}
			this.RefreshState(true);
			this.RefreshPointItems(true);
		}

		// Token: 0x060320F9 RID: 205049 RVA: 0x00E04A8A File Offset: 0x00E02C8A
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(18);
			base.ClearAllTweenAnim();
		}

		// Token: 0x060320FA RID: 205050 RVA: 0x00E04A9A File Offset: 0x00E02C9A
		protected override void OnAttributeChanged()
		{
			this.RefreshPointItems(false);
		}

		// Token: 0x060320FB RID: 205051 RVA: 0x00E04AA3 File Offset: 0x00E02CA3
		protected override void OnMaxAttributeChanged()
		{
		}

		// Token: 0x060320FC RID: 205052 RVA: 0x00E04AA8 File Offset: 0x00E02CA8
		private void RefreshState(bool isStart = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			bool flag = tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1KanteleilaMd10011.状态标识.普通状态"]);
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null && tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1KanteleilaMd10011.状态标识.强化状态"]))
			{
				if (flag)
				{
					this.SetState(SpecialEnergyBarKanTeLeiLa.EState.Pink, isStart);
				}
				else
				{
					this.SetState(SpecialEnergyBarKanTeLeiLa.EState.Colorful, isStart);
				}
			}
			else
			{
				this.SetState(SpecialEnergyBarKanTeLeiLa.EState.Normal, isStart);
			}
			if (this.IsInCd != flag || isStart)
			{
				this.IsInCd = flag;
				this.RefreshNormalEffect(isStart);
			}
		}

		// Token: 0x060320FD RID: 205053 RVA: 0x00E04B38 File Offset: 0x00E02D38
		private void RefreshNormalEffect(bool isStart = false)
		{
			bool flag = !this.IsInCd;
			if (!isStart && this.CurState == SpecialEnergyBarKanTeLeiLa.EState.Normal)
			{
				if (flag)
				{
					base.PlayTweenAnim(24);
				}
				return;
			}
			UUIItem item = base.GetItem(23);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(23);
			if (item2 == null)
			{
				return;
			}
			item2.SetAlpha(flag > false);
		}

		// Token: 0x060320FE RID: 205054 RVA: 0x00E04B94 File Offset: 0x00E02D94
		private void SetState(SpecialEnergyBarKanTeLeiLa.EState state, bool isStart = false)
		{
			if (state == this.CurState && !isStart)
			{
				return;
			}
			SpecialEnergyBarKanTeLeiLa.EState curState = this.CurState;
			this.CurState = state;
			switch (this.CurState)
			{
			case SpecialEnergyBarKanTeLeiLa.EState.Normal:
				if (!isStart)
				{
					base.StopTweenAnim(13);
					base.PlayTweenAnim(14);
					if (curState == SpecialEnergyBarKanTeLeiLa.EState.Colorful)
					{
						base.StopTweenAnim(15);
						base.PlayTweenAnim(16);
					}
				}
				else
				{
					UUIItem item = base.GetItem(6);
					if (item != null)
					{
						item.SetUIActive(true);
					}
					UUIItem item2 = base.GetItem(7);
					if (item2 != null)
					{
						item2.SetUIActive(false);
					}
				}
				break;
			case SpecialEnergyBarKanTeLeiLa.EState.Pink:
			{
				UUIItem item3 = base.GetItem(9);
				if (item3 != null)
				{
					item3.SetUIActive(false);
				}
				UUIItem item4 = base.GetItem(8);
				if (item4 != null)
				{
					item4.SetUIActive(true);
				}
				UUIItem item5 = base.GetItem(8);
				if (item5 != null)
				{
					item5.SetAlpha(1f);
				}
				if (!isStart)
				{
					if (curState == SpecialEnergyBarKanTeLeiLa.EState.Normal)
					{
						base.StopTweenAnim(14);
						base.PlayTweenAnim(13);
						UUIItem item6 = base.GetItem(9);
						if (item6 != null)
						{
							item6.SetUIActive(false);
						}
						UUIItem item7 = base.GetItem(8);
						if (item7 != null)
						{
							item7.SetUIActive(true);
						}
					}
					else
					{
						base.StopTweenAnim(15);
						base.PlayTweenAnim(16);
					}
				}
				else
				{
					UUIItem item8 = base.GetItem(6);
					if (item8 != null)
					{
						item8.SetUIActive(false);
					}
					UUIItem item9 = base.GetItem(7);
					if (item9 != null)
					{
						item9.SetUIActive(true);
					}
				}
				break;
			}
			case SpecialEnergyBarKanTeLeiLa.EState.Colorful:
				if (!isStart)
				{
					if (curState == SpecialEnergyBarKanTeLeiLa.EState.Normal)
					{
						base.StopTweenAnim(14);
						base.PlayTweenAnim(13);
						UUIItem item10 = base.GetItem(9);
						if (item10 != null)
						{
							item10.SetUIActive(true);
						}
						UUIItem item11 = base.GetItem(8);
						if (item11 != null)
						{
							item11.SetUIActive(false);
						}
					}
					base.StopTweenAnim(16);
					base.PlayTweenAnim(15);
				}
				else
				{
					UUIItem item12 = base.GetItem(6);
					if (item12 != null)
					{
						item12.SetUIActive(false);
					}
					UUIItem item13 = base.GetItem(7);
					if (item13 != null)
					{
						item13.SetUIActive(true);
					}
					UUIItem item14 = base.GetItem(9);
					if (item14 != null)
					{
						item14.SetUIActive(true);
					}
					UUIItem item15 = base.GetItem(8);
					if (item15 != null)
					{
						item15.SetUIActive(false);
					}
				}
				break;
			}
			if (!isStart && (curState == SpecialEnergyBarKanTeLeiLa.EState.Colorful || this.CurState == SpecialEnergyBarKanTeLeiLa.EState.Colorful))
			{
				this.RefreshPointItems(true);
				if (this.CurState == SpecialEnergyBarKanTeLeiLa.EState.Colorful)
				{
					base.PlayTweenAnim(19);
				}
			}
		}

		// Token: 0x060320FF RID: 205055 RVA: 0x00E04DC4 File Offset: 0x00E02FC4
		private void RefreshPointItems(bool bForce = false)
		{
			float currentValue = this.AttributeComponent.GetCurrentValue(this.AttributeId);
			if (!bForce && this.LastPointCount == currentValue)
			{
				return;
			}
			for (int i = 0; i < 3; i++)
			{
				bool flag = currentValue > (float)i;
				bool flag2 = this.CurState == SpecialEnergyBarKanTeLeiLa.EState.Colorful && currentValue == 3f;
				this.PointItemsA[i].SetUIActive(flag && !flag2);
				this.PointItemsB[i].SetUIActive(flag && flag2);
				if (flag && this.LastPointCount <= (float)i)
				{
					base.PlayTweenAnim(20 + i);
				}
			}
			if (currentValue < this.LastPointCount)
			{
				base.PlayTweenAnim(17);
			}
			this.LastPointCount = currentValue;
		}

		// Token: 0x06032100 RID: 205056 RVA: 0x00E04E78 File Offset: 0x00E03078
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarKanTeLeiLaSlot barItemNormal = this.BarItemNormal;
			if (barItemNormal != null)
			{
				barItemNormal.Tick(delta);
			}
			SpecialEnergyBarKanTeLeiLaSlot barItemPink = this.BarItemPink;
			if (barItemPink != null)
			{
				barItemPink.Tick(delta);
			}
			SpecialEnergyBarKanTeLeiLaSlot barItemColorful = this.BarItemColorful;
			if (barItemColorful != null)
			{
				barItemColorful.Tick(delta);
			}
			if (this.NeedRefreshState)
			{
				this.RefreshState(false);
				this.NeedRefreshState = false;
			}
			if (this.CurState == SpecialEnergyBarKanTeLeiLa.EState.Normal)
			{
				this.PlayWarnAnim(false);
				return;
			}
			if (this.Buff != null)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.BuffHandle) : null) != null)
				{
					goto IL_8B;
				}
			}
			this.RefreshBuff();
			IL_8B:
			if (this.Buff != null)
			{
				this.PlayWarnAnim(this.Buff.GetRemainDuration() < this.Config.ExtraFloatParams[0]);
			}
		}

		// Token: 0x06032101 RID: 205057 RVA: 0x00E04F3C File Offset: 0x00E0313C
		private void RefreshBuff()
		{
			SpecialEnergyBarInfo config = this.Config;
			bool flag;
			if (config == null)
			{
				flag = false;
			}
			else
			{
				long buffId = config.BuffId;
				flag = true;
			}
			if (flag)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				this.Buff = ((buffComponent != null) ? buffComponent.GetBuffById(this.Config.BuffId) : null);
				IActiveBuff buff = this.Buff;
				this.BuffHandle = ((buff != null) ? buff.Handle : 0);
				return;
			}
			this.Buff = null;
			this.BuffHandle = 0;
		}

		// Token: 0x06032102 RID: 205058 RVA: 0x00E04FA9 File Offset: 0x00E031A9
		private void PlayWarnAnim(bool bPlay)
		{
			if (this.IsPlayWarnAnim == bPlay)
			{
				return;
			}
			this.IsPlayWarnAnim = bPlay;
			if (bPlay)
			{
				base.PlayTweenAnim(18);
				return;
			}
			base.StopTweenAnim(18);
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetAlpha(1f);
		}

		// Token: 0x0401A81A RID: 108570
		private const int NORMAL_CONFIG_ID = 160701;

		// Token: 0x0401A81B RID: 108571
		private const int PINK_CONFIG_ID = 160702;

		// Token: 0x0401A81C RID: 108572
		private const int COLORFUL_CONFIG_ID = 160703;

		// Token: 0x0401A81D RID: 108573
		private const int POINT_NUM = 3;

		// Token: 0x0401A81E RID: 108574
		private SpecialEnergyBarInfo NormalConfig;

		// Token: 0x0401A81F RID: 108575
		private SpecialEnergyBarInfo PinkConfig;

		// Token: 0x0401A820 RID: 108576
		private SpecialEnergyBarInfo ColorfulConfig;

		// Token: 0x0401A821 RID: 108577
		private SpecialEnergyBarKanTeLeiLaSlot BarItemNormal;

		// Token: 0x0401A822 RID: 108578
		private SpecialEnergyBarKanTeLeiLaSlot BarItemPink;

		// Token: 0x0401A823 RID: 108579
		private SpecialEnergyBarKanTeLeiLaSlot BarItemColorful;

		// Token: 0x0401A824 RID: 108580
		[Nullable(1)]
		private readonly List<UUIItem> PointItemsA = new List<UUIItem>();

		// Token: 0x0401A825 RID: 108581
		[Nullable(1)]
		private readonly List<UUIItem> PointItemsB = new List<UUIItem>();

		// Token: 0x0401A826 RID: 108582
		private float LastPointCount;

		// Token: 0x0401A827 RID: 108583
		private SpecialEnergyBarKanTeLeiLa.EState CurState;

		// Token: 0x0401A828 RID: 108584
		private IActiveBuff Buff;

		// Token: 0x0401A829 RID: 108585
		private int BuffHandle;

		// Token: 0x0401A82A RID: 108586
		private bool IsPlayWarnAnim;

		// Token: 0x0401A82B RID: 108587
		private bool IsInCd;

		// Token: 0x0401A82C RID: 108588
		private bool NeedRefreshState;

		// Token: 0x0200AB10 RID: 43792
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034E1D RID: 216605
			PointA1Item,
			// Token: 0x04034E1E RID: 216606
			PointA2Item,
			// Token: 0x04034E1F RID: 216607
			PointA3Item,
			// Token: 0x04034E20 RID: 216608
			PointB1Item,
			// Token: 0x04034E21 RID: 216609
			PointB2Item,
			// Token: 0x04034E22 RID: 216610
			PointB3Item,
			// Token: 0x04034E23 RID: 216611
			NormalItem,
			// Token: 0x04034E24 RID: 216612
			DrownItem,
			// Token: 0x04034E25 RID: 216613
			PinkItem,
			// Token: 0x04034E26 RID: 216614
			ColorfulItem,
			// Token: 0x04034E27 RID: 216615
			SlotBarItemNormal,
			// Token: 0x04034E28 RID: 216616
			SlotBarItemPink,
			// Token: 0x04034E29 RID: 216617
			SlotBarItemColorful,
			// Token: 0x04034E2A RID: 216618
			AnimDrownIn,
			// Token: 0x04034E2B RID: 216619
			AnimDrownOut,
			// Token: 0x04034E2C RID: 216620
			AnimColorfulIn,
			// Token: 0x04034E2D RID: 216621
			AnimColorfulOut,
			// Token: 0x04034E2E RID: 216622
			AnimBurst,
			// Token: 0x04034E2F RID: 216623
			AnimWarning,
			// Token: 0x04034E30 RID: 216624
			AnimCoreIn,
			// Token: 0x04034E31 RID: 216625
			AnimPoint1,
			// Token: 0x04034E32 RID: 216626
			AnimPoint2,
			// Token: 0x04034E33 RID: 216627
			AnimPoint3,
			// Token: 0x04034E34 RID: 216628
			ExtraItem,
			// Token: 0x04034E35 RID: 216629
			AnimPreColorful
		}

		// Token: 0x0200AB11 RID: 43793
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x04034E37 RID: 216631
			Normal,
			// Token: 0x04034E38 RID: 216632
			Pink,
			// Token: 0x04034E39 RID: 216633
			Colorful
		}
	}
}
