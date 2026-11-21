using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain
{
	// Token: 0x0200568B RID: 22155
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityDirectTrainConfig : ConfigBase
	{
		// Token: 0x06036AAF RID: 223919 RVA: 0x00F418CD File Offset: 0x00F3FACD
		public DirectTrainActivity? GetDirectTrainActivityConfById(int activityId)
		{
			return ConfigDirectTrainActivityById.GetConfig(activityId, true);
		}

		// Token: 0x06036AB0 RID: 223920 RVA: 0x00F418D6 File Offset: 0x00F3FAD6
		public DirectTrainMain? GetDirectTrainMainConfByActivityId(int activityId)
		{
			return ConfigDirectTrainMainByActivityId.GetConfig(activityId, true);
		}

		// Token: 0x06036AB1 RID: 223921 RVA: 0x00F418DF File Offset: 0x00F3FADF
		public DirectTrainHighlight? GetDirectTrainHighlightConfById(int id)
		{
			return ConfigDirectTrainHighlightById.GetConfig(id, true);
		}

		// Token: 0x17006999 RID: 27033
		// (get) Token: 0x06036AB2 RID: 223922 RVA: 0x00F418E8 File Offset: 0x00F3FAE8
		public static ActivityDirectTrainConfig Instance
		{
			get
			{
				return ActivityDirectTrainConfig._Instance;
			}
		}

		// Token: 0x06036AB3 RID: 223923 RVA: 0x00F418EF File Offset: 0x00F3FAEF
		public static ActivityDirectTrainConfig GetOrCreateInstance()
		{
			if (ActivityDirectTrainConfig._Instance == null)
			{
				ActivityDirectTrainConfig.CreateInstance();
			}
			return ActivityDirectTrainConfig._Instance;
		}

		// Token: 0x06036AB4 RID: 223924 RVA: 0x00F41903 File Offset: 0x00F3FB03
		public static bool CreateInstance()
		{
			if (ActivityDirectTrainConfig._Instance != null)
			{
				return true;
			}
			ActivityDirectTrainConfig._Instance = new ActivityDirectTrainConfig();
			return true;
		}

		// Token: 0x06036AB5 RID: 223925 RVA: 0x00F41919 File Offset: 0x00F3FB19
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036AB6 RID: 223926 RVA: 0x00F4191B File Offset: 0x00F3FB1B
		public static void ResetStaticDefaultValue()
		{
			ActivityDirectTrainConfig._Instance = null;
		}

		// Token: 0x06036AB7 RID: 223927 RVA: 0x00F41923 File Offset: 0x00F3FB23
		static ActivityDirectTrainConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityDirectTrainConfig.CreateStaticDefaultValue), new Action(ActivityDirectTrainConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401CE3A RID: 118330
		[Nullable(2)]
		private static ActivityDirectTrainConfig _Instance;
	}
}
