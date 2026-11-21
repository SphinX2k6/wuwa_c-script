using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000D87 RID: 3463
public class ItemTipsComponent : UiPanelBase, IItemTipsUiProxy
{
	// Token: 0x06008E34 RID: 36404 RVA: 0x002AD928 File Offset: 0x002ABB28
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

	// Token: 0x06008E35 RID: 36405 RVA: 0x002AD970 File Offset: 0x002ABB70
	protected override UniTask OnBeforeStartAsync()
	{
		ItemTipsComponent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemTipsComponent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008E36 RID: 36406 RVA: 0x002AD9B3 File Offset: 0x002ABBB3
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06008E37 RID: 36407 RVA: 0x002AD9C6 File Offset: 0x002ABBC6
	protected override void OnBeforeShow()
	{
		this.PlayStartSequence();
	}

	// Token: 0x06008E38 RID: 36408 RVA: 0x002AD9D0 File Offset: 0x002ABBD0
	private void PlayStartSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x06008E39 RID: 36409 RVA: 0x002ADA00 File Offset: 0x002ABC00
	public UniTask PlayCloseSequence()
	{
		ItemTipsComponent.<PlayCloseSequence>d__7 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<ItemTipsComponent.<PlayCloseSequence>d__7>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x06008E3A RID: 36410 RVA: 0x002ADA43 File Offset: 0x002ABC43
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

	// Token: 0x06008E3B RID: 36411 RVA: 0x002ADA56 File Offset: 0x002ABC56
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

	// Token: 0x06008E3C RID: 36412 RVA: 0x002ADA69 File Offset: 0x002ABC69
	public void SetTipsNumShow(bool isShow)
	{
		ItemTipsComponentContentComponent content = this.Content;
		if (content == null)
		{
			return;
		}
		content.SetTipsNumShow(isShow);
	}

	// Token: 0x06008E3D RID: 36413 RVA: 0x002ADA7C File Offset: 0x002ABC7C
	public void SetTipsComponentLockButton(bool isShow)
	{
		ItemTipsComponentContentComponent content = this.Content;
		if (content == null)
		{
			return;
		}
		content.SetTipsComponentLockButton(isShow);
	}

	// Token: 0x0400550F RID: 21775
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04005510 RID: 21776
	[Nullable(2)]
	private ItemTipsComponentContentComponent Content;
}
