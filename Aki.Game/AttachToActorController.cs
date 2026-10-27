using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.CreatureTools;
using UnrealEngine;

// Token: 0x020034D4 RID: 13524
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class AttachToActorController : ControllerBase
{
	// Token: 0x0601D8BE RID: 121022 RVA: 0x0083E06C File Offset: 0x0083C26C
	[NullableContext(2)]
	public unsafe bool AttachToActor(AActor actor, AActor parentActor, EDetachType detachType, [Nullable(1)] string reason, FName? socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies, bool doAttach = true, bool ignoreTargetLocationX = false, bool ignoreTargetLocationY = false, bool ignoreTargetLocationZ = false)
	{
		if (string.IsNullOrEmpty(reason))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "AttachToActor的Reason不能使用undefined";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Entity", "AttachToActorController");
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (reason.Length < 4)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "AttachToActor的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (actor == null || !actor.IsValid())
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.LFJW;
			string message3 = "actor无效";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Reason", reason);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		if (parentActor == null || !parentActor.IsValid())
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Entity;
			ELogAuthor author4 = ELogAuthor.LFJW;
			string message4 = "parentActor无效";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Reason", reason);
			instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return false;
		}
		IBPI_CreatureInterface_C ibpi_CreatureInterface_C = parentActor as IBPI_CreatureInterface_C;
		if (ibpi_CreatureInterface_C == null)
		{
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.Entity;
			ELogAuthor author5 = ELogAuthor.LFJW;
			string message5 = "parentActor未实现接口CreatureInterface";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ActorName", parentActor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Reason", reason);
			instance5.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return false;
		}
		int entityId = ibpi_CreatureInterface_C.GetEntityId();
		if (entityId == 0)
		{
			Log instance6 = Log.Instance;
			ELogModule module6 = ELogModule.Entity;
			ELogAuthor author6 = ELogAuthor.LFJW;
			string message6 = "entityId无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("ActorName", parentActor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Reason", reason);
			instance6.Error(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return false;
		}
		AttachToActorModel instance7 = AttachToActorModel.Instance;
		if (!instance7.AddEntityActor(entityId, actor, parentActor, reason, detachType))
		{
			Log instance8 = Log.Instance;
			ELogModule module7 = ELogModule.Entity;
			ELogAuthor author7 = ELogAuthor.LFJW;
			string message7 = "actor添加失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("ActorName", parentActor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("Reason", reason);
			instance8.Error(module7, author7, message7, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
			return false;
		}
		if (doAttach && !this.TryAttachToActor(actor, parentActor, socketName, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies, ignoreTargetLocationX, ignoreTargetLocationY, ignoreTargetLocationZ))
		{
			this.RemoveEntityActorAfterAttachFailed(instance7, entityId, actor, reason);
			return false;
		}
		actor.OnEndPlay.Add(new Action<AActor, TEnumAsByte<EEndPlayReason>>(this.OnEndPlay));
		return true;
	}

	// Token: 0x0601D8BF RID: 121023 RVA: 0x0083E300 File Offset: 0x0083C500
	[NullableContext(2)]
	public unsafe bool AttachToComponent(AActor actor, USceneComponent parentComponent, EDetachType detachType, [Nullable(1)] string reason, FName? socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies, bool doAttach = true, bool ignoreTargetLocationX = false, bool ignoreTargetLocationY = false, bool ignoreTargetLocationZ = false)
	{
		if (string.IsNullOrEmpty(reason))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "AttachToComponent的Reason不能使用undefined";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Entity", typeof(AttachToActorController).Name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (reason.Length < 4)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "AttachToComponent的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (actor == null || !actor.IsValid())
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.LFJW;
			string message3 = "actor无效";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Reason", reason);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		if (parentComponent == null || !parentComponent.IsValid())
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Entity;
			ELogAuthor author4 = ELogAuthor.LFJW;
			string message4 = "parentComponent无效";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Reason", reason);
			instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return false;
		}
		AActor owner = parentComponent.GetOwner();
		if (owner == null || !owner.IsValid())
		{
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.Entity;
			ELogAuthor author5 = ELogAuthor.LFJW;
			string message5 = "parentActor无效";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("Reason", reason);
			instance5.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			return false;
		}
		IBPI_CreatureInterface_C ibpi_CreatureInterface_C = owner as IBPI_CreatureInterface_C;
		if (ibpi_CreatureInterface_C == null)
		{
			Log instance6 = Log.Instance;
			ELogModule module6 = ELogModule.Entity;
			ELogAuthor author6 = ELogAuthor.LFJW;
			string message6 = "ParentActor未实现接口CreatureInterface";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ActorName", owner.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Reason", reason);
			instance6.Error(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return false;
		}
		int entityId = ibpi_CreatureInterface_C.GetEntityId();
		if (entityId == 0)
		{
			Log instance7 = Log.Instance;
			ELogModule module7 = ELogModule.Entity;
			ELogAuthor author7 = ELogAuthor.LFJW;
			string message7 = "entityId无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("ActorName", owner.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Reason", reason);
			instance7.Error(module7, author7, message7, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return false;
		}
		AttachToActorModel instance8 = AttachToActorModel.Instance;
		if (!instance8.AddEntityActor(entityId, actor, owner, reason, detachType))
		{
			Log instance9 = Log.Instance;
			ELogModule module8 = ELogModule.Entity;
			ELogAuthor author8 = ELogAuthor.LFJW;
			string message8 = "actor添加失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("ActorName", owner.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("Reason", reason);
			instance9.Error(module8, author8, message8, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
			return false;
		}
		if (doAttach && !this.TryAttachToComponent(actor, parentComponent, socketName, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies, ignoreTargetLocationX, ignoreTargetLocationY, ignoreTargetLocationZ))
		{
			this.RemoveEntityActorAfterAttachFailed(instance8, entityId, actor, reason);
			return false;
		}
		actor.OnEndPlay.Add(new Action<AActor, TEnumAsByte<EEndPlayReason>>(this.OnEndPlay));
		return true;
	}

	// Token: 0x0601D8C0 RID: 121024 RVA: 0x0083E5E0 File Offset: 0x0083C7E0
	[NullableContext(0)]
	private unsafe void OnEndPlay([Nullable(2)] AActor actor, TEnumAsByte<EEndPlayReason> reason)
	{
		if (actor == null)
		{
			return;
		}
		EEndPlayReason eendPlayReason = reason;
		if (eendPlayReason == EEndPlayReason.EndPlayInEditor || eendPlayReason == EEndPlayReason.Quit)
		{
			return;
		}
		AttachToActorModel instance = AttachToActorModel.Instance;
		if (instance == null)
		{
			return;
		}
		int entityIdByActor = instance.GetEntityIdByActor(actor);
		AttachActorItem attachActorItem = instance.GetAttachActorItem(entityIdByActor, actor);
		if (attachActorItem == null)
		{
			return;
		}
		EDetachType? detachType = attachActorItem.DetachType;
		if (detachType != null)
		{
			EDetachType valueOrDefault = detachType.GetValueOrDefault();
			if (valueOrDefault > EDetachType.EntityDestroy)
			{
				if (valueOrDefault == EDetachType.DestroyExternal)
				{
					this.DetachActorByEntity(actor, "AttachToActorController.OnEndPlay DestroyExternal", entityIdByActor, false, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
					return;
				}
			}
			else
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "非法删除Attach的Actor";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", entityIdByActor);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActorName", attachActorItem.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ParentActorName", attachActorItem.ParentActorName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("DetachType", attachActorItem.DetachType);
				instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				this.DetachActorByEntity(actor, "AttachToActorController.OnEndPlay ManualDestroy", entityIdByActor, false, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
			}
		}
	}

	// Token: 0x0601D8C1 RID: 121025 RVA: 0x0083E710 File Offset: 0x0083C910
	public unsafe bool DetachActor([Nullable(2)] AActor srcActor, bool destroy, string reason, EDetachmentRule locationRule, EDetachmentRule rotationRule, EDetachmentRule scaleRule)
	{
		if (string.IsNullOrEmpty(reason))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "AttachActor: RemoveActor的Reason不能使用undefined";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Entity", typeof(AttachToActorController).Name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (reason.Length < 4)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "AttachActor: RemoveActor的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (srcActor == null || !srcActor.IsValid())
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.LFJW;
			string message3 = "srcActor无效";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Reason", reason);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		AActor attachParentActor = srcActor.GetAttachParentActor();
		if (attachParentActor == null || !attachParentActor.IsValid())
		{
			int entityIdByActor = AttachToActorModel.Instance.GetEntityIdByActor(srcActor);
			if (entityIdByActor != 0)
			{
				return this.DetachActorByEntity(srcActor, reason, entityIdByActor, destroy, locationRule, rotationRule, scaleRule);
			}
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Entity;
			ELogAuthor author4 = ELogAuthor.LFJW;
			string message4 = "AttachActor: entityActor无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Name", srcActor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Reason", reason);
			instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return false;
		}
		else
		{
			IBPI_CreatureInterface_C ibpi_CreatureInterface_C = attachParentActor as IBPI_CreatureInterface_C;
			if (ibpi_CreatureInterface_C == null)
			{
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.Entity;
				ELogAuthor author5 = ELogAuthor.LFJW;
				string message5 = "AttachActor: Actor未实现接口CreatureInterface";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("ActorName", attachParentActor.GetName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Reason", reason);
				instance5.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				return false;
			}
			int entityId = ibpi_CreatureInterface_C.GetEntityId();
			if (entityId == 0)
			{
				Log instance6 = Log.Instance;
				ELogModule module6 = ELogModule.Entity;
				ELogAuthor author6 = ELogAuthor.LFJW;
				string message6 = "AttachActor: entityId无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("ActorName", attachParentActor.GetName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("Reason", reason);
				instance6.Error(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
				return false;
			}
			return this.DetachActorByEntity(srcActor, reason, entityId, destroy, locationRule, rotationRule, scaleRule);
		}
	}

	// Token: 0x0601D8C2 RID: 121026 RVA: 0x0083E960 File Offset: 0x0083CB60
	public unsafe bool DetachActorByEntity([Nullable(2)] AActor srcActor, string reason, int entityId, bool destroy, EDetachmentRule locationRule, EDetachmentRule rotationRule, EDetachmentRule scaleRule)
	{
		if (string.IsNullOrEmpty(reason))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "AttachActor: RemoveActor的Reason不能使用undefined";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Entity", typeof(AttachToActorController).Name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (reason.Length < 4)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "AttachActor: RemoveActor的Reason字符串长度必须大于等于限制字符数量";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("限制的字符数量", 4);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (srcActor == null || !srcActor.IsValid())
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Entity;
			ELogAuthor author3 = ELogAuthor.LFJW;
			string message3 = "srcActor无效";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Reason", reason);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		if (entityId == 0)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Entity;
			ELogAuthor author4 = ELogAuthor.LFJW;
			string message4 = "AttachActor: entityId无效";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", entityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ActorName", srcActor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Reason", reason);
			instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return false;
		}
		AttachToActorModel instance5 = AttachToActorModel.Instance;
		if (instance5.GetAttachActorItem(entityId, srcActor) == null)
		{
			Log instance6 = Log.Instance;
			ELogModule module5 = ELogModule.Entity;
			ELogAuthor author5 = ELogAuthor.LFJW;
			string message5 = "AttachActor: attachActorItem无效";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("EntityId", entityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("ActorName", srcActor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("Reason", reason);
			instance6.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			return false;
		}
		srcActor.OnEndPlay.Remove(new Action<AActor, TEnumAsByte<EEndPlayReason>>(this.OnEndPlay));
		if (!instance5.RemoveEntityActor(entityId, srcActor, reason))
		{
			Log instance7 = Log.Instance;
			ELogModule module6 = ELogModule.Entity;
			ELogAuthor author6 = ELogAuthor.LFJW;
			string message6 = "AttachActor: Detach Actor 失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("EntityId", entityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("ActorName", srcActor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("Reason", reason);
			instance7.Error(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
			return false;
		}
		if (destroy)
		{
			this.ClearLocationAxisFilteredAttach(srcActor);
			srcActor.K2_DestroyActor();
			return true;
		}
		this.ClearLocationAxisFilteredAttach(srcActor);
		srcActor.K2_DetachFromActor(locationRule, rotationRule, scaleRule);
		return true;
	}

	// Token: 0x0601D8C3 RID: 121027 RVA: 0x0083EC04 File Offset: 0x0083CE04
	public bool DetachActorsBeforeDestroyEntity(EntityHandle handle)
	{
		if (handle == null || !handle.Valid)
		{
			return true;
		}
		AttachActorEntry attachActorEntry = AttachToActorModel.Instance.GetAttachActorEntry(handle.Id);
		if (attachActorEntry == null)
		{
			return true;
		}
		IReadOnlyList<AttachActorItem> attachActorItems = attachActorEntry.GetAttachActorItems();
		if (attachActorItems == null || attachActorItems.Count == 0)
		{
			return true;
		}
		bool result = true;
		for (int i = attachActorItems.Count - 1; i >= 0; i--)
		{
			AttachActorItem attachActorItem = attachActorItems[i];
			if (attachActorItem.DetachType.GetValueOrDefault() == EDetachType.EntityDestroy)
			{
				AActor actor = attachActorItem.Actor;
				if (actor != null && actor.IsValid() && !this.DetachActorByEntity(attachActorItem.Actor, "AttachToActorController.DetachActorsBeforeDestroyEntity", handle.Id, true, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld))
				{
					result = false;
				}
			}
		}
		return result;
	}

	// Token: 0x0601D8C4 RID: 121028 RVA: 0x0083ECB4 File Offset: 0x0083CEB4
	public unsafe bool DetachActorsAfterDestroyEntity(int entityId)
	{
		AttachActorEntry attachActorEntry = AttachToActorModel.Instance.GetAttachActorEntry(entityId);
		if (attachActorEntry == null)
		{
			return true;
		}
		IReadOnlyList<AttachActorItem> attachActorItems = attachActorEntry.GetAttachActorItems();
		if (attachActorItems == null || attachActorItems.Count == 0)
		{
			return true;
		}
		bool result = true;
		for (int i = attachActorItems.Count - 1; i >= 0; i--)
		{
			AttachActorItem attachActorItem = attachActorItems[i];
			EDetachType? detachType = attachActorItem.DetachType;
			EDetachType edetachType = EDetachType.ManualDestroy;
			if (detachType.GetValueOrDefault() == edetachType & detachType != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "AttachActor: 存在未类型为ManualDestroy未Detach的Actor";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", entityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActorName", attachActorItem.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ParentActorName", attachActorItem.ParentActorName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Reason", attachActorItem.Reason);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				AActor actor = attachActorItem.Actor;
				if (actor != null && actor.IsValid() && !this.DetachActorByEntity(attachActorItem.Actor, "AttachToActorController.DetachActorsAfterDestroyEntity", entityId, true, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld))
				{
					result = false;
				}
			}
		}
		return result;
	}

	// Token: 0x0601D8C5 RID: 121029 RVA: 0x0083EE00 File Offset: 0x0083D000
	public unsafe bool CheckAttachError(int entityId)
	{
		AttachToActorModel instance = AttachToActorModel.Instance;
		AttachActorEntry attachActorEntry = instance.GetAttachActorEntry(entityId);
		if (attachActorEntry == null)
		{
			return true;
		}
		IReadOnlyList<AttachActorItem> attachActorItems = attachActorEntry.GetAttachActorItems();
		if (attachActorItems == null || attachActorItems.Count == 0)
		{
			return true;
		}
		int count = attachActorItems.Count;
		bool result = true;
		for (int i = count - 1; i >= 0; i--)
		{
			AttachActorItem attachActorItem = attachActorItems[i];
			result = false;
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "AttachActor: Attach的Actor没有删除";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", entityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActorName", attachActorItem.Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ParentActorName", attachActorItem.ParentActorName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Reason", attachActorItem.Reason);
			instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			AActor actor = attachActorItem.Actor;
			if (actor != null && actor.IsValid())
			{
				this.DetachActorByEntity(attachActorItem.Actor, "AttachToActorController.CheckAttachError", attachActorItem.EntityId, true, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
			}
		}
		instance.ClearActorsByEntity(entityId);
		return result;
	}

	// Token: 0x0601D8C6 RID: 121030 RVA: 0x0083EF38 File Offset: 0x0083D138
	private bool TryAttachToActor(AActor actor, AActor parentActor, FName? socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies, bool ignoreTargetLocationX, bool ignoreTargetLocationY, bool ignoreTargetLocationZ)
	{
		if (this.HasLocationAxisFilter(ignoreTargetLocationX, ignoreTargetLocationY, ignoreTargetLocationZ))
		{
			FName fname = socketName ?? FName.NAME_None;
			return UKuroAttachLibrary.KuroAttachToActorWithLocationAxisFilter(actor, parentActor, fname, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies, ignoreTargetLocationX, ignoreTargetLocationY, ignoreTargetLocationZ);
		}
		this.ClearLocationAxisFilteredAttach(actor);
		actor.K2_AttachToActor(parentActor, socketName ?? FName.NAME_None, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies, true);
		return true;
	}

	// Token: 0x0601D8C7 RID: 121031 RVA: 0x0083EFB8 File Offset: 0x0083D1B8
	private bool TryAttachToComponent(AActor actor, USceneComponent parentComponent, FName? socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies, bool ignoreTargetLocationX, bool ignoreTargetLocationY, bool ignoreTargetLocationZ)
	{
		if (this.HasLocationAxisFilter(ignoreTargetLocationX, ignoreTargetLocationY, ignoreTargetLocationZ))
		{
			FName fname = socketName ?? FName.NAME_None;
			return UKuroAttachLibrary.KuroAttachToComponentWithLocationAxisFilter(actor, parentComponent, fname, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies, ignoreTargetLocationX, ignoreTargetLocationY, ignoreTargetLocationZ);
		}
		this.ClearLocationAxisFilteredAttach(actor);
		actor.K2_AttachToComponent(parentComponent, socketName ?? FName.NAME_None, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies, true);
		return true;
	}

	// Token: 0x0601D8C8 RID: 121032 RVA: 0x0083F036 File Offset: 0x0083D236
	private bool HasLocationAxisFilter(bool ignoreTargetLocationX, bool ignoreTargetLocationY, bool ignoreTargetLocationZ)
	{
		return ignoreTargetLocationX || ignoreTargetLocationY || ignoreTargetLocationZ;
	}

	// Token: 0x0601D8C9 RID: 121033 RVA: 0x0083F03D File Offset: 0x0083D23D
	private void RemoveEntityActorAfterAttachFailed(AttachToActorModel attachToActorModel, int entityId, AActor actor, string reason)
	{
		this.ClearLocationAxisFilteredAttach(actor);
		attachToActorModel.RemoveEntityActor(entityId, actor, reason + " AttachFailed");
	}

	// Token: 0x0601D8CA RID: 121034 RVA: 0x0083F05B File Offset: 0x0083D25B
	private void ClearLocationAxisFilteredAttach(AActor actor)
	{
		UKuroAttachLibrary.ClearKuroLocationAxisFilteredAttach(actor);
	}

	// Token: 0x170028DC RID: 10460
	// (get) Token: 0x0601D8CB RID: 121035 RVA: 0x0083F063 File Offset: 0x0083D263
	public static AttachToActorController Instance
	{
		get
		{
			return AttachToActorController._Instance;
		}
	}

	// Token: 0x0601D8CC RID: 121036 RVA: 0x0083F06A File Offset: 0x0083D26A
	public static AttachToActorController GetOrCreateInstance()
	{
		if (AttachToActorController._Instance == null)
		{
			AttachToActorController.CreateInstance();
		}
		return AttachToActorController._Instance;
	}

	// Token: 0x0601D8CD RID: 121037 RVA: 0x0083F07E File Offset: 0x0083D27E
	public static bool CreateInstance()
	{
		if (AttachToActorController._Instance != null)
		{
			return true;
		}
		AttachToActorController._Instance = new AttachToActorController();
		return true;
	}

	// Token: 0x0601D8CE RID: 121038 RVA: 0x0083F094 File Offset: 0x0083D294
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601D8CF RID: 121039 RVA: 0x0083F096 File Offset: 0x0083D296
	public static void ResetStaticDefaultValue()
	{
		AttachToActorController._Instance = null;
	}

	// Token: 0x0601D8D0 RID: 121040 RVA: 0x0083F09E File Offset: 0x0083D29E
	static AttachToActorController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AttachToActorController.CreateStaticDefaultValue), new Action(AttachToActorController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E828 RID: 59432
	private const int ATTACH_REASON_LENGTH_LIMIT = 4;

	// Token: 0x0400E829 RID: 59433
	[Nullable(2)]
	private static AttachToActorController _Instance;
}
