using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Menu;

namespace CSharpScript.Game.Module.KeySetting
{
	// Token: 0x0200477E RID: 18302
	[NullableContext(1)]
	[Nullable(0)]
	public static class KeySettingDefine
	{
		// Token: 0x0602DF4A RID: 188234 RVA: 0x00CDC3A4 File Offset: 0x00CDA5A4
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

		// Token: 0x04018887 RID: 100487
		[StaticVariableRuleIgnore]
		public static readonly EKeySettingExclusiveType[] menuKeySettingExclusiveTypeList = new EKeySettingExclusiveType[]
		{
			EKeySettingExclusiveType.None,
			EKeySettingExclusiveType.Motor
		};

		// Token: 0x04018888 RID: 100488
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<EKeySettingDeviceType, IKeySettingDeviceInfo> keySettingDeviceInfoRecord;
	}
}
