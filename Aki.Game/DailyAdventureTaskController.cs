using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;

// Token: 0x02001215 RID: 4629
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class DailyAdventureTaskController : UiControllerBase
{
	// Token: 0x06007BF8 RID: 31736 RVA: 0x001A2C98 File Offset: 0x001A0E98
	public void TrackTaskByType(EDailyAdventureTaskJumpType type, string[] paramsList)
	{
		switch (type)
		{
		case EDailyAdventureTaskJumpType.Normal:
			break;
		case EDailyAdventureTaskJumpType.Map:
		{
			List<int> list = new List<int>();
			foreach (string s in paramsList)
			{
				list.Add(int.Parse(s));
			}
			this.OpenAndTrackMap(list.ToArray());
			return;
		}
		case EDailyAdventureTaskJumpType.Role:
		{
			EUiTabViewName value = EUiTabViewName.DailyActivityTabView;
			if (paramsList != null && paramsList.Length >= 1)
			{
				value = (EUiTabViewName)paramsList[0];
			}
			this.JumpRoleRootView(new EUiTabViewName?(value));
			return;
		}
		case EDailyAdventureTaskJumpType.SkipTask:
		{
			int skipTaskId = int.Parse(paramsList[0]);
			this.RunSkipTask(skipTaskId);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06007BF9 RID: 31737 RVA: 0x001A2D2C File Offset: 0x001A0F2C
	private void OpenAndTrackMap(int[] markIdList)
	{
		int value = 0;
		if (markIdList.Length > 1)
		{
			value = (MapModel.Instance.IsConfigMarkIdUnlock(markIdList[0]) ? markIdList[0] : markIdList[1]);
		}
		WorldMapViewOpenParams data = new WorldMapViewOpenParams
		{
			MarkId = new int?(value),
			MarkType = EMarkType.None,
			OpenFogId = new int?(0)
		};
		WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
	}

	// Token: 0x06007BFA RID: 31738 RVA: 0x001A2D8C File Offset: 0x001A0F8C
	private void JumpRoleRootView(EUiTabViewName? tabViewName = null)
	{
		RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, 0, new List<int>(), tabViewName, null);
	}

	// Token: 0x06007BFB RID: 31739 RVA: 0x001A2DA1 File Offset: 0x001A0FA1
	private void RunSkipTask(int skipTaskId)
	{
		SkipTaskManager.RunByConfigId(skipTaskId, null);
	}

	// Token: 0x17000A90 RID: 2704
	// (get) Token: 0x06007BFC RID: 31740 RVA: 0x001A2DAA File Offset: 0x001A0FAA
	public static DailyAdventureTaskController Instance
	{
		get
		{
			return DailyAdventureTaskController._Instance;
		}
	}

	// Token: 0x06007BFD RID: 31741 RVA: 0x001A2DB1 File Offset: 0x001A0FB1
	public static DailyAdventureTaskController GetOrCreateInstance()
	{
		if (DailyAdventureTaskController._Instance == null)
		{
			DailyAdventureTaskController.CreateInstance();
		}
		return DailyAdventureTaskController._Instance;
	}

	// Token: 0x06007BFE RID: 31742 RVA: 0x001A2DC5 File Offset: 0x001A0FC5
	public static bool CreateInstance()
	{
		if (DailyAdventureTaskController._Instance != null)
		{
			return true;
		}
		DailyAdventureTaskController._Instance = new DailyAdventureTaskController();
		return true;
	}

	// Token: 0x06007BFF RID: 31743 RVA: 0x001A2DDB File Offset: 0x001A0FDB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007C00 RID: 31744 RVA: 0x001A2DDD File Offset: 0x001A0FDD
	public static void ResetStaticDefaultValue()
	{
		DailyAdventureTaskController._Instance = null;
	}

	// Token: 0x06007C01 RID: 31745 RVA: 0x001A2DE5 File Offset: 0x001A0FE5
	static DailyAdventureTaskController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DailyAdventureTaskController.CreateStaticDefaultValue), new Action(DailyAdventureTaskController.ResetStaticDefaultValue));
	}

	// Token: 0x040038C8 RID: 14536
	[Nullable(2)]
	private static DailyAdventureTaskController _Instance;
}
