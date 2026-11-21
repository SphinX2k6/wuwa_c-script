using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001163 RID: 4451
[NullableContext(2)]
[Nullable(0)]
public class RolePreviewDescribeTabView : UiTabViewBase
{
	// Token: 0x0600B183 RID: 45443 RVA: 0x00347CE8 File Offset: 0x00345EE8
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

	// Token: 0x0600B184 RID: 45444 RVA: 0x00347E17 File Offset: 0x00346017
	protected override void OnStart()
	{
		this.InitText();
		this.PlayMontageStart();
	}

	// Token: 0x0600B185 RID: 45445 RVA: 0x00347E25 File Offset: 0x00346025
	protected override void OnBeforeDestroy()
	{
		this.CharacterVoiceTitleText = null;
		this.CharacterVoiceNameText = null;
		this.AttributeIconTexture = null;
		this.AttributeText = null;
	}

	// Token: 0x0600B186 RID: 45446 RVA: 0x00347E44 File Offset: 0x00346044
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

	// Token: 0x0600B187 RID: 45447 RVA: 0x00347F2F File Offset: 0x0034612F
	protected virtual void SetCharacterVoiceInfo()
	{
		this.CharacterVoiceTitleText.SetUIActive(false);
		this.CharacterVoiceNameText.SetUIActive(false);
	}

	// Token: 0x0600B188 RID: 45448 RVA: 0x00347F49 File Offset: 0x00346149
	protected virtual void SetAttributeInfo()
	{
		this.AttributeIconTexture.SetUIActive(false);
		this.AttributeText.SetUIActive(false);
	}

	// Token: 0x0600B189 RID: 45449 RVA: 0x00347F63 File Offset: 0x00346163
	protected void PlayMontageStart()
	{
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, false, false);
	}

	// Token: 0x0600B18A RID: 45450 RVA: 0x00347F73 File Offset: 0x00346173
	protected override void OnBeforeShow()
	{
		this.PlayMontageStart();
	}

	// Token: 0x0400666A RID: 26218
	protected UUIText CharacterVoiceTitleText;

	// Token: 0x0400666B RID: 26219
	protected UUIText CharacterVoiceNameText;

	// Token: 0x0400666C RID: 26220
	protected UUITexture AttributeIconTexture;

	// Token: 0x0400666D RID: 26221
	protected UUIText AttributeText;

	// Token: 0x02007412 RID: 29714
	[NullableContext(0)]
	private enum ERolePreviewDescribeTabViewCom
	{
		// Token: 0x04025C92 RID: 154770
		NameText,
		// Token: 0x04025C93 RID: 154771
		WeaponTypeText,
		// Token: 0x04025C94 RID: 154772
		IntroductionText,
		// Token: 0x04025C95 RID: 154773
		WeaponTitleText,
		// Token: 0x04025C96 RID: 154774
		CharacterVoiceTitleText,
		// Token: 0x04025C97 RID: 154775
		CharacterVoiceNameText,
		// Token: 0x04025C98 RID: 154776
		AttributeIconTexture,
		// Token: 0x04025C99 RID: 154777
		AttributeText
	}
}
