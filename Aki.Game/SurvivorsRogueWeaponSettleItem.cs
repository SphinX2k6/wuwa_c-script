using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B6F RID: 11119
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRogueWeaponSettleItem : GridProxyAbstract<ISurvivorsWeaponGridData>
{
	// Token: 0x0601707F RID: 94335 RVA: 0x005D8C08 File Offset: 0x005D6E08
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

	// Token: 0x06017080 RID: 94336 RVA: 0x005D8CE8 File Offset: 0x005D6EE8
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueWeaponSettleItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueWeaponSettleItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06017081 RID: 94337 RVA: 0x005D8D2B File Offset: 0x005D6F2B
	protected override void OnStart()
	{
		this.EvolveItemList = new GenericLayout<SurvivorsRogueWeaponEvolveItem, IWeaponEvolveData>(base.GetHorizontalLayout(10), new Func<SurvivorsRogueWeaponEvolveItem>(this.CreateEvolveItem), null, false, true);
		this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnEventSequence));
	}

	// Token: 0x06017082 RID: 94338 RVA: 0x005D8D6B File Offset: 0x005D6F6B
	protected override void OnBeforeDestroy()
	{
		this.ScrollingNumberTool.Clear();
		this.RootActor.OnSequencePlayEvent.Unbind();
	}

	// Token: 0x06017083 RID: 94339 RVA: 0x005D8D88 File Offset: 0x005D6F88
	private SurvivorsRogueWeaponEvolveItem CreateEvolveItem()
	{
		return new SurvivorsRogueWeaponEvolveItem();
	}

	// Token: 0x06017084 RID: 94340 RVA: 0x005D8D8F File Offset: 0x005D6F8F
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

	// Token: 0x06017085 RID: 94341 RVA: 0x005D8DBC File Offset: 0x005D6FBC
	private void OnEventSequence(string sequenceName, string eventName)
	{
		if (sequenceName == "Start" && eventName == "Got")
		{
			this.PlayAnim();
		}
	}

	// Token: 0x06017086 RID: 94342 RVA: 0x005D8DE0 File Offset: 0x005D6FE0
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

	// Token: 0x06017087 RID: 94343 RVA: 0x005D8E32 File Offset: 0x005D7032
	private void SetStateDisable()
	{
		base.GetItem(0).SetUIActive(true);
		base.GetItem(1).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x06017088 RID: 94344 RVA: 0x005D8E5B File Offset: 0x005D705B
	private void SetStateLock()
	{
		base.GetItem(0).SetUIActive(false);
		base.GetItem(1).SetUIActive(true);
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x06017089 RID: 94345 RVA: 0x005D8E84 File Offset: 0x005D7084
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
		this.ScrollingNumberTool.Init(0, weaponData.Data.KillMonsterCount, delegate(float value)
		{
			base.GetText(8).SetText(MathF.Round(value).ToString(), true);
		}, 1000);
		base.SetTextureShowUntilLoaded(survivorsWeapon.Value.Icon, base.GetTexture(4), null);
	}

	// Token: 0x0601708A RID: 94346 RVA: 0x005D8F78 File Offset: 0x005D7178
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

	// Token: 0x0400AC43 RID: 44099
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SurvivorsRogueWeaponEvolveItem, IWeaponEvolveData> EvolveItemList;

	// Token: 0x0400AC44 RID: 44100
	protected ISurvivorsWeaponGridData Data;

	// Token: 0x0400AC45 RID: 44101
	private readonly ScrollingNumberTool ScrollingNumberTool = new ScrollingNumberTool();

	// Token: 0x0400AC46 RID: 44102
	private bool AnimPlayState;
}
