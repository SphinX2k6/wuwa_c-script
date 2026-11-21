using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034C8 RID: 13512
	public class CharEnviInteractionEffect : CharRenderBase
	{
		// Token: 0x06022647 RID: 140871 RVA: 0x009BE7A4 File Offset: 0x009BC9A4
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

		// Token: 0x06022648 RID: 140872 RVA: 0x009BE848 File Offset: 0x009BCA48
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

		// Token: 0x06022649 RID: 140873 RVA: 0x009BE86D File Offset: 0x009BCA6D
		[NullableContext(1)]
		public override string GetStatName()
		{
			return "CharEnviInteractionEffect";
		}

		// Token: 0x0602264A RID: 140874 RVA: 0x009BE874 File Offset: 0x009BCA74
		public override int GetComponentId()
		{
			return 15;
		}

		// Token: 0x04012ED7 RID: 77527
		[Nullable(2)]
		public UKuroEnviInteractionComponent EnviInteractionComponent;
	}
}
