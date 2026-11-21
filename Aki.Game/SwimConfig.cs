using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002711 RID: 10001
[NullableContext(1)]
[Nullable(0)]
public class SwimConfig : ConfigBase
{
	// Token: 0x06019136 RID: 102710 RVA: 0x007A44A6 File Offset: 0x007A26A6
	protected override bool OnInit()
	{
		this.CacheConfig = new Dictionary<string, Swim>();
		this.BuffIdWithInputForNormalSwim = new long?(0L);
		this.BuffIdWithInputForFastSwim = new long?(0L);
		this.BuffIdWithNoInput = new long?(0L);
		this.InitSwimBuffConfig();
		return true;
	}

	// Token: 0x06019137 RID: 102711 RVA: 0x007A44E1 File Offset: 0x007A26E1
	protected override bool OnClear()
	{
		this.CacheConfig = null;
		this.BuffIdWithInputForNormalSwim = null;
		this.BuffIdWithInputForFastSwim = null;
		this.BuffIdWithNoInput = null;
		return true;
	}

	// Token: 0x06019138 RID: 102712 RVA: 0x007A4510 File Offset: 0x007A2710
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

	// Token: 0x06019139 RID: 102713 RVA: 0x007A4580 File Offset: 0x007A2780
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

	// Token: 0x0601913A RID: 102714 RVA: 0x007A459C File Offset: 0x007A279C
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

	// Token: 0x170027D1 RID: 10193
	// (get) Token: 0x0601913B RID: 102715 RVA: 0x007A4687 File Offset: 0x007A2887
	public static SwimConfig Instance
	{
		get
		{
			return SwimConfig._Instance;
		}
	}

	// Token: 0x0601913C RID: 102716 RVA: 0x007A468E File Offset: 0x007A288E
	public static SwimConfig GetOrCreateInstance()
	{
		if (SwimConfig._Instance == null)
		{
			SwimConfig.CreateInstance();
		}
		return SwimConfig._Instance;
	}

	// Token: 0x0601913D RID: 102717 RVA: 0x007A46A2 File Offset: 0x007A28A2
	public static bool CreateInstance()
	{
		if (SwimConfig._Instance != null)
		{
			return true;
		}
		SwimConfig._Instance = new SwimConfig();
		return true;
	}

	// Token: 0x0601913E RID: 102718 RVA: 0x007A46B8 File Offset: 0x007A28B8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601913F RID: 102719 RVA: 0x007A46BA File Offset: 0x007A28BA
	public static void ResetStaticDefaultValue()
	{
		SwimConfig._Instance = null;
	}

	// Token: 0x06019140 RID: 102720 RVA: 0x007A46C2 File Offset: 0x007A28C2
	static SwimConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SwimConfig.CreateStaticDefaultValue), new Action(SwimConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400DAFF RID: 56063
	private const int NORMAL_SWIM_CONFIG_ID = 0;

	// Token: 0x0400DB00 RID: 56064
	private const int NO_INPUT_CONFIG_ID = 1;

	// Token: 0x0400DB01 RID: 56065
	private const int FAST_SWIM_CONFIG_ID = 3;

	// Token: 0x0400DB02 RID: 56066
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<string, Swim> CacheConfig;

	// Token: 0x0400DB03 RID: 56067
	private long? BuffIdWithInputForNormalSwim;

	// Token: 0x0400DB04 RID: 56068
	private long? BuffIdWithInputForFastSwim;

	// Token: 0x0400DB05 RID: 56069
	private long? BuffIdWithNoInput;

	// Token: 0x0400DB06 RID: 56070
	[Nullable(2)]
	private static SwimConfig _Instance;
}
