using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Pawn.Component
{
	// Token: 0x020061EC RID: 25068
	[NullableContext(2)]
	[Nullable(0)]
	public class PawnInteractBaseComponent : EntityComponent
	{
		// Token: 0x0603C2E1 RID: 246497 RVA: 0x01122DBA File Offset: 0x01120FBA
		public virtual bool InteractPawn(int optionInstanceId = -1, CommonInteractOption autoOption = null)
		{
			return true;
		}

		// Token: 0x0603C2E2 RID: 246498 RVA: 0x01122DBD File Offset: 0x01120FBD
		public virtual void CloseInteract(string reason = null)
		{
		}

		// Token: 0x0603C2E3 RID: 246499 RVA: 0x01122DBF File Offset: 0x01120FBF
		public virtual void ForceUpdate()
		{
		}

		// Token: 0x0603C2E4 RID: 246500 RVA: 0x01122DC1 File Offset: 0x01120FC1
		public virtual bool IsPawnInteractive()
		{
			return false;
		}

		// Token: 0x17007190 RID: 29072
		// (get) Token: 0x0603C2E5 RID: 246501 RVA: 0x01122DC4 File Offset: 0x01120FC4
		public virtual AActor OwnerActor
		{
			get
			{
				return null;
			}
		}
	}
}
