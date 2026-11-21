using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BD8 RID: 23512
	[NullableContext(1)]
	[Nullable(0)]
	public class SphereTraceBlockChecker : SceneInteractBlockChecker
	{
		// Token: 0x06039C64 RID: 236644 RVA: 0x0103A3CF File Offset: 0x010385CF
		public SphereTraceBlockChecker(string TraceProfileKey)
		{
			this.TraceProfileKey = TraceProfileKey;
		}

		// Token: 0x06039C65 RID: 236645 RVA: 0x0103A40A File Offset: 0x0103860A
		public override void Dispose()
		{
			this.SphereTrace = null;
		}

		// Token: 0x06039C66 RID: 236646 RVA: 0x0103A414 File Offset: 0x01038614
		public override bool IsBlocked(Vector destLocation, ISceneInteractSearchParams @params, bool useAscendSegment, Func<bool, UTraceBaseElement, bool> filterTraceResult, bool debugDraw, [Nullable(2)] AActor describeIgnoreActor = null)
		{
			UTraceSphereElement orCreateSphereTrace = this.GetOrCreateSphereTrace(@params);
			if (orCreateSphereTrace == null)
			{
				return false;
			}
			Vector currentRoleLocation = @params.CurrentRoleLocation;
			this.AscendMidLocation.DeepCopy(currentRoleLocation);
			if (useAscendSegment)
			{
				this.CalcAscendMidLocation(currentRoleLocation, destLocation, @params, this.AscendMidLocation);
				if (!this.AscendMidLocation.Equals(currentRoleLocation, 9.999999747378752E-05))
				{
					TraceElementCommon.Instance.SetStartLocation(orCreateSphereTrace, currentRoleLocation);
					this.EndLocation.DeepCopy(this.AscendMidLocation);
					TraceElementCommon.Instance.SetEndLocation(orCreateSphereTrace, this.EndLocation);
					bool arg = TraceElementCommon.Instance.SphereTrace(orCreateSphereTrace, this.TraceProfileKey);
					bool flag = filterTraceResult(arg, orCreateSphereTrace);
					if (debugDraw)
					{
						SceneInteractDebugDraw.DrawTraceSegment(currentRoleLocation, this.AscendMidLocation, flag, "[阻挡]上升段 " + this.DescribeBlocker(orCreateSphereTrace, describeIgnoreActor));
					}
					if (flag)
					{
						return true;
					}
				}
			}
			TraceElementCommon.Instance.SetStartLocation(orCreateSphereTrace, this.AscendMidLocation);
			this.EndLocation.DeepCopy(destLocation);
			TraceElementCommon.Instance.SetEndLocation(orCreateSphereTrace, this.EndLocation);
			bool arg2 = TraceElementCommon.Instance.SphereTrace(orCreateSphereTrace, this.TraceProfileKey);
			bool flag2 = filterTraceResult(arg2, orCreateSphereTrace);
			if (debugDraw)
			{
				SceneInteractDebugDraw.DrawTraceSegment(this.AscendMidLocation, destLocation, flag2, "[阻挡]位移段 " + this.DescribeBlocker(orCreateSphereTrace, describeIgnoreActor));
			}
			return flag2;
		}

		// Token: 0x06039C67 RID: 236647 RVA: 0x0103A554 File Offset: 0x01038754
		private string DescribeBlocker(UTraceBaseElement element, [Nullable(2)] AActor ignoreActor)
		{
			UKuroHitResult hitResult = element.HitResult;
			TArray<TWeakObjectPtr<AActor>> tarray = (hitResult != null) ? hitResult.Actors : null;
			if (tarray == null)
			{
				return "";
			}
			for (int i = 0; i < tarray.Num(); i++)
			{
				AActor aactor = tarray.Get(i).Get();
				if (aactor != null && aactor != ignoreActor)
				{
					return aactor.GetName();
				}
			}
			return "";
		}

		// Token: 0x06039C68 RID: 236648 RVA: 0x0103A5B4 File Offset: 0x010387B4
		private void CalcAscendMidLocation(Vector charLoc, Vector destLocation, ISceneInteractSearchParams @params, Vector outMidLocation)
		{
			outMidLocation.DeepCopy(charLoc);
			EntityHandle currentRoleEntityHandle = @params.CurrentRoleEntityHandle;
			BaseActorComponent baseActorComponent;
			if (currentRoleEntityHandle == null)
			{
				baseActorComponent = null;
			}
			else
			{
				WorldEntity entity = currentRoleEntityHandle.Entity;
				baseActorComponent = ((entity != null) ? entity.GetComponent<BaseActorComponent>() : null);
			}
			BaseActorComponent baseActorComponent2 = baseActorComponent;
			if (baseActorComponent2 == null)
			{
				return;
			}
			this.TmpUpDir.DeepCopy(baseActorComponent2.ActorGravityDirectProxy);
			this.TmpUpDir.MultiplyEqual(-1.0);
			this.TmpUpDir.Normalize(9.99999993922529E-09);
			this.TmpToDest.DeepCopy(destLocation);
			this.TmpToDest.SubtractionEqual(charLoc);
			double num = Vector.DotProduct(this.TmpToDest, this.TmpUpDir);
			if (num <= 0.0)
			{
				return;
			}
			this.TmpUpDir.MultiplyEqual(num);
			outMidLocation.AdditionEqual(this.TmpUpDir);
		}

		// Token: 0x06039C69 RID: 236649 RVA: 0x0103A67C File Offset: 0x0103887C
		[return: Nullable(2)]
		private UTraceSphereElement GetOrCreateSphereTrace(ISceneInteractSearchParams @params)
		{
			if (this.SphereTrace == null)
			{
				this.SphereTrace = new UTraceSphereElement();
				this.SphereTrace.bIsSingle = false;
				this.SphereTrace.bIgnoreSelf = true;
				this.SphereTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Visible);
				this.SphereTrace.Radius = 1f;
			}
			EntityHandle currentRoleEntityHandle = @params.CurrentRoleEntityHandle;
			AActor aactor;
			if (currentRoleEntityHandle == null)
			{
				aactor = null;
			}
			else
			{
				WorldEntity entity = currentRoleEntityHandle.Entity;
				if (entity == null)
				{
					aactor = null;
				}
				else
				{
					BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
					aactor = ((component != null) ? component.Owner : null);
				}
			}
			AActor aactor2 = aactor;
			if (aactor2 != null)
			{
				this.SphereTrace.WorldContextObject = aactor2;
			}
			else
			{
				this.SphereTrace.WorldContextObject = GlobalData.World;
			}
			return this.SphereTrace;
		}

		// Token: 0x0401E859 RID: 125017
		private const int SPHERE_TRACE_RADIUS = 1;

		// Token: 0x0401E85A RID: 125018
		[Nullable(2)]
		private UTraceSphereElement SphereTrace;

		// Token: 0x0401E85B RID: 125019
		private readonly Vector EndLocation = Vector.Create();

		// Token: 0x0401E85C RID: 125020
		private readonly Vector AscendMidLocation = Vector.Create();

		// Token: 0x0401E85D RID: 125021
		private readonly Vector TmpUpDir = Vector.Create();

		// Token: 0x0401E85E RID: 125022
		private readonly Vector TmpToDest = Vector.Create();

		// Token: 0x0401E85F RID: 125023
		private readonly string TraceProfileKey;
	}
}
