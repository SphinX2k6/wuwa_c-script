using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001F44 RID: 8004
public class AimUnit : HudUnitBase
{
	// Token: 0x0600F765 RID: 63333 RVA: 0x003BD454 File Offset: 0x003BB654
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

	// Token: 0x0600F766 RID: 63334 RVA: 0x003BD630 File Offset: 0x003BB830
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

	// Token: 0x0600F767 RID: 63335 RVA: 0x003BD6CE File Offset: 0x003BB8CE
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

	// Token: 0x0600F768 RID: 63336 RVA: 0x003BD6F0 File Offset: 0x003BB8F0
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

	// Token: 0x0600F769 RID: 63337 RVA: 0x003BD751 File Offset: 0x003BB951
	public bool GetTargetVisible()
	{
		return this.TargetVisible;
	}

	// Token: 0x0600F76A RID: 63338 RVA: 0x003BD75C File Offset: 0x003BB95C
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

	// Token: 0x0600F76B RID: 63339 RVA: 0x003BD7B0 File Offset: 0x003BB9B0
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

	// Token: 0x0600F76C RID: 63340 RVA: 0x003BD7EA File Offset: 0x003BB9EA
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

	// Token: 0x0600F76D RID: 63341 RVA: 0x003BD824 File Offset: 0x003BBA24
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

	// Token: 0x0600F76E RID: 63342 RVA: 0x003BD872 File Offset: 0x003BBA72
	private void SetCloseAim()
	{
		this.PlayAnim("close", false);
		this.StartCloseTimer();
	}

	// Token: 0x0600F76F RID: 63343 RVA: 0x003BD888 File Offset: 0x003BBA88
	[NullableContext(1)]
	private void PlayAnim(string sequenceName, bool playReverse = false)
	{
		this.ClearCloserTimer();
		this.LevelSequencePlayer.StopCurrentSequence(false, false);
		this.LevelSequencePlayer.PlaySequencePurely(sequenceName, false, playReverse, null, null, false);
	}

	// Token: 0x0600F770 RID: 63344 RVA: 0x003BD8C1 File Offset: 0x003BBAC1
	public override void SetActive(bool visibility)
	{
		if (visibility && !this.TargetVisible)
		{
			return;
		}
		base.SetActive(visibility);
	}

	// Token: 0x0600F771 RID: 63345 RVA: 0x003BD8D6 File Offset: 0x003BBAD6
	private void StartCloseTimer()
	{
		this.CloseTimerId = TimerSystem.Instance.Delay(delegate(float id)
		{
			this.SetActive(false);
			this.CloseTimerId = null;
		}, 200f, null, null, true, 1f);
	}

	// Token: 0x0600F772 RID: 63346 RVA: 0x003BD901 File Offset: 0x003BBB01
	private void ClearCloserTimer()
	{
		if (this.CloseTimerId != null)
		{
			TimerSystem.Instance.Remove(this.CloseTimerId);
			this.CloseTimerId = null;
		}
	}

	// Token: 0x0600F773 RID: 63347 RVA: 0x003BD924 File Offset: 0x003BBB24
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

	// Token: 0x0600F774 RID: 63348 RVA: 0x003BD978 File Offset: 0x003BBB78
	private void SetArrowVisible(bool visible)
	{
		base.GetSprite(6).SetAlpha(!visible);
		base.GetSprite(7).SetAlpha(!visible);
		base.GetSprite(8).SetAlpha(visible > false);
		base.GetSprite(9).SetAlpha(visible > false);
	}

	// Token: 0x0600F775 RID: 63349 RVA: 0x003BD9CA File Offset: 0x003BBBCA
	public void SetArrowLineVisible(bool visible)
	{
		UUIItem item = base.GetItem(12);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(visible);
	}

	// Token: 0x040072B7 RID: 29367
	private const int CloseAnimTime = 200;

	// Token: 0x040072B8 RID: 29368
	private const int MaxByte = 255;

	// Token: 0x040072B9 RID: 29369
	private static readonly FColor ColorWhite = new FColor(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

	// Token: 0x040072BA RID: 29370
	private static readonly FColor ColorRed = new FColor(byte.MaxValue, 0, 0, byte.MaxValue);

	// Token: 0x040072BB RID: 29371
	private EAimStatus AimStatus;

	// Token: 0x040072BC RID: 29372
	private bool TargetVisible;

	// Token: 0x040072BD RID: 29373
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private UUISprite[] ColorSpriteList;

	// Token: 0x040072BE RID: 29374
	private bool IsRedColor;

	// Token: 0x040072BF RID: 29375
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040072C0 RID: 29376
	[Nullable(2)]
	private TimerHandle CloseTimerId;

	// Token: 0x02008534 RID: 34100
	private enum EChildType
	{
		// Token: 0x0402B5D1 RID: 177617
		AnimNode,
		// Token: 0x0402B5D2 RID: 177618
		RingUpL,
		// Token: 0x0402B5D3 RID: 177619
		RingDownL,
		// Token: 0x0402B5D4 RID: 177620
		RingUpR,
		// Token: 0x0402B5D5 RID: 177621
		RingDownR,
		// Token: 0x0402B5D6 RID: 177622
		Dot,
		// Token: 0x0402B5D7 RID: 177623
		LineUp,
		// Token: 0x0402B5D8 RID: 177624
		LineDown,
		// Token: 0x0402B5D9 RID: 177625
		ArrowUp,
		// Token: 0x0402B5DA RID: 177626
		ArrowDown,
		// Token: 0x0402B5DB RID: 177627
		LineL,
		// Token: 0x0402B5DC RID: 177628
		LineR,
		// Token: 0x0402B5DD RID: 177629
		LineNode
	}
}
