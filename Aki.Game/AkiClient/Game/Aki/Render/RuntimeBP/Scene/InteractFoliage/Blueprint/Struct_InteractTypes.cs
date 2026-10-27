using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.InteractFoliage.Blueprint.MeshActor;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.InteractFoliage.Blueprint
{
	// Token: 0x02003B57 RID: 15191
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/Struct_InteractTypes.Struct_InteractTypes")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class Struct_InteractTypes : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021AE8 RID: 137960 RVA: 0x008F2F70 File Offset: 0x008F1170
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (Struct_InteractTypes._ScriptStructPtr != 0) ? Struct_InteractTypes._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/Struct_InteractTypes.Struct_InteractTypes", ref Struct_InteractTypes._ScriptStructPtr);
		}

		// Token: 0x170037C7 RID: 14279
		// (get) Token: 0x06021AE9 RID: 137961 RVA: 0x008F2F94 File Offset: 0x008F1194
		// (set) Token: 0x06021AEA RID: 137962 RVA: 0x008F2FA8 File Offset: 0x008F11A8
		public unsafe UStaticMesh StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_InteractTypes.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_InteractTypes.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170037C8 RID: 14280
		// (get) Token: 0x06021AEB RID: 137963 RVA: 0x008F2FBD File Offset: 0x008F11BD
		// (set) Token: 0x06021AEC RID: 137964 RVA: 0x008F2FD1 File Offset: 0x008F11D1
		public unsafe USkeletalMesh SkeletonMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_InteractTypes.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_InteractTypes.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170037C9 RID: 14281
		// (get) Token: 0x06021AED RID: 137965 RVA: 0x008F2FE6 File Offset: 0x008F11E6
		// (set) Token: 0x06021AEE RID: 137966 RVA: 0x008F2FF6 File Offset: 0x008F11F6
		public unsafe float TraceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_InteractTypes.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_InteractTypes.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170037CA RID: 14282
		// (get) Token: 0x06021AEF RID: 137967 RVA: 0x008F3007 File Offset: 0x008F1207
		// (set) Token: 0x06021AF0 RID: 137968 RVA: 0x008F301B File Offset: 0x008F121B
		public unsafe KUROInteractFoliage_C FoliageType
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<KUROInteractFoliage_C>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_InteractTypes.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_InteractTypes.__PropertyOffset_3, value);
			}
		}

		// Token: 0x06021AF1 RID: 137969 RVA: 0x008F3030 File Offset: 0x008F1230
		public Struct_InteractTypes()
		{
		}

		// Token: 0x06021AF2 RID: 137970 RVA: 0x008F3038 File Offset: 0x008F1238
		[NullableContext(1)]
		public Struct_InteractTypes(UStaticMesh StaticMesh, USkeletalMesh SkeletonMesh, float TraceRadius, KUROInteractFoliage_C FoliageType)
		{
			this.StaticMesh = StaticMesh;
			this.SkeletonMesh = SkeletonMesh;
			this.TraceRadius = TraceRadius;
			this.FoliageType = FoliageType;
		}

		// Token: 0x06021AF3 RID: 137971 RVA: 0x008F305D File Offset: 0x008F125D
		protected override IntPtr GetUStructPtr()
		{
			return Struct_InteractTypes.StaticStruct();
		}

		// Token: 0x06021AF4 RID: 137972 RVA: 0x008F3069 File Offset: 0x008F1269
		public Struct_InteractTypes(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021AF5 RID: 137973 RVA: 0x008F3073 File Offset: 0x008F1273
		public Struct_InteractTypes(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021AF6 RID: 137974 RVA: 0x008F307E File Offset: 0x008F127E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new Struct_InteractTypes(Pointer, false, true);
		}

		// Token: 0x06021AF7 RID: 137975 RVA: 0x008F3088 File Offset: 0x008F1288
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new Struct_InteractTypes(Pointer, MemoryOwner);
		}

		// Token: 0x040106E1 RID: 67297
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/Struct_InteractTypes.Struct_InteractTypes";

		// Token: 0x040106E2 RID: 67298
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040106E3 RID: 67299
		internal static int __PropertyOffset_0;

		// Token: 0x040106E4 RID: 67300
		internal static int __PropertyOffset_1;

		// Token: 0x040106E5 RID: 67301
		internal static int __PropertyOffset_2;

		// Token: 0x040106E6 RID: 67302
		internal static int __PropertyOffset_3;
	}
}
