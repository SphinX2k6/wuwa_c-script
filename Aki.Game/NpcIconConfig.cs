using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020017BD RID: 6077
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class NpcIconConfig : ConfigBase
{
	// Token: 0x17001689 RID: 5769
	// (get) Token: 0x0600ED21 RID: 60705 RVA: 0x004590BB File Offset: 0x004572BB
	public int NpcIconHeadInfoLimitMinDistanceSquared
	{
		get
		{
			return this.NpcIconHeadInfoLimitMinDistanceSquaredInternal;
		}
	}

	// Token: 0x1700168A RID: 5770
	// (get) Token: 0x0600ED22 RID: 60706 RVA: 0x004590C3 File Offset: 0x004572C3
	public int NpcIconHeadInfoLimitMaxDistanceSquared
	{
		get
		{
			return this.NpcIconHeadInfoLimitMaxDistanceSquaredInternal;
		}
	}

	// Token: 0x0600ED23 RID: 60707 RVA: 0x004590CB File Offset: 0x004572CB
	protected override bool OnInit()
	{
		this.GetNpcIconHeadInfoLimitMinDistance();
		this.GetNpcIconHeadInfoLimitMaxDistance();
		return true;
	}

	// Token: 0x0600ED24 RID: 60708 RVA: 0x004590DC File Offset: 0x004572DC
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

	// Token: 0x0600ED25 RID: 60709 RVA: 0x00459111 File Offset: 0x00457311
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

	// Token: 0x0600ED26 RID: 60710 RVA: 0x00459146 File Offset: 0x00457346
	public string GetNpcIconSocketName()
	{
		if (string.IsNullOrEmpty(this.NpcIconSocketName))
		{
			this.NpcIconSocketName = ConfigCommonParamById.GetStringConfig("npcicon_socketname");
		}
		return this.NpcIconSocketName;
	}

	// Token: 0x0600ED27 RID: 60711 RVA: 0x0045916C File Offset: 0x0045736C
	public int GetNpcIconLocationOffsetZ()
	{
		if (this.NpcIconLocationOffsetZ == -1)
		{
			this.NpcIconLocationOffsetZ = ConfigCommonParamById.GetIntConfig("npcicon_location_offsetz").GetValueOrDefault();
		}
		return this.NpcIconLocationOffsetZ;
	}

	// Token: 0x0600ED28 RID: 60712 RVA: 0x004591A0 File Offset: 0x004573A0
	public int GetNpcIconHeadInfoLimitMinDistance()
	{
		if (this.NpcIconHeadInfoLimitMinDistance == -1)
		{
			this.NpcIconHeadInfoLimitMinDistance = ConfigCommonParamById.GetIntConfig("npc_headinfo_limit_min_distance").GetValueOrDefault();
			this.NpcIconHeadInfoLimitMinDistanceSquaredInternal = this.NpcIconHeadInfoLimitMinDistance * this.NpcIconHeadInfoLimitMinDistance;
		}
		return this.NpcIconHeadInfoLimitMinDistance;
	}

	// Token: 0x0600ED29 RID: 60713 RVA: 0x004591E8 File Offset: 0x004573E8
	public int GetNpcIconHeadInfoLimitMaxDistance()
	{
		if (this.NpcIconHeadInfoLimitMaxDistance == -1)
		{
			this.NpcIconHeadInfoLimitMaxDistance = ConfigCommonParamById.GetIntConfig("npc_headinfo_limit_max_distance").GetValueOrDefault();
			this.NpcIconHeadInfoLimitMaxDistanceSquaredInternal = this.NpcIconHeadInfoLimitMaxDistance * this.NpcIconHeadInfoLimitMaxDistance;
		}
		return this.NpcIconHeadInfoLimitMaxDistance;
	}

	// Token: 0x0600ED2A RID: 60714 RVA: 0x00459230 File Offset: 0x00457430
	public int GetNpcIconHeadInfoNameLimitDistance()
	{
		if (this.NpcIconHeadInfoNameLimitDistance == -1)
		{
			this.NpcIconHeadInfoNameLimitDistance = ConfigCommonParamById.GetIntConfig("npc_headinfo_name_limit_distance").GetValueOrDefault();
		}
		return this.NpcIconHeadInfoNameLimitDistance;
	}

	// Token: 0x0600ED2B RID: 60715 RVA: 0x00459264 File Offset: 0x00457464
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

	// Token: 0x0600ED2C RID: 60716 RVA: 0x004592B8 File Offset: 0x004574B8
	public int GetPlayerInfoIconLocationOffsetZ()
	{
		if (this.PlayerInfoIconLocationOffsetZ == -1)
		{
			this.PlayerInfoIconLocationOffsetZ = ConfigCommonParamById.GetIntConfig("OnlinePlayerNameZOffset").GetValueOrDefault();
		}
		return this.PlayerInfoIconLocationOffsetZ;
	}

	// Token: 0x0600ED2D RID: 60717 RVA: 0x004592EC File Offset: 0x004574EC
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

	// Token: 0x0600ED2E RID: 60718 RVA: 0x00459334 File Offset: 0x00457534
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

	// Token: 0x0600ED2F RID: 60719 RVA: 0x0045937B File Offset: 0x0045757B
	protected override bool OnClear()
	{
		this.NpcIconConfigMap.Clear();
		this.NpcIconSocketName = null;
		this.HeadStateScaleCurve = null;
		this.DialogScaleCurve = null;
		return true;
	}

	// Token: 0x1700168B RID: 5771
	// (get) Token: 0x0600ED30 RID: 60720 RVA: 0x0045939E File Offset: 0x0045759E
	public static NpcIconConfig Instance
	{
		get
		{
			return NpcIconConfig._Instance;
		}
	}

	// Token: 0x0600ED31 RID: 60721 RVA: 0x004593A5 File Offset: 0x004575A5
	public static NpcIconConfig GetOrCreateInstance()
	{
		if (NpcIconConfig._Instance == null)
		{
			NpcIconConfig.CreateInstance();
		}
		return NpcIconConfig._Instance;
	}

	// Token: 0x0600ED32 RID: 60722 RVA: 0x004593B9 File Offset: 0x004575B9
	public static bool CreateInstance()
	{
		if (NpcIconConfig._Instance != null)
		{
			return true;
		}
		NpcIconConfig._Instance = new NpcIconConfig();
		return true;
	}

	// Token: 0x0600ED33 RID: 60723 RVA: 0x004593CF File Offset: 0x004575CF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600ED34 RID: 60724 RVA: 0x004593D1 File Offset: 0x004575D1
	public static void ResetStaticDefaultValue()
	{
		NpcIconConfig._Instance = null;
	}

	// Token: 0x0600ED35 RID: 60725 RVA: 0x004593D9 File Offset: 0x004575D9
	static NpcIconConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NpcIconConfig.CreateStaticDefaultValue), new Action(NpcIconConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400866C RID: 34412
	private readonly Dictionary<int, NpcHeadInfo> NpcIconConfigMap = new Dictionary<int, NpcHeadInfo>();

	// Token: 0x0400866D RID: 34413
	[Nullable(2)]
	private UCurveFloat HeadStateScaleCurve;

	// Token: 0x0400866E RID: 34414
	[Nullable(2)]
	private UCurveFloat DialogScaleCurve;

	// Token: 0x0400866F RID: 34415
	[Nullable(2)]
	private string NpcIconSocketName = "";

	// Token: 0x04008670 RID: 34416
	private int NpcIconLocationOffsetZ = -1;

	// Token: 0x04008671 RID: 34417
	private int NpcIconHeadInfoLimitMinDistance = -1;

	// Token: 0x04008672 RID: 34418
	private int NpcIconHeadInfoLimitMinDistanceSquaredInternal;

	// Token: 0x04008673 RID: 34419
	private int NpcIconHeadInfoLimitMaxDistance = -1;

	// Token: 0x04008674 RID: 34420
	private int NpcIconHeadInfoLimitMaxDistanceSquaredInternal;

	// Token: 0x04008675 RID: 34421
	private int NpcIconHeadInfoNameLimitDistance = -1;

	// Token: 0x04008676 RID: 34422
	private int PlayerInfoIconLocationOffsetZ = -1;

	// Token: 0x04008677 RID: 34423
	private int PlayerInfoNameLimitDistance = -1;

	// Token: 0x04008678 RID: 34424
	private int PlayerInfoIconLimitDistance = -1;

	// Token: 0x04008679 RID: 34425
	[Nullable(2)]
	private static NpcIconConfig _Instance;
}
