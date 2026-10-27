using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x02002DD6 RID: 11734
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicShakeCameraController : BulletLogicController<LogicDataShakeScreen, object>
{
	// Token: 0x06018A33 RID: 100915 RVA: 0x0064DEE4 File Offset: 0x0064C0E4
	public BulletLogicShakeCameraController(LogicDataShakeScreen param, Entity bullet) : base(param, bullet)
	{
		base.NeedTick = true;
		this.ActorComp = bullet.GetComponent<BulletActorComponent>();
		this.CountMax = (int)param.Count;
		this.MsInterval = param.Interval * (float)TimeUtil.Instance.InverseMillisecond;
		if (CharacterUtils.CanCharacterMonsterOrSummonedDisplayEffect(this.Bullet.GetBulletInfo().AttackerHandle))
		{
			ResourceSystem.Instance.LoadAsync<UClass>(this.LogicController.Shake.ToAssetPathName(), delegate([Nullable(2)] UClass shakeClass, string path)
			{
				this.ShakeClass = shakeClass;
			}, 100, "js_undefined");
		}
	}

	// Token: 0x06018A34 RID: 100916 RVA: 0x0064DF78 File Offset: 0x0064C178
	protected override void Update(float deltaTime)
	{
		if (!this.Started)
		{
			return;
		}
		if (this.Counter >= this.CountMax)
		{
			return;
		}
		if (this.MsTimeCounter < this.MsInterval)
		{
			this.MsTimeCounter += deltaTime;
			return;
		}
		if (this.ShakeClass == null)
		{
			return;
		}
		CameraController.Instance.PlayWorldCameraShake(this.ShakeClass, new FVectorDouble?(this.ActorComp.ActorLocation), this.LogicController.InnerRadius, this.LogicController.OuterRadius, this.LogicController.Falloff, this.LogicController.OrientShakeTowardsEpicenter, "MainCamera");
		this.MsTimeCounter = 0f;
		this.Counter++;
	}

	// Token: 0x06018A35 RID: 100917 RVA: 0x0064E034 File Offset: 0x0064C234
	[NullableContext(2)]
	public override void BulletLogicAction(object param = null)
	{
		if (this.ShakeClass == null)
		{
			return;
		}
		CameraController.Instance.PlayWorldCameraShake(this.ShakeClass, new FVectorDouble?(this.ActorComp.ActorLocation), this.LogicController.InnerRadius, this.LogicController.OuterRadius, this.LogicController.Falloff, this.LogicController.OrientShakeTowardsEpicenter, "MainCamera");
		this.Started = true;
		this.MsTimeCounter = 0f;
		this.Counter = 1;
	}

	// Token: 0x0400B77A RID: 46970
	private readonly BulletActorComponent ActorComp;

	// Token: 0x0400B77B RID: 46971
	private bool Started;

	// Token: 0x0400B77C RID: 46972
	private float MsTimeCounter;

	// Token: 0x0400B77D RID: 46973
	private int Counter;

	// Token: 0x0400B77E RID: 46974
	private readonly int CountMax;

	// Token: 0x0400B77F RID: 46975
	private readonly float MsInterval;

	// Token: 0x0400B780 RID: 46976
	[Nullable(2)]
	private UClass ShakeClass;
}
