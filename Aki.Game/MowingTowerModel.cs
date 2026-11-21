using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000841 RID: 2113
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MowingTowerModel : ModelBase
{
	// Token: 0x06005FD9 RID: 24537 RVA: 0x001E9E2E File Offset: 0x001E802E
	public bool IsOpenMowingTowerFormation()
	{
		return this.CurrentOptionArea != -1;
	}

	// Token: 0x17000C00 RID: 3072
	// (get) Token: 0x06005FDA RID: 24538 RVA: 0x001E9E3C File Offset: 0x001E803C
	public static MowingTowerModel Instance
	{
		get
		{
			return MowingTowerModel._Instance;
		}
	}

	// Token: 0x06005FDB RID: 24539 RVA: 0x001E9E43 File Offset: 0x001E8043
	public static MowingTowerModel GetOrCreateInstance()
	{
		if (MowingTowerModel._Instance == null)
		{
			MowingTowerModel.CreateInstance();
		}
		return MowingTowerModel._Instance;
	}

	// Token: 0x06005FDC RID: 24540 RVA: 0x001E9E57 File Offset: 0x001E8057
	public static bool CreateInstance()
	{
		if (MowingTowerModel._Instance != null)
		{
			return true;
		}
		MowingTowerModel._Instance = new MowingTowerModel();
		return true;
	}

	// Token: 0x06005FDD RID: 24541 RVA: 0x001E9E6D File Offset: 0x001E806D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005FDE RID: 24542 RVA: 0x001E9E6F File Offset: 0x001E806F
	public static void ResetStaticDefaultValue()
	{
		MowingTowerModel._Instance = null;
	}

	// Token: 0x06005FDF RID: 24543 RVA: 0x001E9E77 File Offset: 0x001E8077
	static MowingTowerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MowingTowerModel.CreateStaticDefaultValue), new Action(MowingTowerModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003ED1 RID: 16081
	[Nullable(2)]
	public MowingTowerLevelDetailInfo CurrentSelectLevelDetailData;

	// Token: 0x04003ED2 RID: 16082
	[Nullable(2)]
	public MowingTowerTeamInfo CurrentTeamInfo;

	// Token: 0x04003ED3 RID: 16083
	public bool PlayBackAnimation;

	// Token: 0x04003ED4 RID: 16084
	public int CurrentSelectActivityId;

	// Token: 0x04003ED5 RID: 16085
	public int CurrentOptionArea = -1;

	// Token: 0x04003ED6 RID: 16086
	public List<int> OtherHalfAreaRoleList = new List<int>();

	// Token: 0x04003ED7 RID: 16087
	public int[] AddLevel = new int[]
	{
		-1,
		-1
	};

	// Token: 0x04003ED8 RID: 16088
	[Nullable(2)]
	private static MowingTowerModel _Instance;
}
