using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001973 RID: 6515
public class VisionAssembleMainRoleHeadItem : UiPanelBase
{
	// Token: 0x0601013C RID: 65852 RVA: 0x004AF8DC File Offset: 0x004ADADC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x0601013D RID: 65853 RVA: 0x004AF936 File Offset: 0x004ADB36
	[NullableContext(2)]
	public VisionAssembleMainRoleHeadItem(UUIItem uiItem = null)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x0601013E RID: 65854 RVA: 0x004AF948 File Offset: 0x004ADB48
	public UniTask Init()
	{
		VisionAssembleMainRoleHeadItem.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<VisionAssembleMainRoleHeadItem.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0601013F RID: 65855 RVA: 0x004AF98C File Offset: 0x004ADB8C
	public void Refresh(int visionId)
	{
		int? phantomEquipOnRoleId = PhantomBattleModel.Instance.GetPhantomEquipOnRoleId(visionId);
		if (phantomEquipOnRoleId == null)
		{
			this.SetActive(false);
			return;
		}
		bool bgSprite = PhantomBattleModel.Instance.CheckPhantomIsMain(visionId);
		this.SetIconTex(phantomEquipOnRoleId.Value);
		this.SetBgSprite(bgSprite);
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(phantomEquipOnRoleId.Value);
		if (roleConfig != null)
		{
			this.SetRoleElement(roleConfig.Value);
		}
		this.SetActive(true);
	}

	// Token: 0x06010140 RID: 65856 RVA: 0x004AFA08 File Offset: 0x004ADC08
	private void SetIconTex(int roleId)
	{
		UUITexture roleHeadTexture = base.GetTexture(0);
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		if (roleDataById == null)
		{
			UUITexture roleHeadTexture5 = roleHeadTexture;
			if (roleHeadTexture5 == null)
			{
				return;
			}
			roleHeadTexture5.SetUIActive(false);
			return;
		}
		else
		{
			int roleSkinId = roleDataById.GetRoleSkinId();
			RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(roleSkinId);
			string text = (roleSkinConfig != null) ? roleSkinConfig.GetValueOrDefault().Card : null;
			if (!string.IsNullOrEmpty(text))
			{
				UUITexture roleHeadTexture2 = roleHeadTexture;
				if (roleHeadTexture2 != null)
				{
					roleHeadTexture2.SetUIActive(false);
				}
				base.SetRoleSkinIcon(text, roleHeadTexture, roleSkinId, null, delegate(bool success)
				{
					UUITexture roleHeadTexture4 = roleHeadTexture;
					if (roleHeadTexture4 == null)
					{
						return;
					}
					roleHeadTexture4.SetUIActive(success);
				});
				return;
			}
			UUITexture roleHeadTexture3 = roleHeadTexture;
			if (roleHeadTexture3 == null)
			{
				return;
			}
			roleHeadTexture3.SetUIActive(false);
			return;
		}
	}

	// Token: 0x06010141 RID: 65857 RVA: 0x004AFAD0 File Offset: 0x004ADCD0
	private void SetRoleElement(RoleInfo roleConfig)
	{
		UUITexture texture = base.GetTexture(1);
		ElementInfo? elementInfo = ElementInfoConfig.Instance.GetElementInfo(roleConfig.ElementId);
		if (elementInfo == null)
		{
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			return;
		}
		string itemTexture = elementInfo.Value.ItemTexture;
		if (string.IsNullOrEmpty(itemTexture))
		{
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			return;
		}
		base.SetTextureByPath(itemTexture, texture, null, null);
		if (texture != null)
		{
			texture.SetUIActive(true);
		}
	}

	// Token: 0x06010142 RID: 65858 RVA: 0x004AFB4C File Offset: 0x004ADD4C
	private void SetBgSprite(bool ifMain)
	{
		string resourcePath;
		if (ifMain)
		{
			resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_ItemRoverElementFrameBSel");
		}
		else
		{
			resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_ItemRoverElementFrameBNor");
		}
		this.SetSpriteByPath(resourcePath, base.GetSprite(2), false, null, null);
	}

	// Token: 0x04008EB0 RID: 36528
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x02007B8D RID: 31629
	private enum EComponent
	{
		// Token: 0x04028044 RID: 163908
		TexRoverIcon,
		// Token: 0x04028045 RID: 163909
		ElementTexture,
		// Token: 0x04028046 RID: 163910
		SprBg
	}
}
