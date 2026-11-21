using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x020024A7 RID: 9383
[NullableContext(1)]
[Nullable(0)]
public class SyncTimescaleGroup
{
	// Token: 0x060175A0 RID: 95648 RVA: 0x006DF9C8 File Offset: 0x006DDBC8
	public SyncTimescaleGroup(EntityHandle instigatorHandle, long buffId)
	{
		this.InstigatorHandle = instigatorHandle;
		this.BuffId = buffId;
		WorldEntity entity = this.InstigatorHandle.Entity;
		this.InstigatorTimeScaleComp = ((entity != null) ? entity.GetComponent<CharacterTimeScaleComponent>() : null);
		EventSystem.Instance.AddWithTarget(this.InstigatorHandle.Entity, EEventName.CharBeHitTimeScale, new Action<float, ETimeScaleSourceType>(this.OnInstigatorTimeScaleChanged));
	}

	// Token: 0x060175A1 RID: 95649 RVA: 0x006DFA35 File Offset: 0x006DDC35
	public void Release()
	{
		if (this.InstigatorHandle.Valid)
		{
			EventSystem.Instance.RemoveWithTarget(this.InstigatorHandle.Entity, EEventName.CharBeHitTimeScale, new Action<float, ETimeScaleSourceType>(this.OnInstigatorTimeScaleChanged));
		}
	}

	// Token: 0x060175A2 RID: 95650 RVA: 0x006DFA68 File Offset: 0x006DDC68
	public bool HasOwner(int ownerId)
	{
		return this.OwnerIds.ContainsKey(ownerId);
	}

	// Token: 0x060175A3 RID: 95651 RVA: 0x006DFA78 File Offset: 0x006DDC78
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

	// Token: 0x060175A4 RID: 95652 RVA: 0x006DFB7F File Offset: 0x006DDD7F
	public string GetOwnerInfo()
	{
		return string.Join<int>(",", this.OwnerIds.Keys);
	}

	// Token: 0x060175A5 RID: 95653 RVA: 0x006DFB98 File Offset: 0x006DDD98
	public void RemoveOwner(int entityId)
	{
		CharacterTimeScaleComponent characterTimeScaleComponent;
		if (this.OwnerIds.TryGetValue(entityId, out characterTimeScaleComponent) && characterTimeScaleComponent.Valid)
		{
			characterTimeScaleComponent.RemoveForceTimeScale("ExtraEffect.SyncTimeScale", true);
		}
		this.OwnerIds.Remove(entityId);
	}

	// Token: 0x060175A6 RID: 95654 RVA: 0x006DFBD8 File Offset: 0x006DDDD8
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

	// Token: 0x060175A7 RID: 95655 RVA: 0x006DFC44 File Offset: 0x006DDE44
	public bool CanRelease()
	{
		return this.OwnerIds.Count <= 0;
	}

	// Token: 0x0400C608 RID: 50696
	private const string ForceTimeScaleLockKey = "ExtraEffect.SyncTimeScale";

	// Token: 0x0400C609 RID: 50697
	private readonly Dictionary<int, CharacterTimeScaleComponent> OwnerIds = new Dictionary<int, CharacterTimeScaleComponent>();

	// Token: 0x0400C60A RID: 50698
	[Nullable(2)]
	public readonly CharacterTimeScaleComponent InstigatorTimeScaleComp;

	// Token: 0x0400C60B RID: 50699
	public readonly EntityHandle InstigatorHandle;

	// Token: 0x0400C60C RID: 50700
	private readonly long BuffId;
}
