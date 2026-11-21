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
	// Token: 0x02003E3C RID: 15932
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleMapRoleAttributeItem : UiPanelBase
	{
		// Token: 0x06028983 RID: 166275 RVA: 0x00B646EC File Offset: 0x00B628EC
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

		// Token: 0x06028984 RID: 166276 RVA: 0x00B64795 File Offset: 0x00B62995
		public void BindEvent()
		{
			EventSystem.Instance.Add(EEventName.RogueResMapSummaryTeamUpdate, new Action<int>(this.OnSelected));
		}

		// Token: 0x06028985 RID: 166277 RVA: 0x00B647B3 File Offset: 0x00B629B3
		public void UnbindEvent()
		{
			EventSystem.Instance.Remove(EEventName.RogueResMapSummaryTeamUpdate, new Action<int>(this.OnSelected));
		}

		// Token: 0x06028986 RID: 166278 RVA: 0x00B647D4 File Offset: 0x00B629D4
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleMapRoleAttributeItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleMapRoleAttributeItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028987 RID: 166279 RVA: 0x00B64817 File Offset: 0x00B62A17
		protected override void OnBeforeDestroy()
		{
			this.TopInfo = null;
			this.FetterInfo = null;
			this.BuffInfo = null;
		}

		// Token: 0x06028988 RID: 166280 RVA: 0x00B64830 File Offset: 0x00B62A30
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

		// Token: 0x06028989 RID: 166281 RVA: 0x00B648C8 File Offset: 0x00B62AC8
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

		// Token: 0x0602898A RID: 166282 RVA: 0x00B64984 File Offset: 0x00B62B84
		private void OnSelected(int roleId)
		{
			this.Refresh(roleId);
		}

		// Token: 0x040160BD RID: 90301
		private int RoleId;

		// Token: 0x040160BE RID: 90302
		private RogueBattleMapRoleAttributeNameItem TopInfo;

		// Token: 0x040160BF RID: 90303
		private RogueBattleMapRoleAttributeFettersItem FetterInfo;

		// Token: 0x040160C0 RID: 90304
		private RogueBattleMapRoleAttributeBuffsItem BuffInfo;
	}
}
