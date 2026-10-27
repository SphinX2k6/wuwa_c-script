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

// Token: 0x020013AB RID: 5035
[NullableContext(1)]
[Nullable(0)]
public class NewcomerSplashView : UiViewBase
{
	// Token: 0x06008D69 RID: 36201 RVA: 0x001E7007 File Offset: 0x001E5207
	public NewcomerSplashView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008D6A RID: 36202 RVA: 0x001E7010 File Offset: 0x001E5210
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

	// Token: 0x06008D6B RID: 36203 RVA: 0x001E7119 File Offset: 0x001E5319
	private void OnClickEmptyBtn()
	{
		if (!this.CheckActivityData(this.ActivityIdCached))
		{
			return;
		}
		ActivityController.Instance.OpenActivityById(this.ActivityIdCached, EActivityViewOpenType.HotKey, null, null);
		base.CloseMe(null);
	}

	// Token: 0x06008D6C RID: 36204 RVA: 0x001E7148 File Offset: 0x001E5348
	protected override UniTask OnBeforeStartAsync()
	{
		NewcomerSplashView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NewcomerSplashView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008D6D RID: 36205 RVA: 0x001E718C File Offset: 0x001E538C
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

	// Token: 0x06008D6E RID: 36206 RVA: 0x001E7231 File Offset: 0x001E5431
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		CommonItemSmallItemGrid commonItemSmallItemGrid = new CommonItemSmallItemGrid();
		commonItemSmallItemGrid.SetAllowClickBack(false);
		return commonItemSmallItemGrid;
	}

	// Token: 0x06008D6F RID: 36207 RVA: 0x001E7240 File Offset: 0x001E5440
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

	// Token: 0x06008D70 RID: 36208 RVA: 0x001E72F0 File Offset: 0x001E54F0
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

	// Token: 0x04003EC8 RID: 16072
	private const string NEWCOMER_LOGO_MALE_RESOURCE_ID = "T_RoleLogoMale";

	// Token: 0x04003EC9 RID: 16073
	private const string NEWCOMER_LOGO_FEMALE_RESOURCE_ID = "T_RoleLogoFemale";

	// Token: 0x04003ECA RID: 16074
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x04003ECB RID: 16075
	private int ActivityIdCached;

	// Token: 0x02007A1C RID: 31260
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028315 RID: 164629
		public const int TxtDesc = 0;

		// Token: 0x04028316 RID: 164630
		public const int RewardLayout = 1;

		// Token: 0x04028317 RID: 164631
		public const int RewardItem = 2;

		// Token: 0x04028318 RID: 164632
		public const int TxtTipTitle = 3;

		// Token: 0x04028319 RID: 164633
		public const int TxtTitle = 4;

		// Token: 0x0402831A RID: 164634
		public const int EmptyBtn = 5;

		// Token: 0x0402831B RID: 164635
		public const int TitleLogo = 6;

		// Token: 0x0402831C RID: 164636
		public const int TitleLogo2 = 7;
	}
}
