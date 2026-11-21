using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DD6 RID: 19926
	public class SpecialEnergyBarLuosela : SpecialEnergyBarBase
	{
		// Token: 0x060321B3 RID: 205235 RVA: 0x00E097A0 File Offset: 0x00E079A0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
			for (int i = 0; i < 12; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
		}

		// Token: 0x060321B4 RID: 205236 RVA: 0x00E097E0 File Offset: 0x00E079E0
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarLuosela.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarLuosela.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060321B5 RID: 205237 RVA: 0x00E09824 File Offset: 0x00E07A24
		private UniTask InitBarItem()
		{
			SpecialEnergyBarLuosela.<InitBarItem>d__10 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarLuosela.<InitBarItem>d__10>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x060321B6 RID: 205238 RVA: 0x00E09867 File Offset: 0x00E07A67
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1LuoselaMd10011.状态.强化状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnStateChanged));
		}

		// Token: 0x060321B7 RID: 205239 RVA: 0x00E09890 File Offset: 0x00E07A90
		protected override void OnStart()
		{
			base.OnStart();
			this.ConfigList.Add(this.Config);
			this.ConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(110902));
			for (int i = 7; i <= 11; i++)
			{
				base.InitTweenAnim(i);
			}
			BaseTagComponent tagComponent = this.TagComponent;
			this.SetState((tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1LuoselaMd10011.状态.强化状态"])) ? SpecialEnergyBarLuosela.EState.StateB : SpecialEnergyBarLuosela.EState.StateA);
		}

		// Token: 0x060321B8 RID: 205240 RVA: 0x00E09916 File Offset: 0x00E07B16
		private void OnStateChanged(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarLuosela.EState.StateB : SpecialEnergyBarLuosela.EState.StateA);
		}

		// Token: 0x060321B9 RID: 205241 RVA: 0x00E09928 File Offset: 0x00E07B28
		private void SetState(SpecialEnergyBarLuosela.EState state)
		{
			this.PointList.ForEach(delegate(SpecialEnergyBarLuoselaPoint logic)
			{
				logic.SetUlt(state == SpecialEnergyBarLuosela.EState.StateB);
			});
			if (state == SpecialEnergyBarLuosela.EState.StateA)
			{
				SpecialEnergyBarLuoselaSlot barSlot = this.BarSlot;
				if (barSlot != null)
				{
					barSlot.SwitchKeyItem(this.ConfigList[0]);
				}
			}
			else
			{
				SpecialEnergyBarLuoselaSlot barSlot2 = this.BarSlot;
				if (barSlot2 != null)
				{
					barSlot2.SwitchKeyItem(this.ConfigList[1]);
				}
			}
			SpecialEnergyBarLuoselaSlot barSlot3 = this.BarSlot;
			if (barSlot3 != null)
			{
				barSlot3.SetSlotUlt(state == SpecialEnergyBarLuosela.EState.StateB);
			}
			SpecialEnergyBarLuoselaSlot barSlot4 = this.BarSlot;
			if (barSlot4 != null)
			{
				barSlot4.SwitchPointColor(false);
			}
			this.CurState = state;
			this.OnBarPercentChanged();
		}

		// Token: 0x060321BA RID: 205242 RVA: 0x00E099DC File Offset: 0x00E07BDC
		protected override void OnBarPercentChanged()
		{
			int num = 0;
			if (this.CurState == SpecialEnergyBarLuosela.EState.StateA)
			{
				if (this.PercentMachine.GetCurPercent() >= 1f)
				{
					num = 1;
				}
			}
			else
			{
				num = 2;
			}
			for (int i = 0; i < this.BgItems.Count; i++)
			{
				this.BgItems[i].SetUIActive(num == i);
			}
			int num2 = -1;
			if (this.PercentMachine.GetCurPercent() >= 1f)
			{
				num2 = 2;
			}
			else if (this.PercentMachine.GetCurPercent() > 0.66f)
			{
				num2 = 1;
			}
			else if (this.PercentMachine.GetCurPercent() > 0.33f)
			{
				num2 = 0;
			}
			for (int j = 0; j < this.PointList.Count; j++)
			{
				this.PointList[j].SetVisible(j <= num2);
			}
			SpecialEnergyBarLuoselaSlot barSlot = this.BarSlot;
			if (barSlot != null)
			{
				barSlot.SetSlotPoint(num2);
			}
			int num3 = Math.Max(num2, 0);
			if (Math.Abs(this.LastPoint - num3) > 1)
			{
				base.PlayTweenAnim(11);
			}
			else if (this.LastPoint < num2)
			{
				base.PlayTweenAnim(num3 + 7);
			}
			else if (this.LastPoint > num2)
			{
				if (num2 == -1)
				{
					base.PlayTweenAnim(10);
				}
				else
				{
					base.PlayTweenAnim(num3 + 7);
				}
			}
			this.LastPoint = num2;
		}

		// Token: 0x060321BB RID: 205243 RVA: 0x00E09B1B File Offset: 0x00E07D1B
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarLuoselaSlot barSlot = this.BarSlot;
			if (barSlot == null)
			{
				return;
			}
			barSlot.Tick(delta);
		}

		// Token: 0x060321BC RID: 205244 RVA: 0x00E09B35 File Offset: 0x00E07D35
		protected override void OnBeforeDestroy()
		{
			this.BgItems.Clear();
			this.PointList.Clear();
			this.ConfigList.Clear();
			base.OnBeforeDestroy();
		}

		// Token: 0x0401A8A7 RID: 108711
		private const int BTN_CONFIG = 110902;

		// Token: 0x0401A8A8 RID: 108712
		[Nullable(2)]
		private SpecialEnergyBarLuoselaSlot BarSlot;

		// Token: 0x0401A8A9 RID: 108713
		[Nullable(1)]
		private readonly List<UUIItem> BgItems = new List<UUIItem>();

		// Token: 0x0401A8AA RID: 108714
		[Nullable(1)]
		private readonly List<SpecialEnergyBarLuoselaPoint> PointList = new List<SpecialEnergyBarLuoselaPoint>();

		// Token: 0x0401A8AB RID: 108715
		[Nullable(1)]
		private readonly List<SpecialEnergyBarInfo> ConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401A8AC RID: 108716
		private SpecialEnergyBarLuosela.EState CurState;

		// Token: 0x0401A8AD RID: 108717
		private int LastPoint;

		// Token: 0x0200AB38 RID: 43832
		private class EChildType
		{
			// Token: 0x04034F44 RID: 216900
			public const int SlotItem = 0;

			// Token: 0x04034F45 RID: 216901
			public const int PnlNor = 1;

			// Token: 0x04034F46 RID: 216902
			public const int PnlFull = 2;

			// Token: 0x04034F47 RID: 216903
			public const int PnlUltimate = 3;

			// Token: 0x04034F48 RID: 216904
			public const int Photo1 = 4;

			// Token: 0x04034F49 RID: 216905
			public const int Photo2 = 5;

			// Token: 0x04034F4A RID: 216906
			public const int Photo3 = 6;

			// Token: 0x04034F4B RID: 216907
			public const int AniState1 = 7;

			// Token: 0x04034F4C RID: 216908
			public const int AniState2 = 8;

			// Token: 0x04034F4D RID: 216909
			public const int AniState3 = 9;

			// Token: 0x04034F4E RID: 216910
			public const int AniState0 = 10;

			// Token: 0x04034F4F RID: 216911
			public const int AniDefault = 11;

			// Token: 0x04034F50 RID: 216912
			public const int MaxCount = 12;
		}

		// Token: 0x0200AB39 RID: 43833
		private enum EState
		{
			// Token: 0x04034F52 RID: 216914
			StateA,
			// Token: 0x04034F53 RID: 216915
			StateB
		}
	}
}
