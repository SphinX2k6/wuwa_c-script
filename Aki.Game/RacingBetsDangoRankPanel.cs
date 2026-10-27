using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002713 RID: 10003
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoRankPanel : UiPanelBase
{
	// Token: 0x06014812 RID: 83986 RVA: 0x0052DA59 File Offset: 0x0052BC59
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06014813 RID: 83987 RVA: 0x0052DA94 File Offset: 0x0052BC94
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsDangoRankPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsDangoRankPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014814 RID: 83988 RVA: 0x0052DAD8 File Offset: 0x0052BCD8
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

	// Token: 0x06014815 RID: 83989 RVA: 0x0052DB50 File Offset: 0x0052BD50
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

	// Token: 0x06014816 RID: 83990 RVA: 0x0052DBAC File Offset: 0x0052BDAC
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

	// Token: 0x06014817 RID: 83991 RVA: 0x0052DBF7 File Offset: 0x0052BDF7
	[NullableContext(2)]
	private UUIItem CreateItemActor()
	{
		if (this.TemplateGridActor == null)
		{
			return null;
		}
		return LguiUtil.Instance.CopyItem(this.TemplateGridActor.GetUIItem(), base.GetRootItem());
	}

	// Token: 0x06014818 RID: 83992 RVA: 0x0052DC20 File Offset: 0x0052BE20
	public UniTask RefreshRankItemAsync()
	{
		RacingBetsDangoRankPanel.<RefreshRankItemAsync>d__15 <RefreshRankItemAsync>d__;
		<RefreshRankItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRankItemAsync>d__.<>4__this = this;
		<RefreshRankItemAsync>d__.<>1__state = -1;
		<RefreshRankItemAsync>d__.<>t__builder.Start<RacingBetsDangoRankPanel.<RefreshRankItemAsync>d__15>(ref <RefreshRankItemAsync>d__);
		return <RefreshRankItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04009A43 RID: 39491
	[Nullable(2)]
	private AUIBaseActor TemplateGridActor;

	// Token: 0x04009A44 RID: 39492
	private readonly Dictionary<RacingBetsDungeonDangoInfo, RacingBetsDangoRankItem> RankItemMap = new Dictionary<RacingBetsDungeonDangoInfo, RacingBetsDangoRankItem>();

	// Token: 0x04009A45 RID: 39493
	public float DangoRankItemHeight;

	// Token: 0x04009A46 RID: 39494
	public int DangoRankInterval = 20;

	// Token: 0x04009A47 RID: 39495
	private List<RacingBetsDangoRankItem> RankItemList = new List<RacingBetsDangoRankItem>();

	// Token: 0x04009A48 RID: 39496
	[Nullable(2)]
	private UCurveFloat LerpCurve;

	// Token: 0x04009A49 RID: 39497
	private bool NeedRank = true;

	// Token: 0x04009A4A RID: 39498
	private bool LayoutByListOrder;

	// Token: 0x02008D63 RID: 36195
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402DE11 RID: 187921
		Content,
		// Token: 0x0402DE12 RID: 187922
		Item
	}
}
