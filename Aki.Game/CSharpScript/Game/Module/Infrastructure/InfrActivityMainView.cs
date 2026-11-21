using System;
using System.Collections.Generic;
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
	// Token: 0x020048E3 RID: 18659
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrActivityMainView : ActivitySubViewBase
	{
		// Token: 0x17005EA6 RID: 24230
		// (get) Token: 0x0602ED40 RID: 191808 RVA: 0x00D0E698 File Offset: 0x00D0C898
		[Nullable(2)]
		protected new InfrastructureActivityData ActivityBaseData
		{
			[NullableContext(2)]
			get
			{
				return this.ActivityBaseData as InfrastructureActivityData;
			}
		}

		// Token: 0x0602ED41 RID: 191809 RVA: 0x00D0E6A8 File Offset: 0x00D0C8A8
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

		// Token: 0x0602ED42 RID: 191810 RVA: 0x00D0E8C0 File Offset: 0x00D0CAC0
		protected override UniTask OnBeforeStartAsync()
		{
			InfrActivityMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrActivityMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602ED43 RID: 191811 RVA: 0x00D0E904 File Offset: 0x00D0CB04
		private UniTask CreateLimitedRewardBtnAsync()
		{
			InfrActivityMainView.<CreateLimitedRewardBtnAsync>d__9 <CreateLimitedRewardBtnAsync>d__;
			<CreateLimitedRewardBtnAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateLimitedRewardBtnAsync>d__.<>4__this = this;
			<CreateLimitedRewardBtnAsync>d__.<>1__state = -1;
			<CreateLimitedRewardBtnAsync>d__.<>t__builder.Start<InfrActivityMainView.<CreateLimitedRewardBtnAsync>d__9>(ref <CreateLimitedRewardBtnAsync>d__);
			return <CreateLimitedRewardBtnAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602ED44 RID: 191812 RVA: 0x00D0E948 File Offset: 0x00D0CB48
		private UniTask CreateExchangeBtnAsync()
		{
			InfrActivityMainView.<CreateExchangeBtnAsync>d__10 <CreateExchangeBtnAsync>d__;
			<CreateExchangeBtnAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateExchangeBtnAsync>d__.<>4__this = this;
			<CreateExchangeBtnAsync>d__.<>1__state = -1;
			<CreateExchangeBtnAsync>d__.<>t__builder.Start<InfrActivityMainView.<CreateExchangeBtnAsync>d__10>(ref <CreateExchangeBtnAsync>d__);
			return <CreateExchangeBtnAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602ED45 RID: 191813 RVA: 0x00D0E98B File Offset: 0x00D0CB8B
		protected override void OnStart()
		{
			this.RefreshShopBtn();
			this.RefreshLimitRewardBtn();
			this.RefreshProgress();
			this.RefreshActivityInfo();
			this.RefreshGender();
		}

		// Token: 0x0602ED46 RID: 191814 RVA: 0x00D0E9AB File Offset: 0x00D0CBAB
		protected override void OnRefreshView()
		{
			this.RefreshShopBtn();
			this.RefreshLimitRewardBtn();
			this.RefreshProgress();
			this.RefreshActivityInfo();
			this.RefreshGender();
		}

		// Token: 0x0602ED47 RID: 191815 RVA: 0x00D0E9CC File Offset: 0x00D0CBCC
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
			int num = 0;
			using (List<InfrastructureLimitTaskData>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == ActivityTaskState.ActivityTaskTaken)
					{
						num++;
					}
				}
			}
			ButtonItem limitRewardBtn = this.LimitRewardBtn;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(list.Count);
			limitRewardBtn.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0602ED48 RID: 191816 RVA: 0x00D0EAC4 File Offset: 0x00D0CCC4
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

		// Token: 0x0602ED49 RID: 191817 RVA: 0x00D0EB4C File Offset: 0x00D0CD4C
		private void RefreshProgress()
		{
			InfrastructureConfig instance = InfrastructureConfig.Instance;
			int fireLevel = InfrastructureModel.Instance.FireLevel;
			long fireExp = InfrastructureModel.Instance.FireExp;
			IReadOnlyList<InfrLevel> allLevelConfigs = instance.GetAllLevelConfigs();
			if (allLevelConfigs.Count == 0)
			{
				throw new InvalidOperationException("Sequence contains no elements");
			}
			int level = allLevelConfigs[0].Level;
			for (int i = 1; i < allLevelConfigs.Count; i++)
			{
				if (allLevelConfigs[i].Level > level)
				{
					level = allLevelConfigs[i].Level;
				}
			}
			List<List<bool>> list = new List<List<bool>>();
			for (int j = 1; j < level; j++)
			{
				if (j == level - 1 && fireLevel == level)
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
						fireExp >= (long)instance.GetLevelConfigById(j).Value.Exp,
						false
					});
				}
			}
			this.ProgressLayout.RefreshByData(list, null, false);
			float num;
			if (fireLevel == level)
			{
				num = 1f;
			}
			else
			{
				num = (float)(fireLevel - 1) / (float)(level - 1) + (float)(fireExp - (long)instance.GetLevelConfigById(fireLevel).Value.Exp) / (float)(instance.GetLevelConfigById(fireLevel + 1).Value.Exp - instance.GetLevelConfigById(fireLevel).Value.Exp);
			}
			base.GetSprite(4).SetFillAmount(num);
			base.GetArtText(7).SetText((num * 100f).ToString("0"));
			base.GetArtText(8).SetText((num * 100f).ToString("0"));
		}

		// Token: 0x0602ED4A RID: 191818 RVA: 0x00D0ED30 File Offset: 0x00D0CF30
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

		// Token: 0x0602ED4B RID: 191819 RVA: 0x00D0EDB4 File Offset: 0x00D0CFB4
		private void RefreshGender()
		{
			if (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male)
			{
				base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/BgCgBig/Activity/Activity30/ActivityInfrastructure/ActivityMain/T_AcivityMainMale.T_AcivityMainMale", base.GetTexture(11), null, null);
				return;
			}
			base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/BgCgBig/Activity/Activity30/ActivityInfrastructure/ActivityMain/T_AcivityMainFemale.T_AcivityMainFemale", base.GetTexture(11), null, null);
		}

		// Token: 0x0602ED4C RID: 191820 RVA: 0x00D0EE09 File Offset: 0x00D0D009
		private void OnConfirmBtnClick()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				InfrastructureController.Instance.OpenInfrastructureMainView(null).Forget<int?>();
			});
		}

		// Token: 0x0602ED4D RID: 191821 RVA: 0x00D0EE3A File Offset: 0x00D0D03A
		private void OnBtnPermanentRewardClick()
		{
			UiManager.Instance.OpenView(EUiViewName.InfrastructureShopMainView, new InfrastructureDefine.InfrShopOpenParam
			{
				OpenSource = InfrastructureDefine.EInfrViewOpenSource.Activity
			}, null);
		}

		// Token: 0x0602ED4E RID: 191822 RVA: 0x00D0EE58 File Offset: 0x00D0D058
		private void OnBtnLimitRewardClick()
		{
			UiManager.Instance.OpenView(EUiViewName.InfrLimitTaskMainView, new InfrastructureDefine.InfrLimitTaskOpenParam
			{
				OpenSource = InfrastructureDefine.EInfrViewOpenSource.Activity
			}, null);
		}

		// Token: 0x04018DA9 RID: 101801
		protected ActivitySubViewGeneralInfo CommonInfoPanel = new ActivitySubViewGeneralInfo();

		// Token: 0x04018DAA RID: 101802
		private ButtonItem PermanentRewardBtn = new ButtonItem(null);

		// Token: 0x04018DAB RID: 101803
		private ButtonItem LimitRewardBtn = new ButtonItem(null);

		// Token: 0x04018DAC RID: 101804
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<InfrActivityProgressItem, List<bool>> ProgressLayout;

		// Token: 0x0200A581 RID: 42369
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04033328 RID: 209704
			public const int CommonActionInfo = 0;

			// Token: 0x04033329 RID: 209705
			public const int BtnLimitReward = 1;

			// Token: 0x0403332A RID: 209706
			public const int BtnPermanentReward = 2;

			// Token: 0x0403332B RID: 209707
			public const int PanelActivated = 3;

			// Token: 0x0403332C RID: 209708
			public const int SpriteProgress = 4;

			// Token: 0x0403332D RID: 209709
			public const int HorizontalLayoutPoint = 5;

			// Token: 0x0403332E RID: 209710
			public const int PanelPoint = 6;

			// Token: 0x0403332F RID: 209711
			public const int ArtTextProgress = 7;

			// Token: 0x04033330 RID: 209712
			public const int ArtTextProgressBg = 8;

			// Token: 0x04033331 RID: 209713
			public const int TextProgressDescription = 9;

			// Token: 0x04033332 RID: 209714
			public const int TextRewardDescription = 10;

			// Token: 0x04033333 RID: 209715
			public const int TextureRole = 11;
		}
	}
}
