using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage
{
	// Token: 0x0200644F RID: 25679
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityMotorLinkageSubView : ActivitySubViewBase
	{
		// Token: 0x17009484 RID: 38020
		// (get) Token: 0x060408A3 RID: 264355 RVA: 0x00F9F447 File Offset: 0x00F9D647
		[Nullable(2)]
		private ActivityMotorLinkageData MotorData
		{
			[NullableContext(2)]
			get
			{
				return this.ActivityBaseData as ActivityMotorLinkageData;
			}
		}

		// Token: 0x060408A4 RID: 264356 RVA: 0x00F9F454 File Offset: 0x00F9D654
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
		}

		// Token: 0x060408A5 RID: 264357 RVA: 0x00F9F51C File Offset: 0x00F9D71C
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityMotorLinkageSubView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityMotorLinkageSubView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060408A6 RID: 264358 RVA: 0x00F9F55F File Offset: 0x00F9D75F
		protected override void OnStart()
		{
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel != null)
			{
				commonInfoPanel.SetBtnText("MotorLinkage_Go", Array.Empty<object>());
			}
			ActivityMotorLinkageData motorData = this.MotorData;
			if (motorData == null)
			{
				return;
			}
			motorData.ReadRedDot();
		}

		// Token: 0x060408A7 RID: 264359 RVA: 0x00F9F58C File Offset: 0x00F9D78C
		protected override void OnRefreshView()
		{
			foreach (MotorLinkageButton motorLinkageButton in this.ButtonList)
			{
				motorLinkageButton.Refresh();
			}
			this.RefreshProgress();
			this.RefreshRedDot();
			this.RefreshTab();
		}

		// Token: 0x060408A8 RID: 264360 RVA: 0x00F9F5F0 File Offset: 0x00F9D7F0
		protected override void OnBeforeDestroy()
		{
			this.CancelResetTimerHandle();
		}

		// Token: 0x060408A9 RID: 264361 RVA: 0x00F9F5F8 File Offset: 0x00F9D7F8
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x060408AA RID: 264362 RVA: 0x00F9F616 File Offset: 0x00F9D816
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x060408AB RID: 264363 RVA: 0x00F9F634 File Offset: 0x00F9D834
		private void OnRedDotRefresh(int activityId)
		{
			ActivityMotorLinkageData motorData = this.MotorData;
			int? num = (motorData != null) ? new int?(motorData.Id) : null;
			if (!(activityId == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			this.OnRefreshView();
		}

		// Token: 0x060408AC RID: 264364 RVA: 0x00F9F67C File Offset: 0x00F9D87C
		private void RefreshTab()
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.MotorData.Id);
		}

		// Token: 0x060408AD RID: 264365 RVA: 0x00F9F69C File Offset: 0x00F9D89C
		public override void PlaySubViewSequence(string name, bool blockClick = false)
		{
			string name2 = name;
			if (name == "ShowView")
			{
				ActivityMotorLinkageData motorData = this.MotorData;
				if (motorData != null && motorData.CanSubViewPlayShowView())
				{
					name2 = "ShowView02";
				}
				else
				{
					name2 = "ShowView01";
				}
			}
			base.PlaySubViewSequence(name2, blockClick);
		}

		// Token: 0x060408AE RID: 264366 RVA: 0x00F9F6E4 File Offset: 0x00F9D8E4
		private void RefreshProgress()
		{
			int allIpCurrentProgress = this.MotorData.GetAllIpCurrentProgress();
			int allIpTotalProgress = this.MotorData.GetAllIpTotalProgress();
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(allIpCurrentProgress.ToString() + "/" + allIpTotalProgress.ToString(), true);
		}

		// Token: 0x060408AF RID: 264367 RVA: 0x00F9F734 File Offset: 0x00F9D934
		private void RefreshRedDot()
		{
			bool flag = this.MotorData.HasAnyRewardCanReceive();
			bool flag2 = this.MotorData.HasSkipRedDot();
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel == null)
			{
				return;
			}
			commonInfoPanel.SetFunctionRedDotVisible(flag2 || flag);
		}

		// Token: 0x060408B0 RID: 264368 RVA: 0x00F9F76C File Offset: 0x00F9D96C
		private UniTask CreateButtonList()
		{
			ActivityMotorLinkageSubView.<CreateButtonList>d__22 <CreateButtonList>d__;
			<CreateButtonList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButtonList>d__.<>4__this = this;
			<CreateButtonList>d__.<>1__state = -1;
			<CreateButtonList>d__.<>t__builder.Start<ActivityMotorLinkageSubView.<CreateButtonList>d__22>(ref <CreateButtonList>d__);
			return <CreateButtonList>d__.<>t__builder.Task;
		}

		// Token: 0x060408B1 RID: 264369 RVA: 0x00F9F7AF File Offset: 0x00F9D9AF
		private void OnClickDetail()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				EventSystem.Instance.Emit<bool, EActivityViewState, bool?>(EEventName.SetActivityViewState, false, EActivityViewState.Side, null);
				ActivityMotorLinkageData motorData = this.MotorData;
				if (motorData == null)
				{
					return;
				}
				motorData.ReadSkipRedDot();
			});
		}

		// Token: 0x060408B2 RID: 264370 RVA: 0x00F9F7CD File Offset: 0x00F9D9CD
		private void OnButtonClick(int ipId)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorLinkageRewardView, ipId, null);
			this.CancelTimerAndResetState();
			ActivityMotorLinkageData motorData = this.MotorData;
			if (motorData == null)
			{
				return;
			}
			motorData.SetCanSubViewPlayShowView(true);
		}

		// Token: 0x060408B3 RID: 264371 RVA: 0x00F9F7FC File Offset: 0x00F9D9FC
		public override void OnCommonViewStateChange(bool show)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopPlayingSequence(false, true);
			}
			string sequenceName = show ? "ShowView01" : "HideView01";
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlaySequencePurely(sequenceName, true, false, null, null, false);
			}
			if (show)
			{
				this.CancelTimerAndResetState();
			}
		}

		// Token: 0x060408B4 RID: 264372 RVA: 0x00F9F854 File Offset: 0x00F9DA54
		private void OnButtonEnter(int ipId)
		{
			int num = this.IpToIndex(ipId);
			if (this.PlayerStateList == null)
			{
				this.PlayerStateList = new bool[this.roleAnimNameDefine.Length];
				for (int i = 0; i < this.PlayerStateList.Length; i++)
				{
					this.PlayerStateList[i] = true;
				}
			}
			this.CancelResetTimerHandle();
			bool flag = true;
			bool[] playerStateList = this.PlayerStateList;
			for (int j = 0; j < playerStateList.Length; j++)
			{
				if (!playerStateList[j])
				{
					flag = false;
					break;
				}
			}
			for (int k = 0; k < this.roleAnimNameDefine.Length; k++)
			{
				string[] array = this.roleAnimNameDefine[k];
				bool flag2 = num == k;
				if (flag2)
				{
					UUIItem item = base.GetItem(this.fxDefineList[k]);
					if (item != null)
					{
						item.SetUIActive(true);
					}
					UUIItem item2 = base.GetItem(this.fxDefineList[k]);
					if (item2 != null)
					{
						item2.SetAlpha(1f);
					}
				}
				if (this.PlayerStateList[k] != flag2 || flag)
				{
					this.PlayerStateList[k] = flag2;
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer != null)
					{
						levelSequencePlayer.StopSequenceByKey(array[(!flag2) ? 1 : 0], false, false);
					}
					LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
					if (levelSequencePlayer2 != null)
					{
						levelSequencePlayer2.PlaySequencePurely(array[(flag2 > false) ? 1 : 0], false, false, null, null, false);
					}
				}
			}
		}

		// Token: 0x060408B5 RID: 264373 RVA: 0x00F9F995 File Offset: 0x00F9DB95
		private void OnButtonExit()
		{
			this.CancelResetTimerHandle();
			this.StartResetTimerHandle();
		}

		// Token: 0x060408B6 RID: 264374 RVA: 0x00F9F9A3 File Offset: 0x00F9DBA3
		private void CancelTimerAndResetState()
		{
			this.CancelResetTimerHandle();
			this.ResetState();
		}

		// Token: 0x060408B7 RID: 264375 RVA: 0x00F9F9B4 File Offset: 0x00F9DBB4
		private void ResetState()
		{
			if (this.PlayerStateList == null)
			{
				return;
			}
			for (int i = 0; i < this.roleAnimNameDefine.Length; i++)
			{
				string[] array = this.roleAnimNameDefine[i];
				int name = this.fxDefineList[i];
				UUIItem item = base.GetItem(name);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				if (!this.PlayerStateList[i])
				{
					this.PlayerStateList[i] = true;
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer != null)
					{
						levelSequencePlayer.StopSequenceByKey(array[0], false, false);
					}
					LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
					if (levelSequencePlayer2 != null)
					{
						levelSequencePlayer2.PlaySequencePurely(array[1], false, false, null, null, false);
					}
				}
			}
		}

		// Token: 0x060408B8 RID: 264376 RVA: 0x00F9FA4C File Offset: 0x00F9DC4C
		private void CancelResetTimerHandle()
		{
			if (this.ResetStateHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ResetStateHandle);
				this.ResetStateHandle = null;
			}
		}

		// Token: 0x060408B9 RID: 264377 RVA: 0x00F9FA6E File Offset: 0x00F9DC6E
		private void StartResetTimerHandle()
		{
			this.ResetStateHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.ResetState();
				this.ResetStateHandle = null;
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x060408BA RID: 264378 RVA: 0x00F9FA9C File Offset: 0x00F9DC9C
		private int IpToIndex(int ipId)
		{
			return ActivityMotorLinkageController.Instance.ActivityData.GetSortedIpList().FindIndex((int id) => id == ipId);
		}

		// Token: 0x04021905 RID: 137477
		private string[][] roleAnimNameDefine = new string[][]
		{
			new string[]
			{
				"RoleLDark",
				"RoleLBright"
			},
			new string[]
			{
				"RoleMDark",
				"RoleMBright"
			},
			new string[]
			{
				"RoleRDark",
				"RoleRBright"
			}
		};

		// Token: 0x04021906 RID: 137478
		private int[] fxDefineList = new int[]
		{
			6,
			7,
			5
		};

		// Token: 0x04021907 RID: 137479
		private int[] buttonDefineList = new int[]
		{
			2,
			3,
			4
		};

		// Token: 0x04021908 RID: 137480
		private const int RESET_TIME_MS = 2000;

		// Token: 0x04021909 RID: 137481
		[Nullable(2)]
		private ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0402190A RID: 137482
		private readonly List<MotorLinkageButton> ButtonList = new List<MotorLinkageButton>();

		// Token: 0x0402190B RID: 137483
		[Nullable(2)]
		private bool[] PlayerStateList;

		// Token: 0x0402190C RID: 137484
		[Nullable(2)]
		private TimerHandle ResetStateHandle;
	}
}
