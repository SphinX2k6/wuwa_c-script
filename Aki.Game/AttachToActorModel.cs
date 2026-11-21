using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002A8F RID: 10895
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class AttachToActorModel : ModelBase
{
	// Token: 0x0601B9FA RID: 113146 RVA: 0x008826EF File Offset: 0x008808EF
	protected override bool OnInit()
	{
		this.ShowLog = GlobalData.IsPlayInEditor;
		return true;
	}

	// Token: 0x0601B9FB RID: 113147 RVA: 0x00882700 File Offset: 0x00880900
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

	// Token: 0x0601B9FC RID: 113148 RVA: 0x008828AC File Offset: 0x00880AAC
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

	// Token: 0x0601B9FD RID: 113149 RVA: 0x008829E8 File Offset: 0x00880BE8
	public int GetEntityIdByActor(AActor actor)
	{
		int result;
		if (!this.ActorForEntityMap.TryGetValue(actor, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x0601B9FE RID: 113150 RVA: 0x00882A08 File Offset: 0x00880C08
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

	// Token: 0x0601B9FF RID: 113151 RVA: 0x00882A28 File Offset: 0x00880C28
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

	// Token: 0x0601BA00 RID: 113152 RVA: 0x00882A50 File Offset: 0x00880C50
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

	// Token: 0x0601BA01 RID: 113153 RVA: 0x00882BB0 File Offset: 0x00880DB0
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

	// Token: 0x0601BA02 RID: 113154 RVA: 0x00882D64 File Offset: 0x00880F64
	protected override bool OnLeaveLevel()
	{
		this.ClearEntityActor("AttachToActorModel.OnLeaveLevel");
		return true;
	}

	// Token: 0x17002CAB RID: 11435
	// (get) Token: 0x0601BA03 RID: 113155 RVA: 0x00882D72 File Offset: 0x00880F72
	public static AttachToActorModel Instance
	{
		get
		{
			return AttachToActorModel._Instance;
		}
	}

	// Token: 0x0601BA04 RID: 113156 RVA: 0x00882D79 File Offset: 0x00880F79
	public static AttachToActorModel GetOrCreateInstance()
	{
		if (AttachToActorModel._Instance == null)
		{
			AttachToActorModel.CreateInstance();
		}
		return AttachToActorModel._Instance;
	}

	// Token: 0x0601BA05 RID: 113157 RVA: 0x00882D8D File Offset: 0x00880F8D
	public static bool CreateInstance()
	{
		if (AttachToActorModel._Instance != null)
		{
			return true;
		}
		AttachToActorModel._Instance = new AttachToActorModel();
		return true;
	}

	// Token: 0x0601BA06 RID: 113158 RVA: 0x00882DA3 File Offset: 0x00880FA3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601BA07 RID: 113159 RVA: 0x00882DA5 File Offset: 0x00880FA5
	public static void ResetStaticDefaultValue()
	{
		AttachToActorModel._Instance = null;
	}

	// Token: 0x0601BA08 RID: 113160 RVA: 0x00882DAD File Offset: 0x00880FAD
	static AttachToActorModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AttachToActorModel.CreateStaticDefaultValue), new Action(AttachToActorModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400EEAA RID: 61098
	public bool ShowLog = true;

	// Token: 0x0400EEAB RID: 61099
	private readonly Dictionary<int, AttachActorEntry> AttachActorMap = new Dictionary<int, AttachActorEntry>();

	// Token: 0x0400EEAC RID: 61100
	private readonly Dictionary<AActor, int> ActorForEntityMap = new Dictionary<AActor, int>();

	// Token: 0x0400EEAD RID: 61101
	private int AttachId;

	// Token: 0x0400EEAE RID: 61102
	[Nullable(2)]
	private static AttachToActorModel _Instance;
}
