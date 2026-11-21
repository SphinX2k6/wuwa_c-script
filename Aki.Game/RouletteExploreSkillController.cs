using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Vision;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.QuestMultiLine;
using Cysharp.Threading.Tasks;

// Token: 0x02001E9E RID: 7838
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RouletteExploreSkillController : ControllerBase
{
	// Token: 0x060135CB RID: 79307 RVA: 0x005A6B80 File Offset: 0x005A4D80
	public void UseRouletteExploreId(ERouletteExploreId exploreId)
	{
		if (!RouletteModel.Instance.GetCurrentExploreRouletteListData().IsExploreSkillIdAllowEquip((int)exploreId))
		{
			return;
		}
		SVisionData visionData = PhantomUtil.GetVisionData((int)exploreId);
		if (visionData == null)
		{
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || getCurrentEntity.Entity == null)
		{
			return;
		}
		if (this.UseExploreSkillId(getCurrentEntity.Id, visionData.技能ID))
		{
			RouletteModel.Instance.TrySendExploreToolGeneralUseLogData((int)exploreId, 0, 0);
		}
	}

	// Token: 0x060135CC RID: 79308 RVA: 0x005A6BEC File Offset: 0x005A4DEC
	public bool UseExploreSkillId(int entityId, int skillId)
	{
		Action<int, int> action;
		if (this.RouletteExploreSkillUseWayMap.TryGetValue((ERouletteSkillId)skillId, out action))
		{
			action(entityId, skillId);
			return true;
		}
		return false;
	}

	// Token: 0x060135CD RID: 79309 RVA: 0x005A6C14 File Offset: 0x005A4E14
	private static void OnUseEquipItem(int entityId, int skillId)
	{
		RouletteController.Instance.OnUseEquipItem();
	}

	// Token: 0x060135CE RID: 79310 RVA: 0x005A6C20 File Offset: 0x005A4E20
	private static void OpenEmptyTips(int entityId, int skillId)
	{
		RouletteController.Instance.OpenEmptyTips();
	}

	// Token: 0x060135CF RID: 79311 RVA: 0x005A6C2C File Offset: 0x005A4E2C
	private static void UseMapExploreTool(int entityId, int skillId)
	{
		MapExploreToolController.Instance.CheckUseMapExploreTool(entityId, skillId);
	}

	// Token: 0x060135D0 RID: 79312 RVA: 0x005A6C3A File Offset: 0x005A4E3A
	private static void OpenAdviceCreateView(int entityId, int skillId)
	{
		AdviceController.Instance.OpenAdviceCreateView();
	}

	// Token: 0x060135D1 RID: 79313 RVA: 0x005A6C46 File Offset: 0x005A4E46
	private static void PhotographFastScreenShot(int entityId, int skillId)
	{
		PhotographController.Instance.PhotographFastScreenShot(ECameraCaptureType.NormalCamera);
	}

	// Token: 0x060135D2 RID: 79314 RVA: 0x005A6C53 File Offset: 0x005A4E53
	private static void OpenFightPhotograph(int entityId, int skillId)
	{
		PhotographController.Instance.TryOpenPhotograph(ECameraCaptureType.FightPhotographCamera);
	}

	// Token: 0x060135D3 RID: 79315 RVA: 0x005A6C61 File Offset: 0x005A4E61
	private static void EnterMotorAutoPilot(int entityId, int skillId)
	{
		AutoPilotController.Instance.EnterAutoPilot().Forget<bool>();
	}

	// Token: 0x060135D4 RID: 79316 RVA: 0x005A6C72 File Offset: 0x005A4E72
	private static void SummonMotorAndEnterAutoPilot(int entityId, int skillId)
	{
		AutoPilotController.Instance.SummonMotorAndEnterAutoPilot();
	}

	// Token: 0x060135D5 RID: 79317 RVA: 0x005A6C7E File Offset: 0x005A4E7E
	private static void OpenMotorMusicPlayer(int entityId, int skillId)
	{
		MotorcycleMusicPlayerController.Instance.OpenMusicPlayerView();
	}

	// Token: 0x060135D6 RID: 79318 RVA: 0x005A6C8A File Offset: 0x005A4E8A
	private static void OpenPhantomSummonView(int entityId, int skillId)
	{
		PhantomInteractController.Instance.OpenPhantomVisionSummonView(entityId, skillId);
	}

	// Token: 0x060135D7 RID: 79319 RVA: 0x005A6C98 File Offset: 0x005A4E98
	private static void OpenMotorTechTreeSwitchView(int entityId, int skillId)
	{
		MotorcycleDevelopController.Instance.OpenMotorTechTreeSwitchView();
	}

	// Token: 0x060135D8 RID: 79320 RVA: 0x005A6CA4 File Offset: 0x005A4EA4
	private static void OpenQuestMultiLineView(int entityId, int skillId)
	{
		QuestMultiLineController.Instance.OpenQuestMultiLineView(0, false, false);
	}

	// Token: 0x17001D8C RID: 7564
	// (get) Token: 0x060135D9 RID: 79321 RVA: 0x005A6CB4 File Offset: 0x005A4EB4
	public static RouletteExploreSkillController Instance
	{
		get
		{
			return RouletteExploreSkillController._Instance;
		}
	}

	// Token: 0x060135DA RID: 79322 RVA: 0x005A6CBB File Offset: 0x005A4EBB
	public static RouletteExploreSkillController GetOrCreateInstance()
	{
		if (RouletteExploreSkillController._Instance == null)
		{
			RouletteExploreSkillController.CreateInstance();
		}
		return RouletteExploreSkillController._Instance;
	}

	// Token: 0x060135DB RID: 79323 RVA: 0x005A6CCF File Offset: 0x005A4ECF
	public static bool CreateInstance()
	{
		if (RouletteExploreSkillController._Instance != null)
		{
			return true;
		}
		RouletteExploreSkillController._Instance = new RouletteExploreSkillController();
		return true;
	}

	// Token: 0x060135DC RID: 79324 RVA: 0x005A6CE5 File Offset: 0x005A4EE5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060135DD RID: 79325 RVA: 0x005A6CE7 File Offset: 0x005A4EE7
	public static void ResetStaticDefaultValue()
	{
		RouletteExploreSkillController._Instance = null;
	}

	// Token: 0x060135DE RID: 79326 RVA: 0x005A6CEF File Offset: 0x005A4EEF
	static RouletteExploreSkillController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RouletteExploreSkillController.CreateStaticDefaultValue), new Action(RouletteExploreSkillController.ResetStaticDefaultValue));
	}

	// Token: 0x060135DF RID: 79327 RVA: 0x005A6D10 File Offset: 0x005A4F10
	public RouletteExploreSkillController()
	{
		Dictionary<ERouletteSkillId, Action<int, int>> dictionary = new Dictionary<ERouletteSkillId, Action<int, int>>();
		ERouletteSkillId key = ERouletteSkillId.道具装配;
		Action<int, int> value;
		if ((value = RouletteExploreSkillController.<>O.<0>__OnUseEquipItem) == null)
		{
			value = (RouletteExploreSkillController.<>O.<0>__OnUseEquipItem = new Action<int, int>(RouletteExploreSkillController.OnUseEquipItem));
		}
		dictionary.Add(key, value);
		ERouletteSkillId key2 = ERouletteSkillId.道具空置;
		Action<int, int> value2;
		if ((value2 = RouletteExploreSkillController.<>O.<1>__OpenEmptyTips) == null)
		{
			value2 = (RouletteExploreSkillController.<>O.<1>__OpenEmptyTips = new Action<int, int>(RouletteExploreSkillController.OpenEmptyTips));
		}
		dictionary.Add(key2, value2);
		ERouletteSkillId key3 = ERouletteSkillId.临时传送;
		Action<int, int> value3;
		if ((value3 = RouletteExploreSkillController.<>O.<2>__UseMapExploreTool) == null)
		{
			value3 = (RouletteExploreSkillController.<>O.<2>__UseMapExploreTool = new Action<int, int>(RouletteExploreSkillController.UseMapExploreTool));
		}
		dictionary.Add(key3, value3);
		ERouletteSkillId key4 = ERouletteSkillId.声匣探测;
		Action<int, int> value4;
		if ((value4 = RouletteExploreSkillController.<>O.<2>__UseMapExploreTool) == null)
		{
			value4 = (RouletteExploreSkillController.<>O.<2>__UseMapExploreTool = new Action<int, int>(RouletteExploreSkillController.UseMapExploreTool));
		}
		dictionary.Add(key4, value4);
		ERouletteSkillId key5 = ERouletteSkillId.物资探测;
		Action<int, int> value5;
		if ((value5 = RouletteExploreSkillController.<>O.<2>__UseMapExploreTool) == null)
		{
			value5 = (RouletteExploreSkillController.<>O.<2>__UseMapExploreTool = new Action<int, int>(RouletteExploreSkillController.UseMapExploreTool));
		}
		dictionary.Add(key5, value5);
		ERouletteSkillId key6 = ERouletteSkillId.溯言刻录;
		Action<int, int> value6;
		if ((value6 = RouletteExploreSkillController.<>O.<3>__OpenAdviceCreateView) == null)
		{
			value6 = (RouletteExploreSkillController.<>O.<3>__OpenAdviceCreateView = new Action<int, int>(RouletteExploreSkillController.OpenAdviceCreateView));
		}
		dictionary.Add(key6, value6);
		ERouletteSkillId key7 = ERouletteSkillId.影像速采;
		Action<int, int> value7;
		if ((value7 = RouletteExploreSkillController.<>O.<4>__PhotographFastScreenShot) == null)
		{
			value7 = (RouletteExploreSkillController.<>O.<4>__PhotographFastScreenShot = new Action<int, int>(RouletteExploreSkillController.PhotographFastScreenShot));
		}
		dictionary.Add(key7, value7);
		ERouletteSkillId key8 = ERouletteSkillId.时停相机;
		Action<int, int> value8;
		if ((value8 = RouletteExploreSkillController.<>O.<5>__OpenFightPhotograph) == null)
		{
			value8 = (RouletteExploreSkillController.<>O.<5>__OpenFightPhotograph = new Action<int, int>(RouletteExploreSkillController.OpenFightPhotograph));
		}
		dictionary.Add(key8, value8);
		ERouletteSkillId key9 = ERouletteSkillId.摩托自动巡航;
		Action<int, int> value9;
		if ((value9 = RouletteExploreSkillController.<>O.<6>__EnterMotorAutoPilot) == null)
		{
			value9 = (RouletteExploreSkillController.<>O.<6>__EnterMotorAutoPilot = new Action<int, int>(RouletteExploreSkillController.EnterMotorAutoPilot));
		}
		dictionary.Add(key9, value9);
		ERouletteSkillId key10 = ERouletteSkillId.摩托车电台;
		Action<int, int> value10;
		if ((value10 = RouletteExploreSkillController.<>O.<7>__OpenMotorMusicPlayer) == null)
		{
			value10 = (RouletteExploreSkillController.<>O.<7>__OpenMotorMusicPlayer = new Action<int, int>(RouletteExploreSkillController.OpenMotorMusicPlayer));
		}
		dictionary.Add(key10, value10);
		ERouletteSkillId key11 = ERouletteSkillId.摩托上车接自动巡航;
		Action<int, int> value11;
		if ((value11 = RouletteExploreSkillController.<>O.<8>__SummonMotorAndEnterAutoPilot) == null)
		{
			value11 = (RouletteExploreSkillController.<>O.<8>__SummonMotorAndEnterAutoPilot = new Action<int, int>(RouletteExploreSkillController.SummonMotorAndEnterAutoPilot));
		}
		dictionary.Add(key11, value11);
		ERouletteSkillId key12 = ERouletteSkillId.声骸显像界面入口;
		Action<int, int> value12;
		if ((value12 = RouletteExploreSkillController.<>O.<9>__OpenPhantomSummonView) == null)
		{
			value12 = (RouletteExploreSkillController.<>O.<9>__OpenPhantomSummonView = new Action<int, int>(RouletteExploreSkillController.OpenPhantomSummonView));
		}
		dictionary.Add(key12, value12);
		ERouletteSkillId key13 = ERouletteSkillId.摩托车声骸显像界面入口;
		Action<int, int> value13;
		if ((value13 = RouletteExploreSkillController.<>O.<9>__OpenPhantomSummonView) == null)
		{
			value13 = (RouletteExploreSkillController.<>O.<9>__OpenPhantomSummonView = new Action<int, int>(RouletteExploreSkillController.OpenPhantomSummonView));
		}
		dictionary.Add(key13, value13);
		ERouletteSkillId key14 = ERouletteSkillId.摩托车切换科技树;
		Action<int, int> value14;
		if ((value14 = RouletteExploreSkillController.<>O.<10>__OpenMotorTechTreeSwitchView) == null)
		{
			value14 = (RouletteExploreSkillController.<>O.<10>__OpenMotorTechTreeSwitchView = new Action<int, int>(RouletteExploreSkillController.OpenMotorTechTreeSwitchView));
		}
		dictionary.Add(key14, value14);
		ERouletteSkillId key15 = ERouletteSkillId.主线任务分线界面;
		Action<int, int> value15;
		if ((value15 = RouletteExploreSkillController.<>O.<11>__OpenQuestMultiLineView) == null)
		{
			value15 = (RouletteExploreSkillController.<>O.<11>__OpenQuestMultiLineView = new Action<int, int>(RouletteExploreSkillController.OpenQuestMultiLineView));
		}
		dictionary.Add(key15, value15);
		this.RouletteExploreSkillUseWayMap = dictionary;
		base..ctor();
	}

	// Token: 0x0400A5C1 RID: 42433
	private readonly Dictionary<ERouletteSkillId, Action<int, int>> RouletteExploreSkillUseWayMap;

	// Token: 0x0400A5C2 RID: 42434
	[Nullable(2)]
	private static RouletteExploreSkillController _Instance;

	// Token: 0x02008154 RID: 33108
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04029D03 RID: 171267
		[Nullable(0)]
		public static Action<int, int> <0>__OnUseEquipItem;

		// Token: 0x04029D04 RID: 171268
		[Nullable(0)]
		public static Action<int, int> <1>__OpenEmptyTips;

		// Token: 0x04029D05 RID: 171269
		[Nullable(0)]
		public static Action<int, int> <2>__UseMapExploreTool;

		// Token: 0x04029D06 RID: 171270
		[Nullable(0)]
		public static Action<int, int> <3>__OpenAdviceCreateView;

		// Token: 0x04029D07 RID: 171271
		[Nullable(0)]
		public static Action<int, int> <4>__PhotographFastScreenShot;

		// Token: 0x04029D08 RID: 171272
		[Nullable(0)]
		public static Action<int, int> <5>__OpenFightPhotograph;

		// Token: 0x04029D09 RID: 171273
		[Nullable(0)]
		public static Action<int, int> <6>__EnterMotorAutoPilot;

		// Token: 0x04029D0A RID: 171274
		[Nullable(0)]
		public static Action<int, int> <7>__OpenMotorMusicPlayer;

		// Token: 0x04029D0B RID: 171275
		[Nullable(0)]
		public static Action<int, int> <8>__SummonMotorAndEnterAutoPilot;

		// Token: 0x04029D0C RID: 171276
		[Nullable(0)]
		public static Action<int, int> <9>__OpenPhantomSummonView;

		// Token: 0x04029D0D RID: 171277
		[Nullable(0)]
		public static Action<int, int> <10>__OpenMotorTechTreeSwitchView;

		// Token: 0x04029D0E RID: 171278
		[Nullable(0)]
		public static Action<int, int> <11>__OpenQuestMultiLineView;
	}
}
