using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000EC7 RID: 3783
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueEntityModel : SurvivorsRogueEntityBaseModel, ISurvivorsRogueCombatInfo, IStaticVariableResetter
{
	// Token: 0x1700072A RID: 1834
	// (get) Token: 0x06005DD3 RID: 24019 RVA: 0x001149F0 File Offset: 0x00112BF0
	// (set) Token: 0x06005DD4 RID: 24020 RVA: 0x001149F8 File Offset: 0x00112BF8
	public ESurvivorsRogueEntityType EntityType { get; set; }

	// Token: 0x1700072B RID: 1835
	// (get) Token: 0x06005DD5 RID: 24021 RVA: 0x00114A01 File Offset: 0x00112C01
	// (set) Token: 0x06005DD6 RID: 24022 RVA: 0x00114A09 File Offset: 0x00112C09
	public int Uid { get; set; }

	// Token: 0x1700072C RID: 1836
	// (get) Token: 0x06005DD7 RID: 24023 RVA: 0x00114A12 File Offset: 0x00112C12
	// (set) Token: 0x06005DD8 RID: 24024 RVA: 0x00114A1A File Offset: 0x00112C1A
	public int OwnerId { get; set; }

	// Token: 0x1700072D RID: 1837
	// (get) Token: 0x06005DD9 RID: 24025 RVA: 0x00114A23 File Offset: 0x00112C23
	// (set) Token: 0x06005DDA RID: 24026 RVA: 0x00114A2B File Offset: 0x00112C2B
	public int TemplateId { get; set; }

	// Token: 0x1700072E RID: 1838
	// (get) Token: 0x06005DDB RID: 24027 RVA: 0x00114A34 File Offset: 0x00112C34
	// (set) Token: 0x06005DDC RID: 24028 RVA: 0x00114A3C File Offset: 0x00112C3C
	public int CombatId { get; set; }

	// Token: 0x1700072F RID: 1839
	// (get) Token: 0x06005DDD RID: 24029 RVA: 0x00114A45 File Offset: 0x00112C45
	// (set) Token: 0x06005DDE RID: 24030 RVA: 0x00114A4D File Offset: 0x00112C4D
	public int SubTypeId { get; set; }

	// Token: 0x17000730 RID: 1840
	// (get) Token: 0x06005DDF RID: 24031 RVA: 0x00114A56 File Offset: 0x00112C56
	// (set) Token: 0x06005DE0 RID: 24032 RVA: 0x00114A5E File Offset: 0x00112C5E
	public string PrefabPath { get; set; }

	// Token: 0x17000731 RID: 1841
	// (get) Token: 0x06005DE1 RID: 24033 RVA: 0x00114A67 File Offset: 0x00112C67
	// (set) Token: 0x06005DE2 RID: 24034 RVA: 0x00114A6F File Offset: 0x00112C6F
	public string AssetPath { get; set; }

	// Token: 0x17000732 RID: 1842
	// (get) Token: 0x06005DE3 RID: 24035 RVA: 0x00114A78 File Offset: 0x00112C78
	// (set) Token: 0x06005DE4 RID: 24036 RVA: 0x00114A80 File Offset: 0x00112C80
	public int PropertyId { get; set; }

	// Token: 0x17000733 RID: 1843
	// (get) Token: 0x06005DE5 RID: 24037 RVA: 0x00114A89 File Offset: 0x00112C89
	// (set) Token: 0x06005DE6 RID: 24038 RVA: 0x00114A91 File Offset: 0x00112C91
	public int? SplineId { get; set; }

	// Token: 0x17000734 RID: 1844
	// (get) Token: 0x06005DE7 RID: 24039 RVA: 0x00114A9A File Offset: 0x00112C9A
	// (set) Token: 0x06005DE8 RID: 24040 RVA: 0x00114AA2 File Offset: 0x00112CA2
	public Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x17000735 RID: 1845
	// (get) Token: 0x06005DE9 RID: 24041 RVA: 0x00114AAB File Offset: 0x00112CAB
	// (set) Token: 0x06005DEA RID: 24042 RVA: 0x00114AB3 File Offset: 0x00112CB3
	public Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x17000736 RID: 1846
	// (get) Token: 0x06005DEB RID: 24043 RVA: 0x00114ABC File Offset: 0x00112CBC
	// (set) Token: 0x06005DEC RID: 24044 RVA: 0x00114AC4 File Offset: 0x00112CC4
	[Nullable(1)]
	public global::Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000737 RID: 1847
	// (get) Token: 0x06005DED RID: 24045 RVA: 0x00114ACD File Offset: 0x00112CCD
	// (set) Token: 0x06005DEE RID: 24046 RVA: 0x00114AD5 File Offset: 0x00112CD5
	[Nullable(1)]
	public global::Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x06005DEF RID: 24047 RVA: 0x00114AE0 File Offset: 0x00112CE0
	public SurvivorsRogueEntityModel()
	{
		this.Position = global::Vector.Create(0.0, 0.0, 0.0);
		this.Rotation = global::Rotator.Create(0f, 0f, 0f);
	}

	// Token: 0x06005DF0 RID: 24048 RVA: 0x00114B33 File Offset: 0x00112D33
	static SurvivorsRogueEntityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SurvivorsRogueEntityModel.CreateStaticDefaultValue), new Action(SurvivorsRogueEntityModel.ResetStaticDefaultValue));
	}

	// Token: 0x06005DF1 RID: 24049 RVA: 0x00114B52 File Offset: 0x00112D52
	public static void CreateStaticDefaultValue()
	{
		SurvivorsRogueEntityModel.EntityPool = new Pool<SurvivorsRogueEntityModel>(100, () => new SurvivorsRogueEntityModel(), null);
	}

	// Token: 0x06005DF2 RID: 24050 RVA: 0x00114B80 File Offset: 0x00112D80
	public static void ResetStaticDefaultValue()
	{
		SurvivorsRogueEntityModel.EntityPool = null;
	}

	// Token: 0x06005DF3 RID: 24051 RVA: 0x00114B88 File Offset: 0x00112D88
	[NullableContext(1)]
	[return: Nullable(2)]
	public new static ISurvivorsRogueCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		if (!componentDataMap.ContainsKey("SimpleCombatComponentPb"))
		{
			return null;
		}
		SurvivorsRogueEntityModel survivorsRogueEntityModel = SurvivorsRogueEntityModel.EntityPool.Get();
		if (survivorsRogueEntityModel == null)
		{
			survivorsRogueEntityModel = SurvivorsRogueEntityModel.EntityPool.Create();
		}
		if (survivorsRogueEntityModel != null)
		{
			survivorsRogueEntityModel.InitFromProto(entityData, componentDataMap);
		}
		return survivorsRogueEntityModel;
	}

	// Token: 0x06005DF4 RID: 24052 RVA: 0x00114BC9 File Offset: 0x00112DC9
	public new static void Clear()
	{
		SurvivorsRogueEntityModel.EntityPool.Clear();
	}

	// Token: 0x06005DF5 RID: 24053 RVA: 0x00114BD8 File Offset: 0x00112DD8
	[NullableContext(1)]
	protected virtual void InitFromProto(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		SimpleCombatComponentPb simpleCombatComponentPb = componentDataMap["SimpleCombatComponentPb"].SimpleCombatComponentPb;
		this.Uid = (int)MathUtils.Instance.LongToNumber(entityData.Id);
		this.OwnerId = (int)MathUtils.Instance.LongToNumber(entityData.OwnerIncId);
		this.TemplateId = entityData.ConfigId;
		this.CombatId = 0;
		this.SubTypeId = simpleCombatComponentPb.SubTypeId;
		this.PrefabPath = null;
		this.AssetPath = null;
		this.PropertyId = 0;
		this.SplineId = ((simpleCombatComponentPb.SplineConfigId != 0) ? new int?(simpleCombatComponentPb.SplineConfigId) : null);
		this.BuffIdLayers = ((simpleCombatComponentPb.BuffLayers != null) ? new Dictionary<int, int>(simpleCombatComponentPb.BuffLayers) : null);
		this.AttributeMap = ((simpleCombatComponentPb.AttributeMap != null) ? new Dictionary<int, int>(simpleCombatComponentPb.AttributeMap) : null);
		Aki.Protocol.Vector pos = entityData.Pos;
		if (pos != null)
		{
			this.Position.Set((double)pos.X, (double)pos.Y, (double)pos.Z);
		}
		Aki.Protocol.Rotator rot = entityData.Rot;
		if (rot != null)
		{
			this.Rotation.Set(rot.Pitch, rot.Yaw, rot.Roll);
		}
	}

	// Token: 0x06005DF6 RID: 24054 RVA: 0x00114D08 File Offset: 0x00112F08
	[NullableContext(1)]
	public virtual void Update(ISurvivorsRogueCombatInfo other)
	{
		this.Uid = other.Uid;
		this.OwnerId = other.OwnerId;
		this.TemplateId = other.TemplateId;
		this.CombatId = other.CombatId;
		this.SubTypeId = other.SubTypeId;
		this.PrefabPath = other.PrefabPath;
		this.AssetPath = other.AssetPath;
		this.PropertyId = other.PropertyId;
		this.SplineId = other.SplineId;
		this.BuffIdLayers = other.BuffIdLayers;
		this.AttributeMap = other.AttributeMap;
		this.Position.Set(other.Position.X, other.Position.Y, other.Position.Z);
		this.Rotation.Set(other.Rotation.Pitch, other.Rotation.Yaw, other.Rotation.Roll);
	}

	// Token: 0x06005DF7 RID: 24055 RVA: 0x00114DF1 File Offset: 0x00112FF1
	public bool IsValid()
	{
		return this.Uid > 0;
	}

	// Token: 0x06005DF8 RID: 24056 RVA: 0x00114DFC File Offset: 0x00112FFC
	public void Reset()
	{
		this.Uid = 0;
		this.OwnerId = 0;
		this.TemplateId = 0;
		this.CombatId = 0;
		this.SubTypeId = 0;
		this.PrefabPath = null;
		this.AssetPath = null;
		this.PropertyId = 0;
		this.SplineId = null;
		this.BuffIdLayers = null;
		this.AttributeMap = null;
		this.Position.Set(0.0, 0.0, 0.0);
		this.Rotation.Set(0f, 0f, 0f);
	}

	// Token: 0x06005DF9 RID: 24057 RVA: 0x00114E9E File Offset: 0x0011309E
	public void Release()
	{
		this.Reset();
		SurvivorsRogueEntityModel.EntityPool.Put(this);
	}

	// Token: 0x06005DFA RID: 24058 RVA: 0x00114EB4 File Offset: 0x001130B4
	[NullableContext(1)]
	public ISurvivorsRogueCombatInfo Clone()
	{
		SurvivorsRogueEntityModel survivorsRogueEntityModel = SurvivorsRogueEntityModel.EntityPool.Get();
		if (survivorsRogueEntityModel == null)
		{
			survivorsRogueEntityModel = SurvivorsRogueEntityModel.EntityPool.Create();
		}
		if (survivorsRogueEntityModel != null)
		{
			survivorsRogueEntityModel.Update(this);
		}
		return survivorsRogueEntityModel;
	}

	// Token: 0x04002ABF RID: 10943
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<SurvivorsRogueEntityModel> EntityPool;
}
