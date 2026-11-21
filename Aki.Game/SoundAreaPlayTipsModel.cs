using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;

// Token: 0x02001FF8 RID: 8184
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SoundAreaPlayTipsModel : ModelBase
{
	// Token: 0x06014476 RID: 83062 RVA: 0x005E8ED9 File Offset: 0x005E70D9
	protected override bool OnLeaveLevel()
	{
		this.CurrentLevelShowInfoIdCountMap.Clear();
		return true;
	}

	// Token: 0x06014477 RID: 83063 RVA: 0x005E8EE8 File Offset: 0x005E70E8
	private int GetInfoIdCountType(int infoId)
	{
		SoundAreaPlayInfo? config = ConfigSoundAreaPlayInfoById.GetConfig(infoId, true);
		if (config == null)
		{
			return 0;
		}
		return config.GetValueOrDefault().MaxCountType;
	}

	// Token: 0x06014478 RID: 83064 RVA: 0x005E8F18 File Offset: 0x005E7118
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

	// Token: 0x06014479 RID: 83065 RVA: 0x005E8F88 File Offset: 0x005E7188
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

	// Token: 0x0601447A RID: 83066 RVA: 0x005E8FFC File Offset: 0x005E71FC
	public bool CheckInfoIdCanShow(int infoId)
	{
		SoundAreaPlayInfo? config = ConfigSoundAreaPlayInfoById.GetConfig(infoId, true);
		return config == null || config.GetValueOrDefault().MaxCount <= 0 || this.GetInfoIdShowCount(infoId) < config.Value.MaxCount;
	}

	// Token: 0x17001E6E RID: 7790
	// (get) Token: 0x0601447B RID: 83067 RVA: 0x005E904C File Offset: 0x005E724C
	public static SoundAreaPlayTipsModel Instance
	{
		get
		{
			return SoundAreaPlayTipsModel._Instance;
		}
	}

	// Token: 0x0601447C RID: 83068 RVA: 0x005E9053 File Offset: 0x005E7253
	public static SoundAreaPlayTipsModel GetOrCreateInstance()
	{
		if (SoundAreaPlayTipsModel._Instance == null)
		{
			SoundAreaPlayTipsModel.CreateInstance();
		}
		return SoundAreaPlayTipsModel._Instance;
	}

	// Token: 0x0601447D RID: 83069 RVA: 0x005E9067 File Offset: 0x005E7267
	public static bool CreateInstance()
	{
		if (SoundAreaPlayTipsModel._Instance != null)
		{
			return true;
		}
		SoundAreaPlayTipsModel._Instance = new SoundAreaPlayTipsModel();
		return true;
	}

	// Token: 0x0601447E RID: 83070 RVA: 0x005E907D File Offset: 0x005E727D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601447F RID: 83071 RVA: 0x005E907F File Offset: 0x005E727F
	public static void ResetStaticDefaultValue()
	{
		SoundAreaPlayTipsModel._Instance = null;
	}

	// Token: 0x06014480 RID: 83072 RVA: 0x005E9087 File Offset: 0x005E7287
	static SoundAreaPlayTipsModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SoundAreaPlayTipsModel.CreateStaticDefaultValue), new Action(SoundAreaPlayTipsModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400AC1D RID: 44061
	private readonly Dictionary<int, int> CurrentLevelShowInfoIdCountMap = new Dictionary<int, int>();

	// Token: 0x0400AC1E RID: 44062
	[Nullable(2)]
	private static SoundAreaPlayTipsModel _Instance;
}
