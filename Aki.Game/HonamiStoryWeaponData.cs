using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001E83 RID: 7811
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryWeaponData
{
	// Token: 0x0600EE0C RID: 60940 RVA: 0x0038C370 File Offset: 0x0038A570
	public HonamiStoryWeaponData(int id)
	{
		this.Id = id;
		this.IsUnlockInternal = false;
		HonamiStoryWeapon? config = this.Config;
		this.PluginTags = config.Value.PluginTags().ToList<int>();
		this.SuitId = config.Value.SuitId().ToList<int>();
		this.ExtraSuitAddEnhanceLevel = new Dictionary<int, int>();
		foreach (KeyValuePair<int, int> keyValuePair in config.Value.ExtraSuitAddEnhanceLevel())
		{
			this.ExtraSuitAddEnhanceLevel.Add(keyValuePair.Key, keyValuePair.Value);
		}
		this.IsShowReward = config.Value.IsShowReward;
		this.Desc = config.Value.AttributesDescription;
		this.DescArgs = config.Value.AttributesDescriptionArgs().ToList<string>();
		this.DescSimple = config.Value.AttributesDescriptionSimple;
		this.DescSimpleArgs = config.Value.AttributesDescriptionSimpleArgs().ToList<string>();
	}

	// Token: 0x170012CE RID: 4814
	// (get) Token: 0x0600EE0D RID: 60941 RVA: 0x0038C4F8 File Offset: 0x0038A6F8
	public int WeaponId
	{
		get
		{
			return this.Id;
		}
	}

	// Token: 0x170012CF RID: 4815
	// (get) Token: 0x0600EE0E RID: 60942 RVA: 0x0038C500 File Offset: 0x0038A700
	public bool IsUnlock
	{
		get
		{
			return this.IsUnlockInternal;
		}
	}

	// Token: 0x0600EE0F RID: 60943 RVA: 0x0038C508 File Offset: 0x0038A708
	public void SetUnlock(bool isUnlock)
	{
		this.IsUnlockInternal = isUnlock;
	}

	// Token: 0x170012D0 RID: 4816
	// (get) Token: 0x0600EE10 RID: 60944 RVA: 0x0038C511 File Offset: 0x0038A711
	public HonamiStoryWeapon? Config
	{
		get
		{
			return HonamiStoryConfig.Instance.GetWeaponConfig(this.Id);
		}
	}

	// Token: 0x170012D1 RID: 4817
	// (get) Token: 0x0600EE11 RID: 60945 RVA: 0x0038C524 File Offset: 0x0038A724
	public EHonamiStoryWeaponType WeaponType
	{
		get
		{
			return (EHonamiStoryWeaponType)this.Config.Value.Type;
		}
	}

	// Token: 0x04006E75 RID: 28277
	private readonly int Id;

	// Token: 0x04006E76 RID: 28278
	private bool IsUnlockInternal;

	// Token: 0x04006E77 RID: 28279
	public List<int> PluginTags = new List<int>();

	// Token: 0x04006E78 RID: 28280
	public List<int> SuitId = new List<int>();

	// Token: 0x04006E79 RID: 28281
	public Dictionary<int, int> ExtraSuitAddEnhanceLevel = new Dictionary<int, int>();

	// Token: 0x04006E7A RID: 28282
	public bool IsShowReward;

	// Token: 0x04006E7B RID: 28283
	public string Desc = "";

	// Token: 0x04006E7C RID: 28284
	public List<string> DescArgs = new List<string>();

	// Token: 0x04006E7D RID: 28285
	public string DescSimple = "";

	// Token: 0x04006E7E RID: 28286
	public List<string> DescSimpleArgs = new List<string>();
}
