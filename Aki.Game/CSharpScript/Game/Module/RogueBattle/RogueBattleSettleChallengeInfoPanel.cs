using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E93 RID: 20115
	public class RogueBattleSettleChallengeInfoPanel : UiPanelBase
	{
		// Token: 0x06033B87 RID: 211847 RVA: 0x00C1D730 File Offset: 0x00C1B930
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
		}

		// Token: 0x06033B88 RID: 211848 RVA: 0x00C1D7B8 File Offset: 0x00C1B9B8
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleSettleChallengeInfoPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleSettleChallengeInfoPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401B769 RID: 112489
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private RogueBattleSettleInfoPanelWithList<RogueBattleSettleInfoRoleGrid, RogueResGainData> RoleLayoutComponent;

		// Token: 0x0401B76A RID: 112490
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private RogueBattleSettleInfoPanelWithList<RogueBattleSettleFetterInfoGrid, RoleBondInfo> FetterLayoutComponent;

		// Token: 0x0401B76B RID: 112491
		public int IncId;

		// Token: 0x0401B76C RID: 112492
		[Nullable(2)]
		public InstResultView ResultView;
	}
}
