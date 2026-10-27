using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DEB RID: 24043
	public class SpecialEnergyBarLuhes : SpecialEnergyBarBase
	{
		// Token: 0x0603D1F5 RID: 250357 RVA: 0x00EB7508 File Offset: 0x00EB5708
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
			for (int i = 0; i < 9; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
		}

		// Token: 0x0603D1F6 RID: 250358 RVA: 0x00EB7548 File Offset: 0x00EB5748
		protected override void OnInitData()
		{
			base.OnInitData();
			this.ConfigList.Add(this.Config);
			this.ConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(151002));
		}

		// Token: 0x0603D1F7 RID: 250359 RVA: 0x00EB7580 File Offset: 0x00EB5780
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1LuhesiMd10011.状态.超级强化状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnStateChanged));
			base.ListenForTagCountChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1LuhesiMd10011.技能.强化E使用次数"], new BaseTagComponent.TTagChangedCallback(this.OnAdvanceCountChanged));
		}

		// Token: 0x0603D1F8 RID: 250360 RVA: 0x00EB75D8 File Offset: 0x00EB57D8
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarLuhes.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarLuhes.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D1F9 RID: 250361 RVA: 0x00EB761C File Offset: 0x00EB581C
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarLuhes.<InitBarItem>d__11 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarLuhes.<InitBarItem>d__11>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D1FA RID: 250362 RVA: 0x00EB765F File Offset: 0x00EB585F
		protected override void OnStart()
		{
			base.InitTweenAnim(5);
			base.InitTweenAnim(6);
			base.InitTweenAnim(7);
			base.InitTweenAnim(8);
		}

		// Token: 0x0603D1FB RID: 250363 RVA: 0x00EB767D File Offset: 0x00EB587D
		protected override void OnBeforeShow()
		{
			this.EnteredC = false;
			this.RefreshState();
			BaseTagComponent tagComponent = this.TagComponent;
			this.UpdatePoint((tagComponent != null) ? tagComponent.GetTagCount(GameplayTagDefine.EGameplayTagId["角色.R2T1LuhesiMd10011.技能.强化E使用次数"]) : 0, true);
		}

		// Token: 0x0603D1FC RID: 250364 RVA: 0x00EB76B4 File Offset: 0x00EB58B4
		protected override void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer != null)
			{
				tweenAnimPlayer.Clear(true);
			}
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603D1FD RID: 250365 RVA: 0x00EB76CE File Offset: 0x00EB58CE
		private void OnStateChanged(int tagId, bool tagExist)
		{
			this.RefreshState();
		}

		// Token: 0x0603D1FE RID: 250366 RVA: 0x00EB76D6 File Offset: 0x00EB58D6
		private void OnAdvanceCountChanged(int count, int tagId, int exactTagId, int oldCount)
		{
			this.UpdatePoint(count, false);
		}

		// Token: 0x0603D1FF RID: 250367 RVA: 0x00EB76E0 File Offset: 0x00EB58E0
		private void SwitchKeyItem()
		{
			SpecialEnergyBarLuhesSlot barSlot = this.BarSlot;
			if (barSlot != null)
			{
				barSlot.SwitchKeyItem((this.CurState == SpecialEnergyBarLuhes.EState.Normal) ? this.ConfigList[0] : this.ConfigList[1]);
			}
			SpecialEnergyBarLuhesSlot barSlot2 = this.BarSlot;
			if (barSlot2 == null)
			{
				return;
			}
			barSlot2.SetBarState(this.CurState == SpecialEnergyBarLuhes.EState.Advance);
		}

		// Token: 0x0603D200 RID: 250368 RVA: 0x00EB7739 File Offset: 0x00EB5939
		private void RefreshState()
		{
			this.CurState = (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1LuhesiMd10011.状态.超级强化状态"]) ? SpecialEnergyBarLuhes.EState.Advance : SpecialEnergyBarLuhes.EState.Normal);
			this.SwitchKeyItem();
		}

		// Token: 0x0603D201 RID: 250369 RVA: 0x00EB7768 File Offset: 0x00EB5968
		private void UpdatePoint(int point, bool isStart = false)
		{
			if (point == 0)
			{
				this.EnteredC = false;
				BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
				if (tweenAnimPlayer == null)
				{
					return;
				}
				tweenAnimPlayer.PlayTweenAnim(isStart ? 5 : 6);
				return;
			}
			else
			{
				if (point != 1)
				{
					if (!this.EnteredC)
					{
						this.EnteredC = true;
						BattleUiTweenAnimPlayer tweenAnimPlayer2 = this.TweenAnimPlayer;
						if (tweenAnimPlayer2 == null)
						{
							return;
						}
						tweenAnimPlayer2.PlayTweenAnim(8);
					}
					return;
				}
				this.EnteredC = false;
				BattleUiTweenAnimPlayer tweenAnimPlayer3 = this.TweenAnimPlayer;
				if (tweenAnimPlayer3 == null)
				{
					return;
				}
				tweenAnimPlayer3.PlayTweenAnim(7);
				return;
			}
		}

		// Token: 0x0603D202 RID: 250370 RVA: 0x00EB77D4 File Offset: 0x00EB59D4
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarLuhesSlot barSlot = this.BarSlot;
			if (barSlot == null)
			{
				return;
			}
			barSlot.Tick(delta);
		}

		// Token: 0x0401FDC9 RID: 130505
		private const int ADV_BAR_ID = 151002;

		// Token: 0x0401FDCA RID: 130506
		[Nullable(2)]
		private SpecialEnergyBarLuhesSlot BarSlot;

		// Token: 0x0401FDCB RID: 130507
		private SpecialEnergyBarLuhes.EState CurState;

		// Token: 0x0401FDCC RID: 130508
		[Nullable(1)]
		private readonly List<SpecialEnergyBarInfo> ConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401FDCD RID: 130509
		private bool EnteredC;

		// Token: 0x0200C11F RID: 49439
		private enum EState
		{
			// Token: 0x0403A520 RID: 238880
			Normal,
			// Token: 0x0403A521 RID: 238881
			Advance
		}

		// Token: 0x0200C120 RID: 49440
		private enum EChildType
		{
			// Token: 0x0403A523 RID: 238883
			SlotBarItem,
			// Token: 0x0403A524 RID: 238884
			PnlState1,
			// Token: 0x0403A525 RID: 238885
			PnlState2,
			// Token: 0x0403A526 RID: 238886
			PnlState3,
			// Token: 0x0403A527 RID: 238887
			Point1,
			// Token: 0x0403A528 RID: 238888
			AniDefA,
			// Token: 0x0403A529 RID: 238889
			AniC2A,
			// Token: 0x0403A52A RID: 238890
			AniA2B,
			// Token: 0x0403A52B RID: 238891
			AniB2C,
			// Token: 0x0403A52C RID: 238892
			MaxCount
		}
	}
}
