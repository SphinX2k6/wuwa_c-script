using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020022D9 RID: 8921
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class NpcIconConfig : ConfigBase
{
	// Token: 0x17001652 RID: 5714
	// (get) Token: 0x0601188A RID: 71818 RVA: 0x0044C3B3 File Offset: 0x0044A5B3
	public int NpcIconHeadInfoLimitMinDistanceSquared
	{
		get
		{
			return this.NpcIconHeadInfoLimitMinDistanceSquaredInternal;
		}
	}

	// Token: 0x17001653 RID: 5715
	// (get) Token: 0x0601188B RID: 71819 RVA: 0x0044C3BB File Offset: 0x0044A5BB
	public int NpcIconHeadInfoLimitMaxDistanceSquared
	{
		get
		{
			return this.NpcIconHeadInfoLimitMaxDistanceSquaredInternal;
		}
	}

	// Token: 0x0601188C RID: 71820 RVA: 0x0044C3C3 File Offset: 0x0044A5C3
	protected override bool OnInit()
	{
		this.GetNpcIconHeadInfoLimitMinDistance();
		this.GetNpcIconHeadInfoLimitMaxDistance();
		return true;
	}

	// Token: 0x0601188D RID: 71821 RVA: 0x0044C3D4 File Offset: 0x0044A5D4
	public float GetHeadStateScaleValue(float distance)
	{
		if (this.HeadStateScaleCurve == null)
		{
			this.HeadStateScaleCurve = ResourceSystem.Instance.GetLoadedAsset<UCurveFloat>("/Game/Aki/UI/UIResources/UiWorld/Curve/NPCHeadStateScaleCurve.NPCHeadStateScaleCurve");
		}
		UCurveFloat headStateScaleCurve = this.HeadStateScaleCurve;
		if (headStateScaleCurve == null)
		{
			return 1f;
		}
		return headStateScaleCurve.GetFloatValue(distance);
	}

	// Token: 0x0601188E RID: 71822 RVA: 0x0044C409 File Offset: 0x0044A609
	public float GetDialogScaleValue(float distance)
	{
		if (this.DialogScaleCurve == null)
		{
			this.DialogScaleCurve = ResourceSystem.Instance.GetLoadedAsset<UCurveFloat>("/Game/Aki/UI/UIResources/UiWorld/Curve/NPCDialogScaleCurve.NPCDialogScaleCurve");
		}
		UCurveFloat dialogScaleCurve = this.DialogScaleCurve;
		if (dialogScaleCurve == null)
		{
			return 1f;
		}
		return dialogScaleCurve.GetFloatValue(distance);
	}

	// Token: 0x0601188F RID: 71823 RVA: 0x0044C43E File Offset: 0x0044A63E
	public string GetNpcIconSocketName()
	{
		if (string.IsNullOrEmpty(this.NpcIconSocketName))
		{
			this.NpcIconSocketName = ConfigCommonParamById.GetStringConfig("npcicon_socketname");
		}
		return this.NpcIconSocketName;
	}

	// Token: 0x06011890 RID: 71824 RVA: 0x0044C464 File Offset: 0x0044A664
	public int GetNpcIconLocationOffsetZ()
	{
		if (this.NpcIconLocationOffsetZ == -1)
		{
			this.NpcIconLocationOffsetZ = ConfigCommonParamById.GetIntConfig("npcicon_location_offsetz").GetValueOrDefault();
		}
		return this.NpcIconLocationOffsetZ;
	}

	// Token: 0x06011891 RID: 71825 RVA: 0x0044C498 File Offset: 0x0044A698
	public int GetNpcIconHeadInfoLimitMinDistance()
	{
		if (this.NpcIconHeadInfoLimitMinDistance == -1)
		{
			this.NpcIconHeadInfoLimitMinDistance = ConfigCommonParamById.GetIntConfig("npc_headinfo_limit_min_distance").GetValueOrDefault();
			this.NpcIconHeadInfoLimitMinDistanceSquaredInternal = this.NpcIconHeadInfoLimitMinDistance * this.NpcIconHeadInfoLimitMinDistance;
		}
		return this.NpcIconHeadInfoLimitMinDistance;
	}

	// Token: 0x06011892 RID: 71826 RVA: 0x0044C4E0 File Offset: 0x0044A6E0
	public int GetNpcIconHeadInfoLimitMaxDistance()
	{
		if (this.NpcIconHeadInfoLimitMaxDistance == -1)
		{
			this.NpcIconHeadInfoLimitMaxDistance = ConfigCommonParamById.GetIntConfig("npc_headinfo_limit_max_distance").GetValueOrDefault();
			this.NpcIconHeadInfoLimitMaxDistanceSquaredInternal = this.NpcIconHeadInfoLimitMaxDistance * this.NpcIconHeadInfoLimitMaxDistance;
		}
		return this.NpcIconHeadInfoLimitMaxDistance;
	}

	// Token: 0x06011893 RID: 71827 RVA: 0x0044C528 File Offset: 0x0044A728
	public int GetNpcIconHeadInfoNameLimitDistance()
	{
		if (this.NpcIconHeadInfoNameLimitDistance == -1)
		{
			this.NpcIconHeadInfoNameLimitDistance = ConfigCommonParamById.GetIntConfig("npc_headinfo_name_limit_distance").GetValueOrDefault();
		}
		return this.NpcIconHeadInfoNameLimitDistance;
	}

	// Token: 0x06011894 RID: 71828 RVA: 0x0044C55C File Offset: 0x0044A75C
	public NpcHeadInfo GetNpcHeadInfo(int id)
	{
		NpcHeadInfo? config = ConfigNpcHeadInfoById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "查找不到对应的NPC头顶信息数据，检查一下NPC头顶信息表格";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ID", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config.Value;
	}

	// Token: 0x06011895 RID: 71829 RVA: 0x0044C5B0 File Offset: 0x0044A7B0
	public int GetPlayerInfoIconLocationOffsetZ()
	{
		if (this.PlayerInfoIconLocationOffsetZ == -1)
		{
			this.PlayerInfoIconLocationOffsetZ = ConfigCommonParamById.GetIntConfig("OnlinePlayerNameZOffset").GetValueOrDefault();
		}
		return this.PlayerInfoIconLocationOffsetZ;
	}

	// Token: 0x06011896 RID: 71830 RVA: 0x0044C5E4 File Offset: 0x0044A7E4
	public int GetPlayerInfoNameLimitDistance()
	{
		if (this.PlayerInfoNameLimitDistance == -1)
		{
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("OnlineTeammateDistanceThreshold");
			this.PlayerInfoNameLimitDistance = intArrayConfig[0] * 100;
			this.PlayerInfoIconLimitDistance = intArrayConfig[1] * 100;
		}
		return this.PlayerInfoNameLimitDistance;
	}

	// Token: 0x06011897 RID: 71831 RVA: 0x0044C62C File Offset: 0x0044A82C
	public int GetPlayerInfoIconLimitDistance()
	{
		if (this.PlayerInfoIconLimitDistance == -1)
		{
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("OnlineTeammateDistanceThreshold");
			this.PlayerInfoNameLimitDistance = intArrayConfig[0] * 100;
			this.PlayerInfoIconLimitDistance = intArrayConfig[1] * 100;
		}
		return this.PlayerInfoIconLimitDistance;
	}

	// Token: 0x06011898 RID: 71832 RVA: 0x0044C673 File Offset: 0x0044A873
	protected override bool OnClear()
	{
		this.NpcIconConfigMap.Clear();
		this.NpcIconSocketName = null;
		this.HeadStateScaleCurve = null;
		this.DialogScaleCurve = null;
		return true;
	}

	// Token: 0x17001654 RID: 5716
	// (get) Token: 0x06011899 RID: 71833 RVA: 0x0044C696 File Offset: 0x0044A896
	public static NpcIconConfig Instance
	{
		get
		{
			return NpcIconConfig._Instance;
		}
	}

	// Token: 0x0601189A RID: 71834 RVA: 0x0044C69D File Offset: 0x0044A89D
	public static NpcIconConfig GetOrCreateInstance()
	{
		if (NpcIconConfig._Instance == null)
		{
			NpcIconConfig.CreateInstance();
		}
		return NpcIconConfig._Instance;
	}

	// Token: 0x0601189B RID: 71835 RVA: 0x0044C6B1 File Offset: 0x0044A8B1
	public static bool CreateInstance()
	{
		if (NpcIconConfig._Instance != null)
		{
			return true;
		}
		NpcIconConfig._Instance = new NpcIconConfig();
		return true;
	}

	// Token: 0x0601189C RID: 71836 RVA: 0x0044C6C7 File Offset: 0x0044A8C7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601189D RID: 71837 RVA: 0x0044C6C9 File Offset: 0x0044A8C9
	public static void ResetStaticDefaultValue()
	{
		NpcIconConfig._Instance = null;
	}

	// Token: 0x0601189E RID: 71838 RVA: 0x0044C6D1 File Offset: 0x0044A8D1
	static NpcIconConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NpcIconConfig.CreateStaticDefaultValue), new Action(NpcIconConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400852E RID: 34094
	private readonly Dictionary<int, NpcHeadInfo> NpcIconConfigMap = new Dictionary<int, NpcHeadInfo>();

	// Token: 0x0400852F RID: 34095
	[Nullable(2)]
	private UCurveFloat HeadStateScaleCurve;

	// Token: 0x04008530 RID: 34096
	[Nullable(2)]
	private UCurveFloat DialogScaleCurve;

	// Token: 0x04008531 RID: 34097
	[Nullable(2)]
	private string NpcIconSocketName = "";

	// Token: 0x04008532 RID: 34098
	private int NpcIconLocationOffsetZ = -1;

	// Token: 0x04008533 RID: 34099
	private int NpcIconHeadInfoLimitMinDistance = -1;

	// Token: 0x04008534 RID: 34100
	private int NpcIconHeadInfoLimitMinDistanceSquaredInternal;

	// Token: 0x04008535 RID: 34101
	private int NpcIconHeadInfoLimitMaxDistance = -1;

	// Token: 0x04008536 RID: 34102
	private int NpcIconHeadInfoLimitMaxDistanceSquaredInternal;

	// Token: 0x04008537 RID: 34103
	private int NpcIconHeadInfoNameLimitDistance = -1;

	// Token: 0x04008538 RID: 34104
	private int PlayerInfoIconLocationOffsetZ = -1;

	// Token: 0x04008539 RID: 34105
	private int PlayerInfoNameLimitDistance = -1;

	// Token: 0x0400853A RID: 34106
	private int PlayerInfoIconLimitDistance = -1;

	// Token: 0x0400853B RID: 34107
	[Nullable(2)]
	private static NpcIconConfig _Instance;
}
