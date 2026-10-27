using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02006DFF RID: 28159
	[NullableContext(1)]
	[Nullable(0)]
	public class GuaranteeActionCenter : Singleton
	{
		// Token: 0x06044B22 RID: 281378 RVA: 0x010F4A70 File Offset: 0x010F2C70
		public void RegGuaranteeActions()
		{
			<>f__AnonymousDelegate0<EGuaranteeAction, Func<GuaranteeActionBase>, EActionFilterMode> <>f__AnonymousDelegate = new <>f__AnonymousDelegate0<EGuaranteeAction, Func<GuaranteeActionBase>, EActionFilterMode>(this.SetupGuaranteeAction);
			<>f__AnonymousDelegate(EGuaranteeAction.RestorePlayerCameraAdjustment, () => new GuaranteeActionRestorePlayerCameraAdjustment(), EActionFilterMode.SameAction);
			<>f__AnonymousDelegate(EGuaranteeAction.EnablePlayerMoveControl, () => new GuaranteeActionEnablePlayerMoveControl(), EActionFilterMode.SameName);
			<>f__AnonymousDelegate(EGuaranteeAction.UnLimitPlayerOperation, () => new GuaranteeActionUnLimitPlayerOperation(), EActionFilterMode.SameName);
			<>f__AnonymousDelegate(EGuaranteeAction.ExitOrbitalCamera, () => new GuaranteeActionExitOrbitalCamera(), EActionFilterMode.SameName);
			<>f__AnonymousDelegate(EGuaranteeAction.ActionBlackScreenFadeOut, () => new GuaranteeActionBlackScreenFadeOut(), EActionFilterMode.SameName);
			<>f__AnonymousDelegate(EGuaranteeAction.DisableSplineMoveModel, () => new GuaranteeActionDisableSplineMoveModel(), EActionFilterMode.SameName);
			<>f__AnonymousDelegate(EGuaranteeAction.StopEffect, () => new GuaranteeActionStopEffect(), EActionFilterMode.SameAction);
			<>f__AnonymousDelegate(EGuaranteeAction.Preload, () => new GuaranteeActionPreload(), EActionFilterMode.SameName);
			<>f__AnonymousDelegate(EGuaranteeAction.DisableKey4Func, () => new GuaranteeActionDisableKey4Func(), EActionFilterMode.SameName);
			<>f__AnonymousDelegate(EGuaranteeAction.ActionExitMovieMode, () => new GuaranteeActionExitMovieMode(), EActionFilterMode.SameName);
			<>f__AnonymousDelegate(EGuaranteeAction.StopGamepadShake, () => new GuaranteeActionStopGamepadShake(), EActionFilterMode.SameName);
		}

		// Token: 0x06044B23 RID: 281379 RVA: 0x010F4C37 File Offset: 0x010F2E37
		private void SetupGuaranteeAction(EGuaranteeAction guaranteeAction, Func<GuaranteeActionBase> actionClass, EActionFilterMode filterMode = EActionFilterMode.SameName)
		{
			if (!this.GuaranteeActionMap.ContainsKey(guaranteeAction))
			{
				this.GuaranteeActionMap[guaranteeAction] = actionClass;
			}
			if (!this.ActionFilterModeMap.ContainsKey(guaranteeAction))
			{
				this.ActionFilterModeMap[guaranteeAction] = filterMode;
			}
		}

		// Token: 0x06044B24 RID: 281380 RVA: 0x010F4C70 File Offset: 0x010F2E70
		[NullableContext(2)]
		public GuaranteeActionBase GetGuaranteeAction(EGuaranteeAction guaranteeAction)
		{
			Func<GuaranteeActionBase> func;
			if (!this.GuaranteeActionMap.TryGetValue(guaranteeAction, out func))
			{
				return null;
			}
			return func();
		}

		// Token: 0x06044B25 RID: 281381 RVA: 0x010F4C98 File Offset: 0x010F2E98
		public EActionFilterMode GetActionFilterMode(EGuaranteeAction guaranteeAction)
		{
			EActionFilterMode result;
			if (this.ActionFilterModeMap.TryGetValue(guaranteeAction, out result))
			{
				return result;
			}
			return EActionFilterMode.Never;
		}

		// Token: 0x170099EA RID: 39402
		// (get) Token: 0x06044B26 RID: 281382 RVA: 0x010F4CB8 File Offset: 0x010F2EB8
		public static GuaranteeActionCenter Instance
		{
			get
			{
				if (GuaranteeActionCenter._instance == null)
				{
					GuaranteeActionCenter._instance = new GuaranteeActionCenter();
					GuaranteeActionCenter._instance.OnInit();
				}
				return GuaranteeActionCenter._instance;
			}
		}

		// Token: 0x06044B27 RID: 281383 RVA: 0x010F4CDB File Offset: 0x010F2EDB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06044B28 RID: 281384 RVA: 0x010F4CDD File Offset: 0x010F2EDD
		public static void ResetStaticDefaultValue()
		{
			GuaranteeActionCenter instance = GuaranteeActionCenter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			GuaranteeActionCenter._instance = null;
		}

		// Token: 0x06044B29 RID: 281385 RVA: 0x010F4CF6 File Offset: 0x010F2EF6
		static GuaranteeActionCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GuaranteeActionCenter.CreateStaticDefaultValue), new Action(GuaranteeActionCenter.ResetStaticDefaultValue));
		}

		// Token: 0x04023BC9 RID: 146377
		private readonly Dictionary<EGuaranteeAction, Func<GuaranteeActionBase>> GuaranteeActionMap = new Dictionary<EGuaranteeAction, Func<GuaranteeActionBase>>();

		// Token: 0x04023BCA RID: 146378
		private readonly Dictionary<EGuaranteeAction, EActionFilterMode> ActionFilterModeMap = new Dictionary<EGuaranteeAction, EActionFilterMode>();

		// Token: 0x04023BCB RID: 146379
		[Nullable(2)]
		private static GuaranteeActionCenter _instance;
	}
}
