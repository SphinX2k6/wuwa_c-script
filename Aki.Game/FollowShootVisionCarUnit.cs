using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F49 RID: 8009
public class FollowShootVisionCarUnit : HudUnitBase
{
	// Token: 0x0600F798 RID: 63384 RVA: 0x003BE2F8 File Offset: 0x003BC4F8
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

	// Token: 0x0600F799 RID: 63385 RVA: 0x003BE382 File Offset: 0x003BC582
	protected override void OnStart()
	{
		this.TargetItem = base.GetItem(0);
		this.TargetItem.SetUIActive(false);
		this.IsActive = false;
		this.IsTargetItemActive = false;
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600F79A RID: 63386 RVA: 0x003BE3BC File Offset: 0x003BC5BC
	protected override void OnBeforeDestroy()
	{
		this.TargetItem = null;
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
		base.OnBeforeDestroy();
	}

	// Token: 0x0600F79B RID: 63387 RVA: 0x003BE3E4 File Offset: 0x003BC5E4
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

	// Token: 0x0600F79C RID: 63388 RVA: 0x003BE494 File Offset: 0x003BC694
	private UniTask PlayCloseSequenceAsync()
	{
		FollowShootVisionCarUnit.<PlayCloseSequenceAsync>d__10 <PlayCloseSequenceAsync>d__;
		<PlayCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequenceAsync>d__.<>4__this = this;
		<PlayCloseSequenceAsync>d__.<>1__state = -1;
		<PlayCloseSequenceAsync>d__.<>t__builder.Start<FollowShootVisionCarUnit.<PlayCloseSequenceAsync>d__10>(ref <PlayCloseSequenceAsync>d__);
		return <PlayCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F79D RID: 63389 RVA: 0x003BE4D7 File Offset: 0x003BC6D7
	public void SetTargetItemOffset(float x, float y)
	{
		if (this.TargetItem == null)
		{
			return;
		}
		this.TargetItem.SetAnchorOffsetX(x);
		this.TargetItem.SetAnchorOffsetY(y);
	}

	// Token: 0x0600F79E RID: 63390 RVA: 0x003BE4FC File Offset: 0x003BC6FC
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
		if (!isVisible)
		{
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.StopSequenceByKey("StartL", false, false);
			}
			this.PlayCloseTargetSequenceAsync().Forget();
			return;
		}
		this.TargetItem.SetUIActive(true);
		LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
		if (levelSequencePlayer3 != null)
		{
			levelSequencePlayer3.StopSequenceByKey("CloseL", false, false);
		}
		LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
		if (levelSequencePlayer4 == null)
		{
			return;
		}
		levelSequencePlayer4.PlaySequencePurely("StartL", false, false, null, null, false);
	}

	// Token: 0x0600F79F RID: 63391 RVA: 0x003BE5C0 File Offset: 0x003BC7C0
	private UniTask PlayCloseTargetSequenceAsync()
	{
		FollowShootVisionCarUnit.<PlayCloseTargetSequenceAsync>d__13 <PlayCloseTargetSequenceAsync>d__;
		<PlayCloseTargetSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseTargetSequenceAsync>d__.<>4__this = this;
		<PlayCloseTargetSequenceAsync>d__.<>1__state = -1;
		<PlayCloseTargetSequenceAsync>d__.<>t__builder.Start<FollowShootVisionCarUnit.<PlayCloseTargetSequenceAsync>d__13>(ref <PlayCloseTargetSequenceAsync>d__);
		return <PlayCloseTargetSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x040072D2 RID: 29394
	[Nullable(2)]
	private UUIItem TargetItem;

	// Token: 0x040072D3 RID: 29395
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040072D4 RID: 29396
	private bool IsActive;

	// Token: 0x040072D5 RID: 29397
	private bool IsTargetItemActive;

	// Token: 0x040072D6 RID: 29398
	private bool IsClosing;

	// Token: 0x0200853A RID: 34106
	private enum EChildType
	{
		// Token: 0x0402B5FF RID: 177663
		TargetItem,
		// Token: 0x0402B600 RID: 177664
		Left,
		// Token: 0x0402B601 RID: 177665
		Right
	}
}
