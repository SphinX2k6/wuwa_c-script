using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Menu;

namespace CSharpScript.Game.Module.KeySetting
{
	// Token: 0x020057A7 RID: 22439
	[NullableContext(1)]
	[Nullable(0)]
	public static class KeySettingDefine
	{
		// Token: 0x0603903A RID: 233530 RVA: 0x00D8D5E8 File Offset: 0x00D8B7E8
		// Note: this type is marked as 'beforefieldinit'.
		static KeySettingDefine()
		{
			Dictionary<EKeySettingDeviceType, IKeySettingDeviceInfo> dictionary = new Dictionary<EKeySettingDeviceType, IKeySettingDeviceInfo>();
			dictionary[EKeySettingDeviceType.None] = new KeySettingDeviceInfoClass
			{
				DeviceType = EKeySettingDeviceType.None,
				NameTextId = ""
			};
			dictionary[EKeySettingDeviceType.Keyboard] = new KeySettingDeviceInfoClass
			{
				DeviceType = EKeySettingDeviceType.Keyboard,
				NameTextId = "Text_KeyBoard_Text"
			};
			dictionary[EKeySettingDeviceType.Gamepad] = new KeySettingDeviceInfoClass
			{
				DeviceType = EKeySettingDeviceType.Gamepad,
				NameTextId = "Text_Handle_Text"
			};
			KeySettingDefine.keySettingDeviceInfoRecord = dictionary;
		}

		// Token: 0x0401DDF1 RID: 122353
		[StaticVariableRuleIgnore]
		public static readonly EKeySettingExclusiveType[] menuKeySettingExclusiveTypeList = new EKeySettingExclusiveType[]
		{
			EKeySettingExclusiveType.None,
			EKeySettingExclusiveType.Motor
		};

		// Token: 0x0401DDF2 RID: 122354
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<EKeySettingDeviceType, IKeySettingDeviceInfo> keySettingDeviceInfoRecord;
	}
}
