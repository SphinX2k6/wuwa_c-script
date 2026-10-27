using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F83 RID: 20355
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class QuickHackTargetSelector
	{
		// Token: 0x060341F5 RID: 213493 RVA: 0x00C3B4EB File Offset: 0x00C396EB
		public virtual void Init(int selectRange, int selectScreenRadius)
		{
			this.SelectRange = selectRange;
			if (selectScreenRadius < 0)
			{
				this.ScreenRadiusSquared = int.MaxValue;
				return;
			}
			this.ScreenRadiusSquared = selectScreenRadius * selectScreenRadius;
		}

		// Token: 0x060341F6 RID: 213494 RVA: 0x00C3B50D File Offset: 0x00C3970D
		public virtual void Clear()
		{
		}

		// Token: 0x060341F7 RID: 213495 RVA: 0x00C3B50F File Offset: 0x00C3970F
		public virtual void OnExecuteExtraEffect(EQuickHackSkillExtraEffect type)
		{
		}

		// Token: 0x060341F8 RID: 213496
		public abstract bool UpdateTargetInfo(float delta);

		// Token: 0x060341F9 RID: 213497
		public abstract IQuickHackLockTargetInfo GetLockTargetInfo();

		// Token: 0x060341FA RID: 213498
		public abstract IQuickHackOnScreenTargetInfo GetOnScreenTargetInfo();

		// Token: 0x060341FB RID: 213499 RVA: 0x00C3B514 File Offset: 0x00C39714
		protected bool ProjectWorldToScreen(FVectorDouble worldLocation, Vector2D outScreenPosition, float extend = 0.1f)
		{
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null)
			{
				return false;
			}
			if (!UGameplayStatics.D_ProjectWorldToScreen(characterController, worldLocation, ref this.RefScreenPosition, false))
			{
				return false;
			}
			FVector2D refScreenPosition = this.RefScreenPosition;
			outScreenPosition.Set((double)refScreenPosition.X, (double)refScreenPosition.Y);
			BattleUiModel instance = BattleUiModel.Instance;
			Vector2D viewportSize = instance.ViewportSize;
			double num = viewportSize.X * (double)extend;
			double num2 = viewportSize.Y * (double)extend;
			if (outScreenPosition.X < -num || outScreenPosition.X > viewportSize.X + num || outScreenPosition.Y < -num2 || outScreenPosition.Y > viewportSize.Y + num2)
			{
				return false;
			}
			outScreenPosition.MultiplyEqual((double)instance.ScreenPositionScale).AdditionEqual(instance.ScreenPositionOffset);
			outScreenPosition.Y = -outScreenPosition.Y;
			return true;
		}

		// Token: 0x0401BB6B RID: 113515
		protected int SelectRange;

		// Token: 0x0401BB6C RID: 113516
		protected int ScreenRadiusSquared;

		// Token: 0x0401BB6D RID: 113517
		private FVector2D RefScreenPosition;
	}
}
