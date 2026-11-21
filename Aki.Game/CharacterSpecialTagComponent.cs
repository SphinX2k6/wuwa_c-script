using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;

// Token: 0x020025E2 RID: 9698
[NullableContext(1)]
[Nullable(0)]
public class CharacterSpecialTagComponent : EntityComponent
{
	// Token: 0x060182A8 RID: 98984 RVA: 0x007422F7 File Offset: 0x007404F7
	protected override bool OnStart()
	{
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		return true;
	}

	// Token: 0x060182A9 RID: 98985 RVA: 0x0074230C File Offset: 0x0074050C
	protected override void OnTick(float delta)
	{
		if (this.TagListenerConfig.Count > 0)
		{
			foreach (SpecialTagConfig specialTagConfig in this.TagListenerConfig.Values)
			{
				specialTagConfig.UpdateCondition((double)delta);
			}
		}
	}

	// Token: 0x060182AA RID: 98986 RVA: 0x00742374 File Offset: 0x00740574
	protected override bool OnEnd()
	{
		foreach (KeyValuePair<int, SpecialTagConfig> keyValuePair in this.TagListenerConfig)
		{
			keyValuePair.Value.Clear();
		}
		return true;
	}

	// Token: 0x060182AB RID: 98987 RVA: 0x007423D0 File Offset: 0x007405D0
	public int InitTagListenerConfig(string daPath, Func<double, bool> condition)
	{
		CharacterSpecialTagComponent.<>c__DisplayClass6_0 CS$<>8__locals1 = new CharacterSpecialTagComponent.<>c__DisplayClass6_0();
		CS$<>8__locals1.daPath = daPath;
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.condition = condition;
		CharacterSpecialTagComponent.<>c__DisplayClass6_0 CS$<>8__locals2 = CS$<>8__locals1;
		int configHandleCount = this.ConfigHandleCount;
		this.ConfigHandleCount = configHandleCount + 1;
		CS$<>8__locals2.handle = configHandleCount;
		ResourceSystem.Instance.LoadTypeAsync("BP_SpecialTagConfig_C", delegate
		{
			ResourceSystem instance = ResourceSystem.Instance;
			string daPath2 = CS$<>8__locals1.daPath;
			Action<BP_SpecialTagConfig_C, string> callback;
			if ((callback = CS$<>8__locals1.<>9__1) == null)
			{
				callback = (CS$<>8__locals1.<>9__1 = delegate([Nullable(2)] BP_SpecialTagConfig_C asset, string _)
				{
					if (asset == null || CS$<>8__locals1.<>4__this.TagComp == null)
					{
						return;
					}
					SpecialTagConfig specialTagConfig = new SpecialTagConfig();
					specialTagConfig.Init(CS$<>8__locals1.<>4__this.TagComp, asset, CS$<>8__locals1.condition);
					CS$<>8__locals1.<>4__this.TagListenerConfig[CS$<>8__locals1.handle] = specialTagConfig;
				});
			}
			instance.LoadAsync<BP_SpecialTagConfig_C>(daPath2, callback, 100, "js_undefined");
		}, "js_undefined");
		return CS$<>8__locals1.handle;
	}

	// Token: 0x060182AC RID: 98988 RVA: 0x00742438 File Offset: 0x00740638
	public void RemoveTagListenerConfig(int handle)
	{
		SpecialTagConfig specialTagConfig;
		if (this.TagListenerConfig.TryGetValue(handle, out specialTagConfig))
		{
			specialTagConfig.Clear();
			this.TagListenerConfig.Remove(handle);
		}
	}

	// Token: 0x060182AD RID: 98989 RVA: 0x00742468 File Offset: 0x00740668
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterSpecialTagComponent characterSpecialTagComponent = (CharacterSpecialTagComponent)componentTemplate;
		this.ConfigHandleCount = characterSpecialTagComponent.ConfigHandleCount;
		if (characterSpecialTagComponent.TagListenerConfig == null)
		{
			this.TagListenerConfig = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagListenerConfig), "TagListenerConfig"))
		{
			return false;
		}
		if (characterSpecialTagComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x170025E5 RID: 9701
	// (get) Token: 0x060182AE RID: 98990 RVA: 0x007424EA File Offset: 0x007406EA
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025E6 RID: 9702
	// (get) Token: 0x060182AF RID: 98991 RVA: 0x007424ED File Offset: 0x007406ED
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025E7 RID: 9703
	// (get) Token: 0x060182B0 RID: 98992 RVA: 0x007424F0 File Offset: 0x007406F0
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CFDE RID: 53214
	private int ConfigHandleCount;

	// Token: 0x0400CFDF RID: 53215
	private Dictionary<int, SpecialTagConfig> TagListenerConfig = new Dictionary<int, SpecialTagConfig>();

	// Token: 0x0400CFE0 RID: 53216
	[Nullable(2)]
	private BaseTagComponent TagComp;
}
