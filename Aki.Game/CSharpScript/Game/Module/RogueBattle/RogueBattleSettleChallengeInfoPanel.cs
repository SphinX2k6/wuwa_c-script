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
	// Token: 0x02003E5C RID: 15964
	public class RogueBattleSettleChallengeInfoPanel : UiPanelBase
	{
		// Token: 0x060289F2 RID: 166386 RVA: 0x00B66C4C File Offset: 0x00B64E4C
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

		// Token: 0x060289F3 RID: 166387 RVA: 0x00B66CD4 File Offset: 0x00B64ED4
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleSettleChallengeInfoPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleSettleChallengeInfoPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401613C RID: 90428
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private RogueBattleSettleInfoPanelWithList<RogueBattleSettleInfoRoleGrid, RogueResGainData> RoleLayoutComponent;

		// Token: 0x0401613D RID: 90429
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private RogueBattleSettleInfoPanelWithList<RogueBattleSettleFetterInfoGrid, RoleBondInfo> FetterLayoutComponent;

		// Token: 0x0401613E RID: 90430
		public int IncId;

		// Token: 0x0401613F RID: 90431
		[Nullable(2)]
		public InstResultView ResultView;
	}
}
