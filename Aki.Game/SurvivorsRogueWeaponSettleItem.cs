using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020EB RID: 8427
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRogueWeaponSettleItem : GridProxyAbstract<ISurvivorsWeaponGridData>
{
	// Token: 0x06014AB0 RID: 84656 RVA: 0x00605770 File Offset: 0x00603970
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
	}

	// Token: 0x06014AB1 RID: 84657 RVA: 0x00605850 File Offset: 0x00603A50
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueWeaponSettleItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueWeaponSettleItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014AB2 RID: 84658 RVA: 0x00605893 File Offset: 0x00603A93
	protected override void OnStart()
	{
		this.EvolveItemList = new GenericLayout<SurvivorsRogueWeaponEvolveItem, IWeaponEvolveData>(base.GetHorizontalLayout(10), new Func<SurvivorsRogueWeaponEvolveItem>(this.CreateEvolveItem), null, false, true);
		this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnEventSequence));
	}

	// Token: 0x06014AB3 RID: 84659 RVA: 0x006058D3 File Offset: 0x00603AD3
	protected override void OnBeforeDestroy()
	{
		this.ScrollingNumberTool.Clear();
		this.RootActor.OnSequencePlayEvent.Unbind();
	}

	// Token: 0x06014AB4 RID: 84660 RVA: 0x006058F0 File Offset: 0x00603AF0
	private SurvivorsRogueWeaponEvolveItem CreateEvolveItem()
	{
		return new SurvivorsRogueWeaponEvolveItem();
	}

	// Token: 0x06014AB5 RID: 84661 RVA: 0x006058F7 File Offset: 0x00603AF7
	public override void Refresh(ISurvivorsWeaponGridData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		if (data.IsDisable)
		{
			this.SetStateDisable();
			return;
		}
		if (data.IsLock)
		{
			this.SetStateLock();
			return;
		}
		this.SetStateNormal();
	}

	// Token: 0x06014AB6 RID: 84662 RVA: 0x00605924 File Offset: 0x00603B24
	private void OnEventSequence(string sequenceName, string eventName)
	{
		if (sequenceName == "Start" && eventName == "Got")
		{
			this.PlayAnim();
		}
	}

	// Token: 0x06014AB7 RID: 84663 RVA: 0x00605948 File Offset: 0x00603B48
	public void PlayAnim()
	{
		if (this.AnimPlayState)
		{
			return;
		}
		this.AnimPlayState = true;
		if (this.Data == null)
		{
			return;
		}
		if (this.Data.IsLock || this.Data.IsDisable)
		{
			return;
		}
		this.RefreshEvolveItemList();
		this.ScrollingNumberTool.StartScrolling();
	}

	// Token: 0x06014AB8 RID: 84664 RVA: 0x0060599A File Offset: 0x00603B9A
	private void SetStateDisable()
	{
		base.GetItem(0).SetUIActive(true);
		base.GetItem(1).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x06014AB9 RID: 84665 RVA: 0x006059C3 File Offset: 0x00603BC3
	private void SetStateLock()
	{
		base.GetItem(0).SetUIActive(false);
		base.GetItem(1).SetUIActive(true);
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x06014ABA RID: 84666 RVA: 0x006059EC File Offset: 0x00603BEC
	private void SetStateNormal()
	{
		base.GetItem(0).SetUIActive(false);
		base.GetItem(1).SetUIActive(false);
		base.GetItem(3).SetUIActive(true);
		SurvivorsWeaponGainData weaponData = this.Data.WeaponData;
		if (weaponData == null)
		{
			return;
		}
		SurvivorsWeapon? survivorsWeapon = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(weaponData.ConfigId);
		if (survivorsWeapon == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "SurvivorsCombat_Lv", new <>z__ReadOnlySingleElementList<object>(weaponData.Data.Level));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), survivorsWeapon.Value.Name, Array.Empty<object>());
		this.ScrollingNumberTool.Init(0f, (float)weaponData.Data.KillMonsterCount, delegate(float value)
		{
			base.GetText(8).SetText(MathF.Round(value).ToString(), true);
		}, 1000, null);
		base.SetTextureShowUntilLoaded(survivorsWeapon.Value.Icon, base.GetTexture(4), null);
	}

	// Token: 0x06014ABB RID: 84667 RVA: 0x00605AE8 File Offset: 0x00603CE8
	private void RefreshEvolveItemList()
	{
		SurvivorsWeaponGainData weaponData = this.Data.WeaponData;
		if (weaponData == null)
		{
			return;
		}
		SurvivorsWeapon? survivorsWeapon = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(weaponData.ConfigId);
		if (survivorsWeapon == null)
		{
			return;
		}
		List<IWeaponEvolveData> list = new List<IWeaponEvolveData>();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = 0; i < survivorsWeapon.Value.EvolveIdsLength; i++)
		{
			DicIntInt value = survivorsWeapon.Value.EvolveIds(i).Value;
			dictionary[value.Value] = value.Key;
		}
		List<int> list2 = new List<int>();
		foreach (int item in dictionary.Values)
		{
			list2.Add(item);
		}
		for (int j = 0; j < weaponData.Data.Evolves.Count; j++)
		{
			WeaponEvolveData item2 = new WeaponEvolveData
			{
				EvolveId = weaponData.Data.Evolves[j],
				IsUnlock = true,
				ShowLine = (j > 0)
			};
			list.Add(item2);
		}
		foreach (int num in list2)
		{
			if (!weaponData.Data.Evolves.Contains(num))
			{
				WeaponEvolveData item3 = new WeaponEvolveData
				{
					EvolveId = num,
					IsUnlock = false,
					ShowLine = (list.Count != 0)
				};
				list.Add(item3);
			}
		}
		this.EvolveItemList.RefreshByData(list, null, true);
	}

	// Token: 0x0400B049 RID: 45129
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SurvivorsRogueWeaponEvolveItem, IWeaponEvolveData> EvolveItemList;

	// Token: 0x0400B04A RID: 45130
	protected ISurvivorsWeaponGridData Data;

	// Token: 0x0400B04B RID: 45131
	private readonly ScrollingNumberTool ScrollingNumberTool = new ScrollingNumberTool();

	// Token: 0x0400B04C RID: 45132
	private bool AnimPlayState;
}
