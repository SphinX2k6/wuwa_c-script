using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SoftMesh
{
	// Token: 0x02003BF7 RID: 15351
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/S_SoftMeshPreset.S_SoftMeshPreset")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class S_SoftMeshPreset : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022E99 RID: 143001 RVA: 0x00915A7C File Offset: 0x00913C7C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_SoftMeshPreset._ScriptStructPtr != 0) ? S_SoftMeshPreset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/S_SoftMeshPreset.S_SoftMeshPreset", ref S_SoftMeshPreset._ScriptStructPtr);
		}

		// Token: 0x17003E76 RID: 15990
		// (get) Token: 0x06022E9A RID: 143002 RVA: 0x00915AA0 File Offset: 0x00913CA0
		// (set) Token: 0x06022E9B RID: 143003 RVA: 0x00915AB4 File Offset: 0x00913CB4
		public unsafe UHoudiniPointCache HPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniPointCache>(base.NativePtr / (IntPtr)sizeof(void*) + S_SoftMeshPreset.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_SoftMeshPreset.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17003E77 RID: 15991
		// (get) Token: 0x06022E9C RID: 143004 RVA: 0x00915AC9 File Offset: 0x00913CC9
		// (set) Token: 0x06022E9D RID: 143005 RVA: 0x00915AD9 File Offset: 0x00913CD9
		public unsafe float TightNess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_SoftMeshPreset.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_SoftMeshPreset.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17003E78 RID: 15992
		// (get) Token: 0x06022E9E RID: 143006 RVA: 0x00915AEA File Offset: 0x00913CEA
		// (set) Token: 0x06022E9F RID: 143007 RVA: 0x00915AFE File Offset: 0x00913CFE
		public unsafe UMaterialInstance InputMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + S_SoftMeshPreset.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_SoftMeshPreset.__PropertyOffset_2, value);
			}
		}

		// Token: 0x06022EA0 RID: 143008 RVA: 0x00915B13 File Offset: 0x00913D13
		public S_SoftMeshPreset()
		{
		}

		// Token: 0x06022EA1 RID: 143009 RVA: 0x00915B1B File Offset: 0x00913D1B
		[NullableContext(1)]
		public S_SoftMeshPreset(UHoudiniPointCache HPC, float TightNess, UMaterialInstance InputMat)
		{
			this.HPC = HPC;
			this.TightNess = TightNess;
			this.InputMat = InputMat;
		}

		// Token: 0x06022EA2 RID: 143010 RVA: 0x00915B38 File Offset: 0x00913D38
		protected override IntPtr GetUStructPtr()
		{
			return S_SoftMeshPreset.StaticStruct();
		}

		// Token: 0x06022EA3 RID: 143011 RVA: 0x00915B44 File Offset: 0x00913D44
		public S_SoftMeshPreset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022EA4 RID: 143012 RVA: 0x00915B4E File Offset: 0x00913D4E
		public S_SoftMeshPreset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022EA5 RID: 143013 RVA: 0x00915B59 File Offset: 0x00913D59
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_SoftMeshPreset(Pointer, false, true);
		}

		// Token: 0x06022EA6 RID: 143014 RVA: 0x00915B63 File Offset: 0x00913D63
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_SoftMeshPreset(Pointer, MemoryOwner);
		}

		// Token: 0x040112EE RID: 70382
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/S_SoftMeshPreset.S_SoftMeshPreset";

		// Token: 0x040112EF RID: 70383
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040112F0 RID: 70384
		internal static int __PropertyOffset_0;

		// Token: 0x040112F1 RID: 70385
		internal static int __PropertyOffset_1;

		// Token: 0x040112F2 RID: 70386
		internal static int __PropertyOffset_2;
	}
}
