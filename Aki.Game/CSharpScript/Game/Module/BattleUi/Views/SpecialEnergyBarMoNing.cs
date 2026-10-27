using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DF6 RID: 24054
	public class SpecialEnergyBarMoNing : SpecialEnergyBarBase
	{
		// Token: 0x0603D259 RID: 250457 RVA: 0x00EB977C File Offset: 0x00EB797C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
			for (int i = 0; i < 12; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
		}

		// Token: 0x0603D25A RID: 250458 RVA: 0x00EB97BC File Offset: 0x00EB79BC
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1MoneMd10011.状态标识.清扫模式"], new BaseTagComponent.TTagSwitchedCallback(this.OnTagChanged));
		}

		// Token: 0x0603D25B RID: 250459 RVA: 0x00EB97E5 File Offset: 0x00EB79E5
		private void OnTagChanged(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarMoNing.EState.Blue : SpecialEnergyBarMoNing.EState.Red, false);
		}

		// Token: 0x0603D25C RID: 250460 RVA: 0x00EB97F8 File Offset: 0x00EB79F8
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarMoNing.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarMoNing.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D25D RID: 250461 RVA: 0x00EB983C File Offset: 0x00EB7A3C
		protected UniTask InitBarItem1()
		{
			SpecialEnergyBarMoNing.<InitBarItem1>d__11 <InitBarItem1>d__;
			<InitBarItem1>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem1>d__.<>4__this = this;
			<InitBarItem1>d__.<>1__state = -1;
			<InitBarItem1>d__.<>t__builder.Start<SpecialEnergyBarMoNing.<InitBarItem1>d__11>(ref <InitBarItem1>d__);
			return <InitBarItem1>d__.<>t__builder.Task;
		}

		// Token: 0x0603D25E RID: 250462 RVA: 0x00EB9880 File Offset: 0x00EB7A80
		protected UniTask InitBarItem2()
		{
			SpecialEnergyBarMoNing.<InitBarItem2>d__12 <InitBarItem2>d__;
			<InitBarItem2>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem2>d__.<>4__this = this;
			<InitBarItem2>d__.<>1__state = -1;
			<InitBarItem2>d__.<>t__builder.Start<SpecialEnergyBarMoNing.<InitBarItem2>d__12>(ref <InitBarItem2>d__);
			return <InitBarItem2>d__.<>t__builder.Task;
		}

		// Token: 0x0603D25F RID: 250463 RVA: 0x00EB98C3 File Offset: 0x00EB7AC3
		protected override void OnStart()
		{
			base.InitTweenAnim(5);
			base.InitTweenAnim(8);
			base.InitTweenAnim(10);
			base.InitTweenAnim(9);
			base.InitTweenAnim(6);
			base.InitTweenAnim(7);
			this.RefreshState(true);
			this.OnBarPercentChanged();
		}

		// Token: 0x0603D260 RID: 250464 RVA: 0x00EB98FE File Offset: 0x00EB7AFE
		protected override void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer != null)
			{
				tweenAnimPlayer.Clear(true);
			}
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603D261 RID: 250465 RVA: 0x00EB9918 File Offset: 0x00EB7B18
		protected override void OnBarPercentChanged()
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool flag = this.LastPercent >= 1f && curPercent < 1f;
			bool flag2 = this.LastPercent < 1f && curPercent >= 1f;
			int num = 0;
			if ((double)curPercent <= 1E-08)
			{
				num = -1;
			}
			else if ((double)curPercent >= 0.99999999)
			{
				num = 1;
			}
			if (this.CurState == SpecialEnergyBarMoNing.EState.Blue)
			{
				if (flag)
				{
					base.PlayTweenAnim(8);
				}
				else if (flag2)
				{
					base.PlayTweenAnim(7);
				}
			}
			else
			{
				if (num != 1)
				{
					base.GetItem(3).SetUIActive(true);
				}
				base.GetItem(4).SetUIActive(num == 1);
				if (flag2)
				{
					base.PlayTweenAnim(5);
				}
			}
			this.LastPercent = curPercent;
		}

		// Token: 0x0603D262 RID: 250466 RVA: 0x00EB99DB File Offset: 0x00EB7BDB
		private void RefreshState(bool isStart = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1MoneMd10011.状态标识.清扫模式"]))
			{
				this.SetState(SpecialEnergyBarMoNing.EState.Blue, isStart);
				return;
			}
			this.SetState(SpecialEnergyBarMoNing.EState.Red, isStart);
		}

		// Token: 0x0603D263 RID: 250467 RVA: 0x00EB9A14 File Offset: 0x00EB7C14
		private void SetState(SpecialEnergyBarMoNing.EState state, bool isStart = false)
		{
			if (state == this.CurState && !isStart)
			{
				return;
			}
			this.CurState = state;
			this.LastPercent = -1f;
			SpecialEnergyBarMoNing.EState curState = this.CurState;
			if (curState != SpecialEnergyBarMoNing.EState.Red)
			{
				if (curState == SpecialEnergyBarMoNing.EState.Blue)
				{
					UUIItem item = base.GetItem(1);
					if (item != null)
					{
						item.SetUIActive(true);
					}
					UUIItem item2 = base.GetItem(2);
					if (item2 != null)
					{
						item2.SetUIActive(false);
					}
					base.PlayTweenAnim(6);
				}
			}
			else
			{
				UUIItem item3 = base.GetItem(1);
				if (item3 != null)
				{
					item3.SetUIActive(false);
				}
				UUIItem item4 = base.GetItem(2);
				if (item4 != null)
				{
					item4.SetUIActive(true);
				}
				base.PlayTweenAnim(9);
			}
			base.GetItem(0).SetUIActive(state == SpecialEnergyBarMoNing.EState.Red);
			base.GetItem(11).SetUIActive(state == SpecialEnergyBarMoNing.EState.Blue);
		}

		// Token: 0x0603D264 RID: 250468 RVA: 0x00EB9ACE File Offset: 0x00EB7CCE
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarMoNingSlot barSlotRed = this.BarSlotRed;
			if (barSlotRed != null)
			{
				barSlotRed.Tick(delta);
			}
			SpecialEnergyBarMoNingSlot barSlotBlue = this.BarSlotBlue;
			if (barSlotBlue == null)
			{
				return;
			}
			barSlotBlue.Tick(delta);
		}

		// Token: 0x0401FE07 RID: 130567
		private const int DOMAIN_CONFIG = 120901;

		// Token: 0x0401FE08 RID: 130568
		[Nullable(2)]
		private SpecialEnergyBarMoNingSlot BarSlotRed;

		// Token: 0x0401FE09 RID: 130569
		[Nullable(2)]
		private SpecialEnergyBarMoNingSlot BarSlotBlue;

		// Token: 0x0401FE0A RID: 130570
		private SpecialEnergyBarMoNing.EState CurState;

		// Token: 0x0401FE0B RID: 130571
		private float LastPercent = -1f;

		// Token: 0x0200C135 RID: 49461
		private enum EState
		{
			// Token: 0x0403A59D RID: 239005
			Red,
			// Token: 0x0403A59E RID: 239006
			Blue
		}

		// Token: 0x0200C136 RID: 49462
		private enum EChildType
		{
			// Token: 0x0403A5A0 RID: 239008
			SlotBarItem1,
			// Token: 0x0403A5A1 RID: 239009
			PnlBlue,
			// Token: 0x0403A5A2 RID: 239010
			PnlRed,
			// Token: 0x0403A5A3 RID: 239011
			PnlRedBg,
			// Token: 0x0403A5A4 RID: 239012
			PnlRedFullBg,
			// Token: 0x0403A5A5 RID: 239013
			AnimRedFull,
			// Token: 0x0403A5A6 RID: 239014
			AnimBlueDefault,
			// Token: 0x0403A5A7 RID: 239015
			AnimBlueFull,
			// Token: 0x0403A5A8 RID: 239016
			AnimBlueEmpty,
			// Token: 0x0403A5A9 RID: 239017
			AnimBlueToRed,
			// Token: 0x0403A5AA RID: 239018
			AnimBlueToRedFull,
			// Token: 0x0403A5AB RID: 239019
			SlotBarItem2,
			// Token: 0x0403A5AC RID: 239020
			MaxCount
		}
	}
}
