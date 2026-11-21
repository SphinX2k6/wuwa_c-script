using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x02002330 RID: 9008
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicShakeCameraController : BulletLogicController<LogicDataShakeScreen, object>
{
	// Token: 0x060162DB RID: 90843 RVA: 0x00673CC8 File Offset: 0x00671EC8
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

	// Token: 0x060162DC RID: 90844 RVA: 0x00673D5C File Offset: 0x00671F5C
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
		CameraController.Instance.PlayWorldCameraShake(new TSubclassOf<UCameraShakeBase>?(this.ShakeClass), new FVectorDouble?(this.ActorComp.ActorLocation), this.LogicController.InnerRadius, this.LogicController.OuterRadius, this.LogicController.Falloff, this.LogicController.OrientShakeTowardsEpicenter, "MainCamera");
		this.MsTimeCounter = 0f;
		this.Counter++;
	}

	// Token: 0x060162DD RID: 90845 RVA: 0x00673E1C File Offset: 0x0067201C
	[NullableContext(2)]
	public override void BulletLogicAction(object param = null)
	{
		if (this.ShakeClass == null)
		{
			return;
		}
		CameraController.Instance.PlayWorldCameraShake(new TSubclassOf<UCameraShakeBase>?(this.ShakeClass), new FVectorDouble?(this.ActorComp.ActorLocation), this.LogicController.InnerRadius, this.LogicController.OuterRadius, this.LogicController.Falloff, this.LogicController.OrientShakeTowardsEpicenter, "MainCamera");
		this.Started = true;
		this.MsTimeCounter = 0f;
		this.Counter = 1;
	}

	// Token: 0x0400BAF5 RID: 47861
	private readonly BulletActorComponent ActorComp;

	// Token: 0x0400BAF6 RID: 47862
	private bool Started;

	// Token: 0x0400BAF7 RID: 47863
	private float MsTimeCounter;

	// Token: 0x0400BAF8 RID: 47864
	private int Counter;

	// Token: 0x0400BAF9 RID: 47865
	private readonly int CountMax;

	// Token: 0x0400BAFA RID: 47866
	private readonly float MsInterval;

	// Token: 0x0400BAFB RID: 47867
	[Nullable(2)]
	private UClass ShakeClass;
}
