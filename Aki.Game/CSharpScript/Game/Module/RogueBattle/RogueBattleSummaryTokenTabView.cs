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
	// Token: 0x02003ED0 RID: 16080
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleSummaryTokenTabView : UiTabViewBase
	{
		// Token: 0x06028C68 RID: 167016 RVA: 0x00B70A7C File Offset: 0x00B6EC7C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06028C69 RID: 167017 RVA: 0x00B70AD6 File Offset: 0x00B6ECD6
		private RogueBattleTokenGrid CreateItem()
		{
			return new RogueBattleTokenGrid
			{
				SelectCallback = new Action<int, RogueResGainData>(this.OnSelectCallback)
			};
		}

		// Token: 0x06028C6A RID: 167018 RVA: 0x00B70AEF File Offset: 0x00B6ECEF
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

		// Token: 0x06028C6B RID: 167019 RVA: 0x00B70B2C File Offset: 0x00B6ED2C
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleSummaryTokenTabView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleSummaryTokenTabView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04016304 RID: 90884
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<RogueBattleTokenGrid, RogueResGainData> TokenScrollView;

		// Token: 0x04016305 RID: 90885
		[Nullable(2)]
		private RogueBattleTokenItem TokenComponent;
	}
}
