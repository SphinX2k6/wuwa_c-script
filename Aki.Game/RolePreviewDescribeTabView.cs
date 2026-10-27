using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CA4 RID: 7332
[NullableContext(2)]
[Nullable(0)]
public class RolePreviewDescribeTabView : UiTabViewBase
{
	// Token: 0x0600DD6D RID: 56685 RVA: 0x0033C89C File Offset: 0x0033AA9C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600DD6E RID: 56686 RVA: 0x0033C9CB File Offset: 0x0033ABCB
	protected override void OnStart()
	{
		this.InitText();
		this.PlayMontageStart();
	}

	// Token: 0x0600DD6F RID: 56687 RVA: 0x0033C9D9 File Offset: 0x0033ABD9
	protected override void OnBeforeDestroy()
	{
		this.CharacterVoiceTitleText = null;
		this.CharacterVoiceNameText = null;
		this.AttributeIconTexture = null;
		this.AttributeText = null;
	}

	// Token: 0x0600DD70 RID: 56688 RVA: 0x0033C9F8 File Offset: 0x0033ABF8
	private void InitText()
	{
		RoleInstance curSelectMainRoleInstance = RoleModel.Instance.GetCurSelectMainRoleInstance();
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(curSelectMainRoleInstance.GetRoleId());
		if (roleConfig != null)
		{
			base.GetText(0).ShowTextNew(roleConfig.Value.Name);
			string weaponTypeName = WeaponConfig.Instance.GetWeaponTypeName(roleConfig.Value.WeaponType);
			base.GetText(1).SetText(weaponTypeName, true);
			base.GetText(2).ShowTextNew(roleConfig.Value.Introduction);
		}
		LguiUtil.Instance.SetLocalText(base.GetText(3), "RoleFilterWeapon", Array.Empty<object>());
		this.CharacterVoiceTitleText = base.GetText(4);
		this.CharacterVoiceNameText = base.GetText(5);
		this.AttributeIconTexture = base.GetTexture(6);
		this.AttributeText = base.GetText(7);
		this.SetCharacterVoiceInfo();
		this.SetAttributeInfo();
	}

	// Token: 0x0600DD71 RID: 56689 RVA: 0x0033CAE3 File Offset: 0x0033ACE3
	protected virtual void SetCharacterVoiceInfo()
	{
		this.CharacterVoiceTitleText.SetUIActive(false);
		this.CharacterVoiceNameText.SetUIActive(false);
	}

	// Token: 0x0600DD72 RID: 56690 RVA: 0x0033CAFD File Offset: 0x0033ACFD
	protected virtual void SetAttributeInfo()
	{
		this.AttributeIconTexture.SetUIActive(false);
		this.AttributeText.SetUIActive(false);
	}

	// Token: 0x0600DD73 RID: 56691 RVA: 0x0033CB17 File Offset: 0x0033AD17
	protected void PlayMontageStart()
	{
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, false, false);
	}

	// Token: 0x0600DD74 RID: 56692 RVA: 0x0033CB27 File Offset: 0x0033AD27
	protected override void OnBeforeShow()
	{
		this.PlayMontageStart();
	}

	// Token: 0x04006599 RID: 26009
	protected UUIText CharacterVoiceTitleText;

	// Token: 0x0400659A RID: 26010
	protected UUIText CharacterVoiceNameText;

	// Token: 0x0400659B RID: 26011
	protected UUITexture AttributeIconTexture;

	// Token: 0x0400659C RID: 26012
	protected UUIText AttributeText;

	// Token: 0x0200828B RID: 33419
	[NullableContext(0)]
	private enum ERolePreviewDescribeTabViewCom
	{
		// Token: 0x0402A974 RID: 174452
		NameText,
		// Token: 0x0402A975 RID: 174453
		WeaponTypeText,
		// Token: 0x0402A976 RID: 174454
		IntroductionText,
		// Token: 0x0402A977 RID: 174455
		WeaponTitleText,
		// Token: 0x0402A978 RID: 174456
		CharacterVoiceTitleText,
		// Token: 0x0402A979 RID: 174457
		CharacterVoiceNameText,
		// Token: 0x0402A97A RID: 174458
		AttributeIconTexture,
		// Token: 0x0402A97B RID: 174459
		AttributeText
	}
}
