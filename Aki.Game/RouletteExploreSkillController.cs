using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Vision;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.QuestMultiLine;
using Cysharp.Threading.Tasks;

// Token: 0x02002923 RID: 10531
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class RouletteExploreSkillController : ControllerBase
{
	// Token: 0x06015BC6 RID: 89030 RVA: 0x0057BB40 File Offset: 0x00579D40
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

	// Token: 0x06015BC7 RID: 89031 RVA: 0x0057BBAC File Offset: 0x00579DAC
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

	// Token: 0x06015BC8 RID: 89032 RVA: 0x0057BBD4 File Offset: 0x00579DD4
	private static void OnUseEquipItem(int entityId, int skillId)
	{
		RouletteController.Instance.OnUseEquipItem();
	}

	// Token: 0x06015BC9 RID: 89033 RVA: 0x0057BBE0 File Offset: 0x00579DE0
	private static void OpenEmptyTips(int entityId, int skillId)
	{
		RouletteController.Instance.OpenEmptyTips();
	}

	// Token: 0x06015BCA RID: 89034 RVA: 0x0057BBEC File Offset: 0x00579DEC
	private static void UseMapExploreTool(int entityId, int skillId)
	{
		MapExploreToolController.Instance.CheckUseMapExploreTool(entityId, skillId);
	}

	// Token: 0x06015BCB RID: 89035 RVA: 0x0057BBFA File Offset: 0x00579DFA
	private static void OpenAdviceCreateView(int entityId, int skillId)
	{
		AdviceController.Instance.OpenAdviceCreateView();
	}

	// Token: 0x06015BCC RID: 89036 RVA: 0x0057BC06 File Offset: 0x00579E06
	private static void PhotographFastScreenShot(int entityId, int skillId)
	{
		PhotographController.Instance.PhotographFastScreenShot(ECameraCaptureType.NormalCamera);
	}

	// Token: 0x06015BCD RID: 89037 RVA: 0x0057BC13 File Offset: 0x00579E13
	private static void OpenFightPhotograph(int entityId, int skillId)
	{
		PhotographController.Instance.TryOpenPhotograph(ECameraCaptureType.FightPhotographCamera);
	}

	// Token: 0x06015BCE RID: 89038 RVA: 0x0057BC21 File Offset: 0x00579E21
	private static void EnterMotorAutoPilot(int entityId, int skillId)
	{
		AutoPilotController.Instance.EnterAutoPilot().Forget<bool>();
	}

	// Token: 0x06015BCF RID: 89039 RVA: 0x0057BC32 File Offset: 0x00579E32
	private static void SummonMotorAndEnterAutoPilot(int entityId, int skillId)
	{
		AutoPilotController.Instance.SummonMotorAndEnterAutoPilot();
	}

	// Token: 0x06015BD0 RID: 89040 RVA: 0x0057BC3E File Offset: 0x00579E3E
	private static void OpenMotorMusicPlayer(int entityId, int skillId)
	{
		MotorcycleMusicPlayerController.Instance.OpenMusicPlayerView();
	}

	// Token: 0x06015BD1 RID: 89041 RVA: 0x0057BC4A File Offset: 0x00579E4A
	private static void OpenPhantomSummonView(int entityId, int skillId)
	{
		PhantomInteractController.Instance.OpenPhantomVisionSummonView(entityId, skillId);
	}

	// Token: 0x06015BD2 RID: 89042 RVA: 0x0057BC58 File Offset: 0x00579E58
	private static void OpenMotorTechTreeSwitchView(int entityId, int skillId)
	{
		MotorcycleDevelopController.Instance.OpenMotorTechTreeSwitchView();
	}

	// Token: 0x06015BD3 RID: 89043 RVA: 0x0057BC64 File Offset: 0x00579E64
	private static void OpenQuestMultiLineView(int entityId, int skillId)
	{
		QuestMultiLineController.Instance.OpenQuestMultiLineView(0, false, false);
	}

	// Token: 0x17001D32 RID: 7474
	// (get) Token: 0x06015BD4 RID: 89044 RVA: 0x0057BC74 File Offset: 0x00579E74
	public static RouletteExploreSkillController Instance
	{
		get
		{
			return RouletteExploreSkillController._Instance;
		}
	}

	// Token: 0x06015BD5 RID: 89045 RVA: 0x0057BC7B File Offset: 0x00579E7B
	public static RouletteExploreSkillController GetOrCreateInstance()
	{
		if (RouletteExploreSkillController._Instance == null)
		{
			RouletteExploreSkillController.CreateInstance();
		}
		return RouletteExploreSkillController._Instance;
	}

	// Token: 0x06015BD6 RID: 89046 RVA: 0x0057BC8F File Offset: 0x00579E8F
	public static bool CreateInstance()
	{
		if (RouletteExploreSkillController._Instance != null)
		{
			return true;
		}
		RouletteExploreSkillController._Instance = new RouletteExploreSkillController();
		return true;
	}

	// Token: 0x06015BD7 RID: 89047 RVA: 0x0057BCA5 File Offset: 0x00579EA5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015BD8 RID: 89048 RVA: 0x0057BCA7 File Offset: 0x00579EA7
	public static void ResetStaticDefaultValue()
	{
		RouletteExploreSkillController._Instance = null;
	}

	// Token: 0x06015BD9 RID: 89049 RVA: 0x0057BCAF File Offset: 0x00579EAF
	static RouletteExploreSkillController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RouletteExploreSkillController.CreateStaticDefaultValue), new Action(RouletteExploreSkillController.ResetStaticDefaultValue));
	}

	// Token: 0x06015BDA RID: 89050 RVA: 0x0057BCD0 File Offset: 0x00579ED0
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

	// Token: 0x0400A1D6 RID: 41430
	private readonly Dictionary<ERouletteSkillId, Action<int, int>> RouletteExploreSkillUseWayMap;

	// Token: 0x0400A1D7 RID: 41431
	[Nullable(2)]
	private static RouletteExploreSkillController _Instance;

	// Token: 0x02008F0C RID: 36620
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402E606 RID: 189958
		[Nullable(0)]
		public static Action<int, int> <0>__OnUseEquipItem;

		// Token: 0x0402E607 RID: 189959
		[Nullable(0)]
		public static Action<int, int> <1>__OpenEmptyTips;

		// Token: 0x0402E608 RID: 189960
		[Nullable(0)]
		public static Action<int, int> <2>__UseMapExploreTool;

		// Token: 0x0402E609 RID: 189961
		[Nullable(0)]
		public static Action<int, int> <3>__OpenAdviceCreateView;

		// Token: 0x0402E60A RID: 189962
		[Nullable(0)]
		public static Action<int, int> <4>__PhotographFastScreenShot;

		// Token: 0x0402E60B RID: 189963
		[Nullable(0)]
		public static Action<int, int> <5>__OpenFightPhotograph;

		// Token: 0x0402E60C RID: 189964
		[Nullable(0)]
		public static Action<int, int> <6>__EnterMotorAutoPilot;

		// Token: 0x0402E60D RID: 189965
		[Nullable(0)]
		public static Action<int, int> <7>__OpenMotorMusicPlayer;

		// Token: 0x0402E60E RID: 189966
		[Nullable(0)]
		public static Action<int, int> <8>__SummonMotorAndEnterAutoPilot;

		// Token: 0x0402E60F RID: 189967
		[Nullable(0)]
		public static Action<int, int> <9>__OpenPhantomSummonView;

		// Token: 0x0402E610 RID: 189968
		[Nullable(0)]
		public static Action<int, int> <10>__OpenMotorTechTreeSwitchView;

		// Token: 0x0402E611 RID: 189969
		[Nullable(0)]
		public static Action<int, int> <11>__OpenQuestMultiLineView;
	}
}
