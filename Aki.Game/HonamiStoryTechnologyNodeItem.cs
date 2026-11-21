using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013C7 RID: 5063
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryTechnologyNodeItem : UiPanelBase
{
	// Token: 0x0600C8A0 RID: 51360 RVA: 0x003BB9E0 File Offset: 0x003B9BE0
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

	// Token: 0x0600C8A1 RID: 51361 RVA: 0x003BBB2C File Offset: 0x003B9D2C
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryTechnologyNodeItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryTechnologyNodeItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C8A2 RID: 51362 RVA: 0x003BBB6F File Offset: 0x003B9D6F
	public HonamiStoryTalent GetNodeDataConfig()
	{
		return this.NodeData.GetConfig;
	}

	// Token: 0x0600C8A3 RID: 51363 RVA: 0x003BBB7C File Offset: 0x003B9D7C
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

	// Token: 0x0600C8A4 RID: 51364 RVA: 0x003BBBC8 File Offset: 0x003B9DC8
	public UniTask RefreshNodeAsync()
	{
		HonamiStoryTechnologyNodeItem.<RefreshNodeAsync>d__8 <RefreshNodeAsync>d__;
		<RefreshNodeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshNodeAsync>d__.<>4__this = this;
		<RefreshNodeAsync>d__.<>1__state = -1;
		<RefreshNodeAsync>d__.<>t__builder.Start<HonamiStoryTechnologyNodeItem.<RefreshNodeAsync>d__8>(ref <RefreshNodeAsync>d__);
		return <RefreshNodeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C8A5 RID: 51365 RVA: 0x003BBC0C File Offset: 0x003B9E0C
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

	// Token: 0x0600C8A6 RID: 51366 RVA: 0x003BBC44 File Offset: 0x003B9E44
	public void UnSelectNode()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600C8A7 RID: 51367 RVA: 0x003BBC58 File Offset: 0x003B9E58
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

	// Token: 0x1700133F RID: 4927
	// (get) Token: 0x0600C8A8 RID: 51368 RVA: 0x003BBC9D File Offset: 0x003B9E9D
	public UUIExtendToggle ToggleItem
	{
		get
		{
			return base.GetExtendToggle(0);
		}
	}

	// Token: 0x0600C8A9 RID: 51369 RVA: 0x003BBCA8 File Offset: 0x003B9EA8
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

	// Token: 0x0600C8AA RID: 51370 RVA: 0x003BBCD5 File Offset: 0x003B9ED5
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

	// Token: 0x04007208 RID: 29192
	[Nullable(2)]
	private HonamiStoryTechNodeData NodeData;

	// Token: 0x04007209 RID: 29193
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0400720A RID: 29194
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public Action<HonamiStoryTechnologyNodeItem, HonamiStoryTechNodeData, UUIExtendToggle> OnClickToggleBack;

	// Token: 0x02007690 RID: 30352
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040267E9 RID: 157673
		TogTechNode,
		// Token: 0x040267EA RID: 157674
		SprBgUnLock,
		// Token: 0x040267EB RID: 157675
		TexTechIcon,
		// Token: 0x040267EC RID: 157676
		SprBgLock,
		// Token: 0x040267ED RID: 157677
		TexTechIconLock,
		// Token: 0x040267EE RID: 157678
		ItemLockIcon,
		// Token: 0x040267EF RID: 157679
		ItemCanActiveIcon
	}
}
