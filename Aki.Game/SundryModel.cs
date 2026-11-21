using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200202F RID: 8239
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SundryModel : ModelBase
{
	// Token: 0x06014655 RID: 83541 RVA: 0x005F3E63 File Offset: 0x005F2063
	public void SetBlockTpDungeon(bool bBlock, SundryModel.EBlockTpDungeonReason reason)
	{
		if (bBlock)
		{
			this.BlockTpDungeonSet.Add(reason);
			return;
		}
		this.BlockTpDungeonSet.Remove(reason);
	}

	// Token: 0x06014656 RID: 83542 RVA: 0x005F3E83 File Offset: 0x005F2083
	public void ForceSetBlockTpDungeon(bool bBlock)
	{
		if (bBlock)
		{
			this.BlockTpDungeonSet.Add(SundryModel.EBlockTpDungeonReason.ForceBlock);
			return;
		}
		this.BlockTpDungeonSet.Clear();
	}

	// Token: 0x06014657 RID: 83543 RVA: 0x005F3EA1 File Offset: 0x005F20A1
	public bool IsBlockTpDungeon()
	{
		return this.BlockTpDungeonSet.Count > 0;
	}

	// Token: 0x06014658 RID: 83544 RVA: 0x005F3EB1 File Offset: 0x005F20B1
	public bool HasBlockTpDungeonReason(SundryModel.EBlockTpDungeonReason reason)
	{
		return this.BlockTpDungeonSet.Contains(reason);
	}

	// Token: 0x06014659 RID: 83545 RVA: 0x005F3EBF File Offset: 0x005F20BF
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

	// Token: 0x0601465A RID: 83546 RVA: 0x005F3EF4 File Offset: 0x005F20F4
	public int GetModuleDebugLevel(string key)
	{
		int result;
		if (!this.ModuleDebugLevelMap.TryGetValue(key, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x0601465B RID: 83547 RVA: 0x005F3F14 File Offset: 0x005F2114
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x17001EA3 RID: 7843
	// (get) Token: 0x0601465C RID: 83548 RVA: 0x005F3F17 File Offset: 0x005F2117
	public static SundryModel Instance
	{
		get
		{
			return SundryModel._Instance;
		}
	}

	// Token: 0x0601465D RID: 83549 RVA: 0x005F3F1E File Offset: 0x005F211E
	public static SundryModel GetOrCreateInstance()
	{
		if (SundryModel._Instance == null)
		{
			SundryModel.CreateInstance();
		}
		return SundryModel._Instance;
	}

	// Token: 0x0601465E RID: 83550 RVA: 0x005F3F32 File Offset: 0x005F2132
	public static bool CreateInstance()
	{
		if (SundryModel._Instance != null)
		{
			return true;
		}
		SundryModel._Instance = new SundryModel();
		return true;
	}

	// Token: 0x0601465F RID: 83551 RVA: 0x005F3F48 File Offset: 0x005F2148
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014660 RID: 83552 RVA: 0x005F3F4A File Offset: 0x005F214A
	public static void ResetStaticDefaultValue()
	{
		SundryModel._Instance = null;
	}

	// Token: 0x06014661 RID: 83553 RVA: 0x005F3F52 File Offset: 0x005F2152
	static SundryModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SundryModel.CreateStaticDefaultValue), new Action(SundryModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400ACF9 RID: 44281
	public int AccountGmId;

	// Token: 0x0400ACFA RID: 44282
	public bool SceneCheckOn;

	// Token: 0x0400ACFB RID: 44283
	public bool RoleMoveDebugLogOn;

	// Token: 0x0400ACFC RID: 44284
	public bool RoleFallingDebugLogOn;

	// Token: 0x0400ACFD RID: 44285
	public string GuideTriggerName = "";

	// Token: 0x0400ACFE RID: 44286
	public bool GmBlueprintGmIsOpen;

	// Token: 0x0400ACFF RID: 44287
	public bool GmBlueprintGmWinDebugIsOpen;

	// Token: 0x0400AD00 RID: 44288
	public bool CurrentGmRunState;

	// Token: 0x0400AD01 RID: 44289
	public string RunningGmName = "";

	// Token: 0x0400AD02 RID: 44290
	public bool CanOpenGmView;

	// Token: 0x0400AD03 RID: 44291
	public bool IsBlockTips;

	// Token: 0x0400AD04 RID: 44292
	private readonly HashSet<SundryModel.EBlockTpDungeonReason> BlockTpDungeonSet = new HashSet<SundryModel.EBlockTpDungeonReason>();

	// Token: 0x0400AD05 RID: 44293
	public Dictionary<string, int> ModuleDebugLevelMap = new Dictionary<string, int>();

	// Token: 0x0400AD06 RID: 44294
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, TipsActorData> TipsActorDataMap;

	// Token: 0x0400AD07 RID: 44295
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, TipsSplineActorData> TipsSplineActorDataMap;

	// Token: 0x0400AD08 RID: 44296
	[Nullable(2)]
	private static SundryModel _Instance;

	// Token: 0x02008329 RID: 33577
	[NullableContext(0)]
	public enum ELogVerbosity
	{
		// Token: 0x0402A618 RID: 173592
		NoLogging,
		// Token: 0x0402A619 RID: 173593
		Fatal,
		// Token: 0x0402A61A RID: 173594
		Error,
		// Token: 0x0402A61B RID: 173595
		Warning,
		// Token: 0x0402A61C RID: 173596
		Display,
		// Token: 0x0402A61D RID: 173597
		Log,
		// Token: 0x0402A61E RID: 173598
		Verbose,
		// Token: 0x0402A61F RID: 173599
		VeryVerbose
	}

	// Token: 0x0200832A RID: 33578
	[NullableContext(0)]
	public enum EBlockTpDungeonReason
	{
		// Token: 0x0402A621 RID: 173601
		GmAutoRun,
		// Token: 0x0402A622 RID: 173602
		EditorStartConfig,
		// Token: 0x0402A623 RID: 173603
		ForceBlock
	}
}
