using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DE7 RID: 19943
	public class SpecialEnergyBarSuizhe : SpecialEnergyBarBase
	{
		// Token: 0x06032298 RID: 205464 RVA: 0x00E0EA00 File Offset: 0x00E0CC00
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
			for (int i = 0; i < 4; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
		}

		// Token: 0x06032299 RID: 205465 RVA: 0x00E0EA3F File Offset: 0x00E0CC3F
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarSuizhe.AdvanceStateTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStateChanged));
		}

		// Token: 0x0603229A RID: 205466 RVA: 0x00E0EA60 File Offset: 0x00E0CC60
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarSuizhe.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarSuizhe.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603229B RID: 205467 RVA: 0x00E0EAA4 File Offset: 0x00E0CCA4
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarSuizhe.<InitBarItem>d__8 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarSuizhe.<InitBarItem>d__8>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603229C RID: 205468 RVA: 0x00E0EAE8 File Offset: 0x00E0CCE8
		protected override void OnStart()
		{
			BaseTagComponent tagComponent = this.TagComponent;
			SpecialEnergyBarSuizhe.EState state = (tagComponent != null && tagComponent.HasTag(SpecialEnergyBarSuizhe.AdvanceStateTagId)) ? SpecialEnergyBarSuizhe.EState.Advance : SpecialEnergyBarSuizhe.EState.Normal;
			this.SetState(state);
		}

		// Token: 0x0603229D RID: 205469 RVA: 0x00E0EB1A File Offset: 0x00E0CD1A
		private void OnStateChanged(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarSuizhe.EState.Advance : SpecialEnergyBarSuizhe.EState.Normal);
		}

		// Token: 0x0603229E RID: 205470 RVA: 0x00E0EB29 File Offset: 0x00E0CD29
		private void SetState(SpecialEnergyBarSuizhe.EState state)
		{
			base.GetItem(1).SetUIActive(state == SpecialEnergyBarSuizhe.EState.Advance);
			SpecialEnergyBarSlot barSlotA = this.BarSlotA;
			if (barSlotA != null)
			{
				barSlotA.SetUiActive(state == SpecialEnergyBarSuizhe.EState.Normal);
			}
			SpecialEnergyBarSlot barSlotB = this.BarSlotB;
			if (barSlotB == null)
			{
				return;
			}
			barSlotB.SetUiActive(state == SpecialEnergyBarSuizhe.EState.Advance);
		}

		// Token: 0x0603229F RID: 205471 RVA: 0x00E0EB64 File Offset: 0x00E0CD64
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarSlot barSlotA = this.BarSlotA;
			if (barSlotA != null)
			{
				barSlotA.Tick(delta);
			}
			SpecialEnergyBarSlot barSlotB = this.BarSlotB;
			if (barSlotB == null)
			{
				return;
			}
			barSlotB.Tick(delta);
		}

		// Token: 0x0401A948 RID: 108872
		[StaticVariableRuleIgnore]
		private static readonly int AdvanceStateTagId = GameplayTagDefine.EGameplayTagId["怪物.MB1SuiZheMd00501.状态.登神解放状态"];

		// Token: 0x0401A949 RID: 108873
		[Nullable(2)]
		private SpecialEnergyBarSlot BarSlotA;

		// Token: 0x0401A94A RID: 108874
		[Nullable(2)]
		private SpecialEnergyBarSlot BarSlotB;

		// Token: 0x0200AB67 RID: 43879
		private enum EChildType
		{
			// Token: 0x04035078 RID: 217208
			BgNormal,
			// Token: 0x04035079 RID: 217209
			BgFull,
			// Token: 0x0403507A RID: 217210
			SlotBarItemA,
			// Token: 0x0403507B RID: 217211
			SlotBarItemB,
			// Token: 0x0403507C RID: 217212
			MaxCount
		}

		// Token: 0x0200AB68 RID: 43880
		private enum EState
		{
			// Token: 0x0403507E RID: 217214
			Normal,
			// Token: 0x0403507F RID: 217215
			Advance
		}
	}
}
