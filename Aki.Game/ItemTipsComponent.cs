using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020018CE RID: 6350
public class ItemTipsComponent : UiPanelBase, IItemTipsUiProxy
{
	// Token: 0x0600BA4B RID: 47691 RVA: 0x002A31D0 File Offset: 0x002A13D0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BA4C RID: 47692 RVA: 0x002A3218 File Offset: 0x002A1418
	protected override UniTask OnBeforeStartAsync()
	{
		ItemTipsComponent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemTipsComponent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BA4D RID: 47693 RVA: 0x002A325B File Offset: 0x002A145B
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600BA4E RID: 47694 RVA: 0x002A326E File Offset: 0x002A146E
	protected override void OnBeforeShow()
	{
		this.PlayStartSequence();
	}

	// Token: 0x0600BA4F RID: 47695 RVA: 0x002A3278 File Offset: 0x002A1478
	private void PlayStartSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600BA50 RID: 47696 RVA: 0x002A32A8 File Offset: 0x002A14A8
	public UniTask PlayCloseSequence()
	{
		ItemTipsComponent.<PlayCloseSequence>d__7 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<ItemTipsComponent.<PlayCloseSequence>d__7>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600BA51 RID: 47697 RVA: 0x002A32EB File Offset: 0x002A14EB
	[NullableContext(1)]
	public void RefreshTipsComponentByType(ItemTipsData data)
	{
		ItemTipsComponentContentComponent content = this.Content;
		if (content == null)
		{
			return;
		}
		content.RefreshTipsComponentByType(data);
	}

	// Token: 0x0600BA52 RID: 47698 RVA: 0x002A32FE File Offset: 0x002A14FE
	[NullableContext(1)]
	public void Refresh(ItemTipsData data)
	{
		ItemTipsComponentContentComponent content = this.Content;
		if (content == null)
		{
			return;
		}
		content.Refresh(data);
	}

	// Token: 0x0600BA53 RID: 47699 RVA: 0x002A3311 File Offset: 0x002A1511
	public void SetTipsNumShow(bool isShow)
	{
		ItemTipsComponentContentComponent content = this.Content;
		if (content == null)
		{
			return;
		}
		content.SetTipsNumShow(isShow);
	}

	// Token: 0x0600BA54 RID: 47700 RVA: 0x002A3324 File Offset: 0x002A1524
	public void SetTipsComponentLockButton(bool isShow)
	{
		ItemTipsComponentContentComponent content = this.Content;
		if (content == null)
		{
			return;
		}
		content.SetTipsComponentLockButton(isShow);
	}

	// Token: 0x04005464 RID: 21604
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04005465 RID: 21605
	[Nullable(2)]
	private ItemTipsComponentContentComponent Content;
}
