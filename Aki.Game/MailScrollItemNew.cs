using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020016BD RID: 5821
[NullableContext(1)]
[Nullable(0)]
public class MailScrollItemNew : UiPanelBase, IDynamicScrollItem<MailData>
{
	// Token: 0x0600E270 RID: 57968 RVA: 0x00426F98 File Offset: 0x00425198
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

	// Token: 0x0600E271 RID: 57969 RVA: 0x004270F4 File Offset: 0x004252F4
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

	// Token: 0x0600E272 RID: 57970 RVA: 0x00427435 File Offset: 0x00425635
	public void BindSelectCall(Action<int, MailData> func)
	{
		this.OnSelectCallback = func;
	}

	// Token: 0x0600E273 RID: 57971 RVA: 0x0042743E File Offset: 0x0042563E
	public void BindGetSelectedIndexFunction(Func<int> func)
	{
		this.GetSelectIndexFunction = func;
	}

	// Token: 0x0600E274 RID: 57972 RVA: 0x00427447 File Offset: 0x00425647
	public void BindFavoriteClickCall(Action<int, MailData> func)
	{
		this.OnFavoriteClickCallback = func;
	}

	// Token: 0x0600E275 RID: 57973 RVA: 0x00427450 File Offset: 0x00425650
	public void OnSelected(bool fireEvent)
	{
		(this.RootActor.GetComponentByClass(UUIExtendToggle.StaticClass()) as UUIExtendToggle).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
	}

	// Token: 0x0600E276 RID: 57974 RVA: 0x00427476 File Offset: 0x00425676
	public void OnDeselected(bool fireEvent)
	{
		this.SelectTrigger = false;
		(this.RootActor.GetComponentByClass(UUIExtendToggle.StaticClass()) as UUIExtendToggle).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x0600E277 RID: 57975 RVA: 0x004274A3 File Offset: 0x004256A3
	private void OnExtendToggleStateChanged(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked && this != null)
		{
			this.OnSelectCallback(this.Index, this.Data);
		}
	}

	// Token: 0x0600E278 RID: 57976 RVA: 0x004274C3 File Offset: 0x004256C3
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

	// Token: 0x0600E279 RID: 57977 RVA: 0x004274EC File Offset: 0x004256EC
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

	// Token: 0x0600E27A RID: 57978 RVA: 0x0042754D File Offset: 0x0042574D
	public AUIBaseActor GetUsingItem(MailData data)
	{
		return base.GetRootItem().GetOwner() as AUIBaseActor;
	}

	// Token: 0x0600E27B RID: 57979 RVA: 0x00427560 File Offset: 0x00425760
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

	// Token: 0x0600E27C RID: 57980 RVA: 0x004275AB File Offset: 0x004257AB
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

	// Token: 0x04008165 RID: 33125
	private const int DAY_GAP = 7;

	// Token: 0x04008166 RID: 33126
	private UUIExtendToggle Toggle;

	// Token: 0x04008167 RID: 33127
	private UUIButtonComponent FavoriteButton;

	// Token: 0x04008168 RID: 33128
	private Action<int, MailData> OnSelectCallback;

	// Token: 0x04008169 RID: 33129
	private Action<int, MailData> OnFavoriteClickCallback;

	// Token: 0x0400816A RID: 33130
	private Func<int> GetSelectIndexFunction;

	// Token: 0x0400816B RID: 33131
	public bool SelectTrigger;

	// Token: 0x0400816C RID: 33132
	public bool IsInit;

	// Token: 0x0400816D RID: 33133
	private int Index = -1;

	// Token: 0x0400816E RID: 33134
	private MailData Data;

	// Token: 0x020078A8 RID: 30888
	[NullableContext(0)]
	private enum EMailScrollItemComponents
	{
		// Token: 0x04027223 RID: 160291
		SprIcon,
		// Token: 0x04027224 RID: 160292
		Toggle,
		// Token: 0x04027225 RID: 160293
		TxtMailTitle,
		// Token: 0x04027226 RID: 160294
		SprStar,
		// Token: 0x04027227 RID: 160295
		TxtPoster,
		// Token: 0x04027228 RID: 160296
		TxtTime,
		// Token: 0x04027229 RID: 160297
		RedDot,
		// Token: 0x0402722A RID: 160298
		PnlContent,
		// Token: 0x0402722B RID: 160299
		SprFavorite
	}
}
