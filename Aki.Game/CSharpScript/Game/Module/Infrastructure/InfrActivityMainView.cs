using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x0200590A RID: 22794
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrActivityMainView : ActivitySubViewBase
	{
		// Token: 0x17008ADA RID: 35546
		// (get) Token: 0x06039E1D RID: 237085 RVA: 0x00DBF400 File Offset: 0x00DBD600
		[Nullable(2)]
		protected new InfrastructureActivityData ActivityBaseData
		{
			[NullableContext(2)]
			get
			{
				return this.ActivityBaseData as InfrastructureActivityData;
			}
		}

		// Token: 0x06039E1E RID: 237086 RVA: 0x00DBF410 File Offset: 0x00DBD610
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnPermanentRewardClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnLimitRewardClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039E1F RID: 237087 RVA: 0x00DBF628 File Offset: 0x00DBD828
		protected override UniTask OnBeforeStartAsync()
		{
			InfrActivityMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrActivityMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039E20 RID: 237088 RVA: 0x00DBF66C File Offset: 0x00DBD86C
		private UniTask CreateLimitedRewardBtnAsync()
		{
			InfrActivityMainView.<CreateLimitedRewardBtnAsync>d__9 <CreateLimitedRewardBtnAsync>d__;
			<CreateLimitedRewardBtnAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateLimitedRewardBtnAsync>d__.<>4__this = this;
			<CreateLimitedRewardBtnAsync>d__.<>1__state = -1;
			<CreateLimitedRewardBtnAsync>d__.<>t__builder.Start<InfrActivityMainView.<CreateLimitedRewardBtnAsync>d__9>(ref <CreateLimitedRewardBtnAsync>d__);
			return <CreateLimitedRewardBtnAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039E21 RID: 237089 RVA: 0x00DBF6B0 File Offset: 0x00DBD8B0
		private UniTask CreateExchangeBtnAsync()
		{
			InfrActivityMainView.<CreateExchangeBtnAsync>d__10 <CreateExchangeBtnAsync>d__;
			<CreateExchangeBtnAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateExchangeBtnAsync>d__.<>4__this = this;
			<CreateExchangeBtnAsync>d__.<>1__state = -1;
			<CreateExchangeBtnAsync>d__.<>t__builder.Start<InfrActivityMainView.<CreateExchangeBtnAsync>d__10>(ref <CreateExchangeBtnAsync>d__);
			return <CreateExchangeBtnAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039E22 RID: 237090 RVA: 0x00DBF6F3 File Offset: 0x00DBD8F3
		protected override void OnStart()
		{
			this.RefreshShopBtn();
			this.RefreshLimitRewardBtn();
			this.RefreshProgress();
			this.RefreshActivityInfo();
			this.RefreshGender();
		}

		// Token: 0x06039E23 RID: 237091 RVA: 0x00DBF713 File Offset: 0x00DBD913
		protected override void OnRefreshView()
		{
			this.RefreshShopBtn();
			this.RefreshLimitRewardBtn();
			this.RefreshProgress();
			this.RefreshActivityInfo();
			this.RefreshGender();
		}

		// Token: 0x06039E24 RID: 237092 RVA: 0x00DBF734 File Offset: 0x00DBD934
		private void RefreshLimitRewardBtn()
		{
			if (!FunctionModel.Instance.IsOpen(EFunctionType.Infrastructure))
			{
				this.LimitRewardBtn.SetUiActive(false);
				return;
			}
			this.LimitRewardBtn.SetFunction(delegate(int _)
			{
				this.OnBtnLimitRewardClick();
			});
			this.LimitRewardBtn.BindRedDot(ERedDotName.InfrLimitedTask, 0);
			InfrastructureActivityData activityData = InfrastructureModel.Instance.GetActivityData();
			List<InfrastructureLimitTaskData> list = ((activityData != null) ? activityData.GetActivityTaskDataList() : null) ?? new List<InfrastructureLimitTaskData>();
			int value = list.Count((InfrastructureLimitTaskData item) => item.Status == ActivityTaskState.ActivityTaskTaken);
			ButtonItem limitRewardBtn = this.LimitRewardBtn;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(list.Count);
			limitRewardBtn.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06039E25 RID: 237093 RVA: 0x00DBF80C File Offset: 0x00DBDA0C
		private void RefreshShopBtn()
		{
			if (!FunctionModel.Instance.IsOpen(EFunctionType.Infrastructure))
			{
				this.PermanentRewardBtn.SetUiActive(false);
				return;
			}
			InfrastructureModel instance = InfrastructureModel.Instance;
			int allShopCurrencyNum = instance.GetAllShopCurrencyNum();
			ButtonItem permanentRewardBtn = this.PermanentRewardBtn;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<long>(instance.MoneyHistorySpent);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(allShopCurrencyNum);
			permanentRewardBtn.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
			this.PermanentRewardBtn.BindRedDot(ERedDotName.InfrShop, 0);
		}

		// Token: 0x06039E26 RID: 237094 RVA: 0x00DBF894 File Offset: 0x00DBDA94
		private void RefreshProgress()
		{
			InfrastructureConfig instance = InfrastructureConfig.Instance;
			int fireLevel = InfrastructureModel.Instance.FireLevel;
			long fireExp = InfrastructureModel.Instance.FireExp;
			int num = instance.GetAllLevelConfigs().Max((InfrLevel prev) => prev.Level);
			List<List<bool>> list = new List<List<bool>>();
			for (int i = 1; i < num; i++)
			{
				if (i == num - 1 && fireLevel == num)
				{
					list.Add(new List<bool>
					{
						true,
						true
					});
				}
				else
				{
					list.Add(new List<bool>
					{
						fireExp >= (long)instance.GetLevelConfigById(i).Value.Exp,
						false
					});
				}
			}
			this.ProgressLayout.RefreshByData(list, null, false);
			float num2;
			if (fireLevel == num)
			{
				num2 = 1f;
			}
			else
			{
				num2 = (float)(fireLevel - 1) / (float)(num - 1) + (float)(fireExp - (long)instance.GetLevelConfigById(fireLevel).Value.Exp) / (float)(instance.GetLevelConfigById(fireLevel + 1).Value.Exp - instance.GetLevelConfigById(fireLevel).Value.Exp);
			}
			base.GetSprite(4).SetFillAmount(num2);
			base.GetArtText(7).SetText((num2 * 100f).ToString("0"));
			base.GetArtText(8).SetText((num2 * 100f).ToString("0"));
		}

		// Token: 0x06039E27 RID: 237095 RVA: 0x00DBFA38 File Offset: 0x00DBDC38
		private void RefreshActivityInfo()
		{
			this.CommonInfoPanel.SetBtnText("LongShanStage_Join01", Array.Empty<object>());
			this.CommonInfoPanel.SetClickFunc(delegate(ActivityBaseData _)
			{
				this.OnConfirmBtnClick();
			});
			this.CommonInfoPanel.SetFunctionRedDotVisible(this.ActivityBaseData.CheckRedDot());
			ActivityFunctionalTypeA functional = this.CommonInfoPanel.GetFunctional();
			ActivityFunctionAreaParams parameters = new ActivityFunctionAreaParams
			{
				UnlockBtnTextId = "LongShanStage_Join01",
				UnlockBtnFunction = new Action(this.OnConfirmBtnClick)
			};
			functional.RefreshGeneralPerformance(parameters);
		}

		// Token: 0x06039E28 RID: 237096 RVA: 0x00DBFABC File Offset: 0x00DBDCBC
		private void RefreshGender()
		{
			if (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male)
			{
				base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/BgCgBig/Activity/Activity30/ActivityInfrastructure/ActivityMain/T_AcivityMainMale.T_AcivityMainMale", base.GetTexture(11), null, null);
				return;
			}
			base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/BgCgBig/Activity/Activity30/ActivityInfrastructure/ActivityMain/T_AcivityMainFemale.T_AcivityMainFemale", base.GetTexture(11), null, null);
		}

		// Token: 0x06039E29 RID: 237097 RVA: 0x00DBFB11 File Offset: 0x00DBDD11
		private void OnConfirmBtnClick()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				InfrastructureController.Instance.OpenInfrastructureMainView(null).Forget<int?>();
			});
		}

		// Token: 0x06039E2A RID: 237098 RVA: 0x00DBFB42 File Offset: 0x00DBDD42
		private void OnBtnPermanentRewardClick()
		{
			UiManager.Instance.OpenView(EUiViewName.InfrastructureShopMainView, new InfrastructureDefine.InfrShopOpenParam
			{
				OpenSource = InfrastructureDefine.EInfrViewOpenSource.Activity
			}, null);
		}

		// Token: 0x06039E2B RID: 237099 RVA: 0x00DBFB60 File Offset: 0x00DBDD60
		private void OnBtnLimitRewardClick()
		{
			UiManager.Instance.OpenView(EUiViewName.InfrLimitTaskMainView, new InfrastructureDefine.InfrLimitTaskOpenParam
			{
				OpenSource = InfrastructureDefine.EInfrViewOpenSource.Activity
			}, null);
		}

		// Token: 0x0401E30C RID: 123660
		protected ActivitySubViewGeneralInfo CommonInfoPanel = new ActivitySubViewGeneralInfo();

		// Token: 0x0401E30D RID: 123661
		private ButtonItem PermanentRewardBtn = new ButtonItem(null);

		// Token: 0x0401E30E RID: 123662
		private ButtonItem LimitRewardBtn = new ButtonItem(null);

		// Token: 0x0401E30F RID: 123663
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<InfrActivityProgressItem, List<bool>> ProgressLayout;

		// Token: 0x0200BB71 RID: 47985
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403893E RID: 231742
			public const int CommonActionInfo = 0;

			// Token: 0x0403893F RID: 231743
			public const int BtnLimitReward = 1;

			// Token: 0x04038940 RID: 231744
			public const int BtnPermanentReward = 2;

			// Token: 0x04038941 RID: 231745
			public const int PanelActivated = 3;

			// Token: 0x04038942 RID: 231746
			public const int SpriteProgress = 4;

			// Token: 0x04038943 RID: 231747
			public const int HorizontalLayoutPoint = 5;

			// Token: 0x04038944 RID: 231748
			public const int PanelPoint = 6;

			// Token: 0x04038945 RID: 231749
			public const int ArtTextProgress = 7;

			// Token: 0x04038946 RID: 231750
			public const int ArtTextProgressBg = 8;

			// Token: 0x04038947 RID: 231751
			public const int TextProgressDescription = 9;

			// Token: 0x04038948 RID: 231752
			public const int TextRewardDescription = 10;

			// Token: 0x04038949 RID: 231753
			public const int TextureRole = 11;
		}
	}
}
