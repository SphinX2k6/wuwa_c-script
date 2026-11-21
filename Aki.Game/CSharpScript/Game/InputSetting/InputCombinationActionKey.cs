using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006181 RID: 24961
	[NullableContext(1)]
	[Nullable(0)]
	public class InputCombinationActionKey
	{
		// Token: 0x0603BE16 RID: 245270 RVA: 0x0110454A File Offset: 0x0110274A
		public static InputCombinationActionKey New(string actionName, string mainKeyName, string secondaryKeyName)
		{
			return new InputCombinationActionKey
			{
				ActionName = actionName,
				MainKeyName = mainKeyName,
				SecondaryKeyName = secondaryKeyName
			};
		}

		// Token: 0x0603BE17 RID: 245271 RVA: 0x01104566 File Offset: 0x01102766
		[NullableContext(2)]
		public InputKey GetMainKey()
		{
			return InputSettings.Instance.GetKey(this.MainKeyName);
		}

		// Token: 0x0603BE18 RID: 245272 RVA: 0x01104578 File Offset: 0x01102778
		[NullableContext(2)]
		public InputKey GetSecondaryKey()
		{
			return InputSettings.Instance.GetKey(this.SecondaryKeyName);
		}

		// Token: 0x0603BE19 RID: 245273 RVA: 0x0110458C File Offset: 0x0110278C
		public FInputActionKeyMapping MainKeyToUeInputActionKeyMapping()
		{
			FName value = FNameUtil.GetDynamicFName(this.ActionName).Value;
			FName value2 = FNameUtil.GetDynamicFName(this.MainKeyName).Value;
			FKey key = new FKey
			{
				KeyName = value2
			};
			return new FInputActionKeyMapping
			{
				ActionName = value,
				Key = key
			};
		}

		// Token: 0x0603BE1A RID: 245274 RVA: 0x011045E4 File Offset: 0x011027E4
		public FInputActionKeyMapping SecondaryKeyToUeInputActionKeyMapping()
		{
			FName value = FNameUtil.GetDynamicFName(this.ActionName).Value;
			FName value2 = FNameUtil.GetDynamicFName(this.SecondaryKeyName).Value;
			FKey key = new FKey
			{
				KeyName = value2
			};
			return new FInputActionKeyMapping
			{
				ActionName = value,
				Key = key
			};
		}

		// Token: 0x0401FA97 RID: 129687
		public string ActionName = "";

		// Token: 0x0401FA98 RID: 129688
		public string MainKeyName = "";

		// Token: 0x0401FA99 RID: 129689
		public string SecondaryKeyName = "";
	}
}
