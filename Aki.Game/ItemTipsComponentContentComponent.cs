using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018D0 RID: 6352
[NullableContext(1)]
[Nullable(0)]
public class ItemTipsComponentContentComponent : UiPanelBase
{
	// Token: 0x0600BA56 RID: 47702 RVA: 0x002A3340 File Offset: 0x002A1540
	[NullableContext(2)]
	public TipsBaseSubComponent GetComponentByType(EItemTipsType type)
	{
		if (!this.TipsSubComponentMap.ContainsKey(type))
		{
			Type type2;
			if (!this.TypeComponentRelationMap.TryGetValue(type, out type2))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Item;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[ItemTips] 常规Tips组件未注册,请检查类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			UUIItem item = base.GetItem(4);
			TipsBaseSubComponent value = (TipsBaseSubComponent)Activator.CreateInstance(type2, new object[]
			{
				item
			});
			this.TipsSubComponentMap.Add(type, value);
		}
		TipsBaseSubComponent result;
		if (this.TipsSubComponentMap.TryGetValue(type, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600BA57 RID: 47703 RVA: 0x002A33D9 File Offset: 0x002A15D9
	public void RefreshTipsComponentByType(ItemTipsData data)
	{
		this.GetComponentByType(data.ItemType).Refresh(data);
		this.GetComponentByType(data.ItemType).SetVisible(true);
	}

	// Token: 0x0600BA58 RID: 47704 RVA: 0x002A3400 File Offset: 0x002A1600
	public void SetTipsComponentVisibleByType(EItemTipsType type, bool isShow)
	{
		TipsBaseSubComponent tipsBaseSubComponent;
		if (this.TipsSubComponentMap.TryGetValue(type, out tipsBaseSubComponent))
		{
			tipsBaseSubComponent.SetVisible(isShow);
		}
	}

	// Token: 0x0600BA59 RID: 47705 RVA: 0x002A3424 File Offset: 0x002A1624
	public void SetTipsComponentLockButton(bool isShow)
	{
		if (this.ItemType == null)
		{
			return;
		}
		this.GetComponentByType(this.ItemType.Value).SetLockButtonShow(isShow);
	}

	// Token: 0x0600BA5A RID: 47706 RVA: 0x002A344B File Offset: 0x002A164B
	public void SetTipsNumShow(bool isShow)
	{
		if (this.ItemType == null)
		{
			return;
		}
		this.GetComponentByType(this.ItemType.Value).SetPanelNumVisible(isShow);
	}

	// Token: 0x0600BA5B RID: 47707 RVA: 0x002A3472 File Offset: 0x002A1672
	public ESkipName GetTipsPreviewType()
	{
		return this.PreviewType;
	}

	// Token: 0x0600BA5C RID: 47708 RVA: 0x002A347A File Offset: 0x002A167A
	public int GetTipsItemConfigId()
	{
		return this.ItemConfigId;
	}

	// Token: 0x0600BA5D RID: 47709 RVA: 0x002A3484 File Offset: 0x002A1684
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickPreviewBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600BA5E RID: 47710 RVA: 0x002A3614 File Offset: 0x002A1814
	protected override void OnStart()
	{
		base.GetTexture(1).SetUIActive(false);
		base.GetButton(8).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x0600BA5F RID: 47711 RVA: 0x002A3648 File Offset: 0x002A1848
	protected override void OnBeforeDestroy()
	{
		foreach (KeyValuePair<EItemTipsType, TipsBaseSubComponent> keyValuePair in this.TipsSubComponentMap)
		{
			keyValuePair.Value.Destroy(null);
		}
		this.TipsSubComponentMap.Clear();
		if (this.ButtonQuestFunction != null)
		{
			this.ButtonQuestFunction = null;
		}
	}

	// Token: 0x0600BA60 RID: 47712 RVA: 0x002A36BC File Offset: 0x002A18BC
	public void Refresh(ItemTipsData data)
	{
		if (this.ItemType != null)
		{
			this.SetTipsComponentVisibleByType(this.ItemType.Value, false);
		}
		this.ItemType = new EItemTipsType?(data.ItemType);
		this.ItemConfigId = data.ConfigId;
		this.PreviewType = data.PreviewType;
		this.RefreshBase(data);
		this.RefreshTipsComponentByType(data);
		this.SetActive(true);
	}

	// Token: 0x0600BA61 RID: 47713 RVA: 0x002A3726 File Offset: 0x002A1926
	private void RefreshBase(ItemTipsData data)
	{
		this.RefreshBaseName(data);
		this.RefreshBaseQuality(data);
		this.RefreshBaseIcon(data);
		this.RefreshPreviewButton(data);
		this.SetDebugText(data.ConfigId);
	}

	// Token: 0x0600BA62 RID: 47714 RVA: 0x002A3750 File Offset: 0x002A1950
	private void RefreshBaseName(ItemTipsData data)
	{
		UUIText text = base.GetText(0);
		if (data.IsQualityByType)
		{
			text.SetUIActive(false);
			return;
		}
		QualityInfo? qualityConfig = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetQualityConfig(data.QualityId);
		if (qualityConfig != null)
		{
			FColor color = FColor.FromHex(qualityConfig.Value.DropColor);
			base.GetText(0).SetColor(color);
			LguiUtil.Instance.SetLocalTextNew(text, data.Title, Array.Empty<object>());
		}
	}

	// Token: 0x0600BA63 RID: 47715 RVA: 0x002A37C8 File Offset: 0x002A19C8
	private void RefreshBaseQuality(ItemTipsData data)
	{
		UUIItem item = base.GetItem(7);
		if (data.IsQualityByType)
		{
			item.SetUIActive(false);
			return;
		}
		FColor color = FColor.FromHex(InventoryConfig.Instance.GetItemQualityConfig(data.QualityId).Value.ItemTipsEffectColor);
		item.SetColor(color);
		item.SetUIActive(true);
	}

	// Token: 0x0600BA64 RID: 47716 RVA: 0x002A3824 File Offset: 0x002A1A24
	private void RefreshBaseIcon(ItemTipsData data)
	{
		base.GetTexture(2).SetUIActive(false);
		base.GetTexture(6).SetUIActive(false);
		UUITexture texture = base.GetTexture(2);
		if (data.IsShowIconBig())
		{
			texture = base.GetTexture(6);
		}
		if (data.IsIconByType)
		{
			texture.SetUIActive(false);
			return;
		}
		texture.SetUIActive(true);
		base.SetItemIcon(texture, data.ConfigId, null, null);
	}

	// Token: 0x0600BA65 RID: 47717 RVA: 0x002A3894 File Offset: 0x002A1A94
	private void RefreshPreviewButton(ItemTipsData data)
	{
		base.GetButton(8).RootUIComp.Get().SetUIActive(data.PreviewType != ESkipName.NoSkip && data.ShowPreview);
	}

	// Token: 0x0600BA66 RID: 47718 RVA: 0x002A38CC File Offset: 0x002A1ACC
	private void SetDebugText(int debugId)
	{
		UUIText text = base.GetText(5);
		if (!GlobalData.IsPlayInEditor)
		{
			text.SetUIActive(false);
			return;
		}
		LguiUtil.Instance.SetLocalText(text, "CommonTipsDebugItemId", new <>z__ReadOnlySingleElementList<object>(debugId));
		text.SetUIActive(true);
	}

	// Token: 0x0600BA67 RID: 47719 RVA: 0x002A3912 File Offset: 0x002A1B12
	private void OnClickPreviewBtn()
	{
		SkipTaskManager.Run(this.PreviewType, new object[]
		{
			this.ItemConfigId
		});
	}

	// Token: 0x0600BA68 RID: 47720 RVA: 0x002A3934 File Offset: 0x002A1B34
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		TipsBaseSubComponent tipsBaseSubComponent;
		if (configParams[0] == "DangoPlugin" && this.TipsSubComponentMap.TryGetValue(EItemTipsType.AbyssDango, out tipsBaseSubComponent))
		{
			return tipsBaseSubComponent.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
		return null;
	}

	// Token: 0x04005470 RID: 21616
	public EItemTipsType? ItemType;

	// Token: 0x04005471 RID: 21617
	[Nullable(2)]
	private Action ButtonQuestFunction;

	// Token: 0x04005472 RID: 21618
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private readonly Dictionary<EItemTipsType, TipsBaseSubComponent> TipsSubComponentMap = new Dictionary<EItemTipsType, TipsBaseSubComponent>();

	// Token: 0x04005473 RID: 21619
	private ESkipName PreviewType = ESkipName.NoSkip;

	// Token: 0x04005474 RID: 21620
	private int ItemConfigId;

	// Token: 0x04005475 RID: 21621
	private readonly Dictionary<EItemTipsType, Type> TypeComponentRelationMap = new Dictionary<EItemTipsType, Type>
	{
		{
			EItemTipsType.Normal,
			typeof(TipsMaterialComponent)
		},
		{
			EItemTipsType.Weapon,
			typeof(TipsWeaponComponent)
		},
		{
			EItemTipsType.Vision,
			typeof(TipsVisionComponent)
		},
		{
			EItemTipsType.Character,
			typeof(ItemTipsCharacterComponent)
		},
		{
			EItemTipsType.AbyssDango,
			typeof(ItemTipsAbyssDangoComponent)
		},
		{
			EItemTipsType.RoleSkin,
			typeof(TipsMaterialComponent)
		}
	};
}
