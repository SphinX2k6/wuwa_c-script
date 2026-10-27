using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Pawn.Component
{
	// Token: 0x0200706B RID: 28779
	[NullableContext(2)]
	[Nullable(0)]
	public class PawnInteractBaseComponent : EntityComponent
	{
		// Token: 0x060460E3 RID: 286947 RVA: 0x01179250 File Offset: 0x01177450
		public virtual bool InteractPawn(int optionInstanceId = -1, CommonInteractOption autoOption = null)
		{
			return true;
		}

		// Token: 0x060460E4 RID: 286948 RVA: 0x01179253 File Offset: 0x01177453
		public virtual void CloseInteract(string reason = null)
		{
		}

		// Token: 0x060460E5 RID: 286949 RVA: 0x01179255 File Offset: 0x01177455
		public virtual void ForceUpdate()
		{
		}

		// Token: 0x060460E6 RID: 286950 RVA: 0x01179257 File Offset: 0x01177457
		public virtual bool IsPawnInteractive()
		{
			return false;
		}

		// Token: 0x17009C07 RID: 39943
		// (get) Token: 0x060460E7 RID: 286951 RVA: 0x0117925A File Offset: 0x0117745A
		public virtual AActor OwnerActor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060460E8 RID: 286952 RVA: 0x0117925D File Offset: 0x0117745D
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PawnInteractBaseComponent pawnInteractBaseComponent = (PawnInteractBaseComponent)componentTemplate;
			return true;
		}
	}
}
