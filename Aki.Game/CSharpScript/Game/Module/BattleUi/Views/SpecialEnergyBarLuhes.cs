using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DD0 RID: 19920
	public class SpecialEnergyBarLuhes : SpecialEnergyBarBase
	{
		// Token: 0x06032184 RID: 205188 RVA: 0x00E08A48 File Offset: 0x00E06C48
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
			for (int i = 0; i < 9; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
		}

		// Token: 0x06032185 RID: 205189 RVA: 0x00E08A88 File Offset: 0x00E06C88
		protected override void OnInitData()
		{
			base.OnInitData();
			this.ConfigList.Add(this.Config);
			this.ConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(151002));
		}

		// Token: 0x06032186 RID: 205190 RVA: 0x00E08AC0 File Offset: 0x00E06CC0
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1LuhesiMd10011.状态.超级强化状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnStateChanged));
			base.ListenForTagCountChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1LuhesiMd10011.技能.强化E使用次数"], new BaseTagComponent.TTagChangedCallback(this.OnAdvanceCountChanged));
		}

		// Token: 0x06032187 RID: 205191 RVA: 0x00E08B18 File Offset: 0x00E06D18
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarLuhes.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarLuhes.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032188 RID: 205192 RVA: 0x00E08B5C File Offset: 0x00E06D5C
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarLuhes.<InitBarItem>d__11 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarLuhes.<InitBarItem>d__11>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032189 RID: 205193 RVA: 0x00E08B9F File Offset: 0x00E06D9F
		protected override void OnStart()
		{
			base.InitTweenAnim(5);
			base.InitTweenAnim(6);
			base.InitTweenAnim(7);
			base.InitTweenAnim(8);
		}

		// Token: 0x0603218A RID: 205194 RVA: 0x00E08BBD File Offset: 0x00E06DBD
		protected override void OnBeforeShow()
		{
			this.EnteredC = false;
			this.RefreshState();
			BaseTagComponent tagComponent = this.TagComponent;
			this.UpdatePoint((tagComponent != null) ? tagComponent.GetTagCount(GameplayTagDefine.EGameplayTagId["角色.R2T1LuhesiMd10011.技能.强化E使用次数"]) : 0, true);
		}

		// Token: 0x0603218B RID: 205195 RVA: 0x00E08BF4 File Offset: 0x00E06DF4
		protected override void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer != null)
			{
				tweenAnimPlayer.Clear(true);
			}
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603218C RID: 205196 RVA: 0x00E08C0E File Offset: 0x00E06E0E
		private void OnStateChanged(int tagId, bool tagExist)
		{
			this.RefreshState();
		}

		// Token: 0x0603218D RID: 205197 RVA: 0x00E08C16 File Offset: 0x00E06E16
		private void OnAdvanceCountChanged(int count, int tagId, int exactTagId, int oldCount)
		{
			this.UpdatePoint(count, false);
		}

		// Token: 0x0603218E RID: 205198 RVA: 0x00E08C20 File Offset: 0x00E06E20
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

		// Token: 0x0603218F RID: 205199 RVA: 0x00E08C79 File Offset: 0x00E06E79
		private void RefreshState()
		{
			this.CurState = (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1LuhesiMd10011.状态.超级强化状态"]) ? SpecialEnergyBarLuhes.EState.Advance : SpecialEnergyBarLuhes.EState.Normal);
			this.SwitchKeyItem();
		}

		// Token: 0x06032190 RID: 205200 RVA: 0x00E08CA8 File Offset: 0x00E06EA8
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

		// Token: 0x06032191 RID: 205201 RVA: 0x00E08D14 File Offset: 0x00E06F14
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

		// Token: 0x0401A890 RID: 108688
		private const int ADV_BAR_ID = 151002;

		// Token: 0x0401A891 RID: 108689
		[Nullable(2)]
		private SpecialEnergyBarLuhesSlot BarSlot;

		// Token: 0x0401A892 RID: 108690
		private SpecialEnergyBarLuhes.EState CurState;

		// Token: 0x0401A893 RID: 108691
		[Nullable(1)]
		private readonly List<SpecialEnergyBarInfo> ConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401A894 RID: 108692
		private bool EnteredC;

		// Token: 0x0200AB2E RID: 43822
		private enum EState
		{
			// Token: 0x04034F12 RID: 216850
			Normal,
			// Token: 0x04034F13 RID: 216851
			Advance
		}

		// Token: 0x0200AB2F RID: 43823
		private enum EChildType
		{
			// Token: 0x04034F15 RID: 216853
			SlotBarItem,
			// Token: 0x04034F16 RID: 216854
			PnlState1,
			// Token: 0x04034F17 RID: 216855
			PnlState2,
			// Token: 0x04034F18 RID: 216856
			PnlState3,
			// Token: 0x04034F19 RID: 216857
			Point1,
			// Token: 0x04034F1A RID: 216858
			AniDefA,
			// Token: 0x04034F1B RID: 216859
			AniC2A,
			// Token: 0x04034F1C RID: 216860
			AniA2B,
			// Token: 0x04034F1D RID: 216861
			AniB2C,
			// Token: 0x04034F1E RID: 216862
			MaxCount
		}
	}
}
