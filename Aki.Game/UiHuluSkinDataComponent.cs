using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Utils;

// Token: 0x02002C9F RID: 11423
[NullableContext(1)]
[Nullable(0)]
public class UiHuluSkinDataComponent : UiModelComponentBase
{
	// Token: 0x06017DF7 RID: 97783 RVA: 0x00611CC3 File Offset: 0x0060FEC3
	public void RefreshCurrentSkinData(int roleId)
	{
		if (RoleModel.Instance.IsMainRole(roleId))
		{
			this.SetSkinId(roleId, CalabashSkinModel.Instance.GetCurrentEquipSkinId());
			return;
		}
		this.SetSkinId(roleId, 0);
	}

	// Token: 0x06017DF8 RID: 97784 RVA: 0x00611CEC File Offset: 0x0060FEEC
	public void SetSkinId(int roleId, int skinId)
	{
		this.SkinIdInternal = skinId;
		if (this.SkinIdInternal != 0)
		{
			this.ModelIdInternal = SkinConfig.Instance.GetCalabashSkinConfig(this.SkinIdInternal).ModelId;
			return;
		}
		this.ModelIdInternal = CharacterUtils.GetHuluModelId(RoleConfig.Instance.GetRoleConfig(roleId).Value.PartyId);
	}

	// Token: 0x17002034 RID: 8244
	// (get) Token: 0x06017DF9 RID: 97785 RVA: 0x00611D4D File Offset: 0x0060FF4D
	public int ModelId
	{
		get
		{
			return this.ModelIdInternal;
		}
	}

	// Token: 0x17002035 RID: 8245
	// (get) Token: 0x06017DFA RID: 97786 RVA: 0x00611D58 File Offset: 0x0060FF58
	public int TransformId
	{
		get
		{
			if (this.SkinIdInternal != 0)
			{
				return SkinConfig.Instance.GetCalabashSkinConfig(this.SkinIdInternal).TransformId;
			}
			return this.ModelIdInternal;
		}
	}

	// Token: 0x17002036 RID: 8246
	// (get) Token: 0x06017DFB RID: 97787 RVA: 0x00611D8C File Offset: 0x0060FF8C
	public string EffectPath
	{
		get
		{
			if (this.SkinIdInternal != 0)
			{
				return SkinConfig.Instance.GetCalabashSkinConfig(this.SkinIdInternal).SwitchEffect;
			}
			return EffectUtil.GetEffectPath("CalabashSwitchEffect");
		}
	}

	// Token: 0x0400B1FB RID: 45563
	private int ModelIdInternal;

	// Token: 0x0400B1FC RID: 45564
	private int SkinIdInternal;
}
