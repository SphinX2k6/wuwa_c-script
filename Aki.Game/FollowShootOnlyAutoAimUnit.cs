using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200140A RID: 5130
[NullableContext(2)]
[Nullable(0)]
public class FollowShootOnlyAutoAimUnit : HudUnitBase
{
	// Token: 0x0600CBAE RID: 52142 RVA: 0x003C9AE8 File Offset: 0x003C7CE8
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

	// Token: 0x0600CBAF RID: 52143 RVA: 0x003C9B74 File Offset: 0x003C7D74
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

	// Token: 0x0600CBB0 RID: 52144 RVA: 0x003C9BFD File Offset: 0x003C7DFD
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

	// Token: 0x0600CBB1 RID: 52145 RVA: 0x003C9C34 File Offset: 0x003C7E34
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

	// Token: 0x0600CBB2 RID: 52146 RVA: 0x003C9D08 File Offset: 0x003C7F08
	private UniTask PlayCloseSequenceAsync()
	{
		FollowShootOnlyAutoAimUnit.<PlayCloseSequenceAsync>d__12 <PlayCloseSequenceAsync>d__;
		<PlayCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequenceAsync>d__.<>4__this = this;
		<PlayCloseSequenceAsync>d__.<>1__state = -1;
		<PlayCloseSequenceAsync>d__.<>t__builder.Start<FollowShootOnlyAutoAimUnit.<PlayCloseSequenceAsync>d__12>(ref <PlayCloseSequenceAsync>d__);
		return <PlayCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CBB3 RID: 52147 RVA: 0x003C9D4B File Offset: 0x003C7F4B
	public void SetTargetItemOffset(float x, float y)
	{
		if (this.TargetItem == null)
		{
			return;
		}
		this.TargetItem.SetAnchorOffsetX(x);
		this.TargetItem.SetAnchorOffsetY(y);
	}

	// Token: 0x0600CBB4 RID: 52148 RVA: 0x003C9D70 File Offset: 0x003C7F70
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

	// Token: 0x040073AC RID: 29612
	private UUIItem TargetItem;

	// Token: 0x040073AD RID: 29613
	private UUIItem Left;

	// Token: 0x040073AE RID: 29614
	private UUIItem Right;

	// Token: 0x040073AF RID: 29615
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040073B0 RID: 29616
	private bool IsActive;

	// Token: 0x040073B1 RID: 29617
	private bool IsTargetItemActive;

	// Token: 0x040073B2 RID: 29618
	private bool IsClosing;

	// Token: 0x020076BD RID: 30397
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402691B RID: 157979
		TargetItem,
		// Token: 0x0402691C RID: 157980
		Left,
		// Token: 0x0402691D RID: 157981
		Right
	}
}
