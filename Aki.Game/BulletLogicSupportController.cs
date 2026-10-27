using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02002DDD RID: 11741
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicSupportController : BulletLogicController<LogicDataSupport, Entity>
{
	// Token: 0x06018A53 RID: 100947 RVA: 0x0064F515 File Offset: 0x0064D715
	public BulletLogicSupportController(LogicDataSupport logicConfig, Entity bulletEntity) : base(logicConfig, bulletEntity)
	{
	}

	// Token: 0x06018A54 RID: 100948 RVA: 0x0064F51F File Offset: 0x0064D71F
	public override void OnInit()
	{
		this.InitTraceInfo();
		this.Bullet.GetBulletInfo().BulletDataMain.Execution.SupportCamp.Add(this.LogicController.Camp);
	}

	// Token: 0x06018A55 RID: 100949 RVA: 0x0064F554 File Offset: 0x0064D754
	private void InitTraceInfo()
	{
		this.TempImpactPoint = Vector.Create(0.0, 0.0, 0.0);
		this.LineTrace = new UTraceLineElement();
		this.LineTrace.bIsSingle = true;
		this.LineTrace.bIgnoreSelf = true;
		this.LineTrace.AddObjectTypeQuery(KuroObjectTypeQuery.Bullet);
		this.LineTrace.DrawTime = 5f;
		TraceElementCommon.Instance.SetTraceColor(this.LineTrace, ColorUtils.LinearGreen);
		TraceElementCommon.Instance.SetTraceHitColor(this.LineTrace, ColorUtils.LinearRed);
	}

	// Token: 0x06018A56 RID: 100950 RVA: 0x0064F5F4 File Offset: 0x0064D7F4
	public override void BulletLogicAction(Entity otherBullet)
	{
		BulletInfo bulletInfo = (otherBullet as BulletEntity).GetBulletInfo();
		if (bulletInfo.AttackerCamp != this.LogicController.Camp || bulletInfo.HasTag(this.LogicController.Tag))
		{
			return;
		}
		bulletInfo.AddTag(this.LogicController.Tag);
		if (ObjectUtils.SoftObjectReferenceValid<UEffectModelBase>(this.LogicController.Effect))
		{
			FTransformDouble hitPointTransform = this.GetHitPointTransform(otherBullet);
			BulletStaticFunction.PlayBulletEffect(GlobalData.World, this.LogicController.Effect.GetAssetPathName().ToString(), hitPointTransform, this.Bullet.GetBulletInfo(), "[BulletLogicSupportController.BulletLogicAction] " + bulletInfo.BulletRowName);
		}
	}

	// Token: 0x06018A57 RID: 100951 RVA: 0x0064F6A4 File Offset: 0x0064D8A4
	private FTransformDouble GetHitPointTransform(Entity otherBullet)
	{
		BulletActorComponent component = this.Bullet.GetComponent<BulletActorComponent>();
		AActor owner = otherBullet.GetComponent<BulletActorComponent>().Owner;
		FTransformDouble ftransformDouble = owner.D_GetTransform();
		FVectorDouble fvectorDouble = UKismetMathLibrary.D_TransformLocation(ftransformDouble, (otherBullet as BulletEntity).Data.Base.CenterOffset.ToUeVector(false));
		ftransformDouble = component.ActorTransform;
		FVectorDouble fvectorDouble2 = UKismetMathLibrary.D_TransformLocation(ftransformDouble, this.Bullet.Data.Base.CenterOffset.ToUeVector(false));
		if (this.LineTrace == null)
		{
			this.InitTraceInfo();
		}
		this.LineTrace.WorldContextObject = owner;
		TraceElementCommon.Instance.SetStartLocation(this.LineTrace, fvectorDouble);
		TraceElementCommon.Instance.SetEndLocation(this.LineTrace, fvectorDouble2);
		bool flag = TraceElementCommon.Instance.LineTrace(this.LineTrace, "BulletLogicSupportController_GetHitPointTransform");
		UKuroHitResult hitResult = this.LineTrace.HitResult;
		FTransformDouble result;
		if (flag && hitResult.bBlockingHit)
		{
			TraceElementCommon.Instance.GetImpactPoint(hitResult, 0, this.TempImpactPoint);
			FQuat fquat = component.ActorRotation.Quaternion();
			FVectorDouble fvectorDouble3 = this.TempImpactPoint.ToUeVector(false);
			result = new FTransformDouble(ref fquat, ref fvectorDouble3);
		}
		else
		{
			result = owner.D_GetTransform();
		}
		this.LineTrace.WorldContextObject = null;
		return result;
	}

	// Token: 0x0400B797 RID: 46999
	private const string PROFILE_KEY = "BulletLogicSupportController_GetHitPointTransform";

	// Token: 0x0400B798 RID: 47000
	private const float DRAW_TIME = 5f;

	// Token: 0x0400B799 RID: 47001
	[Nullable(2)]
	private UTraceLineElement LineTrace;

	// Token: 0x0400B79A RID: 47002
	[Nullable(2)]
	private Vector TempImpactPoint;
}
