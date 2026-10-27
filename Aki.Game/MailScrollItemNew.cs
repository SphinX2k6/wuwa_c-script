using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020021D9 RID: 8665
[NullableContext(1)]
[Nullable(0)]
public class MailScrollItemNew : UiPanelBase, IDynamicScrollItem<MailData>
{
	// Token: 0x06010DDF RID: 69087 RVA: 0x0041A6B8 File Offset: 0x004188B8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x06010DE0 RID: 69088 RVA: 0x0041A814 File Offset: 0x00418A14
	public void Update(MailData data, int index)
	{
		this.Index = index;
		this.Data = data;
		if (this.SelectTrigger)
		{
			this.OnSelected(true);
			this.SelectTrigger = false;
		}
		else
		{
			Func<int> getSelectIndexFunction = this.GetSelectIndexFunction;
			int? num = (getSelectIndexFunction != null) ? new int?(getSelectIndexFunction()) : null;
			if (index == num.GetValueOrDefault() & num != null)
			{
				this.OnSelected(false);
			}
			else
			{
				this.OnDeselected(false);
			}
		}
		base.GetText(2).SetText(data.Title, true);
		base.GetText(4).SetText(data.Sender, true);
		int num2 = TimeUtil.Instance.CalculateMailDayGapByServerTime((double)data.Time);
		if (num2 > 7)
		{
			DateTime dataFromTimeStamp = TimeUtil.Instance.GetDataFromTimeStamp((double)data.Time);
			UUIText text = base.GetText(5);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted<int>(dataFromTimeStamp.Year);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(dataFromTimeStamp.Month);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(dataFromTimeStamp.Day);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		else if (num2 >= 1)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "Text_FriendOfflineSomeDay_Text", new <>z__ReadOnlySingleElementList<object>(num2));
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "Text_Today_Text", Array.Empty<object>());
		}
		base.GetItem(6).SetUIActive(!data.GetWasScanned());
		base.GetItem(3).SetUIActive(data.GetMailLevel() == 2);
		bool isFavorite = data.IsFavorite;
		base.GetSprite(8).SetUIActive(isFavorite);
		UUIButtonComponent favoriteButton = this.FavoriteButton;
		if (favoriteButton != null)
		{
			favoriteButton.SetSelfInteractive(isFavorite);
		}
		if (!data.GetWasScanned() && data.GetAttachmentStatus() == EMailAttachment.AttachmentRemained)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_IconRewardA");
			this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
			base.GetItem(7).SetAlpha(1f);
			return;
		}
		if (data.GetWasScanned() && data.GetAttachmentStatus() == EMailAttachment.AttachmentRemained)
		{
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("SP_IconRewardA");
			this.SetSpriteByPath(resourcePath2, base.GetSprite(0), false, null, null);
			base.GetItem(7).SetAlpha(1f);
			return;
		}
		if (data.GetWasScanned() && data.GetAttachmentStatus() == EMailAttachment.AttachmentPicked)
		{
			string resourcePath3 = UiResourceConfig.Instance.GetResourcePath("SP_IconRewardB");
			this.SetSpriteByPath(resourcePath3, base.GetSprite(0), false, null, null);
			base.GetItem(7).SetAlpha(0.4f);
			return;
		}
		if (!data.GetWasScanned() && data.GetAttachmentStatus() == EMailAttachment.NoneAttachment)
		{
			string resourcePath4 = UiResourceConfig.Instance.GetResourcePath("SP_IconMailA");
			this.SetSpriteByPath(resourcePath4, base.GetSprite(0), false, null, null);
			base.GetItem(7).SetAlpha(1f);
			return;
		}
		if (data.GetWasScanned() && data.GetAttachmentStatus() == EMailAttachment.NoneAttachment)
		{
			string resourcePath5 = UiResourceConfig.Instance.GetResourcePath("SP_IconMailB");
			this.SetSpriteByPath(resourcePath5, base.GetSprite(0), false, null, null);
			base.GetItem(7).SetAlpha(0.4f);
		}
	}

	// Token: 0x06010DE1 RID: 69089 RVA: 0x0041AB55 File Offset: 0x00418D55
	public void BindSelectCall(Action<int, MailData> func)
	{
		this.OnSelectCallback = func;
	}

	// Token: 0x06010DE2 RID: 69090 RVA: 0x0041AB5E File Offset: 0x00418D5E
	public void BindGetSelectedIndexFunction(Func<int> func)
	{
		this.GetSelectIndexFunction = func;
	}

	// Token: 0x06010DE3 RID: 69091 RVA: 0x0041AB67 File Offset: 0x00418D67
	public void BindFavoriteClickCall(Action<int, MailData> func)
	{
		this.OnFavoriteClickCallback = func;
	}

	// Token: 0x06010DE4 RID: 69092 RVA: 0x0041AB70 File Offset: 0x00418D70
	public void OnSelected(bool fireEvent)
	{
		(this.RootActor.GetComponentByClass(UUIExtendToggle.StaticClass()) as UUIExtendToggle).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
	}

	// Token: 0x06010DE5 RID: 69093 RVA: 0x0041AB96 File Offset: 0x00418D96
	public void OnDeselected(bool fireEvent)
	{
		this.SelectTrigger = false;
		(this.RootActor.GetComponentByClass(UUIExtendToggle.StaticClass()) as UUIExtendToggle).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06010DE6 RID: 69094 RVA: 0x0041ABC3 File Offset: 0x00418DC3
	private void OnExtendToggleStateChanged(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked && this != null)
		{
			this.OnSelectCallback(this.Index, this.Data);
		}
	}

	// Token: 0x06010DE7 RID: 69095 RVA: 0x0041ABE3 File Offset: 0x00418DE3
	private void OnFavoriteButtonClick()
	{
		if (this.Data == null)
		{
			return;
		}
		Action<int, MailData> onFavoriteClickCallback = this.OnFavoriteClickCallback;
		if (onFavoriteClickCallback == null)
		{
			return;
		}
		onFavoriteClickCallback(this.Index, this.Data);
	}

	// Token: 0x06010DE8 RID: 69096 RVA: 0x0041AC0C File Offset: 0x00418E0C
	private void BindFavoriteButton()
	{
		UUISprite sprite = base.GetSprite(8);
		if (sprite == null)
		{
			return;
		}
		AUIBaseActor auibaseActor = sprite.GetOwner() as AUIBaseActor;
		this.FavoriteButton = (auibaseActor.GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent);
		UUIButtonComponent favoriteButton = this.FavoriteButton;
		if (favoriteButton == null)
		{
			return;
		}
		favoriteButton.OnClickCallBack.Bind(new Action(this.OnFavoriteButtonClick));
	}

	// Token: 0x06010DE9 RID: 69097 RVA: 0x0041AC6D File Offset: 0x00418E6D
	public AUIBaseActor GetUsingItem(MailData data)
	{
		return base.GetRootItem().GetOwner() as AUIBaseActor;
	}

	// Token: 0x06010DEA RID: 69098 RVA: 0x0041AC80 File Offset: 0x00418E80
	public UniTask Init(UUIItem actor)
	{
		MailScrollItemNew.<Init>d__22 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<MailScrollItemNew.<Init>d__22>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06010DEB RID: 69099 RVA: 0x0041ACCB File Offset: 0x00418ECB
	public void ClearItem()
	{
		UUIButtonComponent favoriteButton = this.FavoriteButton;
		if (favoriteButton != null)
		{
			favoriteButton.OnClickCallBack.Unbind();
		}
		this.Toggle.OnStateChange.Clear();
		this.OnSelectCallback = null;
		base.Destroy(null);
	}

	// Token: 0x0400801E RID: 32798
	private const int DAY_GAP = 7;

	// Token: 0x0400801F RID: 32799
	private UUIExtendToggle Toggle;

	// Token: 0x04008020 RID: 32800
	private UUIButtonComponent FavoriteButton;

	// Token: 0x04008021 RID: 32801
	private Action<int, MailData> OnSelectCallback;

	// Token: 0x04008022 RID: 32802
	private Action<int, MailData> OnFavoriteClickCallback;

	// Token: 0x04008023 RID: 32803
	private Func<int> GetSelectIndexFunction;

	// Token: 0x04008024 RID: 32804
	public bool SelectTrigger;

	// Token: 0x04008025 RID: 32805
	public bool IsInit;

	// Token: 0x04008026 RID: 32806
	private int Index = -1;

	// Token: 0x04008027 RID: 32807
	private MailData Data;

	// Token: 0x0200871F RID: 34591
	[NullableContext(0)]
	private enum EMailScrollItemComponents
	{
		// Token: 0x0402BF0A RID: 179978
		SprIcon,
		// Token: 0x0402BF0B RID: 179979
		Toggle,
		// Token: 0x0402BF0C RID: 179980
		TxtMailTitle,
		// Token: 0x0402BF0D RID: 179981
		SprStar,
		// Token: 0x0402BF0E RID: 179982
		TxtPoster,
		// Token: 0x0402BF0F RID: 179983
		TxtTime,
		// Token: 0x0402BF10 RID: 179984
		RedDot,
		// Token: 0x0402BF11 RID: 179985
		PnlContent,
		// Token: 0x0402BF12 RID: 179986
		SprFavorite
	}
}
