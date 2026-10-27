using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoDevelop
{
	// Token: 0x02006457 RID: 25687
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityMotorDevelopConfig : ConfigBase
	{
		// Token: 0x060408F3 RID: 264435 RVA: 0x00FA0432 File Offset: 0x00F9E632
		public MotorDevelopActivity? GetActivityDataById(int id)
		{
			return ConfigMotorDevelopActivityByActivityId.GetConfig(id, true);
		}

		// Token: 0x060408F4 RID: 264436 RVA: 0x00FA043B File Offset: 0x00F9E63B
		public MotorDevelopTask? GetMotorDevelopTaskById(int id)
		{
			return ConfigMotorDevelopTaskByTaskId.GetConfig(id, true);
		}

		// Token: 0x17009486 RID: 38022
		// (get) Token: 0x060408F5 RID: 264437 RVA: 0x00FA0444 File Offset: 0x00F9E644
		public static ActivityMotorDevelopConfig Instance
		{
			get
			{
				return ActivityMotorDevelopConfig._Instance;
			}
		}

		// Token: 0x060408F6 RID: 264438 RVA: 0x00FA044B File Offset: 0x00F9E64B
		public static ActivityMotorDevelopConfig GetOrCreateInstance()
		{
			if (ActivityMotorDevelopConfig._Instance == null)
			{
				ActivityMotorDevelopConfig.CreateInstance();
			}
			return ActivityMotorDevelopConfig._Instance;
		}

		// Token: 0x060408F7 RID: 264439 RVA: 0x00FA045F File Offset: 0x00F9E65F
		public static bool CreateInstance()
		{
			if (ActivityMotorDevelopConfig._Instance != null)
			{
				return true;
			}
			ActivityMotorDevelopConfig._Instance = new ActivityMotorDevelopConfig();
			return true;
		}

		// Token: 0x060408F8 RID: 264440 RVA: 0x00FA0475 File Offset: 0x00F9E675
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060408F9 RID: 264441 RVA: 0x00FA0477 File Offset: 0x00F9E677
		public static void ResetStaticDefaultValue()
		{
			ActivityMotorDevelopConfig._Instance = null;
		}

		// Token: 0x060408FA RID: 264442 RVA: 0x00FA047F File Offset: 0x00F9E67F
		static ActivityMotorDevelopConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMotorDevelopConfig.CreateStaticDefaultValue), new Action(ActivityMotorDevelopConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04021928 RID: 137512
		[Nullable(2)]
		private static ActivityMotorDevelopConfig _Instance;
	}
}
