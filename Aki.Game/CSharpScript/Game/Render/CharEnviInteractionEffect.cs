using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045A0 RID: 17824
	public class CharEnviInteractionEffect : CharRenderBase
	{
		// Token: 0x0602DF5D RID: 188253 RVA: 0x00A92584 File Offset: 0x00A90784
		public override void Start()
		{
			if (this.EnviInteractionComponent == null)
			{
				AActor owner = base.GetRenderingComponent().GetOwner();
				AActor aactor = owner;
				TSubclassOf<UActorComponent> @class = UKuroEnviInteractionComponent.StaticClass();
				bool bManualAttachment = false;
				FTransform ftransform = new FTransform();
				this.EnviInteractionComponent = (aactor.AddComponentByClass(@class, bManualAttachment, ftransform, false, default(FName)) as UKuroEnviInteractionComponent);
			}
			if (this.EnviInteractionComponent != null)
			{
				this.EnviInteractionComponent.bCalEnviInteractionData = true;
				this.EnviInteractionComponent.RegisterComponentToSystem();
				this.EnviInteractionComponent.bUpdateWaterEID = false;
				FVector rayToOffset = this.EnviInteractionComponent.RayToOffset;
				rayToOffset.Z = -3000f;
				this.EnviInteractionComponent.RayToOffset = rayToOffset;
			}
			base.OnInitSuccess();
		}

		// Token: 0x0602DF5E RID: 188254 RVA: 0x00A92628 File Offset: 0x00A90828
		public override void Destroy()
		{
			if (this.EnviInteractionComponent != null)
			{
				AActor owner = this.EnviInteractionComponent.GetOwner();
				if (owner == null)
				{
					return;
				}
				owner.K2_DestroyComponent(this.EnviInteractionComponent);
			}
		}

		// Token: 0x0602DF5F RID: 188255 RVA: 0x00A9264D File Offset: 0x00A9084D
		[NullableContext(1)]
		public override string GetStatName()
		{
			return "CharEnviInteractionEffect";
		}

		// Token: 0x0602DF60 RID: 188256 RVA: 0x00A92654 File Offset: 0x00A90854
		public override int GetComponentId()
		{
			return 15;
		}

		// Token: 0x0401889C RID: 100508
		[Nullable(2)]
		public UKuroEnviInteractionComponent EnviInteractionComponent;
	}
}
