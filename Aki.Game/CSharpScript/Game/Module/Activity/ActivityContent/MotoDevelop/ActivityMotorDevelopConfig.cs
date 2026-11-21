using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoDevelop
{
	// Token: 0x020053D5 RID: 21461
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityMotorDevelopConfig : ConfigBase
	{
		// Token: 0x060355B4 RID: 218548 RVA: 0x00EE73AE File Offset: 0x00EE55AE
		public MotorDevelopActivity? GetActivityDataById(int id)
		{
			return ConfigMotorDevelopActivityByActivityId.GetConfig(id, true);
		}

		// Token: 0x060355B5 RID: 218549 RVA: 0x00EE73B7 File Offset: 0x00EE55B7
		public MotorDevelopTask? GetMotorDevelopTaskById(int id)
		{
			return ConfigMotorDevelopTaskByTaskId.GetConfig(id, true);
		}

		// Token: 0x170067E8 RID: 26600
		// (get) Token: 0x060355B6 RID: 218550 RVA: 0x00EE73C0 File Offset: 0x00EE55C0
		public static ActivityMotorDevelopConfig Instance
		{
			get
			{
				return ActivityMotorDevelopConfig._Instance;
			}
		}

		// Token: 0x060355B7 RID: 218551 RVA: 0x00EE73C7 File Offset: 0x00EE55C7
		public static ActivityMotorDevelopConfig GetOrCreateInstance()
		{
			if (ActivityMotorDevelopConfig._Instance == null)
			{
				ActivityMotorDevelopConfig.CreateInstance();
			}
			return ActivityMotorDevelopConfig._Instance;
		}

		// Token: 0x060355B8 RID: 218552 RVA: 0x00EE73DB File Offset: 0x00EE55DB
		public static bool CreateInstance()
		{
			if (ActivityMotorDevelopConfig._Instance != null)
			{
				return true;
			}
			ActivityMotorDevelopConfig._Instance = new ActivityMotorDevelopConfig();
			return true;
		}

		// Token: 0x060355B9 RID: 218553 RVA: 0x00EE73F1 File Offset: 0x00EE55F1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060355BA RID: 218554 RVA: 0x00EE73F3 File Offset: 0x00EE55F3
		public static void ResetStaticDefaultValue()
		{
			ActivityMotorDevelopConfig._Instance = null;
		}

		// Token: 0x060355BB RID: 218555 RVA: 0x00EE73FB File Offset: 0x00EE55FB
		static ActivityMotorDevelopConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMotorDevelopConfig.CreateStaticDefaultValue), new Action(ActivityMotorDevelopConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401C257 RID: 115287
		[Nullable(2)]
		private static ActivityMotorDevelopConfig _Instance;
	}
}
