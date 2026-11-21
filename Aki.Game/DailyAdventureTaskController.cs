using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;

// Token: 0x020006C9 RID: 1737
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class DailyAdventureTaskController : UiControllerBase
{
	// Token: 0x06004F8E RID: 20366 RVA: 0x001AB910 File Offset: 0x001A9B10
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

	// Token: 0x06004F8F RID: 20367 RVA: 0x001AB9A4 File Offset: 0x001A9BA4
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

	// Token: 0x06004F90 RID: 20368 RVA: 0x001ABA04 File Offset: 0x001A9C04
	private void JumpRoleRootView(EUiTabViewName? tabViewName = null)
	{
		RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, 0, new List<int>(), tabViewName, null);
	}

	// Token: 0x06004F91 RID: 20369 RVA: 0x001ABA19 File Offset: 0x001A9C19
	private void RunSkipTask(int skipTaskId)
	{
		SkipTaskManager.RunByConfigId(skipTaskId, null);
	}

	// Token: 0x17000AB0 RID: 2736
	// (get) Token: 0x06004F92 RID: 20370 RVA: 0x001ABA22 File Offset: 0x001A9C22
	public static DailyAdventureTaskController Instance
	{
		get
		{
			return DailyAdventureTaskController._Instance;
		}
	}

	// Token: 0x06004F93 RID: 20371 RVA: 0x001ABA29 File Offset: 0x001A9C29
	public static DailyAdventureTaskController GetOrCreateInstance()
	{
		if (DailyAdventureTaskController._Instance == null)
		{
			DailyAdventureTaskController.CreateInstance();
		}
		return DailyAdventureTaskController._Instance;
	}

	// Token: 0x06004F94 RID: 20372 RVA: 0x001ABA3D File Offset: 0x001A9C3D
	public static bool CreateInstance()
	{
		if (DailyAdventureTaskController._Instance != null)
		{
			return true;
		}
		DailyAdventureTaskController._Instance = new DailyAdventureTaskController();
		return true;
	}

	// Token: 0x06004F95 RID: 20373 RVA: 0x001ABA53 File Offset: 0x001A9C53
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004F96 RID: 20374 RVA: 0x001ABA55 File Offset: 0x001A9C55
	public static void ResetStaticDefaultValue()
	{
		DailyAdventureTaskController._Instance = null;
	}

	// Token: 0x06004F97 RID: 20375 RVA: 0x001ABA5D File Offset: 0x001A9C5D
	static DailyAdventureTaskController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DailyAdventureTaskController.CreateStaticDefaultValue), new Action(DailyAdventureTaskController.ResetStaticDefaultValue));
	}

	// Token: 0x04003961 RID: 14689
	[Nullable(2)]
	private static DailyAdventureTaskController _Instance;
}
