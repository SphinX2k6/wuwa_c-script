using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200236F RID: 9071
[NullableContext(2)]
[Nullable(0)]
public class BulletKuroFastCollisionInfo
{
	// Token: 0x060165B7 RID: 91575 RVA: 0x006820F8 File Offset: 0x006802F8
	[NullableContext(1)]
	public unsafe void RegisterCollision(BulletInfo bulletInfo, UKuroFastCollisionAlgorithm algorithm)
	{
		this.UnregisterCollision();
		if (bulletInfo.CollisionInfo.CollisionComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "BulletKuroFastCollisionInfo只支持CollisionComponent";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BulletEntityId", bulletInfo.BulletEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BulletRowName", bulletInfo.BulletRowName);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		UShapeComponent ushapeComponent = bulletInfo.CollisionInfo.CollisionComponent as UShapeComponent;
		if (ushapeComponent == null)
		{
			return;
		}
		algorithm.Add(ushapeComponent);
		algorithm.SetAgentChannelAndMask(ushapeComponent, KuroCollisionChannel.BulletSpecial, 1 << (int)KuroCollisionChannel.Bullet | 1 << (int)KuroCollisionChannel.BulletSpecial);
		this.RegisteredShape = ushapeComponent;
		AActor actor = bulletInfo.Actor;
		UWorldBulletComponent uworldBulletComponent = actor.GetComponentByClass(UWorldBulletComponent.StaticClass()) as UWorldBulletComponent;
		if (uworldBulletComponent == null)
		{
			uworldBulletComponent = (actor.AddComponentByClass(UWorldBulletComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UWorldBulletComponent);
		}
		if (uworldBulletComponent == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Bullet;
			ELogAuthor author2 = ELogAuthor.CFT;
			string message2 = "BulletKuroFastCollisionInfo创建WorldBulletComponent失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("BulletEntityId", bulletInfo.BulletEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("BulletRowName", bulletInfo.BulletRowName);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		this.WorldBulletComponentEnable = false;
		uworldBulletComponent.bEnable = false;
		uworldBulletComponent.WorldBulletType = (EWorldBulletType)bulletInfo.BulletDataMain.Logic.Type;
		this.WorldBulletComponent = uworldBulletComponent;
	}

	// Token: 0x060165B8 RID: 91576 RVA: 0x006822A0 File Offset: 0x006804A0
	public void UnregisterCollision()
	{
		if (this.RegisteredShape == null)
		{
			return;
		}
		UKuroFastCollisionAlgorithm kuroFastCollisionAlgorithm = BulletPatternComponent.GetKuroFastCollisionAlgorithm();
		if (kuroFastCollisionAlgorithm != null)
		{
			kuroFastCollisionAlgorithm.Remove(this.RegisteredShape);
		}
		this.RegisteredShape = null;
		if (this.WorldBulletComponent != null)
		{
			this.WorldBulletComponent.bEnable = false;
			this.WorldBulletComponent = null;
		}
	}

	// Token: 0x060165B9 RID: 91577 RVA: 0x006822ED File Offset: 0x006804ED
	public void SetWorldBulletComponentEnable(bool value)
	{
		if (this.WorldBulletComponent == null)
		{
			return;
		}
		if (this.WorldBulletComponentEnable == value)
		{
			return;
		}
		this.WorldBulletComponentEnable = value;
		this.WorldBulletComponent.bEnable = value;
	}

	// Token: 0x060165BA RID: 91578 RVA: 0x00682315 File Offset: 0x00680515
	public void Clear()
	{
		this.UnregisterCollision();
	}

	// Token: 0x0400BD75 RID: 48501
	private UShapeComponent RegisteredShape;

	// Token: 0x0400BD76 RID: 48502
	public UWorldBulletComponent WorldBulletComponent;

	// Token: 0x0400BD77 RID: 48503
	private bool WorldBulletComponentEnable;
}
