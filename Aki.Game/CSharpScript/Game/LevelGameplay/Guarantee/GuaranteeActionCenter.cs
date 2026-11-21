using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02005F7E RID: 24446
	[NullableContext(1)]
	[Nullable(0)]
	public class GuaranteeActionCenter : Singleton
	{
		// Token: 0x0603AC86 RID: 240774 RVA: 0x0109ED38 File Offset: 0x0109CF38
		public void RegGuaranteeActions()
		{
			<>f__AnonymousDelegate0<EGuaranteeAction, Func<GuaranteeActionBase>, EActionFilterMode> <>f__AnonymousDelegate = new <>f__AnonymousDelegate0<EGuaranteeAction, Func<GuaranteeActionBase>, EActionFilterMode>(this.SetupGuaranteeAction);
			<>f__AnonymousDelegate(EGuaranteeAction.RestorePlayerCameraAdjustment, () => new GuaranteeActionRestorePlayerCameraAdjustment(), EActionFilterMode.SameAction);
			<>f__AnonymousDelegate(EGuaranteeAction.EnablePlayerMoveControl, () => new GuaranteeActionEnablePlayerMoveControl(), EActionFilterMode.SameName);
			<>f__AnonymousDelegate(EGuaranteeAction.UnLimitPlayerOperation, () => new GuaranteeActionUnLimitPlayerOperation(), EActionFilterMode.SameName);
			<>f__AnonymousDelegate(EGuaranteeAction.ExitOrbitalCamera, () => new GuaranteeActionExitOrbitalCamera(), EActionFilterMode.SameName);
			<>f__AnonymousDelegate(EGuaranteeAction.ActionBlackScreenFadeOut, () => new GuaranteeActionBlackScreenFadeOut(), EActionFilterMode.SameName);
			<>f__AnonymousDelegate(EGuaranteeAction.DisableSplineMoveModel, () => new GuaranteeActionDisableSplineMoveModel(), EActionFilterMode.SameAction);
			<>f__AnonymousDelegate(EGuaranteeAction.StopEffect, () => new GuaranteeActionStopEffect(), EActionFilterMode.SameAction);
			<>f__AnonymousDelegate(EGuaranteeAction.Preload, () => new GuaranteeActionPreload(), EActionFilterMode.SameName);
			<>f__AnonymousDelegate(EGuaranteeAction.DisableKey4Func, () => new GuaranteeActionDisableKey4Func(), EActionFilterMode.SameName);
			<>f__AnonymousDelegate(EGuaranteeAction.ActionExitMovieMode, () => new GuaranteeActionExitMovieMode(), EActionFilterMode.SameName);
			<>f__AnonymousDelegate(EGuaranteeAction.StopGamepadShake, () => new GuaranteeActionStopGamepadShake(), EActionFilterMode.SameName);
		}

		// Token: 0x0603AC87 RID: 240775 RVA: 0x0109EF00 File Offset: 0x0109D100
		private void SetupGuaranteeAction(EGuaranteeAction guaranteeAction, Func<GuaranteeActionBase> actionClass, EActionFilterMode filterMode = EActionFilterMode.SameName)
		{
			if (filterMode == EActionFilterMode.SameAction && !this.ActionComparerMap.ContainsKey(guaranteeAction))
			{
				IGuaranteeActionComparer guaranteeActionComparer = actionClass() as IGuaranteeActionComparer;
				if (guaranteeActionComparer == null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 1);
					defaultInterpolatedStringHandler.AppendLiteral("保底行为 ");
					defaultInterpolatedStringHandler.AppendFormatted<EGuaranteeAction>(guaranteeAction);
					defaultInterpolatedStringHandler.AppendLiteral(" 使用 SameAction 时必须实现 IGuaranteeActionComparer");
					throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				this.ActionComparerMap[guaranteeAction] = guaranteeActionComparer;
			}
			if (!this.GuaranteeActionMap.ContainsKey(guaranteeAction))
			{
				this.GuaranteeActionMap[guaranteeAction] = actionClass;
			}
			if (!this.ActionFilterModeMap.ContainsKey(guaranteeAction))
			{
				this.ActionFilterModeMap[guaranteeAction] = filterMode;
			}
		}

		// Token: 0x0603AC88 RID: 240776 RVA: 0x0109EFA8 File Offset: 0x0109D1A8
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

		// Token: 0x0603AC89 RID: 240777 RVA: 0x0109EFD0 File Offset: 0x0109D1D0
		public bool IsSameAction(GuaranteeActionInfo left, GuaranteeActionInfo right)
		{
			if (left.Name != right.Name)
			{
				return false;
			}
			IGuaranteeActionComparer guaranteeActionComparer;
			if (!this.ActionComparerMap.TryGetValue(left.Name, out guaranteeActionComparer))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
				defaultInterpolatedStringHandler.AppendLiteral("保底行为 ");
				defaultInterpolatedStringHandler.AppendFormatted<EGuaranteeAction>(left.Name);
				defaultInterpolatedStringHandler.AppendLiteral(" 未注册 SameAction 比较器");
				throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return guaranteeActionComparer.IsSameAction(left.Params, right.Params);
		}

		// Token: 0x0603AC8A RID: 240778 RVA: 0x0109F050 File Offset: 0x0109D250
		public EActionFilterMode GetActionFilterMode(EGuaranteeAction guaranteeAction)
		{
			EActionFilterMode result;
			if (this.ActionFilterModeMap.TryGetValue(guaranteeAction, out result))
			{
				return result;
			}
			return EActionFilterMode.Never;
		}

		// Token: 0x17006EED RID: 28397
		// (get) Token: 0x0603AC8B RID: 240779 RVA: 0x0109F070 File Offset: 0x0109D270
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

		// Token: 0x0603AC8C RID: 240780 RVA: 0x0109F093 File Offset: 0x0109D293
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AC8D RID: 240781 RVA: 0x0109F095 File Offset: 0x0109D295
		public static void ResetStaticDefaultValue()
		{
			GuaranteeActionCenter instance = GuaranteeActionCenter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			GuaranteeActionCenter._instance = null;
		}

		// Token: 0x0603AC8E RID: 240782 RVA: 0x0109F0AE File Offset: 0x0109D2AE
		static GuaranteeActionCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GuaranteeActionCenter.CreateStaticDefaultValue), new Action(GuaranteeActionCenter.ResetStaticDefaultValue));
		}

		// Token: 0x0401EE6B RID: 126571
		private readonly Dictionary<EGuaranteeAction, Func<GuaranteeActionBase>> GuaranteeActionMap = new Dictionary<EGuaranteeAction, Func<GuaranteeActionBase>>();

		// Token: 0x0401EE6C RID: 126572
		private readonly Dictionary<EGuaranteeAction, EActionFilterMode> ActionFilterModeMap = new Dictionary<EGuaranteeAction, EActionFilterMode>();

		// Token: 0x0401EE6D RID: 126573
		private readonly Dictionary<EGuaranteeAction, IGuaranteeActionComparer> ActionComparerMap = new Dictionary<EGuaranteeAction, IGuaranteeActionComparer>();

		// Token: 0x0401EE6E RID: 126574
		[Nullable(2)]
		private static GuaranteeActionCenter _instance;
	}
}
