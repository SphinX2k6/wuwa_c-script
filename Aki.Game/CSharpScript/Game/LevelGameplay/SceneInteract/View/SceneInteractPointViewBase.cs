using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.View
{
	// Token: 0x02006A82 RID: 27266
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class SceneInteractPointViewBase : UiPanelBase
	{
		// Token: 0x06043C3E RID: 277566 RVA: 0x01096151 File Offset: 0x01094351
		public void UpdateTargetLocation(Vector targetLocation)
		{
			this.TargetLocation = targetLocation;
		}

		// Token: 0x06043C3F RID: 277567 RVA: 0x0109615C File Offset: 0x0109435C
		public void RefreshPosition()
		{
			LguiUtil.Instance.ConvertWorldPositionToLguiPosition(this.TargetLocation.ToUeVector(false), this.TempVector);
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			FVector fvector = this.TempVector.ToUeVectorOld();
			rootItem.SetUIWorldLocation(fvector);
		}

		// Token: 0x04023675 RID: 145013
		protected Vector TargetLocation = Vector.Create();

		// Token: 0x04023676 RID: 145014
		protected Vector TempVector = Vector.Create();
	}
}
