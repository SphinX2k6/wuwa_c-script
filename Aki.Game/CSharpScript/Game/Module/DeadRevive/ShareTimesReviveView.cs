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
	// Token: 0x02004AAE RID: 19118
	public class ShareTimesReviveView : UiViewBase
	{
		// Token: 0x0602FD5C RID: 195932 RVA: 0x00D59CBA File Offset: 0x00D57EBA
		[NullableContext(1)]
		public ShareTimesReviveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602FD5D RID: 195933 RVA: 0x00D59CC4 File Offset: 0x00D57EC4
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

		// Token: 0x0602FD5E RID: 195934 RVA: 0x00D59DF0 File Offset: 0x00D57FF0
		private void OnClickRevive()
		{
			if (!this.CanRevive())
			{
				return;
			}
			DeadReviveController.Instance.TryReviveCurrentRoleByShare();
		}

		// Token: 0x0602FD5F RID: 195935 RVA: 0x00D59E08 File Offset: 0x00D58008
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

		// Token: 0x0602FD60 RID: 195936 RVA: 0x00D59E5C File Offset: 0x00D5805C
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

		// Token: 0x0602FD61 RID: 195937 RVA: 0x00D59EFA File Offset: 0x00D580FA
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnShareReviveTimesChange, new Action(this.RefreshReviveView));
			EventSystem.Instance.Add<long, float>(EEventName.OnRoleReviveCooldownChange, new Action<long, float>(this.OnRoleReviveCooldownChange));
		}

		// Token: 0x0602FD62 RID: 195938 RVA: 0x00D59F34 File Offset: 0x00D58134
		protected override void OnBeforeShow()
		{
			this.RefreshReviveView();
		}

		// Token: 0x0602FD63 RID: 195939 RVA: 0x00D59F3C File Offset: 0x00D5813C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnShareReviveTimesChange, new Action(this.RefreshReviveView));
			EventSystem.Instance.Remove(EEventName.OnRoleReviveCooldownChange, new Action<long, float>(this.OnRoleReviveCooldownChange));
		}

		// Token: 0x0602FD64 RID: 195940 RVA: 0x00D59F78 File Offset: 0x00D58178
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

		// Token: 0x0602FD65 RID: 195941 RVA: 0x00D5A054 File Offset: 0x00D58254
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

		// Token: 0x0602FD66 RID: 195942 RVA: 0x00D5A0A7 File Offset: 0x00D582A7
		private bool CanRevive()
		{
			return this.ReviveTimes > 0 && this.ReviveWaitSeconds <= 0f;
		}

		// Token: 0x04019651 RID: 104017
		private float ReviveWaitSeconds;

		// Token: 0x04019652 RID: 104018
		private int ReviveTimes;

		// Token: 0x0200A726 RID: 42790
		private class EShareTimesReviveViewComponent
		{
			// Token: 0x04033A6E RID: 211566
			public const int ReviveBtn = 0;

			// Token: 0x04033A6F RID: 211567
			public const int QuitButton = 1;

			// Token: 0x04033A70 RID: 211568
			public const int ReviveTitle = 2;

			// Token: 0x04033A71 RID: 211569
			public const int ReviveContent = 3;

			// Token: 0x04033A72 RID: 211570
			public const int ReviveWaitTime = 4;
		}
	}
}
