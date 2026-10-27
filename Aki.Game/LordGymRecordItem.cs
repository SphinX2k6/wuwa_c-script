using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200219F RID: 8607
[NullableContext(1)]
[Nullable(0)]
public class LordGymRecordItem : UiPanelBase, IGridProxy<LordGym>
{
	// Token: 0x17001541 RID: 5441
	// (get) Token: 0x06010BB8 RID: 68536 RVA: 0x00410876 File Offset: 0x0040EA76
	// (set) Token: 0x06010BB9 RID: 68537 RVA: 0x0041087E File Offset: 0x0040EA7E
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

	// Token: 0x17001542 RID: 5442
	// (get) Token: 0x06010BBA RID: 68538 RVA: 0x00410887 File Offset: 0x0040EA87
	// (set) Token: 0x06010BBB RID: 68539 RVA: 0x0041088F File Offset: 0x0040EA8F
	public int GridIndex { get; set; }

	// Token: 0x17001543 RID: 5443
	// (get) Token: 0x06010BBC RID: 68540 RVA: 0x00410898 File Offset: 0x0040EA98
	// (set) Token: 0x06010BBD RID: 68541 RVA: 0x004108A0 File Offset: 0x0040EAA0
	public int DisplayIndex { get; set; }

	// Token: 0x06010BBE RID: 68542 RVA: 0x004108AC File Offset: 0x0040EAAC
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

	// Token: 0x06010BBF RID: 68543 RVA: 0x0041097F File Offset: 0x0040EB7F
	protected override void OnStart()
	{
		this.RoleLayout = new GenericLayout<RoleItem, RoleBrief>(base.GetHorizontalLayout(3), new Func<RoleItem>(this.CreateRoleItem), null, false, true);
	}

	// Token: 0x06010BC0 RID: 68544 RVA: 0x004109A2 File Offset: 0x0040EBA2
	public void Clear()
	{
	}

	// Token: 0x06010BC1 RID: 68545 RVA: 0x004109A4 File Offset: 0x0040EBA4
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x06010BC2 RID: 68546 RVA: 0x004109A6 File Offset: 0x0040EBA6
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x06010BC3 RID: 68547 RVA: 0x004109A8 File Offset: 0x0040EBA8
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

	// Token: 0x06010BC4 RID: 68548 RVA: 0x00410B50 File Offset: 0x0040ED50
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

	// Token: 0x06010BC5 RID: 68549 RVA: 0x00410BB0 File Offset: 0x0040EDB0
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

	// Token: 0x06010BC6 RID: 68550 RVA: 0x00410CBC File Offset: 0x0040EEBC
	public object GetKey(LordGym data, int gridIndex)
	{
		return data.Id;
	}

	// Token: 0x06010BC7 RID: 68551 RVA: 0x00410CCA File Offset: 0x0040EECA
	private RoleItem CreateRoleItem()
	{
		return new RoleItem();
	}

	// Token: 0x04007F6E RID: 32622
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleItem, RoleBrief> RoleLayout;

	// Token: 0x020086CA RID: 34506
	[NullableContext(0)]
	private class ERecordComponents
	{
		// Token: 0x0402BDB1 RID: 179633
		public const int TxtBoss = 0;

		// Token: 0x0402BDB2 RID: 179634
		public const int TxtLevel = 1;

		// Token: 0x0402BDB3 RID: 179635
		public const int TxtTime = 2;

		// Token: 0x0402BDB4 RID: 179636
		public const int PnlHLayout = 3;

		// Token: 0x0402BDB5 RID: 179637
		public const int TxtNoneRecord = 4;

		// Token: 0x0402BDB6 RID: 179638
		public const int PnlLock = 5;

		// Token: 0x0402BDB7 RID: 179639
		public const int TxtLock = 6;

		// Token: 0x0402BDB8 RID: 179640
		public const int TexBossIcon = 7;
	}
}
