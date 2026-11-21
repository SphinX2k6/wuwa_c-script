using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x020024A6 RID: 9382
[NullableContext(1)]
[Nullable(0)]
public class SyncTimeScaleEffect : BuffEffect, IStaticVariableResetter
{
	// Token: 0x06017595 RID: 95637 RVA: 0x006DF6A6 File Offset: 0x006DD8A6
	static SyncTimeScaleEffect()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SyncTimeScaleEffect.CreateStaticDefaultValue), new Action(SyncTimeScaleEffect.ResetStaticDefaultValue));
	}

	// Token: 0x17002471 RID: 9329
	// (get) Token: 0x06017596 RID: 95638 RVA: 0x006DF6C5 File Offset: 0x006DD8C5
	private static Dictionary<int, SyncTimescaleGroup> AllGroups
	{
		get
		{
			return SyncTimeScaleEffect._allGroups;
		}
	}

	// Token: 0x06017597 RID: 95639 RVA: 0x006DF6CC File Offset: 0x006DD8CC
	public static void CreateStaticDefaultValue()
	{
		SyncTimeScaleEffect._allGroups = new Dictionary<int, SyncTimescaleGroup>();
	}

	// Token: 0x06017598 RID: 95640 RVA: 0x006DF6D8 File Offset: 0x006DD8D8
	public static void ResetStaticDefaultValue()
	{
		SyncTimeScaleEffect._allGroups = null;
	}

	// Token: 0x06017599 RID: 95641 RVA: 0x006DF6E0 File Offset: 0x006DD8E0
	public SyncTimeScaleEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x0601759A RID: 95642 RVA: 0x006DF6FA File Offset: 0x006DD8FA
	private bool CheckConflict()
	{
		return false;
	}

	// Token: 0x0601759B RID: 95643 RVA: 0x006DF700 File Offset: 0x006DD900
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

	// Token: 0x0601759C RID: 95644 RVA: 0x006DF873 File Offset: 0x006DDA73
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x0601759D RID: 95645 RVA: 0x006DF878 File Offset: 0x006DDA78
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

	// Token: 0x0601759E RID: 95646 RVA: 0x006DF92C File Offset: 0x006DDB2C
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

	// Token: 0x0601759F RID: 95647 RVA: 0x006DF99A File Offset: 0x006DDB9A
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

	// Token: 0x0400C603 RID: 50691
	[Nullable(2)]
	public SyncTimescaleGroup Group;

	// Token: 0x0400C604 RID: 50692
	private int OwnerId;

	// Token: 0x0400C605 RID: 50693
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, SyncTimescaleGroup> _allGroups;

	// Token: 0x0400C606 RID: 50694
	private bool SameEntityError;

	// Token: 0x0400C607 RID: 50695
	private readonly HashSet<int> TimeScaleIdSet = new HashSet<int>();
}
