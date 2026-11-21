using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000180 RID: 384
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSubMeshFreeze.TsAnimNotifyStateSubMeshFreeze_C")]
public class TsAnimNotifyStateSubMeshFreeze : UKuroAnimNotifyState, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000408 RID: 1032
	// (get) Token: 0x060018AB RID: 6315 RVA: 0x000867DB File Offset: 0x000849DB
	// (set) Token: 0x060018AC RID: 6316 RVA: 0x000867EF File Offset: 0x000849EF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string MeshName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_MeshName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_MeshName)), value);
		}
	}

	// Token: 0x17000409 RID: 1033
	// (get) Token: 0x060018AD RID: 6317 RVA: 0x00086804 File Offset: 0x00084A04
	// (set) Token: 0x060018AE RID: 6318 RVA: 0x00086814 File Offset: 0x00084A14
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 开始是否可见
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_开始是否可见) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_开始是否可见) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700040A RID: 1034
	// (get) Token: 0x060018AF RID: 6319 RVA: 0x00086825 File Offset: 0x00084A25
	// (set) Token: 0x060018B0 RID: 6320 RVA: 0x00086839 File Offset: 0x00084A39
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PD_CharacterControllerData_C 开始材质
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_开始材质);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_开始材质, value);
		}
	}

	// Token: 0x1700040B RID: 1035
	// (get) Token: 0x060018B1 RID: 6321 RVA: 0x00086850 File Offset: 0x00084A50
	// (set) Token: 0x060018B2 RID: 6322 RVA: 0x00086889 File Offset: 0x00084A89
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> 开始特效
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._开始特效) == null)
			{
				result = (this._开始特效 = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_开始特效, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_开始特效, 1);
		}
	}

	// Token: 0x1700040C RID: 1036
	// (get) Token: 0x060018B3 RID: 6323 RVA: 0x000868AE File Offset: 0x00084AAE
	// (set) Token: 0x060018B4 RID: 6324 RVA: 0x000868BE File Offset: 0x00084ABE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 结束是否可见
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_结束是否可见) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_结束是否可见) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700040D RID: 1037
	// (get) Token: 0x060018B5 RID: 6325 RVA: 0x000868CF File Offset: 0x00084ACF
	// (set) Token: 0x060018B6 RID: 6326 RVA: 0x000868E3 File Offset: 0x00084AE3
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PD_CharacterControllerData_C 结束材质
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_结束材质);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_结束材质, value);
		}
	}

	// Token: 0x1700040E RID: 1038
	// (get) Token: 0x060018B7 RID: 6327 RVA: 0x000868F8 File Offset: 0x00084AF8
	// (set) Token: 0x060018B8 RID: 6328 RVA: 0x00086931 File Offset: 0x00084B31
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> 结束特效
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._结束特效) == null)
			{
				result = (this._结束特效 = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_结束特效, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_结束特效, 1);
		}
	}

	// Token: 0x1700040F RID: 1039
	// (get) Token: 0x060018B9 RID: 6329 RVA: 0x00086956 File Offset: 0x00084B56
	// (set) Token: 0x060018BA RID: 6330 RVA: 0x00086966 File Offset: 0x00084B66
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否冻结
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_是否冻结) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_是否冻结) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000410 RID: 1040
	// (get) Token: 0x060018BB RID: 6331 RVA: 0x00086977 File Offset: 0x00084B77
	// (set) Token: 0x060018BC RID: 6332 RVA: 0x00086987 File Offset: 0x00084B87
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 快照延迟时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_快照延迟时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_快照延迟时间) = value;
		}
	}

	// Token: 0x17000411 RID: 1041
	// (get) Token: 0x060018BD RID: 6333 RVA: 0x00086998 File Offset: 0x00084B98
	// (set) Token: 0x060018BE RID: 6334 RVA: 0x000869AC File Offset: 0x00084BAC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag EnableTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_EnableTag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSubMeshFreeze.__PropertyOffset_EnableTag) = value;
		}
	}

	// Token: 0x060018BF RID: 6335 RVA: 0x000869C4 File Offset: 0x00084BC4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (this.ActivateSet == null)
		{
			this.ActivateSet = new HashSet<USkeletalMeshComponent>();
		}
		if (this.BeginTimeMap == null)
		{
			this.BeginTimeMap = new Dictionary<USkeletalMeshComponent, double>();
		}
		if (this.TotalDurationMap == null)
		{
			this.TotalDurationMap = new Dictionary<USkeletalMeshComponent, float>();
		}
		if (this.SnapshotTimerMap == null)
		{
			this.SnapshotTimerMap = new Dictionary<USkeletalMeshComponent, TimerHandle>();
		}
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		if (!(aactor is TsBaseCharacter))
		{
			return false;
		}
		Entity entityNoBlueprint = (aactor as TsBaseCharacter).GetEntityNoBlueprint();
		SubMeshComponent subMeshComp = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<SubMeshComponent>() : null;
		if (subMeshComp == null)
		{
			return false;
		}
		if (this.EnableTag.TagName != "None")
		{
			BaseTagComponent baseTagComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent == null)
			{
				return false;
			}
			if (!baseTagComponent.HasTag(this.EnableTag.TagId()))
			{
				return false;
			}
		}
		this.ActivateSet.Add(meshComp);
		this.BeginTimeMap[meshComp] = Time.Instance.NowSeconds;
		this.TotalDurationMap[meshComp] = totalDuration;
		subMeshComp.ShowSubMeshWithEffect(this.MeshName, this.开始是否可见, this.开始材质, this.开始特效);
		subMeshComp.SnapshotSubMesh(this.MeshName);
		if (this.快照延迟时间 > 0f)
		{
			string meshName = this.MeshName;
			USkeletalMeshComponent capturedMeshComp = meshComp;
			TimerHandle value = TimerSystem.Instance.Delay(delegate(float delta)
			{
				subMeshComp.SnapshotSubMesh(meshName);
				this.SnapshotTimerMap.Remove(capturedMeshComp);
			}, this.快照延迟时间 * 1000f, null, null, true, 1f);
			this.SnapshotTimerMap[meshComp] = value;
		}
		return true;
	}

	// Token: 0x060018C0 RID: 6336 RVA: 0x00086B6C File Offset: 0x00084D6C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		HashSet<USkeletalMeshComponent> activateSet = this.ActivateSet;
		if (activateSet == null || !activateSet.Contains(meshComp))
		{
			return false;
		}
		this.ActivateSet.Remove(meshComp);
		TimerHandle timerHandle;
		if (this.SnapshotTimerMap.TryGetValue(meshComp, out timerHandle) && timerHandle != null)
		{
			TimerSystem.Instance.Remove(timerHandle);
			this.SnapshotTimerMap.Remove(meshComp);
		}
		double num2;
		double num = this.BeginTimeMap.TryGetValue(meshComp, out num2) ? num2 : Time.Instance.NowSeconds;
		float num4;
		float num3 = this.TotalDurationMap.TryGetValue(meshComp, out num4) ? num4 : 0f;
		this.BeginTimeMap.Remove(meshComp);
		this.TotalDurationMap.Remove(meshComp);
		double num5 = Time.Instance.NowSeconds - num;
		bool flag = num3 > 0f && (double)num3 - num5 > 0.05000000074505806;
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		if (!(aactor is TsBaseCharacter))
		{
			return false;
		}
		Entity entityNoBlueprint = (aactor as TsBaseCharacter).GetEntityNoBlueprint();
		SubMeshComponent subMeshComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<SubMeshComponent>() : null;
		if (subMeshComponent == null)
		{
			return false;
		}
		if (flag && this.是否冻结)
		{
			subMeshComponent.FreezeSubMeshWithEffect(this.MeshName, this.结束是否可见, this.结束材质, this.结束特效);
		}
		else
		{
			subMeshComponent.PlaySubMeshEffectOnly(this.MeshName, this.结束是否可见, this.结束材质, this.结束特效);
		}
		return true;
	}

	// Token: 0x060018C1 RID: 6337 RVA: 0x00086CCF File Offset: 0x00084ECF
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "子Mesh冻结控制";
	}

	// Token: 0x060018C2 RID: 6338 RVA: 0x00086CD6 File Offset: 0x00084ED6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSubMeshFreeze._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSubMeshFreeze.TsAnimNotifyStateSubMeshFreeze_C");
		}
		return TsAnimNotifyStateSubMeshFreeze._ClassPtr;
	}

	// Token: 0x060018C3 RID: 6339 RVA: 0x00086CFC File Offset: 0x00084EFC
	public TsAnimNotifyStateSubMeshFreeze() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSubMeshFreeze.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060018C4 RID: 6340 RVA: 0x00086D24 File Offset: 0x00084F24
	public TsAnimNotifyStateSubMeshFreeze(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSubMeshFreeze.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060018C5 RID: 6341 RVA: 0x00086D57 File Offset: 0x00084F57
	protected TsAnimNotifyStateSubMeshFreeze(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060018C6 RID: 6342 RVA: 0x00086D8C File Offset: 0x00084F8C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060018C7 RID: 6343 RVA: 0x00086DC8 File Offset: 0x00084FC8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060018C8 RID: 6344 RVA: 0x00086DFB File Offset: 0x00084FFB
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x04001063 RID: 4195
	private const float INTERRUPT_THRESHOLD = 0.05f;

	// Token: 0x04001064 RID: 4196
	private HashSet<USkeletalMeshComponent> ActivateSet = new HashSet<USkeletalMeshComponent>();

	// Token: 0x04001065 RID: 4197
	private Dictionary<USkeletalMeshComponent, double> BeginTimeMap = new Dictionary<USkeletalMeshComponent, double>();

	// Token: 0x04001066 RID: 4198
	private Dictionary<USkeletalMeshComponent, float> TotalDurationMap = new Dictionary<USkeletalMeshComponent, float>();

	// Token: 0x04001067 RID: 4199
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private Dictionary<USkeletalMeshComponent, TimerHandle> SnapshotTimerMap = new Dictionary<USkeletalMeshComponent, TimerHandle>();

	// Token: 0x04001068 RID: 4200
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSubMeshFreeze.TsAnimNotifyStateSubMeshFreeze_C";

	// Token: 0x04001069 RID: 4201
	private static IntPtr _ClassPtr;

	// Token: 0x0400106A RID: 4202
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400106B RID: 4203
	private static int __PropertyOffset_MeshName;

	// Token: 0x0400106C RID: 4204
	private static int __PropertyOffset_开始是否可见;

	// Token: 0x0400106D RID: 4205
	private static int __PropertyOffset_开始材质;

	// Token: 0x0400106E RID: 4206
	private static int __PropertyOffset_开始特效;

	// Token: 0x0400106F RID: 4207
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _开始特效;

	// Token: 0x04001070 RID: 4208
	private static int __PropertyOffset_结束是否可见;

	// Token: 0x04001071 RID: 4209
	private static int __PropertyOffset_结束材质;

	// Token: 0x04001072 RID: 4210
	private static int __PropertyOffset_结束特效;

	// Token: 0x04001073 RID: 4211
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _结束特效;

	// Token: 0x04001074 RID: 4212
	private static int __PropertyOffset_是否冻结;

	// Token: 0x04001075 RID: 4213
	private static int __PropertyOffset_快照延迟时间;

	// Token: 0x04001076 RID: 4214
	private static int __PropertyOffset_EnableTag;
}
