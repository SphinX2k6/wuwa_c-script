using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003018 RID: 12312
[NullableContext(1)]
[Nullable(0)]
public class FoleySynthController
{
	// Token: 0x170023E1 RID: 9185
	// (get) Token: 0x0601A14A RID: 106826 RVA: 0x006D657B File Offset: 0x006D477B
	// (set) Token: 0x0601A14B RID: 106827 RVA: 0x006D6583 File Offset: 0x006D4783
	public CharacterActorComponent ActorComp { get; private set; }

	// Token: 0x170023E2 RID: 9186
	// (get) Token: 0x0601A14C RID: 106828 RVA: 0x006D658C File Offset: 0x006D478C
	// (set) Token: 0x0601A14D RID: 106829 RVA: 0x006D6594 File Offset: 0x006D4794
	public CharacterAkComponent AkComp { get; private set; }

	// Token: 0x170023E3 RID: 9187
	// (get) Token: 0x0601A14E RID: 106830 RVA: 0x006D659D File Offset: 0x006D479D
	// (set) Token: 0x0601A14F RID: 106831 RVA: 0x006D65A5 File Offset: 0x006D47A5
	public BaseTagComponent TagComp { get; private set; }

	// Token: 0x0601A150 RID: 106832 RVA: 0x006D65AE File Offset: 0x006D47AE
	public FoleySynthController(CharacterActorComponent actorComp, CharacterAkComponent akComp, BaseTagComponent tagComp)
	{
		this.ActorComp = actorComp;
		this.AkComp = akComp;
		this.TagComp = tagComp;
	}

	// Token: 0x0601A151 RID: 106833 RVA: 0x006D65D6 File Offset: 0x006D47D6
	[NullableContext(2)]
	public void Init(FoleySynthAllConfig allConfig)
	{
		if (allConfig == null)
		{
			return;
		}
		this.Config = allConfig;
		this.InitConfig(allConfig);
	}

	// Token: 0x0601A152 RID: 106834 RVA: 0x006D65EC File Offset: 0x006D47EC
	public void Tick(float deltaTime)
	{
		FoleySynthAllConfig config = this.Config;
		if (config == null || !config.IsLoadSuccess())
		{
			return;
		}
		if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]) && !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.冲刺"]))
		{
			return;
		}
		foreach (FoleySynthHandlerBase foleySynthHandlerBase in this.Handlers)
		{
			foleySynthHandlerBase.Tick(deltaTime);
		}
	}

	// Token: 0x0601A153 RID: 106835 RVA: 0x006D6690 File Offset: 0x006D4890
	public void Clear()
	{
		foreach (FoleySynthHandlerBase foleySynthHandlerBase in this.Handlers)
		{
			foleySynthHandlerBase.Clear();
		}
		this.Handlers.Clear();
		this.Config = null;
	}

	// Token: 0x0601A154 RID: 106836 RVA: 0x006D66F4 File Offset: 0x006D48F4
	public void SetDebug(bool debug, int[] models)
	{
		foreach (int num in models)
		{
			if (num < this.Handlers.Count)
			{
				this.Handlers[num].SetDebug(debug);
			}
		}
	}

	// Token: 0x0601A155 RID: 106837 RVA: 0x006D6738 File Offset: 0x006D4938
	private void InitConfig(FoleySynthAllConfig allConfig)
	{
		if (allConfig.FoleySynthModel1Configs.Count > 0)
		{
			FoleySynthModel1Handler foleySynthModel1Handler = new FoleySynthModel1Handler(this.ActorComp, this.AkComp, 2);
			foleySynthModel1Handler.Init(allConfig.FoleySynthModel1Configs);
			this.Handlers.Add(foleySynthModel1Handler);
		}
		if (allConfig.FoleySynthModel2Configs.Count > 0)
		{
			FoleySynthModel2Handler foleySynthModel2Handler = new FoleySynthModel2Handler(this.ActorComp, this.AkComp, allConfig.Model2AccelerationMaxCount);
			foleySynthModel2Handler.Init(allConfig.FoleySynthModel2Configs);
			foleySynthModel2Handler.VelocityMaxCount = allConfig.Model2VelocityMaxCount;
			this.Handlers.Add(foleySynthModel2Handler);
		}
	}

	// Token: 0x0400C5BD RID: 50621
	private readonly List<FoleySynthHandlerBase> Handlers = new List<FoleySynthHandlerBase>();

	// Token: 0x0400C5BE RID: 50622
	[Nullable(2)]
	private FoleySynthAllConfig Config;
}
