using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001710 RID: 5904
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class MotionConfig : ConfigBase
{
	// Token: 0x0600E58F RID: 58767 RVA: 0x004359DD File Offset: 0x00433BDD
	public Motion? GetMotionConfig(int id)
	{
		return ConfigMotionById.GetConfig(id, true);
	}

	// Token: 0x0600E590 RID: 58768 RVA: 0x004359E6 File Offset: 0x00433BE6
	public IReadOnlyList<Motion> GetMotionConfigsByRoleId(int roleId)
	{
		return ConfigMotionByRoleId.GetConfigList(roleId, true);
	}

	// Token: 0x0600E591 RID: 58769 RVA: 0x004359EF File Offset: 0x00433BEF
	public IReadOnlyList<Motion> GetRoleMotionByRoleSkinId(int roleSkinId)
	{
		return ConfigMotionBySkinId.GetConfigList(roleSkinId, true);
	}

	// Token: 0x0600E592 RID: 58770 RVA: 0x004359F8 File Offset: 0x00433BF8
	public IReadOnlyList<Motion> GetRoleMotionByType(int roleId, int type)
	{
		return ConfigMotionByRoleIdAndType.GetConfigList(roleId, type, true);
	}

	// Token: 0x0600E593 RID: 58771 RVA: 0x00435A04 File Offset: 0x00433C04
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

	// Token: 0x0600E594 RID: 58772 RVA: 0x00435A7C File Offset: 0x00433C7C
	public string GetMotionTitle(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return ConfigMultiTextLang.GetLocalTextNew(motionConfig.Value.Title, null);
	}

	// Token: 0x0600E595 RID: 58773 RVA: 0x00435AB4 File Offset: 0x00433CB4
	public string GetMotionContent(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return ConfigMultiTextLang.GetLocalTextNew(motionConfig.Value.Content, null);
	}

	// Token: 0x0600E596 RID: 58774 RVA: 0x00435AEC File Offset: 0x00433CEC
	public int? GetMotionUnLockConditionGroup(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return new int?(motionConfig.Value.CondGroupId);
	}

	// Token: 0x0600E597 RID: 58775 RVA: 0x00435B28 File Offset: 0x00433D28
	public int? GetMotionRoleId(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return new int?(motionConfig.Value.RoleId);
	}

	// Token: 0x0600E598 RID: 58776 RVA: 0x00435B64 File Offset: 0x00433D64
	public int? GetMotionType(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return new int?(motionConfig.Value.Type);
	}

	// Token: 0x0600E599 RID: 58777 RVA: 0x00435BA0 File Offset: 0x00433DA0
	public int? GetMotionSort(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return new int?(motionConfig.Value.Sort);
	}

	// Token: 0x0600E59A RID: 58778 RVA: 0x00435BDC File Offset: 0x00433DDC
	public string GetMotionImg(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return motionConfig.Value.MotionImg;
	}

	// Token: 0x0600E59B RID: 58779 RVA: 0x00435C0C File Offset: 0x00433E0C
	public string GetMotionAnimation(int id)
	{
		Motion? motionConfig = this.GetMotionConfig(id);
		if (motionConfig == null)
		{
			return null;
		}
		return motionConfig.Value.AniMontage;
	}

	// Token: 0x170015E2 RID: 5602
	// (get) Token: 0x0600E59C RID: 58780 RVA: 0x00435C3B File Offset: 0x00433E3B
	[Nullable(1)]
	public static MotionConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return MotionConfig._Instance;
		}
	}

	// Token: 0x0600E59D RID: 58781 RVA: 0x00435C42 File Offset: 0x00433E42
	[NullableContext(1)]
	public static MotionConfig GetOrCreateInstance()
	{
		if (MotionConfig._Instance == null)
		{
			MotionConfig.CreateInstance();
		}
		return MotionConfig._Instance;
	}

	// Token: 0x0600E59E RID: 58782 RVA: 0x00435C56 File Offset: 0x00433E56
	public static bool CreateInstance()
	{
		if (MotionConfig._Instance != null)
		{
			return true;
		}
		MotionConfig._Instance = new MotionConfig();
		return true;
	}

	// Token: 0x0600E59F RID: 58783 RVA: 0x00435C6C File Offset: 0x00433E6C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E5A0 RID: 58784 RVA: 0x00435C6E File Offset: 0x00433E6E
	public static void ResetStaticDefaultValue()
	{
		MotionConfig._Instance = null;
	}

	// Token: 0x0600E5A1 RID: 58785 RVA: 0x00435C76 File Offset: 0x00433E76
	static MotionConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotionConfig.CreateStaticDefaultValue), new Action(MotionConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400834F RID: 33615
	private static MotionConfig _Instance;
}
