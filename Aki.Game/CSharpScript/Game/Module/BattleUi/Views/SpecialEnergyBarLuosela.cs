using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DF1 RID: 24049
	public class SpecialEnergyBarLuosela : SpecialEnergyBarBase
	{
		// Token: 0x0603D224 RID: 250404 RVA: 0x00EB8258 File Offset: 0x00EB6458
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
			for (int i = 0; i < 12; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
		}

		// Token: 0x0603D225 RID: 250405 RVA: 0x00EB8298 File Offset: 0x00EB6498
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarLuosela.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarLuosela.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D226 RID: 250406 RVA: 0x00EB82DC File Offset: 0x00EB64DC
		private UniTask InitBarItem()
		{
			SpecialEnergyBarLuosela.<InitBarItem>d__10 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarLuosela.<InitBarItem>d__10>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D227 RID: 250407 RVA: 0x00EB831F File Offset: 0x00EB651F
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1LuoselaMd10011.状态.强化状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnStateChanged));
		}

		// Token: 0x0603D228 RID: 250408 RVA: 0x00EB8348 File Offset: 0x00EB6548
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

		// Token: 0x0603D229 RID: 250409 RVA: 0x00EB83CE File Offset: 0x00EB65CE
		private void OnStateChanged(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarLuosela.EState.StateB : SpecialEnergyBarLuosela.EState.StateA);
		}

		// Token: 0x0603D22A RID: 250410 RVA: 0x00EB83E0 File Offset: 0x00EB65E0
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

		// Token: 0x0603D22B RID: 250411 RVA: 0x00EB8494 File Offset: 0x00EB6694
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

		// Token: 0x0603D22C RID: 250412 RVA: 0x00EB85D3 File Offset: 0x00EB67D3
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

		// Token: 0x0603D22D RID: 250413 RVA: 0x00EB85ED File Offset: 0x00EB67ED
		protected override void OnBeforeDestroy()
		{
			this.BgItems.Clear();
			this.PointList.Clear();
			this.ConfigList.Clear();
			base.OnBeforeDestroy();
		}

		// Token: 0x0401FDE0 RID: 130528
		private const int BTN_CONFIG = 110902;

		// Token: 0x0401FDE1 RID: 130529
		[Nullable(2)]
		private SpecialEnergyBarLuoselaSlot BarSlot;

		// Token: 0x0401FDE2 RID: 130530
		[Nullable(1)]
		private readonly List<UUIItem> BgItems = new List<UUIItem>();

		// Token: 0x0401FDE3 RID: 130531
		[Nullable(1)]
		private readonly List<SpecialEnergyBarLuoselaPoint> PointList = new List<SpecialEnergyBarLuoselaPoint>();

		// Token: 0x0401FDE4 RID: 130532
		[Nullable(1)]
		private readonly List<SpecialEnergyBarInfo> ConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401FDE5 RID: 130533
		private SpecialEnergyBarLuosela.EState CurState;

		// Token: 0x0401FDE6 RID: 130534
		private int LastPoint;

		// Token: 0x0200C129 RID: 49449
		private class EChildType
		{
			// Token: 0x0403A552 RID: 238930
			public const int SlotItem = 0;

			// Token: 0x0403A553 RID: 238931
			public const int PnlNor = 1;

			// Token: 0x0403A554 RID: 238932
			public const int PnlFull = 2;

			// Token: 0x0403A555 RID: 238933
			public const int PnlUltimate = 3;

			// Token: 0x0403A556 RID: 238934
			public const int Photo1 = 4;

			// Token: 0x0403A557 RID: 238935
			public const int Photo2 = 5;

			// Token: 0x0403A558 RID: 238936
			public const int Photo3 = 6;

			// Token: 0x0403A559 RID: 238937
			public const int AniState1 = 7;

			// Token: 0x0403A55A RID: 238938
			public const int AniState2 = 8;

			// Token: 0x0403A55B RID: 238939
			public const int AniState3 = 9;

			// Token: 0x0403A55C RID: 238940
			public const int AniState0 = 10;

			// Token: 0x0403A55D RID: 238941
			public const int AniDefault = 11;

			// Token: 0x0403A55E RID: 238942
			public const int MaxCount = 12;
		}

		// Token: 0x0200C12A RID: 49450
		private enum EState
		{
			// Token: 0x0403A560 RID: 238944
			StateA,
			// Token: 0x0403A561 RID: 238945
			StateB
		}
	}
}
