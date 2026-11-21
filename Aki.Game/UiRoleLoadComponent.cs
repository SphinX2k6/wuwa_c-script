using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x0200220A RID: 8714
[NullableContext(2)]
[Nullable(0)]
public class UiRoleLoadComponent : UiModelLoadComponent
{
	// Token: 0x060156F1 RID: 87793 RVA: 0x0063962B File Offset: 0x0063782B
	protected override void OnInit()
	{
		base.OnInit();
		this.UiRoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
		this.UiRoleMorphComponent = base.Owner.GetComponent<UiRoleMorphComponent>();
	}

	// Token: 0x060156F2 RID: 87794 RVA: 0x00639655 File Offset: 0x00637855
	protected override void OnEnd()
	{
		base.OnEnd();
	}

	// Token: 0x060156F3 RID: 87795 RVA: 0x00639660 File Offset: 0x00637860
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

	// Token: 0x060156F4 RID: 87796 RVA: 0x00639730 File Offset: 0x00637930
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

	// Token: 0x060156F5 RID: 87797 RVA: 0x00639798 File Offset: 0x00637998
	[NullableContext(1)]
	protected override string GetAnimClassPath()
	{
		if (this.UiRoleDataComponent.RoleSkinId <= 0)
		{
			return RoleConfig.Instance.GetRoleConfig(this.UiRoleDataComponent.RoleConfigId).Value.UiScenePerformanceABP;
		}
		return RoleSkinModel.Instance.GetRoleSkinData(this.UiRoleDataComponent.RoleSkinId).GetRoleSkinConfig().UiScenePerformanceABP;
	}

	// Token: 0x060156F6 RID: 87798 RVA: 0x006397FB File Offset: 0x006379FB
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

	// Token: 0x060156F7 RID: 87799 RVA: 0x0063980E File Offset: 0x00637A0E
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

	// Token: 0x0400B5A6 RID: 46502
	private UiRoleDataComponent UiRoleDataComponent;

	// Token: 0x0400B5A7 RID: 46503
	private UiRoleMorphComponent UiRoleMorphComponent;
}
