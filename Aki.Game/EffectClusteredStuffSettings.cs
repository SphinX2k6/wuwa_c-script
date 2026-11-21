using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029E0 RID: 10720
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/EffectClusteredStuffSettings.EffectClusteredStuffSettings_C")]
public class EffectClusteredStuffSettings : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002BB4 RID: 11188
	// (get) Token: 0x0601AEB9 RID: 110265 RVA: 0x00844BC4 File Offset: 0x00842DC4
	// (set) Token: 0x0601AEBA RID: 110266 RVA: 0x00844BFD File Offset: 0x00842DFD
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> EffectDataRef
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._EffectDataRef) == null)
			{
				result = (this._EffectDataRef = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_EffectDataRef, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_EffectDataRef, 1);
		}
	}

	// Token: 0x17002BB5 RID: 11189
	// (get) Token: 0x0601AEBB RID: 110267 RVA: 0x00844C22 File Offset: 0x00842E22
	// (set) Token: 0x0601AEBC RID: 110268 RVA: 0x00844C32 File Offset: 0x00842E32
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float DensityChangeSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_DensityChangeSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_DensityChangeSpeed) = value;
		}
	}

	// Token: 0x17002BB6 RID: 11190
	// (get) Token: 0x0601AEBD RID: 110269 RVA: 0x00844C43 File Offset: 0x00842E43
	// (set) Token: 0x0601AEBE RID: 110270 RVA: 0x00844C53 File Offset: 0x00842E53
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool AttachToActor
	{
		get
		{
			return *(base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_AttachToActor) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_AttachToActor) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002BB7 RID: 11191
	// (get) Token: 0x0601AEBF RID: 110271 RVA: 0x00844C64 File Offset: 0x00842E64
	// (set) Token: 0x0601AEC0 RID: 110272 RVA: 0x00844C78 File Offset: 0x00842E78
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector AbsoluteWorldPosition
	{
		get
		{
			return *(base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_AbsoluteWorldPosition);
		}
		set
		{
			*(base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_AbsoluteWorldPosition) = value;
		}
	}

	// Token: 0x0601AEC1 RID: 110273 RVA: 0x00844C8D File Offset: 0x00842E8D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectClusteredStuffSettings._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/EffectClusteredStuffSettings.EffectClusteredStuffSettings_C");
		}
		return EffectClusteredStuffSettings._ClassPtr;
	}

	// Token: 0x0601AEC2 RID: 110274 RVA: 0x00844CB4 File Offset: 0x00842EB4
	public EffectClusteredStuffSettings() : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AEC3 RID: 110275 RVA: 0x00844CDC File Offset: 0x00842EDC
	public EffectClusteredStuffSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AEC4 RID: 110276 RVA: 0x00844D0F File Offset: 0x00842F0F
	protected EffectClusteredStuffSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E9DE RID: 59870
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/EffectClusteredStuffSettings.EffectClusteredStuffSettings_C";

	// Token: 0x0400E9DF RID: 59871
	private static IntPtr _ClassPtr;

	// Token: 0x0400E9E0 RID: 59872
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E9E1 RID: 59873
	private static int __PropertyOffset_EffectDataRef;

	// Token: 0x0400E9E2 RID: 59874
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _EffectDataRef;

	// Token: 0x0400E9E3 RID: 59875
	private static int __PropertyOffset_DensityChangeSpeed;

	// Token: 0x0400E9E4 RID: 59876
	private static int __PropertyOffset_AttachToActor;

	// Token: 0x0400E9E5 RID: 59877
	private static int __PropertyOffset_AbsoluteWorldPosition;
}
