using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.DeadRevive;
using CSharpScript.Game.Module.FlagChallenge;
using CSharpScript.Game.Module.TrainingDegree;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C1F RID: 19487
	public class FlagChallengeReviveView : UiTickViewBase
	{
		// Token: 0x060309CB RID: 199115 RVA: 0x00D8CC33 File Offset: 0x00D8AE33
		[NullableContext(1)]
		public FlagChallengeReviveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060309CC RID: 199116 RVA: 0x00D8CC3C File Offset: 0x00D8AE3C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickRevive));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickGiveUp));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060309CD RID: 199117 RVA: 0x00D8CE78 File Offset: 0x00D8B078
		protected override void OnStart()
		{
			this.IsAutoRevived = false;
			this.AutoReviveCountDown = base.GetText(9);
			this.AutoReviveCountDownTime = 60f;
			this.AutoReviveCountDown.SetUIActive(true);
			LguiUtil.Instance.SetLocalText(this.AutoReviveCountDown, "ReviveItemTips", new <>z__ReadOnlySingleElementList<object>(this.AutoReviveCountDownTime));
			UUIText text = base.GetText(5);
			DeadReviveModel instance = DeadReviveModel.Instance;
			text.ShowTextNew(((instance.ReviveConfig != null) ? instance.ReviveConfig.GetValueOrDefault().ReviveTitle : null) ?? string.Empty);
			UUIText text2 = base.GetText(6);
			DeadReviveModel instance2 = DeadReviveModel.Instance;
			string key = ((instance2.ReviveConfig != null) ? instance2.ReviveConfig.GetValueOrDefault().ReviveContent : null) ?? "Morale_title_29";
			text2.ShowTextNew(key);
			this.TrainingView = new TrainingView();
			this.TrainingView.Show(base.GetHorizontalLayout(7), FlagChallengeBattleModel.Instance.GetTrainingDataList());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "Morale_32_Fail_LowLevelButt", Array.Empty<object>());
			base.GetButton(3).RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x060309CE RID: 199118 RVA: 0x00D8CFA5 File Offset: 0x00D8B1A5
		protected override void OnTick(float delta)
		{
			if (this.IsAutoRevived)
			{
				return;
			}
			this.TimeCount += delta;
			if (this.TimeCount >= 1000f)
			{
				this.TimeCount = 0f;
				this.AutoReviveOnTick();
			}
		}

		// Token: 0x060309CF RID: 199119 RVA: 0x00D8CFDC File Offset: 0x00D8B1DC
		protected override void OnBeforeDestroy()
		{
			TrainingView trainingView = this.TrainingView;
			if (trainingView != null)
			{
				trainingView.Clear();
			}
			this.TrainingView = null;
			this.AutoReviveCountDown = null;
			this.TimeCount = 0f;
			this.AutoReviveCountDownTime = 0f;
			this.IsAutoRevived = false;
			DeadReviveModel.Instance.ClearExternalHandles();
		}

		// Token: 0x060309D0 RID: 199120 RVA: 0x00D8D030 File Offset: 0x00D8B230
		private void AutoReviveOnTick()
		{
			if (this.IsAutoRevived)
			{
				return;
			}
			if (this.AutoReviveCountDownTime <= 0f)
			{
				this.IsAutoRevived = true;
				this.OnClickRevive();
				return;
			}
			this.AutoReviveCountDownTime -= 1f;
			LguiUtil.Instance.SetLocalText(this.AutoReviveCountDown, "ReviveItemTips", new <>z__ReadOnlySingleElementList<object>(this.AutoReviveCountDownTime));
		}

		// Token: 0x060309D1 RID: 199121 RVA: 0x00D8D098 File Offset: 0x00D8B298
		private void OnClickRevive()
		{
			DeadReviveController.Instance.ReviveRequest(false, null, new int?(0));
			base.CloseMe(null);
		}

		// Token: 0x060309D2 RID: 199122 RVA: 0x00D8D0B4 File Offset: 0x00D8B2B4
		private void OnClickGiveUp()
		{
			int activityId = FlagChallengeBattleModel.Instance.ActivityId;
			int levelId = FlagChallengeBattleModel.Instance.LevelId;
			int levelRecommendStrongholdId = FlagChallengeModel.Instance.GetLevelRecommendStrongholdId(activityId, levelId, null);
			DeadReviveController.Instance.ReviveRequest(false, null, new int?(levelRecommendStrongholdId));
			base.CloseMe(null);
		}

		// Token: 0x04019B98 RID: 105368
		private const float TIME_SECOND = 1000f;

		// Token: 0x04019B99 RID: 105369
		private const float AUTO_REVIVE_TIME = 60f;

		// Token: 0x04019B9A RID: 105370
		private float TimeCount;

		// Token: 0x04019B9B RID: 105371
		private bool IsAutoRevived;

		// Token: 0x04019B9C RID: 105372
		private float AutoReviveCountDownTime;

		// Token: 0x04019B9D RID: 105373
		[Nullable(2)]
		private UUIText AutoReviveCountDown;

		// Token: 0x04019B9E RID: 105374
		[Nullable(2)]
		private TrainingView TrainingView;

		// Token: 0x0200A83C RID: 43068
		private enum EComponentType
		{
			// Token: 0x04033F78 RID: 212856
			Revive,
			// Token: 0x04033F79 RID: 212857
			Fail,
			// Token: 0x04033F7A RID: 212858
			ReviveBtn,
			// Token: 0x04033F7B RID: 212859
			GiveUpBtn,
			// Token: 0x04033F7C RID: 212860
			WaitTime,
			// Token: 0x04033F7D RID: 212861
			ReviveTitle,
			// Token: 0x04033F7E RID: 212862
			ReviveContent,
			// Token: 0x04033F7F RID: 212863
			RoleTrainingLayout,
			// Token: 0x04033F80 RID: 212864
			ReviveAtLocationBtn,
			// Token: 0x04033F81 RID: 212865
			AutoReviveCountDownText,
			// Token: 0x04033F82 RID: 212866
			ItemTexture,
			// Token: 0x04033F83 RID: 212867
			ItemText,
			// Token: 0x04033F84 RID: 212868
			GiveUpBtnText
		}
	}
}
