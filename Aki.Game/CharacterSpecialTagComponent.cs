using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;

// Token: 0x0200308B RID: 12427
[NullableContext(1)]
[Nullable(0)]
public class CharacterSpecialTagComponent : EntityComponent
{
	// Token: 0x0601A8C1 RID: 108737 RVA: 0x0071BF3F File Offset: 0x0071A13F
	protected override bool OnStart()
	{
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		return true;
	}

	// Token: 0x0601A8C2 RID: 108738 RVA: 0x0071BF54 File Offset: 0x0071A154
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

	// Token: 0x0601A8C3 RID: 108739 RVA: 0x0071BFBC File Offset: 0x0071A1BC
	protected override bool OnEnd()
	{
		foreach (KeyValuePair<int, SpecialTagConfig> keyValuePair in this.TagListenerConfig)
		{
			keyValuePair.Value.Clear();
		}
		return true;
	}

	// Token: 0x0601A8C4 RID: 108740 RVA: 0x0071C018 File Offset: 0x0071A218
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

	// Token: 0x0601A8C5 RID: 108741 RVA: 0x0071C080 File Offset: 0x0071A280
	public void RemoveTagListenerConfig(int handle)
	{
		SpecialTagConfig specialTagConfig;
		if (this.TagListenerConfig.TryGetValue(handle, out specialTagConfig))
		{
			specialTagConfig.Clear();
			this.TagListenerConfig.Remove(handle);
		}
	}

	// Token: 0x0601A8C6 RID: 108742 RVA: 0x0071C0B0 File Offset: 0x0071A2B0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterSpecialTagComponent characterSpecialTagComponent = (CharacterSpecialTagComponent)componentTemplate;
		if (base.CanResetComponentProperty("ConfigHandleCount"))
		{
			this.ConfigHandleCount = characterSpecialTagComponent.ConfigHandleCount;
		}
		if (base.CanResetComponentProperty("TagListenerConfig"))
		{
			if (characterSpecialTagComponent.TagListenerConfig == null)
			{
				this.TagListenerConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, SpecialTagConfig>>(this.TagListenerConfig), "TagListenerConfig"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (characterSpecialTagComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400CBFB RID: 52219
	private int ConfigHandleCount;

	// Token: 0x0400CBFC RID: 52220
	private Dictionary<int, SpecialTagConfig> TagListenerConfig = new Dictionary<int, SpecialTagConfig>();

	// Token: 0x0400CBFD RID: 52221
	[Nullable(2)]
	private BaseTagComponent TagComp;
}
