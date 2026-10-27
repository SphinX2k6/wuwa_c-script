using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x02002F53 RID: 12115
[NullableContext(1)]
[Nullable(0)]
public class SyncTimeScaleEffect : BuffEffect, IStaticVariableResetter
{
	// Token: 0x06019C8A RID: 105610 RVA: 0x006B938A File Offset: 0x006B758A
	static SyncTimeScaleEffect()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SyncTimeScaleEffect.CreateStaticDefaultValue), new Action(SyncTimeScaleEffect.ResetStaticDefaultValue));
	}

	// Token: 0x170023AF RID: 9135
	// (get) Token: 0x06019C8B RID: 105611 RVA: 0x006B93A9 File Offset: 0x006B75A9
	private static Dictionary<int, SyncTimescaleGroup> AllGroups
	{
		get
		{
			return SyncTimeScaleEffect._allGroups;
		}
	}

	// Token: 0x06019C8C RID: 105612 RVA: 0x006B93B0 File Offset: 0x006B75B0
	public static void CreateStaticDefaultValue()
	{
		SyncTimeScaleEffect._allGroups = new Dictionary<int, SyncTimescaleGroup>();
	}

	// Token: 0x06019C8D RID: 105613 RVA: 0x006B93BC File Offset: 0x006B75BC
	public static void ResetStaticDefaultValue()
	{
		SyncTimeScaleEffect._allGroups = null;
	}

	// Token: 0x06019C8E RID: 105614 RVA: 0x006B93C4 File Offset: 0x006B75C4
	public SyncTimeScaleEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019C8F RID: 105615 RVA: 0x006B93DE File Offset: 0x006B75DE
	private bool CheckConflict()
	{
		return false;
	}

	// Token: 0x06019C90 RID: 105616 RVA: 0x006B93E4 File Offset: 0x006B75E4
	public unsafe override void OnCreated()
	{
		if (this.InstigatorEntityId != base.OwnerEntity.Id)
		{
			EntityHandle instigatorEntity = base.InstigatorEntity;
			if (instigatorEntity != null && instigatorEntity.Valid && !this.CheckConflict())
			{
				this.OwnerId = base.OwnerEntity.Id;
				SyncTimescaleGroup syncTimescaleGroup;
				if (!SyncTimeScaleEffect.AllGroups.TryGetValue(this.InstigatorEntityId, out syncTimescaleGroup))
				{
					syncTimescaleGroup = new SyncTimescaleGroup(base.InstigatorEntity, this.BuffId);
					SyncTimeScaleEffect.AllGroups[this.InstigatorEntityId] = syncTimescaleGroup;
				}
				this.Group = syncTimescaleGroup;
				syncTimescaleGroup.AddOwner(base.OwnerEntity);
				return;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.BuffItem;
		ELogAuthor author = ELogAuthor.HCW;
		string message = "顿帧同步效果 OnCreated";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Buff", this.BuffId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Instigator", base.OwnerEntity.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Owner", base.OwnerEntity.Id);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
		string item = "Instigator.Valid";
		EntityHandle instigatorEntity2 = base.InstigatorEntity;
		ptr = new ValueTuple<string, object>(item, (instigatorEntity2 != null) ? new bool?(instigatorEntity2.Valid) : null);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		this.SameEntityError = true;
	}

	// Token: 0x06019C91 RID: 105617 RVA: 0x006B9557 File Offset: 0x006B7757
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019C92 RID: 105618 RVA: 0x006B955C File Offset: 0x006B775C
	public override void OnRemoved(bool bPremature)
	{
		if (this.Group == null || this.SameEntityError)
		{
			return;
		}
		foreach (int id in this.TimeScaleIdSet)
		{
			this.RemoveTimeScale(id, false);
		}
		this.TimeScaleIdSet.Clear();
		this.Group.RemoveOwner(this.OwnerId);
		if (this.Group.CanRelease())
		{
			this.Group.Release();
			SyncTimeScaleEffect.AllGroups.Remove(this.InstigatorEntityId);
		}
		this.Group = null;
	}

	// Token: 0x06019C93 RID: 105619 RVA: 0x006B9610 File Offset: 0x006B7810
	[NullableContext(2)]
	public int SetTimeScale(int priority, float timeDilation, UCurveFloat curve, float duration, ETimeScaleSourceType sourceType, bool needAddSceneItemTag = false, bool immuneSelfCenter = false)
	{
		SyncTimescaleGroup group = this.Group;
		bool flag;
		if (group == null)
		{
			flag = false;
		}
		else
		{
			CharacterTimeScaleComponent instigatorTimeScaleComp = group.InstigatorTimeScaleComp;
			flag = ((instigatorTimeScaleComp != null) ? new bool?(instigatorTimeScaleComp.Valid) : null).GetValueOrDefault();
		}
		if (flag)
		{
			int num = this.Group.InstigatorTimeScaleComp.SetTimeScale(priority, timeDilation, curve, duration, sourceType, needAddSceneItemTag, immuneSelfCenter);
			this.TimeScaleIdSet.Add(num);
			return num;
		}
		return 0;
	}

	// Token: 0x06019C94 RID: 105620 RVA: 0x006B967E File Offset: 0x006B787E
	public void RemoveTimeScale(int id, bool deleteTimeScaleId = true)
	{
		if (deleteTimeScaleId)
		{
			this.TimeScaleIdSet.Remove(id);
		}
		SyncTimescaleGroup group = this.Group;
		if (group == null)
		{
			return;
		}
		CharacterTimeScaleComponent instigatorTimeScaleComp = group.InstigatorTimeScaleComp;
		if (instigatorTimeScaleComp == null)
		{
			return;
		}
		instigatorTimeScaleComp.RemoveTimeScale(id);
	}

	// Token: 0x0400C261 RID: 49761
	[Nullable(2)]
	public SyncTimescaleGroup Group;

	// Token: 0x0400C262 RID: 49762
	private int OwnerId;

	// Token: 0x0400C263 RID: 49763
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, SyncTimescaleGroup> _allGroups;

	// Token: 0x0400C264 RID: 49764
	private bool SameEntityError;

	// Token: 0x0400C265 RID: 49765
	private readonly HashSet<int> TimeScaleIdSet = new HashSet<int>();
}
