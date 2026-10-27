using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline.Structure
{
	// Token: 0x02003C2E RID: 15406
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/Structure/SPCG_RoadPropertyBasedMultiMesh.SPCG_RoadPropertyBasedMultiMesh")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class SPCG_RoadPropertyBasedMultiMesh : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602364B RID: 144971 RVA: 0x00922DB0 File Offset: 0x00920FB0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPCG_RoadPropertyBasedMultiMesh._ScriptStructPtr != 0) ? SPCG_RoadPropertyBasedMultiMesh._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/Structure/SPCG_RoadPropertyBasedMultiMesh.SPCG_RoadPropertyBasedMultiMesh", ref SPCG_RoadPropertyBasedMultiMesh._ScriptStructPtr);
		}

		// Token: 0x17004116 RID: 16662
		// (get) Token: 0x0602364C RID: 144972 RVA: 0x00922DD4 File Offset: 0x00920FD4
		// (set) Token: 0x0602364D RID: 144973 RVA: 0x00922DE8 File Offset: 0x00920FE8
		[Nullable(2)]
		public unsafe UStaticMesh 基础模型
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + SPCG_RoadPropertyBasedMultiMesh.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SPCG_RoadPropertyBasedMultiMesh.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17004117 RID: 16663
		// (get) Token: 0x0602364E RID: 144974 RVA: 0x00922DFD File Offset: 0x00920FFD
		// (set) Token: 0x0602364F RID: 144975 RVA: 0x00922E11 File Offset: 0x00921011
		public unsafe TEnumAsByte<ESplineMeshAxis> 前向轴
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadPropertyBasedMultiMesh.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadPropertyBasedMultiMesh.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17004118 RID: 16664
		// (get) Token: 0x06023650 RID: 144976 RVA: 0x00922E26 File Offset: 0x00921026
		// (set) Token: 0x06023651 RID: 144977 RVA: 0x00922E36 File Offset: 0x00921036
		public unsafe float 轴向旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadPropertyBasedMultiMesh.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadPropertyBasedMultiMesh.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17004119 RID: 16665
		// (get) Token: 0x06023652 RID: 144978 RVA: 0x00922E47 File Offset: 0x00921047
		// (set) Token: 0x06023653 RID: 144979 RVA: 0x00922E5B File Offset: 0x0092105B
		public unsafe FVector 模型偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadPropertyBasedMultiMesh.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadPropertyBasedMultiMesh.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700411A RID: 16666
		// (get) Token: 0x06023654 RID: 144980 RVA: 0x00922E70 File Offset: 0x00921070
		// (set) Token: 0x06023655 RID: 144981 RVA: 0x00922E80 File Offset: 0x00921080
		public unsafe float 缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadPropertyBasedMultiMesh.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadPropertyBasedMultiMesh.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700411B RID: 16667
		// (get) Token: 0x06023656 RID: 144982 RVA: 0x00922E91 File Offset: 0x00921091
		// (set) Token: 0x06023657 RID: 144983 RVA: 0x00922EA1 File Offset: 0x009210A1
		public unsafe int 数量限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadPropertyBasedMultiMesh.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadPropertyBasedMultiMesh.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x06023658 RID: 144984 RVA: 0x00922EB2 File Offset: 0x009210B2
		public SPCG_RoadPropertyBasedMultiMesh()
		{
		}

		// Token: 0x06023659 RID: 144985 RVA: 0x00922EBA File Offset: 0x009210BA
		public SPCG_RoadPropertyBasedMultiMesh([Nullable(1)] UStaticMesh 基础模型, TEnumAsByte<ESplineMeshAxis> 前向轴, float 轴向旋转, FVector 模型偏移, float 缩放, int 数量限制)
		{
			this.基础模型 = 基础模型;
			this.前向轴 = 前向轴;
			this.轴向旋转 = 轴向旋转;
			this.模型偏移 = 模型偏移;
			this.缩放 = 缩放;
			this.数量限制 = 数量限制;
		}

		// Token: 0x0602365A RID: 144986 RVA: 0x00922EEF File Offset: 0x009210EF
		protected override IntPtr GetUStructPtr()
		{
			return SPCG_RoadPropertyBasedMultiMesh.StaticStruct();
		}

		// Token: 0x0602365B RID: 144987 RVA: 0x00922EFB File Offset: 0x009210FB
		[NullableContext(2)]
		public SPCG_RoadPropertyBasedMultiMesh(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602365C RID: 144988 RVA: 0x00922F05 File Offset: 0x00921105
		public SPCG_RoadPropertyBasedMultiMesh(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602365D RID: 144989 RVA: 0x00922F10 File Offset: 0x00921110
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPCG_RoadPropertyBasedMultiMesh(Pointer, false, true);
		}

		// Token: 0x0602365E RID: 144990 RVA: 0x00922F1A File Offset: 0x0092111A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPCG_RoadPropertyBasedMultiMesh(Pointer, MemoryOwner);
		}

		// Token: 0x0401177F RID: 71551
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/Structure/SPCG_RoadPropertyBasedMultiMesh.SPCG_RoadPropertyBasedMultiMesh";

		// Token: 0x04011780 RID: 71552
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011781 RID: 71553
		internal static int __PropertyOffset_0;

		// Token: 0x04011782 RID: 71554
		internal static int __PropertyOffset_1;

		// Token: 0x04011783 RID: 71555
		internal static int __PropertyOffset_2;

		// Token: 0x04011784 RID: 71556
		internal static int __PropertyOffset_3;

		// Token: 0x04011785 RID: 71557
		internal static int __PropertyOffset_4;

		// Token: 0x04011786 RID: 71558
		internal static int __PropertyOffset_5;
	}
}
