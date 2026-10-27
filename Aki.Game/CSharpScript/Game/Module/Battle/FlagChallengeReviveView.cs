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
	// Token: 0x02005C3F RID: 23615
	public class FlagChallengeReviveView : UiTickViewBase
	{
		// Token: 0x0603BA80 RID: 244352 RVA: 0x00E3C8C3 File Offset: 0x00E3AAC3
		[NullableContext(1)]
		public FlagChallengeReviveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603BA81 RID: 244353 RVA: 0x00E3C8CC File Offset: 0x00E3AACC
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

		// Token: 0x0603BA82 RID: 244354 RVA: 0x00E3CB08 File Offset: 0x00E3AD08
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

		// Token: 0x0603BA83 RID: 244355 RVA: 0x00E3CC35 File Offset: 0x00E3AE35
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

		// Token: 0x0603BA84 RID: 244356 RVA: 0x00E3CC6C File Offset: 0x00E3AE6C
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

		// Token: 0x0603BA85 RID: 244357 RVA: 0x00E3CCC0 File Offset: 0x00E3AEC0
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

		// Token: 0x0603BA86 RID: 244358 RVA: 0x00E3CD28 File Offset: 0x00E3AF28
		private void OnClickRevive()
		{
			DeadReviveController.Instance.ReviveRequest(false, null, new int?(0));
			base.CloseMe(null);
		}

		// Token: 0x0603BA87 RID: 244359 RVA: 0x00E3CD44 File Offset: 0x00E3AF44
		private void OnClickGiveUp()
		{
			int activityId = FlagChallengeBattleModel.Instance.ActivityId;
			int levelId = FlagChallengeBattleModel.Instance.LevelId;
			int levelRecommendStrongholdId = FlagChallengeModel.Instance.GetLevelRecommendStrongholdId(activityId, levelId, null);
			DeadReviveController.Instance.ReviveRequest(false, null, new int?(levelRecommendStrongholdId));
			base.CloseMe(null);
		}

		// Token: 0x0401F0E7 RID: 127207
		private const float TIME_SECOND = 1000f;

		// Token: 0x0401F0E8 RID: 127208
		private const float AUTO_REVIVE_TIME = 60f;

		// Token: 0x0401F0E9 RID: 127209
		private float TimeCount;

		// Token: 0x0401F0EA RID: 127210
		private bool IsAutoRevived;

		// Token: 0x0401F0EB RID: 127211
		private float AutoReviveCountDownTime;

		// Token: 0x0401F0EC RID: 127212
		[Nullable(2)]
		private UUIText AutoReviveCountDown;

		// Token: 0x0401F0ED RID: 127213
		[Nullable(2)]
		private TrainingView TrainingView;

		// Token: 0x0200BE34 RID: 48692
		private enum EComponentType
		{
			// Token: 0x040395B5 RID: 234933
			Revive,
			// Token: 0x040395B6 RID: 234934
			Fail,
			// Token: 0x040395B7 RID: 234935
			ReviveBtn,
			// Token: 0x040395B8 RID: 234936
			GiveUpBtn,
			// Token: 0x040395B9 RID: 234937
			WaitTime,
			// Token: 0x040395BA RID: 234938
			ReviveTitle,
			// Token: 0x040395BB RID: 234939
			ReviveContent,
			// Token: 0x040395BC RID: 234940
			RoleTrainingLayout,
			// Token: 0x040395BD RID: 234941
			ReviveAtLocationBtn,
			// Token: 0x040395BE RID: 234942
			AutoReviveCountDownText,
			// Token: 0x040395BF RID: 234943
			ItemTexture,
			// Token: 0x040395C0 RID: 234944
			ItemText,
			// Token: 0x040395C1 RID: 234945
			GiveUpBtnText
		}
	}
}
