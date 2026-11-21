using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001406 RID: 5126
public class AimUnit : HudUnitBase
{
	// Token: 0x0600CB84 RID: 52100 RVA: 0x003C8F40 File Offset: 0x003C7140
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CB85 RID: 52101 RVA: 0x003C911C File Offset: 0x003C731C
	protected override void OnStart()
	{
		this.ColorSpriteList = new UUISprite[]
		{
			base.GetSprite(1),
			base.GetSprite(2),
			base.GetSprite(3),
			base.GetSprite(4),
			base.GetSprite(5),
			base.GetSprite(6),
			base.GetSprite(7),
			base.GetSprite(8),
			base.GetSprite(9),
			base.GetSprite(10),
			base.GetSprite(11)
		};
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600CB86 RID: 52102 RVA: 0x003C91BA File Offset: 0x003C73BA
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
		this.ClearCloserTimer();
	}

	// Token: 0x0600CB87 RID: 52103 RVA: 0x003C91DC File Offset: 0x003C73DC
	public void SetTargetVisible(bool visible, bool immediately)
	{
		this.TargetVisible = visible;
		this.ClearCloserTimer();
		if (!immediately && !visible && base.GetActive() && this.AimStatus != EAimStatus.None)
		{
			this.SetAimStatus(EAimStatus.None);
			return;
		}
		if (visible)
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			base.GetItem(0).SetAlpha(1f);
		}
		base.SetVisible(visible, 0);
	}

	// Token: 0x0600CB88 RID: 52104 RVA: 0x003C923D File Offset: 0x003C743D
	public bool GetTargetVisible()
	{
		return this.TargetVisible;
	}

	// Token: 0x0600CB89 RID: 52105 RVA: 0x003C9248 File Offset: 0x003C7448
	public void SetAimStatus(EAimStatus status)
	{
		if (this.AimStatus == status)
		{
			return;
		}
		switch (status)
		{
		case EAimStatus.None:
			this.SetCloseAim();
			break;
		case EAimStatus.NoTarget:
			this.SetNormalAim();
			break;
		case EAimStatus.Target:
			this.SetTargetAim();
			break;
		case EAimStatus.Weakness:
			this.SetWeaknessAim();
			break;
		}
		this.AimStatus = status;
	}

	// Token: 0x0600CB8A RID: 52106 RVA: 0x003C929C File Offset: 0x003C749C
	private void SetNormalAim()
	{
		this.SetRedColor(false);
		this.SetArrowVisible(false);
		if (this.AimStatus == EAimStatus.Weakness)
		{
			this.PlayAnim("Change", true);
			return;
		}
		if (this.AimStatus == EAimStatus.None)
		{
			this.PlayAnim("Start1", false);
		}
	}

	// Token: 0x0600CB8B RID: 52107 RVA: 0x003C92D6 File Offset: 0x003C74D6
	private void SetTargetAim()
	{
		this.SetRedColor(true);
		this.SetArrowVisible(false);
		if (this.AimStatus == EAimStatus.Weakness)
		{
			this.PlayAnim("Change", true);
			return;
		}
		if (this.AimStatus == EAimStatus.None)
		{
			this.PlayAnim("Start1", false);
		}
	}

	// Token: 0x0600CB8C RID: 52108 RVA: 0x003C9310 File Offset: 0x003C7510
	private void SetWeaknessAim()
	{
		this.SetRedColor(true);
		this.SetArrowVisible(true);
		if (this.AimStatus == EAimStatus.Target || this.AimStatus == EAimStatus.NoTarget)
		{
			this.PlayAnim("Change", false);
			return;
		}
		if (this.AimStatus == EAimStatus.None)
		{
			this.PlayAnim("Start2", false);
		}
	}

	// Token: 0x0600CB8D RID: 52109 RVA: 0x003C935E File Offset: 0x003C755E
	private void SetCloseAim()
	{
		this.PlayAnim("close", false);
		this.StartCloseTimer();
	}

	// Token: 0x0600CB8E RID: 52110 RVA: 0x003C9374 File Offset: 0x003C7574
	[NullableContext(1)]
	private void PlayAnim(string sequenceName, bool playReverse = false)
	{
		this.ClearCloserTimer();
		this.LevelSequencePlayer.StopCurrentSequence(false, false);
		this.LevelSequencePlayer.PlaySequencePurely(sequenceName, false, playReverse, null, null, false);
	}

	// Token: 0x0600CB8F RID: 52111 RVA: 0x003C93AD File Offset: 0x003C75AD
	public override void SetActive(bool visibility)
	{
		if (visibility && !this.TargetVisible)
		{
			return;
		}
		base.SetActive(visibility);
	}

	// Token: 0x0600CB90 RID: 52112 RVA: 0x003C93C2 File Offset: 0x003C75C2
	private void StartCloseTimer()
	{
		this.CloseTimerId = TimerSystem.Instance.Delay(delegate(float id)
		{
			this.SetActive(false);
			this.CloseTimerId = null;
		}, 200f, null, null, true, 1f);
	}

	// Token: 0x0600CB91 RID: 52113 RVA: 0x003C93ED File Offset: 0x003C75ED
	private void ClearCloserTimer()
	{
		if (this.CloseTimerId != null)
		{
			TimerSystem.Instance.Remove(this.CloseTimerId);
			this.CloseTimerId = null;
		}
	}

	// Token: 0x0600CB92 RID: 52114 RVA: 0x003C9410 File Offset: 0x003C7610
	private void SetRedColor(bool isRedColor)
	{
		if (this.IsRedColor == isRedColor)
		{
			return;
		}
		this.IsRedColor = isRedColor;
		FColor color = this.IsRedColor ? AimUnit.ColorRed : AimUnit.ColorWhite;
		UUISprite[] colorSpriteList = this.ColorSpriteList;
		for (int i = 0; i < colorSpriteList.Length; i++)
		{
			colorSpriteList[i].SetColor(color);
		}
	}

	// Token: 0x0600CB93 RID: 52115 RVA: 0x003C9464 File Offset: 0x003C7664
	private void SetArrowVisible(bool visible)
	{
		base.GetSprite(6).SetAlpha(!visible);
		base.GetSprite(7).SetAlpha(!visible);
		base.GetSprite(8).SetAlpha(visible > false);
		base.GetSprite(9).SetAlpha(visible > false);
	}

	// Token: 0x0600CB94 RID: 52116 RVA: 0x003C94B6 File Offset: 0x003C76B6
	public void SetArrowLineVisible(bool visible)
	{
		UUIItem item = base.GetItem(12);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(visible);
	}

	// Token: 0x04007398 RID: 29592
	private const int CloseAnimTime = 200;

	// Token: 0x04007399 RID: 29593
	private const int MaxByte = 255;

	// Token: 0x0400739A RID: 29594
	private static readonly FColor ColorWhite = new FColor(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

	// Token: 0x0400739B RID: 29595
	private static readonly FColor ColorRed = new FColor(byte.MaxValue, 0, 0, byte.MaxValue);

	// Token: 0x0400739C RID: 29596
	private EAimStatus AimStatus;

	// Token: 0x0400739D RID: 29597
	private bool TargetVisible;

	// Token: 0x0400739E RID: 29598
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private UUISprite[] ColorSpriteList;

	// Token: 0x0400739F RID: 29599
	private bool IsRedColor;

	// Token: 0x040073A0 RID: 29600
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040073A1 RID: 29601
	[Nullable(2)]
	private TimerHandle CloseTimerId;

	// Token: 0x020076B9 RID: 30393
	private enum EChildType
	{
		// Token: 0x040268F5 RID: 157941
		AnimNode,
		// Token: 0x040268F6 RID: 157942
		RingUpL,
		// Token: 0x040268F7 RID: 157943
		RingDownL,
		// Token: 0x040268F8 RID: 157944
		RingUpR,
		// Token: 0x040268F9 RID: 157945
		RingDownR,
		// Token: 0x040268FA RID: 157946
		Dot,
		// Token: 0x040268FB RID: 157947
		LineUp,
		// Token: 0x040268FC RID: 157948
		LineDown,
		// Token: 0x040268FD RID: 157949
		ArrowUp,
		// Token: 0x040268FE RID: 157950
		ArrowDown,
		// Token: 0x040268FF RID: 157951
		LineL,
		// Token: 0x04026900 RID: 157952
		LineR,
		// Token: 0x04026901 RID: 157953
		LineNode
	}
}
