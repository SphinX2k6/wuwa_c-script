using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.NPC.Common;
using CSharpScript.Game.Common.Event;

// Token: 0x020000FC RID: 252
[NullableContext(2)]
[Nullable(0)]
public class NpcDecisionController
{
	// Token: 0x06000E38 RID: 3640 RVA: 0x00052BFC File Offset: 0x00050DFC
	[NullableContext(1)]
	public void Init(AiController aiCtrl)
	{
		if (aiCtrl == null)
		{
			return;
		}
		this.AiComp = aiCtrl.CharAiDesignComp;
		if (this.AiComp == null)
		{
			return;
		}
		this.CheckQuestSet = new HashSet<int>();
		this.AddEvents();
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x00052C28 File Offset: 0x00050E28
	private void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.DayStateChange, new Action(this.OnDayStateChanged));
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestChanged));
	}

	// Token: 0x06000E3A RID: 3642 RVA: 0x00052C62 File Offset: 0x00050E62
	private void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.DayStateChange, new Action(this.OnDayStateChanged));
		EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestChanged));
	}

	// Token: 0x06000E3B RID: 3643 RVA: 0x00052C9C File Offset: 0x00050E9C
	private void OnQuestChanged(int questId, QuestState state, EQuestStatusUpdateReason _)
	{
		if (this.AiComp == null)
		{
			return;
		}
		if (state != QuestState.Progress && state != QuestState.Finish)
		{
			return;
		}
		if (this.CheckQuestSet == null || !this.CheckQuestSet.Contains(questId))
		{
			return;
		}
		TsAiController tsAiController = this.AiComp.TsAiController;
		if (tsAiController == null)
		{
			return;
		}
		IBPI_NpcEcological_C ibpi_NpcEcological_C = tsAiController as IBPI_NpcEcological_C;
		if (ibpi_NpcEcological_C == null)
		{
			return;
		}
		ibpi_NpcEcological_C.HandleQuestChanged();
	}

	// Token: 0x06000E3C RID: 3644 RVA: 0x00052CF4 File Offset: 0x00050EF4
	private void OnDayStateChanged()
	{
		if (!this.CheckDayState)
		{
			return;
		}
		if (this.AiComp == null)
		{
			return;
		}
		TsAiController tsAiController = this.AiComp.TsAiController;
		if (tsAiController == null)
		{
			return;
		}
		IBPI_NpcEcological_C ibpi_NpcEcological_C = tsAiController as IBPI_NpcEcological_C;
		if (ibpi_NpcEcological_C == null)
		{
			return;
		}
		ibpi_NpcEcological_C.HandleDayStateChanged();
	}

	// Token: 0x06000E3D RID: 3645 RVA: 0x00052D33 File Offset: 0x00050F33
	public void AddQuestToCheckList(int questId)
	{
		HashSet<int> checkQuestSet = this.CheckQuestSet;
		if (checkQuestSet == null)
		{
			return;
		}
		checkQuestSet.Add(questId);
	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x00052D47 File Offset: 0x00050F47
	public void Destroy()
	{
		this.RemoveEvents();
		this.AiComp = null;
	}

	// Token: 0x04000BA2 RID: 2978
	private CharacterAiComponent AiComp;

	// Token: 0x04000BA3 RID: 2979
	private HashSet<int> CheckQuestSet;

	// Token: 0x04000BA4 RID: 2980
	public bool CheckPlayerImpact;

	// Token: 0x04000BA5 RID: 2981
	public bool CheckPlayerAttack;

	// Token: 0x04000BA6 RID: 2982
	public bool CheckDayState;

	// Token: 0x04000BA7 RID: 2983
	public bool CheckWeatherState;
}
