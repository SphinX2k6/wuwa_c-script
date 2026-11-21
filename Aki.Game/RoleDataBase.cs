using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001D33 RID: 7475
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleDataBase
{
	// Token: 0x0601289E RID: 75934 RVA: 0x0057A7D4 File Offset: 0x005789D4
	public RoleDataBase(int id)
	{
		this.Id = id;
		this.Name = RoleConfig.Instance.GetRoleName(this.GetRoleConfig().Name);
		this.InitModelData();
	}

	// Token: 0x0601289F RID: 75935 RVA: 0x0057A894 File Offset: 0x00578A94
	private void InitModelData()
	{
		int roleId = this.GetRoleId();
		foreach (Type type in this.ModelDataList)
		{
			this.ModelDataMap[type] = (RoleModuleDataBase)Activator.CreateInstance(type, new object[]
			{
				roleId
			});
		}
	}

	// Token: 0x060128A0 RID: 75936 RVA: 0x0057A8E7 File Offset: 0x00578AE7
	public RoleLevelData GetLevelData()
	{
		return (RoleLevelData)this.ModelDataMap[typeof(RoleLevelData)];
	}

	// Token: 0x060128A1 RID: 75937 RVA: 0x0057A903 File Offset: 0x00578B03
	public RoleAttributeData GetAttributeData()
	{
		return (RoleAttributeData)this.ModelDataMap[typeof(RoleAttributeData)];
	}

	// Token: 0x060128A2 RID: 75938 RVA: 0x0057A91F File Offset: 0x00578B1F
	public RoleSkillData GetSkillData()
	{
		return (RoleSkillData)this.ModelDataMap[typeof(RoleSkillData)];
	}

	// Token: 0x060128A3 RID: 75939 RVA: 0x0057A93B File Offset: 0x00578B3B
	public RoleResonanceData GetResonanceData()
	{
		return (RoleResonanceData)this.ModelDataMap[typeof(RoleResonanceData)];
	}

	// Token: 0x060128A4 RID: 75940 RVA: 0x0057A957 File Offset: 0x00578B57
	public RolePhantomData GetPhantomData()
	{
		return (RolePhantomData)this.ModelDataMap[typeof(RolePhantomData)];
	}

	// Token: 0x060128A5 RID: 75941 RVA: 0x0057A973 File Offset: 0x00578B73
	public RoleAudioData GetAudioData()
	{
		return (RoleAudioData)this.ModelDataMap[typeof(RoleAudioData)];
	}

	// Token: 0x060128A6 RID: 75942 RVA: 0x0057A98F File Offset: 0x00578B8F
	public RoleFavorData GetFavorData()
	{
		return (RoleFavorData)this.ModelDataMap[typeof(RoleFavorData)];
	}

	// Token: 0x060128A7 RID: 75943 RVA: 0x0057A9AB File Offset: 0x00578BAB
	public void SetRoleSkinId(int skinId)
	{
		this.SkinId = skinId;
	}

	// Token: 0x060128A8 RID: 75944 RVA: 0x0057A9B4 File Offset: 0x00578BB4
	public virtual int GetRoleSkinId()
	{
		if (this.SkinId <= 0)
		{
			return this.GetRoleConfig().SkinId;
		}
		return this.SkinId;
	}

	// Token: 0x060128A9 RID: 75945 RVA: 0x0057A9DF File Offset: 0x00578BDF
	public void SetBackgroundMusicEnabled(bool bEnable)
	{
		this.BackgroundMusicEnable = bEnable;
	}

	// Token: 0x060128AA RID: 75946 RVA: 0x0057A9E8 File Offset: 0x00578BE8
	public bool GetBackgroundMusicEnabled()
	{
		return this.BackgroundMusicEnable;
	}

	// Token: 0x060128AB RID: 75947 RVA: 0x0057A9F0 File Offset: 0x00578BF0
	public ElementInfo? GetElementInfo()
	{
		RoleInfo roleConfig = this.GetRoleConfig();
		return ElementInfoConfig.Instance.GetElementInfo(roleConfig.ElementId);
	}

	// Token: 0x060128AC RID: 75948 RVA: 0x0057AA18 File Offset: 0x00578C18
	public RoleQualityInfo GetQualityConfig()
	{
		RoleInfo roleConfig = this.GetRoleConfig();
		return RoleConfig.Instance.GetRoleQualityInfo(roleConfig.QualityId).Value;
	}

	// Token: 0x060128AD RID: 75949 RVA: 0x0057AA48 File Offset: 0x00578C48
	public RoleInfo GetRoleConfig()
	{
		return RoleConfig.Instance.GetRoleConfig(this.GetRoleId()).Value;
	}

	// Token: 0x060128AE RID: 75950 RVA: 0x0057AA70 File Offset: 0x00578C70
	[NullableContext(2)]
	public IReadOnlyList<SkillTree> GetRoleSkillTreeConfig()
	{
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.GetRoleId());
		if (roleConfig == null)
		{
			return null;
		}
		return RoleSkillConfig.Instance.GetSkillTreeNodeListByGroupId(roleConfig.Value.SkillTreeGroupId);
	}

	// Token: 0x060128AF RID: 75951 RVA: 0x0057AAB2 File Offset: 0x00578CB2
	public int GetDataId()
	{
		return this.Id;
	}

	// Token: 0x060128B0 RID: 75952 RVA: 0x0057AABC File Offset: 0x00578CBC
	public List<AttrListScrollData> GetShowAttrList()
	{
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		IReadOnlyList<PropertyIndex> propertyIndexList = PropertyIndexConfig.Instance.GetPropertyIndexList();
		if (propertyIndexList == null)
		{
			return list;
		}
		SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)this.Id, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.ConfigId,
			OnlyMyRole = new bool?(true)
		});
		BaseAttributeComponent baseAttributeComponent = (teamItem != null) ? teamItem.EntityHandle.Entity.GetComponent<BaseAttributeComponent>() : null;
		foreach (PropertyIndex propertyIndex in propertyIndexList)
		{
			if (propertyIndex.IsShow)
			{
				float num;
				float num2;
				if (baseAttributeComponent != null)
				{
					num = baseAttributeComponent.GetBaseValue((EAttributeType)propertyIndex.Id);
					num2 = baseAttributeComponent.GetCurrentValue((EAttributeType)propertyIndex.Id) - num;
				}
				else
				{
					RoleAttributeData attributeData = this.GetAttributeData();
					num = (float)attributeData.GetRoleBaseAttr(propertyIndex.Id);
					num2 = (float)attributeData.GetRoleAddAttr(propertyIndex.Id);
				}
				RoleAttrListScrollData item = new RoleAttrListScrollData(propertyIndex.Id, (double)num, (double)num2, propertyIndex.Priority, false, CommonComponentDefine.EAttributeType.NormalType);
				list.Add(item);
			}
		}
		FormationAttrListScrollData[] teamAttribute = this.GetTeamAttribute();
		list.AddRange(teamAttribute);
		list.Sort(new Comparison<AttrListScrollData>(this.SortAttrList));
		return list;
	}

	// Token: 0x060128B1 RID: 75953 RVA: 0x0057AC0C File Offset: 0x00578E0C
	private FormationAttrListScrollData[] GetTeamAttribute()
	{
		List<FormationAttrListScrollData> list = new List<FormationAttrListScrollData>();
		foreach (int num in new int[]
		{
			10
		})
		{
			FormationProperty? config = ConfigFormationPropertyById.GetConfig(num, true);
			if (config != null && LevelGeneralController.Instance.CheckCondition(config.Value.Condition.ToString(), null, true, Array.Empty<object>()))
			{
				IAttributeData data = FormationAttributeModel.Instance.GetData((EFormationAttributeId)num);
				if (data != null)
				{
					FormationAttrListScrollData item = new FormationAttrListScrollData(num, (double)(data.Max / 100f), 0.0, config.Value.Priority, false, CommonComponentDefine.EAttributeType.NormalType);
					list.Add(item);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x060128B2 RID: 75954 RVA: 0x0057ACD4 File Offset: 0x00578ED4
	public unsafe virtual float GetShowAttributeValueById(int id)
	{
		SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)this.Id, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.ConfigId,
			OnlyMyRole = new bool?(true)
		});
		BaseAttributeComponent baseAttributeComponent;
		if (teamItem == null)
		{
			baseAttributeComponent = null;
		}
		else
		{
			EntityHandle entityHandle = teamItem.EntityHandle;
			if (entityHandle == null)
			{
				baseAttributeComponent = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				baseAttributeComponent = ((entity != null) ? entity.GetComponent<BaseAttributeComponent>() : null);
			}
		}
		BaseAttributeComponent baseAttributeComponent2 = baseAttributeComponent;
		float num;
		if (baseAttributeComponent2 != null)
		{
			num = baseAttributeComponent2.GetCurrentValue((EAttributeType)id);
			if (num == 0f)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "角色界面获取实体属性值为0";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		else
		{
			RoleAttributeData attributeData = this.GetAttributeData();
			int roleBaseAttr = attributeData.GetRoleBaseAttr(id);
			int roleAddAttr = attributeData.GetRoleAddAttr(id);
			num = (float)(roleBaseAttr + roleAddAttr);
			if (num == 0f)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Character;
				ELogAuthor author2 = ELogAuthor.LZK;
				string message2 = "角色界面从服务器获取的属性值为0";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("baseAttr", roleBaseAttr);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("addAttr", roleAddAttr);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
		}
		return num;
	}

	// Token: 0x060128B3 RID: 75955 RVA: 0x0057AE20 File Offset: 0x00579020
	public float GetBaseAttributeValueById(int id)
	{
		SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)this.Id, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.ConfigId,
			OnlyMyRole = new bool?(true)
		});
		BaseAttributeComponent baseAttributeComponent = (teamItem != null) ? teamItem.EntityHandle.Entity.GetComponent<BaseAttributeComponent>() : null;
		float result;
		if (baseAttributeComponent != null)
		{
			result = baseAttributeComponent.GetBaseValue((EAttributeType)id);
		}
		else
		{
			result = (float)this.GetAttributeData().GetRoleBaseAttr(id);
		}
		return result;
	}

	// Token: 0x060128B4 RID: 75956 RVA: 0x0057AE90 File Offset: 0x00579090
	protected int SortAttrList(AttrListScrollData dataA, AttrListScrollData dataB)
	{
		bool flag = dataA.Priority != 0;
		bool flag2 = dataB.Priority != 0;
		if (flag && flag2)
		{
			return dataA.Priority - dataB.Priority;
		}
		if (flag)
		{
			return -1;
		}
		if (flag2)
		{
			return 1;
		}
		return dataA.Id - dataB.Id;
	}

	// Token: 0x060128B5 RID: 75957
	public abstract bool IsTrialRole();

	// Token: 0x060128B6 RID: 75958
	public abstract bool IsOnlineRole();

	// Token: 0x060128B7 RID: 75959
	public abstract int GetRoleId();

	// Token: 0x060128B8 RID: 75960
	public abstract string GetName(int? playerId = null);

	// Token: 0x060128B9 RID: 75961
	public abstract bool CanChangeName();

	// Token: 0x060128BA RID: 75962
	public abstract int GetRoleCreateTime();

	// Token: 0x060128BB RID: 75963
	public abstract bool GetIsNew();

	// Token: 0x060128BC RID: 75964 RVA: 0x0057AEDB File Offset: 0x005790DB
	public virtual bool TryRemoveNewFlag()
	{
		return false;
	}

	// Token: 0x0400A0FA RID: 41210
	protected int Id;

	// Token: 0x0400A0FB RID: 41211
	protected string Name;

	// Token: 0x0400A0FC RID: 41212
	[Nullable(2)]
	protected SModelConfig RoleModelConfig;

	// Token: 0x0400A0FD RID: 41213
	private readonly Dictionary<Type, RoleModuleDataBase> ModelDataMap = new Dictionary<Type, RoleModuleDataBase>();

	// Token: 0x0400A0FE RID: 41214
	private readonly Type[] ModelDataList = new Type[]
	{
		typeof(RoleLevelData),
		typeof(RoleAttributeData),
		typeof(RoleSkillData),
		typeof(RoleResonanceData),
		typeof(RolePhantomData),
		typeof(RoleAudioData),
		typeof(RoleFavorData)
	};

	// Token: 0x0400A0FF RID: 41215
	private int SkinId = -1;

	// Token: 0x0400A100 RID: 41216
	private bool BackgroundMusicEnable = true;
}
