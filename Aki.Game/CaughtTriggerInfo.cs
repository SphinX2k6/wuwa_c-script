using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020025A6 RID: 9638
[NullableContext(2)]
[Nullable(0)]
public class CaughtTriggerInfo
{
	// Token: 0x06017E25 RID: 97829 RVA: 0x0071AD48 File Offset: 0x00718F48
	[NullableContext(1)]
	public unsafe void Init(string caughtId, SCaughtInfo info, CharacterActorComponent entityActorComp, CharacterCaughtNewComponent caughtComp, int skillId)
	{
		this.Entity = entityActorComp.Entity;
		this.CaughtId = caughtId;
		this.CaughtInfo = info;
		this.TriggerInfo = this.CaughtInfo.TriggerInfo;
		int num = BulletUtil.CreateBulletFromAN(entityActorComp.Actor, this.TriggerInfo.BulletId, new FTransformDouble?(entityActorComp.ActorTransform), skillId, false, caughtComp.CaughtTriggerAnsMessageId, null, null, null);
		this.DebugBulletId = num;
		this.BulletEntity = BulletModel.Instance.GetBulletEntityById(num);
		BulletEntity bulletEntity = this.BulletEntity;
		this.BulletActorComponent = ((bulletEntity != null) ? bulletEntity.GetComponent<BulletActorComponent>() : null);
		if (this.BulletEntity != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.HYJ;
			string message = "bug追踪  初始化CaughtTriggerInfo， 创建抓取子弹";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DebugBulletId", this.DebugBulletId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("caught id", this.CaughtId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("BulletEntity", this.BulletEntity);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.BulletEntity.GetBulletInfo().AddTagId(GameplayTagDefine.EGameplayTagId["子弹.通用标识.抓取判定"]);
			this.Handle = delegate(global::HitInformation hitData, HitContext _)
			{
				Entity target = hitData.Target;
				if (this.BulletEntity == null || (target == null || !target.Valid) || this.BulletEntity.Id != hitData.BulletEntityId)
				{
					return;
				}
				CreatureDataComponent component = target.GetComponent<CreatureDataComponent>();
				if (component.GetEntityType() == EEntityType.Player || component.GetEntityType() == EEntityType.Monster)
				{
					caughtComp.TryCaught(this, target);
				}
			};
			EventSystem.Instance.AddWithTarget<global::HitInformation, HitContext>(this.Entity, EEventName.CharHitLocal, this.Handle);
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Battle;
		ELogAuthor author2 = ELogAuthor.HYJ;
		string message2 = "bug追踪 初始化CaughtTriggerInfo时异常，没有抓取子弹Entity";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("DebugBulletId", this.DebugBulletId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("caught id", this.CaughtId);
		instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
	}

	// Token: 0x06017E26 RID: 97830 RVA: 0x0071AF4C File Offset: 0x0071914C
	public unsafe void Clear()
	{
		if (this.BulletEntity != null)
		{
			EventSystem.Instance.RemoveWithTarget<global::HitInformation, HitContext>(this.Entity, EEventName.CharHitLocal, this.Handle);
			BulletController.Instance.DestroyBullet(this.BulletEntity.Id, false, EBulletDestroyReason.Normal, false);
		}
		else
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.HYJ;
			string message = "bug追踪 清理CaughtTriggerInfo时异常，没有抓取子弹Entity";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DebugBulletId", this.DebugBulletId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("caught id", this.CaughtId);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		this.Index = 0;
		this.CaughtId = "";
		this.TriggerInfo = null;
		this.CaughtInfo = null;
		this.BulletEntity = null;
		this.BulletActorComponent = null;
		this.Handle = null;
		this.DebugBulletId = 0;
	}

	// Token: 0x0400CC37 RID: 52279
	private Entity Entity;

	// Token: 0x0400CC38 RID: 52280
	public int Index;

	// Token: 0x0400CC39 RID: 52281
	[Nullable(1)]
	public string CaughtId = "";

	// Token: 0x0400CC3A RID: 52282
	private SCaughtInfo CaughtInfo;

	// Token: 0x0400CC3B RID: 52283
	public SCaughtTriggerInfo TriggerInfo;

	// Token: 0x0400CC3C RID: 52284
	public BulletEntity BulletEntity;

	// Token: 0x0400CC3D RID: 52285
	public BulletActorComponent BulletActorComponent;

	// Token: 0x0400CC3E RID: 52286
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<global::HitInformation, HitContext> Handle;

	// Token: 0x0400CC3F RID: 52287
	private int DebugBulletId;
}
