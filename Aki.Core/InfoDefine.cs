using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200002C RID: 44
[NullableContext(1)]
[Nullable(0)]
public static class InfoDefine
{
	// Token: 0x040000EB RID: 235
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<ESourcePlatformType, EInputControllerType> DefaultPlatformAndInputControllerMap = new Dictionary<ESourcePlatformType, EInputControllerType>
	{
		{
			ESourcePlatformType.Android,
			EInputControllerType.Touch
		},
		{
			ESourcePlatformType.IOS,
			EInputControllerType.Touch
		},
		{
			ESourcePlatformType.OpenHarmony,
			EInputControllerType.Touch
		},
		{
			ESourcePlatformType.Windows,
			EInputControllerType.Keyboard
		},
		{
			ESourcePlatformType.Mac,
			EInputControllerType.Keyboard
		},
		{
			ESourcePlatformType.Linux,
			EInputControllerType.Keyboard
		},
		{
			ESourcePlatformType.XboxOne,
			EInputControllerType.XboxOne
		},
		{
			ESourcePlatformType.PS4,
			EInputControllerType.PS4
		},
		{
			ESourcePlatformType.PS5,
			EInputControllerType.PS5
		},
		{
			ESourcePlatformType.XSX,
			EInputControllerType.XSX
		},
		{
			ESourcePlatformType.WinGDK,
			EInputControllerType.Keyboard
		}
	};

	// Token: 0x040000EC RID: 236
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EInputControllerType, EOperationType> ShowTypeAndInputControllerMap = new Dictionary<EInputControllerType, EOperationType>
	{
		{
			EInputControllerType.None,
			EOperationType.None
		},
		{
			EInputControllerType.Keyboard,
			EOperationType.Desktop
		},
		{
			EInputControllerType.XboxOne,
			EOperationType.Desktop
		},
		{
			EInputControllerType.PS4,
			EOperationType.Desktop
		},
		{
			EInputControllerType.PS5,
			EOperationType.Desktop
		},
		{
			EInputControllerType.Touch,
			EOperationType.Pad
		},
		{
			EInputControllerType.BackBone,
			EOperationType.Desktop
		},
		{
			EInputControllerType.NsPro,
			EOperationType.Desktop
		},
		{
			EInputControllerType.XSX,
			EOperationType.Desktop
		}
	};

	// Token: 0x040000ED RID: 237
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EInputControllerType, EInputControllerMainType> InputControllerMainTypeMap = new Dictionary<EInputControllerType, EInputControllerMainType>
	{
		{
			EInputControllerType.None,
			EInputControllerMainType.None
		},
		{
			EInputControllerType.Keyboard,
			EInputControllerMainType.Keyboard
		},
		{
			EInputControllerType.XboxOne,
			EInputControllerMainType.Gamepad
		},
		{
			EInputControllerType.PS4,
			EInputControllerMainType.Gamepad
		},
		{
			EInputControllerType.PS5,
			EInputControllerMainType.Gamepad
		},
		{
			EInputControllerType.Touch,
			EInputControllerMainType.Touch
		},
		{
			EInputControllerType.BackBone,
			EInputControllerMainType.Gamepad
		},
		{
			EInputControllerType.NsPro,
			EInputControllerMainType.Gamepad
		},
		{
			EInputControllerType.XSX,
			EInputControllerMainType.Gamepad
		}
	};
}
