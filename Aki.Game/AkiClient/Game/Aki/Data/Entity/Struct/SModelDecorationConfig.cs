using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Entity.Struct
{
	// Token: 0x02003F90 RID: 16272
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Struct/SModelDecorationConfig.SModelDecorationConfig")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class SModelDecorationConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602994D RID: 170317 RVA: 0x009C7E20 File Offset: 0x009C6020
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SModelDecorationConfig._ScriptStructPtr != 0) ? SModelDecorationConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Entity/Struct/SModelDecorationConfig.SModelDecorationConfig", ref SModelDecorationConfig._ScriptStructPtr);
		}

		// Token: 0x17006412 RID: 25618
		// (get) Token: 0x0602994E RID: 170318 RVA: 0x009C7E44 File Offset: 0x009C6044
		// (set) Token: 0x0602994F RID: 170319 RVA: 0x009C7E58 File Offset: 0x009C6058
		public unsafe string SocketName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SModelDecorationConfig.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SModelDecorationConfig.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006413 RID: 25619
		// (get) Token: 0x06029950 RID: 170320 RVA: 0x009C7E6D File Offset: 0x009C606D
		// (set) Token: 0x06029951 RID: 170321 RVA: 0x009C7E81 File Offset: 0x009C6081
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelDecorationConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelDecorationConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006414 RID: 25620
		// (get) Token: 0x06029952 RID: 170322 RVA: 0x009C7E96 File Offset: 0x009C6096
		// (set) Token: 0x06029953 RID: 170323 RVA: 0x009C7EB5 File Offset: 0x009C60B5
		public TSoftObjectPtr<USkeletalMesh> SkeletalMesh
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SModelDecorationConfig.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelDecorationConfig.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06029954 RID: 170324 RVA: 0x009C7EDA File Offset: 0x009C60DA
		public SModelDecorationConfig()
		{
		}

		// Token: 0x06029955 RID: 170325 RVA: 0x009C7EE2 File Offset: 0x009C60E2
		public SModelDecorationConfig(string SocketName, FTransform Transform, TSoftObjectPtr<USkeletalMesh> SkeletalMesh)
		{
			this.SocketName = SocketName;
			this.Transform = Transform;
			this.SkeletalMesh = SkeletalMesh;
		}

		// Token: 0x06029956 RID: 170326 RVA: 0x009C7EFF File Offset: 0x009C60FF
		protected override IntPtr GetUStructPtr()
		{
			return SModelDecorationConfig.StaticStruct();
		}

		// Token: 0x06029957 RID: 170327 RVA: 0x009C7F0B File Offset: 0x009C610B
		[NullableContext(2)]
		public SModelDecorationConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029958 RID: 170328 RVA: 0x009C7F15 File Offset: 0x009C6115
		public SModelDecorationConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029959 RID: 170329 RVA: 0x009C7F20 File Offset: 0x009C6120
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SModelDecorationConfig(Pointer, false, true);
		}

		// Token: 0x0602995A RID: 170330 RVA: 0x009C7F2A File Offset: 0x009C612A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SModelDecorationConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401551D RID: 87325
		public const string __ObjectPath = "/Game/Aki/Data/Entity/Struct/SModelDecorationConfig.SModelDecorationConfig";

		// Token: 0x0401551E RID: 87326
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401551F RID: 87327
		internal static int __PropertyOffset_0;

		// Token: 0x04015520 RID: 87328
		internal static int __PropertyOffset_1;

		// Token: 0x04015521 RID: 87329
		internal static int __PropertyOffset_2;
	}
}
