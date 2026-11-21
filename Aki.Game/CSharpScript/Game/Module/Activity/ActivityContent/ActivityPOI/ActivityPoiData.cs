using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.ActivityPOI
{
	// Token: 0x0200587E RID: 22654
	public class ActivityPoiData : ActivityBaseData
	{
		// Token: 0x06037D3D RID: 228669 RVA: 0x00F9CF26 File Offset: 0x00F9B126
		private void HandleQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason _)
		{
			this.OnQuestStateChange(questId, state);
		}

		// Token: 0x06037D3E RID: 228670 RVA: 0x00F9CF31 File Offset: 0x00F9B131
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.HandleQuestStateChange));
		}

		// Token: 0x06037D3F RID: 228671 RVA: 0x00F9CF4F File Offset: 0x00F9B14F
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.HandleQuestStateChange));
		}

		// Token: 0x06037D40 RID: 228672 RVA: 0x00F9CF70 File Offset: 0x00F9B170
		[NullableContext(1)]
		protected override void PhraseEx(ActivityData data)
		{
			RoleGuideActivity? config = ConfigRoleGuideActivityById.GetConfig(base.Id, true);
			if (config == null)
			{
				return;
			}
			this.RoleQuestId = config.Value.RoleQuestId;
		}

		// Token: 0x06037D41 RID: 228673 RVA: 0x00F9CFA9 File Offset: 0x00F9B1A9
		protected override bool GetExDataFinishShowState()
		{
			return QuestNewModel.Instance.CheckQuestFinished(this.RoleQuestId);
		}

		// Token: 0x06037D42 RID: 228674 RVA: 0x00F9CFBB File Offset: 0x00F9B1BB
		public bool OnQuestStateChange(int questId, QuestState state)
		{
			if (questId != this.RoleQuestId)
			{
				return false;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, base.Id);
			return true;
		}

		// Token: 0x06037D43 RID: 228675 RVA: 0x00F9CFF5 File Offset: 0x00F9B1F5
		public override bool GetExDataRedPointShowState()
		{
			return false;
		}

		// Token: 0x06037D44 RID: 228676 RVA: 0x00F9CFF8 File Offset: 0x00F9B1F8
		public override bool NeedSelfControlFirstRedPoint()
		{
			return false;
		}

		// Token: 0x0401D761 RID: 120673
		public int RoleQuestId;
	}
}
