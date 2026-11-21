using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000250 RID: 592
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ConditionConfig : ConfigBase
{
	// Token: 0x06002485 RID: 9349 RVA: 0x000E1450 File Offset: 0x000DF650
	public ConditionGroup? GetConditionGroupConfig(int conditionGroupId)
	{
		ConditionGroup? config = ConfigConditionGroupById.GetConfig(conditionGroupId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InstanceDungeon;
			ELogAuthor author = ELogAuthor.TL;
			string message = "获取条件组配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("conditionGroupId", conditionGroupId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new ConditionGroup?(config.Value);
	}

	// Token: 0x06002486 RID: 9350 RVA: 0x000E14B0 File Offset: 0x000DF6B0
	public Condition? GetConditionConfig(int conditionId)
	{
		Condition? config = ConfigConditionById.GetConfig(conditionId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InstanceDungeon;
			ELogAuthor author = ELogAuthor.TL;
			string message = "获取条件配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("conditionId", conditionId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new Condition?(config.Value);
	}

	// Token: 0x06002487 RID: 9351 RVA: 0x000E1510 File Offset: 0x000DF710
	public Condition? GetConditionConfigByType(int conditionGroupId, string type)
	{
		ConditionGroup? conditionGroupConfig = this.GetConditionGroupConfig(conditionGroupId);
		if (conditionGroupConfig != null)
		{
			foreach (int conditionId in conditionGroupConfig.Value.GroupId())
			{
				Condition? conditionConfig = this.GetConditionConfig(conditionId);
				if (type == ((conditionConfig != null) ? conditionConfig.GetValueOrDefault().Type : null))
				{
					return conditionConfig;
				}
			}
		}
		return null;
	}

	// Token: 0x06002488 RID: 9352 RVA: 0x000E158C File Offset: 0x000DF78C
	public int[] GetGroupConditionIds(int conditionGroupId)
	{
		ConditionGroup? conditionGroupConfig = this.GetConditionGroupConfig(conditionGroupId);
		if (conditionGroupConfig == null)
		{
			return new int[0];
		}
		return conditionGroupConfig.Value.GroupId();
	}

	// Token: 0x170005B5 RID: 1461
	// (get) Token: 0x06002489 RID: 9353 RVA: 0x000E15C0 File Offset: 0x000DF7C0
	public static ConditionConfig Instance
	{
		get
		{
			return ConditionConfig._Instance;
		}
	}

	// Token: 0x0600248A RID: 9354 RVA: 0x000E15C7 File Offset: 0x000DF7C7
	public static ConditionConfig GetOrCreateInstance()
	{
		if (ConditionConfig._Instance == null)
		{
			ConditionConfig.CreateInstance();
		}
		return ConditionConfig._Instance;
	}

	// Token: 0x0600248B RID: 9355 RVA: 0x000E15DB File Offset: 0x000DF7DB
	public static bool CreateInstance()
	{
		if (ConditionConfig._Instance != null)
		{
			return true;
		}
		ConditionConfig._Instance = new ConditionConfig();
		return true;
	}

	// Token: 0x0600248C RID: 9356 RVA: 0x000E15F1 File Offset: 0x000DF7F1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600248D RID: 9357 RVA: 0x000E15F3 File Offset: 0x000DF7F3
	public static void ResetStaticDefaultValue()
	{
		ConditionConfig._Instance = null;
	}

	// Token: 0x0600248E RID: 9358 RVA: 0x000E15FB File Offset: 0x000DF7FB
	static ConditionConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ConditionConfig.CreateStaticDefaultValue), new Action(ConditionConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04001871 RID: 6257
	[Nullable(2)]
	private static ConditionConfig _Instance;
}
