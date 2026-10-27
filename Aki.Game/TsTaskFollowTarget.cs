using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000A2 RID: 162
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFollowTarget.TsTaskFollowTarget_C")]
public class TsTaskFollowTarget : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06000895 RID: 2197 RVA: 0x0002B8E7 File Offset: 0x00029AE7
	// (set) Token: 0x06000896 RID: 2198 RVA: 0x0002B8F7 File Offset: 0x00029AF7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Angle
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_Angle);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_Angle) = value;
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06000897 RID: 2199 RVA: 0x0002B908 File Offset: 0x00029B08
	// (set) Token: 0x06000898 RID: 2200 RVA: 0x0002B918 File Offset: 0x00029B18
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Length
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_Length);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_Length) = value;
		}
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06000899 RID: 2201 RVA: 0x0002B929 File Offset: 0x00029B29
	// (set) Token: 0x0600089A RID: 2202 RVA: 0x0002B939 File Offset: 0x00029B39
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Speed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_Speed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_Speed) = value;
		}
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x0600089B RID: 2203 RVA: 0x0002B94A File Offset: 0x00029B4A
	// (set) Token: 0x0600089C RID: 2204 RVA: 0x0002B95A File Offset: 0x00029B5A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float StandSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_StandSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_StandSpeed) = value;
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x0600089D RID: 2205 RVA: 0x0002B96B File Offset: 0x00029B6B
	// (set) Token: 0x0600089E RID: 2206 RVA: 0x0002B97B File Offset: 0x00029B7B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Radius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_Radius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_Radius) = value;
		}
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x0600089F RID: 2207 RVA: 0x0002B98C File Offset: 0x00029B8C
	// (set) Token: 0x060008A0 RID: 2208 RVA: 0x0002B99C File Offset: 0x00029B9C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float NavigationRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_NavigationRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_NavigationRadius) = value;
		}
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x060008A1 RID: 2209 RVA: 0x0002B9AD File Offset: 0x00029BAD
	// (set) Token: 0x060008A2 RID: 2210 RVA: 0x0002B9BD File Offset: 0x00029BBD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxNavigationMillisecond
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_MaxNavigationMillisecond);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_MaxNavigationMillisecond) = value;
		}
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0002B9CE File Offset: 0x00029BCE
	// (set) Token: 0x060008A4 RID: 2212 RVA: 0x0002B9E2 File Offset: 0x00029BE2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string FollowPointName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFollowTarget.__PropertyOffset_FollowPointName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFollowTarget.__PropertyOffset_FollowPointName)), value);
		}
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x060008A5 RID: 2213 RVA: 0x0002B9F7 File Offset: 0x00029BF7
	// (set) Token: 0x060008A6 RID: 2214 RVA: 0x0002BA07 File Offset: 0x00029C07
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsShowCube
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_IsShowCube) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_IsShowCube) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x060008A7 RID: 2215 RVA: 0x0002BA18 File Offset: 0x00029C18
	// (set) Token: 0x060008A8 RID: 2216 RVA: 0x0002BA51 File Offset: 0x00029C51
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<FGameplayTag> Tags
	{
		get
		{
			base.FastCheckIsValid();
			TArray<FGameplayTag> result;
			if ((result = this._Tags) == null)
			{
				result = (this._Tags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_Tags, this));
			}
			return result;
		}
		set
		{
			this.Tags.CopyAssign(value);
		}
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0002BA5F File Offset: 0x00029C5F
	// (set) Token: 0x060008AA RID: 2218 RVA: 0x0002BA73 File Offset: 0x00029C73
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string WaitTimeName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFollowTarget.__PropertyOffset_WaitTimeName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFollowTarget.__PropertyOffset_WaitTimeName)), value);
		}
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x060008AB RID: 2219 RVA: 0x0002BA88 File Offset: 0x00029C88
	// (set) Token: 0x060008AC RID: 2220 RVA: 0x0002BA98 File Offset: 0x00029C98
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float WaitTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_WaitTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_WaitTime) = value;
		}
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x060008AD RID: 2221 RVA: 0x0002BAA9 File Offset: 0x00029CA9
	// (set) Token: 0x060008AE RID: 2222 RVA: 0x0002BABD File Offset: 0x00029CBD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BeginTimeName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFollowTarget.__PropertyOffset_BeginTimeName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFollowTarget.__PropertyOffset_BeginTimeName)), value);
		}
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x060008AF RID: 2223 RVA: 0x0002BAD2 File Offset: 0x00029CD2
	// (set) Token: 0x060008B0 RID: 2224 RVA: 0x0002BAE6 File Offset: 0x00029CE6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string IsHasName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFollowTarget.__PropertyOffset_IsHasName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFollowTarget.__PropertyOffset_IsHasName)), value);
		}
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x060008B1 RID: 2225 RVA: 0x0002BAFB File Offset: 0x00029CFB
	// (set) Token: 0x060008B2 RID: 2226 RVA: 0x0002BB0B File Offset: 0x00029D0B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsInTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_IsInTag) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowTarget.__PropertyOffset_IsInTag) = (value ? 1 : 0);
		}
	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x0002BB1C File Offset: 0x00029D1C
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsAngle = this.Angle;
			this.TsLength = this.Length;
			this.TsSpeed = this.Speed;
			this.TsStandSpeed = this.StandSpeed;
			this.TsRadius = this.Radius;
			this.TsNavigationRadius = this.NavigationRadius;
			this.TsMaxNavigationMillisecond = (double)this.MaxNavigationMillisecond;
			this.TsFollowPointName = this.FollowPointName;
			this.TsIsShowCube = this.IsShowCube;
			this.TsTags = new List<FGameplayTag>();
			int i = 0;
			int count = this.Tags.Count;
			while (i < count)
			{
				this.TsTags.Add(this.Tags.Get(i));
				i++;
			}
			this.TsWaitTime = this.WaitTime;
			this.TsBeginTimeName = this.BeginTimeName;
			this.TsIsHasName = this.IsHasName;
			this.TsIsInTag = this.IsInTag;
		}
	}

	// Token: 0x060008B4 RID: 2228 RVA: 0x0002BC1C File Offset: 0x00029E1C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveExecuteAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x0002BCB5 File Offset: 0x00029EB5
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		this.GetPath(ownerController, controlledPawn);
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x0002BCC8 File Offset: 0x00029EC8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTickAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x0002BD68 File Offset: 0x00029F68
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			base.FinishExecute(false);
			return;
		}
		this.DelayDie(ownerController);
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp.Entity.CheckGetComponent<BaseTagComponent>().HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]))
		{
			charActorComp.SetInputDirect(Vector.ZeroVectorProxy, false);
			this.OnClear();
			return;
		}
		this.GetPath(ownerController, controlledPawn);
		if (!this.FoundPath)
		{
			return;
		}
		if (Time.Instance.WorldTime > this.NavigationEndTime)
		{
			base.Finish(false);
			return;
		}
		Vector vector = Vector.Create(this.NavigationPath[this.CurrentNavigationIndex]);
		vector.Subtraction(charActorComp.ActorLocationProxy, vector);
		vector.Z = 0.0;
		double num = vector.Size();
		TsBaseCharacter tsBaseCharacter = charActorComp.Owner as TsBaseCharacter;
		float? num2;
		if (tsBaseCharacter == null)
		{
			num2 = null;
		}
		else
		{
			UPawnMovementComponent movementComponent = tsBaseCharacter.GetMovementComponent();
			num2 = ((movementComponent != null) ? new float?(movementComponent.Velocity.Size()) : null);
		}
		float? num3 = num2;
		float valueOrDefault = num3.GetValueOrDefault();
		float num4 = ((this.TsSpeed != 0f) ? this.TsSpeed : 1f) * 0.017453292f;
		float num5 = valueOrDefault / num4 + 10f;
		if (num < (double)num5)
		{
			this.CurrentNavigationIndex++;
			if (this.CurrentNavigationIndex == this.NavigationPath.Count)
			{
				base.Finish(true);
				return;
			}
		}
		vector.DivisionEqual(num);
		charActorComp.SetInputDirect(vector, true);
		AiControllerLibrary.TurnToDirect(charActorComp, vector, this.TsSpeed, false, 0f);
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x0002BF14 File Offset: 0x0002A114
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void GetPath(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetPath"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTaskFollowTarget.__GetPath_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTaskFollowTarget.__GetPath_FunctionParams*)ptr + 15L / (long)sizeof(TsTaskFollowTarget.__GetPath_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->ownerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->controlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x0002BFB0 File Offset: 0x0002A1B0
	[NullableContext(2)]
	protected void GetPath_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		CreatureDataComponent creatureDataComponent = charActorComp.Entity.CheckGetComponent<CreatureDataComponent>();
		int entityId = CreatureModel.Instance.GetEntityId(creatureDataComponent.GetSummonerId());
		if (entityId != 0)
		{
			this.Source = CharacterController.Instance.GetCharacterActorComponentById(entityId);
			Vector vector = Vector.Create();
			this.Source.ActorForwardProxy.RotateAngleAxis((double)this.TsAngle, Vector.UpVectorProxy, vector);
			vector.Normalize(0.0001);
			vector.Multiply((double)this.TsLength, vector);
			vector.Addition(this.Source.ActorLocationProxy, vector);
			int num = 5;
			int num2 = 156;
			if (this.TsIsShowCube)
			{
				FVectorDouble fvectorDouble = vector.ToUeVector(false);
				this.DrawCube(new FTransformDouble?(new FTransformDouble(ref fvectorDouble)), (float)num, (float)num2);
			}
			double num3 = Vector.DistSquared(vector, charActorComp.ActorLocationProxy);
			if (this.TsIsShowCube)
			{
				FVectorDouble fvectorDouble = charActorComp.ActorLocation;
				this.DrawCube(new FTransformDouble?(new FTransformDouble(ref fvectorDouble)), (float)num, 0f);
			}
			if (num3 > (double)(this.TsNavigationRadius * this.TsNavigationRadius) || charActorComp.Entity.CheckGetComponent<BaseTagComponent>().HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.行走"]))
			{
				if (this.NavigationPath == null)
				{
					this.NavigationPath = new List<Vector>();
				}
				this.NavigationPath.Clear();
				if (num3 <= (double)(this.TsRadius * this.TsRadius))
				{
					BlackboardController.Instance.SetBooleanValueByEntity(aiController.CharAiDesignComp.Entity.Id, "FollowIsCanInput", true);
					charActorComp.Entity.CheckGetComponent<CharacterUnifiedStateComponent>().SetMoveState(ECharMoveState.Stand);
					this.OnClear();
					return;
				}
				this.FoundPath = AiControllerLibrary.NavigationFindPath(ownerController, charActorComp.ActorLocation, vector.ToUeVector(false), this.NavigationPath, null, null);
				if (this.NavigationPath.Count > 0)
				{
					BlackboardController.Instance.SetVectorValueByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsFollowPointName, (double)((float)this.NavigationPath[this.NavigationPath.Count - 1].X), (double)((float)this.NavigationPath[this.NavigationPath.Count - 1].Y), (double)((float)this.NavigationPath[this.NavigationPath.Count - 1].Z));
				}
				this.CurrentNavigationIndex = 1;
				this.NavigationEndTime = Time.Instance.WorldTime + this.TsMaxNavigationMillisecond;
				charActorComp.Entity.CheckGetComponent<CharacterUnifiedStateComponent>().SetMoveState(ECharMoveState.Walk);
				BlackboardController.Instance.SetBooleanValueByEntity(aiController.CharAiDesignComp.Entity.Id, "FollowIsCanInput", false);
			}
			if (num3 <= (double)(this.TsRadius * this.TsRadius) && charActorComp.Entity.CheckGetComponent<BaseTagComponent>().HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.站立"]))
			{
				AiControllerLibrary.TurnToDirect(charActorComp, this.Source.ActorForwardProxy, this.TsStandSpeed, false, 0f);
				return;
			}
		}
		else
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.ZQ;
			string message2 = "没有召唤Source对象 或者没有setRole";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.FinishExecute(false);
		}
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x0002C350 File Offset: 0x0002A550
	[NullableContext(2)]
	private bool DelayDie(AAIController ownerController)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		if (tsAiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.ZQ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		CharacterActorComponent charActorComp = tsAiController.AiController.CharActorComp;
		if (charActorComp == null)
		{
			return false;
		}
		CreatureDataComponent creatureDataComponent = charActorComp.Entity.CheckGetComponent<CreatureDataComponent>();
		int entityId = CreatureModel.Instance.GetEntityId(creatureDataComponent.GetSummonerId());
		this.IsHas = BlackboardController.Instance.GetBooleanValueByEntity(tsAiController.AiController.CharAiDesignComp.Entity.Id, this.TsIsHasName).GetValueOrDefault();
		if (this.Source == null && entityId != 0)
		{
			this.Source = CharacterController.Instance.GetCharacterActorComponentById(entityId);
		}
		if (this.Source == null)
		{
			return false;
		}
		bool flag = false;
		foreach (FGameplayTag tag in this.TsTags)
		{
			bool flag2 = this.Source.Entity.CheckGetComponent<BaseTagComponent>().HasTag(tag.TagId());
			if ((this.TsIsInTag && flag2) || (!this.TsIsInTag && !flag2))
			{
				if (!this.IsHas)
				{
					BlackboardController.Instance.SetIntValueByEntity(tsAiController.AiController.CharAiDesignComp.Entity.Id, this.TsBeginTimeName, (int)Time.Instance.WorldTime);
					BlackboardController.Instance.SetBooleanValueByEntity(tsAiController.AiController.CharAiDesignComp.Entity.Id, this.TsIsHasName, true);
					this.IsHas = true;
				}
				flag = true;
			}
		}
		if (!flag)
		{
			BlackboardController.Instance.SetBooleanValueByEntity(tsAiController.AiController.CharAiDesignComp.Entity.Id, this.TsIsHasName, false);
			return false;
		}
		int? intValueByEntity = BlackboardController.Instance.GetIntValueByEntity(tsAiController.AiController.CharAiDesignComp.Entity.Id, this.TsBeginTimeName);
		double worldTime = Time.Instance.WorldTime;
		int? num = intValueByEntity;
		int num2 = 0;
		int? num3 = (!(num.GetValueOrDefault() == num2 & num != null)) ? intValueByEntity : new int?(0);
		intValueByEntity = new int?((int)(worldTime - ((num3 != null) ? new double?((double)num3.GetValueOrDefault()) : null)).Value);
		num3 = intValueByEntity;
		float? num4 = (num3 != null) ? new float?((float)num3.GetValueOrDefault()) : null;
		float tsWaitTime = this.TsWaitTime;
		if (num4.GetValueOrDefault() >= tsWaitTime & num4 != null)
		{
			if (entityId != 0 && CharacterController.Instance.GetCharacterActorComponentById(entityId) != null)
			{
				EventSystem.Instance.Emit<int>(EEventName.OnClearFollowData, tsAiController.AiController.CharAiDesignComp.Entity.Id);
			}
			return true;
		}
		return false;
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x0002C670 File Offset: 0x0002A870
	protected override void OnClear()
	{
		TsAiController tsAiController = base.AIOwner as TsAiController;
		if (tsAiController != null)
		{
			AiControllerLibrary.ClearInput(tsAiController);
		}
		this.NavigationPath = null;
		this.Source = null;
		this.FoundPath = false;
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x0002C6A8 File Offset: 0x0002A8A8
	protected void DrawCube(FTransformDouble? transform, float duration, float colorValue)
	{
		if (transform == null)
		{
			return;
		}
		FTransformDouble value = transform.Value;
		FLinearColor lineColor = new FLinearColor(colorValue, colorValue, colorValue, colorValue);
		FVectorDouble location = value.GetLocation();
		FVector fvector = new FVector(10f, 10f, 10f);
		FVectorDouble extent = new FVectorDouble((double)fvector.X * 0.5, (double)fvector.Y * 0.5, (double)fvector.Z * 0.5);
		FRotator rotation = value.Rotator();
		float thickness = 30f;
		UKismetSystemLibrary.D_DrawDebugBox(GlobalData.World, location, extent, lineColor, rotation, duration, thickness);
		FVectorDouble lineStart = UKismetMathLibrary.D_TransformLocation(value, new FVectorDouble(0.5, 0.5, 0.5));
		FVectorDouble lineEnd = UKismetMathLibrary.D_TransformLocation(value, new FVectorDouble(-0.5, -0.5, -0.5));
		float thickness2 = 15f;
		UKismetSystemLibrary.D_DrawDebugLine(GlobalData.World, lineStart, lineEnd, lineColor, duration, thickness2);
		FVectorDouble lineStart2 = UKismetMathLibrary.D_TransformLocation(value, new FVectorDouble(0.5, -0.5, 0.5));
		FVectorDouble lineEnd2 = UKismetMathLibrary.D_TransformLocation(value, new FVectorDouble(-0.5, 0.5, 0.5));
		UKismetSystemLibrary.D_DrawDebugLine(GlobalData.World, lineStart2, lineEnd2, lineColor, duration, thickness2);
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x0002C81C File Offset: 0x0002AA1C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFollowTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFollowTarget.TsTaskFollowTarget_C");
		}
		return TsTaskFollowTarget._ClassPtr;
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x0002C840 File Offset: 0x0002AA40
	public TsTaskFollowTarget() : this(BuiltinUtils.AllocNativeUObject(TsTaskFollowTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x0002C868 File Offset: 0x0002AA68
	public TsTaskFollowTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFollowTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x0002C89B File Offset: 0x0002AA9B
	protected TsTaskFollowTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x0002C8C8 File Offset: 0x0002AAC8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x0002C8F8 File Offset: 0x0002AAF8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x0002C92C File Offset: 0x0002AB2C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetPath_Implementation(TsTaskFollowTarget.__GetPath_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->ownerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->controlledPawn);
		this.GetPath_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000694 RID: 1684
	private const float NAVIGATION_COMPLETE_DISTANCE = 10f;

	// Token: 0x04000695 RID: 1685
	[Nullable(2)]
	private CharacterActorComponent Source;

	// Token: 0x04000696 RID: 1686
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<Vector> NavigationPath;

	// Token: 0x04000697 RID: 1687
	private double NavigationEndTime;

	// Token: 0x04000698 RID: 1688
	private bool FoundPath;

	// Token: 0x04000699 RID: 1689
	private int CurrentNavigationIndex;

	// Token: 0x0400069A RID: 1690
	protected double BeginTime;

	// Token: 0x0400069B RID: 1691
	protected bool IsHas;

	// Token: 0x0400069C RID: 1692
	private bool IsInitTsVariables;

	// Token: 0x0400069D RID: 1693
	private float TsAngle;

	// Token: 0x0400069E RID: 1694
	private float TsLength;

	// Token: 0x0400069F RID: 1695
	private float TsSpeed;

	// Token: 0x040006A0 RID: 1696
	private float TsStandSpeed;

	// Token: 0x040006A1 RID: 1697
	private float TsRadius;

	// Token: 0x040006A2 RID: 1698
	private float TsNavigationRadius;

	// Token: 0x040006A3 RID: 1699
	private double TsMaxNavigationMillisecond;

	// Token: 0x040006A4 RID: 1700
	private string TsFollowPointName = "";

	// Token: 0x040006A5 RID: 1701
	private bool TsIsShowCube;

	// Token: 0x040006A6 RID: 1702
	[Nullable(2)]
	private List<FGameplayTag> TsTags;

	// Token: 0x040006A7 RID: 1703
	private float TsWaitTime;

	// Token: 0x040006A8 RID: 1704
	private string TsBeginTimeName = "";

	// Token: 0x040006A9 RID: 1705
	private string TsIsHasName = "";

	// Token: 0x040006AA RID: 1706
	private bool TsIsInTag;

	// Token: 0x040006AB RID: 1707
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFollowTarget.TsTaskFollowTarget_C";

	// Token: 0x040006AC RID: 1708
	private static IntPtr _ClassPtr;

	// Token: 0x040006AD RID: 1709
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040006AE RID: 1710
	private static int __PropertyOffset_Angle;

	// Token: 0x040006AF RID: 1711
	private static int __PropertyOffset_Length;

	// Token: 0x040006B0 RID: 1712
	private static int __PropertyOffset_Speed;

	// Token: 0x040006B1 RID: 1713
	private static int __PropertyOffset_StandSpeed;

	// Token: 0x040006B2 RID: 1714
	private static int __PropertyOffset_Radius;

	// Token: 0x040006B3 RID: 1715
	private static int __PropertyOffset_NavigationRadius;

	// Token: 0x040006B4 RID: 1716
	private static int __PropertyOffset_MaxNavigationMillisecond;

	// Token: 0x040006B5 RID: 1717
	private static int __PropertyOffset_FollowPointName;

	// Token: 0x040006B6 RID: 1718
	private static int __PropertyOffset_IsShowCube;

	// Token: 0x040006B7 RID: 1719
	private static int __PropertyOffset_Tags;

	// Token: 0x040006B8 RID: 1720
	[Nullable(2)]
	private TArray<FGameplayTag> _Tags;

	// Token: 0x040006B9 RID: 1721
	private static int __PropertyOffset_WaitTimeName;

	// Token: 0x040006BA RID: 1722
	private static int __PropertyOffset_WaitTime;

	// Token: 0x040006BB RID: 1723
	private static int __PropertyOffset_BeginTimeName;

	// Token: 0x040006BC RID: 1724
	private static int __PropertyOffset_IsHasName;

	// Token: 0x040006BD RID: 1725
	private static int __PropertyOffset_IsInTag;

	// Token: 0x0200737D RID: 29565
	[NullableContext(0)]
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetPath_FunctionParams
	{
		// Token: 0x040265FA RID: 157178
		[FieldOffset(0)]
		public IntPtr ownerController;

		// Token: 0x040265FB RID: 157179
		[FieldOffset(8)]
		public IntPtr controlledPawn;
	}
}
