using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x02002F54 RID: 12116
[NullableContext(1)]
[Nullable(0)]
public class SyncTimescaleGroup
{
	// Token: 0x06019C95 RID: 105621 RVA: 0x006B96AC File Offset: 0x006B78AC
	public SyncTimescaleGroup(EntityHandle instigatorHandle, long buffId)
	{
		this.InstigatorHandle = instigatorHandle;
		this.BuffId = buffId;
		WorldEntity entity = this.InstigatorHandle.Entity;
		this.InstigatorTimeScaleComp = ((entity != null) ? entity.GetComponent<CharacterTimeScaleComponent>() : null);
		EventSystem.Instance.AddWithTarget(this.InstigatorHandle.Entity, EEventName.CharBeHitTimeScale, new Action<float, ETimeScaleSourceType>(this.OnInstigatorTimeScaleChanged));
	}

	// Token: 0x06019C96 RID: 105622 RVA: 0x006B9719 File Offset: 0x006B7919
	public void Release()
	{
		if (this.InstigatorHandle.Valid)
		{
			EventSystem.Instance.RemoveWithTarget(this.InstigatorHandle.Entity, EEventName.CharBeHitTimeScale, new Action<float, ETimeScaleSourceType>(this.OnInstigatorTimeScaleChanged));
		}
	}

	// Token: 0x06019C97 RID: 105623 RVA: 0x006B974C File Offset: 0x006B794C
	public bool HasOwner(int ownerId)
	{
		return this.OwnerIds.ContainsKey(ownerId);
	}

	// Token: 0x06019C98 RID: 105624 RVA: 0x006B975C File Offset: 0x006B795C
	[NullableContext(2)]
	public unsafe void AddOwner(Entity ownerEntity = null)
	{
		if (ownerEntity == null)
		{
			return;
		}
		if (this.OwnerIds.ContainsKey(ownerEntity.Id))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BuffItem;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "添加了多个Buff都有85号效果";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BuffId", this.BuffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Instigator", this.InstigatorHandle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Owner", ownerEntity.Id);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		CharacterTimeScaleComponent component = ownerEntity.GetComponent<CharacterTimeScaleComponent>();
		if (component != null)
		{
			this.OwnerIds[ownerEntity.Id] = component;
			if (component.Valid)
			{
				CharacterTimeScaleComponent instigatorTimeScaleComp = this.InstigatorTimeScaleComp;
				if (instigatorTimeScaleComp != null && instigatorTimeScaleComp.Valid)
				{
					component.AddForceTimeScale(this.InstigatorTimeScaleComp.CurrentTimeScale, "ExtraEffect.SyncTimeScale", true, ETimeScaleSourceType.InnerForceTimeScale);
				}
			}
		}
	}

	// Token: 0x06019C99 RID: 105625 RVA: 0x006B9863 File Offset: 0x006B7A63
	public string GetOwnerInfo()
	{
		return string.Join<int>(",", this.OwnerIds.Keys);
	}

	// Token: 0x06019C9A RID: 105626 RVA: 0x006B987C File Offset: 0x006B7A7C
	public void RemoveOwner(int entityId)
	{
		CharacterTimeScaleComponent characterTimeScaleComponent;
		if (this.OwnerIds.TryGetValue(entityId, out characterTimeScaleComponent) && characterTimeScaleComponent.Valid)
		{
			characterTimeScaleComponent.RemoveForceTimeScale("ExtraEffect.SyncTimeScale", true);
		}
		this.OwnerIds.Remove(entityId);
	}

	// Token: 0x06019C9B RID: 105627 RVA: 0x006B98BC File Offset: 0x006B7ABC
	public void OnInstigatorTimeScaleChanged(float timeScale, ETimeScaleSourceType sourceType)
	{
		foreach (CharacterTimeScaleComponent characterTimeScaleComponent in this.OwnerIds.Values)
		{
			if (characterTimeScaleComponent != null && characterTimeScaleComponent.Valid)
			{
				characterTimeScaleComponent.AddForceTimeScale(timeScale, "ExtraEffect.SyncTimeScale", true, sourceType);
			}
		}
	}

	// Token: 0x06019C9C RID: 105628 RVA: 0x006B9928 File Offset: 0x006B7B28
	public bool CanRelease()
	{
		return this.OwnerIds.Count <= 0;
	}

	// Token: 0x0400C266 RID: 49766
	private const string ForceTimeScaleLockKey = "ExtraEffect.SyncTimeScale";

	// Token: 0x0400C267 RID: 49767
	private readonly Dictionary<int, CharacterTimeScaleComponent> OwnerIds = new Dictionary<int, CharacterTimeScaleComponent>();

	// Token: 0x0400C268 RID: 49768
	[Nullable(2)]
	public readonly CharacterTimeScaleComponent InstigatorTimeScaleComp;

	// Token: 0x0400C269 RID: 49769
	public readonly EntityHandle InstigatorHandle;

	// Token: 0x0400C26A RID: 49770
	private readonly long BuffId;
}
