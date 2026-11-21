using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.View
{
	// Token: 0x02005BDF RID: 23519
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class SceneInteractPointViewBase : UiPanelBase
	{
		// Token: 0x06039C8C RID: 236684 RVA: 0x0103A991 File Offset: 0x01038B91
		public void UpdateTargetLocation(Vector targetLocation)
		{
			this.TargetLocation = targetLocation;
		}

		// Token: 0x06039C8D RID: 236685 RVA: 0x0103A99C File Offset: 0x01038B9C
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

		// Token: 0x0401E867 RID: 125031
		protected Vector TargetLocation = Vector.Create();

		// Token: 0x0401E868 RID: 125032
		protected Vector TempVector = Vector.Create();
	}
}
