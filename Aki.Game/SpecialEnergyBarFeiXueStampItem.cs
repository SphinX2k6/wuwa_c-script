using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016FC RID: 5884
public class SpecialEnergyBarFeiXueStampItem : UiPanelBase
{
	// Token: 0x0600A8C2 RID: 43202 RVA: 0x0025F910 File Offset: 0x0025DB10
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
	}

	// Token: 0x0600A8C3 RID: 43203 RVA: 0x0025F9D8 File Offset: 0x0025DBD8
	protected override void OnStart()
	{
		this.InitTweenAnim(2);
		this.InitTweenAnim(3);
		this.InitTweenAnim(4);
		this.InitTweenAnim(5);
		this.InitTweenAnim(6);
		this.InitTweenAnim(7);
		base.GetItem(0).SetUIActive(this.CurState == SpecialEnergyBarFeiXueStampItem.EState.Dis);
		base.GetItem(1).SetUIActive(this.CurState == SpecialEnergyBarFeiXueStampItem.EState.Act);
	}

	// Token: 0x0600A8C4 RID: 43204 RVA: 0x0025FA3C File Offset: 0x0025DC3C
	public void SetState(int state, bool isMoveIn)
	{
		if (this.CurState == (SpecialEnergyBarFeiXueStampItem.EState)state)
		{
			return;
		}
		bool flag = this.CurState == SpecialEnergyBarFeiXueStampItem.EState.Dis;
		bool flag2 = this.CurState == SpecialEnergyBarFeiXueStampItem.EState.Act;
		this.CurState = (SpecialEnergyBarFeiXueStampItem.EState)state;
		bool flag3 = this.CurState == SpecialEnergyBarFeiXueStampItem.EState.Dis;
		bool flag4 = this.CurState == SpecialEnergyBarFeiXueStampItem.EState.Act;
		if (flag3)
		{
			base.GetItem(0).SetUIActive(true);
			this.StopTweenAnim(5);
			this.PlayTweenAnim(4);
			if (flag2)
			{
				this.StopTweenAnim(2);
				this.StopTweenAnim(6);
				this.PlayTweenAnim(7);
				return;
			}
		}
		else if (flag4)
		{
			base.GetItem(1).SetUIActive(true);
			this.StopTweenAnim(3);
			this.StopTweenAnim(7);
			if (isMoveIn)
			{
				this.PlayTweenAnim(6);
			}
			else
			{
				this.PlayTweenAnim(2);
			}
			if (flag)
			{
				this.PlayTweenAnim(5);
				return;
			}
		}
		else
		{
			if (flag2)
			{
				this.StopTweenAnim(2);
				this.StopTweenAnim(6);
				this.PlayTweenAnim(3);
				return;
			}
			this.StopTweenAnim(4);
			this.PlayTweenAnim(5);
		}
	}

	// Token: 0x0600A8C5 RID: 43205 RVA: 0x0025FB1A File Offset: 0x0025DD1A
	protected override void OnBeforeDestroy()
	{
		this.ClearAllTweenAnim();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600A8C6 RID: 43206 RVA: 0x0025FB28 File Offset: 0x0025DD28
	protected void InitTweenAnim(int componentType)
	{
		if (this.TweenAnimPlayer == null)
		{
			this.TweenAnimPlayer = new BattleUiTweenAnimPlayer();
		}
		this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
	}

	// Token: 0x0600A8C7 RID: 43207 RVA: 0x0025FB51 File Offset: 0x0025DD51
	protected void PlayTweenAnim(int componentType)
	{
		BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
		if (tweenAnimPlayer == null)
		{
			return;
		}
		tweenAnimPlayer.PlayTweenAnim(componentType);
	}

	// Token: 0x0600A8C8 RID: 43208 RVA: 0x0025FB64 File Offset: 0x0025DD64
	protected void StopTweenAnim(int componentType)
	{
		BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
		if (tweenAnimPlayer == null)
		{
			return;
		}
		tweenAnimPlayer.StopTweenAnim(componentType);
	}

	// Token: 0x0600A8C9 RID: 43209 RVA: 0x0025FB77 File Offset: 0x0025DD77
	protected void ClearAllTweenAnim()
	{
		BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
		if (tweenAnimPlayer == null)
		{
			return;
		}
		tweenAnimPlayer.Clear(false);
	}

	// Token: 0x04004D07 RID: 19719
	[Nullable(2)]
	protected BattleUiTweenAnimPlayer TweenAnimPlayer;

	// Token: 0x04004D08 RID: 19720
	private SpecialEnergyBarFeiXueStampItem.EState CurState;

	// Token: 0x02007CBD RID: 31933
	private enum EChildType
	{
		// Token: 0x04028EB3 RID: 167603
		DisItem,
		// Token: 0x04028EB4 RID: 167604
		ActItem,
		// Token: 0x04028EB5 RID: 167605
		AniActIn,
		// Token: 0x04028EB6 RID: 167606
		AniActOut,
		// Token: 0x04028EB7 RID: 167607
		AniDisIn,
		// Token: 0x04028EB8 RID: 167608
		AniDisOut,
		// Token: 0x04028EB9 RID: 167609
		AniActMoveIn,
		// Token: 0x04028EBA RID: 167610
		AniActMoveOut
	}

	// Token: 0x02007CBE RID: 31934
	private enum EState
	{
		// Token: 0x04028EBC RID: 167612
		None,
		// Token: 0x04028EBD RID: 167613
		Dis,
		// Token: 0x04028EBE RID: 167614
		Act
	}
}
