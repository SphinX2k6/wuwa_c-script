using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FFF RID: 28671
	[NullableContext(1)]
	[Nullable(0)]
	public class InputAxisKey
	{
		// Token: 0x06045C57 RID: 285783 RVA: 0x01159F64 File Offset: 0x01158164
		public void CreateUeData()
		{
			this.UeAxisName = FNameUtil.GetDynamicFName(this.AxisName).Value;
			this.UeKeyName = FNameUtil.GetDynamicFName(this.KeyName).Value;
			this.UeKey = new FKey(this.UeKeyName);
			this.UeInputAxisKeyMapping = new FInputAxisKeyMapping(this.UeAxisName, this.Scale, this.UeKey);
		}

		// Token: 0x06045C58 RID: 285784 RVA: 0x01159FD1 File Offset: 0x011581D1
		public static InputAxisKey New(string axisName, float scale, string keyName)
		{
			InputAxisKey inputAxisKey = new InputAxisKey();
			inputAxisKey.AxisName = axisName;
			inputAxisKey.Scale = scale;
			inputAxisKey.KeyName = keyName;
			inputAxisKey.CreateUeData();
			return inputAxisKey;
		}

		// Token: 0x06045C59 RID: 285785 RVA: 0x01159FF4 File Offset: 0x011581F4
		public static InputAxisKey NewByInputAxisKeyMapping(FInputAxisKeyMapping inputAxisKeyMapping)
		{
			InputAxisKey inputAxisKey = new InputAxisKey();
			inputAxisKey.AxisName = inputAxisKeyMapping.AxisName.ToString();
			inputAxisKey.Scale = inputAxisKeyMapping.Scale;
			inputAxisKey.KeyName = inputAxisKeyMapping.Key.KeyName.ToString();
			inputAxisKey.CreateUeData();
			return inputAxisKey;
		}

		// Token: 0x06045C5A RID: 285786 RVA: 0x0115A054 File Offset: 0x01158254
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

		// Token: 0x06045C5B RID: 285787 RVA: 0x0115A0DD File Offset: 0x011582DD
		public FInputAxisKeyMapping ToUeInputAxisKeyMapping()
		{
			return this.UeInputAxisKeyMapping;
		}

		// Token: 0x06045C5C RID: 285788 RVA: 0x0115A0E5 File Offset: 0x011582E5
		[NullableContext(2)]
		public InputKey GetKey()
		{
			return InputSettings.Instance.GetKey(this.KeyName);
		}

		// Token: 0x06045C5D RID: 285789 RVA: 0x0115A0F8 File Offset: 0x011582F8
		public string GetKeyIconPath()
		{
			InputKey key = this.GetKey();
			if (key == null)
			{
				return "";
			}
			return key.GetKeyIconPath();
		}

		// Token: 0x06045C5E RID: 285790 RVA: 0x0115A11C File Offset: 0x0115831C
		public bool IsEqual(FInputAxisKeyMapping inputAxisKeyMapping)
		{
			return this.AxisName == inputAxisKeyMapping.AxisName.ToString() && this.KeyName == inputAxisKeyMapping.Key.KeyName.ToString() && this.Scale == inputAxisKeyMapping.Scale;
		}

		// Token: 0x040247DA RID: 149466
		public string AxisName = "";

		// Token: 0x040247DB RID: 149467
		public float Scale;

		// Token: 0x040247DC RID: 149468
		public string KeyName = "";

		// Token: 0x040247DD RID: 149469
		public FName UeAxisName;

		// Token: 0x040247DE RID: 149470
		public FName UeKeyName;

		// Token: 0x040247DF RID: 149471
		public FKey UeKey;

		// Token: 0x040247E0 RID: 149472
		public FInputAxisKeyMapping UeInputAxisKeyMapping;
	}
}
