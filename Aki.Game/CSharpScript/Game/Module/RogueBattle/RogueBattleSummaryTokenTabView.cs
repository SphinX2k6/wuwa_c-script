using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004F07 RID: 20231
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleSummaryTokenTabView : UiTabViewBase
	{
		// Token: 0x06033DFD RID: 212477 RVA: 0x00C274DC File Offset: 0x00C256DC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06033DFE RID: 212478 RVA: 0x00C27536 File Offset: 0x00C25736
		private RogueBattleTokenGrid CreateItem()
		{
			return new RogueBattleTokenGrid
			{
				SelectCallback = new Action<int, RogueResGainData>(this.OnSelectCallback)
			};
		}

		// Token: 0x06033DFF RID: 212479 RVA: 0x00C2754F File Offset: 0x00C2574F
		private void OnSelectCallback(int index, RogueResGainData data)
		{
			RogueBattleTokenItem tokenComponent = this.TokenComponent;
			if (tokenComponent != null)
			{
				tokenComponent.Refresh(data, false, 0);
			}
			RogueBattleTokenItem tokenComponent2 = this.TokenComponent;
			if (tokenComponent2 != null)
			{
				tokenComponent2.SetUiActive(true);
			}
			LoopScrollView<RogueBattleTokenGrid, RogueResGainData> tokenScrollView = this.TokenScrollView;
			if (tokenScrollView == null)
			{
				return;
			}
			tokenScrollView.SelectGridProxy(index, false);
		}

		// Token: 0x06033E00 RID: 212480 RVA: 0x00C2758C File Offset: 0x00C2578C
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleSummaryTokenTabView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleSummaryTokenTabView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401B931 RID: 112945
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<RogueBattleTokenGrid, RogueResGainData> TokenScrollView;

		// Token: 0x0401B932 RID: 112946
		[Nullable(2)]
		private RogueBattleTokenItem TokenComponent;
	}
}
