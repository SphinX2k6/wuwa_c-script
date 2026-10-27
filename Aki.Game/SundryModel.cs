using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002AB3 RID: 10931
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SundryModel : ModelBase
{
	// Token: 0x06016C24 RID: 93220 RVA: 0x005C730F File Offset: 0x005C550F
	public void SetBlockTpDungeon(bool bBlock, SundryModel.EBlockTpDungeonReason reason)
	{
		if (bBlock)
		{
			this.BlockTpDungeonSet.Add(reason);
			return;
		}
		this.BlockTpDungeonSet.Remove(reason);
	}

	// Token: 0x06016C25 RID: 93221 RVA: 0x005C732F File Offset: 0x005C552F
	public void ForceSetBlockTpDungeon(bool bBlock)
	{
		if (bBlock)
		{
			this.BlockTpDungeonSet.Add(SundryModel.EBlockTpDungeonReason.ForceBlock);
			return;
		}
		this.BlockTpDungeonSet.Clear();
	}

	// Token: 0x06016C26 RID: 93222 RVA: 0x005C734D File Offset: 0x005C554D
	public bool IsBlockTpDungeon()
	{
		return this.BlockTpDungeonSet.Count > 0;
	}

	// Token: 0x06016C27 RID: 93223 RVA: 0x005C735D File Offset: 0x005C555D
	public bool HasBlockTpDungeonReason(SundryModel.EBlockTpDungeonReason reason)
	{
		return this.BlockTpDungeonSet.Contains(reason);
	}

	// Token: 0x06016C28 RID: 93224 RVA: 0x005C736B File Offset: 0x005C556B
	public void ChangeModuleDebugLevel(string key, int level)
	{
		if (level > 0)
		{
			this.ModuleDebugLevelMap[key] = level;
		}
		else
		{
			this.ModuleDebugLevelMap.Remove(key);
		}
		EventSystem.Instance.Emit<string, int>(EEventName.OnChangeModuleDebugLevel, key, level);
	}

	// Token: 0x06016C29 RID: 93225 RVA: 0x005C73A0 File Offset: 0x005C55A0
	public int GetModuleDebugLevel(string key)
	{
		int result;
		if (!this.ModuleDebugLevelMap.TryGetValue(key, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x06016C2A RID: 93226 RVA: 0x005C73C0 File Offset: 0x005C55C0
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x17001E4B RID: 7755
	// (get) Token: 0x06016C2B RID: 93227 RVA: 0x005C73C3 File Offset: 0x005C55C3
	public static SundryModel Instance
	{
		get
		{
			return SundryModel._Instance;
		}
	}

	// Token: 0x06016C2C RID: 93228 RVA: 0x005C73CA File Offset: 0x005C55CA
	public static SundryModel GetOrCreateInstance()
	{
		if (SundryModel._Instance == null)
		{
			SundryModel.CreateInstance();
		}
		return SundryModel._Instance;
	}

	// Token: 0x06016C2D RID: 93229 RVA: 0x005C73DE File Offset: 0x005C55DE
	public static bool CreateInstance()
	{
		if (SundryModel._Instance != null)
		{
			return true;
		}
		SundryModel._Instance = new SundryModel();
		return true;
	}

	// Token: 0x06016C2E RID: 93230 RVA: 0x005C73F4 File Offset: 0x005C55F4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016C2F RID: 93231 RVA: 0x005C73F6 File Offset: 0x005C55F6
	public static void ResetStaticDefaultValue()
	{
		SundryModel._Instance = null;
	}

	// Token: 0x06016C30 RID: 93232 RVA: 0x005C73FE File Offset: 0x005C55FE
	static SundryModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SundryModel.CreateStaticDefaultValue), new Action(SundryModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A8F3 RID: 43251
	public int AccountGmId;

	// Token: 0x0400A8F4 RID: 43252
	public bool SceneCheckOn;

	// Token: 0x0400A8F5 RID: 43253
	public bool RoleMoveDebugLogOn;

	// Token: 0x0400A8F6 RID: 43254
	public bool RoleFallingDebugLogOn;

	// Token: 0x0400A8F7 RID: 43255
	public string GuideTriggerName = "";

	// Token: 0x0400A8F8 RID: 43256
	public bool GmBlueprintGmIsOpen;

	// Token: 0x0400A8F9 RID: 43257
	public bool GmBlueprintGmWinDebugIsOpen;

	// Token: 0x0400A8FA RID: 43258
	public bool CurrentGmRunState;

	// Token: 0x0400A8FB RID: 43259
	public string RunningGmName = "";

	// Token: 0x0400A8FC RID: 43260
	public bool CanOpenGmView;

	// Token: 0x0400A8FD RID: 43261
	public bool IsBlockTips;

	// Token: 0x0400A8FE RID: 43262
	private readonly HashSet<SundryModel.EBlockTpDungeonReason> BlockTpDungeonSet = new HashSet<SundryModel.EBlockTpDungeonReason>();

	// Token: 0x0400A8FF RID: 43263
	public Dictionary<string, int> ModuleDebugLevelMap = new Dictionary<string, int>();

	// Token: 0x0400A900 RID: 43264
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, TipsActorData> TipsActorDataMap;

	// Token: 0x0400A901 RID: 43265
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, TipsSplineActorData> TipsSplineActorDataMap;

	// Token: 0x0400A902 RID: 43266
	[Nullable(2)]
	private static SundryModel _Instance;

	// Token: 0x020090E5 RID: 37093
	[NullableContext(0)]
	public enum ELogVerbosity
	{
		// Token: 0x0402EF12 RID: 192274
		NoLogging,
		// Token: 0x0402EF13 RID: 192275
		Fatal,
		// Token: 0x0402EF14 RID: 192276
		Error,
		// Token: 0x0402EF15 RID: 192277
		Warning,
		// Token: 0x0402EF16 RID: 192278
		Display,
		// Token: 0x0402EF17 RID: 192279
		Log,
		// Token: 0x0402EF18 RID: 192280
		Verbose,
		// Token: 0x0402EF19 RID: 192281
		VeryVerbose
	}

	// Token: 0x020090E6 RID: 37094
	[NullableContext(0)]
	public enum EBlockTpDungeonReason
	{
		// Token: 0x0402EF1B RID: 192283
		GmAutoRun,
		// Token: 0x0402EF1C RID: 192284
		EditorStartConfig,
		// Token: 0x0402EF1D RID: 192285
		ForceBlock
	}
}
