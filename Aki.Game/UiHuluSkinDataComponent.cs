using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Utils;

// Token: 0x020021F8 RID: 8696
[NullableContext(1)]
[Nullable(0)]
public class UiHuluSkinDataComponent : UiModelComponentBase
{
	// Token: 0x0601566B RID: 87659 RVA: 0x00637847 File Offset: 0x00635A47
	public void RefreshCurrentSkinData(int roleId)
	{
		if (RoleModel.Instance.IsMainRole(roleId))
		{
			this.SetSkinId(roleId, CalabashSkinModel.Instance.GetCurrentEquipSkinId());
			return;
		}
		this.SetSkinId(roleId, 0);
	}

	// Token: 0x0601566C RID: 87660 RVA: 0x00637870 File Offset: 0x00635A70
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

	// Token: 0x17002085 RID: 8325
	// (get) Token: 0x0601566D RID: 87661 RVA: 0x006378D1 File Offset: 0x00635AD1
	public int ModelId
	{
		get
		{
			return this.ModelIdInternal;
		}
	}

	// Token: 0x17002086 RID: 8326
	// (get) Token: 0x0601566E RID: 87662 RVA: 0x006378DC File Offset: 0x00635ADC
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

	// Token: 0x17002087 RID: 8327
	// (get) Token: 0x0601566F RID: 87663 RVA: 0x00637910 File Offset: 0x00635B10
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

	// Token: 0x0400B566 RID: 46438
	private int ModelIdInternal;

	// Token: 0x0400B567 RID: 46439
	private int SkinIdInternal;
}
