using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F75 RID: 20341
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class QuickHackModel : ModelBase
	{
		// Token: 0x06034185 RID: 213381 RVA: 0x00C39AD6 File Offset: 0x00C37CD6
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

		// Token: 0x06034186 RID: 213382 RVA: 0x00C39AF1 File Offset: 0x00C37CF1
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

		// Token: 0x06034187 RID: 213383 RVA: 0x00C39B0C File Offset: 0x00C37D0C
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

		// Token: 0x06034188 RID: 213384 RVA: 0x00C39CD0 File Offset: 0x00C37ED0
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

		// Token: 0x17007F56 RID: 32598
		// (get) Token: 0x06034189 RID: 213385 RVA: 0x00C39D63 File Offset: 0x00C37F63
		[Nullable(1)]
		public static QuickHackModel Instance
		{
			[NullableContext(1)]
			get
			{
				return QuickHackModel._Instance;
			}
		}

		// Token: 0x0603418A RID: 213386 RVA: 0x00C39D6A File Offset: 0x00C37F6A
		[NullableContext(1)]
		public static QuickHackModel GetOrCreateInstance()
		{
			if (QuickHackModel._Instance == null)
			{
				QuickHackModel.CreateInstance();
			}
			return QuickHackModel._Instance;
		}

		// Token: 0x0603418B RID: 213387 RVA: 0x00C39D7E File Offset: 0x00C37F7E
		public static bool CreateInstance()
		{
			if (QuickHackModel._Instance != null)
			{
				return true;
			}
			QuickHackModel._Instance = new QuickHackModel();
			return true;
		}

		// Token: 0x0603418C RID: 213388 RVA: 0x00C39D94 File Offset: 0x00C37F94
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603418D RID: 213389 RVA: 0x00C39D96 File Offset: 0x00C37F96
		public static void ResetStaticDefaultValue()
		{
			QuickHackModel._Instance = null;
		}

		// Token: 0x0603418E RID: 213390 RVA: 0x00C39D9E File Offset: 0x00C37F9E
		static QuickHackModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(QuickHackModel.CreateStaticDefaultValue), new Action(QuickHackModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401BB0F RID: 113423
		public bool IsQuickHacking;

		// Token: 0x0401BB10 RID: 113424
		public QuickHackDevice? DeviceConfig;

		// Token: 0x0401BB11 RID: 113425
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, QuickHackSkillInstance> SkillInstanceMap;

		// Token: 0x0401BB12 RID: 113426
		public QuickHackRamManager RamManager;

		// Token: 0x0401BB13 RID: 113427
		public QuickHackTargetSelector TargetSelector;

		// Token: 0x0401BB14 RID: 113428
		public QuickHackSkillConditionHelper ConditionHelper;

		// Token: 0x0401BB15 RID: 113429
		public IQuickHackTimeScaleManager TimeScaleManager;

		// Token: 0x0401BB16 RID: 113430
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<QuickHackHighlightManager> HighlightManagerList;

		// Token: 0x0401BB17 RID: 113431
		public QuickHackMarkManager MarkManager;

		// Token: 0x0401BB18 RID: 113432
		public Dictionary<int, int> EntityIdToDisableActorHandleMap;

		// Token: 0x0401BB19 RID: 113433
		public long CombatMessageId;

		// Token: 0x0401BB1A RID: 113434
		public List<int> UsedSkillIdList;

		// Token: 0x0401BB1B RID: 113435
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, HashSet<int>> TargetBeenUsedSkillRecordMap;

		// Token: 0x0401BB1C RID: 113436
		public Action OnCloseQuickHack;

		// Token: 0x0401BB1D RID: 113437
		public bool CloseWhenInteractFinish = true;

		// Token: 0x0401BB1E RID: 113438
		public FGameplayTag? InteractFinishGameplayEventTag;

		// Token: 0x0401BB1F RID: 113439
		public int OwnerEntityId;

		// Token: 0x0401BB20 RID: 113440
		public bool IsInteractFinish;

		// Token: 0x0401BB21 RID: 113441
		public TimerHandle InteractFinishTimer;

		// Token: 0x0401BB22 RID: 113442
		public double DurationLimitTotalTime;

		// Token: 0x0401BB23 RID: 113443
		public double DurationLimitRemainTime;

		// Token: 0x0401BB24 RID: 113444
		public double DurationLimitStartTime;

		// Token: 0x0401BB25 RID: 113445
		public TimerHandle DurationLimitTimer;

		// Token: 0x0401BB26 RID: 113446
		public EntityHandle CurrentLockOnEntityHandle;

		// Token: 0x0401BB27 RID: 113447
		public QuickHackSkillInstance CurrentSelectSkill;

		// Token: 0x0401BB28 RID: 113448
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<QuickHackSkillInstance> CurrentSkillList;

		// Token: 0x0401BB29 RID: 113449
		public bool IsCameraControlling;

		// Token: 0x0401BB2A RID: 113450
		public int CameraControlDeviceId;

		// Token: 0x0401BB2B RID: 113451
		public int CurrentCameraControlIndex = -1;

		// Token: 0x0401BB2C RID: 113452
		public List<int> CameraControlPbDataIdList;

		// Token: 0x0401BB2D RID: 113453
		public float CameraControlMaxFov;

		// Token: 0x0401BB2E RID: 113454
		public float CameraControlMinFov;

		// Token: 0x0401BB2F RID: 113455
		public float CameraControlDefaultFov;

		// Token: 0x0401BB30 RID: 113456
		public float CameraControlDefaultPitch;

		// Token: 0x0401BB31 RID: 113457
		public float CameraControlPitchMin;

		// Token: 0x0401BB32 RID: 113458
		public float CameraControlPitchMax;

		// Token: 0x0401BB33 RID: 113459
		public float CameraControlDefaultYaw;

		// Token: 0x0401BB34 RID: 113460
		public float CameraControlYawMin;

		// Token: 0x0401BB35 RID: 113461
		public float CameraControlYawMax;

		// Token: 0x0401BB36 RID: 113462
		public bool CameraControlAutoOpenQuickHack;

		// Token: 0x0401BB37 RID: 113463
		public int PostProcessEffectHandle;

		// Token: 0x0401BB38 RID: 113464
		private static QuickHackModel _Instance;
	}
}
