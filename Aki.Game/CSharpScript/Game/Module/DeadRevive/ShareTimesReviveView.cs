using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02005ACD RID: 23245
	public class ShareTimesReviveView : UiViewBase
	{
		// Token: 0x0603ADEA RID: 241130 RVA: 0x00E08FDA File Offset: 0x00E071DA
		[NullableContext(1)]
		public ShareTimesReviveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603ADEB RID: 241131 RVA: 0x00E08FE4 File Offset: 0x00E071E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickRevive));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickQuitBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603ADEC RID: 241132 RVA: 0x00E09110 File Offset: 0x00E07310
		private void OnClickRevive()
		{
			if (!this.CanRevive())
			{
				return;
			}
			DeadReviveController.Instance.TryReviveCurrentRoleByShare();
		}

		// Token: 0x0603ADED RID: 241133 RVA: 0x00E09128 File Offset: 0x00E07328
		private void OnClickQuitBtn()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.AbyssExit);
			Action value = delegate()
			{
				int id = InstanceDungeonEntranceModel.Instance.SelectInstanceId;
				if (GameModeController.Instance.IsInInstance())
				{
					id = CreatureModel.Instance.GetInstanceId();
				}
				InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(id);
				if (config != null && config.GetValueOrDefault().InstSubType == 33)
				{
					DangoAbyssController.Instance.RequestQuitChallenge();
					return;
				}
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
			};
			confirmBoxDataNew.FunctionMap[2] = value;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603ADEE RID: 241134 RVA: 0x00E0917C File Offset: 0x00E0737C
		protected override void OnStart()
		{
			UUIText text = base.GetText(2);
			LguiUtil instance = LguiUtil.Instance;
			UUIText uiText = text;
			DeadReviveModel instance2 = DeadReviveModel.Instance;
			instance.SetLocalTextNew(uiText, ((instance2.ReviveConfig != null) ? instance2.ReviveConfig.GetValueOrDefault().ReviveTitle : null) ?? "", Array.Empty<object>());
			SceneTeamItem getCurrentTeamItem = SceneTeamModel.Instance.GetCurrentTeamItem;
			if (getCurrentTeamItem != null)
			{
				ReviveCooldownData reviveCooldownData = null;
				DeadReviveModel.Instance.ReviveCooldownCreatureMap.TryGetValue(getCurrentTeamItem.GetCreatureDataId(), out reviveCooldownData);
				this.ReviveWaitSeconds = (float)(0.0010000000474974513 * ((reviveCooldownData != null) ? reviveCooldownData.RemainMilliseconds : 0.0));
			}
		}

		// Token: 0x0603ADEF RID: 241135 RVA: 0x00E0921A File Offset: 0x00E0741A
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnShareReviveTimesChange, new Action(this.RefreshReviveView));
			EventSystem.Instance.Add<long, float>(EEventName.OnRoleReviveCooldownChange, new Action<long, float>(this.OnRoleReviveCooldownChange));
		}

		// Token: 0x0603ADF0 RID: 241136 RVA: 0x00E09254 File Offset: 0x00E07454
		protected override void OnBeforeShow()
		{
			this.RefreshReviveView();
		}

		// Token: 0x0603ADF1 RID: 241137 RVA: 0x00E0925C File Offset: 0x00E0745C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnShareReviveTimesChange, new Action(this.RefreshReviveView));
			EventSystem.Instance.Remove(EEventName.OnRoleReviveCooldownChange, new Action<long, float>(this.OnRoleReviveCooldownChange));
		}

		// Token: 0x0603ADF2 RID: 241138 RVA: 0x00E09298 File Offset: 0x00E07498
		private void RefreshReviveView()
		{
			int currentShareReviveTimes = DeadReviveModel.Instance.CurrentShareReviveTimes;
			int maxShareReviveTimes = DeadReviveModel.Instance.MaxShareReviveTimes;
			this.ReviveTimes = currentShareReviveTimes;
			UUIText text = base.GetText(3);
			if (currentShareReviveTimes > 0)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "TuanZiAbyss_RE_NumRemainder", new <>z__ReadOnlyArray<object>(new object[]
				{
					currentShareReviveTimes,
					maxShareReviveTimes
				}));
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(text, "TuanZiAbyss_RE_NoNum", Array.Empty<object>());
			}
			UUIText text2 = base.GetText(4);
			bool flag = this.ReviveWaitSeconds > 0f;
			text2.SetUIActive(flag);
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(text2, "TuanZiAbyss_RE_ReTime", new <>z__ReadOnlySingleElementList<object>(this.ReviveWaitSeconds.ToString("F1")));
			}
			base.GetButton(0).GetRootComponent().SetUIActive(this.CanRevive());
		}

		// Token: 0x0603ADF3 RID: 241139 RVA: 0x00E09374 File Offset: 0x00E07574
		private void OnRoleReviveCooldownChange(long creatureDataId, float remainSeconds)
		{
			SceneTeamItem getCurrentTeamItem = SceneTeamModel.Instance.GetCurrentTeamItem;
			long? num = (getCurrentTeamItem != null) ? new long?(getCurrentTeamItem.GetCreatureDataId()) : null;
			if (!(creatureDataId == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			this.ReviveWaitSeconds = remainSeconds;
			this.RefreshReviveView();
		}

		// Token: 0x0603ADF4 RID: 241140 RVA: 0x00E093C7 File Offset: 0x00E075C7
		private bool CanRevive()
		{
			return this.ReviveTimes > 0 && this.ReviveWaitSeconds <= 0f;
		}

		// Token: 0x0401EB95 RID: 125845
		private float ReviveWaitSeconds;

		// Token: 0x0401EB96 RID: 125846
		private int ReviveTimes;

		// Token: 0x0200BD1E RID: 48414
		private class EShareTimesReviveViewComponent
		{
			// Token: 0x040390A4 RID: 233636
			public const int ReviveBtn = 0;

			// Token: 0x040390A5 RID: 233637
			public const int QuitButton = 1;

			// Token: 0x040390A6 RID: 233638
			public const int ReviveTitle = 2;

			// Token: 0x040390A7 RID: 233639
			public const int ReviveContent = 3;

			// Token: 0x040390A8 RID: 233640
			public const int ReviveWaitTime = 4;
		}
	}
}
