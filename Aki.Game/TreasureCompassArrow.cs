using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200142C RID: 5164
[NullableContext(2)]
[Nullable(0)]
public class TreasureCompassArrow : UiPanelBase
{
	// Token: 0x0600CD94 RID: 52628 RVA: 0x003D2D20 File Offset: 0x003D0F20
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

	// Token: 0x0600CD95 RID: 52629 RVA: 0x003D2D8C File Offset: 0x003D0F8C
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

	// Token: 0x0600CD96 RID: 52630 RVA: 0x003D2E07 File Offset: 0x003D1007
	public void Clean()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600CD97 RID: 52631 RVA: 0x003D2E24 File Offset: 0x003D1024
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

	// Token: 0x0600CD98 RID: 52632 RVA: 0x003D2EAC File Offset: 0x003D10AC
	private UniTask PlayCloseAsync()
	{
		TreasureCompassArrow.<PlayCloseAsync>d__10 <PlayCloseAsync>d__;
		<PlayCloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseAsync>d__.<>4__this = this;
		<PlayCloseAsync>d__.<>1__state = -1;
		<PlayCloseAsync>d__.<>t__builder.Start<TreasureCompassArrow.<PlayCloseAsync>d__10>(ref <PlayCloseAsync>d__);
		return <PlayCloseAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CD99 RID: 52633 RVA: 0x003D2EEF File Offset: 0x003D10EF
	public void SetRotation(FRotator rotator)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIRelativeRotation(rotator);
	}

	// Token: 0x0600CD9A RID: 52634 RVA: 0x003D2F03 File Offset: 0x003D1103
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

	// Token: 0x0600CD9B RID: 52635 RVA: 0x003D2F38 File Offset: 0x003D1138
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

	// Token: 0x04007520 RID: 29984
	private UUIItem ArrowItem;

	// Token: 0x04007521 RID: 29985
	private UUIItem HighLightArrowItem;

	// Token: 0x04007522 RID: 29986
	[Nullable(1)]
	private readonly Vector ScaleVec = Vector.Create();

	// Token: 0x04007523 RID: 29987
	private bool IsHighLight;

	// Token: 0x04007524 RID: 29988
	private bool IsVisible = true;

	// Token: 0x04007525 RID: 29989
	private LevelSequencePlayer LevelSequencePlayer;
}
