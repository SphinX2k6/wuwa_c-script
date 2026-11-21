using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.PathDrivenActorSpawner
{
	// Token: 0x02006274 RID: 25204
	public class PathDrivenActorBehaviorRegistry : IStaticVariableResetter
	{
		// Token: 0x0603CD18 RID: 249112 RVA: 0x01178EB9 File Offset: 0x011770B9
		static PathDrivenActorBehaviorRegistry()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PathDrivenActorBehaviorRegistry.CreateStaticDefaultValue), new Action(PathDrivenActorBehaviorRegistry.ResetStaticDefaultValue));
		}

		// Token: 0x0603CD19 RID: 249113 RVA: 0x01178EE4 File Offset: 0x011770E4
		public static void CreateStaticDefaultValue()
		{
			PathDrivenActorBehaviorRegistry.Entries.Clear();
			PathDrivenActorBehaviorRegistry.RegisterPathDrivenActorBehavior("PathDrivenBehavior.ExplosiveBarrel", (int? ownerPbDataId) => new ExplosiveBarrelPathDrivenBehavior(ownerPbDataId));
			PathDrivenActorBehaviorRegistry.RegisterPathDrivenActorBehavior("PathDrivenBehavior.WaterBoxTransport", (int? ownerPbDataId) => new WaterBoxTransportBehavior(ownerPbDataId));
		}

		// Token: 0x0603CD1A RID: 249114 RVA: 0x01178F4D File Offset: 0x0117714D
		public static void ResetStaticDefaultValue()
		{
			PathDrivenActorBehaviorRegistry.Entries.Clear();
		}

		// Token: 0x0603CD1B RID: 249115 RVA: 0x01178F59 File Offset: 0x01177159
		[NullableContext(1)]
		public static void RegisterPathDrivenActorBehavior(string behaviorTag, PathDrivenActorBehaviorFactory createBehavior)
		{
			PathDrivenActorBehaviorRegistry.Entries.Add(new ValueTuple<string, PathDrivenActorBehaviorFactory>(behaviorTag, createBehavior));
		}

		// Token: 0x0603CD1C RID: 249116 RVA: 0x01178F6C File Offset: 0x0117716C
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

		// Token: 0x04020411 RID: 132113
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
