using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200222C RID: 8748
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class MotionConfig : ConfigBase
{
	// Token: 0x060110F9 RID: 69881 RVA: 0x00428E39 File Offset: 0x00427039
	public Motion? GetMotionConfig(int id)
	{
		return ConfigMotionById.GetConfig(id, true);
	}

	// Token: 0x060110FA RID: 69882 RVA: 0x00428E42 File Offset: 0x00427042
	public IReadOnlyList<Motion> GetMotionConfigsByRoleId(int roleId)
	{
		return ConfigMotionByRoleId.GetConfigList(roleId, true);
	}

	// Token: 0x060110FB RID: 69883 RVA: 0x00428E4B File Offset: 0x0042704B
	public IReadOnlyList<Motion> GetRoleMotionByRoleSkinId(int roleSkinId)
	{
		return ConfigMotionBySkinId.GetConfigList(roleSkinId, true);
	}

	// Token: 0x060110FC RID: 69884 RVA: 0x00428E54 File Offset: 0x00427054
	public IReadOnlyList<Motion> GetRoleMotionByType(int roleId, int type)
	{
		return ConfigMotionByRoleIdAndType.GetConfigList(roleId, type, true);
	}

	// Token: 0x060110FD RID: 69885 RVA: 0x00428E60 File Offset: 0x00427060
	public Motion? GetPerformanceMotionConfigByPosition(int skinId, int position)
	{
		IReadOnlyList<Motion> configList = ConfigMotionBySkinIdAndType.GetConfigList(skinId, 2, true);
		if (configList == null)
		{
			return null;
		}
		foreach (Motion value in configList)
		{
			if (value.Sort == position)
			{
				return new Motion?(value);
			}
		}
		return null;
	}

	// Token: 0x060110FE RID: 69886 RVA: 0x00428ED8 File Offset: 0x004270D8
	public string GetMotionTitle(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return ConfigMultiTextLang.GetLocalTextNew(motionConfig.Value.Title, null);
	}

	// Token: 0x060110FF RID: 69887 RVA: 0x00428F10 File Offset: 0x00427110
	public string GetMotionContent(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return ConfigMultiTextLang.GetLocalTextNew(motionConfig.Value.Content, null);
	}

	// Token: 0x06011100 RID: 69888 RVA: 0x00428F48 File Offset: 0x00427148
	public int? GetMotionUnLockConditionGroup(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return new int?(motionConfig.Value.CondGroupId);
	}

	// Token: 0x06011101 RID: 69889 RVA: 0x00428F84 File Offset: 0x00427184
	public int? GetMotionRoleId(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return new int?(motionConfig.Value.RoleId);
	}

	// Token: 0x06011102 RID: 69890 RVA: 0x00428FC0 File Offset: 0x004271C0
	public int? GetMotionType(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return new int?(motionConfig.Value.Type);
	}

	// Token: 0x06011103 RID: 69891 RVA: 0x00428FFC File Offset: 0x004271FC
	public int? GetMotionSort(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return new int?(motionConfig.Value.Sort);
	}

	// Token: 0x06011104 RID: 69892 RVA: 0x00429038 File Offset: 0x00427238
	public string GetMotionImg(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return motionConfig.Value.MotionImg;
	}

	// Token: 0x06011105 RID: 69893 RVA: 0x00429068 File Offset: 0x00427268
	public string GetMotionAnimation(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return motionConfig.Value.AniMontage;
	}

	// Token: 0x170015AB RID: 5547
	// (get) Token: 0x06011106 RID: 69894 RVA: 0x00429097 File Offset: 0x00427297
	[Nullable(1)]
	public static MotionConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return MotionConfig._Instance;
		}
	}

	// Token: 0x06011107 RID: 69895 RVA: 0x0042909E File Offset: 0x0042729E
	[NullableContext(1)]
	public static MotionConfig GetOrCreateInstance()
	{
		if (MotionConfig._Instance == null)
		{
			MotionConfig.CreateInstance();
		}
		return MotionConfig._Instance;
	}

	// Token: 0x06011108 RID: 69896 RVA: 0x004290B2 File Offset: 0x004272B2
	public static bool CreateInstance()
	{
		if (MotionConfig._Instance != null)
		{
			return true;
		}
		MotionConfig._Instance = new MotionConfig();
		return true;
	}

	// Token: 0x06011109 RID: 69897 RVA: 0x004290C8 File Offset: 0x004272C8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601110A RID: 69898 RVA: 0x004290CA File Offset: 0x004272CA
	public static void ResetStaticDefaultValue()
	{
		MotionConfig._Instance = null;
	}

	// Token: 0x0601110B RID: 69899 RVA: 0x004290D2 File Offset: 0x004272D2
	static MotionConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotionConfig.CreateStaticDefaultValue), new Action(MotionConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04008211 RID: 33297
	private static MotionConfig _Instance;
}
