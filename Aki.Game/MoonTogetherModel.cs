using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02001F79 RID: 8057
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MoonTogetherModel : ModelBase
{
	// Token: 0x17001E1E RID: 7710
	// (get) Token: 0x06013EE4 RID: 81636 RVA: 0x005D00D9 File Offset: 0x005CE2D9
	public int CurInviteRoleId
	{
		get
		{
			return this.CurInviteRole;
		}
	}

	// Token: 0x06013EE5 RID: 81637 RVA: 0x005D00E1 File Offset: 0x005CE2E1
	public void InviteRole(int roleId)
	{
		this.SelectRole = roleId;
	}

	// Token: 0x06013EE6 RID: 81638 RVA: 0x005D00EC File Offset: 0x005CE2EC
	public void ExitAndClear()
	{
		this.IsInMoonTogether = false;
		if (UiManager.Instance.IsViewOpen(EUiViewName.MoonTogetherMainView))
		{
			UiManager.Instance.CloseView(EUiViewName.MoonTogetherMainView, null);
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.MoonTogetherInviteView))
		{
			UiManager.Instance.CloseView(EUiViewName.MoonTogetherInviteView, null);
		}
	}

	// Token: 0x06013EE7 RID: 81639 RVA: 0x005D0144 File Offset: 0x005CE344
	public void SendAndSave()
	{
		this.IsInMoonTogether = true;
		if (this.CurInviteRole == this.SelectRole)
		{
			return;
		}
		if (this.CurInviteRole != 0)
		{
			EventSystem.Instance.Emit<int, int>(EEventName.OnRemoveRideSharingPassenger, this.CurInviteRole, 1);
		}
		if (this.SelectRole != 0)
		{
			EventSystem.Instance.Emit<int, int>(EEventName.OnChangeRideSharingPassenger, this.SelectRole, 1);
		}
		this.CurInviteRole = this.SelectRole;
	}

	// Token: 0x06013EE8 RID: 81640 RVA: 0x005D01B4 File Offset: 0x005CE3B4
	public bool IsLinkageRole(int roleId)
	{
		VehicleRidingRoles? vehicleRidingRolesById = MoonTogetherConfig.Instance.GetVehicleRidingRolesById(roleId);
		return vehicleRidingRolesById != null && vehicleRidingRolesById.GetValueOrDefault().RegionId == 1006;
	}

	// Token: 0x06013EE9 RID: 81641 RVA: 0x005D01EE File Offset: 0x005CE3EE
	public bool IsLinkageRegion(int regionId)
	{
		return regionId == 1006;
	}

	// Token: 0x06013EEA RID: 81642 RVA: 0x005D01F8 File Offset: 0x005CE3F8
	public void ClearCurInviteRole()
	{
		this.CurInviteRole = 0;
		this.SelectRole = 0;
	}

	// Token: 0x17001E1F RID: 7711
	// (get) Token: 0x06013EEB RID: 81643 RVA: 0x005D0208 File Offset: 0x005CE408
	public static MoonTogetherModel Instance
	{
		get
		{
			return MoonTogetherModel._Instance;
		}
	}

	// Token: 0x06013EEC RID: 81644 RVA: 0x005D020F File Offset: 0x005CE40F
	public static MoonTogetherModel GetOrCreateInstance()
	{
		if (MoonTogetherModel._Instance == null)
		{
			MoonTogetherModel.CreateInstance();
		}
		return MoonTogetherModel._Instance;
	}

	// Token: 0x06013EED RID: 81645 RVA: 0x005D0223 File Offset: 0x005CE423
	public static bool CreateInstance()
	{
		if (MoonTogetherModel._Instance != null)
		{
			return true;
		}
		MoonTogetherModel._Instance = new MoonTogetherModel();
		return true;
	}

	// Token: 0x06013EEE RID: 81646 RVA: 0x005D0239 File Offset: 0x005CE439
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013EEF RID: 81647 RVA: 0x005D023B File Offset: 0x005CE43B
	public static void ResetStaticDefaultValue()
	{
		MoonTogetherModel._Instance = null;
	}

	// Token: 0x06013EF0 RID: 81648 RVA: 0x005D0243 File Offset: 0x005CE443
	static MoonTogetherModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonTogetherModel.CreateStaticDefaultValue), new Action(MoonTogetherModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A9D2 RID: 43474
	private const int LINKAGE_ROLE_REGION = 1006;

	// Token: 0x0400A9D3 RID: 43475
	public bool IsInMoonTogether;

	// Token: 0x0400A9D4 RID: 43476
	private int CurInviteRole;

	// Token: 0x0400A9D5 RID: 43477
	private int SelectRole;

	// Token: 0x0400A9D6 RID: 43478
	public int HandleEntityId;

	// Token: 0x0400A9D7 RID: 43479
	[Nullable(2)]
	private static MoonTogetherModel _Instance;
}
