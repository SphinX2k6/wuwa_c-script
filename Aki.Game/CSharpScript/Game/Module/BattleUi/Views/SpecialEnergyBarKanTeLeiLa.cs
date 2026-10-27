using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DE1 RID: 24033
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarKanTeLeiLa : SpecialEnergyBarBase
	{
		// Token: 0x0603D17A RID: 250234 RVA: 0x00EB35D4 File Offset: 0x00EB17D4
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

		// Token: 0x0603D17B RID: 250235 RVA: 0x00EB3948 File Offset: 0x00EB1B48
		protected override void OnInitData()
		{
			this.NormalConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(160701);
			this.PinkConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(160702);
			this.ColorfulConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(160703);
		}

		// Token: 0x0603D17C RID: 250236 RVA: 0x00EB39A4 File Offset: 0x00EB1BA4
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1KanteleilaMd10011.状态标识.强化状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnDrownTagChange));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1KanteleilaMd10011.状态标识.普通状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnFinisherTagChange));
		}

		// Token: 0x0603D17D RID: 250237 RVA: 0x00EB39F9 File Offset: 0x00EB1BF9
		private void OnDrownTagChange(int tagId, bool tagExist)
		{
			this.NeedRefreshState = true;
		}

		// Token: 0x0603D17E RID: 250238 RVA: 0x00EB3A02 File Offset: 0x00EB1C02
		private void OnFinisherTagChange(int tagId, bool tagExist)
		{
			this.NeedRefreshState = true;
		}

		// Token: 0x0603D17F RID: 250239 RVA: 0x00EB3A0C File Offset: 0x00EB1C0C
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarKanTeLeiLa.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarKanTeLeiLa.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D180 RID: 250240 RVA: 0x00EB3A50 File Offset: 0x00EB1C50
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarKanTeLeiLa.<InitBarItem>d__27 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarKanTeLeiLa.<InitBarItem>d__27>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D181 RID: 250241 RVA: 0x00EB3A94 File Offset: 0x00EB1C94
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

		// Token: 0x0603D182 RID: 250242 RVA: 0x00EB3B8A File Offset: 0x00EB1D8A
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(18);
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603D183 RID: 250243 RVA: 0x00EB3B9A File Offset: 0x00EB1D9A
		protected override void OnAttributeChanged()
		{
			this.RefreshPointItems(false);
		}

		// Token: 0x0603D184 RID: 250244 RVA: 0x00EB3BA3 File Offset: 0x00EB1DA3
		protected override void OnMaxAttributeChanged()
		{
		}

		// Token: 0x0603D185 RID: 250245 RVA: 0x00EB3BA8 File Offset: 0x00EB1DA8
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

		// Token: 0x0603D186 RID: 250246 RVA: 0x00EB3C38 File Offset: 0x00EB1E38
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

		// Token: 0x0603D187 RID: 250247 RVA: 0x00EB3C94 File Offset: 0x00EB1E94
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

		// Token: 0x0603D188 RID: 250248 RVA: 0x00EB3EC4 File Offset: 0x00EB20C4
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

		// Token: 0x0603D189 RID: 250249 RVA: 0x00EB3F78 File Offset: 0x00EB2178
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

		// Token: 0x0603D18A RID: 250250 RVA: 0x00EB403C File Offset: 0x00EB223C
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

		// Token: 0x0603D18B RID: 250251 RVA: 0x00EB40A9 File Offset: 0x00EB22A9
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

		// Token: 0x0401FD5D RID: 130397
		private const int NORMAL_CONFIG_ID = 160701;

		// Token: 0x0401FD5E RID: 130398
		private const int PINK_CONFIG_ID = 160702;

		// Token: 0x0401FD5F RID: 130399
		private const int COLORFUL_CONFIG_ID = 160703;

		// Token: 0x0401FD60 RID: 130400
		private const int POINT_NUM = 3;

		// Token: 0x0401FD61 RID: 130401
		private SpecialEnergyBarInfo NormalConfig;

		// Token: 0x0401FD62 RID: 130402
		private SpecialEnergyBarInfo PinkConfig;

		// Token: 0x0401FD63 RID: 130403
		private SpecialEnergyBarInfo ColorfulConfig;

		// Token: 0x0401FD64 RID: 130404
		private SpecialEnergyBarKanTeLeiLaSlot BarItemNormal;

		// Token: 0x0401FD65 RID: 130405
		private SpecialEnergyBarKanTeLeiLaSlot BarItemPink;

		// Token: 0x0401FD66 RID: 130406
		private SpecialEnergyBarKanTeLeiLaSlot BarItemColorful;

		// Token: 0x0401FD67 RID: 130407
		[Nullable(1)]
		private readonly List<UUIItem> PointItemsA = new List<UUIItem>();

		// Token: 0x0401FD68 RID: 130408
		[Nullable(1)]
		private readonly List<UUIItem> PointItemsB = new List<UUIItem>();

		// Token: 0x0401FD69 RID: 130409
		private float LastPointCount;

		// Token: 0x0401FD6A RID: 130410
		private SpecialEnergyBarKanTeLeiLa.EState CurState;

		// Token: 0x0401FD6B RID: 130411
		private IActiveBuff Buff;

		// Token: 0x0401FD6C RID: 130412
		private int BuffHandle;

		// Token: 0x0401FD6D RID: 130413
		private bool IsPlayWarnAnim;

		// Token: 0x0401FD6E RID: 130414
		private bool IsInCd;

		// Token: 0x0401FD6F RID: 130415
		private bool NeedRefreshState;

		// Token: 0x0200C107 RID: 49415
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A44B RID: 238667
			PointA1Item,
			// Token: 0x0403A44C RID: 238668
			PointA2Item,
			// Token: 0x0403A44D RID: 238669
			PointA3Item,
			// Token: 0x0403A44E RID: 238670
			PointB1Item,
			// Token: 0x0403A44F RID: 238671
			PointB2Item,
			// Token: 0x0403A450 RID: 238672
			PointB3Item,
			// Token: 0x0403A451 RID: 238673
			NormalItem,
			// Token: 0x0403A452 RID: 238674
			DrownItem,
			// Token: 0x0403A453 RID: 238675
			PinkItem,
			// Token: 0x0403A454 RID: 238676
			ColorfulItem,
			// Token: 0x0403A455 RID: 238677
			SlotBarItemNormal,
			// Token: 0x0403A456 RID: 238678
			SlotBarItemPink,
			// Token: 0x0403A457 RID: 238679
			SlotBarItemColorful,
			// Token: 0x0403A458 RID: 238680
			AnimDrownIn,
			// Token: 0x0403A459 RID: 238681
			AnimDrownOut,
			// Token: 0x0403A45A RID: 238682
			AnimColorfulIn,
			// Token: 0x0403A45B RID: 238683
			AnimColorfulOut,
			// Token: 0x0403A45C RID: 238684
			AnimBurst,
			// Token: 0x0403A45D RID: 238685
			AnimWarning,
			// Token: 0x0403A45E RID: 238686
			AnimCoreIn,
			// Token: 0x0403A45F RID: 238687
			AnimPoint1,
			// Token: 0x0403A460 RID: 238688
			AnimPoint2,
			// Token: 0x0403A461 RID: 238689
			AnimPoint3,
			// Token: 0x0403A462 RID: 238690
			ExtraItem,
			// Token: 0x0403A463 RID: 238691
			AnimPreColorful
		}

		// Token: 0x0200C108 RID: 49416
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x0403A465 RID: 238693
			Normal,
			// Token: 0x0403A466 RID: 238694
			Pink,
			// Token: 0x0403A467 RID: 238695
			Colorful
		}
	}
}
