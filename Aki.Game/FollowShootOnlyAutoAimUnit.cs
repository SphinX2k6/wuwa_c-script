using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F48 RID: 8008
[NullableContext(2)]
[Nullable(0)]
public class FollowShootOnlyAutoAimUnit : HudUnitBase
{
	// Token: 0x0600F78F RID: 63375 RVA: 0x003BDFFC File Offset: 0x003BC1FC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F790 RID: 63376 RVA: 0x003BE088 File Offset: 0x003BC288
	protected override void OnStart()
	{
		this.TargetItem = base.GetItem(0);
		this.Left = base.GetItem(1);
		this.Right = base.GetItem(2);
		UUIItem targetItem = this.TargetItem;
		if (targetItem != null)
		{
			targetItem.SetUIActive(false);
		}
		UUIItem left = this.Left;
		if (left != null)
		{
			left.SetUIActive(false);
		}
		UUIItem right = this.Right;
		if (right != null)
		{
			right.SetUIActive(false);
		}
		this.IsActive = false;
		this.IsTargetItemActive = false;
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600F791 RID: 63377 RVA: 0x003BE111 File Offset: 0x003BC311
	protected override void OnBeforeDestroy()
	{
		this.TargetItem = null;
		this.Left = null;
		this.Right = null;
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
		base.OnBeforeDestroy();
	}

	// Token: 0x0600F792 RID: 63378 RVA: 0x003BE148 File Offset: 0x003BC348
	public override void SetActive(bool active)
	{
		if (base.IsCreateOrCreating)
		{
			return;
		}
		if (active == this.IsActive)
		{
			return;
		}
		this.IsActive = active;
		UUIItem left = this.Left;
		if (left != null)
		{
			left.SetUIActive(false);
		}
		UUIItem right = this.Right;
		if (right != null)
		{
			right.SetUIActive(false);
		}
		if (active)
		{
			base.SetActive(true);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopSequenceByKey("Close", false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlaySequencePurely("Start", false, false, null, null, false);
			}
			this.IsTargetItemActive = false;
			this.IsClosing = false;
			return;
		}
		this.SetTargetAimVisible(false, false);
		this.IsClosing = true;
		LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
		if (levelSequencePlayer3 != null)
		{
			levelSequencePlayer3.StopSequenceByKey("Start", false, false);
		}
		this.PlayCloseSequenceAsync().Forget();
	}

	// Token: 0x0600F793 RID: 63379 RVA: 0x003BE21C File Offset: 0x003BC41C
	private UniTask PlayCloseSequenceAsync()
	{
		FollowShootOnlyAutoAimUnit.<PlayCloseSequenceAsync>d__12 <PlayCloseSequenceAsync>d__;
		<PlayCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequenceAsync>d__.<>4__this = this;
		<PlayCloseSequenceAsync>d__.<>1__state = -1;
		<PlayCloseSequenceAsync>d__.<>t__builder.Start<FollowShootOnlyAutoAimUnit.<PlayCloseSequenceAsync>d__12>(ref <PlayCloseSequenceAsync>d__);
		return <PlayCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F794 RID: 63380 RVA: 0x003BE25F File Offset: 0x003BC45F
	public void SetTargetItemOffset(float x, float y)
	{
		if (this.TargetItem == null)
		{
			return;
		}
		this.TargetItem.SetAnchorOffsetX(x);
		this.TargetItem.SetAnchorOffsetY(y);
	}

	// Token: 0x0600F795 RID: 63381 RVA: 0x003BE284 File Offset: 0x003BC484
	public void SetTargetAimVisible(bool isVisible, bool isTargetChanged)
	{
		if (this.IsClosing || this.TargetItem == null)
		{
			return;
		}
		if (this.IsTargetItemActive == isVisible)
		{
			if (isVisible && isTargetChanged)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer == null)
				{
					return;
				}
				levelSequencePlayer.PlaySequencePurely("Start_Red", false, false, null, null, false);
			}
			return;
		}
		this.IsTargetItemActive = isVisible;
		this.TargetItem.SetUIActive(isVisible);
	}

	// Token: 0x040072CB RID: 29387
	private UUIItem TargetItem;

	// Token: 0x040072CC RID: 29388
	private UUIItem Left;

	// Token: 0x040072CD RID: 29389
	private UUIItem Right;

	// Token: 0x040072CE RID: 29390
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040072CF RID: 29391
	private bool IsActive;

	// Token: 0x040072D0 RID: 29392
	private bool IsTargetItemActive;

	// Token: 0x040072D1 RID: 29393
	private bool IsClosing;

	// Token: 0x02008538 RID: 34104
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402B5F7 RID: 177655
		TargetItem,
		// Token: 0x0402B5F8 RID: 177656
		Left,
		// Token: 0x0402B5F9 RID: 177657
		Right
	}
}
