using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006180 RID: 24960
	[NullableContext(1)]
	[Nullable(0)]
	public class InputAxisKey
	{
		// Token: 0x0603BE0D RID: 245261 RVA: 0x011042F8 File Offset: 0x011024F8
		public void CreateUeData()
		{
			this.UeAxisName = FNameUtil.GetDynamicFName(this.AxisName).Value;
			this.UeKeyName = FNameUtil.GetDynamicFName(this.KeyName).Value;
			this.UeKey = new FKey
			{
				KeyName = this.UeKeyName
			};
			this.UeInputAxisKeyMapping = new FInputAxisKeyMapping
			{
				AxisName = this.UeAxisName,
				Scale = this.Scale,
				Key = this.UeKey
			};
		}

		// Token: 0x0603BE0E RID: 245262 RVA: 0x0110437D File Offset: 0x0110257D
		public static InputAxisKey New(string axisName, float scale, string keyName)
		{
			InputAxisKey inputAxisKey = new InputAxisKey();
			inputAxisKey.AxisName = axisName;
			inputAxisKey.Scale = scale;
			inputAxisKey.KeyName = keyName;
			inputAxisKey.CreateUeData();
			return inputAxisKey;
		}

		// Token: 0x0603BE0F RID: 245263 RVA: 0x011043A0 File Offset: 0x011025A0
		public static InputAxisKey NewByInputAxisKeyMapping(FInputAxisKeyMapping inputAxisKeyMapping)
		{
			InputAxisKey inputAxisKey = new InputAxisKey();
			inputAxisKey.AxisName = inputAxisKeyMapping.AxisName.ToString();
			inputAxisKey.Scale = inputAxisKeyMapping.Scale;
			inputAxisKey.KeyName = inputAxisKeyMapping.Key.KeyName.ToString();
			inputAxisKey.CreateUeData();
			return inputAxisKey;
		}

		// Token: 0x0603BE10 RID: 245264 RVA: 0x01104400 File Offset: 0x01102600
		public static void Refresh(InputAxisKey inputAxisKey, string axisName, float scale, string keyName)
		{
			inputAxisKey.AxisName = axisName;
			inputAxisKey.Scale = scale;
			inputAxisKey.KeyName = keyName;
			inputAxisKey.UeAxisName = FNameUtil.GetDynamicFName(axisName).Value;
			inputAxisKey.UeKeyName = FNameUtil.GetDynamicFName(keyName).Value;
			inputAxisKey.UeKey.KeyName = inputAxisKey.UeKeyName;
			inputAxisKey.UeInputAxisKeyMapping.AxisName = inputAxisKey.UeAxisName;
			inputAxisKey.UeInputAxisKeyMapping.Scale = scale;
			inputAxisKey.UeInputAxisKeyMapping.Key = inputAxisKey.UeKey;
		}

		// Token: 0x0603BE11 RID: 245265 RVA: 0x01104489 File Offset: 0x01102689
		public FInputAxisKeyMapping ToUeInputAxisKeyMapping()
		{
			return this.UeInputAxisKeyMapping;
		}

		// Token: 0x0603BE12 RID: 245266 RVA: 0x01104491 File Offset: 0x01102691
		[NullableContext(2)]
		public InputKey GetKey()
		{
			return InputSettings.Instance.GetKey(this.KeyName);
		}

		// Token: 0x0603BE13 RID: 245267 RVA: 0x011044A4 File Offset: 0x011026A4
		public string GetKeyIconPath()
		{
			InputKey key = this.GetKey();
			if (key == null)
			{
				return "";
			}
			return key.GetKeyIconPath();
		}

		// Token: 0x0603BE14 RID: 245268 RVA: 0x011044C8 File Offset: 0x011026C8
		public bool IsEqual(FInputAxisKeyMapping inputAxisKeyMapping)
		{
			return this.AxisName == inputAxisKeyMapping.AxisName.ToString() && this.KeyName == inputAxisKeyMapping.Key.KeyName.ToString() && this.Scale == inputAxisKeyMapping.Scale;
		}

		// Token: 0x0401FA90 RID: 129680
		public string AxisName = "";

		// Token: 0x0401FA91 RID: 129681
		public float Scale;

		// Token: 0x0401FA92 RID: 129682
		public string KeyName = "";

		// Token: 0x0401FA93 RID: 129683
		public FName UeAxisName;

		// Token: 0x0401FA94 RID: 129684
		public FName UeKeyName;

		// Token: 0x0401FA95 RID: 129685
		public FKey UeKey;

		// Token: 0x0401FA96 RID: 129686
		public FInputAxisKeyMapping UeInputAxisKeyMapping;
	}
}
