using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001006 RID: 4102
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingTipsPopGrid : UiPanelBase
{
	// Token: 0x0600692C RID: 26924 RVA: 0x0014EFC4 File Offset: 0x0014D1C4
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

	// Token: 0x0600692D RID: 26925 RVA: 0x0014F078 File Offset: 0x0014D278
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

	// Token: 0x0600692E RID: 26926 RVA: 0x0014F168 File Offset: 0x0014D368
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

	// Token: 0x0600692F RID: 26927 RVA: 0x0014F1BE File Offset: 0x0014D3BE
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

	// Token: 0x06006930 RID: 26928 RVA: 0x0014F1DE File Offset: 0x0014D3DE
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

	// Token: 0x06006931 RID: 26929 RVA: 0x0014F210 File Offset: 0x0014D410
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

	// Token: 0x06006932 RID: 26930 RVA: 0x0014F274 File Offset: 0x0014D474
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

	// Token: 0x0400306A RID: 12394
	private const int PIXEL_OFFSET = 60;

	// Token: 0x0400306B RID: 12395
	private const int GRID_WIDTH = 135;

	// Token: 0x0400306C RID: 12396
	private const int INTERVAL_TIME = 250;

	// Token: 0x0400306D RID: 12397
	protected string Code = "";

	// Token: 0x0400306E RID: 12398
	protected int Index;

	// Token: 0x0400306F RID: 12399
	protected int NextIndex = -1;

	// Token: 0x04003070 RID: 12400
	protected Vector Position = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04003071 RID: 12401
	protected int Size;

	// Token: 0x04003072 RID: 12402
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04003073 RID: 12403
	[Nullable(2)]
	private TimerHandle DelayTimerHandle;
}
