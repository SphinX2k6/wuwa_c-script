using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200351A RID: 13594
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class AttachToActorModel : ModelBase
{
	// Token: 0x0601DCE0 RID: 122080 RVA: 0x0085A147 File Offset: 0x00858347
	protected override bool OnInit()
	{
		this.ShowLog = GlobalData.IsPlayInEditor;
		return true;
	}

	// Token: 0x0601DCE1 RID: 122081 RVA: 0x0085A158 File Offset: 0x00858358
	public unsafe bool AddEntityActor(int entityId, AActor actor, AActor parentActor, string reason, EDetachType detachType)
	{
		AttachActorEntry attachActorEntry;
		if (!this.AttachActorMap.TryGetValue(entityId, out attachActorEntry))
		{
			attachActorEntry = new AttachActorEntry();
			this.AttachActorMap[entityId] = attachActorEntry;
		}
		int num = this.AttachId + 1;
		this.AttachId = num;
		int num2 = num;
		if (!attachActorEntry.AddAttachActorItem(num2, entityId, actor, parentActor, reason, detachType))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "AttachActor: 重复AttachActor";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", entityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AttachId", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ActorName", actor);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Reason", reason);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return false;
		}
		if (this.ShowLog)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "AttachActor: 添加Attach数据";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("AttachId", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ActorName", actor);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("EntityId", entityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("ParentActorName", parentActor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("Reason", reason);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
		}
		this.ActorForEntityMap[actor] = entityId;
		return true;
	}

	// Token: 0x0601DCE2 RID: 122082 RVA: 0x0085A304 File Offset: 0x00858504
	public unsafe bool RemoveEntityActor(int entityId, AActor actor, string reason)
	{
		AttachActorEntry attachActorEntry;
		if (!this.AttachActorMap.TryGetValue(entityId, out attachActorEntry))
		{
			return false;
		}
		if (this.ShowLog)
		{
			AttachActorItem attachActorItem = attachActorEntry.GetAttachActorItem(actor);
			if (attachActorItem != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "AttachActor: 删除Attach数据";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AttachId", attachActorItem.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActorName", attachActorItem.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityId", attachActorItem.EntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ParentActorName", attachActorItem.ParentActorName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("AttachReason", attachActorItem.Reason);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Reason", reason);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			}
		}
		if (!attachActorEntry.RemoveAttachActorItem(actor))
		{
			return false;
		}
		if (attachActorEntry.Size() == 0)
		{
			this.AttachActorMap.Remove(entityId);
		}
		this.ActorForEntityMap.Remove(actor);
		return true;
	}

	// Token: 0x0601DCE3 RID: 122083 RVA: 0x0085A440 File Offset: 0x00858640
	public int GetEntityIdByActor(AActor actor)
	{
		int result;
		if (!this.ActorForEntityMap.TryGetValue(actor, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x0601DCE4 RID: 122084 RVA: 0x0085A460 File Offset: 0x00858660
	[NullableContext(2)]
	public AttachActorEntry GetAttachActorEntry(int entityId)
	{
		AttachActorEntry result;
		if (!this.AttachActorMap.TryGetValue(entityId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0601DCE5 RID: 122085 RVA: 0x0085A480 File Offset: 0x00858680
	[return: Nullable(2)]
	public AttachActorItem GetAttachActorItem(int entityId, AActor actor)
	{
		AttachActorEntry attachActorEntry;
		if (!this.AttachActorMap.TryGetValue(entityId, out attachActorEntry))
		{
			return null;
		}
		return attachActorEntry.GetAttachActorItem(actor);
	}

	// Token: 0x0601DCE6 RID: 122086 RVA: 0x0085A4A8 File Offset: 0x008586A8
	public unsafe void ClearActorsByEntity(int entityId)
	{
		AttachActorEntry attachActorEntry;
		if (!this.AttachActorMap.TryGetValue(entityId, out attachActorEntry))
		{
			return;
		}
		foreach (AttachActorItem attachActorItem in attachActorEntry.GetAttachActorItems())
		{
			AActor actor = attachActorItem.Actor;
			if (actor != null && actor.IsValid())
			{
				this.ActorForEntityMap.Remove(attachActorItem.Actor);
			}
			if (this.ShowLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "AttachActor: 删除Attach数据";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AttachId", attachActorItem.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActorName", attachActorItem.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityId", attachActorItem.EntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ParentActorName", attachActorItem.ParentActorName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("AttachReason", attachActorItem.Reason);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			}
		}
		attachActorEntry.Clear();
	}

	// Token: 0x0601DCE7 RID: 122087 RVA: 0x0085A608 File Offset: 0x00858808
	public unsafe void ClearEntityActor(string reason)
	{
		foreach (KeyValuePair<int, AttachActorEntry> keyValuePair in this.AttachActorMap)
		{
			if (this.ShowLog)
			{
				foreach (AttachActorItem attachActorItem in keyValuePair.Value.GetAttachActorItems())
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Entity;
					ELogAuthor author = ELogAuthor.LFJW;
					string message = "AttachActor: 删除Attach数据";
					<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AttachId", attachActorItem.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActorName", attachActorItem.Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityId", attachActorItem.EntityId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ParentActorName", attachActorItem.ParentActorName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("AttachReason", attachActorItem.Reason);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Reason", reason);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
				}
			}
			keyValuePair.Value.Clear();
		}
		this.AttachActorMap.Clear();
		this.ActorForEntityMap.Clear();
	}

	// Token: 0x0601DCE8 RID: 122088 RVA: 0x0085A7BC File Offset: 0x008589BC
	protected override bool OnLeaveLevel()
	{
		this.ClearEntityActor("AttachToActorModel.OnLeaveLevel");
		return true;
	}

	// Token: 0x17002912 RID: 10514
	// (get) Token: 0x0601DCE9 RID: 122089 RVA: 0x0085A7CA File Offset: 0x008589CA
	public static AttachToActorModel Instance
	{
		get
		{
			return AttachToActorModel._Instance;
		}
	}

	// Token: 0x0601DCEA RID: 122090 RVA: 0x0085A7D1 File Offset: 0x008589D1
	public static AttachToActorModel GetOrCreateInstance()
	{
		if (AttachToActorModel._Instance == null)
		{
			AttachToActorModel.CreateInstance();
		}
		return AttachToActorModel._Instance;
	}

	// Token: 0x0601DCEB RID: 122091 RVA: 0x0085A7E5 File Offset: 0x008589E5
	public static bool CreateInstance()
	{
		if (AttachToActorModel._Instance != null)
		{
			return true;
		}
		AttachToActorModel._Instance = new AttachToActorModel();
		return true;
	}

	// Token: 0x0601DCEC RID: 122092 RVA: 0x0085A7FB File Offset: 0x008589FB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DCED RID: 122093 RVA: 0x0085A7FD File Offset: 0x008589FD
	public static void ResetStaticDefaultValue()
	{
		AttachToActorModel._Instance = null;
	}

	// Token: 0x0601DCEE RID: 122094 RVA: 0x0085A805 File Offset: 0x00858A05
	static AttachToActorModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AttachToActorModel.CreateStaticDefaultValue), new Action(AttachToActorModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400E9EF RID: 59887
	public bool ShowLog = true;

	// Token: 0x0400E9F0 RID: 59888
	private readonly Dictionary<int, AttachActorEntry> AttachActorMap = new Dictionary<int, AttachActorEntry>();

	// Token: 0x0400E9F1 RID: 59889
	private readonly Dictionary<AActor, int> ActorForEntityMap = new Dictionary<AActor, int>();

	// Token: 0x0400E9F2 RID: 59890
	private int AttachId;

	// Token: 0x0400E9F3 RID: 59891
	[Nullable(2)]
	private static AttachToActorModel _Instance;
}
