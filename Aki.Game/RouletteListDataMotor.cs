using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;

// Token: 0x02001E96 RID: 7830
[NullableContext(1)]
[Nullable(0)]
public class RouletteListDataMotor : RouletteListDataBase
{
	// Token: 0x17001D89 RID: 7561
	// (get) Token: 0x06013549 RID: 79177 RVA: 0x005A4B8A File Offset: 0x005A2D8A
	public override ERouletteType RouletteType
	{
		get
		{
			return ERouletteType.Motor;
		}
	}

	// Token: 0x17001D8A RID: 7562
	// (get) Token: 0x0601354A RID: 79178 RVA: 0x005A4B8D File Offset: 0x005A2D8D
	public override ERoulettePriority Priority
	{
		get
		{
			return ERoulettePriority.Special;
		}
	}

	// Token: 0x0601354B RID: 79179 RVA: 0x005A4B90 File Offset: 0x005A2D90
	public override List<int> GetRouletteIdList()
	{
		return this.RouletteIdListServer;
	}

	// Token: 0x0601354C RID: 79180 RVA: 0x005A4B98 File Offset: 0x005A2D98
	public override int GetExtraItemId()
	{
		return 0;
	}

	// Token: 0x0601354D RID: 79181 RVA: 0x005A4B9B File Offset: 0x005A2D9B
	public override int GetEquipExploreSkillId()
	{
		return this.EquipExploreSkillIdServer;
	}

	// Token: 0x0601354E RID: 79182 RVA: 0x005A4BA3 File Offset: 0x005A2DA3
	public override void Init()
	{
	}

	// Token: 0x0601354F RID: 79183 RVA: 0x005A4BA5 File Offset: 0x005A2DA5
	public override void Clear()
	{
	}

	// Token: 0x06013550 RID: 79184 RVA: 0x005A4BA7 File Offset: 0x005A2DA7
	public override bool IsActivate()
	{
		return this.InActivate;
	}

	// Token: 0x06013551 RID: 79185 RVA: 0x005A4BB0 File Offset: 0x005A2DB0
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

	// Token: 0x06013552 RID: 79186 RVA: 0x005A4C18 File Offset: 0x005A2E18
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

	// Token: 0x06013553 RID: 79187 RVA: 0x005A4C60 File Offset: 0x005A2E60
	public override bool IsRouletteReplace()
	{
		return false;
	}

	// Token: 0x06013554 RID: 79188 RVA: 0x005A4C64 File Offset: 0x005A2E64
	public override bool IsRouletteOpen()
	{
		ExploreRouletteType? exploreRouletteTypeById = RouletteConfig.Instance.GetExploreRouletteTypeById((int)this.RouletteType);
		return exploreRouletteTypeById != null && (exploreRouletteTypeById.Value.UnlockFuncId == 0 || FunctionModel.Instance.IsOpen(exploreRouletteTypeById.Value.UnlockFuncId));
	}

	// Token: 0x06013555 RID: 79189 RVA: 0x005A4CBC File Offset: 0x005A2EBC
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

	// Token: 0x06013556 RID: 79190 RVA: 0x005A4D4D File Offset: 0x005A2F4D
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

	// Token: 0x06013557 RID: 79191 RVA: 0x005A4D64 File Offset: 0x005A2F64
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

	// Token: 0x06013558 RID: 79192 RVA: 0x005A4DA8 File Offset: 0x005A2FA8
	public override RouletteMainViewProxyBase GetRouletteMainViewProxy()
	{
		return new MotorRouletteMainViewProxy();
	}

	// Token: 0x06013559 RID: 79193 RVA: 0x005A4DAF File Offset: 0x005A2FAF
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

	// Token: 0x0601355A RID: 79194 RVA: 0x005A4DB7 File Offset: 0x005A2FB7
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

	// Token: 0x0601355B RID: 79195 RVA: 0x005A4DDC File Offset: 0x005A2FDC
	private List<AssemblyGridData> CreateAllAssemblyDataExplore()
	{
		List<AssemblyExploreGridData> list = new List<AssemblyExploreGridData>();
		foreach (KeyValuePair<int, ExploreTools> keyValuePair in RouletteModel.Instance.UnlockExploreSkillDataMap)
		{
			int key = keyValuePair.Key;
			ExploreTools value = keyValuePair.Value;
			if (NoLinq.Contains<int>(value.GetRouletteTypeBytes(), (int)this.RouletteType) && value.CanAssemblyShow)
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
		return new List<AssemblyGridData>(list);
	}

	// Token: 0x0400A5A3 RID: 42403
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

	// Token: 0x0400A5A4 RID: 42404
	private bool InActivate;
}
