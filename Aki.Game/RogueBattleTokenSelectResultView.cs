using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200277A RID: 10106
[NullableContext(1)]
[Nullable(0)]
public class RogueBattleTokenSelectResultView : UiViewBase
{
	// Token: 0x06014B75 RID: 84853 RVA: 0x0053EB36 File Offset: 0x0053CD36
	public RogueBattleTokenSelectResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014B76 RID: 84854 RVA: 0x0053EB48 File Offset: 0x0053CD48
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

	// Token: 0x06014B77 RID: 84855 RVA: 0x0053EBC8 File Offset: 0x0053CDC8
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
		this.TokenLayout.RefreshByData(addTokenView.RogueResGainDatas.ToList<RogueResGainData>().GetRange(this.Index, this.PerShowCount), null, false);
	}

	// Token: 0x06014B78 RID: 84856 RVA: 0x0053EC8F File Offset: 0x0053CE8F
	private RogueBattleTokenItem CreateItem()
	{
		return new RogueBattleTokenItem();
	}

	// Token: 0x06014B79 RID: 84857 RVA: 0x0053EC98 File Offset: 0x0053CE98
	protected override UniTask OnBeforeStartAsync()
	{
		RogueBattleTokenSelectResultView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleTokenSelectResultView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04009BE7 RID: 39911
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RogueBattleTokenItem, RogueResGainData> TokenLayout;

	// Token: 0x04009BE8 RID: 39912
	[Nullable(2)]
	private RogueBattleTopPanel TopPanel;

	// Token: 0x04009BE9 RID: 39913
	private int Index;

	// Token: 0x04009BEA RID: 39914
	private int PerShowCount = 1;
}
