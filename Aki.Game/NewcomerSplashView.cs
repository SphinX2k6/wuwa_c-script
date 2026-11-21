using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200085F RID: 2143
[NullableContext(1)]
[Nullable(0)]
public class NewcomerSplashView : UiViewBase
{
	// Token: 0x060060FF RID: 24831 RVA: 0x001EFC57 File Offset: 0x001EDE57
	public NewcomerSplashView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006100 RID: 24832 RVA: 0x001EFC60 File Offset: 0x001EDE60
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickEmptyBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006101 RID: 24833 RVA: 0x001EFD69 File Offset: 0x001EDF69
	private void OnClickEmptyBtn()
	{
		if (!this.CheckActivityData(this.ActivityIdCached))
		{
			return;
		}
		ActivityController.Instance.OpenActivityById(this.ActivityIdCached, EActivityViewOpenType.HotKey, null, null);
		base.CloseMe(null);
	}

	// Token: 0x06006102 RID: 24834 RVA: 0x001EFD98 File Offset: 0x001EDF98
	protected override UniTask OnBeforeStartAsync()
	{
		NewcomerSplashView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NewcomerSplashView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006103 RID: 24835 RVA: 0x001EFDDC File Offset: 0x001EDFDC
	private bool CheckActivityData(int activityId)
	{
		if (activityId <= 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("ActivityAdvice", Array.Empty<object>());
			base.CloseMe(null);
			return false;
		}
		ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(activityId);
		if (activityById == null)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("ActivityAdvice", Array.Empty<object>());
			base.CloseMe(null);
			return false;
		}
		if (!(activityById is ActivitySevenDaySignData))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("ActivityAdvice", Array.Empty<object>());
			base.CloseMe(null);
			return false;
		}
		if (!activityById.CheckIfInShowTime())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("ActivityAdvice", Array.Empty<object>());
			base.CloseMe(null);
			return false;
		}
		return true;
	}

	// Token: 0x06006104 RID: 24836 RVA: 0x001EFE81 File Offset: 0x001EE081
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		CommonItemSmallItemGrid commonItemSmallItemGrid = new CommonItemSmallItemGrid();
		commonItemSmallItemGrid.SetAllowClickBack(false);
		return commonItemSmallItemGrid;
	}

	// Token: 0x06006105 RID: 24837 RVA: 0x001EFE90 File Offset: 0x001EE090
	protected override void OnBeforeShow()
	{
		this.LoadLogoTexture();
		int? intConfig = ConfigCommonParamById.GetIntConfig("NewPlayerSplashScreenItem");
		if (intConfig != null)
		{
			int? num = intConfig;
			int num2 = 0;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				try
				{
					List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(intConfig.Value);
					GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
					if (rewardLayout != null)
					{
						rewardLayout.RefreshByData(dropPackagePreviewItemList, null, false);
					}
				}
				catch
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("ActivityAdvice", Array.Empty<object>());
					base.CloseMe(null);
				}
				finally
				{
					SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.NewcomerActivity);
				}
			}
		}
	}

	// Token: 0x06006106 RID: 24838 RVA: 0x001EFF40 File Offset: 0x001EE140
	private void LoadLogoTexture()
	{
		UUITexture texture = base.GetTexture(6);
		UUITexture texture2 = base.GetTexture(7);
		if (texture != null && texture2 != null)
		{
			PlayerInfoModel instance = PlayerInfoModel.Instance;
			string resourceId = (((instance != null) ? instance.GetPlayerGender() : EPlayerGender.None) == EPlayerGender.Male) ? "T_RoleLogoMale" : "T_RoleLogoFemale";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (!string.IsNullOrEmpty(resourcePath))
			{
				base.SetTextureByPath(resourcePath, texture, null, null);
				base.SetTextureByPath(resourcePath, texture2, null, null);
			}
		}
	}

	// Token: 0x04003F60 RID: 16224
	private const string NEWCOMER_LOGO_MALE_RESOURCE_ID = "T_RoleLogoMale";

	// Token: 0x04003F61 RID: 16225
	private const string NEWCOMER_LOGO_FEMALE_RESOURCE_ID = "T_RoleLogoFemale";

	// Token: 0x04003F62 RID: 16226
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x04003F63 RID: 16227
	private int ActivityIdCached;

	// Token: 0x02006BA2 RID: 27554
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04023632 RID: 144946
		public const int TxtDesc = 0;

		// Token: 0x04023633 RID: 144947
		public const int RewardLayout = 1;

		// Token: 0x04023634 RID: 144948
		public const int RewardItem = 2;

		// Token: 0x04023635 RID: 144949
		public const int TxtTipTitle = 3;

		// Token: 0x04023636 RID: 144950
		public const int TxtTitle = 4;

		// Token: 0x04023637 RID: 144951
		public const int EmptyBtn = 5;

		// Token: 0x04023638 RID: 144952
		public const int TitleLogo = 6;

		// Token: 0x04023639 RID: 144953
		public const int TitleLogo2 = 7;
	}
}
