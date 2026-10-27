using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;

// Token: 0x0200291B RID: 10523
[NullableContext(1)]
[Nullable(0)]
public class RouletteListDataMotor : RouletteListDataBase
{
	// Token: 0x17001D2F RID: 7471
	// (get) Token: 0x06015B45 RID: 88901 RVA: 0x00579C0A File Offset: 0x00577E0A
	public override ERouletteType RouletteType
	{
		get
		{
			return ERouletteType.Motor;
		}
	}

	// Token: 0x17001D30 RID: 7472
	// (get) Token: 0x06015B46 RID: 88902 RVA: 0x00579C0D File Offset: 0x00577E0D
	public override ERoulettePriority Priority
	{
		get
		{
			return ERoulettePriority.Special;
		}
	}

	// Token: 0x06015B47 RID: 88903 RVA: 0x00579C10 File Offset: 0x00577E10
	public override List<int> GetRouletteIdList()
	{
		return this.RouletteIdListServer;
	}

	// Token: 0x06015B48 RID: 88904 RVA: 0x00579C18 File Offset: 0x00577E18
	public override int GetExtraItemId()
	{
		return 0;
	}

	// Token: 0x06015B49 RID: 88905 RVA: 0x00579C1B File Offset: 0x00577E1B
	public override int GetEquipExploreSkillId()
	{
		return this.EquipExploreSkillIdServer;
	}

	// Token: 0x06015B4A RID: 88906 RVA: 0x00579C23 File Offset: 0x00577E23
	public override void Init()
	{
	}

	// Token: 0x06015B4B RID: 88907 RVA: 0x00579C25 File Offset: 0x00577E25
	public override void Clear()
	{
	}

	// Token: 0x06015B4C RID: 88908 RVA: 0x00579C27 File Offset: 0x00577E27
	public override bool IsActivate()
	{
		return this.InActivate;
	}

	// Token: 0x06015B4D RID: 88909 RVA: 0x00579C30 File Offset: 0x00577E30
	private void Activate()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Phantom;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[RouletteMotor] 激活";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EquipSkillId", this.EquipExploreSkillIdServer);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		CharacterExploreModel.Instance.SetExploreSkillId(this.EquipExploreSkillIdServer, EExploreSkillLayer.Roulette, "摩托轮盘激活");
		RouletteController.Instance.ExploreSkillSetRequest(this.EquipExploreSkillIdServer, null, false);
	}

	// Token: 0x06015B4E RID: 88910 RVA: 0x00579C98 File Offset: 0x00577E98
	private void Deactivate()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Phantom;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[RouletteMotor] 取消激活";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EquipSkillId", this.EquipExploreSkillIdServer);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		RouletteModel.Instance.RecoverEquipExploreSkillId();
	}

	// Token: 0x06015B4F RID: 88911 RVA: 0x00579CE0 File Offset: 0x00577EE0
	public override bool IsRouletteReplace()
	{
		return false;
	}

	// Token: 0x06015B50 RID: 88912 RVA: 0x00579CE4 File Offset: 0x00577EE4
	public override bool IsRouletteOpen()
	{
		ExploreRouletteType? exploreRouletteTypeById = RouletteConfig.Instance.GetExploreRouletteTypeById((int)this.RouletteType);
		return exploreRouletteTypeById != null && (exploreRouletteTypeById.Value.UnlockFuncId == 0 || FunctionModel.Instance.IsOpen(exploreRouletteTypeById.Value.UnlockFuncId));
	}

	// Token: 0x06015B51 RID: 88913 RVA: 0x00579D3C File Offset: 0x00577F3C
	public override bool IsMainRouletteCanOpenView(bool checkTips)
	{
		if (!this.IsRouletteOpen())
		{
			return false;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		object obj;
		if (getCurrentEntity == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			obj = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null && obj2.HasAnyTag(RouletteModel.Instance.GetExploreRouletteBanTagIds()))
		{
			if (checkTips)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ExploreToolCantOpen", Array.Empty<object>());
			}
			return false;
		}
		if (!LevelFuncFlagModel.Instance.GetFuncFlagEnable(ELevelFuncFlagId.ExploreSkillRoulette))
		{
			if (checkTips)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ExploreToolCantOpen", Array.Empty<object>());
			}
			return false;
		}
		return true;
	}

	// Token: 0x06015B52 RID: 88914 RVA: 0x00579DCD File Offset: 0x00577FCD
	public override Dictionary<ERouletteGridType, List<AssemblyGridData>> CreateAssemblyGridData()
	{
		return new Dictionary<ERouletteGridType, List<AssemblyGridData>>
		{
			{
				ERouletteGridType.Explore,
				this.CreateAllAssemblyDataExplore()
			}
		};
	}

	// Token: 0x06015B53 RID: 88915 RVA: 0x00579DE4 File Offset: 0x00577FE4
	public override int? GetRouletteGridId(int index, ERouletteGridType type, bool useDisplay)
	{
		if (type != ERouletteGridType.Explore)
		{
			return null;
		}
		List<int> rouletteIdList = this.GetRouletteIdList();
		if (index >= 0 && index < rouletteIdList.Count)
		{
			return new int?(rouletteIdList[index]);
		}
		return null;
	}

	// Token: 0x06015B54 RID: 88916 RVA: 0x00579E28 File Offset: 0x00578028
	public override RouletteMainViewProxyBase GetRouletteMainViewProxy()
	{
		return new MotorRouletteMainViewProxy();
	}

	// Token: 0x06015B55 RID: 88917 RVA: 0x00579E2F File Offset: 0x0057802F
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public override List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> GetRouletteDataMap()
	{
		return this.MotorRouletteMap;
	}

	// Token: 0x06015B56 RID: 88918 RVA: 0x00579E37 File Offset: 0x00578037
	public void ChangeRouletteActivateStatus(bool bActive)
	{
		if (this.InActivate == bActive)
		{
			return;
		}
		this.InActivate = bActive;
		if (bActive)
		{
			this.Activate();
			return;
		}
		this.Deactivate();
	}

	// Token: 0x06015B57 RID: 88919 RVA: 0x00579E5C File Offset: 0x0057805C
	private List<AssemblyGridData> CreateAllAssemblyDataExplore()
	{
		List<AssemblyExploreGridData> list = new List<AssemblyExploreGridData>();
		foreach (KeyValuePair<int, ExploreTools> keyValuePair in RouletteModel.Instance.UnlockExploreSkillDataMap)
		{
			int key = keyValuePair.Key;
			ExploreTools value = keyValuePair.Value;
			if (value.GetRouletteTypeArray().Contains((int)this.RouletteType) && value.CanAssemblyShow)
			{
				AssemblyExploreGridData assemblyExploreGridData = new AssemblyExploreGridData();
				assemblyExploreGridData.GridType = ERouletteGridType.Explore;
				assemblyExploreGridData.IconPath = value.BackGround;
				assemblyExploreGridData.Name = value.Name;
				assemblyExploreGridData.Id = key;
				int? sort = value.GetSort((int)this.RouletteType);
				if (sort != null && sort.Value > 0)
				{
					assemblyExploreGridData.SortId = sort.Value;
				}
				else
				{
					assemblyExploreGridData.SortId = 0;
				}
				list.Add(assemblyExploreGridData);
			}
		}
		list.Sort((AssemblyExploreGridData a, AssemblyExploreGridData b) => a.SortId - b.SortId);
		return list.Cast<AssemblyGridData>().ToList<AssemblyGridData>();
	}

	// Token: 0x0400A1B8 RID: 41400
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	private readonly List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> MotorRouletteMap = new List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>>
	{
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			1
		}, ERouletteComponentNode.RouletteItem1, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			2
		}, ERouletteComponentNode.RouletteItem2, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			3
		}, ERouletteComponentNode.RouletteItem3, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			4
		}, ERouletteComponentNode.RouletteItem4, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			5
		}, ERouletteComponentNode.RouletteItem5, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			6
		}, ERouletteComponentNode.RouletteItem6, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			7
		}, ERouletteComponentNode.RouletteItem7, ERouletteGridType.Explore),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			8
		}, ERouletteComponentNode.RouletteItem8, ERouletteGridType.Explore)
	};

	// Token: 0x0400A1B9 RID: 41401
	private bool InActivate;
}
