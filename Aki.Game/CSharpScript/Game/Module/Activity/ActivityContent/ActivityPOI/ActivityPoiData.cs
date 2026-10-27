using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.ActivityPOI
{
	// Token: 0x0200692E RID: 26926
	public class ActivityPoiData : ActivityBaseData
	{
		// Token: 0x060431E5 RID: 274917 RVA: 0x0105B8FA File Offset: 0x01059AFA
		private void HandleQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason _)
		{
			this.OnQuestStateChange(questId, state);
		}

		// Token: 0x060431E6 RID: 274918 RVA: 0x0105B905 File Offset: 0x01059B05
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.HandleQuestStateChange));
		}

		// Token: 0x060431E7 RID: 274919 RVA: 0x0105B923 File Offset: 0x01059B23
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.HandleQuestStateChange));
		}

		// Token: 0x060431E8 RID: 274920 RVA: 0x0105B944 File Offset: 0x01059B44
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

		// Token: 0x060431E9 RID: 274921 RVA: 0x0105B97D File Offset: 0x01059B7D
		protected override bool GetExDataFinishShowState()
		{
			return QuestNewModel.Instance.CheckQuestFinished(this.RoleQuestId);
		}

		// Token: 0x060431EA RID: 274922 RVA: 0x0105B98F File Offset: 0x01059B8F
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

		// Token: 0x060431EB RID: 274923 RVA: 0x0105B9C9 File Offset: 0x01059BC9
		public override bool GetExDataRedPointShowState()
		{
			return false;
		}

		// Token: 0x060431EC RID: 274924 RVA: 0x0105B9CC File Offset: 0x01059BCC
		public override bool NeedSelfControlFirstRedPoint()
		{
			return false;
		}

		// Token: 0x04022F05 RID: 143109
		public int RoleQuestId;
	}
}
