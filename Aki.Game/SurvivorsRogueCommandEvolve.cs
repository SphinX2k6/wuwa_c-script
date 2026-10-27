using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02002AE0 RID: 10976
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCommandEvolve : SurvivorsRogueCommandBase
{
	// Token: 0x06016D74 RID: 93556 RVA: 0x005CC25B File Offset: 0x005CA45B
	public SurvivorsRogueCommandEvolve(ESurvivorsRogueCommandType type) : base(type)
	{
	}

	// Token: 0x06016D75 RID: 93557 RVA: 0x005CC264 File Offset: 0x005CA464
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[Evolve] Count: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.GetEvolveData().Count);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06016D76 RID: 93558 RVA: 0x005CC2A0 File Offset: 0x005CA4A0
	protected override void OnStartExecute()
	{
		base.OpenView(EUiViewName.SurvivorsRogueEvolveView, true);
	}

	// Token: 0x06016D77 RID: 93559 RVA: 0x005CC2AE File Offset: 0x005CA4AE
	private IList<Aki.Protocol.SurvivorsGainData> GetEvolveData()
	{
		return this.Data.EvolveView.SurvivorsGainDatas;
	}

	// Token: 0x06016D78 RID: 93560 RVA: 0x005CC2C0 File Offset: 0x005CA4C0
	protected override void OnUpdate()
	{
	}

	// Token: 0x06016D79 RID: 93561 RVA: 0x005CC2C2 File Offset: 0x005CA4C2
	protected override void Back2Fore()
	{
	}

	// Token: 0x06016D7A RID: 93562 RVA: 0x005CC2C4 File Offset: 0x005CA4C4
	protected override void Fore2Back()
	{
	}

	// Token: 0x06016D7B RID: 93563 RVA: 0x005CC2C6 File Offset: 0x005CA4C6
	protected override void OnExecute()
	{
	}

	// Token: 0x06016D7C RID: 93564 RVA: 0x005CC2C8 File Offset: 0x005CA4C8
	protected override void OnFinish()
	{
		base.RequestCommand(new int[1], null);
	}

	// Token: 0x06016D7D RID: 93565 RVA: 0x005CC2D7 File Offset: 0x005CA4D7
	protected override void OnDelete()
	{
	}

	// Token: 0x06016D7E RID: 93566 RVA: 0x005CC2DC File Offset: 0x005CA4DC
	public List<SurvivorsEvolveViewInfo> GetViewInfoList()
	{
		List<SurvivorsEvolveViewInfo> list = new List<SurvivorsEvolveViewInfo>();
		IEnumerable<Aki.Protocol.SurvivorsGainData> evolveData = this.GetEvolveData();
		Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
		foreach (Aki.Protocol.SurvivorsGainData survivorsGainData in evolveData)
		{
			SurvivorsEvolveViewInfo survivorsEvolveViewInfo = null;
			string a2 = survivorsGainData.DataCase.ToString();
			if (!(a2 == "Proto_SurvivorsRoleEvolve"))
			{
				if (a2 == "Proto_SurvivorsWeaponEvolve")
				{
					SurvivorsWeaponEvolve survivorsWeaponEvolve = survivorsGainData.SurvivorsWeaponEvolve;
					bool flag = survivorsWeaponEvolve.WeaponBondId > 0;
					survivorsEvolveViewInfo = new SurvivorsEvolveViewInfo
					{
						SourceType = ESurvivorsRogueItemType.Weapon,
						SourceId = survivorsWeaponEvolve.WeaponId,
						TitleId = (flag ? "SurvivorsWeaponEvolution_SuperTitle" : "SurvivorsWeaponEvolution_Title"),
						EvolveId = survivorsGainData.ConfigId,
						BondType = new ESurvivorsRogueItemType?(ESurvivorsRogueItemType.Weapon),
						BondId = new int?(survivorsWeaponEvolve.WeaponBondId)
					};
					List<int> list2;
					if (!dictionary.TryGetValue(survivorsWeaponEvolve.WeaponId, out list2))
					{
						list2 = new List<int>();
						dictionary[survivorsWeaponEvolve.WeaponId] = list2;
					}
					list2.Add(survivorsGainData.ConfigId);
				}
			}
			else
			{
				SurvivorsRoleEvolve survivorsRoleEvolve = survivorsGainData.SurvivorsRoleEvolve;
				survivorsEvolveViewInfo = new SurvivorsEvolveViewInfo
				{
					SourceType = ESurvivorsRogueItemType.Character,
					SourceId = survivorsRoleEvolve.RoleId,
					TitleId = "SurvivorsRoleEvolution_Title",
					EvolveId = survivorsGainData.ConfigId
				};
			}
			if (survivorsEvolveViewInfo != null)
			{
				list.Add(survivorsEvolveViewInfo);
			}
		}
		list.Sort(delegate(SurvivorsEvolveViewInfo a, SurvivorsEvolveViewInfo b)
		{
			if (a.SourceType != b.SourceType)
			{
				return b.SourceType - a.SourceType;
			}
			if (a.SourceId != b.SourceId)
			{
				return a.SourceId - b.SourceId;
			}
			return a.EvolveId - b.EvolveId;
		});
		for (int i = 0; i < list.Count; i++)
		{
			SurvivorsEvolveViewInfo survivorsEvolveViewInfo2 = list[i];
			SurvivorsEvolveViewInfo survivorsEvolveViewInfo3 = (i + 1 < list.Count) ? list[i + 1] : null;
			if (survivorsEvolveViewInfo2.SourceType == ESurvivorsRogueItemType.Weapon)
			{
				if (i != list.Count - 1)
				{
					int sourceId = survivorsEvolveViewInfo2.SourceId;
					int? num = (survivorsEvolveViewInfo3 != null) ? new int?(survivorsEvolveViewInfo3.SourceId) : null;
					if (sourceId == num.GetValueOrDefault() & num != null)
					{
						goto IL_233;
					}
				}
				List<int> list3;
				survivorsEvolveViewInfo2.WeaponEvolveIds = (dictionary.TryGetValue(survivorsEvolveViewInfo2.SourceId, out list3) ? list3.ToArray() : null);
				survivorsEvolveViewInfo2.PlayTween = new bool?(true);
			}
			IL_233:;
		}
		return list;
	}
}
