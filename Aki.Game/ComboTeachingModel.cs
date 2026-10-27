using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol.Summon;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;

// Token: 0x020017C8 RID: 6088
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ComboTeachingModel : ModelBase
{
	// Token: 0x17000ECE RID: 3790
	// (get) Token: 0x0600B1D0 RID: 45520 RVA: 0x0028363D File Offset: 0x0028183D
	// (set) Token: 0x0600B1D1 RID: 45521 RVA: 0x00283645 File Offset: 0x00281845
	public float BeforeJumpTime
	{
		get
		{
			return this.BeforeJumpTimeInternal;
		}
		set
		{
			this.BeforeJumpTimeInternal = value;
		}
	}

	// Token: 0x17000ECF RID: 3791
	// (get) Token: 0x0600B1D2 RID: 45522 RVA: 0x0028364E File Offset: 0x0028184E
	// (set) Token: 0x0600B1D3 RID: 45523 RVA: 0x00283656 File Offset: 0x00281856
	public bool IsClose
	{
		get
		{
			return this.IsCloseInternal;
		}
		set
		{
			this.IsCloseInternal = value;
		}
	}

	// Token: 0x17000ED0 RID: 3792
	// (get) Token: 0x0600B1D4 RID: 45524 RVA: 0x0028365F File Offset: 0x0028185F
	// (set) Token: 0x0600B1D5 RID: 45525 RVA: 0x00283667 File Offset: 0x00281867
	public bool IsEmit
	{
		get
		{
			return this.IsEmitInternal;
		}
		set
		{
			this.IsEmitInternal = value;
		}
	}

	// Token: 0x17000ED1 RID: 3793
	// (get) Token: 0x0600B1D6 RID: 45526 RVA: 0x00283670 File Offset: 0x00281870
	// (set) Token: 0x0600B1D7 RID: 45527 RVA: 0x00283678 File Offset: 0x00281878
	public int RecoveryComboId
	{
		get
		{
			return this.RecoveryComboIdInternal;
		}
		set
		{
			this.RecoveryComboIdInternal = value;
		}
	}

	// Token: 0x17000ED2 RID: 3794
	// (get) Token: 0x0600B1D8 RID: 45528 RVA: 0x00283681 File Offset: 0x00281881
	public List<long> AddBuffList
	{
		get
		{
			return this.AddBuffListInternal;
		}
	}

	// Token: 0x17000ED3 RID: 3795
	// (get) Token: 0x0600B1D9 RID: 45529 RVA: 0x00283689 File Offset: 0x00281889
	public List<string> AddTagList
	{
		get
		{
			return this.AddTagListInternal;
		}
	}

	// Token: 0x17000ED4 RID: 3796
	// (get) Token: 0x0600B1DA RID: 45530 RVA: 0x00283691 File Offset: 0x00281891
	// (set) Token: 0x0600B1DB RID: 45531 RVA: 0x00283699 File Offset: 0x00281899
	public long NextAttrSkillId
	{
		get
		{
			return this.NextAttrSkillIdInternal;
		}
		set
		{
			this.NextAttrSkillIdInternal = value;
		}
	}

	// Token: 0x17000ED5 RID: 3797
	// (get) Token: 0x0600B1DD RID: 45533 RVA: 0x002836AB File Offset: 0x002818AB
	// (set) Token: 0x0600B1DC RID: 45532 RVA: 0x002836A2 File Offset: 0x002818A2
	public long UseSkillId
	{
		get
		{
			return this.UseSkillIdInternal;
		}
		set
		{
			this.UseSkillIdInternal = value;
		}
	}

	// Token: 0x17000ED6 RID: 3798
	// (get) Token: 0x0600B1DF RID: 45535 RVA: 0x002836BC File Offset: 0x002818BC
	// (set) Token: 0x0600B1DE RID: 45534 RVA: 0x002836B3 File Offset: 0x002818B3
	public float UseSkillTime
	{
		get
		{
			return this.UseSkillTimeInternal;
		}
		set
		{
			this.UseSkillTimeInternal = value;
		}
	}

	// Token: 0x17000ED7 RID: 3799
	// (get) Token: 0x0600B1E1 RID: 45537 RVA: 0x002836CD File Offset: 0x002818CD
	// (set) Token: 0x0600B1E0 RID: 45536 RVA: 0x002836C4 File Offset: 0x002818C4
	public bool PreNextAttr
	{
		get
		{
			return this.PreNextAttrInternal;
		}
		set
		{
			this.PreNextAttrInternal = value;
		}
	}

	// Token: 0x17000ED8 RID: 3800
	// (get) Token: 0x0600B1E3 RID: 45539 RVA: 0x002836EA File Offset: 0x002818EA
	// (set) Token: 0x0600B1E2 RID: 45538 RVA: 0x002836D5 File Offset: 0x002818D5
	public bool NextAttr
	{
		get
		{
			return this.NextAttrInternal;
		}
		set
		{
			this.PreNextAttrInternal = this.NextAttrInternal;
			this.NextAttrInternal = value;
		}
	}

	// Token: 0x17000ED9 RID: 3801
	// (get) Token: 0x0600B1E5 RID: 45541 RVA: 0x0028370B File Offset: 0x0028190B
	// (set) Token: 0x0600B1E4 RID: 45540 RVA: 0x002836F2 File Offset: 0x002818F2
	public int CurrentNodeIndex
	{
		get
		{
			return this.CurrentNodeIndexInternal;
		}
		set
		{
			this.CurrentNodeIndexInternal = value;
			EventSystem.Instance.Emit(EEventName.ComboTeachingIndexUpdate);
		}
	}

	// Token: 0x17000EDA RID: 3802
	// (get) Token: 0x0600B1E6 RID: 45542 RVA: 0x00283713 File Offset: 0x00281913
	// (set) Token: 0x0600B1E7 RID: 45543 RVA: 0x00283722 File Offset: 0x00281922
	public bool InitStart
	{
		get
		{
			bool initStartInternal = this.InitStartInternal;
			this.InitStartInternal = false;
			return initStartInternal;
		}
		set
		{
			this.InitStartInternal = value;
		}
	}

	// Token: 0x0600B1E8 RID: 45544 RVA: 0x0028372C File Offset: 0x0028192C
	public void RefreshComboList(int comboId)
	{
		this.CurrentNodeIndex = 0;
		ComboTeaching? comboTeachingConfig = ComboTeachingConfig.Instance.GetComboTeachingConfig(comboId);
		int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
		Entity entity = EntitySystem.Instance.Get(entityIdNoBlueprint);
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
		foreach (string tagName in this.AddTagList)
		{
			if (baseTagComponent != null)
			{
				baseTagComponent.RemoveTag(new int?(GameplayTagUtils.GetTagIdByName(tagName)));
			}
		}
		this.AddTagList.Clear();
		foreach (KeyValuePair<string, List<string>> keyValuePair in ComboTeachingDefine.banKeyMap)
		{
			if (!comboTeachingConfig.Value.InputEnums().Contains(keyValuePair.Key))
			{
				this.AddTagList.AddRange(keyValuePair.Value);
			}
		}
		foreach (string tagName2 in this.AddTagList)
		{
			int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName2);
			if (baseTagComponent != null && !baseTagComponent.HasTag(tagIdByName) && baseTagComponent != null)
			{
				baseTagComponent.AddTag(new int?(tagIdByName));
			}
		}
		foreach (long buffId in this.AddBuffList)
		{
			if (characterBuffComponent != null && characterBuffComponent.GetBuffTotalStackById(buffId, false) > 0 && characterBuffComponent != null)
			{
				characterBuffComponent.RemoveBuff(buffId, -1, "ComboTeachingView.RefreshComboList", null, null, null);
			}
		}
		this.AddBuffList.Clear();
		foreach (long item in comboTeachingConfig.Value.AddBuffIDIter())
		{
			this.AddBuffList.Add(item);
		}
		foreach (long buffId2 in this.AddBuffList)
		{
			if (characterBuffComponent != null)
			{
				characterBuffComponent.AddBuff(buffId2, new AddBuffParam
				{
					InstigatorId = ((characterBuffComponent != null) ? characterBuffComponent.CreatureDataId : 0L),
					Reason = "CombatTeachingView.RefreshComboList"
				});
			}
		}
		foreach (int guideId in comboTeachingConfig.Value.GuideIDIter())
		{
			GuideController.Instance.TryStartGuide(guideId);
		}
	}

	// Token: 0x0600B1E9 RID: 45545 RVA: 0x00283A40 File Offset: 0x00281C40
	public void OnComboListEnd()
	{
		if (Global.BaseCharacter == null)
		{
			this.AddBuffList.Clear();
			this.AddTagList.Clear();
			return;
		}
		int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
		Entity entity = EntitySystem.Instance.Get(entityIdNoBlueprint);
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		foreach (string tagName in this.AddTagList)
		{
			if (baseTagComponent != null)
			{
				baseTagComponent.RemoveTag(new int?(GameplayTagUtils.GetTagIdByName(tagName)));
			}
		}
		this.AddTagList.Clear();
		CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
		foreach (long buffId in this.AddBuffList)
		{
			if (characterBuffComponent != null && characterBuffComponent.GetBuffTotalStackById(buffId, false) > 0 && characterBuffComponent != null)
			{
				characterBuffComponent.RemoveBuff(buffId, -1, "ComboTeachingView.OnBeforeDestroy", null, null, null);
			}
		}
		this.AddBuffList.Clear();
	}

	// Token: 0x0600B1EA RID: 45546 RVA: 0x00283B84 File Offset: 0x00281D84
	public IComboTeachingInfo CreateComboNodeInfo(int index, ComboTeaching comboConfig)
	{
		ComboTeachingCondition value = ComboTeachingConfig.Instance.GetComboTeachingConditionConfig(comboConfig.CommandID()[index]).Value;
		BaseCheckCondition successChecker = ComboTeachingController.Instance.GetSuccessChecker(value.CompleteCondition, value.CompleteParam);
		List<BaseCheckCondition> list = new List<BaseCheckCondition>();
		List<BaseCheckCondition> list2 = new List<BaseCheckCondition>();
		for (int i = 0; i < value.FailedCondition().Length; i++)
		{
			int type = value.FailedCondition()[i];
			string conditionString = (value.FailedParamLength > i) ? value.FailedParam()[i] : "";
			BaseCheckCondition failChecker = ComboTeachingController.Instance.GetFailChecker(type, conditionString);
			EComboTeachingCheckType type2 = failChecker.Type;
			if (type2 != EComboTeachingCheckType.Event)
			{
				if (type2 == EComboTeachingCheckType.Update)
				{
					list.Add(failChecker);
				}
			}
			else
			{
				list2.Add(failChecker);
			}
		}
		bool flag = index >= comboConfig.KeyIDLength || string.IsNullOrEmpty(comboConfig.KeyID(index));
		ComboTeachingInfo comboTeachingInfo = new ComboTeachingInfo
		{
			Index = index,
			Config = comboConfig,
			HoldTotalTime = 0f,
			SuccessCondition = successChecker,
			FailUpdateCondition = list,
			FailEventCondition = list2,
			IsEmit = false,
			IsHoldAction = false,
			IsShowTag = false,
			ActionInfo = "",
			NeedTickSummon = true,
			SuccessDelay = (float)value.CompleteDelay,
			FailDelay = (float)value.FailDelay
		};
		if (flag)
		{
			return comboTeachingInfo;
		}
		string text = comboConfig.KeyID(index).Split(';', StringSplitOptions.None)[0];
		bool flag2 = text.Contains('#');
		bool isShowTag = comboConfig.IconTagTextLength > index && comboConfig.IconTagText(index) != "";
		float holdTotalTime = flag2 ? float.Parse(text.Split('#', StringSplitOptions.None)[1]) : 0f;
		comboTeachingInfo.IsHoldAction = flag2;
		comboTeachingInfo.IsShowTag = isShowTag;
		comboTeachingInfo.HoldTotalTime = holdTotalTime;
		comboTeachingInfo.ActionInfo = (flag2 ? text.Split('#', StringSplitOptions.None)[0] : text);
		return comboTeachingInfo;
	}

	// Token: 0x0600B1EB RID: 45547 RVA: 0x00283D78 File Offset: 0x00281F78
	public void ResetComboConfig()
	{
		this.UseSkillId = 0L;
		this.UseSkillTime = 0f;
		this.NextAttr = false;
		this.PreNextAttr = false;
	}

	// Token: 0x0600B1EC RID: 45548 RVA: 0x00283D9C File Offset: 0x00281F9C
	public bool CheckFailCondition(IComboTeachingInfo data, EComboTeachingFailCondition condition)
	{
		ComboTeaching config = data.Config;
		int index = data.Index;
		return ComboTeachingConfig.Instance.GetComboTeachingConditionConfig(config.CommandID()[index]).Value.FailedCondition().Contains((int)condition);
	}

	// Token: 0x0600B1ED RID: 45549 RVA: 0x00283DE0 File Offset: 0x00281FE0
	public void OnCurIndexChanged(IComboTeachingInfo data)
	{
		ComboTeaching config = data.Config;
		int index = data.Index;
		ComboTeachingCondition value = ComboTeachingConfig.Instance.GetComboTeachingConditionConfig(config.CommandID()[index]).Value;
		int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
		Entity entity = EntitySystem.Instance.Get(entityIdNoBlueprint);
		if (value.RemoveBuff().Length != 0)
		{
			CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
			foreach (int num in value.RemoveBuff())
			{
				if (characterBuffComponent != null && characterBuffComponent.GetBuffTotalStackById((long)num, false) > 0 && characterBuffComponent != null)
				{
					characterBuffComponent.RemoveBuff((long)num, -1, "ComboTeachingView.OnNodeStart", null, null, null);
				}
			}
		}
		if (value.RemoveBullet().Length != 0)
		{
			OrderedDictionary<int, BulletEntity> bulletEntityMap = BulletModel.Instance.GetBulletEntityMap();
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			foreach (KeyValuePair<int, BulletEntity> keyValuePair in bulletEntityMap)
			{
				dictionary[keyValuePair.Value.GetBulletInfo().BulletRowName] = keyValuePair.Value.Id;
			}
			foreach (string text in value.RemoveBullet())
			{
				bool summonChild = false;
				string key;
				if (text.Contains(';'))
				{
					string[] array3 = text.Split(';', StringSplitOptions.None);
					key = array3[0];
					summonChild = bool.Parse(array3[1]);
				}
				else
				{
					key = text;
				}
				int id;
				if (dictionary.TryGetValue(key, out id))
				{
					BulletController.Instance.DestroyBullet(id, summonChild, EBulletDestroyReason.Normal, false);
				}
			}
		}
		if (value.SummonPos != 0 && data.NeedTickSummon)
		{
			this.CheckSummonBuffAdd(data);
			return;
		}
		data.NeedTickSummon = false;
	}

	// Token: 0x0600B1EE RID: 45550 RVA: 0x00283FC4 File Offset: 0x002821C4
	public void CheckSummonBuffAdd(IComboTeachingInfo data)
	{
		ComboTeaching config = data.Config;
		int index = data.Index;
		ComboTeachingCondition value = ComboTeachingConfig.Instance.GetComboTeachingConditionConfig(config.CommandID()[index]).Value;
		int summonPos = value.SummonPos;
		if (summonPos == 0)
		{
			data.NeedTickSummon = false;
			return;
		}
		EntityHandle summonedEntityByOwnerId = PhantomUtil.GetSummonedEntityByOwnerId(Global.BaseCharacter.GetEntityIdNoBlueprint(), ESummonType.ConcomitantCustom, summonPos);
		if (summonedEntityByOwnerId == null)
		{
			return;
		}
		WorldEntity entity = summonedEntityByOwnerId.Entity;
		CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
		if (characterBuffComponent != null)
		{
			foreach (int num in value.SummonRemoveBuff())
			{
				characterBuffComponent.RemoveBuff((long)num, -1, "ComboTeachingView.SummonRemoveBuff", null, null, null);
			}
			foreach (int num2 in value.SummonAddBuff())
			{
				characterBuffComponent.AddBuff((long)num2, new AddBuffParam
				{
					InstigatorId = characterBuffComponent.CreatureDataId,
					Reason = "CombatTeachingView.SummonAddBuff"
				});
			}
		}
		data.NeedTickSummon = false;
	}

	// Token: 0x17000EDB RID: 3803
	// (get) Token: 0x0600B1EF RID: 45551 RVA: 0x002840E5 File Offset: 0x002822E5
	public static ComboTeachingModel Instance
	{
		get
		{
			return ComboTeachingModel._Instance;
		}
	}

	// Token: 0x0600B1F0 RID: 45552 RVA: 0x002840EC File Offset: 0x002822EC
	public static ComboTeachingModel GetOrCreateInstance()
	{
		if (ComboTeachingModel._Instance == null)
		{
			ComboTeachingModel.CreateInstance();
		}
		return ComboTeachingModel._Instance;
	}

	// Token: 0x0600B1F1 RID: 45553 RVA: 0x00284100 File Offset: 0x00282300
	public static bool CreateInstance()
	{
		if (ComboTeachingModel._Instance != null)
		{
			return true;
		}
		ComboTeachingModel._Instance = new ComboTeachingModel();
		return true;
	}

	// Token: 0x0600B1F2 RID: 45554 RVA: 0x00284116 File Offset: 0x00282316
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B1F3 RID: 45555 RVA: 0x00284118 File Offset: 0x00282318
	public static void ResetStaticDefaultValue()
	{
		ComboTeachingModel._Instance = null;
	}

	// Token: 0x0600B1F4 RID: 45556 RVA: 0x00284120 File Offset: 0x00282320
	static ComboTeachingModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ComboTeachingModel.CreateStaticDefaultValue), new Action(ComboTeachingModel.ResetStaticDefaultValue));
	}

	// Token: 0x040050AD RID: 20653
	private long UseSkillIdInternal;

	// Token: 0x040050AE RID: 20654
	private float UseSkillTimeInternal;

	// Token: 0x040050AF RID: 20655
	private bool PreNextAttrInternal;

	// Token: 0x040050B0 RID: 20656
	private bool NextAttrInternal;

	// Token: 0x040050B1 RID: 20657
	private int CurrentNodeIndexInternal;

	// Token: 0x040050B2 RID: 20658
	private long NextAttrSkillIdInternal;

	// Token: 0x040050B3 RID: 20659
	private readonly List<long> AddBuffListInternal = new List<long>();

	// Token: 0x040050B4 RID: 20660
	private readonly List<string> AddTagListInternal = new List<string>();

	// Token: 0x040050B5 RID: 20661
	private int RecoveryComboIdInternal;

	// Token: 0x040050B6 RID: 20662
	private bool IsEmitInternal;

	// Token: 0x040050B7 RID: 20663
	private bool IsCloseInternal;

	// Token: 0x040050B8 RID: 20664
	private float BeforeJumpTimeInternal;

	// Token: 0x040050B9 RID: 20665
	private bool InitStartInternal;

	// Token: 0x040050BA RID: 20666
	[Nullable(2)]
	private static ComboTeachingModel _Instance;
}
