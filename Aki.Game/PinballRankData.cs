using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020013E4 RID: 5092
[NullableContext(2)]
[Nullable(0)]
public class PinballRankData
{
	// Token: 0x06008FBE RID: 36798 RVA: 0x001F14AF File Offset: 0x001EF6AF
	public PinballRankData(bool isMyRank)
	{
		this.IsMyRank = isMyRank;
	}

	// Token: 0x06008FBF RID: 36799 RVA: 0x001F14D4 File Offset: 0x001EF6D4
	public static bool IsValidServerRankData(Aki.Protocol.PinballRankData data)
	{
		return data != null && data.TowerLevel > 0;
	}

	// Token: 0x06008FC0 RID: 36800 RVA: 0x001F14E4 File Offset: 0x001EF6E4
	public void SetDataByConfig(int towerLevel)
	{
		PinballRank? pinballRankConfigByTower = PinballConfig.Instance.GetPinballRankConfigByTower(towerLevel);
		if (pinballRankConfigByTower != null)
		{
			this.TowerLevel = pinballRankConfigByTower.Value.Tower;
			this.CostTime = pinballRankConfigByTower.Value.PassTime;
			this.DisplayThreshold = pinballRankConfigByTower.Value.DisplayThreshold;
			string name;
			if ((name = ConfigMultiTextLang.GetLocalTextNew(pinballRankConfigByTower.Value.PlayerName, null)) == null)
			{
				name = (pinballRankConfigByTower.Value.PlayerName ?? "");
			}
			this.Name = name;
			this.Formation = new List<ValueTuple<int, int>>();
			int roleListLength = pinballRankConfigByTower.Value.RoleListLength;
			for (int i = 0; i < roleListLength; i++)
			{
				string text = pinballRankConfigByTower.Value.RoleList(i);
				if (text != null)
				{
					string[] array = text.Split(':', StringSplitOptions.None);
					if (array.Length >= 2)
					{
						int num;
						int num2;
						this.Formation.Add(new ValueTuple<int, int>(int.TryParse(array[0], out num) ? num : 0, int.TryParse(array[1], out num2) ? num2 : 0));
					}
				}
			}
			this.HasData = true;
		}
	}

	// Token: 0x06008FC1 RID: 36801 RVA: 0x001F160C File Offset: 0x001EF80C
	public void SetDataByServerInfo(Aki.Protocol.PinballRankData data)
	{
		if (!global::PinballRankData.IsValidServerRankData(data))
		{
			return;
		}
		this.Name = data.Name;
		this.TowerLevel = data.TowerLevel;
		this.CostTime = data.CostTime;
		this.Formation = new List<ValueTuple<int, int>>();
		foreach (Aki.Protocol.PinballRoleData pinballRoleData in data.Formation)
		{
			this.Formation.Add(new ValueTuple<int, int>(pinballRoleData.ConfigId, pinballRoleData.RoleLevel));
		}
		this.HasData = true;
	}

	// Token: 0x06008FC2 RID: 36802 RVA: 0x001F16B0 File Offset: 0x001EF8B0
	public void SetMyRankData(Aki.Protocol.PinballRankData data)
	{
		if (!global::PinballRankData.IsValidServerRankData(data))
		{
			this.Name = FunctionModel.Instance.GetPlayerName();
			this.TowerLevel = 0;
			this.CostTime = 0;
			this.Formation = new List<ValueTuple<int, int>>();
			this.HasData = false;
			return;
		}
		this.SetDataByServerInfo(data);
	}

	// Token: 0x04003F8B RID: 16267
	public int Ranking;

	// Token: 0x04003F8C RID: 16268
	[Nullable(1)]
	public string Name = "";

	// Token: 0x04003F8D RID: 16269
	public int TowerLevel;

	// Token: 0x04003F8E RID: 16270
	public int CostTime;

	// Token: 0x04003F8F RID: 16271
	public bool HasData;

	// Token: 0x04003F90 RID: 16272
	public int DisplayThreshold;

	// Token: 0x04003F91 RID: 16273
	[TupleElementNames(new string[]
	{
		"RoleId",
		"Level"
	})]
	[Nullable(new byte[]
	{
		1,
		0
	})]
	public List<ValueTuple<int, int>> Formation = new List<ValueTuple<int, int>>();

	// Token: 0x04003F92 RID: 16274
	public bool IsMyRank;
}
