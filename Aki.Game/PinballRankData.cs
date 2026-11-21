using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02000898 RID: 2200
[NullableContext(2)]
[Nullable(0)]
public class PinballRankData
{
	// Token: 0x06006353 RID: 25427 RVA: 0x001F9FEB File Offset: 0x001F81EB
	public PinballRankData(bool isMyRank)
	{
		this.IsMyRank = isMyRank;
	}

	// Token: 0x06006354 RID: 25428 RVA: 0x001FA010 File Offset: 0x001F8210
	public static bool IsValidServerRankData(Aki.Protocol.PinballRankData data)
	{
		return data != null && data.TowerLevel > 0;
	}

	// Token: 0x06006355 RID: 25429 RVA: 0x001FA020 File Offset: 0x001F8220
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

	// Token: 0x06006356 RID: 25430 RVA: 0x001FA148 File Offset: 0x001F8348
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

	// Token: 0x06006357 RID: 25431 RVA: 0x001FA1EC File Offset: 0x001F83EC
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

	// Token: 0x04004023 RID: 16419
	public int Ranking;

	// Token: 0x04004024 RID: 16420
	[Nullable(1)]
	public string Name = "";

	// Token: 0x04004025 RID: 16421
	public int TowerLevel;

	// Token: 0x04004026 RID: 16422
	public int CostTime;

	// Token: 0x04004027 RID: 16423
	public bool HasData;

	// Token: 0x04004028 RID: 16424
	public int DisplayThreshold;

	// Token: 0x04004029 RID: 16425
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

	// Token: 0x0400402A RID: 16426
	public bool IsMyRank;
}
