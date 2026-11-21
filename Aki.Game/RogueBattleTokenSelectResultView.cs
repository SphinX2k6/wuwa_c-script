using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C65 RID: 7269
[NullableContext(1)]
[Nullable(0)]
public class RogueBattleTokenSelectResultView : UiViewBase
{
	// Token: 0x06012058 RID: 73816 RVA: 0x0054D9B6 File Offset: 0x0054BBB6
	public RogueBattleTokenSelectResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012059 RID: 73817 RVA: 0x0054D9C8 File Offset: 0x0054BBC8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnMask))
		};
	}

	// Token: 0x0601205A RID: 73818 RVA: 0x0054DA48 File Offset: 0x0054BC48
	private void OnClickBtnMask()
	{
		MapRogueOp opData = MapRogueModel.Instance.GetOpData((int)this.OpenParam);
		if (opData == null)
		{
			return;
		}
		AddTokenView addTokenView = opData.Data.ShowViewOp.AddTokenView;
		if (addTokenView.Type == 1)
		{
			MapRogueModel.Instance.ExecuteOpData((int)this.OpenParam, null);
			base.CloseMe(null);
			return;
		}
		this.Index++;
		if (this.Index >= addTokenView.RogueResGainDatas.Count)
		{
			MapRogueModel.Instance.ExecuteOpData((int)this.OpenParam, null);
			base.CloseMe(null);
			return;
		}
		this.TokenLayout.RefreshByData(new List<RogueResGainData>(addTokenView.RogueResGainDatas).GetRange(this.Index, this.PerShowCount), null, false);
	}

	// Token: 0x0601205B RID: 73819 RVA: 0x0054DB0F File Offset: 0x0054BD0F
	private RogueBattleTokenItem CreateItem()
	{
		return new RogueBattleTokenItem();
	}

	// Token: 0x0601205C RID: 73820 RVA: 0x0054DB18 File Offset: 0x0054BD18
	protected override UniTask OnBeforeStartAsync()
	{
		RogueBattleTokenSelectResultView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleTokenSelectResultView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04009D3F RID: 40255
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RogueBattleTokenItem, RogueResGainData> TokenLayout;

	// Token: 0x04009D40 RID: 40256
	[Nullable(2)]
	private RogueBattleTopPanel TopPanel;

	// Token: 0x04009D41 RID: 40257
	private int Index;

	// Token: 0x04009D42 RID: 40258
	private int PerShowCount = 1;
}
