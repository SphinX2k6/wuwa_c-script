using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol.Summon;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;

// Token: 0x02000C81 RID: 3201
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ComboTeachingModel : ModelBase
{
	// Token: 0x17000EF1 RID: 3825
	// (get) Token: 0x060085B8 RID: 34232 RVA: 0x0028DBE5 File Offset: 0x0028BDE5
	// (set) Token: 0x060085B9 RID: 34233 RVA: 0x0028DBED File Offset: 0x0028BDED
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

	// Token: 0x17000EF2 RID: 3826
	// (get) Token: 0x060085BA RID: 34234 RVA: 0x0028DBF6 File Offset: 0x0028BDF6
	// (set) Token: 0x060085BB RID: 34235 RVA: 0x0028DBFE File Offset: 0x0028BDFE
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

	// Token: 0x17000EF3 RID: 3827
	// (get) Token: 0x060085BC RID: 34236 RVA: 0x0028DC07 File Offset: 0x0028BE07
	// (set) Token: 0x060085BD RID: 34237 RVA: 0x0028DC0F File Offset: 0x0028BE0F
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

	// Token: 0x17000EF4 RID: 3828
	// (get) Token: 0x060085BE RID: 34238 RVA: 0x0028DC18 File Offset: 0x0028BE18
	// (set) Token: 0x060085BF RID: 34239 RVA: 0x0028DC20 File Offset: 0x0028BE20
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

	// Token: 0x17000EF5 RID: 3829
	// (get) Token: 0x060085C0 RID: 34240 RVA: 0x0028DC29 File Offset: 0x0028BE29
	public List<long> AddBuffList
	{
		get
		{
			return this.AddBuffListInternal;
		}
	}

	// Token: 0x17000EF6 RID: 3830
	// (get) Token: 0x060085C1 RID: 34241 RVA: 0x0028DC31 File Offset: 0x0028BE31
	public List<string> AddTagList
	{
		get
		{
			return this.AddTagListInternal;
		}
	}

	// Token: 0x17000EF7 RID: 3831
	// (get) Token: 0x060085C2 RID: 34242 RVA: 0x0028DC39 File Offset: 0x0028BE39
	// (set) Token: 0x060085C3 RID: 34243 RVA: 0x0028DC41 File Offset: 0x0028BE41
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

	// Token: 0x17000EF8 RID: 3832
	// (get) Token: 0x060085C5 RID: 34245 RVA: 0x0028DC53 File Offset: 0x0028BE53
	// (set) Token: 0x060085C4 RID: 34244 RVA: 0x0028DC4A File Offset: 0x0028BE4A
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

	// Token: 0x17000EF9 RID: 3833
	// (get) Token: 0x060085C7 RID: 34247 RVA: 0x0028DC64 File Offset: 0x0028BE64
	// (set) Token: 0x060085C6 RID: 34246 RVA: 0x0028DC5B File Offset: 0x0028BE5B
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

	// Token: 0x17000EFA RID: 3834
	// (get) Token: 0x060085C9 RID: 34249 RVA: 0x0028DC75 File Offset: 0x0028BE75
	// (set) Token: 0x060085C8 RID: 34248 RVA: 0x0028DC6C File Offset: 0x0028BE6C
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

	// Token: 0x17000EFB RID: 3835
	// (get) Token: 0x060085CB RID: 34251 RVA: 0x0028DC92 File Offset: 0x0028BE92
	// (set) Token: 0x060085CA RID: 34250 RVA: 0x0028DC7D File Offset: 0x0028BE7D
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

	// Token: 0x17000EFC RID: 3836
	// (get) Token: 0x060085CD RID: 34253 RVA: 0x0028DCB3 File Offset: 0x0028BEB3
	// (set) Token: 0x060085CC RID: 34252 RVA: 0x0028DC9A File Offset: 0x0028BE9A
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

	// Token: 0x17000EFD RID: 3837
	// (get) Token: 0x060085CE RID: 34254 RVA: 0x0028DCBB File Offset: 0x0028BEBB
	// (set) Token: 0x060085CF RID: 34255 RVA: 0x0028DCCA File Offset: 0x0028BECA
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

	// Token: 0x060085D0 RID: 34256 RVA: 0x0028DCD4 File Offset: 0x0028BED4
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
			if (Array.IndexOf<string>(comboTeachingConfig.Value.InputEnums(), keyValuePair.Key) < 0)
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

	// Token: 0x060085D1 RID: 34257 RVA: 0x0028DFE8 File Offset: 0x0028C1E8
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

	// Token: 0x060085D2 RID: 34258 RVA: 0x0028E12C File Offset: 0x0028C32C
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

	// Token: 0x060085D3 RID: 34259 RVA: 0x0028E320 File Offset: 0x0028C520
	public void ResetComboConfig()
	{
		this.UseSkillId = 0L;
		this.UseSkillTime = 0f;
		this.NextAttr = false;
		this.PreNextAttr = false;
	}

	// Token: 0x060085D4 RID: 34260 RVA: 0x0028E344 File Offset: 0x0028C544
	public bool CheckFailCondition(IComboTeachingInfo data, EComboTeachingFailCondition condition)
	{
		ComboTeaching config = data.Config;
		int index = data.Index;
		return Array.IndexOf<int>(ComboTeachingConfig.Instance.GetComboTeachingConditionConfig(config.CommandID()[index]).Value.FailedCondition(), (int)condition) >= 0;
	}

	// Token: 0x060085D5 RID: 34261 RVA: 0x0028E390 File Offset: 0x0028C590
	public void OnCurIndexChanged(IComboTeachingInfo data)
	{
		ComboTeaching config = data.Config;
		int index = data.Index;
		ComboTeachingCondition value = ComboTeachingConfig.Instance.GetComboTeachingConditionConfig(config.CommandID()[index]).Value;
		if (value.RemoveBuff().Length == 0 && value.RemoveBullet().Length == 0)
		{
			int summonPos = value.SummonPos;
		}
		string text = "";
		foreach (BaseCheckCondition baseCheckCondition in data.FailUpdateCondition)
		{
			string str = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted<EComboTeachingFailCondition>((EComboTeachingFailCondition)baseCheckCondition.GetConditionType());
			defaultInterpolatedStringHandler.AppendLiteral("=");
			defaultInterpolatedStringHandler.AppendFormatted(baseCheckCondition.OriginString);
			defaultInterpolatedStringHandler.AppendLiteral(";");
			text = str + defaultInterpolatedStringHandler.ToStringAndClear();
		}
		string text2 = "";
		foreach (BaseCheckCondition baseCheckCondition2 in data.FailEventCondition)
		{
			string str2 = text2;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
			defaultInterpolatedStringHandler.AppendFormatted<EComboTeachingFailCondition>((EComboTeachingFailCondition)baseCheckCondition2.GetConditionType());
			defaultInterpolatedStringHandler.AppendLiteral("=");
			defaultInterpolatedStringHandler.AppendFormatted(baseCheckCondition2.OriginString);
			defaultInterpolatedStringHandler.AppendLiteral(";");
			text2 = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
		}
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
			foreach (string text3 in value.RemoveBullet())
			{
				bool summonChild = false;
				string key;
				if (text3.Contains(';'))
				{
					string[] array3 = text3.Split(';', StringSplitOptions.None);
					key = array3[0];
					summonChild = bool.Parse(array3[1]);
				}
				else
				{
					key = text3;
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

	// Token: 0x060085D6 RID: 34262 RVA: 0x0028E6B0 File Offset: 0x0028C8B0
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

	// Token: 0x17000EFE RID: 3838
	// (get) Token: 0x060085D7 RID: 34263 RVA: 0x0028E7D1 File Offset: 0x0028C9D1
	public static ComboTeachingModel Instance
	{
		get
		{
			return ComboTeachingModel._Instance;
		}
	}

	// Token: 0x060085D8 RID: 34264 RVA: 0x0028E7D8 File Offset: 0x0028C9D8
	public static ComboTeachingModel GetOrCreateInstance()
	{
		if (ComboTeachingModel._Instance == null)
		{
			ComboTeachingModel.CreateInstance();
		}
		return ComboTeachingModel._Instance;
	}

	// Token: 0x060085D9 RID: 34265 RVA: 0x0028E7EC File Offset: 0x0028C9EC
	public static bool CreateInstance()
	{
		if (ComboTeachingModel._Instance != null)
		{
			return true;
		}
		ComboTeachingModel._Instance = new ComboTeachingModel();
		return true;
	}

	// Token: 0x060085DA RID: 34266 RVA: 0x0028E802 File Offset: 0x0028CA02
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060085DB RID: 34267 RVA: 0x0028E804 File Offset: 0x0028CA04
	public static void ResetStaticDefaultValue()
	{
		ComboTeachingModel._Instance = null;
	}

	// Token: 0x060085DC RID: 34268 RVA: 0x0028E80C File Offset: 0x0028CA0C
	static ComboTeachingModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ComboTeachingModel.CreateStaticDefaultValue), new Action(ComboTeachingModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005158 RID: 20824
	private long UseSkillIdInternal;

	// Token: 0x04005159 RID: 20825
	private float UseSkillTimeInternal;

	// Token: 0x0400515A RID: 20826
	private bool PreNextAttrInternal;

	// Token: 0x0400515B RID: 20827
	private bool NextAttrInternal;

	// Token: 0x0400515C RID: 20828
	private int CurrentNodeIndexInternal;

	// Token: 0x0400515D RID: 20829
	private long NextAttrSkillIdInternal;

	// Token: 0x0400515E RID: 20830
	private readonly List<long> AddBuffListInternal = new List<long>();

	// Token: 0x0400515F RID: 20831
	private readonly List<string> AddTagListInternal = new List<string>();

	// Token: 0x04005160 RID: 20832
	private int RecoveryComboIdInternal;

	// Token: 0x04005161 RID: 20833
	private bool IsEmitInternal;

	// Token: 0x04005162 RID: 20834
	private bool IsCloseInternal;

	// Token: 0x04005163 RID: 20835
	private float BeforeJumpTimeInternal;

	// Token: 0x04005164 RID: 20836
	private bool InitStartInternal;

	// Token: 0x04005165 RID: 20837
	[Nullable(2)]
	private static ComboTeachingModel _Instance;
}
