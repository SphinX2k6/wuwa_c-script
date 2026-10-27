using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FFE RID: 28670
	[NullableContext(1)]
	[Nullable(0)]
	public class InputActionKey
	{
		// Token: 0x06045C4E RID: 285774 RVA: 0x01159C94 File Offset: 0x01157E94
		public void CreateUeData()
		{
			this.UeActionName = FNameUtil.GetCheckDynamicFName(this.ActionName);
			this.UeKeyName = FNameUtil.GetCheckDynamicFName(this.KeyName);
			this.UeKey = new FKey(this.UeKeyName);
			this.UeInputActionKeyMapping = new FInputActionKeyMapping(this.UeActionName, this.IsShift, this.IsCtrl, this.IsAlt, this.IsCmd, this.UeKey);
		}

		// Token: 0x06045C4F RID: 285775 RVA: 0x01159D03 File Offset: 0x01157F03
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

		// Token: 0x06045C50 RID: 285776 RVA: 0x01159D3C File Offset: 0x01157F3C
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

		// Token: 0x06045C51 RID: 285777 RVA: 0x01159DC0 File Offset: 0x01157FC0
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

		// Token: 0x06045C52 RID: 285778 RVA: 0x01159E78 File Offset: 0x01158078
		public FInputActionKeyMapping ToUeInputActionKeyMapping()
		{
			return this.UeInputActionKeyMapping;
		}

		// Token: 0x06045C53 RID: 285779 RVA: 0x01159E80 File Offset: 0x01158080
		[NullableContext(2)]
		public InputKey GetKey()
		{
			return InputSettings.Instance.GetKey(this.KeyName);
		}

		// Token: 0x06045C54 RID: 285780 RVA: 0x01159E94 File Offset: 0x01158094
		public string GetKeyIconPath()
		{
			InputKey key = this.GetKey();
			if (key == null)
			{
				return string.Empty;
			}
			return key.GetKeyIconPath();
		}

		// Token: 0x06045C55 RID: 285781 RVA: 0x01159EB8 File Offset: 0x011580B8
		public bool IsEqual(FInputActionKeyMapping inputActionKeyMapping)
		{
			return this.ActionName == inputActionKeyMapping.ActionName.ToString() && this.KeyName == inputActionKeyMapping.Key.KeyName.ToString() && this.IsAlt == inputActionKeyMapping.bAlt && this.IsCmd == inputActionKeyMapping.bCmd && this.IsCtrl == inputActionKeyMapping.bCtrl && this.IsShift == inputActionKeyMapping.bShift;
		}

		// Token: 0x040247D0 RID: 149456
		public string ActionName = "";

		// Token: 0x040247D1 RID: 149457
		public bool IsAlt;

		// Token: 0x040247D2 RID: 149458
		public bool IsCmd;

		// Token: 0x040247D3 RID: 149459
		public bool IsCtrl;

		// Token: 0x040247D4 RID: 149460
		public bool IsShift;

		// Token: 0x040247D5 RID: 149461
		public string KeyName = "";

		// Token: 0x040247D6 RID: 149462
		public FName UeActionName;

		// Token: 0x040247D7 RID: 149463
		public FName UeKeyName;

		// Token: 0x040247D8 RID: 149464
		public FKey UeKey;

		// Token: 0x040247D9 RID: 149465
		public FInputActionKeyMapping UeInputActionKeyMapping;
	}
}
