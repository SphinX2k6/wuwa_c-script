using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BFE RID: 7166
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoRankPanel : UiPanelBase
{
	// Token: 0x06011CF4 RID: 72948 RVA: 0x0053C775 File Offset: 0x0053A975
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06011CF5 RID: 72949 RVA: 0x0053C7B0 File Offset: 0x0053A9B0
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsDangoRankPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsDangoRankPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011CF6 RID: 72950 RVA: 0x0053C7F4 File Offset: 0x0053A9F4
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(0);
		object obj;
		if (item == null)
		{
			obj = null;
		}
		else
		{
			UUIItem attachUIChild = item.GetAttachUIChild(0);
			obj = ((attachUIChild != null) ? attachUIChild.GetOwner() : null);
		}
		this.TemplateGridActor = (obj as AUIBaseActor);
		if (this.TemplateGridActor == null)
		{
			return;
		}
		UUIItem uiitem = this.TemplateGridActor.GetUIItem();
		this.DangoRankItemHeight = ((uiitem != null) ? uiitem.GetHeight() : 0f);
		UUIItem uiitem2 = this.TemplateGridActor.GetUIItem();
		if (uiitem2 == null)
		{
			return;
		}
		uiitem2.SetUIActive(false);
	}

	// Token: 0x06011CF7 RID: 72951 RVA: 0x0053C86C File Offset: 0x0053AA6C
	public UniTask InitAsync(List<RacingBetsDungeonDangoInfo> rankingList, bool needRank = true, bool layoutByListOrder = false)
	{
		RacingBetsDangoRankPanel.<InitAsync>d__12 <InitAsync>d__;
		<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAsync>d__.<>4__this = this;
		<InitAsync>d__.rankingList = rankingList;
		<InitAsync>d__.needRank = needRank;
		<InitAsync>d__.layoutByListOrder = layoutByListOrder;
		<InitAsync>d__.<>1__state = -1;
		<InitAsync>d__.<>t__builder.Start<RacingBetsDangoRankPanel.<InitAsync>d__12>(ref <InitAsync>d__);
		return <InitAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011CF8 RID: 72952 RVA: 0x0053C8C8 File Offset: 0x0053AAC8
	private UniTask CreateRacingBetsDangoRankItemAsync(int index, RacingBetsDungeonDangoInfo rankInfo)
	{
		RacingBetsDangoRankPanel.<CreateRacingBetsDangoRankItemAsync>d__13 <CreateRacingBetsDangoRankItemAsync>d__;
		<CreateRacingBetsDangoRankItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateRacingBetsDangoRankItemAsync>d__.<>4__this = this;
		<CreateRacingBetsDangoRankItemAsync>d__.rankInfo = rankInfo;
		<CreateRacingBetsDangoRankItemAsync>d__.<>1__state = -1;
		<CreateRacingBetsDangoRankItemAsync>d__.<>t__builder.Start<RacingBetsDangoRankPanel.<CreateRacingBetsDangoRankItemAsync>d__13>(ref <CreateRacingBetsDangoRankItemAsync>d__);
		return <CreateRacingBetsDangoRankItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011CF9 RID: 72953 RVA: 0x0053C913 File Offset: 0x0053AB13
	[NullableContext(2)]
	private UUIItem CreateItemActor()
	{
		if (this.TemplateGridActor == null)
		{
			return null;
		}
		return LguiUtil.Instance.CopyItem(this.TemplateGridActor.GetUIItem(), base.GetRootItem());
	}

	// Token: 0x06011CFA RID: 72954 RVA: 0x0053C93C File Offset: 0x0053AB3C
	public UniTask RefreshRankItemAsync()
	{
		RacingBetsDangoRankPanel.<RefreshRankItemAsync>d__15 <RefreshRankItemAsync>d__;
		<RefreshRankItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRankItemAsync>d__.<>4__this = this;
		<RefreshRankItemAsync>d__.<>1__state = -1;
		<RefreshRankItemAsync>d__.<>t__builder.Start<RacingBetsDangoRankPanel.<RefreshRankItemAsync>d__15>(ref <RefreshRankItemAsync>d__);
		return <RefreshRankItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04009B9B RID: 39835
	[Nullable(2)]
	private AUIBaseActor TemplateGridActor;

	// Token: 0x04009B9C RID: 39836
	private readonly Dictionary<RacingBetsDungeonDangoInfo, RacingBetsDangoRankItem> RankItemMap = new Dictionary<RacingBetsDungeonDangoInfo, RacingBetsDangoRankItem>();

	// Token: 0x04009B9D RID: 39837
	public float DangoRankItemHeight;

	// Token: 0x04009B9E RID: 39838
	public int DangoRankInterval = 20;

	// Token: 0x04009B9F RID: 39839
	private List<RacingBetsDangoRankItem> RankItemList = new List<RacingBetsDangoRankItem>();

	// Token: 0x04009BA0 RID: 39840
	[Nullable(2)]
	private UCurveFloat LerpCurve;

	// Token: 0x04009BA1 RID: 39841
	private bool NeedRank = true;

	// Token: 0x04009BA2 RID: 39842
	private bool LayoutByListOrder;

	// Token: 0x02007EEC RID: 32492
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029128 RID: 168232
		Content,
		// Token: 0x04029129 RID: 168233
		Item
	}
}
