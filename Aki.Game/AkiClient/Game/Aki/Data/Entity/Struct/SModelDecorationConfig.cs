using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Entity.Struct
{
	// Token: 0x02003224 RID: 12836
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Struct/SModelDecorationConfig.SModelDecorationConfig")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class SModelDecorationConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060200CE RID: 131278 RVA: 0x0093C15B File Offset: 0x0093A35B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SModelDecorationConfig._ScriptStructPtr != 0) ? SModelDecorationConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Entity/Struct/SModelDecorationConfig.SModelDecorationConfig", ref SModelDecorationConfig._ScriptStructPtr);
		}

		// Token: 0x17003D03 RID: 15619
		// (get) Token: 0x060200CF RID: 131279 RVA: 0x0093C17F File Offset: 0x0093A37F
		// (set) Token: 0x060200D0 RID: 131280 RVA: 0x0093C193 File Offset: 0x0093A393
		public unsafe string SocketName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SModelDecorationConfig.__PropertyOffset_SocketName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SModelDecorationConfig.__PropertyOffset_SocketName)), value);
			}
		}

		// Token: 0x17003D04 RID: 15620
		// (get) Token: 0x060200D1 RID: 131281 RVA: 0x0093C1A8 File Offset: 0x0093A3A8
		// (set) Token: 0x060200D2 RID: 131282 RVA: 0x0093C1BC File Offset: 0x0093A3BC
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelDecorationConfig.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelDecorationConfig.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17003D05 RID: 15621
		// (get) Token: 0x060200D3 RID: 131283 RVA: 0x0093C1D1 File Offset: 0x0093A3D1
		// (set) Token: 0x060200D4 RID: 131284 RVA: 0x0093C1F0 File Offset: 0x0093A3F0
		public TSoftObjectPtr<USkeletalMesh> SkeletalMesh
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SModelDecorationConfig.__PropertyOffset_SkeletalMesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelDecorationConfig.__PropertyOffset_SkeletalMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x060200D5 RID: 131285 RVA: 0x0093C215 File Offset: 0x0093A415
		public SModelDecorationConfig()
		{
		}

		// Token: 0x060200D6 RID: 131286 RVA: 0x0093C21D File Offset: 0x0093A41D
		protected override IntPtr GetUStructPtr()
		{
			return SModelDecorationConfig.StaticStruct();
		}

		// Token: 0x060200D7 RID: 131287 RVA: 0x0093C229 File Offset: 0x0093A429
		[NullableContext(2)]
		public SModelDecorationConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060200D8 RID: 131288 RVA: 0x0093C233 File Offset: 0x0093A433
		public SModelDecorationConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060200D9 RID: 131289 RVA: 0x0093C23E File Offset: 0x0093A43E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SModelDecorationConfig(Pointer, false, true);
		}

		// Token: 0x060200DA RID: 131290 RVA: 0x0093C248 File Offset: 0x0093A448
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SModelDecorationConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04011393 RID: 70547
		public const string __ObjectPath = "/Game/Aki/Data/Entity/Struct/SModelDecorationConfig.SModelDecorationConfig";

		// Token: 0x04011394 RID: 70548
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011395 RID: 70549
		internal static int __PropertyOffset_SocketName;

		// Token: 0x04011396 RID: 70550
		internal static int __PropertyOffset_Transform;

		// Token: 0x04011397 RID: 70551
		internal static int __PropertyOffset_SkeletalMesh;
	}
}
