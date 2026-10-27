using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SplineMover
{
	// Token: 0x02003BEC RID: 15340
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SplineMover/S_MoverData.S_MoverData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class S_MoverData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022D4D RID: 142669 RVA: 0x0091376B File Offset: 0x0091196B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_MoverData._ScriptStructPtr != 0) ? S_MoverData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/SplineMover/S_MoverData.S_MoverData", ref S_MoverData._ScriptStructPtr);
		}

		// Token: 0x17003E0C RID: 15884
		// (get) Token: 0x06022D4E RID: 142670 RVA: 0x0091378F File Offset: 0x0091198F
		// (set) Token: 0x06022D4F RID: 142671 RVA: 0x009137A3 File Offset: 0x009119A3
		[Nullable(2)]
		public unsafe UStaticMeshComponent TargetMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + S_MoverData.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_MoverData.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17003E0D RID: 15885
		// (get) Token: 0x06022D50 RID: 142672 RVA: 0x009137B8 File Offset: 0x009119B8
		// (set) Token: 0x06022D51 RID: 142673 RVA: 0x009137C8 File Offset: 0x009119C8
		public unsafe float CurrentDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_MoverData.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_MoverData.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x06022D52 RID: 142674 RVA: 0x009137D9 File Offset: 0x009119D9
		public S_MoverData()
		{
		}

		// Token: 0x06022D53 RID: 142675 RVA: 0x009137E1 File Offset: 0x009119E1
		[NullableContext(1)]
		public S_MoverData(UStaticMeshComponent TargetMesh, float CurrentDistance)
		{
			this.TargetMesh = TargetMesh;
			this.CurrentDistance = CurrentDistance;
		}

		// Token: 0x06022D54 RID: 142676 RVA: 0x009137F7 File Offset: 0x009119F7
		protected override IntPtr GetUStructPtr()
		{
			return S_MoverData.StaticStruct();
		}

		// Token: 0x06022D55 RID: 142677 RVA: 0x00913803 File Offset: 0x00911A03
		[NullableContext(2)]
		public S_MoverData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022D56 RID: 142678 RVA: 0x0091380D File Offset: 0x00911A0D
		public S_MoverData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022D57 RID: 142679 RVA: 0x00913818 File Offset: 0x00911A18
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_MoverData(Pointer, false, true);
		}

		// Token: 0x06022D58 RID: 142680 RVA: 0x00913822 File Offset: 0x00911A22
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_MoverData(Pointer, MemoryOwner);
		}

		// Token: 0x04011232 RID: 70194
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SplineMover/S_MoverData.S_MoverData";

		// Token: 0x04011233 RID: 70195
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011234 RID: 70196
		internal static int __PropertyOffset_0;

		// Token: 0x04011235 RID: 70197
		internal static int __PropertyOffset_1;
	}
}
