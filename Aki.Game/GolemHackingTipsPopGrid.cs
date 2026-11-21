using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020004BA RID: 1210
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingTipsPopGrid : UiPanelBase
{
	// Token: 0x06003CC1 RID: 15553 RVA: 0x001578EC File Offset: 0x00155AEC
	public GolemHackingTipsPopGrid(GolemHackingTipsGirdInfo param)
	{
		this.Code = param.Code;
		this.Index = param.Index;
		this.NextIndex = param.NextIndex;
		this.Position.X = (double)param.PosX;
		this.Position.Y = (double)param.PosY;
		this.Position.Z = (double)param.PosZ;
		this.Size = param.Size;
	}

	// Token: 0x06003CC2 RID: 15554 RVA: 0x001579A0 File Offset: 0x00155BA0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06003CC3 RID: 15555 RVA: 0x00157A90 File Offset: 0x00155C90
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetText(this.Code, true);
		}
		UUIItem rootItem = base.GetRootItem();
		FVector fvector = this.Position.ToUeVectorOld();
		rootItem.SetLGUISpaceAbsolutePosition(fvector);
		this.InitLine();
	}

	// Token: 0x06003CC4 RID: 15556 RVA: 0x00157AE6 File Offset: 0x00155CE6
	protected override void OnBeforeDestroy()
	{
		this.ClearDelayTimer();
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
	}

	// Token: 0x06003CC5 RID: 15557 RVA: 0x00157B06 File Offset: 0x00155D06
	private void ClearDelayTimer()
	{
		if (this.DelayTimerHandle != null)
		{
			if (this.DelayTimerHandle.Valid())
			{
				TimerSystem.Instance.Remove(this.DelayTimerHandle);
			}
			this.DelayTimerHandle = null;
		}
	}

	// Token: 0x06003CC6 RID: 15558 RVA: 0x00157B38 File Offset: 0x00155D38
	public void PlayAnim(int index)
	{
		this.ClearDelayTimer();
		int num = index * 250;
		if (num != 0)
		{
			this.DelayTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 == null)
				{
					return;
				}
				sequencePlayer2.PlayOrReplaySequenceByName("Notice", false, null);
			}, (float)num, null, null, true, 1f);
			return;
		}
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.PlayOrReplaySequenceByName("Notice", false, null);
	}

	// Token: 0x06003CC7 RID: 15559 RVA: 0x00157B9C File Offset: 0x00155D9C
	protected void InitLine()
	{
		if (this.NextIndex == -1)
		{
			return;
		}
		int num = this.Index % this.Size;
		int num2 = this.Index / this.Size;
		int num3 = this.NextIndex % this.Size;
		int num4 = this.NextIndex / this.Size - num2;
		int num5 = num3 - num;
		UUISprite sprite = base.GetSprite(1);
		if (sprite != null)
		{
			sprite.SetUIActive(num4 > 0);
		}
		UUISprite sprite2 = base.GetSprite(0);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(num4 < 0);
		}
		UUISprite sprite3 = base.GetSprite(3);
		if (sprite3 != null)
		{
			sprite3.SetUIActive(num5 > 0);
		}
		UUISprite sprite4 = base.GetSprite(2);
		if (sprite4 != null)
		{
			sprite4.SetUIActive(num5 < 0);
		}
		if (num5 > 0)
		{
			int num6 = 135 * (num5 - 1) + 60;
			UUISprite sprite5 = base.GetSprite(3);
			if (sprite5 != null)
			{
				sprite5.SetWidth((float)num6);
			}
		}
		else if (num5 < 0)
		{
			int num7 = 135 * (-num5 - 1) + 60;
			UUISprite sprite6 = base.GetSprite(2);
			if (sprite6 != null)
			{
				sprite6.SetWidth((float)num7);
			}
		}
		if (num4 <= 0)
		{
			if (num4 < 0)
			{
				int num8 = 135 * (-num4 - 1) + 60;
				UUISprite sprite7 = base.GetSprite(0);
				if (sprite7 == null)
				{
					return;
				}
				sprite7.SetWidth((float)num8);
			}
			return;
		}
		int num9 = 135 * (num4 - 1) + 60;
		UUISprite sprite8 = base.GetSprite(1);
		if (sprite8 == null)
		{
			return;
		}
		sprite8.SetWidth((float)num9);
	}

	// Token: 0x04003103 RID: 12547
	private const int PIXEL_OFFSET = 60;

	// Token: 0x04003104 RID: 12548
	private const int GRID_WIDTH = 135;

	// Token: 0x04003105 RID: 12549
	private const int INTERVAL_TIME = 250;

	// Token: 0x04003106 RID: 12550
	protected string Code = "";

	// Token: 0x04003107 RID: 12551
	protected int Index;

	// Token: 0x04003108 RID: 12552
	protected int NextIndex = -1;

	// Token: 0x04003109 RID: 12553
	protected Vector Position = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400310A RID: 12554
	protected int Size;

	// Token: 0x0400310B RID: 12555
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0400310C RID: 12556
	[Nullable(2)]
	private TimerHandle DelayTimerHandle;
}
