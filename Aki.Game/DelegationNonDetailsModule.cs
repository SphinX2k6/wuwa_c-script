using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001315 RID: 4885
[NullableContext(1)]
[Nullable(0)]
public class DelegationNonDetailsModule : UiPanelBase
{
	// Token: 0x06008771 RID: 34673 RVA: 0x001CE768 File Offset: 0x001CC968
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUITexture)),
			new ValueTuple<int, Type>(12, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnButton))
		};
	}

	// Token: 0x06008772 RID: 34674 RVA: 0x001CE8C8 File Offset: 0x001CCAC8
	protected override UniTask OnBeforeStartAsync()
	{
		DelegationNonDetailsModule.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DelegationNonDetailsModule.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008773 RID: 34675 RVA: 0x001CE90C File Offset: 0x001CCB0C
	private void OnButton()
	{
		if (!this.Data.IsVisible)
		{
			BusinessViewController vc = this.Vc;
			if (vc == null)
			{
				return;
			}
			vc.JumpByConfigCondition(this.Data.Id);
			return;
		}
		else
		{
			int notEnoughConsumeItemId = this.Data.GetNotEnoughConsumeItemId();
			if (notEnoughConsumeItemId <= 0)
			{
				BusinessViewController vc2 = this.Vc;
				if (vc2 == null)
				{
					return;
				}
				vc2.SwitchToState(EBusinessSkipDefine.DelegationDetails, new object[]
				{
					this.Data.Id
				});
				return;
			}
			else
			{
				int powerItemId = BusinessConfig.Instance.GetPowerItemId();
				int coinItemId = BusinessConfig.Instance.GetCoinItemId();
				if (notEnoughConsumeItemId != powerItemId)
				{
					if (notEnoughConsumeItemId == coinItemId)
					{
						BusinessViewController vc3 = this.Vc;
						if (vc3 == null)
						{
							return;
						}
						vc3.JumpMoneyNotEnough();
					}
					return;
				}
				BusinessViewController vc4 = this.Vc;
				if (vc4 == null)
				{
					return;
				}
				vc4.JumpEnergyNotEnough();
				return;
			}
		}
	}

	// Token: 0x06008774 RID: 34676 RVA: 0x001CE9BC File Offset: 0x001CCBBC
	private DelegationNonDetailsModuleStarItem InitStarItem()
	{
		return new DelegationNonDetailsModuleStarItem();
	}

	// Token: 0x06008775 RID: 34677 RVA: 0x001CE9C4 File Offset: 0x001CCBC4
	private void RefreshLockState()
	{
		bool isVisible = this.Data.IsVisible;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(!isVisible);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(isVisible);
	}

	// Token: 0x06008776 RID: 34678 RVA: 0x001CEA05 File Offset: 0x001CCC05
	private void RefreshLockCondition()
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(this.Data.GetLockText(), true);
	}

	// Token: 0x06008777 RID: 34679 RVA: 0x001CEA24 File Offset: 0x001CCC24
	private void RefreshConsumePrivate()
	{
		IItemData itemData = this.Data.GetConsumeList()[1];
		this.SecondCurrency.UpdateItem(itemData.ItemId, itemData.Count);
	}

	// Token: 0x06008778 RID: 34680 RVA: 0x001CEA5C File Offset: 0x001CCC5C
	private void RefreshTitle()
	{
		TrackMoonEntrust delegationConfig = BusinessConfig.Instance.GetDelegationConfig(this.Data.Id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), delegationConfig.Title, Array.Empty<object>());
	}

	// Token: 0x06008779 RID: 34681 RVA: 0x001CEA9C File Offset: 0x001CCC9C
	private void RefreshStar()
	{
		TrackMoonEntrust delegationConfig = BusinessConfig.Instance.GetDelegationConfig(this.Data.Id);
		this.StarLayout.RefreshByDataAsync(new List<object>(), false, new int?(delegationConfig.Star)).Forget();
	}

	// Token: 0x0600877A RID: 34682 RVA: 0x001CEAE4 File Offset: 0x001CCCE4
	private void RefreshEvaluate()
	{
		base.GetItem(7).SetUIActive(this.Data.HasBestEvaluate());
		if (this.Data.HasBestEvaluate())
		{
			base.SetTextureByPath(BusinessConfig.Instance.GetEvaluateByLevel(this.Data.BestEvaluateLevel).Icon, base.GetTexture(8), null, null);
		}
	}

	// Token: 0x0600877B RID: 34683 RVA: 0x001CEB4C File Offset: 0x001CCD4C
	private void RefreshIcon()
	{
		TrackMoonEntrust delegationConfig = BusinessConfig.Instance.GetDelegationConfig(this.Data.Id);
		EntrustType entrustTypeById = BusinessConfig.Instance.GetEntrustTypeById(delegationConfig.EntrustType);
		UUITexture texture = base.GetTexture(11);
		base.SetTextureByPath(entrustTypeById.Icon, texture, null, null);
		UUIItem uuiitem = texture;
		bool bUseChangeColor = !this.Data.IsVisible;
		FColor? fcolor = new FColor?(texture.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x0600877C RID: 34684 RVA: 0x001CEBC5 File Offset: 0x001CCDC5
	private void RefreshNewTag()
	{
		UUIItem item = base.GetItem(12);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!this.Data.HasBestEvaluate());
	}

	// Token: 0x0600877D RID: 34685 RVA: 0x001CEBE8 File Offset: 0x001CCDE8
	public void Refresh(DelegationData data)
	{
		this.Data = data;
		if (!this.Data.IsVisible)
		{
			this.RefreshLockState();
			this.RefreshLockCondition();
			this.RefreshIcon();
			return;
		}
		this.RefreshLockState();
		this.RefreshConsumePrivate();
		this.RefreshTitle();
		this.RefreshStar();
		this.RefreshEvaluate();
		this.RefreshIcon();
		this.RefreshNewTag();
	}

	// Token: 0x0600877E RID: 34686 RVA: 0x001CEC46 File Offset: 0x001CCE46
	public void RefreshConsume()
	{
		if (this.Data.IsVisible)
		{
			this.RefreshConsumePrivate();
		}
	}

	// Token: 0x0600877F RID: 34687 RVA: 0x001CEC5B File Offset: 0x001CCE5B
	public void RegisterViewController(BusinessViewController vc)
	{
		this.Vc = vc;
	}

	// Token: 0x04003C6E RID: 15470
	protected DelegationNonDetailsModuleCostItem SecondCurrency;

	// Token: 0x04003C6F RID: 15471
	protected DelegationData Data;

	// Token: 0x04003C70 RID: 15472
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	protected GenericLayout<DelegationNonDetailsModuleStarItem, object> StarLayout;

	// Token: 0x04003C71 RID: 15473
	[Nullable(2)]
	private BusinessViewController Vc;

	// Token: 0x0200795D RID: 31069
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04027F88 RID: 163720
		public const int Button = 0;

		// Token: 0x04027F89 RID: 163721
		public const int LockItem = 1;

		// Token: 0x04027F8A RID: 163722
		public const int LockText = 2;

		// Token: 0x04027F8B RID: 163723
		public const int UnLockItem = 3;

		// Token: 0x04027F8C RID: 163724
		public const int Title = 4;

		// Token: 0x04027F8D RID: 163725
		public const int StarLayout = 5;

		// Token: 0x04027F8E RID: 163726
		public const int StarItem = 6;

		// Token: 0x04027F8F RID: 163727
		public const int BestEvaluateItem = 7;

		// Token: 0x04027F90 RID: 163728
		public const int BestEvaluateTexture = 8;

		// Token: 0x04027F91 RID: 163729
		public const int FirstCost = 9;

		// Token: 0x04027F92 RID: 163730
		public const int SecondCost = 10;

		// Token: 0x04027F93 RID: 163731
		public const int Icon = 11;

		// Token: 0x04027F94 RID: 163732
		public const int NewTag = 12;
	}
}
