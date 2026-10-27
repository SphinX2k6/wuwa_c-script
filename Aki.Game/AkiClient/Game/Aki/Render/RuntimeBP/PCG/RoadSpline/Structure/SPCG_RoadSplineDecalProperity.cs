using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline.Structure
{
	// Token: 0x02003C2F RID: 15407
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/Structure/SPCG_RoadSplineDecalProperity.SPCG_RoadSplineDecalProperity")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class SPCG_RoadSplineDecalProperity : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602365F RID: 144991 RVA: 0x00922F23 File Offset: 0x00921123
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPCG_RoadSplineDecalProperity._ScriptStructPtr != 0) ? SPCG_RoadSplineDecalProperity._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/Structure/SPCG_RoadSplineDecalProperity.SPCG_RoadSplineDecalProperity", ref SPCG_RoadSplineDecalProperity._ScriptStructPtr);
		}

		// Token: 0x1700411C RID: 16668
		// (get) Token: 0x06023660 RID: 144992 RVA: 0x00922F47 File Offset: 0x00921147
		// (set) Token: 0x06023661 RID: 144993 RVA: 0x00922F57 File Offset: 0x00921157
		public unsafe int 数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadSplineDecalProperity.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadSplineDecalProperity.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700411D RID: 16669
		// (get) Token: 0x06023662 RID: 144994 RVA: 0x00922F68 File Offset: 0x00921168
		// (set) Token: 0x06023663 RID: 144995 RVA: 0x00922F7C File Offset: 0x0092117C
		public unsafe FVector2D 距离范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadSplineDecalProperity.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadSplineDecalProperity.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700411E RID: 16670
		// (get) Token: 0x06023664 RID: 144996 RVA: 0x00922F91 File Offset: 0x00921191
		// (set) Token: 0x06023665 RID: 144997 RVA: 0x00922FA5 File Offset: 0x009211A5
		public unsafe FVector2D 大小范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadSplineDecalProperity.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadSplineDecalProperity.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700411F RID: 16671
		// (get) Token: 0x06023666 RID: 144998 RVA: 0x00922FBA File Offset: 0x009211BA
		// (set) Token: 0x06023667 RID: 144999 RVA: 0x00922FCE File Offset: 0x009211CE
		public unsafe FVector2D 旋转范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadSplineDecalProperity.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadSplineDecalProperity.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06023668 RID: 145000 RVA: 0x00922FE3 File Offset: 0x009211E3
		public SPCG_RoadSplineDecalProperity()
		{
		}

		// Token: 0x06023669 RID: 145001 RVA: 0x00922FEB File Offset: 0x009211EB
		public SPCG_RoadSplineDecalProperity(int 数量, FVector2D 距离范围, FVector2D 大小范围, FVector2D 旋转范围)
		{
			this.数量 = 数量;
			this.距离范围 = 距离范围;
			this.大小范围 = 大小范围;
			this.旋转范围 = 旋转范围;
		}

		// Token: 0x0602366A RID: 145002 RVA: 0x00923010 File Offset: 0x00921210
		protected override IntPtr GetUStructPtr()
		{
			return SPCG_RoadSplineDecalProperity.StaticStruct();
		}

		// Token: 0x0602366B RID: 145003 RVA: 0x0092301C File Offset: 0x0092121C
		[NullableContext(2)]
		public SPCG_RoadSplineDecalProperity(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602366C RID: 145004 RVA: 0x00923026 File Offset: 0x00921226
		public SPCG_RoadSplineDecalProperity(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602366D RID: 145005 RVA: 0x00923031 File Offset: 0x00921231
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPCG_RoadSplineDecalProperity(Pointer, false, true);
		}

		// Token: 0x0602366E RID: 145006 RVA: 0x0092303B File Offset: 0x0092123B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPCG_RoadSplineDecalProperity(Pointer, MemoryOwner);
		}

		// Token: 0x04011787 RID: 71559
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/Structure/SPCG_RoadSplineDecalProperity.SPCG_RoadSplineDecalProperity";

		// Token: 0x04011788 RID: 71560
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011789 RID: 71561
		internal static int __PropertyOffset_0;

		// Token: 0x0401178A RID: 71562
		internal static int __PropertyOffset_1;

		// Token: 0x0401178B RID: 71563
		internal static int __PropertyOffset_2;

		// Token: 0x0401178C RID: 71564
		internal static int __PropertyOffset_3;
	}
}
