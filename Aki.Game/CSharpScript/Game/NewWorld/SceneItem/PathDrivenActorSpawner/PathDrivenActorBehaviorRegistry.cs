using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x020071BF RID: 29119
	public class PathDrivenActorBehaviorRegistry : IStaticVariableResetter
	{
		// Token: 0x0604741D RID: 291869 RVA: 0x0121EFAD File Offset: 0x0121D1AD
		static PathDrivenActorBehaviorRegistry()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PathDrivenActorBehaviorRegistry.CreateStaticDefaultValue), new Action(PathDrivenActorBehaviorRegistry.ResetStaticDefaultValue));
		}

		// Token: 0x0604741E RID: 291870 RVA: 0x0121EFD8 File Offset: 0x0121D1D8
		public static void CreateStaticDefaultValue()
		{
			PathDrivenActorBehaviorRegistry.Entries.Clear();
			PathDrivenActorBehaviorRegistry.RegisterPathDrivenActorBehavior("PathDrivenBehavior.ExplosiveBarrel", (int? ownerPbDataId) => new ExplosiveBarrelPathDrivenBehavior(ownerPbDataId));
			PathDrivenActorBehaviorRegistry.RegisterPathDrivenActorBehavior("PathDrivenBehavior.WaterBoxTransport", (int? ownerPbDataId) => new WaterBoxTransportBehavior(ownerPbDataId));
		}

		// Token: 0x0604741F RID: 291871 RVA: 0x0121F041 File Offset: 0x0121D241
		public static void ResetStaticDefaultValue()
		{
			PathDrivenActorBehaviorRegistry.Entries.Clear();
		}

		// Token: 0x06047420 RID: 291872 RVA: 0x0121F04D File Offset: 0x0121D24D
		[NullableContext(1)]
		public static void RegisterPathDrivenActorBehavior(string behaviorTag, PathDrivenActorBehaviorFactory createBehavior)
		{
			PathDrivenActorBehaviorRegistry.Entries.Add(new ValueTuple<string, PathDrivenActorBehaviorFactory>(behaviorTag, createBehavior));
		}

		// Token: 0x06047421 RID: 291873 RVA: 0x0121F060 File Offset: 0x0121D260
		[NullableContext(1)]
		[return: Nullable(2)]
		public static IPathDrivenActorBehavior CreatePathDrivenActorBehavior(AActor actor, int? ownerPbDataId)
		{
			AActor aactor = UKuroStaticLibrary.GetDefaultObject(actor.GetClass()) as AActor;
			if (aactor == null || !aactor.IsValid())
			{
				return null;
			}
			foreach (ValueTuple<string, PathDrivenActorBehaviorFactory> valueTuple in PathDrivenActorBehaviorRegistry.Entries)
			{
				if (aactor.ActorHasTag(FNameUtil.GetDynamicFName(valueTuple.Item1).Value))
				{
					return valueTuple.Item2(ownerPbDataId);
				}
			}
			return null;
		}

		// Token: 0x040257A2 RID: 153506
		[TupleElementNames(new string[]
		{
			"BehaviorTag",
			"CreateBehavior"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		private static readonly List<ValueTuple<string, PathDrivenActorBehaviorFactory>> Entries = new List<ValueTuple<string, PathDrivenActorBehaviorFactory>>();
	}
}
