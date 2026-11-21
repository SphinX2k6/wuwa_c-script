using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200617F RID: 24959
	[NullableContext(1)]
	[Nullable(0)]
	public class InputActionKey
	{
		// Token: 0x0603BE04 RID: 245252 RVA: 0x01103FFC File Offset: 0x011021FC
		public void CreateUeData()
		{
			this.UeActionName = FNameUtil.GetCheckDynamicFName(this.ActionName);
			this.UeKeyName = FNameUtil.GetCheckDynamicFName(this.KeyName);
			this.UeKey = new FKey
			{
				KeyName = this.UeKeyName
			};
			this.UeInputActionKeyMapping = new FInputActionKeyMapping
			{
				ActionName = this.UeActionName,
				bShift = this.IsShift,
				bCtrl = this.IsCtrl,
				bAlt = this.IsAlt,
				bCmd = this.IsCmd,
				Key = this.UeKey
			};
		}

		// Token: 0x0603BE05 RID: 245253 RVA: 0x01104095 File Offset: 0x01102295
		public static InputActionKey New(string actionName, bool bShift, bool bCtrl, bool bAlt, bool bCmd, string keyName)
		{
			InputActionKey inputActionKey = new InputActionKey();
			inputActionKey.ActionName = actionName;
			inputActionKey.IsShift = bShift;
			inputActionKey.IsCtrl = bCtrl;
			inputActionKey.IsAlt = bAlt;
			inputActionKey.IsCmd = bCmd;
			inputActionKey.KeyName = keyName;
			inputActionKey.CreateUeData();
			return inputActionKey;
		}

		// Token: 0x0603BE06 RID: 245254 RVA: 0x011040D0 File Offset: 0x011022D0
		public static InputActionKey NewByInputActionKeyMapping(FInputActionKeyMapping inputActionKeyMapping)
		{
			InputActionKey inputActionKey = new InputActionKey();
			inputActionKey.ActionName = inputActionKeyMapping.ActionName.ToString();
			inputActionKey.IsShift = inputActionKeyMapping.bShift;
			inputActionKey.IsCtrl = inputActionKeyMapping.bCtrl;
			inputActionKey.IsAlt = inputActionKeyMapping.bAlt;
			inputActionKey.IsCmd = inputActionKeyMapping.bCmd;
			inputActionKey.KeyName = inputActionKeyMapping.Key.KeyName.ToString();
			inputActionKey.CreateUeData();
			return inputActionKey;
		}

		// Token: 0x0603BE07 RID: 245255 RVA: 0x01104154 File Offset: 0x01102354
		public static void Refresh(InputActionKey inputActionKey, string actionName, bool bShift, bool bCtrl, bool bAlt, bool bCmd, string keyName)
		{
			inputActionKey.ActionName = actionName;
			inputActionKey.IsShift = bShift;
			inputActionKey.IsCtrl = bCtrl;
			inputActionKey.IsAlt = bAlt;
			inputActionKey.IsCmd = bCmd;
			inputActionKey.KeyName = keyName;
			inputActionKey.UeActionName = FNameUtil.GetCheckDynamicFName(actionName);
			inputActionKey.UeKeyName = FNameUtil.GetCheckDynamicFName(keyName);
			inputActionKey.UeKey.KeyName = inputActionKey.UeKeyName;
			inputActionKey.UeInputActionKeyMapping.ActionName = inputActionKey.UeActionName;
			inputActionKey.UeInputActionKeyMapping.bShift = bShift;
			inputActionKey.UeInputActionKeyMapping.bCtrl = bCtrl;
			inputActionKey.UeInputActionKeyMapping.bAlt = bAlt;
			inputActionKey.UeInputActionKeyMapping.bCmd = bCmd;
			inputActionKey.UeInputActionKeyMapping.Key = inputActionKey.UeKey;
		}

		// Token: 0x0603BE08 RID: 245256 RVA: 0x0110420C File Offset: 0x0110240C
		public FInputActionKeyMapping ToUeInputActionKeyMapping()
		{
			return this.UeInputActionKeyMapping;
		}

		// Token: 0x0603BE09 RID: 245257 RVA: 0x01104214 File Offset: 0x01102414
		[NullableContext(2)]
		public InputKey GetKey()
		{
			return InputSettings.Instance.GetKey(this.KeyName);
		}

		// Token: 0x0603BE0A RID: 245258 RVA: 0x01104228 File Offset: 0x01102428
		public string GetKeyIconPath()
		{
			InputKey key = this.GetKey();
			if (key == null)
			{
				return string.Empty;
			}
			return key.GetKeyIconPath();
		}

		// Token: 0x0603BE0B RID: 245259 RVA: 0x0110424C File Offset: 0x0110244C
		public bool IsEqual(FInputActionKeyMapping inputActionKeyMapping)
		{
			return this.ActionName == inputActionKeyMapping.ActionName.ToString() && this.KeyName == inputActionKeyMapping.Key.KeyName.ToString() && this.IsAlt == inputActionKeyMapping.bAlt && this.IsCmd == inputActionKeyMapping.bCmd && this.IsCtrl == inputActionKeyMapping.bCtrl && this.IsShift == inputActionKeyMapping.bShift;
		}

		// Token: 0x0401FA86 RID: 129670
		public string ActionName = "";

		// Token: 0x0401FA87 RID: 129671
		public bool IsAlt;

		// Token: 0x0401FA88 RID: 129672
		public bool IsCmd;

		// Token: 0x0401FA89 RID: 129673
		public bool IsCtrl;

		// Token: 0x0401FA8A RID: 129674
		public bool IsShift;

		// Token: 0x0401FA8B RID: 129675
		public string KeyName = "";

		// Token: 0x0401FA8C RID: 129676
		public FName UeActionName;

		// Token: 0x0401FA8D RID: 129677
		public FName UeKeyName;

		// Token: 0x0401FA8E RID: 129678
		public FKey UeKey;

		// Token: 0x0401FA8F RID: 129679
		public FInputActionKeyMapping UeInputActionKeyMapping;
	}
}
