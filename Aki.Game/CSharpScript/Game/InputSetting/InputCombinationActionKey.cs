using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007000 RID: 28672
	[NullableContext(1)]
	[Nullable(0)]
	public class InputCombinationActionKey
	{
		// Token: 0x06045C60 RID: 285792 RVA: 0x0115A19E File Offset: 0x0115839E
		public static InputCombinationActionKey New(string actionName, string mainKeyName, string secondaryKeyName)
		{
			return new InputCombinationActionKey
			{
				ActionName = actionName,
				MainKeyName = mainKeyName,
				SecondaryKeyName = secondaryKeyName
			};
		}

		// Token: 0x06045C61 RID: 285793 RVA: 0x0115A1BA File Offset: 0x011583BA
		[NullableContext(2)]
		public InputKey GetMainKey()
		{
			return InputSettings.Instance.GetKey(this.MainKeyName);
		}

		// Token: 0x06045C62 RID: 285794 RVA: 0x0115A1CC File Offset: 0x011583CC
		[NullableContext(2)]
		public InputKey GetSecondaryKey()
		{
			return InputSettings.Instance.GetKey(this.SecondaryKeyName);
		}

		// Token: 0x06045C63 RID: 285795 RVA: 0x0115A1E0 File Offset: 0x011583E0
		public FInputActionKeyMapping MainKeyToUeInputActionKeyMapping()
		{
			FName value = FNameUtil.GetDynamicFName(this.ActionName).Value;
			FKey key = new FKey(FNameUtil.GetDynamicFName(this.MainKeyName).Value);
			return new FInputActionKeyMapping(value, false, false, false, false, key);
		}

		// Token: 0x06045C64 RID: 285796 RVA: 0x0115A224 File Offset: 0x01158424
		public FInputActionKeyMapping SecondaryKeyToUeInputActionKeyMapping()
		{
			FName value = FNameUtil.GetDynamicFName(this.ActionName).Value;
			FKey key = new FKey(FNameUtil.GetDynamicFName(this.SecondaryKeyName).Value);
			return new FInputActionKeyMapping(value, false, false, false, false, key);
		}

		// Token: 0x040247E1 RID: 149473
		public string ActionName = "";

		// Token: 0x040247E2 RID: 149474
		public string MainKeyName = "";

		// Token: 0x040247E3 RID: 149475
		public string SecondaryKeyName = "";
	}
}
