using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;

// Token: 0x02002A7C RID: 10876
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SoundAreaPlayTipsModel : ModelBase
{
	// Token: 0x06016A51 RID: 92753 RVA: 0x005BCCA9 File Offset: 0x005BAEA9
	protected override bool OnLeaveLevel()
	{
		this.CurrentLevelShowInfoIdCountMap.Clear();
		return true;
	}

	// Token: 0x06016A52 RID: 92754 RVA: 0x005BCCB8 File Offset: 0x005BAEB8
	private int GetInfoIdCountType(int infoId)
	{
		SoundAreaPlayInfo? config = ConfigSoundAreaPlayInfoById.GetConfig(infoId, true);
		if (config == null)
		{
			return 0;
		}
		return config.GetValueOrDefault().MaxCountType;
	}

	// Token: 0x06016A53 RID: 92755 RVA: 0x005BCCE8 File Offset: 0x005BAEE8
	public void AddShowInfoIdCount(int infoId)
	{
		int infoIdCountType = this.GetInfoIdCountType(infoId);
		if (infoIdCountType == 0)
		{
			Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.SilentTips, null) ?? new Dictionary<int, int>();
			int num;
			dictionary.TryGetValue(infoId, out num);
			num++;
			dictionary[infoId] = num;
			LocalStorage.SetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.SilentTips, dictionary);
			return;
		}
		if (infoIdCountType == 1)
		{
			int num2;
			this.CurrentLevelShowInfoIdCountMap.TryGetValue(infoId, out num2);
			num2++;
			this.CurrentLevelShowInfoIdCountMap[infoId] = num2;
		}
	}

	// Token: 0x06016A54 RID: 92756 RVA: 0x005BCD58 File Offset: 0x005BAF58
	public int GetInfoIdShowCount(int infoId)
	{
		SoundAreaPlayInfo? config = ConfigSoundAreaPlayInfoById.GetConfig(infoId, true);
		int infoIdCountType = this.GetInfoIdCountType(infoId);
		if (config != null && config.GetValueOrDefault().MaxCount > 0)
		{
			if (infoIdCountType == 0)
			{
				int result;
				(LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.SilentTips, null) ?? new Dictionary<int, int>()).TryGetValue(infoId, out result);
				return result;
			}
			if (infoIdCountType == 1)
			{
				int result2;
				this.CurrentLevelShowInfoIdCountMap.TryGetValue(infoId, out result2);
				return result2;
			}
		}
		return 0;
	}

	// Token: 0x06016A55 RID: 92757 RVA: 0x005BCDCC File Offset: 0x005BAFCC
	public bool CheckInfoIdCanShow(int infoId)
	{
		SoundAreaPlayInfo? config = ConfigSoundAreaPlayInfoById.GetConfig(infoId, true);
		return config == null || config.GetValueOrDefault().MaxCount <= 0 || this.GetInfoIdShowCount(infoId) < config.Value.MaxCount;
	}

	// Token: 0x17001E16 RID: 7702
	// (get) Token: 0x06016A56 RID: 92758 RVA: 0x005BCE1C File Offset: 0x005BB01C
	public static SoundAreaPlayTipsModel Instance
	{
		get
		{
			return SoundAreaPlayTipsModel._Instance;
		}
	}

	// Token: 0x06016A57 RID: 92759 RVA: 0x005BCE23 File Offset: 0x005BB023
	public static SoundAreaPlayTipsModel GetOrCreateInstance()
	{
		if (SoundAreaPlayTipsModel._Instance == null)
		{
			SoundAreaPlayTipsModel.CreateInstance();
		}
		return SoundAreaPlayTipsModel._Instance;
	}

	// Token: 0x06016A58 RID: 92760 RVA: 0x005BCE37 File Offset: 0x005BB037
	public static bool CreateInstance()
	{
		if (SoundAreaPlayTipsModel._Instance != null)
		{
			return true;
		}
		SoundAreaPlayTipsModel._Instance = new SoundAreaPlayTipsModel();
		return true;
	}

	// Token: 0x06016A59 RID: 92761 RVA: 0x005BCE4D File Offset: 0x005BB04D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016A5A RID: 92762 RVA: 0x005BCE4F File Offset: 0x005BB04F
	public static void ResetStaticDefaultValue()
	{
		SoundAreaPlayTipsModel._Instance = null;
	}

	// Token: 0x06016A5B RID: 92763 RVA: 0x005BCE57 File Offset: 0x005BB057
	static SoundAreaPlayTipsModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SoundAreaPlayTipsModel.CreateStaticDefaultValue), new Action(SoundAreaPlayTipsModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A818 RID: 43032
	private readonly Dictionary<int, int> CurrentLevelShowInfoIdCountMap = new Dictionary<int, int>();

	// Token: 0x0400A819 RID: 43033
	[Nullable(2)]
	private static SoundAreaPlayTipsModel _Instance;
}
