using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02002CB1 RID: 11441
[NullableContext(2)]
[Nullable(0)]
public class UiRoleLoadComponent : UiModelLoadComponent
{
	// Token: 0x06017E7D RID: 97917 RVA: 0x00613A9F File Offset: 0x00611C9F
	protected override void OnInit()
	{
		base.OnInit();
		this.UiRoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
		this.UiRoleMorphComponent = base.Owner.GetComponent<UiRoleMorphComponent>();
	}

	// Token: 0x06017E7E RID: 97918 RVA: 0x00613AC9 File Offset: 0x00611CC9
	protected override void OnEnd()
	{
		base.OnEnd();
	}

	// Token: 0x06017E7F RID: 97919 RVA: 0x00613AD4 File Offset: 0x00611CD4
	public unsafe void LoadModelByRoleDataId(int roleDataId, int roleSkinId, bool waitMeshStreaming = false, Action loadFinishCallBack = null)
	{
		if (roleDataId == this.UiRoleDataComponent.RoleDataId)
		{
			UiRoleDataComponent uiRoleDataComponent = this.UiRoleDataComponent;
			int? num = (uiRoleDataComponent != null) ? new int?(uiRoleDataComponent.RoleSkinId) : null;
			if (roleSkinId == num.GetValueOrDefault() & num != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "重复加载角色";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RoleDataId", roleDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RoleSkinId", roleSkinId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
		}
		this.UiRoleDataComponent.SetRoleDataId(roleDataId, roleSkinId);
		this.LoadFinishCallBack = loadFinishCallBack;
		base.LoadModel(waitMeshStreaming, null, 0);
	}

	// Token: 0x06017E80 RID: 97920 RVA: 0x00613BA4 File Offset: 0x00611DA4
	public void LoadModelByRoleConfigId(int roleConfigId, int skinId, bool waitMeshStreaming = false, Action loadFinishCallBack = null)
	{
		if (roleConfigId == this.UiRoleDataComponent.RoleConfigId)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "重复加载角色";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoleConfigId", roleConfigId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.UiRoleDataComponent.SetRoleConfigId(roleConfigId, skinId);
		this.LoadFinishCallBack = loadFinishCallBack;
		base.LoadModel(waitMeshStreaming, null, 0);
	}

	// Token: 0x06017E81 RID: 97921 RVA: 0x00613C0C File Offset: 0x00611E0C
	[NullableContext(1)]
	protected override string GetAnimClassPath()
	{
		if (this.UiRoleDataComponent.RoleSkinId <= 0)
		{
			return RoleConfig.Instance.GetRoleConfig(this.UiRoleDataComponent.RoleConfigId).Value.UiScenePerformanceABP;
		}
		return RoleSkinModel.Instance.GetRoleSkinData(this.UiRoleDataComponent.RoleSkinId).GetRoleSkinConfig().UiScenePerformanceABP;
	}

	// Token: 0x06017E82 RID: 97922 RVA: 0x00613C6F File Offset: 0x00611E6F
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	protected override List<string> GetAllMorphPathList()
	{
		UiRoleMorphComponent uiRoleMorphComponent = this.UiRoleMorphComponent;
		if (uiRoleMorphComponent == null)
		{
			return null;
		}
		return uiRoleMorphComponent.GetAllMorphPathList();
	}

	// Token: 0x06017E83 RID: 97923 RVA: 0x00613C82 File Offset: 0x00611E82
	protected override void FinishLoad()
	{
		base.FinishLoad();
		UiRoleMorphComponent uiRoleMorphComponent = this.UiRoleMorphComponent;
		if (uiRoleMorphComponent == null)
		{
			return;
		}
		uiRoleMorphComponent.PreloadMorphData();
	}

	// Token: 0x0400B23B RID: 45627
	private UiRoleDataComponent UiRoleDataComponent;

	// Token: 0x0400B23C RID: 45628
	private UiRoleMorphComponent UiRoleMorphComponent;
}
