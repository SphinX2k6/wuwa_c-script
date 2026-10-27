using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200255E RID: 9566
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhotoDecoItem : GridProxyAbstract<PhotoDecoData>
{
	// Token: 0x060134B6 RID: 79030 RVA: 0x004CCA60 File Offset: 0x004CAC60
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUILangTexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x060134B7 RID: 79031 RVA: 0x004CCB4B File Offset: 0x004CAD4B
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x060134B8 RID: 79032 RVA: 0x004CCB5C File Offset: 0x004CAD5C
	public override void Refresh(PhotoDecoData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.CancelLangTextureLoad();
		bool isDefault = data.IsDefault;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(isDefault);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(!isDefault);
		}
		if (!isDefault)
		{
			this.RefreshIcon(data);
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		this.IsUnlock = PhotoUnlockAnimPlayer.IsUnlockByItem(data.RelativeItem);
		UUIItem item3 = base.GetItem(6);
		if (item3 != null)
		{
			item3.SetUIActive(!this.IsUnlock);
		}
		this.SetToggleState(isSelected, false);
		this.UnlockAnimPlayer.TryPlay(this.RootItem, data.RelativeItem);
	}

	// Token: 0x060134B9 RID: 79033 RVA: 0x004CCC10 File Offset: 0x004CAE10
	private void RefreshIcon(PhotoDecoData data)
	{
		UUITexture texture = base.GetTexture(4);
		UUILangTexture langTexture = base.GetLangTexture(7);
		UUISprite sprite = base.GetSprite(3);
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		if (texture != null)
		{
			texture.SetUIActive(true);
		}
		if (data.DecoType == EPhotoDecorationSubTabType.Frame)
		{
			UUILangTexture langTexture3 = langTexture;
			if (langTexture3 != null)
			{
				langTexture3.SetLangTextureData(null);
			}
			if (data.FrameConfig != null)
			{
				base.SetTextureByPath(data.FrameConfig.Value.Icon, texture, null, null);
			}
			return;
		}
		PhotoSticker value = data.StickerConfig.Value;
		if (!value.IsMultilingual)
		{
			UUILangTexture langTexture2 = langTexture;
			if (langTexture2 != null)
			{
				langTexture2.SetLangTextureData(null);
			}
			base.SetTextureByPath(value.Icon, texture, null, null);
			return;
		}
		this.LangTextureHandleId = ResourceSystem.Instance.LoadAsync<ULGUILangTextureData>(value.LangIcon, delegate([Nullable(2)] ULGUILangTextureData langData, string path)
		{
			this.LangTextureHandleId = -1;
			if (langTexture == null || !langTexture.IsValid())
			{
				return;
			}
			if (langData == null || !langData.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "贴纸多语言图标数据加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("路径", path);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			langTexture.SetLangTextureData(langData);
		}, ResourceSystem.EResourceLoadPriority.Ui, "js_undefined");
	}

	// Token: 0x060134BA RID: 79034 RVA: 0x004CCD15 File Offset: 0x004CAF15
	private void CancelLangTextureLoad()
	{
		if (this.LangTextureHandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.LangTextureHandleId);
			this.LangTextureHandleId = -1;
		}
	}

	// Token: 0x060134BB RID: 79035 RVA: 0x004CCD37 File Offset: 0x004CAF37
	protected override void OnBeforeDestroy()
	{
		this.CancelLangTextureLoad();
		this.UnlockAnimPlayer.Clear();
	}

	// Token: 0x060134BC RID: 79036 RVA: 0x004CCD4A File Offset: 0x004CAF4A
	private void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x060134BD RID: 79037 RVA: 0x004CCD67 File Offset: 0x004CAF67
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x060134BE RID: 79038 RVA: 0x004CCD71 File Offset: 0x004CAF71
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x060134BF RID: 79039 RVA: 0x004CCD7B File Offset: 0x004CAF7B
	public override object GetKey(PhotoDecoData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x060134C0 RID: 79040 RVA: 0x004CCD88 File Offset: 0x004CAF88
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		if (!this.IsUnlock)
		{
			this.SetToggleState(false, false);
			if (this.Data.RelativeItem != 0)
			{
				ItemController.Instance.OpenItemTipsByItemId(this.Data.RelativeItem, true, null);
			}
			return;
		}
		this.OnDecoClick(base.GridIndex);
	}

	// Token: 0x04009192 RID: 37266
	private PhotoDecoData Data;

	// Token: 0x04009193 RID: 37267
	private bool IsUnlock = true;

	// Token: 0x04009194 RID: 37268
	public Action<int> OnDecoClick = delegate(int gridIndex)
	{
	};

	// Token: 0x04009195 RID: 37269
	private int LangTextureHandleId = -1;

	// Token: 0x04009196 RID: 37270
	private readonly PhotoUnlockAnimPlayer UnlockAnimPlayer = new PhotoUnlockAnimPlayer();

	// Token: 0x02008B2A RID: 35626
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D2EB RID: 185067
		ToggleItem,
		// Token: 0x0402D2EC RID: 185068
		ItemNormalState,
		// Token: 0x0402D2ED RID: 185069
		ItemContent,
		// Token: 0x0402D2EE RID: 185070
		SpriteIcon,
		// Token: 0x0402D2EF RID: 185071
		TextureIcon,
		// Token: 0x0402D2F0 RID: 185072
		SpriteRedDot,
		// Token: 0x0402D2F1 RID: 185073
		ItemLockPanel,
		// Token: 0x0402D2F2 RID: 185074
		LangTextureIcon
	}
}
