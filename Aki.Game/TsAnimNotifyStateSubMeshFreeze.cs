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

// Token: 0x0200017C RID: 380
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSubMeshFreeze.TsAnimNotifyStateSubMeshFreeze_C")]
public class TsAnimNotifyStateSubMeshFreeze : UKuroAnimNotifyState, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003E6 RID: 998
	// (get) Token: 0x0600180E RID: 6158 RVA: 0x000808B3 File Offset: 0x0007EAB3
	// (set) Token: 0x0600180F RID: 6159 RVA: 0x000808C7 File Offset: 0x0007EAC7
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

	// Token: 0x170003E7 RID: 999
	// (get) Token: 0x06001810 RID: 6160 RVA: 0x000808DC File Offset: 0x0007EADC
	// (set) Token: 0x06001811 RID: 6161 RVA: 0x000808EC File Offset: 0x0007EAEC
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

	// Token: 0x170003E8 RID: 1000
	// (get) Token: 0x06001812 RID: 6162 RVA: 0x000808FD File Offset: 0x0007EAFD
	// (set) Token: 0x06001813 RID: 6163 RVA: 0x00080911 File Offset: 0x0007EB11
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

	// Token: 0x170003E9 RID: 1001
	// (get) Token: 0x06001814 RID: 6164 RVA: 0x00080928 File Offset: 0x0007EB28
	// (set) Token: 0x06001815 RID: 6165 RVA: 0x00080961 File Offset: 0x0007EB61
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

	// Token: 0x170003EA RID: 1002
	// (get) Token: 0x06001816 RID: 6166 RVA: 0x00080986 File Offset: 0x0007EB86
	// (set) Token: 0x06001817 RID: 6167 RVA: 0x00080996 File Offset: 0x0007EB96
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

	// Token: 0x170003EB RID: 1003
	// (get) Token: 0x06001818 RID: 6168 RVA: 0x000809A7 File Offset: 0x0007EBA7
	// (set) Token: 0x06001819 RID: 6169 RVA: 0x000809BB File Offset: 0x0007EBBB
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

	// Token: 0x170003EC RID: 1004
	// (get) Token: 0x0600181A RID: 6170 RVA: 0x000809D0 File Offset: 0x0007EBD0
	// (set) Token: 0x0600181B RID: 6171 RVA: 0x00080A09 File Offset: 0x0007EC09
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

	// Token: 0x170003ED RID: 1005
	// (get) Token: 0x0600181C RID: 6172 RVA: 0x00080A2E File Offset: 0x0007EC2E
	// (set) Token: 0x0600181D RID: 6173 RVA: 0x00080A3E File Offset: 0x0007EC3E
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

	// Token: 0x170003EE RID: 1006
	// (get) Token: 0x0600181E RID: 6174 RVA: 0x00080A4F File Offset: 0x0007EC4F
	// (set) Token: 0x0600181F RID: 6175 RVA: 0x00080A5F File Offset: 0x0007EC5F
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

	// Token: 0x170003EF RID: 1007
	// (get) Token: 0x06001820 RID: 6176 RVA: 0x00080A70 File Offset: 0x0007EC70
	// (set) Token: 0x06001821 RID: 6177 RVA: 0x00080A84 File Offset: 0x0007EC84
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

	// Token: 0x06001822 RID: 6178 RVA: 0x00080A9C File Offset: 0x0007EC9C
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

	// Token: 0x06001823 RID: 6179 RVA: 0x00080C44 File Offset: 0x0007EE44
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

	// Token: 0x06001824 RID: 6180 RVA: 0x00080DA7 File Offset: 0x0007EFA7
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "子Mesh冻结控制";
	}

	// Token: 0x06001825 RID: 6181 RVA: 0x00080DAE File Offset: 0x0007EFAE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSubMeshFreeze._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSubMeshFreeze.TsAnimNotifyStateSubMeshFreeze_C");
		}
		return TsAnimNotifyStateSubMeshFreeze._ClassPtr;
	}

	// Token: 0x06001826 RID: 6182 RVA: 0x00080DD4 File Offset: 0x0007EFD4
	public TsAnimNotifyStateSubMeshFreeze() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSubMeshFreeze.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001827 RID: 6183 RVA: 0x00080DFC File Offset: 0x0007EFFC
	public TsAnimNotifyStateSubMeshFreeze(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSubMeshFreeze.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001828 RID: 6184 RVA: 0x00080E2F File Offset: 0x0007F02F
	protected TsAnimNotifyStateSubMeshFreeze(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001829 RID: 6185 RVA: 0x00080E64 File Offset: 0x0007F064
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600182A RID: 6186 RVA: 0x00080EA0 File Offset: 0x0007F0A0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600182B RID: 6187 RVA: 0x00080ED3 File Offset: 0x0007F0D3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x04001020 RID: 4128
	private const float INTERRUPT_THRESHOLD = 0.05f;

	// Token: 0x04001021 RID: 4129
	private HashSet<USkeletalMeshComponent> ActivateSet = new HashSet<USkeletalMeshComponent>();

	// Token: 0x04001022 RID: 4130
	private Dictionary<USkeletalMeshComponent, double> BeginTimeMap = new Dictionary<USkeletalMeshComponent, double>();

	// Token: 0x04001023 RID: 4131
	private Dictionary<USkeletalMeshComponent, float> TotalDurationMap = new Dictionary<USkeletalMeshComponent, float>();

	// Token: 0x04001024 RID: 4132
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private Dictionary<USkeletalMeshComponent, TimerHandle> SnapshotTimerMap = new Dictionary<USkeletalMeshComponent, TimerHandle>();

	// Token: 0x04001025 RID: 4133
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSubMeshFreeze.TsAnimNotifyStateSubMeshFreeze_C";

	// Token: 0x04001026 RID: 4134
	private static IntPtr _ClassPtr;

	// Token: 0x04001027 RID: 4135
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001028 RID: 4136
	private static int __PropertyOffset_MeshName;

	// Token: 0x04001029 RID: 4137
	private static int __PropertyOffset_开始是否可见;

	// Token: 0x0400102A RID: 4138
	private static int __PropertyOffset_开始材质;

	// Token: 0x0400102B RID: 4139
	private static int __PropertyOffset_开始特效;

	// Token: 0x0400102C RID: 4140
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _开始特效;

	// Token: 0x0400102D RID: 4141
	private static int __PropertyOffset_结束是否可见;

	// Token: 0x0400102E RID: 4142
	private static int __PropertyOffset_结束材质;

	// Token: 0x0400102F RID: 4143
	private static int __PropertyOffset_结束特效;

	// Token: 0x04001030 RID: 4144
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _结束特效;

	// Token: 0x04001031 RID: 4145
	private static int __PropertyOffset_是否冻结;

	// Token: 0x04001032 RID: 4146
	private static int __PropertyOffset_快照延迟时间;

	// Token: 0x04001033 RID: 4147
	private static int __PropertyOffset_EnableTag;
}
