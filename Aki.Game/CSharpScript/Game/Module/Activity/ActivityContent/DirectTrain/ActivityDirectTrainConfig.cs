using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain
{
	// Token: 0x0200673B RID: 26427
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityDirectTrainConfig : ConfigBase
	{
		// Token: 0x06041F63 RID: 270179 RVA: 0x0100051D File Offset: 0x00FFE71D
		public DirectTrainActivity? GetDirectTrainActivityConfById(int activityId)
		{
			return ConfigDirectTrainActivityById.GetConfig(activityId, true);
		}

		// Token: 0x06041F64 RID: 270180 RVA: 0x01000526 File Offset: 0x00FFE726
		public DirectTrainMain? GetDirectTrainMainConfByActivityId(int activityId)
		{
			return ConfigDirectTrainMainByActivityId.GetConfig(activityId, true);
		}

		// Token: 0x06041F65 RID: 270181 RVA: 0x0100052F File Offset: 0x00FFE72F
		public DirectTrainHighlight? GetDirectTrainHighlightConfById(int id)
		{
			return ConfigDirectTrainHighlightById.GetConfig(id, true);
		}

		// Token: 0x1700965A RID: 38490
		// (get) Token: 0x06041F66 RID: 270182 RVA: 0x01000538 File Offset: 0x00FFE738
		public static ActivityDirectTrainConfig Instance
		{
			get
			{
				return ActivityDirectTrainConfig._Instance;
			}
		}

		// Token: 0x06041F67 RID: 270183 RVA: 0x0100053F File Offset: 0x00FFE73F
		public static ActivityDirectTrainConfig GetOrCreateInstance()
		{
			if (ActivityDirectTrainConfig._Instance == null)
			{
				ActivityDirectTrainConfig.CreateInstance();
			}
			return ActivityDirectTrainConfig._Instance;
		}

		// Token: 0x06041F68 RID: 270184 RVA: 0x01000553 File Offset: 0x00FFE753
		public static bool CreateInstance()
		{
			if (ActivityDirectTrainConfig._Instance != null)
			{
				return true;
			}
			ActivityDirectTrainConfig._Instance = new ActivityDirectTrainConfig();
			return true;
		}

		// Token: 0x06041F69 RID: 270185 RVA: 0x01000569 File Offset: 0x00FFE769
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06041F6A RID: 270186 RVA: 0x0100056B File Offset: 0x00FFE76B
		public static void ResetStaticDefaultValue()
		{
			ActivityDirectTrainConfig._Instance = null;
		}

		// Token: 0x06041F6B RID: 270187 RVA: 0x01000573 File Offset: 0x00FFE773
		static ActivityDirectTrainConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityDirectTrainConfig.CreateStaticDefaultValue), new Action(ActivityDirectTrainConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040225E1 RID: 140769
		[Nullable(2)]
		private static ActivityDirectTrainConfig _Instance;
	}
}
