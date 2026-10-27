using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.KuroSimpleCombat.PB
{
	// Token: 0x02006FBE RID: 28606
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBattleLaunchDirectionController
	{
		// Token: 0x0604583D RID: 284733 RVA: 0x0113FA32 File Offset: 0x0113DC32
		public void Init(PinballBattleLaunchDirectionItem directionItem)
		{
			this.DirectionItem = directionItem;
			this.DirectionActor = directionItem.GetRootActor();
		}

		// Token: 0x0604583E RID: 284734 RVA: 0x0113FA47 File Offset: 0x0113DC47
		public void Destroy()
		{
			this.DirectionItem = null;
			this.DirectionActor = null;
		}

		// Token: 0x0604583F RID: 284735 RVA: 0x0113FA58 File Offset: 0x0113DC58
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

		// Token: 0x06045840 RID: 284736 RVA: 0x0113FAB4 File Offset: 0x0113DCB4
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

		// Token: 0x04024463 RID: 148579
		[Nullable(2)]
		private PinballBattleLaunchDirectionItem DirectionItem;

		// Token: 0x04024464 RID: 148580
		[Nullable(2)]
		private AActor DirectionActor;

		// Token: 0x04024465 RID: 148581
		private bool IsShowLaunchDirection;

		// Token: 0x04024466 RID: 148582
		private readonly Rotator Rotation = Rotator.Create(0f, 0f, 0f);

		// Token: 0x04024467 RID: 148583
		[StaticVariableRuleIgnore]
		private static readonly Stat UpdateStat = Stat.Create("PinballBattleLaunchDirectionController.Update", "", "");
	}
}
