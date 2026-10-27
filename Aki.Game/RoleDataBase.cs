using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020027B8 RID: 10168
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleDataBase
{
	// Token: 0x06014E9F RID: 85663 RVA: 0x0054FAB0 File Offset: 0x0054DCB0
	public RoleDataBase(int id)
	{
		this.Id = id;
		this.Name = RoleConfig.Instance.GetRoleName(this.GetRoleConfig().Name);
		this.InitModelData();
	}

	// Token: 0x06014EA0 RID: 85664 RVA: 0x0054FB70 File Offset: 0x0054DD70
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

	// Token: 0x06014EA1 RID: 85665 RVA: 0x0054FBC3 File Offset: 0x0054DDC3
	public RoleLevelData GetLevelData()
	{
		return (RoleLevelData)this.ModelDataMap[typeof(RoleLevelData)];
	}

	// Token: 0x06014EA2 RID: 85666 RVA: 0x0054FBDF File Offset: 0x0054DDDF
	public RoleAttributeData GetAttributeData()
	{
		return (RoleAttributeData)this.ModelDataMap[typeof(RoleAttributeData)];
	}

	// Token: 0x06014EA3 RID: 85667 RVA: 0x0054FBFB File Offset: 0x0054DDFB
	public RoleSkillData GetSkillData()
	{
		return (RoleSkillData)this.ModelDataMap[typeof(RoleSkillData)];
	}

	// Token: 0x06014EA4 RID: 85668 RVA: 0x0054FC17 File Offset: 0x0054DE17
	public RoleResonanceData GetResonanceData()
	{
		return (RoleResonanceData)this.ModelDataMap[typeof(RoleResonanceData)];
	}

	// Token: 0x06014EA5 RID: 85669 RVA: 0x0054FC33 File Offset: 0x0054DE33
	public RolePhantomData GetPhantomData()
	{
		return (RolePhantomData)this.ModelDataMap[typeof(RolePhantomData)];
	}

	// Token: 0x06014EA6 RID: 85670 RVA: 0x0054FC4F File Offset: 0x0054DE4F
	public RoleAudioData GetAudioData()
	{
		return (RoleAudioData)this.ModelDataMap[typeof(RoleAudioData)];
	}

	// Token: 0x06014EA7 RID: 85671 RVA: 0x0054FC6B File Offset: 0x0054DE6B
	public RoleFavorData GetFavorData()
	{
		return (RoleFavorData)this.ModelDataMap[typeof(RoleFavorData)];
	}

	// Token: 0x06014EA8 RID: 85672 RVA: 0x0054FC87 File Offset: 0x0054DE87
	public void SetRoleSkinId(int skinId)
	{
		this.SkinId = skinId;
	}

	// Token: 0x06014EA9 RID: 85673 RVA: 0x0054FC90 File Offset: 0x0054DE90
	public virtual int GetRoleSkinId()
	{
		if (this.SkinId <= 0)
		{
			return this.GetRoleConfig().SkinId;
		}
		return this.SkinId;
	}

	// Token: 0x06014EAA RID: 85674 RVA: 0x0054FCBB File Offset: 0x0054DEBB
	public void SetBackgroundMusicEnabled(bool bEnable)
	{
		this.BackgroundMusicEnable = bEnable;
	}

	// Token: 0x06014EAB RID: 85675 RVA: 0x0054FCC4 File Offset: 0x0054DEC4
	public bool GetBackgroundMusicEnabled()
	{
		return this.BackgroundMusicEnable;
	}

	// Token: 0x06014EAC RID: 85676 RVA: 0x0054FCCC File Offset: 0x0054DECC
	public ElementInfo? GetElementInfo()
	{
		RoleInfo roleConfig = this.GetRoleConfig();
		return ElementInfoConfig.Instance.GetElementInfo(roleConfig.ElementId);
	}

	// Token: 0x06014EAD RID: 85677 RVA: 0x0054FCF4 File Offset: 0x0054DEF4
	public RoleQualityInfo GetQualityConfig()
	{
		RoleInfo roleConfig = this.GetRoleConfig();
		return RoleConfig.Instance.GetRoleQualityInfo(roleConfig.QualityId).Value;
	}

	// Token: 0x06014EAE RID: 85678 RVA: 0x0054FD24 File Offset: 0x0054DF24
	public RoleInfo GetRoleConfig()
	{
		return RoleConfig.Instance.GetRoleConfig(this.GetRoleId()).Value;
	}

	// Token: 0x06014EAF RID: 85679 RVA: 0x0054FD4C File Offset: 0x0054DF4C
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

	// Token: 0x06014EB0 RID: 85680 RVA: 0x0054FD8E File Offset: 0x0054DF8E
	public int GetDataId()
	{
		return this.Id;
	}

	// Token: 0x06014EB1 RID: 85681 RVA: 0x0054FD98 File Offset: 0x0054DF98
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

	// Token: 0x06014EB2 RID: 85682 RVA: 0x0054FEE8 File Offset: 0x0054E0E8
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

	// Token: 0x06014EB3 RID: 85683 RVA: 0x0054FFB0 File Offset: 0x0054E1B0
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

	// Token: 0x06014EB4 RID: 85684 RVA: 0x005500FC File Offset: 0x0054E2FC
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

	// Token: 0x06014EB5 RID: 85685 RVA: 0x0055016C File Offset: 0x0054E36C
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

	// Token: 0x06014EB6 RID: 85686
	public abstract bool IsTrialRole();

	// Token: 0x06014EB7 RID: 85687
	public abstract bool IsOnlineRole();

	// Token: 0x06014EB8 RID: 85688
	public abstract int GetRoleId();

	// Token: 0x06014EB9 RID: 85689
	public abstract string GetName(int? playerId = null);

	// Token: 0x06014EBA RID: 85690
	public abstract bool CanChangeName();

	// Token: 0x06014EBB RID: 85691
	public abstract int GetRoleCreateTime();

	// Token: 0x06014EBC RID: 85692
	public abstract bool GetIsNew();

	// Token: 0x06014EBD RID: 85693 RVA: 0x005501B7 File Offset: 0x0054E3B7
	public virtual bool TryRemoveNewFlag()
	{
		return false;
	}

	// Token: 0x04009D17 RID: 40215
	protected int Id;

	// Token: 0x04009D18 RID: 40216
	protected string Name;

	// Token: 0x04009D19 RID: 40217
	[Nullable(2)]
	protected SModelConfig RoleModelConfig;

	// Token: 0x04009D1A RID: 40218
	private readonly Dictionary<Type, RoleModuleDataBase> ModelDataMap = new Dictionary<Type, RoleModuleDataBase>();

	// Token: 0x04009D1B RID: 40219
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

	// Token: 0x04009D1C RID: 40220
	private int SkinId = -1;

	// Token: 0x04009D1D RID: 40221
	private bool BackgroundMusicEnable = true;
}
