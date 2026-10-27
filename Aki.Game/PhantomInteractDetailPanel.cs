using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200246B RID: 9323
[NullableContext(2)]
[Nullable(0)]
public class PhantomInteractDetailPanel : UiPanelBase, IDetailContent
{
	// Token: 0x06012B8E RID: 76686 RVA: 0x0049E658 File Offset: 0x0049C858
	public PhantomInteractDetailPanel(bool isSpecialContent)
	{
		this.IsSpecialContent = isSpecialContent;
	}

	// Token: 0x06012B8F RID: 76687 RVA: 0x0049E674 File Offset: 0x0049C874
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

	// Token: 0x06012B90 RID: 76688 RVA: 0x0049E6FC File Offset: 0x0049C8FC
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomInteractDetailPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomInteractDetailPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012B91 RID: 76689 RVA: 0x0049E740 File Offset: 0x0049C940
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

	// Token: 0x06012B92 RID: 76690 RVA: 0x0049E78B File Offset: 0x0049C98B
	void IDetailContent.SetUiActive(bool active)
	{
		base.SetUiActive(active);
	}

	// Token: 0x06012B93 RID: 76691 RVA: 0x0049E794 File Offset: 0x0049C994
	[NullableContext(1)]
	void IDetailContent.Refresh(PhantomInteractDetailViewModel viewModel)
	{
		this.Refresh(viewModel);
	}

	// Token: 0x06012B94 RID: 76692 RVA: 0x0049E7A0 File Offset: 0x0049C9A0
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

	// Token: 0x06012B95 RID: 76693 RVA: 0x0049E7E0 File Offset: 0x0049C9E0
	public void SetScrollListenerActive(bool active)
	{
		IDetailContent detailContent = this.DetailContent;
		if (detailContent == null)
		{
			return;
		}
		detailContent.SetScrollListenerActive(active);
	}

	// Token: 0x04008CFA RID: 36090
	private PhantomInteractListItem PhantomItem;

	// Token: 0x04008CFB RID: 36091
	private GetWayPanel GetWayPanel;

	// Token: 0x04008CFC RID: 36092
	private int? GetWayId = new int?(0);

	// Token: 0x04008CFD RID: 36093
	private IDetailContent DetailContent;

	// Token: 0x04008CFE RID: 36094
	private ActivePanel ActivePanel;

	// Token: 0x04008CFF RID: 36095
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04008D00 RID: 36096
	private readonly bool IsSpecialContent;

	// Token: 0x020089E6 RID: 35302
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CC8E RID: 183438
		ItemPanelVision,
		// Token: 0x0402CC8F RID: 183439
		TxtTitle,
		// Token: 0x0402CC90 RID: 183440
		ItemPanelContent,
		// Token: 0x0402CC91 RID: 183441
		ItemLink,
		// Token: 0x0402CC92 RID: 183442
		ItemNotActive
	}
}
