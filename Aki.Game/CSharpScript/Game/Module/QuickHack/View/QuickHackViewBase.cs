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
	// Token: 0x02004F96 RID: 20374
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class QuickHackViewBase : UiTickViewBase, IUiProhibitRefreshData
	{
		// Token: 0x060342B8 RID: 213688 RVA: 0x00C3F84C File Offset: 0x00C3DA4C
		public QuickHackViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060342B9 RID: 213689 RVA: 0x00C3F85C File Offset: 0x00C3DA5C
		protected override UniTask OnBeforeStartAsync()
		{
			QuickHackViewBase.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuickHackViewBase.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060342BA RID: 213690 RVA: 0x00C3F8A0 File Offset: 0x00C3DAA0
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(this.GetUiComponentType(EQuickHackUiType.SkillPanelLayout));
			this.SkillPanelAnim = (verticalLayout.GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController);
		}

		// Token: 0x060342BB RID: 213691 RVA: 0x00C3F908 File Offset: 0x00C3DB08
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

		// Token: 0x060342BC RID: 213692 RVA: 0x00C3FAA0 File Offset: 0x00C3DCA0
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

		// Token: 0x060342BD RID: 213693 RVA: 0x00C3FBC0 File Offset: 0x00C3DDC0
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.UpdateKeyItem();
		}

		// Token: 0x060342BE RID: 213694 RVA: 0x00C3FBC8 File Offset: 0x00C3DDC8
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

		// Token: 0x060342BF RID: 213695 RVA: 0x00C3FC9C File Offset: 0x00C3DE9C
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

		// Token: 0x060342C0 RID: 213696
		protected abstract void RefreshInput(bool enable);

		// Token: 0x060342C1 RID: 213697
		protected abstract int GetUiComponentType(EQuickHackUiType uiType);

		// Token: 0x060342C2 RID: 213698
		protected abstract List<UUIItem> GetSkillItems();

		// Token: 0x060342C3 RID: 213699 RVA: 0x00C3FD29 File Offset: 0x00C3DF29
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

		// Token: 0x060342C4 RID: 213700 RVA: 0x00C3FD69 File Offset: 0x00C3DF69
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

		// Token: 0x060342C5 RID: 213701 RVA: 0x00C3FD94 File Offset: 0x00C3DF94
		private void OnCurrentRamChange()
		{
			QuickHackRamManager ramManager = QuickHackModel.Instance.RamManager;
			int currentRam = (int)Math.Floor((double)((ramManager != null) ? ramManager.GetCurrentRam() : 0f));
			int maxRam = (int)Math.Floor((double)((ramManager != null) ? ramManager.GetMaxRam() : 0f));
			this.RefreshRam(currentRam, maxRam, true);
		}

		// Token: 0x060342C6 RID: 213702 RVA: 0x00C3FDE8 File Offset: 0x00C3DFE8
		private void OnMxRamChange()
		{
			QuickHackRamManager ramManager = QuickHackModel.Instance.RamManager;
			int currentRam = (int)Math.Floor((double)((ramManager != null) ? ramManager.GetCurrentRam() : 0f));
			int maxRam = (int)Math.Floor((double)((ramManager != null) ? ramManager.GetMaxRam() : 0f));
			this.RefreshRam(currentRam, maxRam, false);
		}

		// Token: 0x060342C7 RID: 213703 RVA: 0x00C3FE3C File Offset: 0x00C3E03C
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

		// Token: 0x060342C8 RID: 213704 RVA: 0x00C3FE98 File Offset: 0x00C3E098
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

		// Token: 0x060342C9 RID: 213705 RVA: 0x00C3FFF1 File Offset: 0x00C3E1F1
		protected virtual bool ShouldShowTargetItem()
		{
			return true;
		}

		// Token: 0x060342CA RID: 213706 RVA: 0x00C3FFF4 File Offset: 0x00C3E1F4
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

		// Token: 0x060342CB RID: 213707 RVA: 0x00C40078 File Offset: 0x00C3E278
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

		// Token: 0x060342CC RID: 213708 RVA: 0x00C4012C File Offset: 0x00C3E32C
		private void OnAllSkillChange()
		{
			this.UpdateSkillInfo(true, false);
		}

		// Token: 0x060342CD RID: 213709 RVA: 0x00C40136 File Offset: 0x00C3E336
		private void OnSelectSkillChange()
		{
			this.UpdateSkillInfo(false, false);
		}

		// Token: 0x060342CE RID: 213710 RVA: 0x00C40140 File Offset: 0x00C3E340
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

		// Token: 0x060342CF RID: 213711 RVA: 0x00C402FD File Offset: 0x00C3E4FD
		private void UpdateInfoLine()
		{
			if (this.HasUploadTimeInfo || this.HasDurationInfo)
			{
				base.GetItem(this.GetUiComponentType(EQuickHackUiType.InfoLineItem)).SetUIActive(true);
				return;
			}
			base.GetItem(this.GetUiComponentType(EQuickHackUiType.InfoLineItem)).SetUIActive(false);
		}

		// Token: 0x060342D0 RID: 213712 RVA: 0x00C40338 File Offset: 0x00C3E538
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

		// Token: 0x060342D1 RID: 213713
		protected abstract string GetSelectSkillAudioPath();

		// Token: 0x060342D2 RID: 213714 RVA: 0x00C403CF File Offset: 0x00C3E5CF
		public bool CheckCondition()
		{
			return !InputManager.Instance.IsShowMouseCursor() || !Info.Instance.IsInKeyBoard();
		}

		// Token: 0x060342D3 RID: 213715 RVA: 0x00C403EC File Offset: 0x00C3E5EC
		public string[] GetDistributeTags()
		{
			return this.GetInputDistributeTags();
		}

		// Token: 0x060342D4 RID: 213716 RVA: 0x00C403F4 File Offset: 0x00C3E5F4
		protected virtual string[] GetInputDistributeTags()
		{
			return new string[]
			{
				"FightInputRoot.FightInput.AxisInput.CameraInput.CameraRotation",
				"UiInputRoot.MouseInputTag",
				"UiInputRoot.Navigation"
			};
		}

		// Token: 0x060342D5 RID: 213717 RVA: 0x00C40414 File Offset: 0x00C3E614
		private void OnCheckCurrentSkillCanUse(QuickHackSkillConditionResult canUseInfo)
		{
			this.UpdateCurrentSkillCanUse(canUseInfo);
			this.RefreshSelectRam();
		}

		// Token: 0x060342D6 RID: 213718 RVA: 0x00C40424 File Offset: 0x00C3E624
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

		// Token: 0x060342D7 RID: 213719 RVA: 0x00C40483 File Offset: 0x00C3E683
		protected virtual void OnUpdateCurrentSkillCanUse(bool canUse)
		{
		}

		// Token: 0x060342D8 RID: 213720 RVA: 0x00C40488 File Offset: 0x00C3E688
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

		// Token: 0x060342D9 RID: 213721 RVA: 0x00C404E4 File Offset: 0x00C3E6E4
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

		// Token: 0x060342DA RID: 213722 RVA: 0x00C4051D File Offset: 0x00C3E71D
		protected void OnShowMouseCursor(bool value)
		{
			this.UpdateKeyItem();
		}

		// Token: 0x060342DB RID: 213723 RVA: 0x00C40525 File Offset: 0x00C3E725
		protected void UpdateKeyItem()
		{
			base.GetItem(this.GetUiComponentType(EQuickHackUiType.UseSkillKeyItem)).SetUIActive(Info.Instance.IsInKeyBoard() && !InputManager.Instance.IsShowMouseCursor());
		}

		// Token: 0x0401BBCD RID: 113613
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401BBCE RID: 113614
		[Nullable(2)]
		private QuickHackRamBar RamBar;

		// Token: 0x0401BBCF RID: 113615
		[Nullable(2)]
		private QuickHackSkillPanel SkillPanel;

		// Token: 0x0401BBD0 RID: 113616
		private int TargetItemEntityId;

		// Token: 0x0401BBD1 RID: 113617
		[Nullable(2)]
		private QuickHackTargetItem TargetItem;

		// Token: 0x0401BBD2 RID: 113618
		private bool HasTarget;

		// Token: 0x0401BBD3 RID: 113619
		[Nullable(2)]
		private QuickHackSkillInstance CurrentSkill;

		// Token: 0x0401BBD4 RID: 113620
		private bool SkillPanelVisible;

		// Token: 0x0401BBD5 RID: 113621
		[Nullable(2)]
		private UUIInturnAnimController SkillPanelAnim;

		// Token: 0x0401BBD6 RID: 113622
		private int CurrentUploadTime = -1;

		// Token: 0x0401BBD7 RID: 113623
		private bool HasUploadTimeInfo;

		// Token: 0x0401BBD8 RID: 113624
		private bool HasDurationInfo;
	}
}
