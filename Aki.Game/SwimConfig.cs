using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020031A2 RID: 12706
[NullableContext(1)]
[Nullable(0)]
public class SwimConfig : ConfigBase
{
	// Token: 0x0601B60D RID: 112141 RVA: 0x0077C26A File Offset: 0x0077A46A
	protected override bool OnInit()
	{
		this.CacheConfig = new Dictionary<string, Swim>();
		this.BuffIdWithInputForNormalSwim = new long?(0L);
		this.BuffIdWithInputForFastSwim = new long?(0L);
		this.BuffIdWithNoInput = new long?(0L);
		this.InitSwimBuffConfig();
		return true;
	}

	// Token: 0x0601B60E RID: 112142 RVA: 0x0077C2A5 File Offset: 0x0077A4A5
	protected override bool OnClear()
	{
		this.CacheConfig = null;
		this.BuffIdWithInputForNormalSwim = null;
		this.BuffIdWithInputForFastSwim = null;
		this.BuffIdWithNoInput = null;
		return true;
	}

	// Token: 0x0601B60F RID: 112143 RVA: 0x0077C2D4 File Offset: 0x0077A4D4
	public Swim? GetSwimConfigByRoleBodyId(string roleBodyId)
	{
		Swim value;
		if (this.CacheConfig.TryGetValue(roleBodyId, out value))
		{
			return new Swim?(value);
		}
		Swim? config = ConfigSwimById.GetConfig(roleBodyId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "以下身高没有配置游泳";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoleBody", roleBodyId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.CacheConfig.Add(roleBodyId, config.Value);
		return config;
	}

	// Token: 0x0601B610 RID: 112144 RVA: 0x0077C344 File Offset: 0x0077A544
	public long? GetSwimBuffId(bool hasInput, bool bFastSwim)
	{
		if (!hasInput)
		{
			return this.BuffIdWithNoInput;
		}
		if (bFastSwim)
		{
			return this.BuffIdWithInputForFastSwim;
		}
		return this.BuffIdWithInputForNormalSwim;
	}

	// Token: 0x0601B611 RID: 112145 RVA: 0x0077C360 File Offset: 0x0077A560
	public void InitSwimBuffConfig()
	{
		SwimBuff? config = ConfigSwimBuffById.GetConfig(0, true);
		if (config == null)
		{
			Log.Instance.Error(ELogModule.Movement, ELogAuthor.LJM, "游泳Buff表没有配置Id为0的基础配置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.BuffIdWithInputForNormalSwim = new long?((long)config.Value.BuffId);
		SwimBuff? config2 = ConfigSwimBuffById.GetConfig(1, true);
		if (config2 == null)
		{
			Log.Instance.Error(ELogModule.Movement, ELogAuthor.LJM, "游泳Buff表没有配置Id为1的基础配置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.BuffIdWithNoInput = new long?((long)config2.Value.BuffId);
		SwimBuff? config3 = ConfigSwimBuffById.GetConfig(3, true);
		if (config3 == null)
		{
			Log.Instance.Error(ELogModule.Movement, ELogAuthor.LJM, "游泳Buff表没有配置Id为3的基础配置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.BuffIdWithInputForFastSwim = new long?((long)config3.Value.BuffId);
	}

	// Token: 0x170025D8 RID: 9688
	// (get) Token: 0x0601B612 RID: 112146 RVA: 0x0077C44B File Offset: 0x0077A64B
	public static SwimConfig Instance
	{
		get
		{
			return SwimConfig._Instance;
		}
	}

	// Token: 0x0601B613 RID: 112147 RVA: 0x0077C452 File Offset: 0x0077A652
	public static SwimConfig GetOrCreateInstance()
	{
		if (SwimConfig._Instance == null)
		{
			SwimConfig.CreateInstance();
		}
		return SwimConfig._Instance;
	}

	// Token: 0x0601B614 RID: 112148 RVA: 0x0077C466 File Offset: 0x0077A666
	public static bool CreateInstance()
	{
		if (SwimConfig._Instance != null)
		{
			return true;
		}
		SwimConfig._Instance = new SwimConfig();
		return true;
	}

	// Token: 0x0601B615 RID: 112149 RVA: 0x0077C47C File Offset: 0x0077A67C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B616 RID: 112150 RVA: 0x0077C47E File Offset: 0x0077A67E
	public static void ResetStaticDefaultValue()
	{
		SwimConfig._Instance = null;
	}

	// Token: 0x0601B617 RID: 112151 RVA: 0x0077C486 File Offset: 0x0077A686
	static SwimConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SwimConfig.CreateStaticDefaultValue), new Action(SwimConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400D679 RID: 54905
	private const int NORMAL_SWIM_CONFIG_ID = 0;

	// Token: 0x0400D67A RID: 54906
	private const int NO_INPUT_CONFIG_ID = 1;

	// Token: 0x0400D67B RID: 54907
	private const int FAST_SWIM_CONFIG_ID = 3;

	// Token: 0x0400D67C RID: 54908
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, Swim> CacheConfig;

	// Token: 0x0400D67D RID: 54909
	private long? BuffIdWithInputForNormalSwim;

	// Token: 0x0400D67E RID: 54910
	private long? BuffIdWithInputForFastSwim;

	// Token: 0x0400D67F RID: 54911
	private long? BuffIdWithNoInput;

	// Token: 0x0400D680 RID: 54912
	[Nullable(2)]
	private static SwimConfig _Instance;
}
