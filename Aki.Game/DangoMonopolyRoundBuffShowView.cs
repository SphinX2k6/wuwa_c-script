using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006FB RID: 1787
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyRoundBuffShowView : DangoMonopolyViewBase
{
	// Token: 0x17000ADF RID: 2783
	// (get) Token: 0x0600529E RID: 21150 RVA: 0x001B7934 File Offset: 0x001B5B34
	[Nullable(2)]
	public new DangoMonopolyRoundBuffShowViewParam OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as DangoMonopolyRoundBuffShowViewParam;
		}
	}

	// Token: 0x0600529F RID: 21151 RVA: 0x001B7941 File Offset: 0x001B5B41
	public DangoMonopolyRoundBuffShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060052A0 RID: 21152 RVA: 0x001B794C File Offset: 0x001B5B4C
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

	// Token: 0x060052A1 RID: 21153 RVA: 0x001B7A0D File Offset: 0x001B5C0D
	private void InitDataParam()
	{
	}

	// Token: 0x060052A2 RID: 21154 RVA: 0x001B7A10 File Offset: 0x001B5C10
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyRoundBuffShowView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyRoundBuffShowView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060052A3 RID: 21155 RVA: 0x001B7A53 File Offset: 0x001B5C53
	protected override void OnBeforeShow()
	{
		GenericLayout<DangoMonopolyRoundBuffShowItem, IDangoMonopolyRoundBuffData> buffLayout = this.BuffLayout;
		if (buffLayout == null)
		{
			return;
		}
		buffLayout.RefreshByData(this.GetBuffList(), null, true);
	}

	// Token: 0x060052A4 RID: 21156 RVA: 0x001B7A70 File Offset: 0x001B5C70
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

	// Token: 0x060052A5 RID: 21157 RVA: 0x001B7AC6 File Offset: 0x001B5CC6
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

	// Token: 0x060052A6 RID: 21158 RVA: 0x001B7AE2 File Offset: 0x001B5CE2
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x060052A7 RID: 21159 RVA: 0x001B7AEB File Offset: 0x001B5CEB
	private DangoMonopolyRoundBuffShowItem CreateBuffItem()
	{
		return new DangoMonopolyRoundBuffShowItem();
	}

	// Token: 0x04003A6E RID: 14958
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DangoMonopolyRoundBuffShowItem, IDangoMonopolyRoundBuffData> BuffLayout;

	// Token: 0x020069EA RID: 27114
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022DD8 RID: 142808
		BtnClose,
		// Token: 0x04022DD9 RID: 142809
		TxtTitle,
		// Token: 0x04022DDA RID: 142810
		BtnEmpty,
		// Token: 0x04022DDB RID: 142811
		VLayoutProperty,
		// Token: 0x04022DDC RID: 142812
		ItemProperty
	}
}
