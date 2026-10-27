using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02003050 RID: 12368
[NullableContext(2)]
[Nullable(0)]
public class CaughtTriggerInfo
{
	// Token: 0x0601A493 RID: 107667 RVA: 0x006F3AF4 File Offset: 0x006F1CF4
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

	// Token: 0x0601A494 RID: 107668 RVA: 0x006F3CF8 File Offset: 0x006F1EF8
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

	// Token: 0x0400C85E RID: 51294
	private Entity Entity;

	// Token: 0x0400C85F RID: 51295
	public int Index;

	// Token: 0x0400C860 RID: 51296
	[Nullable(1)]
	public string CaughtId = "";

	// Token: 0x0400C861 RID: 51297
	private SCaughtInfo CaughtInfo;

	// Token: 0x0400C862 RID: 51298
	public SCaughtTriggerInfo TriggerInfo;

	// Token: 0x0400C863 RID: 51299
	public BulletEntity BulletEntity;

	// Token: 0x0400C864 RID: 51300
	public BulletActorComponent BulletActorComponent;

	// Token: 0x0400C865 RID: 51301
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<global::HitInformation, HitContext> Handle;

	// Token: 0x0400C866 RID: 51302
	private int DebugBulletId;
}
