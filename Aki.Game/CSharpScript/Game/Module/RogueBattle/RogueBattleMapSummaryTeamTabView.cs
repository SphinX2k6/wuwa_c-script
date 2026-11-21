using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EB9 RID: 16057
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleMapSummaryTeamTabView : UiTabViewBase
	{
		// Token: 0x06028BF4 RID: 166900 RVA: 0x00B6E672 File Offset: 0x00B6C872
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06028BF5 RID: 166901 RVA: 0x00B6E6AB File Offset: 0x00B6C8AB
		protected override void AddEventListener()
		{
			this.Attribute.BindEvent();
			this.RoleList.BindEvent();
		}

		// Token: 0x06028BF6 RID: 166902 RVA: 0x00B6E6C3 File Offset: 0x00B6C8C3
		protected override void RemoveEventListener()
		{
			this.Attribute.UnbindEvent();
			this.RoleList.UnbindEvent();
		}

		// Token: 0x06028BF7 RID: 166903 RVA: 0x00B6E6DC File Offset: 0x00B6C8DC
		protected override void OnAfterShow()
		{
			this.UiViewSequence.PlaySequence("Start", false, null);
		}

		// Token: 0x06028BF8 RID: 166904 RVA: 0x00B6E704 File Offset: 0x00B6C904
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleMapSummaryTeamTabView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleMapSummaryTeamTabView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028BF9 RID: 166905 RVA: 0x00B6E747 File Offset: 0x00B6C947
		protected override void OnBeforeDestroy()
		{
			this.Attribute = null;
			this.RoleList = null;
		}

		// Token: 0x0401628E RID: 90766
		private RogueBattleMapRoleAttributeItem Attribute;

		// Token: 0x0401628F RID: 90767
		private RogueBattleMapRoleListPanel RoleList;
	}
}
