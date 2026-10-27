using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EF0 RID: 20208
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleMapSummaryTeamTabView : UiTabViewBase
	{
		// Token: 0x06033D89 RID: 212361 RVA: 0x00C250CA File Offset: 0x00C232CA
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06033D8A RID: 212362 RVA: 0x00C25103 File Offset: 0x00C23303
		protected override void AddEventListener()
		{
			this.Attribute.BindEvent();
			this.RoleList.BindEvent();
		}

		// Token: 0x06033D8B RID: 212363 RVA: 0x00C2511B File Offset: 0x00C2331B
		protected override void RemoveEventListener()
		{
			this.Attribute.UnbindEvent();
			this.RoleList.UnbindEvent();
		}

		// Token: 0x06033D8C RID: 212364 RVA: 0x00C25134 File Offset: 0x00C23334
		protected override void OnAfterShow()
		{
			this.UiViewSequence.PlaySequence("Start", false, null);
		}

		// Token: 0x06033D8D RID: 212365 RVA: 0x00C2515C File Offset: 0x00C2335C
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleMapSummaryTeamTabView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleMapSummaryTeamTabView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033D8E RID: 212366 RVA: 0x00C2519F File Offset: 0x00C2339F
		protected override void OnBeforeDestroy()
		{
			this.Attribute = null;
			this.RoleList = null;
		}

		// Token: 0x0401B8BB RID: 112827
		private RogueBattleMapRoleAttributeItem Attribute;

		// Token: 0x0401B8BC RID: 112828
		private RogueBattleMapRoleListPanel RoleList;
	}
}
