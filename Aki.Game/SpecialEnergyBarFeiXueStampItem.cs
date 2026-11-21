using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000BB4 RID: 2996
public class SpecialEnergyBarFeiXueStampItem : UiPanelBase
{
	// Token: 0x06007CA2 RID: 31906 RVA: 0x00269D2C File Offset: 0x00267F2C
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

	// Token: 0x06007CA3 RID: 31907 RVA: 0x00269DF4 File Offset: 0x00267FF4
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

	// Token: 0x06007CA4 RID: 31908 RVA: 0x00269E58 File Offset: 0x00268058
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

	// Token: 0x06007CA5 RID: 31909 RVA: 0x00269F36 File Offset: 0x00268136
	protected override void OnBeforeDestroy()
	{
		this.ClearAllTweenAnim();
		base.OnBeforeDestroy();
	}

	// Token: 0x06007CA6 RID: 31910 RVA: 0x00269F44 File Offset: 0x00268144
	protected void InitTweenAnim(int componentType)
	{
		if (this.TweenAnimPlayer == null)
		{
			this.TweenAnimPlayer = new BattleUiTweenAnimPlayer();
		}
		this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
	}

	// Token: 0x06007CA7 RID: 31911 RVA: 0x00269F6D File Offset: 0x0026816D
	protected void PlayTweenAnim(int componentType)
	{
		BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
		if (tweenAnimPlayer == null)
		{
			return;
		}
		tweenAnimPlayer.PlayTweenAnim(componentType);
	}

	// Token: 0x06007CA8 RID: 31912 RVA: 0x00269F80 File Offset: 0x00268180
	protected void StopTweenAnim(int componentType)
	{
		BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
		if (tweenAnimPlayer == null)
		{
			return;
		}
		tweenAnimPlayer.StopTweenAnim(componentType);
	}

	// Token: 0x06007CA9 RID: 31913 RVA: 0x00269F93 File Offset: 0x00268193
	protected void ClearAllTweenAnim()
	{
		BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
		if (tweenAnimPlayer == null)
		{
			return;
		}
		tweenAnimPlayer.Clear(false);
	}

	// Token: 0x04004DAE RID: 19886
	[Nullable(2)]
	protected BattleUiTweenAnimPlayer TweenAnimPlayer;

	// Token: 0x04004DAF RID: 19887
	private SpecialEnergyBarFeiXueStampItem.EState CurState;

	// Token: 0x02006E42 RID: 28226
	private enum EChildType
	{
		// Token: 0x040241DC RID: 147932
		DisItem,
		// Token: 0x040241DD RID: 147933
		ActItem,
		// Token: 0x040241DE RID: 147934
		AniActIn,
		// Token: 0x040241DF RID: 147935
		AniActOut,
		// Token: 0x040241E0 RID: 147936
		AniDisIn,
		// Token: 0x040241E1 RID: 147937
		AniDisOut,
		// Token: 0x040241E2 RID: 147938
		AniActMoveIn,
		// Token: 0x040241E3 RID: 147939
		AniActMoveOut
	}

	// Token: 0x02006E43 RID: 28227
	private enum EState
	{
		// Token: 0x040241E5 RID: 147941
		None,
		// Token: 0x040241E6 RID: 147942
		Dis,
		// Token: 0x040241E7 RID: 147943
		Act
	}
}
