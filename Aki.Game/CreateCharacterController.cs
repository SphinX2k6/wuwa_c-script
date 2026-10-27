using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x020019E6 RID: 6630
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class CreateCharacterController : UiControllerBase
{
	// Token: 0x0600C1E4 RID: 49636 RVA: 0x002BC4A0 File Offset: 0x002BA6A0
	public static void TriggerInputName()
	{
		EventSystem.Instance.Emit(EEventName.CreateRoleShowInputName);
	}

	// Token: 0x0600C1E5 RID: 49637 RVA: 0x002BC4B4 File Offset: 0x002BA6B4
	public static void AddBurstEyeRenderingMaterial(bool isBoy)
	{
		int roleId = CreateCharacterConfig.Instance.GetInitialRoles()[(isBoy > false) ? 1 : 0];
		string effectId = isBoy ? "RoleMaleBurstEyeMaterialController" : "RoleFemaleBurstEyeMaterialController";
		int burstEyeMaterialId = UiLoginSceneManager.Instance.SetRoleRenderingMaterial(roleId, effectId);
		UiLoginSceneManager.Instance.SetBurstEyeMaterialId(burstEyeMaterialId);
	}

	// Token: 0x0600C1E6 RID: 49638 RVA: 0x002BC500 File Offset: 0x002BA700
	public static void RemoveBurstEyeRenderingMaterial(bool isBoy)
	{
		int roleId = CreateCharacterConfig.Instance.GetInitialRoles()[(isBoy > false) ? 1 : 0];
		int burstEyeMaterialId = UiLoginSceneManager.Instance.GetBurstEyeMaterialId();
		UiLoginSceneManager.Instance.RemoveRoleRenderingMaterial(roleId, burstEyeMaterialId);
	}

	// Token: 0x17001033 RID: 4147
	// (get) Token: 0x0600C1E7 RID: 49639 RVA: 0x002BC538 File Offset: 0x002BA738
	public static CreateCharacterController Instance
	{
		get
		{
			return CreateCharacterController._Instance;
		}
	}

	// Token: 0x0600C1E8 RID: 49640 RVA: 0x002BC53F File Offset: 0x002BA73F
	public static CreateCharacterController GetOrCreateInstance()
	{
		if (CreateCharacterController._Instance == null)
		{
			CreateCharacterController.CreateInstance();
		}
		return CreateCharacterController._Instance;
	}

	// Token: 0x0600C1E9 RID: 49641 RVA: 0x002BC553 File Offset: 0x002BA753
	public static bool CreateInstance()
	{
		if (CreateCharacterController._Instance != null)
		{
			return true;
		}
		CreateCharacterController._Instance = new CreateCharacterController();
		return true;
	}

	// Token: 0x0600C1EA RID: 49642 RVA: 0x002BC569 File Offset: 0x002BA769
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C1EB RID: 49643 RVA: 0x002BC56B File Offset: 0x002BA76B
	public static void ResetStaticDefaultValue()
	{
		CreateCharacterController._Instance = null;
	}

	// Token: 0x0600C1EC RID: 49644 RVA: 0x002BC573 File Offset: 0x002BA773
	static CreateCharacterController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CreateCharacterController.CreateStaticDefaultValue), new Action(CreateCharacterController.ResetStaticDefaultValue));
	}

	// Token: 0x04005951 RID: 22865
	[Nullable(2)]
	private static CreateCharacterController _Instance;
}
