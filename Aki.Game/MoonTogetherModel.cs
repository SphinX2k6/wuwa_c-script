using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x020029FE RID: 10750
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MoonTogetherModel : ModelBase
{
	// Token: 0x17001DC5 RID: 7621
	// (get) Token: 0x060164DD RID: 91357 RVA: 0x005A5101 File Offset: 0x005A3301
	public int CurInviteRoleId
	{
		get
		{
			return this.CurInviteRole;
		}
	}

	// Token: 0x060164DE RID: 91358 RVA: 0x005A5109 File Offset: 0x005A3309
	public void InviteRole(int roleId)
	{
		this.SelectRole = roleId;
	}

	// Token: 0x060164DF RID: 91359 RVA: 0x005A5114 File Offset: 0x005A3314
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

	// Token: 0x060164E0 RID: 91360 RVA: 0x005A516C File Offset: 0x005A336C
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

	// Token: 0x060164E1 RID: 91361 RVA: 0x005A51DC File Offset: 0x005A33DC
	public bool IsLinkageRole(int roleId)
	{
		VehicleRidingRoles? vehicleRidingRolesById = MoonTogetherConfig.Instance.GetVehicleRidingRolesById(roleId);
		return vehicleRidingRolesById != null && vehicleRidingRolesById.GetValueOrDefault().RegionId == 1006;
	}

	// Token: 0x060164E2 RID: 91362 RVA: 0x005A5216 File Offset: 0x005A3416
	public bool IsLinkageRegion(int regionId)
	{
		return regionId == 1006;
	}

	// Token: 0x060164E3 RID: 91363 RVA: 0x005A5220 File Offset: 0x005A3420
	public void ClearCurInviteRole()
	{
		this.CurInviteRole = 0;
		this.SelectRole = 0;
	}

	// Token: 0x17001DC6 RID: 7622
	// (get) Token: 0x060164E4 RID: 91364 RVA: 0x005A5230 File Offset: 0x005A3430
	public static MoonTogetherModel Instance
	{
		get
		{
			return MoonTogetherModel._Instance;
		}
	}

	// Token: 0x060164E5 RID: 91365 RVA: 0x005A5237 File Offset: 0x005A3437
	public static MoonTogetherModel GetOrCreateInstance()
	{
		if (MoonTogetherModel._Instance == null)
		{
			MoonTogetherModel.CreateInstance();
		}
		return MoonTogetherModel._Instance;
	}

	// Token: 0x060164E6 RID: 91366 RVA: 0x005A524B File Offset: 0x005A344B
	public static bool CreateInstance()
	{
		if (MoonTogetherModel._Instance != null)
		{
			return true;
		}
		MoonTogetherModel._Instance = new MoonTogetherModel();
		return true;
	}

	// Token: 0x060164E7 RID: 91367 RVA: 0x005A5261 File Offset: 0x005A3461
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060164E8 RID: 91368 RVA: 0x005A5263 File Offset: 0x005A3463
	public static void ResetStaticDefaultValue()
	{
		MoonTogetherModel._Instance = null;
	}

	// Token: 0x060164E9 RID: 91369 RVA: 0x005A526B File Offset: 0x005A346B
	static MoonTogetherModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonTogetherModel.CreateStaticDefaultValue), new Action(MoonTogetherModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A5E8 RID: 42472
	private const int LINKAGE_ROLE_REGION = 1006;

	// Token: 0x0400A5E9 RID: 42473
	public bool IsInMoonTogether;

	// Token: 0x0400A5EA RID: 42474
	private int CurInviteRole;

	// Token: 0x0400A5EB RID: 42475
	private int SelectRole;

	// Token: 0x0400A5EC RID: 42476
	public int HandleEntityId;

	// Token: 0x0400A5ED RID: 42477
	[Nullable(2)]
	private static MoonTogetherModel _Instance;
}
