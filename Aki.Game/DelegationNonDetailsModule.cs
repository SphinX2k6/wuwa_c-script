using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007C9 RID: 1993
[NullableContext(1)]
[Nullable(0)]
public class DelegationNonDetailsModule : UiPanelBase
{
	// Token: 0x06005B0C RID: 23308 RVA: 0x001D75D4 File Offset: 0x001D57D4
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

	// Token: 0x06005B0D RID: 23309 RVA: 0x001D7734 File Offset: 0x001D5934
	protected override UniTask OnBeforeStartAsync()
	{
		DelegationNonDetailsModule.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DelegationNonDetailsModule.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005B0E RID: 23310 RVA: 0x001D7778 File Offset: 0x001D5978
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

	// Token: 0x06005B0F RID: 23311 RVA: 0x001D7828 File Offset: 0x001D5A28
	private DelegationNonDetailsModuleStarItem InitStarItem()
	{
		return new DelegationNonDetailsModuleStarItem();
	}

	// Token: 0x06005B10 RID: 23312 RVA: 0x001D7830 File Offset: 0x001D5A30
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

	// Token: 0x06005B11 RID: 23313 RVA: 0x001D7871 File Offset: 0x001D5A71
	private void RefreshLockCondition()
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(this.Data.GetLockText(), true);
	}

	// Token: 0x06005B12 RID: 23314 RVA: 0x001D7890 File Offset: 0x001D5A90
	private void RefreshConsumePrivate()
	{
		IItemData itemData = this.Data.GetConsumeList()[1];
		this.SecondCurrency.UpdateItem(itemData.ItemId, itemData.Count);
	}

	// Token: 0x06005B13 RID: 23315 RVA: 0x001D78C8 File Offset: 0x001D5AC8
	private void RefreshTitle()
	{
		TrackMoonEntrust delegationConfig = BusinessConfig.Instance.GetDelegationConfig(this.Data.Id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), delegationConfig.Title, Array.Empty<object>());
	}

	// Token: 0x06005B14 RID: 23316 RVA: 0x001D7908 File Offset: 0x001D5B08
	private void RefreshStar()
	{
		TrackMoonEntrust delegationConfig = BusinessConfig.Instance.GetDelegationConfig(this.Data.Id);
		this.StarLayout.RefreshByDataAsync(new List<object>(), false, new int?(delegationConfig.Star)).Forget();
	}

	// Token: 0x06005B15 RID: 23317 RVA: 0x001D7950 File Offset: 0x001D5B50
	private void RefreshEvaluate()
	{
		base.GetItem(7).SetUIActive(this.Data.HasBestEvaluate());
		if (this.Data.HasBestEvaluate())
		{
			base.SetTextureByPath(BusinessConfig.Instance.GetEvaluateByLevel(this.Data.BestEvaluateLevel).Icon, base.GetTexture(8), null, null);
		}
	}

	// Token: 0x06005B16 RID: 23318 RVA: 0x001D79B8 File Offset: 0x001D5BB8
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

	// Token: 0x06005B17 RID: 23319 RVA: 0x001D7A31 File Offset: 0x001D5C31
	private void RefreshNewTag()
	{
		UUIItem item = base.GetItem(12);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!this.Data.HasBestEvaluate());
	}

	// Token: 0x06005B18 RID: 23320 RVA: 0x001D7A54 File Offset: 0x001D5C54
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

	// Token: 0x06005B19 RID: 23321 RVA: 0x001D7AB2 File Offset: 0x001D5CB2
	public void RefreshConsume()
	{
		if (this.Data.IsVisible)
		{
			this.RefreshConsumePrivate();
		}
	}

	// Token: 0x06005B1A RID: 23322 RVA: 0x001D7AC7 File Offset: 0x001D5CC7
	public void RegisterViewController(BusinessViewController vc)
	{
		this.Vc = vc;
	}

	// Token: 0x04003D06 RID: 15622
	protected DelegationNonDetailsModuleCostItem SecondCurrency;

	// Token: 0x04003D07 RID: 15623
	protected DelegationData Data;

	// Token: 0x04003D08 RID: 15624
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	protected GenericLayout<DelegationNonDetailsModuleStarItem, object> StarLayout;

	// Token: 0x04003D09 RID: 15625
	[Nullable(2)]
	private BusinessViewController Vc;

	// Token: 0x02006AE7 RID: 27367
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x040232B5 RID: 144053
		public const int Button = 0;

		// Token: 0x040232B6 RID: 144054
		public const int LockItem = 1;

		// Token: 0x040232B7 RID: 144055
		public const int LockText = 2;

		// Token: 0x040232B8 RID: 144056
		public const int UnLockItem = 3;

		// Token: 0x040232B9 RID: 144057
		public const int Title = 4;

		// Token: 0x040232BA RID: 144058
		public const int StarLayout = 5;

		// Token: 0x040232BB RID: 144059
		public const int StarItem = 6;

		// Token: 0x040232BC RID: 144060
		public const int BestEvaluateItem = 7;

		// Token: 0x040232BD RID: 144061
		public const int BestEvaluateTexture = 8;

		// Token: 0x040232BE RID: 144062
		public const int FirstCost = 9;

		// Token: 0x040232BF RID: 144063
		public const int SecondCost = 10;

		// Token: 0x040232C0 RID: 144064
		public const int Icon = 11;

		// Token: 0x040232C1 RID: 144065
		public const int NewTag = 12;
	}
}
