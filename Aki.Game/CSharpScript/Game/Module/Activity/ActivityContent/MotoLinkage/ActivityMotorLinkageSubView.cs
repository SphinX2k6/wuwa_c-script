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
	// Token: 0x020053CD RID: 21453
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityMotorLinkageSubView : ActivitySubViewBase
	{
		// Token: 0x170067E6 RID: 26598
		// (get) Token: 0x06035564 RID: 218468 RVA: 0x00EE63C3 File Offset: 0x00EE45C3
		[Nullable(2)]
		private ActivityMotorLinkageData MotorData
		{
			[NullableContext(2)]
			get
			{
				return this.ActivityBaseData as ActivityMotorLinkageData;
			}
		}

		// Token: 0x06035565 RID: 218469 RVA: 0x00EE63D0 File Offset: 0x00EE45D0
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

		// Token: 0x06035566 RID: 218470 RVA: 0x00EE6498 File Offset: 0x00EE4698
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityMotorLinkageSubView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityMotorLinkageSubView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035567 RID: 218471 RVA: 0x00EE64DB File Offset: 0x00EE46DB
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

		// Token: 0x06035568 RID: 218472 RVA: 0x00EE6508 File Offset: 0x00EE4708
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

		// Token: 0x06035569 RID: 218473 RVA: 0x00EE656C File Offset: 0x00EE476C
		protected override void OnBeforeDestroy()
		{
			this.CancelResetTimerHandle();
		}

		// Token: 0x0603556A RID: 218474 RVA: 0x00EE6574 File Offset: 0x00EE4774
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x0603556B RID: 218475 RVA: 0x00EE6592 File Offset: 0x00EE4792
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x0603556C RID: 218476 RVA: 0x00EE65B0 File Offset: 0x00EE47B0
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

		// Token: 0x0603556D RID: 218477 RVA: 0x00EE65F8 File Offset: 0x00EE47F8
		private void RefreshTab()
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.MotorData.Id);
		}

		// Token: 0x0603556E RID: 218478 RVA: 0x00EE6618 File Offset: 0x00EE4818
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

		// Token: 0x0603556F RID: 218479 RVA: 0x00EE6660 File Offset: 0x00EE4860
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

		// Token: 0x06035570 RID: 218480 RVA: 0x00EE66B0 File Offset: 0x00EE48B0
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

		// Token: 0x06035571 RID: 218481 RVA: 0x00EE66E8 File Offset: 0x00EE48E8
		private UniTask CreateButtonList()
		{
			ActivityMotorLinkageSubView.<CreateButtonList>d__22 <CreateButtonList>d__;
			<CreateButtonList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButtonList>d__.<>4__this = this;
			<CreateButtonList>d__.<>1__state = -1;
			<CreateButtonList>d__.<>t__builder.Start<ActivityMotorLinkageSubView.<CreateButtonList>d__22>(ref <CreateButtonList>d__);
			return <CreateButtonList>d__.<>t__builder.Task;
		}

		// Token: 0x06035572 RID: 218482 RVA: 0x00EE672B File Offset: 0x00EE492B
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

		// Token: 0x06035573 RID: 218483 RVA: 0x00EE6749 File Offset: 0x00EE4949
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

		// Token: 0x06035574 RID: 218484 RVA: 0x00EE6778 File Offset: 0x00EE4978
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

		// Token: 0x06035575 RID: 218485 RVA: 0x00EE67D0 File Offset: 0x00EE49D0
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

		// Token: 0x06035576 RID: 218486 RVA: 0x00EE6911 File Offset: 0x00EE4B11
		private void OnButtonExit()
		{
			this.CancelResetTimerHandle();
			this.StartResetTimerHandle();
		}

		// Token: 0x06035577 RID: 218487 RVA: 0x00EE691F File Offset: 0x00EE4B1F
		private void CancelTimerAndResetState()
		{
			this.CancelResetTimerHandle();
			this.ResetState();
		}

		// Token: 0x06035578 RID: 218488 RVA: 0x00EE6930 File Offset: 0x00EE4B30
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

		// Token: 0x06035579 RID: 218489 RVA: 0x00EE69C8 File Offset: 0x00EE4BC8
		private void CancelResetTimerHandle()
		{
			if (this.ResetStateHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ResetStateHandle);
				this.ResetStateHandle = null;
			}
		}

		// Token: 0x0603557A RID: 218490 RVA: 0x00EE69EA File Offset: 0x00EE4BEA
		private void StartResetTimerHandle()
		{
			this.ResetStateHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.ResetState();
				this.ResetStateHandle = null;
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x0603557B RID: 218491 RVA: 0x00EE6A18 File Offset: 0x00EE4C18
		private int IpToIndex(int ipId)
		{
			return ActivityMotorLinkageController.Instance.ActivityData.GetSortedIpList().FindIndex((int id) => id == ipId);
		}

		// Token: 0x0401C234 RID: 115252
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

		// Token: 0x0401C235 RID: 115253
		private int[] fxDefineList = new int[]
		{
			6,
			7,
			5
		};

		// Token: 0x0401C236 RID: 115254
		private int[] buttonDefineList = new int[]
		{
			2,
			3,
			4
		};

		// Token: 0x0401C237 RID: 115255
		private const int RESET_TIME_MS = 2000;

		// Token: 0x0401C238 RID: 115256
		[Nullable(2)]
		private ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0401C239 RID: 115257
		private readonly List<MotorLinkageButton> ButtonList = new List<MotorLinkageButton>();

		// Token: 0x0401C23A RID: 115258
		[Nullable(2)]
		private bool[] PlayerStateList;

		// Token: 0x0401C23B RID: 115259
		[Nullable(2)]
		private TimerHandle ResetStateHandle;
	}
}
