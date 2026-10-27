using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004F05 RID: 20229
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleSummaryTeamTabView : UiTabViewBase
	{
		// Token: 0x06033DF4 RID: 212468 RVA: 0x00C2735F File Offset: 0x00C2555F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06033DF5 RID: 212469 RVA: 0x00C27398 File Offset: 0x00C25598
		protected override void OnAfterShow()
		{
			this.UiViewSequence.PlaySequence("Start", false, null);
		}

		// Token: 0x06033DF6 RID: 212470 RVA: 0x00C273C0 File Offset: 0x00C255C0
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleSummaryTeamTabView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleSummaryTeamTabView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033DF7 RID: 212471 RVA: 0x00C27403 File Offset: 0x00C25603
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RogueResMapSummaryTeamShowAgain, new Action(this.OnShowAgain));
		}

		// Token: 0x06033DF8 RID: 212472 RVA: 0x00C27421 File Offset: 0x00C25621
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RogueResMapSummaryTeamShowAgain, new Action(this.OnShowAgain));
		}

		// Token: 0x06033DF9 RID: 212473 RVA: 0x00C27440 File Offset: 0x00C25640
		protected override void OnBeforeShow()
		{
			int getConfigId = SceneTeamModel.Instance.GetTeamItems(false)[0].GetConfigId;
			this.MainRole = getConfigId;
			this.OnShowAgain();
			RogueBattleMapRoleAttributeItem attribute = this.Attribute;
			if (attribute == null)
			{
				return;
			}
			attribute.Refresh(getConfigId);
		}

		// Token: 0x06033DFA RID: 212474 RVA: 0x00C27482 File Offset: 0x00C25682
		protected override void OnBeforeDestroy()
		{
			this.Attribute = null;
			this.RoleInfo = null;
		}

		// Token: 0x06033DFB RID: 212475 RVA: 0x00C27494 File Offset: 0x00C25694
		private void OnShowAgain()
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.MainRole);
			RoleController.Instance.OnSelectedRoleChange(this.MainRole, roleConfig.Value.SkinId);
		}

		// Token: 0x0401B92A RID: 112938
		private int MainRole;

		// Token: 0x0401B92B RID: 112939
		private RogueBattleMapRoleAttributeItem Attribute;

		// Token: 0x0401B92C RID: 112940
		private RogueBattleSummaryRoleItem RoleInfo;
	}
}
