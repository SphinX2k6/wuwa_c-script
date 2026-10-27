using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A7B RID: 27259
	[NullableContext(1)]
	[Nullable(0)]
	public class SphereTraceBlockChecker : SceneInteractBlockChecker
	{
		// Token: 0x06043C16 RID: 277526 RVA: 0x01095B8F File Offset: 0x01093D8F
		public SphereTraceBlockChecker(string TraceProfileKey)
		{
			this.TraceProfileKey = TraceProfileKey;
		}

		// Token: 0x06043C17 RID: 277527 RVA: 0x01095BCA File Offset: 0x01093DCA
		public override void Dispose()
		{
			this.SphereTrace = null;
		}

		// Token: 0x06043C18 RID: 277528 RVA: 0x01095BD4 File Offset: 0x01093DD4
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

		// Token: 0x06043C19 RID: 277529 RVA: 0x01095D14 File Offset: 0x01093F14
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

		// Token: 0x06043C1A RID: 277530 RVA: 0x01095D74 File Offset: 0x01093F74
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

		// Token: 0x06043C1B RID: 277531 RVA: 0x01095E3C File Offset: 0x0109403C
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

		// Token: 0x04023667 RID: 144999
		private const int SPHERE_TRACE_RADIUS = 1;

		// Token: 0x04023668 RID: 145000
		[Nullable(2)]
		private UTraceSphereElement SphereTrace;

		// Token: 0x04023669 RID: 145001
		private readonly Vector EndLocation = Vector.Create();

		// Token: 0x0402366A RID: 145002
		private readonly Vector AscendMidLocation = Vector.Create();

		// Token: 0x0402366B RID: 145003
		private readonly Vector TmpUpDir = Vector.Create();

		// Token: 0x0402366C RID: 145004
		private readonly Vector TmpToDest = Vector.Create();

		// Token: 0x0402366D RID: 145005
		private readonly string TraceProfileKey;
	}
}
