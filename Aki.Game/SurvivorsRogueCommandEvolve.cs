using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x0200205C RID: 8284
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCommandEvolve : SurvivorsRogueCommandBase
{
	// Token: 0x060147A5 RID: 83877 RVA: 0x005F8DAB File Offset: 0x005F6FAB
	public SurvivorsRogueCommandEvolve(ESurvivorsRogueCommandType type) : base(type)
	{
	}

	// Token: 0x060147A6 RID: 83878 RVA: 0x005F8DB4 File Offset: 0x005F6FB4
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[Evolve] Count: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.GetEvolveData().Count);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060147A7 RID: 83879 RVA: 0x005F8DF0 File Offset: 0x005F6FF0
	protected override void OnStartExecute()
	{
		base.OpenView(EUiViewName.SurvivorsRogueEvolveView, true);
	}

	// Token: 0x060147A8 RID: 83880 RVA: 0x005F8DFE File Offset: 0x005F6FFE
	private IList<Aki.Protocol.SurvivorsGainData> GetEvolveData()
	{
		return this.Data.EvolveView.SurvivorsGainDatas;
	}

	// Token: 0x060147A9 RID: 83881 RVA: 0x005F8E10 File Offset: 0x005F7010
	protected override void OnUpdate()
	{
	}

	// Token: 0x060147AA RID: 83882 RVA: 0x005F8E12 File Offset: 0x005F7012
	protected override void Back2Fore()
	{
	}

	// Token: 0x060147AB RID: 83883 RVA: 0x005F8E14 File Offset: 0x005F7014
	protected override void Fore2Back()
	{
	}

	// Token: 0x060147AC RID: 83884 RVA: 0x005F8E16 File Offset: 0x005F7016
	protected override void OnExecute()
	{
	}

	// Token: 0x060147AD RID: 83885 RVA: 0x005F8E18 File Offset: 0x005F7018
	protected override void OnFinish()
	{
		base.RequestCommand(new int[1], null);
	}

	// Token: 0x060147AE RID: 83886 RVA: 0x005F8E27 File Offset: 0x005F7027
	protected override void OnDelete()
	{
	}

	// Token: 0x060147AF RID: 83887 RVA: 0x005F8E2C File Offset: 0x005F702C
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
