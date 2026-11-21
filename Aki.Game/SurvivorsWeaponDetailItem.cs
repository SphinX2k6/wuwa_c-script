using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200208C RID: 8332
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsWeaponDetailItem : GridProxyAbstract<int>
{
	// Token: 0x060148C4 RID: 84164 RVA: 0x005FCDE4 File Offset: 0x005FAFE4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUITexture))
		};
	}

	// Token: 0x060148C5 RID: 84165 RVA: 0x005FCF64 File Offset: 0x005FB164
	protected override void OnStart()
	{
		this.EntryLayout = new GenericLayout<EntryItem, IEntryItemData>(base.GetVerticalLayout(9), new Func<EntryItem>(this.CreateGridProxy), base.GetItem(10).GetOwner() as AUIBaseActor, false, true);
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(11),
			ViewType = ETermExplanationViewType.Center,
			ReportType = ETermExplanationReportType.SurvivorsRogue
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x060148C6 RID: 84166 RVA: 0x005FCFD3 File Offset: 0x005FB1D3
	private EntryItem CreateGridProxy()
	{
		return new EntryItem();
	}

	// Token: 0x060148C7 RID: 84167 RVA: 0x005FCFDA File Offset: 0x005FB1DA
	public void SetIsCurrentState(bool state)
	{
		UUIItem item = base.GetItem(12);
		if (item != null)
		{
			item.SetUIActive(state);
		}
		UUITexture texture = base.GetTexture(15);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(state);
	}

	// Token: 0x060148C8 RID: 84168 RVA: 0x005FD003 File Offset: 0x005FB203
	public void SetIsLocked(bool isLocked)
	{
		UUIItem item = base.GetItem(14);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isLocked);
	}

	// Token: 0x060148C9 RID: 84169 RVA: 0x005FD018 File Offset: 0x005FB218
	public override void Refresh(int evolveId, bool isSelected, int gridIndex)
	{
		this.RefreshByWeaponEvolveId(evolveId);
	}

	// Token: 0x060148CA RID: 84170 RVA: 0x005FD024 File Offset: 0x005FB224
	public void RefreshByWeaponEvolveId(int weaponEvolveId)
	{
		SurvivorsWeaponEvolve? survivorsWeaponEvolve = SurvivorsRogueConfig.Instance.GetSurvivorsWeaponEvolve(weaponEvolveId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), survivorsWeaponEvolve.Value.EvolveName, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), survivorsWeaponEvolve.Value.Describe, Array.Empty<object>());
		base.SetTextureShowUntilLoaded(SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(survivorsWeaponEvolve.Value.WeaponId).Value.Icon, base.GetTexture(8), null);
		SurvivorsQuality? qualityConfig = SurvivorsRogueConfig.Instance.GetQualityConfig(survivorsWeaponEvolve.Value.Quality);
		this.SetColorFromHex(qualityConfig.Value.WeaponColor ?? "");
		base.SetTextureShowUntilLoaded(qualityConfig.Value.WeaponEvolvePath, base.GetTexture(3), null);
		this.RefreshEntryList(survivorsWeaponEvolve.Value);
	}

	// Token: 0x060148CB RID: 84171 RVA: 0x005FD124 File Offset: 0x005FB324
	private void RefreshEntryList(SurvivorsWeaponEvolve config)
	{
		List<IEntryItemData> list = new List<IEntryItemData>();
		List<int> list2 = new List<int>();
		for (int i = 0; i < config.ConditionArgsLength; i++)
		{
			DicIntInt? dicIntInt = config.ConditionArgs(i);
			if (dicIntInt != null)
			{
				list2.Add(dicIntInt.Value.Key);
			}
		}
		for (int j = 0; j < list2.Count; j++)
		{
			int weaponId = list2[j];
			DicIntInt? dicIntInt2 = config.ConditionArgs(j);
			if (dicIntInt2 != null)
			{
				int value = dicIntInt2.Value.Value;
				List<string> list3 = new List<string>();
				list3.Add(ConfigMultiTextLang.GetLocalTextNew(SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(weaponId).Value.Name, null) ?? "");
				list3.Add(value.ToString());
				string text = "";
				if (j < config.UnlockDescLength)
				{
					text = (config.UnlockDesc(j) ?? "");
				}
				SurvivorsQuality? qualityConfig = SurvivorsRogueConfig.Instance.GetQualityConfig(config.Quality);
				list.Add(new EntryItemData
				{
					Text = text,
					Args = list3.ToArray(),
					Color = (qualityConfig.Value.WeaponColor ?? "")
				});
			}
		}
		this.EntryLayout.RefreshByData(list, null, false);
	}

	// Token: 0x060148CC RID: 84172 RVA: 0x005FD294 File Offset: 0x005FB494
	private void SetColorFromHex(string hex)
	{
		FColor color = FColor.FromHex(hex);
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			sprite.SetColor(color);
		}
		UUISprite sprite2 = base.GetSprite(1);
		if (sprite2 != null)
		{
			sprite2.SetColor(color);
		}
		UUISprite sprite3 = base.GetSprite(2);
		if (sprite3 != null)
		{
			sprite3.SetColor(color);
		}
		UUISprite sprite4 = base.GetSprite(4);
		if (sprite4 != null)
		{
			sprite4.SetColor(color);
		}
		UUISprite sprite5 = base.GetSprite(5);
		if (sprite5 != null)
		{
			sprite5.SetColor(color);
		}
		UUISprite sprite6 = base.GetSprite(7);
		if (sprite6 == null)
		{
			return;
		}
		sprite6.SetColor(color);
	}

	// Token: 0x0400AE50 RID: 44624
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<EntryItem, IEntryItemData> EntryLayout;
}
