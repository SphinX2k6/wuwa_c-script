using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020025D0 RID: 9680
public class PhotographExpressionItem : UiPanelBase
{
	// Token: 0x06013A28 RID: 80424 RVA: 0x004E9198 File Offset: 0x004E7398
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

	// Token: 0x06013A29 RID: 80425 RVA: 0x004E9241 File Offset: 0x004E7441
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x06013A2A RID: 80426 RVA: 0x004E9260 File Offset: 0x004E7460
	protected override void OnBeforeDestroy()
	{
		base.GetExtendToggle(0).CanExecuteChange.Unbind();
	}

	// Token: 0x06013A2B RID: 80427 RVA: 0x004E9274 File Offset: 0x004E7474
	private bool OnCanExecuteChange()
	{
		bool flag = this.IsUnLock();
		if (flag && this.OnCanExecuteChangeFunc != null)
		{
			return this.OnCanExecuteChangeFunc(this);
		}
		return flag;
	}

	// Token: 0x06013A2C RID: 80428 RVA: 0x004E92A4 File Offset: 0x004E74A4
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

	// Token: 0x06013A2D RID: 80429 RVA: 0x004E9408 File Offset: 0x004E7608
	private bool IsUnLock()
	{
		if (this.PhotoMontageId == 0)
		{
			return true;
		}
		int unLockConditionGroup = this.PhotoMontageConfig.Value.UnLockConditionGroup;
		return unLockConditionGroup == 0 || LevelGeneralController.Instance.CheckCondition(unLockConditionGroup.ToString(), null, true, Array.Empty<object>());
	}

	// Token: 0x06013A2E RID: 80430 RVA: 0x004E9450 File Offset: 0x004E7650
	[NullableContext(1)]
	public void BindOnSelected(Action<PhotographExpressionItem, bool> onSelected)
	{
		this.OnSelected = onSelected;
	}

	// Token: 0x06013A2F RID: 80431 RVA: 0x004E9459 File Offset: 0x004E7659
	[NullableContext(1)]
	public void BindOnCanExecuteChange(Func<PhotographExpressionItem, bool> canExecuteChange)
	{
		this.OnCanExecuteChangeFunc = canExecuteChange;
	}

	// Token: 0x06013A30 RID: 80432 RVA: 0x004E9464 File Offset: 0x004E7664
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

	// Token: 0x06013A31 RID: 80433 RVA: 0x004E9491 File Offset: 0x004E7691
	public int GetPhotoMontageId()
	{
		return this.PhotoMontageId;
	}

	// Token: 0x06013A32 RID: 80434 RVA: 0x004E9499 File Offset: 0x004E7699
	public PhotoMontage? GetPhotoMontageConfig()
	{
		return this.PhotoMontageConfig;
	}

	// Token: 0x06013A33 RID: 80435 RVA: 0x004E94A4 File Offset: 0x004E76A4
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

	// Token: 0x0400940C RID: 37900
	private int PhotoMontageId;

	// Token: 0x0400940D RID: 37901
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhotographExpressionItem, bool> OnSelected;

	// Token: 0x0400940E RID: 37902
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<PhotographExpressionItem, bool> OnCanExecuteChangeFunc;

	// Token: 0x0400940F RID: 37903
	private PhotoMontage? PhotoMontageConfig;

	// Token: 0x04009410 RID: 37904
	private const float LOCK_ALPHA = 0.3f;

	// Token: 0x04009411 RID: 37905
	private const float UNLOCK_ALPHA = 1f;

	// Token: 0x02008BDF RID: 35807
	private enum EChildType
	{
		// Token: 0x0402D67B RID: 185979
		Toggle,
		// Token: 0x0402D67C RID: 185980
		SpriteIcon,
		// Token: 0x0402D67D RID: 185981
		TextTitle,
		// Token: 0x0402D67E RID: 185982
		TextLock,
		// Token: 0x0402D67F RID: 185983
		ItemLock
	}
}
