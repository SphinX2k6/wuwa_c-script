using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001247 RID: 4679
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyRoundBuffShowView : DangoMonopolyViewBase
{
	// Token: 0x17000ABF RID: 2751
	// (get) Token: 0x06007F07 RID: 32519 RVA: 0x001AEC7C File Offset: 0x001ACE7C
	[Nullable(2)]
	public new DangoMonopolyRoundBuffShowViewParam OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as DangoMonopolyRoundBuffShowViewParam;
		}
	}

	// Token: 0x06007F08 RID: 32520 RVA: 0x001AEC89 File Offset: 0x001ACE89
	public DangoMonopolyRoundBuffShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007F09 RID: 32521 RVA: 0x001AEC94 File Offset: 0x001ACE94
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickClose))
		};
	}

	// Token: 0x06007F0A RID: 32522 RVA: 0x001AED55 File Offset: 0x001ACF55
	private void InitDataParam()
	{
	}

	// Token: 0x06007F0B RID: 32523 RVA: 0x001AED58 File Offset: 0x001ACF58
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyRoundBuffShowView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyRoundBuffShowView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007F0C RID: 32524 RVA: 0x001AED9B File Offset: 0x001ACF9B
	protected override void OnBeforeShow()
	{
		GenericLayout<DangoMonopolyRoundBuffShowItem, IDangoMonopolyRoundBuffData> buffLayout = this.BuffLayout;
		if (buffLayout == null)
		{
			return;
		}
		buffLayout.RefreshByData(this.GetBuffList(), null, true);
	}

	// Token: 0x06007F0D RID: 32525 RVA: 0x001AEDB8 File Offset: 0x001ACFB8
	private List<IDangoMonopolyRoundBuffData> GetBuffList()
	{
		DangoMonopolyRoundBuffShowViewParam openParam = this.OpenParam;
		int key = (openParam != null) ? openParam.BoardId : 0;
		DangoMonopolyBoardData currentBoardData;
		if (!this.ActivityData.BoardMap.TryGetValue(key, out currentBoardData))
		{
			currentBoardData = this.ActivityData.CurrentBoardData;
		}
		return ((currentBoardData != null) ? currentBoardData.GetDangoBuffShowList() : null) ?? new List<IDangoMonopolyRoundBuffData>();
	}

	// Token: 0x06007F0E RID: 32526 RVA: 0x001AEE0E File Offset: 0x001AD00E
	protected override void OnBeforeDestroy()
	{
		DangoMonopolyRoundBuffShowViewParam openParam = this.OpenParam;
		if (openParam == null)
		{
			return;
		}
		CustomPromise promise = openParam.Promise;
		if (promise == null)
		{
			return;
		}
		promise.SetResult();
	}

	// Token: 0x06007F0F RID: 32527 RVA: 0x001AEE2A File Offset: 0x001AD02A
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06007F10 RID: 32528 RVA: 0x001AEE33 File Offset: 0x001AD033
	private DangoMonopolyRoundBuffShowItem CreateBuffItem()
	{
		return new DangoMonopolyRoundBuffShowItem();
	}

	// Token: 0x040039D6 RID: 14806
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DangoMonopolyRoundBuffShowItem, IDangoMonopolyRoundBuffData> BuffLayout;

	// Token: 0x0200785F RID: 30815
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04027AA7 RID: 162471
		BtnClose,
		// Token: 0x04027AA8 RID: 162472
		TxtTitle,
		// Token: 0x04027AA9 RID: 162473
		BtnEmpty,
		// Token: 0x04027AAA RID: 162474
		VLayoutProperty,
		// Token: 0x04027AAB RID: 162475
		ItemProperty
	}
}
