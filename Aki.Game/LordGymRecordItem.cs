using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001683 RID: 5763
[NullableContext(1)]
[Nullable(0)]
public class LordGymRecordItem : UiPanelBase, IGridProxy<LordGym>
{
	// Token: 0x17001578 RID: 5496
	// (get) Token: 0x0600E049 RID: 57417 RVA: 0x0041D15E File Offset: 0x0041B35E
	// (set) Token: 0x0600E04A RID: 57418 RVA: 0x0041D166 File Offset: 0x0041B366
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IScrollViewDelegate<IGridProxy<LordGym>, LordGym> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17001579 RID: 5497
	// (get) Token: 0x0600E04B RID: 57419 RVA: 0x0041D16F File Offset: 0x0041B36F
	// (set) Token: 0x0600E04C RID: 57420 RVA: 0x0041D177 File Offset: 0x0041B377
	public int GridIndex { get; set; }

	// Token: 0x1700157A RID: 5498
	// (get) Token: 0x0600E04D RID: 57421 RVA: 0x0041D180 File Offset: 0x0041B380
	// (set) Token: 0x0600E04E RID: 57422 RVA: 0x0041D188 File Offset: 0x0041B388
	public int DisplayIndex { get; set; }

	// Token: 0x0600E04F RID: 57423 RVA: 0x0041D194 File Offset: 0x0041B394
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x0600E050 RID: 57424 RVA: 0x0041D267 File Offset: 0x0041B467
	protected override void OnStart()
	{
		this.RoleLayout = new GenericLayout<RoleItem, RoleBrief>(base.GetHorizontalLayout(3), new Func<RoleItem>(this.CreateRoleItem), null, false, true);
	}

	// Token: 0x0600E051 RID: 57425 RVA: 0x0041D28A File Offset: 0x0041B48A
	public void Clear()
	{
	}

	// Token: 0x0600E052 RID: 57426 RVA: 0x0041D28C File Offset: 0x0041B48C
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600E053 RID: 57427 RVA: 0x0041D28E File Offset: 0x0041B48E
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600E054 RID: 57428 RVA: 0x0041D290 File Offset: 0x0041B490
	public void Refresh(LordGym data, bool isSelected, int gridIndex)
	{
		if (data.MonsterListLength == 0)
		{
			return;
		}
		int num = data.MonsterList(0);
		if (num == 0)
		{
			return;
		}
		string bossIconPath = this.GetBossIconPath(data.Id);
		base.SetTextureByPath(bossIconPath, base.GetTexture(7), null, null);
		string monsterName = MonsterInfoConfig.Instance.GetMonsterName(num);
		base.GetText(0).SetText(monsterName, true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_InstanceDungeonRecommendLevel_Text", new <>z__ReadOnlySingleElementList<object>(data.MonsterLevel.ToString()));
		bool lordGymIsUnLock = LordGymModel.Instance.GetLordGymIsUnLock(data.Id);
		bool lastGymFinish = LordGymModel.Instance.GetLastGymFinish(data.Id);
		LordGymPassRecord lordGymPassRecord;
		LordGymModel.Instance.LordGymRecord.TryGetValue(data.Id, out lordGymPassRecord);
		bool flag = lordGymPassRecord != null;
		bool uiactive = !lordGymIsUnLock || !lastGymFinish;
		bool uiactive2 = lordGymIsUnLock && lastGymFinish && !flag;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "PrefabTextItem_LordLocked_Text", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "PrefabTextItem_LordNorecord_Text", Array.Empty<object>());
		base.GetItem(5).SetUIActive(uiactive);
		base.GetText(4).SetUIActive(uiactive2);
		base.GetText(2).SetUIActive(flag && lordGymIsUnLock);
		this.RoleLayout.SetActive(flag);
		if (lordGymIsUnLock && flag && lordGymPassRecord != null)
		{
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(TimeUtil.Instance.GetTimeString((double)lordGymPassRecord.PassTime), true);
			}
			this.RoleLayout.RefreshByData(this.GetRoleItemData(lordGymPassRecord), null, false);
		}
	}

	// Token: 0x0600E055 RID: 57429 RVA: 0x0041D438 File Offset: 0x0041B638
	private List<RoleBrief> GetRoleItemData(LordGymPassRecord recordData)
	{
		List<RoleBrief> list = new List<RoleBrief>(3);
		for (int i = 0; i < 3; i++)
		{
			if (i < recordData.RoleIds.Count)
			{
				list.Add(recordData.RoleIds[i]);
			}
			else
			{
				RoleBrief roleBrief = RoleBrief.Create();
				roleBrief.RoleId = -1;
				roleBrief.Level = 1;
				list.Add(roleBrief);
			}
		}
		return list;
	}

	// Token: 0x0600E056 RID: 57430 RVA: 0x0041D498 File Offset: 0x0041B698
	private string GetBossIconPath(int gymId)
	{
		IReadOnlyList<LordGymEntrance> lordGymEntranceAllConfig = LordGymConfig.Instance.GetLordGymEntranceAllConfig();
		int num = 0;
		if (lordGymEntranceAllConfig != null)
		{
			foreach (LordGymEntrance lordGymEntrance in lordGymEntranceAllConfig)
			{
				int[] array = lordGymEntrance.LordGymList();
				if (array != null)
				{
					bool flag = false;
					int[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						if (array2[i] == gymId)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						num = lordGymEntrance.Id;
						break;
					}
				}
			}
		}
		if (num == 0)
		{
			return "";
		}
		IReadOnlyList<SilentAreaDetection> allSilentAreaDetection = AdventureGuideConfig.Instance.GetAllSilentAreaDetection();
		if (allSilentAreaDetection != null)
		{
			foreach (SilentAreaDetection silentAreaDetection in allSilentAreaDetection)
			{
				if (silentAreaDetection.Secondary == 61 && silentAreaDetection.AdditionalId == num)
				{
					return silentAreaDetection.BigIcon;
				}
			}
		}
		return "";
	}

	// Token: 0x0600E057 RID: 57431 RVA: 0x0041D5A4 File Offset: 0x0041B7A4
	public object GetKey(LordGym data, int gridIndex)
	{
		return data.Id;
	}

	// Token: 0x0600E058 RID: 57432 RVA: 0x0041D5B2 File Offset: 0x0041B7B2
	private RoleItem CreateRoleItem()
	{
		return new RoleItem();
	}

	// Token: 0x040080B5 RID: 32949
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleItem, RoleBrief> RoleLayout;

	// Token: 0x02007855 RID: 30805
	[NullableContext(0)]
	private class ERecordComponents
	{
		// Token: 0x040270D2 RID: 159954
		public const int TxtBoss = 0;

		// Token: 0x040270D3 RID: 159955
		public const int TxtLevel = 1;

		// Token: 0x040270D4 RID: 159956
		public const int TxtTime = 2;

		// Token: 0x040270D5 RID: 159957
		public const int PnlHLayout = 3;

		// Token: 0x040270D6 RID: 159958
		public const int TxtNoneRecord = 4;

		// Token: 0x040270D7 RID: 159959
		public const int PnlLock = 5;

		// Token: 0x040270D8 RID: 159960
		public const int TxtLock = 6;

		// Token: 0x040270D9 RID: 159961
		public const int TexBossIcon = 7;
	}
}
