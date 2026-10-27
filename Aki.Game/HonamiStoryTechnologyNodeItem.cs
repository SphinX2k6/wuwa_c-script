using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F05 RID: 7941
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryTechnologyNodeItem : UiPanelBase
{
	// Token: 0x0600F481 RID: 62593 RVA: 0x003AFEEC File Offset: 0x003AE0EC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F482 RID: 62594 RVA: 0x003B0038 File Offset: 0x003AE238
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryTechnologyNodeItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryTechnologyNodeItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F483 RID: 62595 RVA: 0x003B007B File Offset: 0x003AE27B
	public HonamiStoryTalent GetNodeDataConfig()
	{
		return this.NodeData.GetConfig;
	}

	// Token: 0x0600F484 RID: 62596 RVA: 0x003B0088 File Offset: 0x003AE288
	public UniTask RefreshNodeAsyncByData(HonamiStoryTechNodeData data)
	{
		HonamiStoryTechnologyNodeItem.<RefreshNodeAsyncByData>d__7 <RefreshNodeAsyncByData>d__;
		<RefreshNodeAsyncByData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshNodeAsyncByData>d__.<>4__this = this;
		<RefreshNodeAsyncByData>d__.data = data;
		<RefreshNodeAsyncByData>d__.<>1__state = -1;
		<RefreshNodeAsyncByData>d__.<>t__builder.Start<HonamiStoryTechnologyNodeItem.<RefreshNodeAsyncByData>d__7>(ref <RefreshNodeAsyncByData>d__);
		return <RefreshNodeAsyncByData>d__.<>t__builder.Task;
	}

	// Token: 0x0600F485 RID: 62597 RVA: 0x003B00D4 File Offset: 0x003AE2D4
	public UniTask RefreshNodeAsync()
	{
		HonamiStoryTechnologyNodeItem.<RefreshNodeAsync>d__8 <RefreshNodeAsync>d__;
		<RefreshNodeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshNodeAsync>d__.<>4__this = this;
		<RefreshNodeAsync>d__.<>1__state = -1;
		<RefreshNodeAsync>d__.<>t__builder.Start<HonamiStoryTechnologyNodeItem.<RefreshNodeAsync>d__8>(ref <RefreshNodeAsync>d__);
		return <RefreshNodeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F486 RID: 62598 RVA: 0x003B0118 File Offset: 0x003AE318
	public void SelectNode()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		Action<HonamiStoryTechnologyNodeItem, HonamiStoryTechNodeData, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this, this.NodeData, extendToggle);
	}

	// Token: 0x0600F487 RID: 62599 RVA: 0x003B0150 File Offset: 0x003AE350
	public void UnSelectNode()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600F488 RID: 62600 RVA: 0x003B0164 File Offset: 0x003AE364
	public void PlayActivateAnim()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.StopSequenceByKey("Activate", false, false);
		}
		LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
		if (seqPlayer2 == null)
		{
			return;
		}
		seqPlayer2.PlayLevelSequenceByName("Activate", false, null, false);
	}

	// Token: 0x17001315 RID: 4885
	// (get) Token: 0x0600F489 RID: 62601 RVA: 0x003B01A9 File Offset: 0x003AE3A9
	public UUIExtendToggle ToggleItem
	{
		get
		{
			return base.GetExtendToggle(0);
		}
	}

	// Token: 0x0600F48A RID: 62602 RVA: 0x003B01B4 File Offset: 0x003AE3B4
	private void OnClickToggle(EToggleState toggleState)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		Action<HonamiStoryTechnologyNodeItem, HonamiStoryTechNodeData, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this, this.NodeData, extendToggle);
	}

	// Token: 0x0600F48B RID: 62603 RVA: 0x003B01E1 File Offset: 0x003AE3E1
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.Clear();
		}
		this.SeqPlayer = null;
		base.OnBeforeDestroy();
	}

	// Token: 0x04007127 RID: 28967
	[Nullable(2)]
	private HonamiStoryTechNodeData NodeData;

	// Token: 0x04007128 RID: 28968
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04007129 RID: 28969
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public Action<HonamiStoryTechnologyNodeItem, HonamiStoryTechNodeData, UUIExtendToggle> OnClickToggleBack;

	// Token: 0x0200850B RID: 34059
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B4C5 RID: 177349
		TogTechNode,
		// Token: 0x0402B4C6 RID: 177350
		SprBgUnLock,
		// Token: 0x0402B4C7 RID: 177351
		TexTechIcon,
		// Token: 0x0402B4C8 RID: 177352
		SprBgLock,
		// Token: 0x0402B4C9 RID: 177353
		TexTechIconLock,
		// Token: 0x0402B4CA RID: 177354
		ItemLockIcon,
		// Token: 0x0402B4CB RID: 177355
		ItemCanActiveIcon
	}
}
