using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02000EA5 RID: 3749
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class CreateCharacterController : UiControllerBase
{
	// Token: 0x060095F1 RID: 38385 RVA: 0x002C7478 File Offset: 0x002C5678
	public static void TriggerInputName()
	{
		EventSystem.Instance.Emit(EEventName.CreateRoleShowInputName);
	}

	// Token: 0x060095F2 RID: 38386 RVA: 0x002C748C File Offset: 0x002C568C
	public static void AddBurstEyeRenderingMaterial(bool isBoy)
	{
		int roleId = CreateCharacterConfig.Instance.GetInitialRoles()[(isBoy > false) ? 1 : 0];
		string effectId = isBoy ? "RoleMaleBurstEyeMaterialController" : "RoleFemaleBurstEyeMaterialController";
		int burstEyeMaterialId = UiLoginSceneManager.Instance.SetRoleRenderingMaterial(roleId, effectId);
		UiLoginSceneManager.Instance.SetBurstEyeMaterialId(burstEyeMaterialId);
	}

	// Token: 0x060095F3 RID: 38387 RVA: 0x002C74D8 File Offset: 0x002C56D8
	public static void RemoveBurstEyeRenderingMaterial(bool isBoy)
	{
		int roleId = CreateCharacterConfig.Instance.GetInitialRoles()[(isBoy > false) ? 1 : 0];
		int burstEyeMaterialId = UiLoginSceneManager.Instance.GetBurstEyeMaterialId();
		UiLoginSceneManager.Instance.RemoveRoleRenderingMaterial(roleId, burstEyeMaterialId);
	}

	// Token: 0x17001058 RID: 4184
	// (get) Token: 0x060095F4 RID: 38388 RVA: 0x002C7510 File Offset: 0x002C5710
	public static CreateCharacterController Instance
	{
		get
		{
			return CreateCharacterController._Instance;
		}
	}

	// Token: 0x060095F5 RID: 38389 RVA: 0x002C7517 File Offset: 0x002C5717
	public static CreateCharacterController GetOrCreateInstance()
	{
		if (CreateCharacterController._Instance == null)
		{
			CreateCharacterController.CreateInstance();
		}
		return CreateCharacterController._Instance;
	}

	// Token: 0x060095F6 RID: 38390 RVA: 0x002C752B File Offset: 0x002C572B
	public static bool CreateInstance()
	{
		if (CreateCharacterController._Instance != null)
		{
			return true;
		}
		CreateCharacterController._Instance = new CreateCharacterController();
		return true;
	}

	// Token: 0x060095F7 RID: 38391 RVA: 0x002C7541 File Offset: 0x002C5741
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060095F8 RID: 38392 RVA: 0x002C7543 File Offset: 0x002C5743
	public static void ResetStaticDefaultValue()
	{
		CreateCharacterController._Instance = null;
	}

	// Token: 0x060095F9 RID: 38393 RVA: 0x002C754B File Offset: 0x002C574B
	static CreateCharacterController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CreateCharacterController.CreateStaticDefaultValue), new Action(CreateCharacterController.ResetStaticDefaultValue));
	}

	// Token: 0x04005A20 RID: 23072
	[Nullable(2)]
	private static CreateCharacterController _Instance;
}
