using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200138D RID: 5005
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MowingTowerModel : ModelBase
{
	// Token: 0x06008C3E RID: 35902 RVA: 0x001E0FDA File Offset: 0x001DF1DA
	public bool IsOpenMowingTowerFormation()
	{
		return this.CurrentOptionArea != -1;
	}

	// Token: 0x17000BE0 RID: 3040
	// (get) Token: 0x06008C3F RID: 35903 RVA: 0x001E0FE8 File Offset: 0x001DF1E8
	public static MowingTowerModel Instance
	{
		get
		{
			return MowingTowerModel._Instance;
		}
	}

	// Token: 0x06008C40 RID: 35904 RVA: 0x001E0FEF File Offset: 0x001DF1EF
	public static MowingTowerModel GetOrCreateInstance()
	{
		if (MowingTowerModel._Instance == null)
		{
			MowingTowerModel.CreateInstance();
		}
		return MowingTowerModel._Instance;
	}

	// Token: 0x06008C41 RID: 35905 RVA: 0x001E1003 File Offset: 0x001DF203
	public static bool CreateInstance()
	{
		if (MowingTowerModel._Instance != null)
		{
			return true;
		}
		MowingTowerModel._Instance = new MowingTowerModel();
		return true;
	}

	// Token: 0x06008C42 RID: 35906 RVA: 0x001E1019 File Offset: 0x001DF219
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008C43 RID: 35907 RVA: 0x001E101B File Offset: 0x001DF21B
	public static void ResetStaticDefaultValue()
	{
		MowingTowerModel._Instance = null;
	}

	// Token: 0x06008C44 RID: 35908 RVA: 0x001E1023 File Offset: 0x001DF223
	static MowingTowerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MowingTowerModel.CreateStaticDefaultValue), new Action(MowingTowerModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003E39 RID: 15929
	[Nullable(2)]
	public MowingTowerLevelDetailInfo CurrentSelectLevelDetailData;

	// Token: 0x04003E3A RID: 15930
	[Nullable(2)]
	public MowingTowerTeamInfo CurrentTeamInfo;

	// Token: 0x04003E3B RID: 15931
	public bool PlayBackAnimation;

	// Token: 0x04003E3C RID: 15932
	public int CurrentSelectActivityId;

	// Token: 0x04003E3D RID: 15933
	public int CurrentOptionArea = -1;

	// Token: 0x04003E3E RID: 15934
	public List<int> OtherHalfAreaRoleList = new List<int>();

	// Token: 0x04003E3F RID: 15935
	public int[] AddLevel = new int[]
	{
		-1,
		-1
	};

	// Token: 0x04003E40 RID: 15936
	[Nullable(2)]
	private static MowingTowerModel _Instance;
}
