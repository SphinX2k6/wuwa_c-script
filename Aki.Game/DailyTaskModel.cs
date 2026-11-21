using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02001B27 RID: 6951
[NullableContext(1)]
[Nullable(0)]
public class DailyTaskModel : ModelBase
{
	// Token: 0x0601156F RID: 71023 RVA: 0x0051B598 File Offset: 0x00519798
	protected override bool OnInit()
	{
		this.DailyQuestMap = new Dictionary<int, DailyQuest>();
		return true;
	}

	// Token: 0x06011570 RID: 71024 RVA: 0x0051B5A6 File Offset: 0x005197A6
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

	// Token: 0x06011571 RID: 71025 RVA: 0x0051B5C1 File Offset: 0x005197C1
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, DailyQuest> GetAllDailyQuest()
	{
		return this.DailyQuestMap;
	}

	// Token: 0x06011572 RID: 71026 RVA: 0x0051B5CC File Offset: 0x005197CC
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

	// Token: 0x06011573 RID: 71027 RVA: 0x0051B668 File Offset: 0x00519868
	public void AddDailyQuest(DailyQuest quest)
	{
		if (quest == null)
		{
			return;
		}
		this.DailyQuestMap[quest.Id] = quest;
		EventSystem.Instance.Emit(EEventName.DailyTaskChange);
	}

	// Token: 0x06011574 RID: 71028 RVA: 0x0051B690 File Offset: 0x00519890
	public void RemoveDailyQuest(int questId)
	{
		this.DailyQuestMap.Remove(questId);
	}

	// Token: 0x170019B7 RID: 6583
	// (get) Token: 0x06011575 RID: 71029 RVA: 0x0051B69F File Offset: 0x0051989F
	public static DailyTaskModel Instance
	{
		get
		{
			return DailyTaskModel._Instance;
		}
	}

	// Token: 0x06011576 RID: 71030 RVA: 0x0051B6A6 File Offset: 0x005198A6
	public static DailyTaskModel GetOrCreateInstance()
	{
		if (DailyTaskModel._Instance == null)
		{
			DailyTaskModel.CreateInstance();
		}
		return DailyTaskModel._Instance;
	}

	// Token: 0x06011577 RID: 71031 RVA: 0x0051B6BA File Offset: 0x005198BA
	public static bool CreateInstance()
	{
		if (DailyTaskModel._Instance != null)
		{
			return true;
		}
		DailyTaskModel._Instance = new DailyTaskModel();
		return true;
	}

	// Token: 0x06011578 RID: 71032 RVA: 0x0051B6D0 File Offset: 0x005198D0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011579 RID: 71033 RVA: 0x0051B6D2 File Offset: 0x005198D2
	public static void ResetStaticDefaultValue()
	{
		DailyTaskModel._Instance = null;
	}

	// Token: 0x0601157A RID: 71034 RVA: 0x0051B6DA File Offset: 0x005198DA
	static DailyTaskModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DailyTaskModel.CreateStaticDefaultValue), new Action(DailyTaskModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009860 RID: 39008
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, DailyQuest> DailyQuestMap;

	// Token: 0x04009861 RID: 39009
	[Nullable(2)]
	private static DailyTaskModel _Instance;
}
