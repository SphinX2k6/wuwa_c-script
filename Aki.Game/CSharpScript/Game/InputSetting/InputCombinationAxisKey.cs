using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007001 RID: 28673
	[NullableContext(1)]
	[Nullable(0)]
	public class InputCombinationAxisKey
	{
		// Token: 0x06045C66 RID: 285798 RVA: 0x0115A290 File Offset: 0x01158490
		public static InputCombinationAxisKey New(string axisName, string mainKeyName, string secondaryKeyName, float scale)
		{
			return new InputCombinationAxisKey
			{
				AxisName = axisName,
				MainKeyName = mainKeyName,
				SecondaryKeyName = secondaryKeyName,
				Scale = scale
			};
		}

		// Token: 0x06045C67 RID: 285799 RVA: 0x0115A2B3 File Offset: 0x011584B3
		[NullableContext(2)]
		public InputKey GetMainKey()
		{
			return InputSettings.Instance.GetKey(this.MainKeyName);
		}

		// Token: 0x06045C68 RID: 285800 RVA: 0x0115A2C5 File Offset: 0x011584C5
		[NullableContext(2)]
		public InputKey GetSecondaryKey()
		{
			return InputSettings.Instance.GetKey(this.SecondaryKeyName);
		}

		// Token: 0x06045C69 RID: 285801 RVA: 0x0115A2D8 File Offset: 0x011584D8
		public FInputActionKeyMapping MainKeyToUeInputActionKeyMapping()
		{
			FName value = FNameUtil.GetDynamicFName(this.AxisName).Value;
			FKey key = new FKey(FNameUtil.GetDynamicFName(this.MainKeyName).Value);
			return new FInputActionKeyMapping(value, false, false, false, false, key);
		}

		// Token: 0x06045C6A RID: 285802 RVA: 0x0115A31C File Offset: 0x0115851C
		public FInputAxisKeyMapping SecondaryKeyToUeInputActionKeyMapping()
		{
			FName value = FNameUtil.GetDynamicFName(this.AxisName).Value;
			FKey key = new FKey(FNameUtil.GetDynamicFName(this.SecondaryKeyName).Value);
			return new FInputAxisKeyMapping(value, this.Scale, key);
		}

		// Token: 0x040247E4 RID: 149476
		public string AxisName = "";

		// Token: 0x040247E5 RID: 149477
		public string MainKeyName = "";

		// Token: 0x040247E6 RID: 149478
		public string SecondaryKeyName = "";

		// Token: 0x040247E7 RID: 149479
		public float Scale;
	}
}
