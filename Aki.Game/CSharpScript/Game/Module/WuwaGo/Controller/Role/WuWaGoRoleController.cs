using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role
{
	// Token: 0x0200368E RID: 13966
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class WuWaGoRoleController : ExecutableUnitBase, IStaticVariableResetter
	{
		// Token: 0x060243ED RID: 148461 RVA: 0x00A40811 File Offset: 0x00A3EA11
		static WuWaGoRoleController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuWaGoRoleController.CreateStaticDefaultValue), new Action(WuWaGoRoleController.ResetStaticDefaultValue));
		}

		// Token: 0x060243EE RID: 148462 RVA: 0x00A40830 File Offset: 0x00A3EA30
		public static void CreateStaticDefaultValue()
		{
			WuWaGoRoleController.ForwardAlignThresholdSquared = Math.Pow(Math.Cos(0.7853981633974483), 2.0);
		}

		// Token: 0x060243EF RID: 148463 RVA: 0x00A40853 File Offset: 0x00A3EA53
		public static void ResetStaticDefaultValue()
		{
			WuWaGoRoleController.ForwardAlignThresholdSquared = Math.Pow(Math.Cos(0.7853981633974483), 2.0);
		}

		// Token: 0x17004A07 RID: 18951
		// (get) Token: 0x060243F0 RID: 148464
		public abstract WuWaGoRole BaseRole { get; }

		// Token: 0x17004A08 RID: 18952
		// (get) Token: 0x060243F1 RID: 148465
		public abstract EWuWaGoRoleType RoleType { get; }

		// Token: 0x060243F2 RID: 148466
		[NullableContext(2)]
		public abstract UniTask TakeAttack(bool playBeHitAnim, UAnimMontage deathMontage = null);

		// Token: 0x060243F3 RID: 148467
		public abstract void SyncRuntimePresentationAfterCoordinateChanged();

		// Token: 0x060243F4 RID: 148468
		public abstract void HideAttackRangeEffect(string reason);

		// Token: 0x060243F5 RID: 148469
		public abstract void ShowAttackRangeEffect(string reason);

		// Token: 0x060243F6 RID: 148470 RVA: 0x00A40876 File Offset: 0x00A3EA76
		public virtual void OnPlayIntroBegin()
		{
		}

		// Token: 0x060243F7 RID: 148471 RVA: 0x00A40878 File Offset: 0x00A3EA78
		public virtual void OnEnterRunning()
		{
		}

		// Token: 0x040142F9 RID: 82681
		private const int FORWARD_ANGLE_LIMIT_DEG = 45;

		// Token: 0x040142FA RID: 82682
		protected static double ForwardAlignThresholdSquared;
	}
}
