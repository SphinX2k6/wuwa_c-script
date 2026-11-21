using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001950 RID: 6480
[NullableContext(2)]
[Nullable(0)]
public class PhantomInteractDetailPanel : UiPanelBase, IDetailContent
{
	// Token: 0x06010046 RID: 65606 RVA: 0x004ABDC4 File Offset: 0x004A9FC4
	public PhantomInteractDetailPanel(bool isSpecialContent)
	{
		this.IsSpecialContent = isSpecialContent;
	}

	// Token: 0x06010047 RID: 65607 RVA: 0x004ABDE0 File Offset: 0x004A9FE0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06010048 RID: 65608 RVA: 0x004ABE68 File Offset: 0x004AA068
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomInteractDetailPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomInteractDetailPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010049 RID: 65609 RVA: 0x004ABEAC File Offset: 0x004AA0AC
	[NullableContext(1)]
	public UniTask Refresh(PhantomInteractDetailViewModel viewModel)
	{
		PhantomInteractDetailPanel.<Refresh>d__11 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.viewModel = viewModel;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<PhantomInteractDetailPanel.<Refresh>d__11>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x0601004A RID: 65610 RVA: 0x004ABEF7 File Offset: 0x004AA0F7
	void IDetailContent.SetUiActive(bool active)
	{
		base.SetUiActive(active);
	}

	// Token: 0x0601004B RID: 65611 RVA: 0x004ABF00 File Offset: 0x004AA100
	[NullableContext(1)]
	void IDetailContent.Refresh(PhantomInteractDetailViewModel viewModel)
	{
		this.Refresh(viewModel);
	}

	// Token: 0x0601004C RID: 65612 RVA: 0x004ABF0C File Offset: 0x004AA10C
	public void PlaySwitchAnimation()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.StopCurrentSequence(false, true);
		}
		LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
		if (seqPlayer2 == null)
		{
			return;
		}
		seqPlayer2.PlayLevelSequenceByName("Switch", false, null, false);
	}

	// Token: 0x0601004D RID: 65613 RVA: 0x004ABF4C File Offset: 0x004AA14C
	public void SetScrollListenerActive(bool active)
	{
		IDetailContent detailContent = this.DetailContent;
		if (detailContent == null)
		{
			return;
		}
		detailContent.SetScrollListenerActive(active);
	}

	// Token: 0x04008E41 RID: 36417
	private PhantomInteractListItem PhantomItem;

	// Token: 0x04008E42 RID: 36418
	private GetWayPanel GetWayPanel;

	// Token: 0x04008E43 RID: 36419
	private int? GetWayId = new int?(0);

	// Token: 0x04008E44 RID: 36420
	private IDetailContent DetailContent;

	// Token: 0x04008E45 RID: 36421
	private ActivePanel ActivePanel;

	// Token: 0x04008E46 RID: 36422
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04008E47 RID: 36423
	private readonly bool IsSpecialContent;

	// Token: 0x02007B6D RID: 31597
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04027FA4 RID: 163748
		ItemPanelVision,
		// Token: 0x04027FA5 RID: 163749
		TxtTitle,
		// Token: 0x04027FA6 RID: 163750
		ItemPanelContent,
		// Token: 0x04027FA7 RID: 163751
		ItemLink,
		// Token: 0x04027FA8 RID: 163752
		ItemNotActive
	}
}
