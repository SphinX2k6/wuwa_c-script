using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005907 RID: 22791
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolEventCheckGameplay : SolarSchoolGameplayBase, ISolarSchoolEventCheckViewHandler
	{
		// Token: 0x060382F7 RID: 230135 RVA: 0x00FB49DC File Offset: 0x00FB2BDC
		protected override void OnGameplayStart()
		{
			this.EventCheck = SolarSchoolConfig.Instance.GetEventCheck(base.GameplayId);
			if (this.EventCheck == null)
			{
				base.MarkFailed();
				return;
			}
			this.RadarDisplayMax = this.CalcRadarDisplayMax();
			this.PlayerDisplayRadii = this.BuildPlayerDisplayRadii();
			base.AddState("Popup", new Action(this.EnterPopup));
			base.AddState("OpenView", new Action(this.EnterOpenView));
			base.AddState("WaitChoice", new Action(this.EnterWaitChoice));
			base.AddState("Judge", new Action(this.EnterJudge));
			base.AddState("FakeAnim", new Action(this.EnterFakeAnim));
			base.AddState("ShowResult", new Action(this.EnterShowResult));
		}

		// Token: 0x060382F8 RID: 230136 RVA: 0x00FB4AB5 File Offset: 0x00FB2CB5
		protected override void OnGameplayEnd()
		{
			this.CloseView();
		}

		// Token: 0x060382F9 RID: 230137 RVA: 0x00FB4AC0 File Offset: 0x00FB2CC0
		private void EnterPopup()
		{
			SolarSchoolEventPopupParam param = new SolarSchoolEventPopupParam
			{
				PopupId = ESolarSchoolPopupId.EventCheckStart,
				OnCloseCallback = delegate()
				{
					base.GotoState("OpenView");
				}
			};
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolEventPopupView, param, null);
		}

		// Token: 0x060382FA RID: 230138 RVA: 0x00FB4AFD File Offset: 0x00FB2CFD
		private void EnterOpenView()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolEventCheckView, this, null);
		}

		// Token: 0x060382FB RID: 230139 RVA: 0x00FB4B10 File Offset: 0x00FB2D10
		private void EnterWaitChoice()
		{
			IReadOnlyList<SolarSchoolEventCheckOpt> opts = SolarSchoolConfig.Instance.GetEventCheckOptListByGroupId(this.EventCheck.Value.OptionGroupId) ?? Array.Empty<SolarSchoolEventCheckOpt>();
			SolarSchoolEventCheckView view = this.View;
			if (view == null)
			{
				return;
			}
			view.ShowEvent(this.EventCheck.Value, opts, this.PlayerDisplayRadii);
		}

		// Token: 0x060382FC RID: 230140 RVA: 0x00FB4B68 File Offset: 0x00FB2D68
		private float CalcRadarDisplayMax()
		{
			ESolarSchoolSecondAttr[] attrsShowList = SolarSchoolDefine.AttrsShowList;
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			SolarSchoolPlayerData playerData = SolarSchoolGamePlayModel.Instance.PlayerData;
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < attrsShowList.Length; i++)
			{
				num = Math.Max(num, playerData.GetAttr(attrsShowList[i]));
				SolarSchoolAttr? solarSchoolAttr = SolarSchoolConfig.Instance.TryGetAttrByType(activityId, (int)attrsShowList[i]);
				num2 = Math.Max(num2, (solarSchoolAttr != null) ? solarSchoolAttr.GetValueOrDefault().MaxValue : 0);
			}
			IReadOnlyList<SolarSchoolEventCheckOpt> eventCheckOptListByGroupId = SolarSchoolConfig.Instance.GetEventCheckOptListByGroupId(this.EventCheck.Value.OptionGroupId);
			if (eventCheckOptListByGroupId != null)
			{
				foreach (SolarSchoolEventCheckOpt solarSchoolEventCheckOpt in eventCheckOptListByGroupId)
				{
					int num3 = 0;
					while (num3 < attrsShowList.Length && num3 < solarSchoolEventCheckOpt.AttrRequireLength)
					{
						num = Math.Max(num, solarSchoolEventCheckOpt.AttrRequire(num3));
						num3++;
					}
				}
			}
			float num4 = (float)num * 1.15f;
			if (num2 <= 0)
			{
				return num4;
			}
			return Math.Min(num4, (float)num2);
		}

		// Token: 0x060382FD RID: 230141 RVA: 0x00FB4C98 File Offset: 0x00FB2E98
		private float[] BuildPlayerDisplayRadii()
		{
			ESolarSchoolSecondAttr[] attrsShowList = SolarSchoolDefine.AttrsShowList;
			SolarSchoolPlayerData playerData = SolarSchoolGamePlayModel.Instance.PlayerData;
			float[] array = new float[attrsShowList.Length];
			for (int i = 0; i < attrsShowList.Length; i++)
			{
				array[i] = ((this.RadarDisplayMax > 0f) ? Math.Clamp((float)playerData.GetAttr(attrsShowList[i]) / this.RadarDisplayMax, 0f, 1f) : 0f);
			}
			return array;
		}

		// Token: 0x060382FE RID: 230142 RVA: 0x00FB4D08 File Offset: 0x00FB2F08
		private unsafe void EnterJudge()
		{
			SolarSchoolEventCheckOpt? eventCheckOpt = SolarSchoolConfig.Instance.GetEventCheckOpt(this.ChosenOptionId);
			if (eventCheckOpt == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool][EventCheck] 选项表缺行，按失败结算";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", base.GameplayId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("optionId", this.ChosenOptionId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.JudgeSuccess = false;
				this.LowRateThreshold = 0;
				base.GotoState("FakeAnim");
				return;
			}
			SolarSchoolEventCheckOpt value = eventCheckOpt.Value;
			ESolarSchoolSecondAttr[] attrsShowList = SolarSchoolDefine.AttrsShowList;
			int num = attrsShowList.Length;
			double[] array = new double[num];
			double[] array2 = new double[num];
			SolarSchoolPlayerData playerData = SolarSchoolGamePlayModel.Instance.PlayerData;
			this.EventDisplayRadii = new float[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = (double)((i < value.AttrRequireLength) ? value.AttrRequire(i) : 0);
				array2[i] = (double)playerData.GetAttr(attrsShowList[i]);
				this.EventDisplayRadii[i] = ((this.RadarDisplayMax > 0f) ? Math.Clamp((float)(array[i] / (double)this.RadarDisplayMax), 0f, 1f) : 0f);
			}
			int num2 = (int)Math.Round(SolarSchoolRadarOverlapUtil.CalcProbability(array2, array) * (double)RandomSystem.RAND_PERCENT);
			this.Rate = (double)num2;
			this.LowRateThreshold = value.LowSuccessRate;
			int num3 = num2;
			int num4;
			if (SolarSchoolConfig.Instance.TryMapEventProbability(num2, out num4))
			{
				num3 = num4;
			}
			this.JudgeSuccess = (RandomSystem.GetRandomPercent() < (float)num3);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.YYZ;
			string message2 = "[SolarSchool][EventCheck] 概率判定";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("configId", base.GameplayId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("optionId", this.ChosenOptionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("realPercent", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("finalPercent", num3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("success", this.JudgeSuccess);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
			base.GotoState("FakeAnim");
		}

		// Token: 0x060382FF RID: 230143 RVA: 0x00FB4F91 File Offset: 0x00FB3191
		private void EnterFakeAnim()
		{
			SolarSchoolEventCheckView view = this.View;
			if (view == null)
			{
				return;
			}
			view.PlayJudgeAnim(this.JudgeSuccess, this.Rate, this.LowRateThreshold, this.EventDisplayRadii);
		}

		// Token: 0x06038300 RID: 230144 RVA: 0x00FB4FBC File Offset: 0x00FB31BC
		private void EnterShowResult()
		{
			SolarSchoolEventCheckOpt value = SolarSchoolConfig.Instance.GetEventCheckOpt(this.ChosenOptionId).Value;
			if (value.AddScore != 0 && SolarSchoolGamePlayModel.Instance.InstanceType == ESolarSchoolInstanceType.Exam)
			{
				if (this.JudgeSuccess)
				{
					SolarSchoolGamePlayModel.Instance.AddCurrentExamScore(value.AddScore);
				}
			}
			else
			{
				int num = this.JudgeSuccess ? value.RewardSuccess : value.RewardFail;
				if (num > 0)
				{
					SolarSchoolRewardCenter.Instance.TryGiveReward(num);
				}
			}
			foreach (int actionId in this.JudgeSuccess ? value.SuccessActionList() : value.FailActionList())
			{
				this.PushSerialAction(actionId);
			}
			SolarSchoolEventCheckView view = this.View;
			if (view == null)
			{
				return;
			}
			view.ShowResult(this.JudgeSuccess, this.JudgeSuccess ? value.SuccessDescKey : value.FailDescKey);
		}

		// Token: 0x06038301 RID: 230145 RVA: 0x00FB50A4 File Offset: 0x00FB32A4
		private unsafe void PushSerialAction(int actionId)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolActionBase solarSchoolActionBase = instance.CreateAction(actionId);
			if (solarSchoolActionBase == null)
			{
				return;
			}
			if (!instance.TryInjectActionToCurrentTask(solarSchoolActionBase))
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool][EventCheck] 结束串行 Action 加入当前 Task 失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actionId", actionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("actionType", solarSchoolActionBase.GetType().Name);
				instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x06038302 RID: 230146 RVA: 0x00FB5131 File Offset: 0x00FB3331
		public void OnViewReady(SolarSchoolEventCheckView view)
		{
			this.View = view;
			base.GotoState("WaitChoice");
		}

		// Token: 0x06038303 RID: 230147 RVA: 0x00FB5145 File Offset: 0x00FB3345
		public void OnChoiceSelected(int optionId)
		{
			this.ChosenOptionId = optionId;
			base.GotoState("Judge");
		}

		// Token: 0x06038304 RID: 230148 RVA: 0x00FB5159 File Offset: 0x00FB3359
		public void OnJudgeAnimFinished()
		{
			base.GotoState("ShowResult");
		}

		// Token: 0x06038305 RID: 230149 RVA: 0x00FB5166 File Offset: 0x00FB3366
		public void OnResultConfirmed()
		{
			this.CloseView();
			base.FinishGameplay();
		}

		// Token: 0x06038306 RID: 230150 RVA: 0x00FB5174 File Offset: 0x00FB3374
		public void OnViewClosed()
		{
			this.View = null;
		}

		// Token: 0x06038307 RID: 230151 RVA: 0x00FB517D File Offset: 0x00FB337D
		private void CloseView()
		{
			if (this.View == null)
			{
				base.CloseOpeningView(EUiViewName.SolarSchoolEventCheckView);
				return;
			}
			UiViewBase view = this.View;
			this.View = null;
			view.CloseMe(null);
		}

		// Token: 0x0401D948 RID: 121160
		[Nullable(2)]
		private SolarSchoolEventCheckView View;

		// Token: 0x0401D949 RID: 121161
		public SolarSchoolEventCheck? EventCheck;

		// Token: 0x0401D94A RID: 121162
		private bool JudgeSuccess;

		// Token: 0x0401D94B RID: 121163
		private int ChosenOptionId;

		// Token: 0x0401D94C RID: 121164
		private double Rate;

		// Token: 0x0401D94D RID: 121165
		private int LowRateThreshold;

		// Token: 0x0401D94E RID: 121166
		private const float RadarExtraRatio = 0.15f;

		// Token: 0x0401D94F RID: 121167
		private float RadarDisplayMax;

		// Token: 0x0401D950 RID: 121168
		private float[] PlayerDisplayRadii = Array.Empty<float>();

		// Token: 0x0401D951 RID: 121169
		private float[] EventDisplayRadii = Array.Empty<float>();

		// Token: 0x0200B4C5 RID: 46277
		[Nullable(0)]
		private static class GameplayState
		{
			// Token: 0x04037E55 RID: 228949
			public const string Popup = "Popup";

			// Token: 0x04037E56 RID: 228950
			public const string OpenView = "OpenView";

			// Token: 0x04037E57 RID: 228951
			public const string WaitChoice = "WaitChoice";

			// Token: 0x04037E58 RID: 228952
			public const string Judge = "Judge";

			// Token: 0x04037E59 RID: 228953
			public const string FakeAnim = "FakeAnim";

			// Token: 0x04037E5A RID: 228954
			public const string ShowResult = "ShowResult";
		}
	}
}
