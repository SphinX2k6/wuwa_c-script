using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001345 RID: 4933
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryWeaponData
{
	// Token: 0x0600C22B RID: 49707 RVA: 0x00397F60 File Offset: 0x00396160
	public HonamiStoryWeaponData(int id)
	{
		this.Id = id;
		this.IsUnlockInternal = false;
		HonamiStoryWeapon? config = this.Config;
		this.PluginTags = new List<int>(config.Value.PluginTags());
		this.SuitId = new List<int>(config.Value.SuitId());
		this.ExtraSuitAddEnhanceLevel = new Dictionary<int, int>();
		foreach (KeyValuePair<int, int> keyValuePair in config.Value.ExtraSuitAddEnhanceLevel())
		{
			this.ExtraSuitAddEnhanceLevel.Add(keyValuePair.Key, keyValuePair.Value);
		}
		this.IsShowReward = config.Value.IsShowReward;
		this.Desc = config.Value.AttributesDescription;
		this.DescArgs = new List<string>(config.Value.AttributesDescriptionArgs());
		this.DescSimple = config.Value.AttributesDescriptionSimple;
		this.DescSimpleArgs = new List<string>(config.Value.AttributesDescriptionSimpleArgs());
	}

	// Token: 0x170012F8 RID: 4856
	// (get) Token: 0x0600C22C RID: 49708 RVA: 0x003980E8 File Offset: 0x003962E8
	public int WeaponId
	{
		get
		{
			return this.Id;
		}
	}

	// Token: 0x170012F9 RID: 4857
	// (get) Token: 0x0600C22D RID: 49709 RVA: 0x003980F0 File Offset: 0x003962F0
	public bool IsUnlock
	{
		get
		{
			return this.IsUnlockInternal;
		}
	}

	// Token: 0x0600C22E RID: 49710 RVA: 0x003980F8 File Offset: 0x003962F8
	public void SetUnlock(bool isUnlock)
	{
		this.IsUnlockInternal = isUnlock;
	}

	// Token: 0x170012FA RID: 4858
	// (get) Token: 0x0600C22F RID: 49711 RVA: 0x00398101 File Offset: 0x00396301
	public HonamiStoryWeapon? Config
	{
		get
		{
			return HonamiStoryConfig.Instance.GetWeaponConfig(this.Id);
		}
	}

	// Token: 0x170012FB RID: 4859
	// (get) Token: 0x0600C230 RID: 49712 RVA: 0x00398114 File Offset: 0x00396314
	public EHonamiStoryWeaponType WeaponType
	{
		get
		{
			return (EHonamiStoryWeaponType)this.Config.Value.Type;
		}
	}

	// Token: 0x04006F56 RID: 28502
	private readonly int Id;

	// Token: 0x04006F57 RID: 28503
	private bool IsUnlockInternal;

	// Token: 0x04006F58 RID: 28504
	public List<int> PluginTags = new List<int>();

	// Token: 0x04006F59 RID: 28505
	public List<int> SuitId = new List<int>();

	// Token: 0x04006F5A RID: 28506
	public Dictionary<int, int> ExtraSuitAddEnhanceLevel = new Dictionary<int, int>();

	// Token: 0x04006F5B RID: 28507
	public bool IsShowReward;

	// Token: 0x04006F5C RID: 28508
	public string Desc = "";

	// Token: 0x04006F5D RID: 28509
	public List<string> DescArgs = new List<string>();

	// Token: 0x04006F5E RID: 28510
	public string DescSimple = "";

	// Token: 0x04006F5F RID: 28511
	public List<string> DescSimpleArgs = new List<string>();
}
