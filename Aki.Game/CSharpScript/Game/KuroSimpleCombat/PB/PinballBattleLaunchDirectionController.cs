using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.KuroSimpleCombat.PB
{
	// Token: 0x0200613F RID: 24895
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBattleLaunchDirectionController
	{
		// Token: 0x0603B9ED RID: 244205 RVA: 0x010E9802 File Offset: 0x010E7A02
		public void Init(PinballBattleLaunchDirectionItem directionItem)
		{
			this.DirectionItem = directionItem;
			this.DirectionActor = directionItem.GetRootActor();
		}

		// Token: 0x0603B9EE RID: 244206 RVA: 0x010E9817 File Offset: 0x010E7A17
		public void Destroy()
		{
			this.DirectionItem = null;
			this.DirectionActor = null;
		}

		// Token: 0x0603B9EF RID: 244207 RVA: 0x010E9828 File Offset: 0x010E7A28
		[NullableContext(2)]
		public void Update(AKSC_Shape2D_Entity_Bar leftBar, AKSC_Shape2D_Entity_Bar rightBar)
		{
			AKSC_Shape2D_Entity_Bar aksc_Shape2D_Entity_Bar = null;
			if (leftBar != null && leftBar.IsShowLaunchDirection)
			{
				aksc_Shape2D_Entity_Bar = leftBar;
			}
			else if (rightBar != null && rightBar.IsShowLaunchDirection)
			{
				aksc_Shape2D_Entity_Bar = rightBar;
			}
			if (aksc_Shape2D_Entity_Bar == null)
			{
				this.ShowLaunchDirection(false, null, 0f);
				return;
			}
			this.ShowLaunchDirection(true, new FVector?(aksc_Shape2D_Entity_Bar.LaunchStartPoint), aksc_Shape2D_Entity_Bar.LaunchRotation);
		}

		// Token: 0x0603B9F0 RID: 244208 RVA: 0x010E9884 File Offset: 0x010E7A84
		private void ShowLaunchDirection(bool isShow, FVector? location = null, float rotation = 0f)
		{
			if (isShow && location != null)
			{
				this.Rotation.Yaw = rotation;
				AActor directionActor = this.DirectionActor;
				if (directionActor != null)
				{
					FVector value = location.Value;
					directionActor.D_K2_SetActorLocationAndRotation(value, this.Rotation.ToUeRotator(), false, ref WorldGlobal.SweepHitResult, true);
				}
			}
			if (this.IsShowLaunchDirection == isShow)
			{
				return;
			}
			this.IsShowLaunchDirection = isShow;
			if (isShow)
			{
				PinballBattleLaunchDirectionItem directionItem = this.DirectionItem;
				if (directionItem == null)
				{
					return;
				}
				directionItem.Show(null);
				return;
			}
			else
			{
				PinballBattleLaunchDirectionItem directionItem2 = this.DirectionItem;
				if (directionItem2 == null)
				{
					return;
				}
				directionItem2.Hide(null);
				return;
			}
		}

		// Token: 0x0401F718 RID: 128792
		[Nullable(2)]
		private PinballBattleLaunchDirectionItem DirectionItem;

		// Token: 0x0401F719 RID: 128793
		[Nullable(2)]
		private AActor DirectionActor;

		// Token: 0x0401F71A RID: 128794
		private bool IsShowLaunchDirection;

		// Token: 0x0401F71B RID: 128795
		private readonly Rotator Rotation = Rotator.Create(0f, 0f, 0f);

		// Token: 0x0401F71C RID: 128796
		[StaticVariableRuleIgnore]
		private static readonly Stat UpdateStat = Stat.Create("PinballBattleLaunchDirectionController.Update", "", "");
	}
}
