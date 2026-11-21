using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200256E RID: 9582
[NullableContext(1)]
[Nullable(0)]
public class FoleySynthController
{
	// Token: 0x170024AF RID: 9391
	// (get) Token: 0x06017A92 RID: 96914 RVA: 0x006FE483 File Offset: 0x006FC683
	// (set) Token: 0x06017A93 RID: 96915 RVA: 0x006FE48B File Offset: 0x006FC68B
	public CharacterActorComponent ActorComp { get; private set; }

	// Token: 0x170024B0 RID: 9392
	// (get) Token: 0x06017A94 RID: 96916 RVA: 0x006FE494 File Offset: 0x006FC694
	// (set) Token: 0x06017A95 RID: 96917 RVA: 0x006FE49C File Offset: 0x006FC69C
	public CharacterAkComponent AkComp { get; private set; }

	// Token: 0x170024B1 RID: 9393
	// (get) Token: 0x06017A96 RID: 96918 RVA: 0x006FE4A5 File Offset: 0x006FC6A5
	// (set) Token: 0x06017A97 RID: 96919 RVA: 0x006FE4AD File Offset: 0x006FC6AD
	public BaseTagComponent TagComp { get; private set; }

	// Token: 0x06017A98 RID: 96920 RVA: 0x006FE4B6 File Offset: 0x006FC6B6
	public FoleySynthController(CharacterActorComponent actorComp, CharacterAkComponent akComp, BaseTagComponent tagComp)
	{
		this.ActorComp = actorComp;
		this.AkComp = akComp;
		this.TagComp = tagComp;
	}

	// Token: 0x06017A99 RID: 96921 RVA: 0x006FE4DE File Offset: 0x006FC6DE
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

	// Token: 0x06017A9A RID: 96922 RVA: 0x006FE4F4 File Offset: 0x006FC6F4
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

	// Token: 0x06017A9B RID: 96923 RVA: 0x006FE598 File Offset: 0x006FC798
	public void Clear()
	{
		foreach (FoleySynthHandlerBase foleySynthHandlerBase in this.Handlers)
		{
			foleySynthHandlerBase.Clear();
		}
		this.Handlers.Clear();
		this.Config = null;
	}

	// Token: 0x06017A9C RID: 96924 RVA: 0x006FE5FC File Offset: 0x006FC7FC
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

	// Token: 0x06017A9D RID: 96925 RVA: 0x006FE640 File Offset: 0x006FC840
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

	// Token: 0x0400C98A RID: 51594
	private readonly List<FoleySynthHandlerBase> Handlers = new List<FoleySynthHandlerBase>();

	// Token: 0x0400C98B RID: 51595
	[Nullable(2)]
	private FoleySynthAllConfig Config;
}
