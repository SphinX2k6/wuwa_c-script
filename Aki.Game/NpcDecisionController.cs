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
	// Token: 0x06000E32 RID: 3634 RVA: 0x00052068 File Offset: 0x00050268
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

	// Token: 0x06000E33 RID: 3635 RVA: 0x00052094 File Offset: 0x00050294
	private void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.DayStateChange, new Action(this.OnDayStateChanged));
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestChanged));
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x000520CE File Offset: 0x000502CE
	private void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.DayStateChange, new Action(this.OnDayStateChanged));
		EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestChanged));
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x00052108 File Offset: 0x00050308
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

	// Token: 0x06000E36 RID: 3638 RVA: 0x00052160 File Offset: 0x00050360
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

	// Token: 0x06000E37 RID: 3639 RVA: 0x0005219F File Offset: 0x0005039F
	public void AddQuestToCheckList(int questId)
	{
		HashSet<int> checkQuestSet = this.CheckQuestSet;
		if (checkQuestSet == null)
		{
			return;
		}
		checkQuestSet.Add(questId);
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x000521B3 File Offset: 0x000503B3
	public void Destroy()
	{
		this.RemoveEvents();
		this.AiComp = null;
	}

	// Token: 0x04000B9A RID: 2970
	private CharacterAiComponent AiComp;

	// Token: 0x04000B9B RID: 2971
	private HashSet<int> CheckQuestSet;

	// Token: 0x04000B9C RID: 2972
	public bool CheckPlayerImpact;

	// Token: 0x04000B9D RID: 2973
	public bool CheckPlayerAttack;

	// Token: 0x04000B9E RID: 2974
	public bool CheckDayState;

	// Token: 0x04000B9F RID: 2975
	public bool CheckWeatherState;
}
