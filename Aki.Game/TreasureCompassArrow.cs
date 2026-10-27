using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F6A RID: 8042
[NullableContext(2)]
[Nullable(0)]
public class TreasureCompassArrow : UiPanelBase
{
	// Token: 0x0600F975 RID: 63861 RVA: 0x003C7234 File Offset: 0x003C5434
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F976 RID: 63862 RVA: 0x003C72A0 File Offset: 0x003C54A0
	protected override void OnStart()
	{
		base.OnStart();
		this.IsVisible = false;
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIActive(false);
		}
		this.ArrowItem = base.GetItem(0);
		UUIItem arrowItem = this.ArrowItem;
		if (arrowItem != null)
		{
			arrowItem.SetUIActive(true);
		}
		this.HighLightArrowItem = base.GetItem(1);
		UUIItem highLightArrowItem = this.HighLightArrowItem;
		if (highLightArrowItem != null)
		{
			highLightArrowItem.SetUIActive(false);
		}
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600F977 RID: 63863 RVA: 0x003C731B File Offset: 0x003C551B
	public void Clean()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600F978 RID: 63864 RVA: 0x003C7338 File Offset: 0x003C5538
	public void SetVisible(bool isVisible)
	{
		if (isVisible == this.IsVisible)
		{
			return;
		}
		this.IsVisible = isVisible;
		if (!isVisible)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			this.PlayCloseAsync().Forget();
			return;
		}
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIActive(true);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 != null)
		{
			levelSequencePlayer2.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
		if (levelSequencePlayer3 == null)
		{
			return;
		}
		levelSequencePlayer3.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600F979 RID: 63865 RVA: 0x003C73C0 File Offset: 0x003C55C0
	private UniTask PlayCloseAsync()
	{
		TreasureCompassArrow.<PlayCloseAsync>d__10 <PlayCloseAsync>d__;
		<PlayCloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseAsync>d__.<>4__this = this;
		<PlayCloseAsync>d__.<>1__state = -1;
		<PlayCloseAsync>d__.<>t__builder.Start<TreasureCompassArrow.<PlayCloseAsync>d__10>(ref <PlayCloseAsync>d__);
		return <PlayCloseAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F97A RID: 63866 RVA: 0x003C7403 File Offset: 0x003C5603
	public void SetRotation(FRotator rotator)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIRelativeRotation(rotator);
	}

	// Token: 0x0600F97B RID: 63867 RVA: 0x003C7417 File Offset: 0x003C5617
	public void SetArrowScale(double scale)
	{
		this.ScaleVec.X = scale;
		this.ScaleVec.Y = scale;
		UUIItem arrowItem = this.ArrowItem;
		if (arrowItem == null)
		{
			return;
		}
		arrowItem.SetUIItemScale(this.ScaleVec.ToUeVectorOld());
	}

	// Token: 0x0600F97C RID: 63868 RVA: 0x003C744C File Offset: 0x003C564C
	public void SetHighLight(bool isHighLight)
	{
		if (isHighLight == this.IsHighLight)
		{
			return;
		}
		this.IsHighLight = isHighLight;
		UUIItem arrowItem = this.ArrowItem;
		if (arrowItem != null)
		{
			arrowItem.SetUIActive(!isHighLight);
		}
		UUIItem highLightArrowItem = this.HighLightArrowItem;
		if (highLightArrowItem != null)
		{
			highLightArrowItem.SetUIActive(isHighLight);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0400743F RID: 29759
	private UUIItem ArrowItem;

	// Token: 0x04007440 RID: 29760
	private UUIItem HighLightArrowItem;

	// Token: 0x04007441 RID: 29761
	[Nullable(1)]
	private readonly Vector ScaleVec = Vector.Create();

	// Token: 0x04007442 RID: 29762
	private bool IsHighLight;

	// Token: 0x04007443 RID: 29763
	private bool IsVisible = true;

	// Token: 0x04007444 RID: 29764
	private LevelSequencePlayer LevelSequencePlayer;
}
