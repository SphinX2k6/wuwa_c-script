using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200263C RID: 9788
[NullableContext(1)]
[Nullable(0)]
public class DailyTaskModel : ModelBase
{
	// Token: 0x0601408D RID: 82061 RVA: 0x0050C678 File Offset: 0x0050A878
	protected override bool OnInit()
	{
		this.DailyQuestMap = new Dictionary<int, DailyQuest>();
		return true;
	}

	// Token: 0x0601408E RID: 82062 RVA: 0x0050C686 File Offset: 0x0050A886
	protected override bool OnClear()
	{
		Dictionary<int, DailyQuest> dailyQuestMap = this.DailyQuestMap;
		if (dailyQuestMap != null)
		{
			dailyQuestMap.Clear();
		}
		this.DailyQuestMap = null;
		return true;
	}

	// Token: 0x0601408F RID: 82063 RVA: 0x0050C6A1 File Offset: 0x0050A8A1
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, DailyQuest> GetAllDailyQuest()
	{
		return this.DailyQuestMap;
	}

	// Token: 0x06014090 RID: 82064 RVA: 0x0050C6AC File Offset: 0x0050A8AC
	public List<int> GetDailyTaskCorrelativeEntities()
	{
		List<int> list = new List<int>();
		foreach (DailyQuest dailyQuest in this.DailyQuestMap.Values)
		{
			IReadOnlyList<int> currentCorrelativeEntities = dailyQuest.GetCurrentCorrelativeEntities();
			if (currentCorrelativeEntities != null)
			{
				foreach (int item in currentCorrelativeEntities)
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	// Token: 0x06014091 RID: 82065 RVA: 0x0050C748 File Offset: 0x0050A948
	public void AddDailyQuest(DailyQuest quest)
	{
		if (quest == null)
		{
			return;
		}
		this.DailyQuestMap[quest.Id] = quest;
		EventSystem.Instance.Emit(EEventName.DailyTaskChange);
	}

	// Token: 0x06014092 RID: 82066 RVA: 0x0050C770 File Offset: 0x0050A970
	public void RemoveDailyQuest(int questId)
	{
		this.DailyQuestMap.Remove(questId);
	}

	// Token: 0x1700197F RID: 6527
	// (get) Token: 0x06014093 RID: 82067 RVA: 0x0050C77F File Offset: 0x0050A97F
	public static DailyTaskModel Instance
	{
		get
		{
			return DailyTaskModel._Instance;
		}
	}

	// Token: 0x06014094 RID: 82068 RVA: 0x0050C786 File Offset: 0x0050A986
	public static DailyTaskModel GetOrCreateInstance()
	{
		if (DailyTaskModel._Instance == null)
		{
			DailyTaskModel.CreateInstance();
		}
		return DailyTaskModel._Instance;
	}

	// Token: 0x06014095 RID: 82069 RVA: 0x0050C79A File Offset: 0x0050A99A
	public static bool CreateInstance()
	{
		if (DailyTaskModel._Instance != null)
		{
			return true;
		}
		DailyTaskModel._Instance = new DailyTaskModel();
		return true;
	}

	// Token: 0x06014096 RID: 82070 RVA: 0x0050C7B0 File Offset: 0x0050A9B0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014097 RID: 82071 RVA: 0x0050C7B2 File Offset: 0x0050A9B2
	public static void ResetStaticDefaultValue()
	{
		DailyTaskModel._Instance = null;
	}

	// Token: 0x06014098 RID: 82072 RVA: 0x0050C7BA File Offset: 0x0050A9BA
	static DailyTaskModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DailyTaskModel.CreateStaticDefaultValue), new Action(DailyTaskModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009708 RID: 38664
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, DailyQuest> DailyQuestMap;

	// Token: 0x04009709 RID: 38665
	[Nullable(2)]
	private static DailyTaskModel _Instance;
}
