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

// Token: 0x02000D89 RID: 3465
[NullableContext(1)]
[Nullable(0)]
public class ItemTipsComponentContentComponent : UiPanelBase
{
	// Token: 0x06008E3F RID: 36415 RVA: 0x002ADA98 File Offset: 0x002ABC98
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

	// Token: 0x06008E40 RID: 36416 RVA: 0x002ADB31 File Offset: 0x002ABD31
	public void RefreshTipsComponentByType(ItemTipsData data)
	{
		this.GetComponentByType(data.ItemType).Refresh(data);
		this.GetComponentByType(data.ItemType).SetVisible(true);
	}

	// Token: 0x06008E41 RID: 36417 RVA: 0x002ADB58 File Offset: 0x002ABD58
	public void SetTipsComponentVisibleByType(EItemTipsType type, bool isShow)
	{
		TipsBaseSubComponent tipsBaseSubComponent;
		if (this.TipsSubComponentMap.TryGetValue(type, out tipsBaseSubComponent))
		{
			tipsBaseSubComponent.SetVisible(isShow);
		}
	}

	// Token: 0x06008E42 RID: 36418 RVA: 0x002ADB7C File Offset: 0x002ABD7C
	public void SetTipsComponentLockButton(bool isShow)
	{
		if (this.ItemType == null)
		{
			return;
		}
		this.GetComponentByType(this.ItemType.Value).SetLockButtonShow(isShow);
	}

	// Token: 0x06008E43 RID: 36419 RVA: 0x002ADBA3 File Offset: 0x002ABDA3
	public void SetTipsNumShow(bool isShow)
	{
		if (this.ItemType == null)
		{
			return;
		}
		this.GetComponentByType(this.ItemType.Value).SetPanelNumVisible(isShow);
	}

	// Token: 0x06008E44 RID: 36420 RVA: 0x002ADBCA File Offset: 0x002ABDCA
	public ESkipName GetTipsPreviewType()
	{
		return this.PreviewType;
	}

	// Token: 0x06008E45 RID: 36421 RVA: 0x002ADBD2 File Offset: 0x002ABDD2
	public int GetTipsItemConfigId()
	{
		return this.ItemConfigId;
	}

	// Token: 0x06008E46 RID: 36422 RVA: 0x002ADBDC File Offset: 0x002ABDDC
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

	// Token: 0x06008E47 RID: 36423 RVA: 0x002ADD6C File Offset: 0x002ABF6C
	protected override void OnStart()
	{
		base.GetTexture(1).SetUIActive(false);
		base.GetButton(8).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06008E48 RID: 36424 RVA: 0x002ADDA0 File Offset: 0x002ABFA0
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

	// Token: 0x06008E49 RID: 36425 RVA: 0x002ADE14 File Offset: 0x002AC014
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

	// Token: 0x06008E4A RID: 36426 RVA: 0x002ADE7E File Offset: 0x002AC07E
	private void RefreshBase(ItemTipsData data)
	{
		this.RefreshBaseName(data);
		this.RefreshBaseQuality(data);
		this.RefreshBaseIcon(data);
		this.RefreshPreviewButton(data);
		this.SetDebugText(data.ConfigId);
	}

	// Token: 0x06008E4B RID: 36427 RVA: 0x002ADEA8 File Offset: 0x002AC0A8
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

	// Token: 0x06008E4C RID: 36428 RVA: 0x002ADF20 File Offset: 0x002AC120
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

	// Token: 0x06008E4D RID: 36429 RVA: 0x002ADF7C File Offset: 0x002AC17C
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

	// Token: 0x06008E4E RID: 36430 RVA: 0x002ADFEC File Offset: 0x002AC1EC
	private void RefreshPreviewButton(ItemTipsData data)
	{
		base.GetButton(8).RootUIComp.Get().SetUIActive(data.PreviewType != ESkipName.NoSkip && data.ShowPreview);
	}

	// Token: 0x06008E4F RID: 36431 RVA: 0x002AE024 File Offset: 0x002AC224
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

	// Token: 0x06008E50 RID: 36432 RVA: 0x002AE06A File Offset: 0x002AC26A
	private void OnClickPreviewBtn()
	{
		SkipTaskManager.Run(this.PreviewType, new object[]
		{
			this.ItemConfigId
		});
	}

	// Token: 0x06008E51 RID: 36433 RVA: 0x002AE08C File Offset: 0x002AC28C
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

	// Token: 0x0400551B RID: 21787
	public EItemTipsType? ItemType;

	// Token: 0x0400551C RID: 21788
	[Nullable(2)]
	private Action ButtonQuestFunction;

	// Token: 0x0400551D RID: 21789
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private readonly Dictionary<EItemTipsType, TipsBaseSubComponent> TipsSubComponentMap = new Dictionary<EItemTipsType, TipsBaseSubComponent>();

	// Token: 0x0400551E RID: 21790
	private ESkipName PreviewType = ESkipName.NoSkip;

	// Token: 0x0400551F RID: 21791
	private int ItemConfigId;

	// Token: 0x04005520 RID: 21792
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
