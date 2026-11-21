using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F4C RID: 16204
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class QuickHackTargetSelector
	{
		// Token: 0x06029063 RID: 168035 RVA: 0x00B84C97 File Offset: 0x00B82E97
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

		// Token: 0x06029064 RID: 168036 RVA: 0x00B84CB9 File Offset: 0x00B82EB9
		public virtual void Clear()
		{
		}

		// Token: 0x06029065 RID: 168037 RVA: 0x00B84CBB File Offset: 0x00B82EBB
		public virtual void OnExecuteExtraEffect(EQuickHackSkillExtraEffect type)
		{
		}

		// Token: 0x06029066 RID: 168038
		public abstract bool UpdateTargetInfo(float delta);

		// Token: 0x06029067 RID: 168039
		public abstract IQuickHackLockTargetInfo GetLockTargetInfo();

		// Token: 0x06029068 RID: 168040
		public abstract IQuickHackOnScreenTargetInfo GetOnScreenTargetInfo();

		// Token: 0x06029069 RID: 168041 RVA: 0x00B84CC0 File Offset: 0x00B82EC0
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

		// Token: 0x04016540 RID: 91456
		protected int SelectRange;

		// Token: 0x04016541 RID: 91457
		protected int ScreenRadiusSquared;

		// Token: 0x04016542 RID: 91458
		private FVector2D RefScreenPosition;
	}
}
