using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E02 RID: 24066
	public class SpecialEnergyBarSuizhe : SpecialEnergyBarBase
	{
		// Token: 0x0603D309 RID: 250633 RVA: 0x00EBD4A0 File Offset: 0x00EBB6A0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
			for (int i = 0; i < 4; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
		}

		// Token: 0x0603D30A RID: 250634 RVA: 0x00EBD4DF File Offset: 0x00EBB6DF
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarSuizhe.AdvanceStateTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStateChanged));
		}

		// Token: 0x0603D30B RID: 250635 RVA: 0x00EBD500 File Offset: 0x00EBB700
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarSuizhe.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarSuizhe.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D30C RID: 250636 RVA: 0x00EBD544 File Offset: 0x00EBB744
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarSuizhe.<InitBarItem>d__8 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarSuizhe.<InitBarItem>d__8>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D30D RID: 250637 RVA: 0x00EBD588 File Offset: 0x00EBB788
		protected override void OnStart()
		{
			BaseTagComponent tagComponent = this.TagComponent;
			SpecialEnergyBarSuizhe.EState state = (tagComponent != null && tagComponent.HasTag(SpecialEnergyBarSuizhe.AdvanceStateTagId)) ? SpecialEnergyBarSuizhe.EState.Advance : SpecialEnergyBarSuizhe.EState.Normal;
			this.SetState(state);
		}

		// Token: 0x0603D30E RID: 250638 RVA: 0x00EBD5BA File Offset: 0x00EBB7BA
		private void OnStateChanged(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarSuizhe.EState.Advance : SpecialEnergyBarSuizhe.EState.Normal);
		}

		// Token: 0x0603D30F RID: 250639 RVA: 0x00EBD5C9 File Offset: 0x00EBB7C9
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

		// Token: 0x0603D310 RID: 250640 RVA: 0x00EBD604 File Offset: 0x00EBB804
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

		// Token: 0x0401FE81 RID: 130689
		[StaticVariableRuleIgnore]
		private static readonly int AdvanceStateTagId = GameplayTagDefine.EGameplayTagId["怪物.MB1SuiZheMd00501.状态.登神解放状态"];

		// Token: 0x0401FE82 RID: 130690
		[Nullable(2)]
		private SpecialEnergyBarSlot BarSlotA;

		// Token: 0x0401FE83 RID: 130691
		[Nullable(2)]
		private SpecialEnergyBarSlot BarSlotB;

		// Token: 0x0200C158 RID: 49496
		private enum EChildType
		{
			// Token: 0x0403A686 RID: 239238
			BgNormal,
			// Token: 0x0403A687 RID: 239239
			BgFull,
			// Token: 0x0403A688 RID: 239240
			SlotBarItemA,
			// Token: 0x0403A689 RID: 239241
			SlotBarItemB,
			// Token: 0x0403A68A RID: 239242
			MaxCount
		}

		// Token: 0x0200C159 RID: 49497
		private enum EState
		{
			// Token: 0x0403A68C RID: 239244
			Normal,
			// Token: 0x0403A68D RID: 239245
			Advance
		}
	}
}
