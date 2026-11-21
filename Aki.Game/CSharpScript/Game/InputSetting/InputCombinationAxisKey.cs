using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006182 RID: 24962
	[NullableContext(1)]
	[Nullable(0)]
	public class InputCombinationAxisKey
	{
		// Token: 0x0603BE1C RID: 245276 RVA: 0x01104662 File Offset: 0x01102862
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

		// Token: 0x0603BE1D RID: 245277 RVA: 0x01104685 File Offset: 0x01102885
		[NullableContext(2)]
		public InputKey GetMainKey()
		{
			return InputSettings.Instance.GetKey(this.MainKeyName);
		}

		// Token: 0x0603BE1E RID: 245278 RVA: 0x01104697 File Offset: 0x01102897
		[NullableContext(2)]
		public InputKey GetSecondaryKey()
		{
			return InputSettings.Instance.GetKey(this.SecondaryKeyName);
		}

		// Token: 0x0603BE1F RID: 245279 RVA: 0x011046AC File Offset: 0x011028AC
		public FInputActionKeyMapping MainKeyToUeInputActionKeyMapping()
		{
			FName value = FNameUtil.GetDynamicFName(this.AxisName).Value;
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

		// Token: 0x0603BE20 RID: 245280 RVA: 0x01104704 File Offset: 0x01102904
		public FInputAxisKeyMapping SecondaryKeyToUeInputActionKeyMapping()
		{
			FName value = FNameUtil.GetDynamicFName(this.AxisName).Value;
			FName value2 = FNameUtil.GetDynamicFName(this.SecondaryKeyName).Value;
			FKey key = new FKey
			{
				KeyName = value2
			};
			return new FInputAxisKeyMapping
			{
				AxisName = value,
				Scale = this.Scale,
				Key = key
			};
		}

		// Token: 0x0401FA9A RID: 129690
		public string AxisName = "";

		// Token: 0x0401FA9B RID: 129691
		public string MainKeyName = "";

		// Token: 0x0401FA9C RID: 129692
		public string SecondaryKeyName = "";

		// Token: 0x0401FA9D RID: 129693
		public float Scale;
	}
}
