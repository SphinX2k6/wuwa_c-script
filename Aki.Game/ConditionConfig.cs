using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200024C RID: 588
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ConditionConfig : ConfigBase
{
	// Token: 0x060023CD RID: 9165 RVA: 0x000DAF08 File Offset: 0x000D9108
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

	// Token: 0x060023CE RID: 9166 RVA: 0x000DAF68 File Offset: 0x000D9168
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

	// Token: 0x060023CF RID: 9167 RVA: 0x000DAFC8 File Offset: 0x000D91C8
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

	// Token: 0x060023D0 RID: 9168 RVA: 0x000DB044 File Offset: 0x000D9244
	public int[] GetGroupConditionIds(int conditionGroupId)
	{
		ConditionGroup? conditionGroupConfig = this.GetConditionGroupConfig(conditionGroupId);
		if (conditionGroupConfig == null)
		{
			return new int[0];
		}
		return conditionGroupConfig.Value.GroupId();
	}

	// Token: 0x1700058E RID: 1422
	// (get) Token: 0x060023D1 RID: 9169 RVA: 0x000DB078 File Offset: 0x000D9278
	public static ConditionConfig Instance
	{
		get
		{
			return ConditionConfig._Instance;
		}
	}

	// Token: 0x060023D2 RID: 9170 RVA: 0x000DB07F File Offset: 0x000D927F
	public static ConditionConfig GetOrCreateInstance()
	{
		if (ConditionConfig._Instance == null)
		{
			ConditionConfig.CreateInstance();
		}
		return ConditionConfig._Instance;
	}

	// Token: 0x060023D3 RID: 9171 RVA: 0x000DB093 File Offset: 0x000D9293
	public static bool CreateInstance()
	{
		if (ConditionConfig._Instance != null)
		{
			return true;
		}
		ConditionConfig._Instance = new ConditionConfig();
		return true;
	}

	// Token: 0x060023D4 RID: 9172 RVA: 0x000DB0A9 File Offset: 0x000D92A9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060023D5 RID: 9173 RVA: 0x000DB0AB File Offset: 0x000D92AB
	public static void ResetStaticDefaultValue()
	{
		ConditionConfig._Instance = null;
	}

	// Token: 0x060023D6 RID: 9174 RVA: 0x000DB0B3 File Offset: 0x000D92B3
	static ConditionConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ConditionConfig.CreateStaticDefaultValue), new Action(ConditionConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400182D RID: 6189
	[Nullable(2)]
	private static ConditionConfig _Instance;
}
