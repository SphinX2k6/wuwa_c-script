using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02002726 RID: 10022
[NullableContext(1)]
[Nullable(0)]
public class ActorDebugMovementComponent : EntityComponent
{
	// Token: 0x0601922E RID: 102958 RVA: 0x007A94AC File Offset: 0x007A76AC
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
		this.IsDebug = false;
		if (this.ActorComp != null)
		{
			this.InspectionType = this.InspectionTypeList.Contains(this.ActorComp.CreatureData.GetEntityType());
			this.LastRecordLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		}
		return true;
	}

	// Token: 0x0601922F RID: 102959 RVA: 0x007A9514 File Offset: 0x007A7714
	public void SetDebug(bool newDebug)
	{
		if (this.IsDebug == newDebug)
		{
			return;
		}
		this.IsDebug = newDebug;
		if (this.IsDebug)
		{
			BaseActorComponent actorComp = this.ActorComp;
			if (((actorComp != null) ? actorComp.Owner : null) != null)
			{
				this.UeDebugComp = (this.ActorComp.Owner.AddComponentByClass(UKuroDebugMovementComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UKuroDebugMovementComponent);
			}
			this.UeDebugComp.Resigter();
		}
	}

	// Token: 0x06019230 RID: 102960 RVA: 0x007A9594 File Offset: 0x007A7794
	public unsafe void MarkDebugRecord(string context, EKDMRecordType? type = 15, bool noInspection = false)
	{
		if (this.InspectionType && this.ActorComp != null)
		{
			if (!noInspection && global::Vector.DistSquared(this.LastRecordLocation, this.ActorComp.ActorLocationProxy) > 25000000.0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "MarkDebugRecord 移动距离超五十米";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", this.ActorComp.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Context", context);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("From", this.LastRecordLocation);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("To", this.ActorComp.ActorLocationProxy);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Actor", this.ActorComp.Owner);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			}
			this.LastRecordLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		}
		if (this.IsDebug)
		{
			string[] array = new string[5];
			array[0] = "[PbDataId:";
			int num = 1;
			BaseActorComponent actorComp = this.ActorComp;
			array[num] = ((actorComp != null) ? actorComp.CreatureData.GetPbDataId().ToString() : null);
			array[2] = "][CreatureDataId:";
			int num2 = 3;
			BaseActorComponent actorComp2 = this.ActorComp;
			array[num2] = ((actorComp2 != null) ? actorComp2.CreatureData.GetCreatureDataId().ToString() : null);
			array[4] = "]";
			string str = string.Concat(array);
			this.UeDebugComp.RecordModifyInfo(context + str, default(FVector), type.GetValueOrDefault(EKDMRecordType.KDM_ALL));
		}
	}

	// Token: 0x06019231 RID: 102961 RVA: 0x007A9782 File Offset: 0x007A7982
	public static void StaticMarkDebugRecord(Entity entity, string context, EKDMRecordType type = EKDMRecordType.KDM_ALL, global::Vector customVector = null)
	{
		entity.GetComponent<ActorDebugMovementComponent>().MarkDebugRecord(context, new EKDMRecordType?(type), false);
	}

	// Token: 0x06019232 RID: 102962 RVA: 0x007A9798 File Offset: 0x007A7998
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		ActorDebugMovementComponent actorDebugMovementComponent = (ActorDebugMovementComponent)componentTemplate;
		if (actorDebugMovementComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (actorDebugMovementComponent.UeDebugComp == null)
		{
			this.UeDebugComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UeDebugComp), "UeDebugComp"))
		{
			return false;
		}
		this.IsDebug = actorDebugMovementComponent.IsDebug;
		if (actorDebugMovementComponent.LastRecordLocation == null)
		{
			this.LastRecordLocation = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastRecordLocation), "LastRecordLocation"))
		{
			return false;
		}
		this.InspectionType = actorDebugMovementComponent.InspectionType;
		return actorDebugMovementComponent.InspectionTypeList == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.InspectionTypeList), "InspectionTypeList");
	}

	// Token: 0x170027F4 RID: 10228
	// (get) Token: 0x06019233 RID: 102963 RVA: 0x007A9873 File Offset: 0x007A7A73
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DB8E RID: 56206
	private const float WARNING_THRESHOLD_SQUARED = 25000000f;

	// Token: 0x0400DB8F RID: 56207
	[Nullable(2)]
	public BaseActorComponent ActorComp;

	// Token: 0x0400DB90 RID: 56208
	[Nullable(2)]
	public UKuroDebugMovementComponent UeDebugComp;

	// Token: 0x0400DB91 RID: 56209
	public bool IsDebug;

	// Token: 0x0400DB92 RID: 56210
	public global::Vector LastRecordLocation = global::Vector.Create();

	// Token: 0x0400DB93 RID: 56211
	private bool InspectionType;

	// Token: 0x0400DB94 RID: 56212
	private readonly List<EEntityType> InspectionTypeList = new List<EEntityType>
	{
		EEntityType.Monster,
		EEntityType.Player,
		EEntityType.Npc,
		EEntityType.Vehicle
	};
}
