using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F3E RID: 16190
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class QuickHackModel : ModelBase
	{
		// Token: 0x06028FF3 RID: 167923 RVA: 0x00B83282 File Offset: 0x00B81482
		protected override bool OnChangeMode()
		{
			QuickHackMarkManager markManager = this.MarkManager;
			if (markManager != null)
			{
				markManager.Clear();
			}
			this.MarkManager = null;
			return true;
		}

		// Token: 0x06028FF4 RID: 167924 RVA: 0x00B8329D File Offset: 0x00B8149D
		protected override bool OnLeaveLevel()
		{
			QuickHackMarkManager markManager = this.MarkManager;
			if (markManager != null)
			{
				markManager.Clear();
			}
			this.MarkManager = null;
			return true;
		}

		// Token: 0x06028FF5 RID: 167925 RVA: 0x00B832B8 File Offset: 0x00B814B8
		public void ClearQuickHack()
		{
			if (this.HighlightManagerList != null)
			{
				foreach (QuickHackHighlightManager quickHackHighlightManager in this.HighlightManagerList)
				{
					quickHackHighlightManager.Clear();
				}
				this.HighlightManagerList = null;
			}
			if (this.SkillInstanceMap != null)
			{
				foreach (QuickHackSkillInstance quickHackSkillInstance in this.SkillInstanceMap.Values)
				{
					quickHackSkillInstance.Clear();
				}
				this.SkillInstanceMap = null;
			}
			this.IsQuickHacking = false;
			this.DeviceConfig = null;
			this.CombatMessageId = 0L;
			this.UsedSkillIdList = null;
			QuickHackRamManager ramManager = this.RamManager;
			if (ramManager != null)
			{
				ramManager.Clear();
			}
			this.RamManager = null;
			QuickHackTargetSelector targetSelector = this.TargetSelector;
			if (targetSelector != null)
			{
				targetSelector.Clear();
			}
			this.TargetSelector = null;
			this.TimeScaleManager = null;
			this.ConditionHelper = null;
			this.CloseWhenInteractFinish = true;
			this.InteractFinishGameplayEventTag = null;
			this.OwnerEntityId = 0;
			this.IsInteractFinish = false;
			TimerHandle interactFinishTimer = this.InteractFinishTimer;
			if (interactFinishTimer != null)
			{
				interactFinishTimer.Remove();
			}
			this.InteractFinishTimer = null;
			this.DurationLimitTotalTime = 0.0;
			this.DurationLimitRemainTime = 0.0;
			this.DurationLimitStartTime = 0.0;
			TimerHandle durationLimitTimer = this.DurationLimitTimer;
			if (durationLimitTimer != null)
			{
				durationLimitTimer.Remove();
			}
			this.DurationLimitTimer = null;
			this.CurrentSelectSkill = null;
			this.CurrentLockOnEntityHandle = null;
			this.CurrentSkillList = null;
			this.EntityIdToDisableActorHandleMap = null;
			this.OnCloseQuickHack = null;
			this.PostProcessEffectHandle = 0;
			this.TargetBeenUsedSkillRecordMap = null;
		}

		// Token: 0x06028FF6 RID: 167926 RVA: 0x00B8347C File Offset: 0x00B8167C
		public void ClearCameraControl()
		{
			this.IsCameraControlling = false;
			this.CameraControlDeviceId = 0;
			this.CurrentCameraControlIndex = -1;
			this.CameraControlPbDataIdList = null;
			this.CameraControlMaxFov = 0f;
			this.CameraControlMinFov = 0f;
			this.CameraControlDefaultFov = 0f;
			this.CameraControlPitchMin = 0f;
			this.CameraControlPitchMax = 0f;
			this.CameraControlYawMin = 0f;
			this.CameraControlYawMax = 0f;
			this.CameraControlDefaultPitch = 0f;
			this.CameraControlDefaultYaw = 0f;
			this.CameraControlAutoOpenQuickHack = false;
		}

		// Token: 0x17005306 RID: 21254
		// (get) Token: 0x06028FF7 RID: 167927 RVA: 0x00B8350F File Offset: 0x00B8170F
		[Nullable(1)]
		public static QuickHackModel Instance
		{
			[NullableContext(1)]
			get
			{
				return QuickHackModel._Instance;
			}
		}

		// Token: 0x06028FF8 RID: 167928 RVA: 0x00B83516 File Offset: 0x00B81716
		[NullableContext(1)]
		public static QuickHackModel GetOrCreateInstance()
		{
			if (QuickHackModel._Instance == null)
			{
				QuickHackModel.CreateInstance();
			}
			return QuickHackModel._Instance;
		}

		// Token: 0x06028FF9 RID: 167929 RVA: 0x00B8352A File Offset: 0x00B8172A
		public static bool CreateInstance()
		{
			if (QuickHackModel._Instance != null)
			{
				return true;
			}
			QuickHackModel._Instance = new QuickHackModel();
			return true;
		}

		// Token: 0x06028FFA RID: 167930 RVA: 0x00B83540 File Offset: 0x00B81740
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06028FFB RID: 167931 RVA: 0x00B83542 File Offset: 0x00B81742
		public static void ResetStaticDefaultValue()
		{
			QuickHackModel._Instance = null;
		}

		// Token: 0x06028FFC RID: 167932 RVA: 0x00B8354A File Offset: 0x00B8174A
		static QuickHackModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(QuickHackModel.CreateStaticDefaultValue), new Action(QuickHackModel.ResetStaticDefaultValue));
		}

		// Token: 0x040164E4 RID: 91364
		public bool IsQuickHacking;

		// Token: 0x040164E5 RID: 91365
		public QuickHackDevice? DeviceConfig;

		// Token: 0x040164E6 RID: 91366
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, QuickHackSkillInstance> SkillInstanceMap;

		// Token: 0x040164E7 RID: 91367
		public QuickHackRamManager RamManager;

		// Token: 0x040164E8 RID: 91368
		public QuickHackTargetSelector TargetSelector;

		// Token: 0x040164E9 RID: 91369
		public QuickHackSkillConditionHelper ConditionHelper;

		// Token: 0x040164EA RID: 91370
		public IQuickHackTimeScaleManager TimeScaleManager;

		// Token: 0x040164EB RID: 91371
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<QuickHackHighlightManager> HighlightManagerList;

		// Token: 0x040164EC RID: 91372
		public QuickHackMarkManager MarkManager;

		// Token: 0x040164ED RID: 91373
		public Dictionary<int, int> EntityIdToDisableActorHandleMap;

		// Token: 0x040164EE RID: 91374
		public long CombatMessageId;

		// Token: 0x040164EF RID: 91375
		public List<int> UsedSkillIdList;

		// Token: 0x040164F0 RID: 91376
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, HashSet<int>> TargetBeenUsedSkillRecordMap;

		// Token: 0x040164F1 RID: 91377
		public Action OnCloseQuickHack;

		// Token: 0x040164F2 RID: 91378
		public bool CloseWhenInteractFinish = true;

		// Token: 0x040164F3 RID: 91379
		public FGameplayTag? InteractFinishGameplayEventTag;

		// Token: 0x040164F4 RID: 91380
		public int OwnerEntityId;

		// Token: 0x040164F5 RID: 91381
		public bool IsInteractFinish;

		// Token: 0x040164F6 RID: 91382
		public TimerHandle InteractFinishTimer;

		// Token: 0x040164F7 RID: 91383
		public double DurationLimitTotalTime;

		// Token: 0x040164F8 RID: 91384
		public double DurationLimitRemainTime;

		// Token: 0x040164F9 RID: 91385
		public double DurationLimitStartTime;

		// Token: 0x040164FA RID: 91386
		public TimerHandle DurationLimitTimer;

		// Token: 0x040164FB RID: 91387
		public EntityHandle CurrentLockOnEntityHandle;

		// Token: 0x040164FC RID: 91388
		public QuickHackSkillInstance CurrentSelectSkill;

		// Token: 0x040164FD RID: 91389
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<QuickHackSkillInstance> CurrentSkillList;

		// Token: 0x040164FE RID: 91390
		public bool IsCameraControlling;

		// Token: 0x040164FF RID: 91391
		public int CameraControlDeviceId;

		// Token: 0x04016500 RID: 91392
		public int CurrentCameraControlIndex = -1;

		// Token: 0x04016501 RID: 91393
		public List<int> CameraControlPbDataIdList;

		// Token: 0x04016502 RID: 91394
		public float CameraControlMaxFov;

		// Token: 0x04016503 RID: 91395
		public float CameraControlMinFov;

		// Token: 0x04016504 RID: 91396
		public float CameraControlDefaultFov;

		// Token: 0x04016505 RID: 91397
		public float CameraControlDefaultPitch;

		// Token: 0x04016506 RID: 91398
		public float CameraControlPitchMin;

		// Token: 0x04016507 RID: 91399
		public float CameraControlPitchMax;

		// Token: 0x04016508 RID: 91400
		public float CameraControlDefaultYaw;

		// Token: 0x04016509 RID: 91401
		public float CameraControlYawMin;

		// Token: 0x0401650A RID: 91402
		public float CameraControlYawMax;

		// Token: 0x0401650B RID: 91403
		public bool CameraControlAutoOpenQuickHack;

		// Token: 0x0401650C RID: 91404
		public int PostProcessEffectHandle;

		// Token: 0x0401650D RID: 91405
		private static QuickHackModel _Instance;
	}
}
