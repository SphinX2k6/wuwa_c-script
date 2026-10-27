using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E73 RID: 20083
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleMapRoleAttributeItem : UiPanelBase
	{
		// Token: 0x06033B18 RID: 211736 RVA: 0x00C1B1C8 File Offset: 0x00C193C8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirm))
			};
		}

		// Token: 0x06033B19 RID: 211737 RVA: 0x00C1B271 File Offset: 0x00C19471
		public void BindEvent()
		{
			EventSystem.Instance.Add(EEventName.RogueResMapSummaryTeamUpdate, new Action<int>(this.OnSelected));
		}

		// Token: 0x06033B1A RID: 211738 RVA: 0x00C1B28F File Offset: 0x00C1948F
		public void UnbindEvent()
		{
			EventSystem.Instance.Remove(EEventName.RogueResMapSummaryTeamUpdate, new Action<int>(this.OnSelected));
		}

		// Token: 0x06033B1B RID: 211739 RVA: 0x00C1B2B0 File Offset: 0x00C194B0
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleMapRoleAttributeItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleMapRoleAttributeItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033B1C RID: 211740 RVA: 0x00C1B2F3 File Offset: 0x00C194F3
		protected override void OnBeforeDestroy()
		{
			this.TopInfo = null;
			this.FetterInfo = null;
			this.BuffInfo = null;
		}

		// Token: 0x06033B1D RID: 211741 RVA: 0x00C1B30C File Offset: 0x00C1950C
		public void Refresh(int roleId)
		{
			this.RoleId = roleId;
			bool flag = RogueBattleModel.Instance.IsRoleGot(roleId);
			UUIButtonComponent button = base.GetButton(3);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(flag);
			}
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			this.TopInfo.Refresh(roleId);
			this.FetterInfo.Refresh(roleId);
			if (flag)
			{
				this.BuffInfo.SetUiActive(true);
				this.BuffInfo.Refresh(roleId);
				return;
			}
			this.BuffInfo.SetUiActive(false);
		}

		// Token: 0x06033B1E RID: 211742 RVA: 0x00C1B3A4 File Offset: 0x00C195A4
		private void OnClickConfirm()
		{
			if (!RogueBattleModel.Instance.IsRoleGot(this.RoleId))
			{
				return;
			}
			List<int> summaryRoleList = RogueBattleModel.Instance.SummaryRoleList;
			List<int> list = new List<int>();
			foreach (int num in summaryRoleList)
			{
				if (num >= 100000)
				{
					list.Add(num);
				}
				else
				{
					list.Add(RogueBattleConfig.Instance.GetRogueResBondRole(num).Value.TrialRoleId);
				}
			}
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, this.RoleId, list, new EUiTabViewName?(EUiTabViewName.RoleSkillTabView), null);
		}

		// Token: 0x06033B1F RID: 211743 RVA: 0x00C1B460 File Offset: 0x00C19660
		private void OnSelected(int roleId)
		{
			this.Refresh(roleId);
		}

		// Token: 0x0401B6EA RID: 112362
		private int RoleId;

		// Token: 0x0401B6EB RID: 112363
		private RogueBattleMapRoleAttributeNameItem TopInfo;

		// Token: 0x0401B6EC RID: 112364
		private RogueBattleMapRoleAttributeFettersItem FetterInfo;

		// Token: 0x0401B6ED RID: 112365
		private RogueBattleMapRoleAttributeBuffsItem BuffInfo;
	}
}
