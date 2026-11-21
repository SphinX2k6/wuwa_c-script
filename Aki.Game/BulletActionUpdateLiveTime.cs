using System;
using UnrealEngine;

// Token: 0x020022F7 RID: 8951
public class BulletActionUpdateLiveTime : BulletActionBase
{
	// Token: 0x06016105 RID: 90373 RVA: 0x00669972 File Offset: 0x00667B72
	public BulletActionUpdateLiveTime(EBulletAction type) : base(type)
	{
	}

	// Token: 0x06016106 RID: 90374 RVA: 0x0066997B File Offset: 0x00667B7B
	protected override void OnExecute()
	{
		this.BulletInfo.LiveTime = 0f;
		this.BulletInfo.LiveTimeAddDelta = 0f;
		this.BulletInfo.CreateFrame = 0;
	}

	// Token: 0x06016107 RID: 90375 RVA: 0x006699AC File Offset: 0x00667BAC
	public override void AfterTick(float delta)
	{
		if (this.BulletInfo.CreateFrame == 0)
		{
			this.BulletInfo.CreateFrame = Time.Instance.Frame;
		}
		this.BulletInfo.LiveTime = this.BulletInfo.LiveTimeAddDelta;
		if (this.BulletInfo.NeedDestroy)
		{
			bool openDestroyLog = BulletConstant.Instance.OpenDestroyLog;
			return;
		}
		AActor actor = this.BulletInfo.Actor;
		if (actor == null || !actor.IsValid())
		{
			this.DestroyBullet();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "子弹Actor被意外销毁";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("子弹Id", this.BulletInfo.BulletRowName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (actor.IsActorBeingDestroyed())
		{
			this.DestroyBullet();
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Bullet;
			ELogAuthor author2 = ELogAuthor.CFT;
			string message2 = "子弹Actor.IsActorBeingDestroyed为true";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("子弹Id", this.BulletInfo.BulletRowName);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		float duration = this.BulletInfo.Duration;
		if (duration < 0f)
		{
			return;
		}
		if (this.BulletInfo.LiveTime >= duration * (float)TimeUtil.Instance.InverseMillisecond)
		{
			this.BulletInfo.IsTimeNotEnough = true;
			this.DestroyBullet();
			return;
		}
		if (this.BulletInfo.AttackerHandle == null)
		{
			this.DestroyBullet();
		}
	}

	// Token: 0x06016108 RID: 90376 RVA: 0x00669AF4 File Offset: 0x00667CF4
	private void DestroyBullet()
	{
		BulletController.Instance.DestroyBullet(this.BulletInfo.BulletEntityId, false, EBulletDestroyReason.Normal, false);
		this.IsFinish = true;
	}
}
