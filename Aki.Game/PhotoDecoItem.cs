using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A49 RID: 6729
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhotoDecoItem : GridProxyAbstract<PhotoDecoData>
{
	// Token: 0x06010998 RID: 67992 RVA: 0x004DB694 File Offset: 0x004D9894
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

	// Token: 0x06010999 RID: 67993 RVA: 0x004DB77F File Offset: 0x004D997F
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x0601099A RID: 67994 RVA: 0x004DB790 File Offset: 0x004D9990
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

	// Token: 0x0601099B RID: 67995 RVA: 0x004DB844 File Offset: 0x004D9A44
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

	// Token: 0x0601099C RID: 67996 RVA: 0x004DB949 File Offset: 0x004D9B49
	private void CancelLangTextureLoad()
	{
		if (this.LangTextureHandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.LangTextureHandleId);
			this.LangTextureHandleId = -1;
		}
	}

	// Token: 0x0601099D RID: 67997 RVA: 0x004DB96B File Offset: 0x004D9B6B
	protected override void OnBeforeDestroy()
	{
		this.CancelLangTextureLoad();
		this.UnlockAnimPlayer.Clear();
	}

	// Token: 0x0601099E RID: 67998 RVA: 0x004DB97E File Offset: 0x004D9B7E
	private void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x0601099F RID: 67999 RVA: 0x004DB99B File Offset: 0x004D9B9B
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x060109A0 RID: 68000 RVA: 0x004DB9A5 File Offset: 0x004D9BA5
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x060109A1 RID: 68001 RVA: 0x004DB9AF File Offset: 0x004D9BAF
	public override object GetKey(PhotoDecoData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x060109A2 RID: 68002 RVA: 0x004DB9BC File Offset: 0x004D9BBC
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
				ItemController.Instance.OpenItemTipsByItemId(this.Data.RelativeItem, true, null, false);
			}
			return;
		}
		this.OnDecoClick(base.GridIndex);
	}

	// Token: 0x040092EB RID: 37611
	private PhotoDecoData Data;

	// Token: 0x040092EC RID: 37612
	private bool IsUnlock = true;

	// Token: 0x040092ED RID: 37613
	public Action<int> OnDecoClick = delegate(int gridIndex)
	{
	};

	// Token: 0x040092EE RID: 37614
	private int LangTextureHandleId = -1;

	// Token: 0x040092EF RID: 37615
	private readonly PhotoUnlockAnimPlayer UnlockAnimPlayer = new PhotoUnlockAnimPlayer();

	// Token: 0x02007CB0 RID: 31920
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040285F8 RID: 165368
		ToggleItem,
		// Token: 0x040285F9 RID: 165369
		ItemNormalState,
		// Token: 0x040285FA RID: 165370
		ItemContent,
		// Token: 0x040285FB RID: 165371
		SpriteIcon,
		// Token: 0x040285FC RID: 165372
		TextureIcon,
		// Token: 0x040285FD RID: 165373
		SpriteRedDot,
		// Token: 0x040285FE RID: 165374
		ItemLockPanel,
		// Token: 0x040285FF RID: 165375
		LangTextureIcon
	}
}
