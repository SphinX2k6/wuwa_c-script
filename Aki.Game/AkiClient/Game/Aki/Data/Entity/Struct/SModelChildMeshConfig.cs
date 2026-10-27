using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Entity.Struct
{
	// Token: 0x02003F8E RID: 16270
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Struct/SModelChildMeshConfig.SModelChildMeshConfig")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 65)]
	public class SModelChildMeshConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060298F7 RID: 170231 RVA: 0x009C7380 File Offset: 0x009C5580
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SModelChildMeshConfig._ScriptStructPtr != 0) ? SModelChildMeshConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Entity/Struct/SModelChildMeshConfig.SModelChildMeshConfig", ref SModelChildMeshConfig._ScriptStructPtr);
		}

		// Token: 0x170063EF RID: 25583
		// (get) Token: 0x060298F8 RID: 170232 RVA: 0x009C73A4 File Offset: 0x009C55A4
		// (set) Token: 0x060298F9 RID: 170233 RVA: 0x009C73C3 File Offset: 0x009C55C3
		public TSoftObjectPtr<USkeletalMesh> SkeletalMesh
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SModelChildMeshConfig.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelChildMeshConfig.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170063F0 RID: 25584
		// (get) Token: 0x060298FA RID: 170234 RVA: 0x009C73E8 File Offset: 0x009C55E8
		// (set) Token: 0x060298FB RID: 170235 RVA: 0x009C73FC File Offset: 0x009C55FC
		public unsafe string ComponentName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SModelChildMeshConfig.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SModelChildMeshConfig.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x170063F1 RID: 25585
		// (get) Token: 0x060298FC RID: 170236 RVA: 0x009C7411 File Offset: 0x009C5611
		// (set) Token: 0x060298FD RID: 170237 RVA: 0x009C7421 File Offset: 0x009C5621
		public unsafe bool DefaultVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelChildMeshConfig.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelChildMeshConfig.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x060298FE RID: 170238 RVA: 0x009C7432 File Offset: 0x009C5632
		public SModelChildMeshConfig()
		{
		}

		// Token: 0x060298FF RID: 170239 RVA: 0x009C743A File Offset: 0x009C563A
		public SModelChildMeshConfig(TSoftObjectPtr<USkeletalMesh> SkeletalMesh, string ComponentName, bool DefaultVisible)
		{
			this.SkeletalMesh = SkeletalMesh;
			this.ComponentName = ComponentName;
			this.DefaultVisible = DefaultVisible;
		}

		// Token: 0x06029900 RID: 170240 RVA: 0x009C7457 File Offset: 0x009C5657
		protected override IntPtr GetUStructPtr()
		{
			return SModelChildMeshConfig.StaticStruct();
		}

		// Token: 0x06029901 RID: 170241 RVA: 0x009C7463 File Offset: 0x009C5663
		[NullableContext(2)]
		public SModelChildMeshConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029902 RID: 170242 RVA: 0x009C746D File Offset: 0x009C566D
		public SModelChildMeshConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029903 RID: 170243 RVA: 0x009C7478 File Offset: 0x009C5678
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SModelChildMeshConfig(Pointer, false, true);
		}

		// Token: 0x06029904 RID: 170244 RVA: 0x009C7482 File Offset: 0x009C5682
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SModelChildMeshConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040154E7 RID: 87271
		public const string __ObjectPath = "/Game/Aki/Data/Entity/Struct/SModelChildMeshConfig.SModelChildMeshConfig";

		// Token: 0x040154E8 RID: 87272
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040154E9 RID: 87273
		internal static int __PropertyOffset_0;

		// Token: 0x040154EA RID: 87274
		internal static int __PropertyOffset_1;

		// Token: 0x040154EB RID: 87275
		internal static int __PropertyOffset_2;
	}
}
