using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001ABB RID: 6843
public class PhotographExpressionItem : UiPanelBase
{
	// Token: 0x06010F08 RID: 69384 RVA: 0x004F7D98 File Offset: 0x004F5F98
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClicked))
		};
	}

	// Token: 0x06010F09 RID: 69385 RVA: 0x004F7E41 File Offset: 0x004F6041
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x06010F0A RID: 69386 RVA: 0x004F7E60 File Offset: 0x004F6060
	protected override void OnBeforeDestroy()
	{
		base.GetExtendToggle(0).CanExecuteChange.Unbind();
	}

	// Token: 0x06010F0B RID: 69387 RVA: 0x004F7E74 File Offset: 0x004F6074
	private bool OnCanExecuteChange()
	{
		bool flag = this.IsUnLock();
		if (flag && this.OnCanExecuteChangeFunc != null)
		{
			return this.OnCanExecuteChangeFunc(this);
		}
		return flag;
	}

	// Token: 0x06010F0C RID: 69388 RVA: 0x004F7EA4 File Offset: 0x004F60A4
	public void Refresh(int photoMontageId)
	{
		this.PhotoMontageId = photoMontageId;
		if (photoMontageId == 0)
		{
			return;
		}
		this.PhotoMontageConfig = PhotographConfig.Instance.GetPhotoMontageConfig(photoMontageId);
		if (this.PhotoMontageConfig == null)
		{
			return;
		}
		string name = this.PhotoMontageConfig.Value.Name;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), name, Array.Empty<object>());
		bool flag = this.IsUnLock();
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (flag)
		{
			extendToggle.RootUIComp.Get().SetAlpha(1f);
			int iconType = this.PhotoMontageConfig.Value.IconType;
			UiResourceConfig instance = UiResourceConfig.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("SP_PhotoMotionIcon");
			defaultInterpolatedStringHandler.AppendFormatted<int>(iconType);
			string resourcePath = instance.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
			this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, null);
		}
		else
		{
			extendToggle.RootUIComp.Get().SetAlpha(0.3f);
			string conditionTipsId = this.PhotoMontageConfig.Value.ConditionTipsId;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), conditionTipsId, Array.Empty<object>());
		}
		base.GetText(3).SetUIActive(!flag);
		base.GetSprite(1).SetUIActive(flag);
		base.GetItem(4).SetUIActive(!flag);
	}

	// Token: 0x06010F0D RID: 69389 RVA: 0x004F8008 File Offset: 0x004F6208
	private bool IsUnLock()
	{
		if (this.PhotoMontageId == 0)
		{
			return true;
		}
		int unLockConditionGroup = this.PhotoMontageConfig.Value.UnLockConditionGroup;
		return unLockConditionGroup == 0 || LevelGeneralController.Instance.CheckCondition(unLockConditionGroup.ToString(), null, true, Array.Empty<object>());
	}

	// Token: 0x06010F0E RID: 69390 RVA: 0x004F8050 File Offset: 0x004F6250
	[NullableContext(1)]
	public void BindOnSelected(Action<PhotographExpressionItem, bool> onSelected)
	{
		this.OnSelected = onSelected;
	}

	// Token: 0x06010F0F RID: 69391 RVA: 0x004F8059 File Offset: 0x004F6259
	[NullableContext(1)]
	public void BindOnCanExecuteChange(Func<PhotographExpressionItem, bool> canExecuteChange)
	{
		this.OnCanExecuteChangeFunc = canExecuteChange;
	}

	// Token: 0x06010F10 RID: 69392 RVA: 0x004F8064 File Offset: 0x004F6264
	public void SetSelected(bool bSelected, bool bFireEvent = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (bSelected)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, bFireEvent, false, false);
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, bFireEvent, false, false);
	}

	// Token: 0x06010F11 RID: 69393 RVA: 0x004F8091 File Offset: 0x004F6291
	public int GetPhotoMontageId()
	{
		return this.PhotoMontageId;
	}

	// Token: 0x06010F12 RID: 69394 RVA: 0x004F8099 File Offset: 0x004F6299
	public PhotoMontage? GetPhotoMontageConfig()
	{
		return this.PhotoMontageConfig;
	}

	// Token: 0x06010F13 RID: 69395 RVA: 0x004F80A4 File Offset: 0x004F62A4
	private void OnClicked(EToggleState state)
	{
		if (!this.IsUnLock())
		{
			return;
		}
		bool arg = state == EToggleState.ETT_Checked;
		if (this.OnSelected != null)
		{
			this.OnSelected(this, arg);
		}
	}

	// Token: 0x04009562 RID: 38242
	private int PhotoMontageId;

	// Token: 0x04009563 RID: 38243
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhotographExpressionItem, bool> OnSelected;

	// Token: 0x04009564 RID: 38244
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<PhotographExpressionItem, bool> OnCanExecuteChangeFunc;

	// Token: 0x04009565 RID: 38245
	private PhotoMontage? PhotoMontageConfig;

	// Token: 0x04009566 RID: 38246
	private const float LOCK_ALPHA = 0.3f;

	// Token: 0x04009567 RID: 38247
	private const float UNLOCK_ALPHA = 1f;

	// Token: 0x02007D67 RID: 32103
	private enum EChildType
	{
		// Token: 0x04028990 RID: 166288
		Toggle,
		// Token: 0x04028991 RID: 166289
		SpriteIcon,
		// Token: 0x04028992 RID: 166290
		TextTitle,
		// Token: 0x04028993 RID: 166291
		TextLock,
		// Token: 0x04028994 RID: 166292
		ItemLock
	}
}
