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
	// Token: 0x02003ECE RID: 16078
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleSummaryTeamTabView : UiTabViewBase
	{
		// Token: 0x06028C5F RID: 167007 RVA: 0x00B708FF File Offset: 0x00B6EAFF
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06028C60 RID: 167008 RVA: 0x00B70938 File Offset: 0x00B6EB38
		protected override void OnAfterShow()
		{
			this.UiViewSequence.PlaySequence("Start", false, null);
		}

		// Token: 0x06028C61 RID: 167009 RVA: 0x00B70960 File Offset: 0x00B6EB60
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleSummaryTeamTabView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleSummaryTeamTabView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028C62 RID: 167010 RVA: 0x00B709A3 File Offset: 0x00B6EBA3
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RogueResMapSummaryTeamShowAgain, new Action(this.OnShowAgain));
		}

		// Token: 0x06028C63 RID: 167011 RVA: 0x00B709C1 File Offset: 0x00B6EBC1
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RogueResMapSummaryTeamShowAgain, new Action(this.OnShowAgain));
		}

		// Token: 0x06028C64 RID: 167012 RVA: 0x00B709E0 File Offset: 0x00B6EBE0
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

		// Token: 0x06028C65 RID: 167013 RVA: 0x00B70A22 File Offset: 0x00B6EC22
		protected override void OnBeforeDestroy()
		{
			this.Attribute = null;
			this.RoleInfo = null;
		}

		// Token: 0x06028C66 RID: 167014 RVA: 0x00B70A34 File Offset: 0x00B6EC34
		private void OnShowAgain()
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.MainRole);
			RoleController.Instance.OnSelectedRoleChange(this.MainRole, roleConfig.Value.SkinId);
		}

		// Token: 0x040162FD RID: 90877
		private int MainRole;

		// Token: 0x040162FE RID: 90878
		private RogueBattleMapRoleAttributeItem Attribute;

		// Token: 0x040162FF RID: 90879
		private RogueBattleSummaryRoleItem RoleInfo;
	}
}
