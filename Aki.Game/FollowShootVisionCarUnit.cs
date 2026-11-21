using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200140B RID: 5131
public class FollowShootVisionCarUnit : HudUnitBase
{
	// Token: 0x0600CBB7 RID: 52151 RVA: 0x003C9DE4 File Offset: 0x003C7FE4
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

	// Token: 0x0600CBB8 RID: 52152 RVA: 0x003C9E6E File Offset: 0x003C806E
	protected override void OnStart()
	{
		this.TargetItem = base.GetItem(0);
		this.TargetItem.SetUIActive(false);
		this.IsActive = false;
		this.IsTargetItemActive = false;
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600CBB9 RID: 52153 RVA: 0x003C9EA8 File Offset: 0x003C80A8
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

	// Token: 0x0600CBBA RID: 52154 RVA: 0x003C9ED0 File Offset: 0x003C80D0
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

	// Token: 0x0600CBBB RID: 52155 RVA: 0x003C9F80 File Offset: 0x003C8180
	private UniTask PlayCloseSequenceAsync()
	{
		FollowShootVisionCarUnit.<PlayCloseSequenceAsync>d__10 <PlayCloseSequenceAsync>d__;
		<PlayCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequenceAsync>d__.<>4__this = this;
		<PlayCloseSequenceAsync>d__.<>1__state = -1;
		<PlayCloseSequenceAsync>d__.<>t__builder.Start<FollowShootVisionCarUnit.<PlayCloseSequenceAsync>d__10>(ref <PlayCloseSequenceAsync>d__);
		return <PlayCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CBBC RID: 52156 RVA: 0x003C9FC3 File Offset: 0x003C81C3
	public void SetTargetItemOffset(float x, float y)
	{
		if (this.TargetItem == null)
		{
			return;
		}
		this.TargetItem.SetAnchorOffsetX(x);
		this.TargetItem.SetAnchorOffsetY(y);
	}

	// Token: 0x0600CBBD RID: 52157 RVA: 0x003C9FE8 File Offset: 0x003C81E8
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

	// Token: 0x0600CBBE RID: 52158 RVA: 0x003CA0AC File Offset: 0x003C82AC
	private UniTask PlayCloseTargetSequenceAsync()
	{
		FollowShootVisionCarUnit.<PlayCloseTargetSequenceAsync>d__13 <PlayCloseTargetSequenceAsync>d__;
		<PlayCloseTargetSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseTargetSequenceAsync>d__.<>4__this = this;
		<PlayCloseTargetSequenceAsync>d__.<>1__state = -1;
		<PlayCloseTargetSequenceAsync>d__.<>t__builder.Start<FollowShootVisionCarUnit.<PlayCloseTargetSequenceAsync>d__13>(ref <PlayCloseTargetSequenceAsync>d__);
		return <PlayCloseTargetSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x040073B3 RID: 29619
	[Nullable(2)]
	private UUIItem TargetItem;

	// Token: 0x040073B4 RID: 29620
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040073B5 RID: 29621
	private bool IsActive;

	// Token: 0x040073B6 RID: 29622
	private bool IsTargetItemActive;

	// Token: 0x040073B7 RID: 29623
	private bool IsClosing;

	// Token: 0x020076BF RID: 30399
	private enum EChildType
	{
		// Token: 0x04026923 RID: 157987
		TargetItem,
		// Token: 0x04026924 RID: 157988
		Left,
		// Token: 0x04026925 RID: 157989
		Right
	}
}
