using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role
{
	// Token: 0x0200475D RID: 18269
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class WuWaGoRoleController : ExecutableUnitBase, IStaticVariableResetter
	{
		// Token: 0x0602FC23 RID: 195619 RVA: 0x00B10851 File Offset: 0x00B0EA51
		static WuWaGoRoleController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuWaGoRoleController.CreateStaticDefaultValue), new Action(WuWaGoRoleController.ResetStaticDefaultValue));
		}

		// Token: 0x0602FC24 RID: 195620 RVA: 0x00B10870 File Offset: 0x00B0EA70
		public static void CreateStaticDefaultValue()
		{
			WuWaGoRoleController.ForwardAlignThresholdSquared = Math.Pow(Math.Cos(0.7853981633974483), 2.0);
		}

		// Token: 0x0602FC25 RID: 195621 RVA: 0x00B10893 File Offset: 0x00B0EA93
		public static void ResetStaticDefaultValue()
		{
			WuWaGoRoleController.ForwardAlignThresholdSquared = Math.Pow(Math.Cos(0.7853981633974483), 2.0);
		}

		// Token: 0x1700774B RID: 30539
		// (get) Token: 0x0602FC26 RID: 195622
		public abstract WuWaGoRole BaseRole { get; }

		// Token: 0x1700774C RID: 30540
		// (get) Token: 0x0602FC27 RID: 195623
		public abstract EWuWaGoRoleType RoleType { get; }

		// Token: 0x0602FC28 RID: 195624
		[NullableContext(2)]
		public abstract UniTask TakeAttack(bool playBeHitAnim, UAnimMontage deathMontage = null);

		// Token: 0x0602FC29 RID: 195625
		public abstract void SyncRuntimePresentationAfterCoordinateChanged();

		// Token: 0x0602FC2A RID: 195626
		public abstract void HideAttackRangeEffect(string reason);

		// Token: 0x0602FC2B RID: 195627
		public abstract void ShowAttackRangeEffect(string reason);

		// Token: 0x0602FC2C RID: 195628 RVA: 0x00B108B6 File Offset: 0x00B0EAB6
		public virtual void OnPlayIntroBegin()
		{
		}

		// Token: 0x0602FC2D RID: 195629 RVA: 0x00B108B8 File Offset: 0x00B0EAB8
		public virtual void OnEnterRunning()
		{
		}

		// Token: 0x04019C49 RID: 105545
		private const int FORWARD_ANGLE_LIMIT_DEG = 45;

		// Token: 0x04019C4A RID: 105546
		protected static double ForwardAlignThresholdSquared;
	}
}
