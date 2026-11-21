using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.ActivityCondition
{
	// Token: 0x02005A7E RID: 23166
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityConditionConfig : ConfigBase
	{
		// Token: 0x060391CE RID: 233934 RVA: 0x00FFF698 File Offset: 0x00FFD898
		public ActivityCondition? GetConditionConfig(int conditionId)
		{
			ActivityCondition? config = ConfigActivityConditionById.GetConfig(conditionId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityCondition;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[ActivityCondition] 获取条件配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("conditionId", conditionId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x060391CF RID: 233935 RVA: 0x00FFF6F0 File Offset: 0x00FFD8F0
		public ActivityConditionGroup? GetConditionGroupConfig(int groupId)
		{
			ActivityConditionGroup? config = ConfigActivityConditionGroupById.GetConfig(groupId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityCondition;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[ActivityCondition] 获取条件组配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("groupId", groupId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x17006CC8 RID: 27848
		// (get) Token: 0x060391D0 RID: 233936 RVA: 0x00FFF745 File Offset: 0x00FFD945
		public static ActivityConditionConfig Instance
		{
			get
			{
				return ActivityConditionConfig._Instance;
			}
		}

		// Token: 0x060391D1 RID: 233937 RVA: 0x00FFF74C File Offset: 0x00FFD94C
		public static ActivityConditionConfig GetOrCreateInstance()
		{
			if (ActivityConditionConfig._Instance == null)
			{
				ActivityConditionConfig.CreateInstance();
			}
			return ActivityConditionConfig._Instance;
		}

		// Token: 0x060391D2 RID: 233938 RVA: 0x00FFF760 File Offset: 0x00FFD960
		public static bool CreateInstance()
		{
			if (ActivityConditionConfig._Instance != null)
			{
				return true;
			}
			ActivityConditionConfig._Instance = new ActivityConditionConfig();
			return true;
		}

		// Token: 0x060391D3 RID: 233939 RVA: 0x00FFF776 File Offset: 0x00FFD976
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060391D4 RID: 233940 RVA: 0x00FFF778 File Offset: 0x00FFD978
		public static void ResetStaticDefaultValue()
		{
			ActivityConditionConfig._Instance = null;
		}

		// Token: 0x060391D5 RID: 233941 RVA: 0x00FFF780 File Offset: 0x00FFD980
		static ActivityConditionConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityConditionConfig.CreateStaticDefaultValue), new Action(ActivityConditionConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401E0BC RID: 123068
		[Nullable(2)]
		private static ActivityConditionConfig _Instance;
	}
}
