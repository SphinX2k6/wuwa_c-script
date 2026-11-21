using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Component;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack.View
{
	// Token: 0x02003F5F RID: 16223
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class QuickHackViewBase : UiTickViewBase, IUiProhibitRefreshData
	{
		// Token: 0x06029126 RID: 168230 RVA: 0x00B88FF8 File Offset: 0x00B871F8
		public QuickHackViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06029127 RID: 168231 RVA: 0x00B89008 File Offset: 0x00B87208
		protected override UniTask OnBeforeStartAsync()
		{
			QuickHackViewBase.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuickHackViewBase.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029128 RID: 168232 RVA: 0x00B8904C File Offset: 0x00B8724C
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(this.GetUiComponentType(EQuickHackUiType.SkillPanelLayout));
			this.SkillPanelAnim = (verticalLayout.GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController);
		}

		// Token: 0x06029129 RID: 168233 RVA: 0x00B890B4 File Offset: 0x00B872B4
		protected override void OnBeforeShow()
		{
			QuickHackModel instance = QuickHackModel.Instance;
			QuickHackRamManager ramManager = instance.RamManager;
			if (ramManager == null)
			{
				return;
			}
			double durationLimitTotalTime = instance.DurationLimitTotalTime;
			bool flag = durationLimitTotalTime > 0.0;
			base.GetItem(this.GetUiComponentType(EQuickHackUiType.DurationLimitItem)).SetUIActive(flag);
			if (flag)
			{
				this.UpdateDurationLimit(instance.DurationLimitRemainTime, durationLimitTotalTime);
			}
			int currentRam = (int)Math.Floor((double)ramManager.GetCurrentRam());
			int maxRam = (int)Math.Floor((double)ramManager.GetMaxRam());
			this.RefreshRam(currentRam, maxRam, false);
			this.UpdateInfoLine();
			QuickHackController.Instance.UpdateLockTarget(0f);
			this.UpdateSkillInfo(true, true);
			this.UpdateLockTarget();
			this.UpdateKeyItem();
			EventSystem.Instance.Add<bool>(EEventName.OnShowMouseCursor, new Action<bool>(this.OnShowMouseCursor));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Add(EEventName.OnQuickHackAllSkillChange, new Action(this.OnAllSkillChange));
			EventSystem.Instance.Add(EEventName.OnQuickHackSelectSkillChange, new Action(this.OnSelectSkillChange));
			EventSystem.Instance.Add<double, double>(EEventName.OnQuickHackDurationLimitChange, new Action<double, double>(this.UpdateDurationLimit));
			EventSystem.Instance.Add(EEventName.OnQuickHackCurrentRamChange, new Action(this.OnCurrentRamChange));
			EventSystem.Instance.Add(EEventName.OnQuickHackMaxRamChange, new Action(this.OnMxRamChange));
			UiProhibitFightInputCenter.Instance.RegisterExtraRefreshData(this.ViewInfo.Name, this);
			InputDistributeController.Instance.RefreshInputTag();
			this.RefreshInput(true);
		}

		// Token: 0x0602912A RID: 168234 RVA: 0x00B8924C File Offset: 0x00B8744C
		protected override void OnBeforeHide()
		{
			QuickHackSkillInstance currentSkill = this.CurrentSkill;
			if (currentSkill != null)
			{
				currentSkill.UnRegisterOnCheckSkillCanUse(new Action<QuickHackSkillConditionResult>(this.OnCheckCurrentSkillCanUse));
			}
			this.CurrentSkill = null;
			EventSystem.Instance.Remove(EEventName.OnShowMouseCursor, new Action<bool>(this.OnShowMouseCursor));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Remove(EEventName.OnQuickHackAllSkillChange, new Action(this.OnAllSkillChange));
			EventSystem.Instance.Remove(EEventName.OnQuickHackSelectSkillChange, new Action(this.OnSelectSkillChange));
			EventSystem.Instance.Remove(EEventName.OnQuickHackDurationLimitChange, new Action<double, double>(this.UpdateDurationLimit));
			EventSystem.Instance.Remove(EEventName.OnQuickHackCurrentRamChange, new Action(this.OnCurrentRamChange));
			EventSystem.Instance.Remove(EEventName.OnQuickHackMaxRamChange, new Action(this.OnMxRamChange));
			UiProhibitFightInputCenter.Instance.UnRegisterExtraRefreshData(this.ViewInfo.Name);
			InputDistributeController.Instance.RefreshInputTag();
			this.RefreshInput(false);
		}

		// Token: 0x0602912B RID: 168235 RVA: 0x00B8936C File Offset: 0x00B8756C
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.UpdateKeyItem();
		}

		// Token: 0x0602912C RID: 168236 RVA: 0x00B89374 File Offset: 0x00B87574
		private void UpdateDurationLimit(double remainTime, double totalTime)
		{
			double num = MathUtils.Instance.Clamp(remainTime, 0.0, totalTime);
			double num2 = num / totalTime;
			double num3 = MathUtils.Instance.Clamp(num * 0.0010000000474974513, 0.0, TimeUtil.Instance.Minute);
			int num4 = (int)Math.Floor(num3);
			int num5 = (int)Math.Floor((num3 - (double)num4) * 100.0);
			string text = num4.ToString().PadLeft(2, '0');
			string text2 = num5.ToString().PadLeft(2, '0');
			base.GetSprite(this.GetUiComponentType(EQuickHackUiType.DurationLimitBarSprite)).SetFillAmount((float)num2);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(this.GetUiComponentType(EQuickHackUiType.DurationLimitText)), "QuickHack_Desc_2", new <>z__ReadOnlyArray<object>(new object[]
			{
				text,
				text2
			}));
		}

		// Token: 0x0602912D RID: 168237 RVA: 0x00B89448 File Offset: 0x00B87648
		protected virtual bool UseCurrentSkill()
		{
			QuickHackModel instance = QuickHackModel.Instance;
			List<QuickHackSkillInstance> currentSkillList = instance.CurrentSkillList;
			QuickHackSkillInstance currentSelectSkill = instance.CurrentSelectSkill;
			if (currentSelectSkill == null || currentSkillList == null)
			{
				return false;
			}
			int num = currentSkillList.IndexOf(currentSelectSkill);
			if (num < 0)
			{
				return false;
			}
			if (!currentSelectSkill.GetSkillCanUseInfo().IsSuccess)
			{
				QuickHackSkillPanel skillPanel = this.SkillPanel;
				if (skillPanel != null)
				{
					QuickHackSkillItem item = skillPanel.GetItem(num);
					if (item != null)
					{
						item.PlayDisableSequence();
					}
				}
				return false;
			}
			if (QuickHackController.Instance.UseCurrentSkill())
			{
				QuickHackSkillPanel skillPanel2 = this.SkillPanel;
				if (skillPanel2 != null)
				{
					QuickHackSkillItem item2 = skillPanel2.GetItem(num);
					if (item2 != null)
					{
						item2.PlayUseSkillSequence();
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x0602912E RID: 168238
		protected abstract void RefreshInput(bool enable);

		// Token: 0x0602912F RID: 168239
		protected abstract int GetUiComponentType(EQuickHackUiType uiType);

		// Token: 0x06029130 RID: 168240
		protected abstract List<UUIItem> GetSkillItems();

		// Token: 0x06029131 RID: 168241 RVA: 0x00B894D5 File Offset: 0x00B876D5
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			QuickHackRamBar ramBar = this.RamBar;
			if (ramBar != null)
			{
				ramBar.Clear();
			}
			this.RamBar = null;
			this.SkillPanel = null;
			this.SkillPanelAnim = null;
		}

		// Token: 0x06029132 RID: 168242 RVA: 0x00B89515 File Offset: 0x00B87715
		protected override void OnTick(float delta)
		{
			QuickHackController.Instance.UpdateLockTarget(delta);
			this.UpdateLockTarget();
			this.UpdateUploadTime();
			QuickHackRamBar ramBar = this.RamBar;
			if (ramBar == null)
			{
				return;
			}
			ramBar.TickRamBar(delta);
		}

		// Token: 0x06029133 RID: 168243 RVA: 0x00B89540 File Offset: 0x00B87740
		private void OnCurrentRamChange()
		{
			QuickHackRamManager ramManager = QuickHackModel.Instance.RamManager;
			int currentRam = (int)Math.Floor((double)((ramManager != null) ? ramManager.GetCurrentRam() : 0f));
			int maxRam = (int)Math.Floor((double)((ramManager != null) ? ramManager.GetMaxRam() : 0f));
			this.RefreshRam(currentRam, maxRam, true);
		}

		// Token: 0x06029134 RID: 168244 RVA: 0x00B89594 File Offset: 0x00B87794
		private void OnMxRamChange()
		{
			QuickHackRamManager ramManager = QuickHackModel.Instance.RamManager;
			int currentRam = (int)Math.Floor((double)((ramManager != null) ? ramManager.GetCurrentRam() : 0f));
			int maxRam = (int)Math.Floor((double)((ramManager != null) ? ramManager.GetMaxRam() : 0f));
			this.RefreshRam(currentRam, maxRam, false);
		}

		// Token: 0x06029135 RID: 168245 RVA: 0x00B895E8 File Offset: 0x00B877E8
		private void RefreshRam(int currentRam, int maxRam, bool playReduceAnim = false)
		{
			QuickHackRamBar ramBar = this.RamBar;
			if (ramBar != null)
			{
				ramBar.RefreshRam(currentRam, maxRam, playReduceAnim);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(this.GetUiComponentType(EQuickHackUiType.RamTitleText)), "QuickHack_Desc_1", new <>z__ReadOnlyArray<object>(new object[]
			{
				currentRam,
				maxRam
			}));
		}

		// Token: 0x06029136 RID: 168246 RVA: 0x00B89644 File Offset: 0x00B87844
		private void UpdateLockTarget()
		{
			EntityHandle closestOnScreenTarget = QuickHackController.Instance.GetClosestOnScreenTarget();
			bool flag = closestOnScreenTarget != null;
			if (flag != this.HasTarget)
			{
				this.HasTarget = flag;
				if (flag)
				{
					this.SequencePlayer.StopSequenceByKey("CheckOut", false, false);
					this.SequencePlayer.PlaySequencePurely("CheckIn", false, false);
				}
				else
				{
					this.SequencePlayer.StopSequenceByKey("CheckIn", false, false);
					this.SequencePlayer.PlaySequencePurely("CheckOut", false, false);
				}
			}
			if (this.TargetItem == null)
			{
				return;
			}
			if (!this.ShouldShowTargetItem() || !flag)
			{
				this.TargetItemEntityId = 0;
				this.TargetItem.SetActive(false);
				return;
			}
			int id = closestOnScreenTarget.Id;
			if (id == this.TargetItemEntityId)
			{
				return;
			}
			this.TargetItemEntityId = id;
			CreatureDataComponent component = closestOnScreenTarget.Entity.GetComponent<CreatureDataComponent>();
			string entityTidName = component.GetEntityTidName();
			if (entityTidName == null)
			{
				this.TargetItem.SetActive(false);
				return;
			}
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(entityTidName);
			if (StringUtils.IsBlank(configTextByKey))
			{
				this.TargetItem.SetActive(false);
				return;
			}
			MonsterComponent monsterComponent = component.GetMonsterComponent();
			string text;
			if (monsterComponent == null)
			{
				text = null;
			}
			else
			{
				IBossStateViewConfig bossViewConfig = monsterComponent.BossViewConfig;
				text = ((bossViewConfig != null) ? bossViewConfig.TidBossSubTitle : null);
			}
			string text2 = text;
			string title = (text2 != null) ? (configTextByKey + PublicUtil.Instance.GetConfigTextByKey(text2)) : configTextByKey;
			this.TargetItem.SetActive(true);
			this.TargetItem.RefreshTitle(title);
		}

		// Token: 0x06029137 RID: 168247 RVA: 0x00B8979D File Offset: 0x00B8799D
		protected virtual bool ShouldShowTargetItem()
		{
			return true;
		}

		// Token: 0x06029138 RID: 168248 RVA: 0x00B897A0 File Offset: 0x00B879A0
		private void UpdateUploadTime()
		{
			int uploadTime = this.GetUploadTime();
			if (uploadTime == this.CurrentUploadTime)
			{
				return;
			}
			this.CurrentUploadTime = uploadTime;
			bool flag = uploadTime > 0;
			if (this.HasUploadTimeInfo != flag)
			{
				this.HasUploadTimeInfo = flag;
				this.UpdateInfoLine();
			}
			UUIText text = base.GetText(this.GetUiComponentType(EQuickHackUiType.InfoUploadText));
			text.SetUIActive(flag);
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "QuickHack_SkillMessage_2", new <>z__ReadOnlySingleElementList<object>(((float)uploadTime * 0.001f).ToString("F1")));
			}
		}

		// Token: 0x06029139 RID: 168249 RVA: 0x00B89824 File Offset: 0x00B87A24
		private int GetUploadTime()
		{
			QuickHackTargetSelector targetSelector = QuickHackModel.Instance.TargetSelector;
			IQuickHackLockTargetInfo quickHackLockTargetInfo = (targetSelector != null) ? targetSelector.GetLockTargetInfo() : null;
			if (quickHackLockTargetInfo == null || quickHackLockTargetInfo.HackType == null)
			{
				return 0;
			}
			using (IEnumerator<EntityHandle> enumerator = quickHackLockTargetInfo.Targets.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					WorldEntity entity = enumerator.Current.Entity;
					int? num;
					if (entity == null)
					{
						num = null;
					}
					else
					{
						SceneItemQuickHackComponent component = entity.GetComponent<SceneItemQuickHackComponent>();
						num = ((component != null) ? new int?(component.GetUploadTime()) : null);
					}
					int? num2 = num;
					return num2.GetValueOrDefault();
				}
			}
			return 0;
		}

		// Token: 0x0602913A RID: 168250 RVA: 0x00B898D8 File Offset: 0x00B87AD8
		private void OnAllSkillChange()
		{
			this.UpdateSkillInfo(true, false);
		}

		// Token: 0x0602913B RID: 168251 RVA: 0x00B898E2 File Offset: 0x00B87AE2
		private void OnSelectSkillChange()
		{
			this.UpdateSkillInfo(false, false);
		}

		// Token: 0x0602913C RID: 168252 RVA: 0x00B898EC File Offset: 0x00B87AEC
		private void UpdateSkillInfo(bool allSkillChange, bool isInit = false)
		{
			this.RefreshSelectRam();
			QuickHackModel instance = QuickHackModel.Instance;
			List<QuickHackSkillInstance> currentSkillList = instance.CurrentSkillList;
			QuickHackSkillInstance currentSelectSkill = instance.CurrentSelectSkill;
			if (this.SkillPanel == null || currentSkillList == null || (currentSkillList != null && currentSkillList.Count == 0) || currentSelectSkill == null)
			{
				QuickHackSkillInstance currentSkill = this.CurrentSkill;
				if (currentSkill != null)
				{
					currentSkill.UnRegisterOnCheckSkillCanUse(new Action<QuickHackSkillConditionResult>(this.OnCheckCurrentSkillCanUse));
				}
				this.CurrentSkill = null;
				this.RefreshSkillPanelVisible(false, isInit);
				return;
			}
			if (allSkillChange)
			{
				this.SkillPanel.RefreshByData(currentSkillList);
				this.RefreshSkillPanelVisible(true, isInit);
			}
			QuickHackSkillInstance currentSkill2 = this.CurrentSkill;
			if (currentSkill2 != null)
			{
				currentSkill2.UnRegisterOnCheckSkillCanUse(new Action<QuickHackSkillConditionResult>(this.OnCheckCurrentSkillCanUse));
			}
			this.CurrentSkill = currentSelectSkill;
			this.UpdateCurrentSkillCanUse(currentSelectSkill.GetSkillCanUseInfo());
			currentSelectSkill.RegisterOnCheckSkillCanUse(new Action<QuickHackSkillConditionResult>(this.OnCheckCurrentSkillCanUse));
			int num = currentSkillList.IndexOf(currentSelectSkill);
			if (num >= 0)
			{
				this.SkillPanel.Select(num);
			}
			QuickHackSkill config = currentSelectSkill.GetConfig();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(this.GetUiComponentType(EQuickHackUiType.InfoTitleText)), config.SkillName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(this.GetUiComponentType(EQuickHackUiType.InfoTagText)), config.SkillTag, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(this.GetUiComponentType(EQuickHackUiType.InfoDescText)), config.SkillDescribe, Array.Empty<object>());
			int duration = config.Duration;
			bool flag = duration > 0;
			if (this.HasDurationInfo != flag)
			{
				this.HasDurationInfo = flag;
				this.UpdateInfoLine();
			}
			UUIText text = base.GetText(this.GetUiComponentType(EQuickHackUiType.InfoDurationText));
			text.SetUIActive(flag);
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "QuickHack_SkillMessage_1", new <>z__ReadOnlySingleElementList<object>(((float)duration * 0.001f).ToString("F1")));
			}
		}

		// Token: 0x0602913D RID: 168253 RVA: 0x00B89AA9 File Offset: 0x00B87CA9
		private void UpdateInfoLine()
		{
			if (this.HasUploadTimeInfo || this.HasDurationInfo)
			{
				base.GetItem(this.GetUiComponentType(EQuickHackUiType.InfoLineItem)).SetUIActive(true);
				return;
			}
			base.GetItem(this.GetUiComponentType(EQuickHackUiType.InfoLineItem)).SetUIActive(false);
		}

		// Token: 0x0602913E RID: 168254 RVA: 0x00B89AE4 File Offset: 0x00B87CE4
		private void RefreshSkillPanelVisible(bool visible, bool isInit = false)
		{
			if (!isInit && visible == this.SkillPanelVisible && !visible)
			{
				return;
			}
			this.SkillPanelVisible = visible;
			if (visible)
			{
				this.SequencePlayer.StopSequenceByKey("Close01", false, true);
				this.SequencePlayer.StopSequenceByKey("Start02", false, true);
				this.SequencePlayer.PlaySequencePurely("Start02", false, false);
				return;
			}
			this.SequencePlayer.StopSequenceByKey("Start02", false, false);
			this.SequencePlayer.PlaySequencePurely("Close01", false, false);
			if (isInit)
			{
				this.SequencePlayer.StopSequenceByKey("Close01", false, true);
			}
		}

		// Token: 0x0602913F RID: 168255
		protected abstract string GetSelectSkillAudioPath();

		// Token: 0x06029140 RID: 168256 RVA: 0x00B89B7B File Offset: 0x00B87D7B
		public bool CheckCondition()
		{
			return !InputManager.Instance.IsShowMouseCursor() || !Info.Instance.IsInKeyBoard();
		}

		// Token: 0x06029141 RID: 168257 RVA: 0x00B89B98 File Offset: 0x00B87D98
		public string[] GetDistributeTags()
		{
			return this.GetInputDistributeTags();
		}

		// Token: 0x06029142 RID: 168258 RVA: 0x00B89BA0 File Offset: 0x00B87DA0
		protected virtual string[] GetInputDistributeTags()
		{
			return new string[]
			{
				"FightInputRoot.FightInput.AxisInput.CameraInput.CameraRotation",
				"UiInputRoot.MouseInputTag",
				"UiInputRoot.Navigation"
			};
		}

		// Token: 0x06029143 RID: 168259 RVA: 0x00B89BC0 File Offset: 0x00B87DC0
		private void OnCheckCurrentSkillCanUse(QuickHackSkillConditionResult canUseInfo)
		{
			this.UpdateCurrentSkillCanUse(canUseInfo);
			this.RefreshSelectRam();
		}

		// Token: 0x06029144 RID: 168260 RVA: 0x00B89BD0 File Offset: 0x00B87DD0
		private void UpdateCurrentSkillCanUse(QuickHackSkillConditionResult canUseInfo)
		{
			bool isSuccess = canUseInfo.IsSuccess;
			bool flag = !isSuccess;
			base.GetItem(this.GetUiComponentType(EQuickHackUiType.TipItem)).SetUIActive(flag);
			if (flag)
			{
				string failTextIdByCondition = QuickHackUtil.GetFailTextIdByCondition(canUseInfo.FailConditionType);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(this.GetUiComponentType(EQuickHackUiType.TipText)), failTextIdByCondition, Array.Empty<object>());
			}
			this.OnUpdateCurrentSkillCanUse(isSuccess);
		}

		// Token: 0x06029145 RID: 168261 RVA: 0x00B89C2F File Offset: 0x00B87E2F
		protected virtual void OnUpdateCurrentSkillCanUse(bool canUse)
		{
		}

		// Token: 0x06029146 RID: 168262 RVA: 0x00B89C34 File Offset: 0x00B87E34
		private void RefreshSelectRam()
		{
			if (this.RamBar == null)
			{
				return;
			}
			QuickHackSkillInstance currentSelectSkill = QuickHackModel.Instance.CurrentSelectSkill;
			if (currentSelectSkill == null)
			{
				this.RamBar.SelectRam(0);
				return;
			}
			QuickHackSkillConditionResult skillCanUseInfo = currentSelectSkill.GetSkillCanUseInfo();
			this.RamBar.SelectRam(skillCanUseInfo.IsSuccess ? currentSelectSkill.GetConfig().RamCost : 0);
		}

		// Token: 0x06029147 RID: 168263 RVA: 0x00B89C90 File Offset: 0x00B87E90
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			UUIInturnAnimController skillPanelAnim = this.SkillPanelAnim;
			if (skillPanelAnim == null || !skillPanelAnim.IsValid())
			{
				return;
			}
			if (eventName == "Sequence_Start")
			{
				this.SkillPanelAnim.Play("", -1, false);
			}
		}

		// Token: 0x06029148 RID: 168264 RVA: 0x00B89CC9 File Offset: 0x00B87EC9
		protected void OnShowMouseCursor(bool value)
		{
			this.UpdateKeyItem();
		}

		// Token: 0x06029149 RID: 168265 RVA: 0x00B89CD1 File Offset: 0x00B87ED1
		protected void UpdateKeyItem()
		{
			base.GetItem(this.GetUiComponentType(EQuickHackUiType.UseSkillKeyItem)).SetUIActive(Info.Instance.IsInKeyBoard() && !InputManager.Instance.IsShowMouseCursor());
		}

		// Token: 0x040165A2 RID: 91554
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x040165A3 RID: 91555
		[Nullable(2)]
		private QuickHackRamBar RamBar;

		// Token: 0x040165A4 RID: 91556
		[Nullable(2)]
		private QuickHackSkillPanel SkillPanel;

		// Token: 0x040165A5 RID: 91557
		private int TargetItemEntityId;

		// Token: 0x040165A6 RID: 91558
		[Nullable(2)]
		private QuickHackTargetItem TargetItem;

		// Token: 0x040165A7 RID: 91559
		private bool HasTarget;

		// Token: 0x040165A8 RID: 91560
		[Nullable(2)]
		private QuickHackSkillInstance CurrentSkill;

		// Token: 0x040165A9 RID: 91561
		private bool SkillPanelVisible;

		// Token: 0x040165AA RID: 91562
		[Nullable(2)]
		private UUIInturnAnimController SkillPanelAnim;

		// Token: 0x040165AB RID: 91563
		private int CurrentUploadTime = -1;

		// Token: 0x040165AC RID: 91564
		private bool HasUploadTimeInfo;

		// Token: 0x040165AD RID: 91565
		private bool HasDurationInfo;
	}
}
