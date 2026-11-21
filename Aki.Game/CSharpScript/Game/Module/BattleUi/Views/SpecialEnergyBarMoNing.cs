using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DDB RID: 19931
	public class SpecialEnergyBarMoNing : SpecialEnergyBarBase
	{
		// Token: 0x060321E8 RID: 205288 RVA: 0x00E0ACC4 File Offset: 0x00E08EC4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
			for (int i = 0; i < 12; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
		}

		// Token: 0x060321E9 RID: 205289 RVA: 0x00E0AD04 File Offset: 0x00E08F04
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1MoneMd10011.状态标识.清扫模式"], new BaseTagComponent.TTagSwitchedCallback(this.OnTagChanged));
		}

		// Token: 0x060321EA RID: 205290 RVA: 0x00E0AD2D File Offset: 0x00E08F2D
		private void OnTagChanged(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarMoNing.EState.Blue : SpecialEnergyBarMoNing.EState.Red, false);
		}

		// Token: 0x060321EB RID: 205291 RVA: 0x00E0AD40 File Offset: 0x00E08F40
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarMoNing.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarMoNing.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060321EC RID: 205292 RVA: 0x00E0AD84 File Offset: 0x00E08F84
		protected UniTask InitBarItem1()
		{
			SpecialEnergyBarMoNing.<InitBarItem1>d__11 <InitBarItem1>d__;
			<InitBarItem1>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem1>d__.<>4__this = this;
			<InitBarItem1>d__.<>1__state = -1;
			<InitBarItem1>d__.<>t__builder.Start<SpecialEnergyBarMoNing.<InitBarItem1>d__11>(ref <InitBarItem1>d__);
			return <InitBarItem1>d__.<>t__builder.Task;
		}

		// Token: 0x060321ED RID: 205293 RVA: 0x00E0ADC8 File Offset: 0x00E08FC8
		protected UniTask InitBarItem2()
		{
			SpecialEnergyBarMoNing.<InitBarItem2>d__12 <InitBarItem2>d__;
			<InitBarItem2>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem2>d__.<>4__this = this;
			<InitBarItem2>d__.<>1__state = -1;
			<InitBarItem2>d__.<>t__builder.Start<SpecialEnergyBarMoNing.<InitBarItem2>d__12>(ref <InitBarItem2>d__);
			return <InitBarItem2>d__.<>t__builder.Task;
		}

		// Token: 0x060321EE RID: 205294 RVA: 0x00E0AE0B File Offset: 0x00E0900B
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

		// Token: 0x060321EF RID: 205295 RVA: 0x00E0AE46 File Offset: 0x00E09046
		protected override void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer != null)
			{
				tweenAnimPlayer.Clear(true);
			}
			base.ClearAllTweenAnim();
		}

		// Token: 0x060321F0 RID: 205296 RVA: 0x00E0AE60 File Offset: 0x00E09060
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

		// Token: 0x060321F1 RID: 205297 RVA: 0x00E0AF23 File Offset: 0x00E09123
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

		// Token: 0x060321F2 RID: 205298 RVA: 0x00E0AF5C File Offset: 0x00E0915C
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

		// Token: 0x060321F3 RID: 205299 RVA: 0x00E0B016 File Offset: 0x00E09216
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

		// Token: 0x0401A8CE RID: 108750
		private const int DOMAIN_CONFIG = 120901;

		// Token: 0x0401A8CF RID: 108751
		[Nullable(2)]
		private SpecialEnergyBarMoNingSlot BarSlotRed;

		// Token: 0x0401A8D0 RID: 108752
		[Nullable(2)]
		private SpecialEnergyBarMoNingSlot BarSlotBlue;

		// Token: 0x0401A8D1 RID: 108753
		private SpecialEnergyBarMoNing.EState CurState;

		// Token: 0x0401A8D2 RID: 108754
		private float LastPercent = -1f;

		// Token: 0x0200AB44 RID: 43844
		private enum EState
		{
			// Token: 0x04034F8F RID: 216975
			Red,
			// Token: 0x04034F90 RID: 216976
			Blue
		}

		// Token: 0x0200AB45 RID: 43845
		private enum EChildType
		{
			// Token: 0x04034F92 RID: 216978
			SlotBarItem1,
			// Token: 0x04034F93 RID: 216979
			PnlBlue,
			// Token: 0x04034F94 RID: 216980
			PnlRed,
			// Token: 0x04034F95 RID: 216981
			PnlRedBg,
			// Token: 0x04034F96 RID: 216982
			PnlRedFullBg,
			// Token: 0x04034F97 RID: 216983
			AnimRedFull,
			// Token: 0x04034F98 RID: 216984
			AnimBlueDefault,
			// Token: 0x04034F99 RID: 216985
			AnimBlueFull,
			// Token: 0x04034F9A RID: 216986
			AnimBlueEmpty,
			// Token: 0x04034F9B RID: 216987
			AnimBlueToRed,
			// Token: 0x04034F9C RID: 216988
			AnimBlueToRedFull,
			// Token: 0x04034F9D RID: 216989
			SlotBarItem2,
			// Token: 0x04034F9E RID: 216990
			MaxCount
		}
	}
}
