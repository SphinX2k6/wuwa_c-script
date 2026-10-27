using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUBoxSimulation
{
	// Token: 0x02003CBE RID: 15550
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/struct_XPBD.struct_XPBD")]
	[UnrealStructLayout(92, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 92)]
	public class struct_XPBD : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024BA2 RID: 150434 RVA: 0x00946D68 File Offset: 0x00944F68
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (struct_XPBD._ScriptStructPtr != 0) ? struct_XPBD._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/struct_XPBD.struct_XPBD", ref struct_XPBD._ScriptStructPtr);
		}

		// Token: 0x170048BC RID: 18620
		// (get) Token: 0x06024BA3 RID: 150435 RVA: 0x00946D8C File Offset: 0x00944F8C
		// (set) Token: 0x06024BA4 RID: 150436 RVA: 0x00946D9C File Offset: 0x00944F9C
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170048BD RID: 18621
		// (get) Token: 0x06024BA5 RID: 150437 RVA: 0x00946DAD File Offset: 0x00944FAD
		// (set) Token: 0x06024BA6 RID: 150438 RVA: 0x00946DC1 File Offset: 0x00944FC1
		public unsafe FVector Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170048BE RID: 18622
		// (get) Token: 0x06024BA7 RID: 150439 RVA: 0x00946DD6 File Offset: 0x00944FD6
		// (set) Token: 0x06024BA8 RID: 150440 RVA: 0x00946DE6 File Offset: 0x00944FE6
		public unsafe int neighbour1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170048BF RID: 18623
		// (get) Token: 0x06024BA9 RID: 150441 RVA: 0x00946DF7 File Offset: 0x00944FF7
		// (set) Token: 0x06024BAA RID: 150442 RVA: 0x00946E07 File Offset: 0x00945007
		public unsafe int neighbour2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170048C0 RID: 18624
		// (get) Token: 0x06024BAB RID: 150443 RVA: 0x00946E18 File Offset: 0x00945018
		// (set) Token: 0x06024BAC RID: 150444 RVA: 0x00946E28 File Offset: 0x00945028
		public unsafe int neighbour3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170048C1 RID: 18625
		// (get) Token: 0x06024BAD RID: 150445 RVA: 0x00946E39 File Offset: 0x00945039
		// (set) Token: 0x06024BAE RID: 150446 RVA: 0x00946E49 File Offset: 0x00945049
		public unsafe int neighbour4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170048C2 RID: 18626
		// (get) Token: 0x06024BAF RID: 150447 RVA: 0x00946E5A File Offset: 0x0094505A
		// (set) Token: 0x06024BB0 RID: 150448 RVA: 0x00946E6A File Offset: 0x0094506A
		public unsafe int neighbour5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170048C3 RID: 18627
		// (get) Token: 0x06024BB1 RID: 150449 RVA: 0x00946E7B File Offset: 0x0094507B
		// (set) Token: 0x06024BB2 RID: 150450 RVA: 0x00946E8B File Offset: 0x0094508B
		public unsafe int neighbour6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170048C4 RID: 18628
		// (get) Token: 0x06024BB3 RID: 150451 RVA: 0x00946E9C File Offset: 0x0094509C
		// (set) Token: 0x06024BB4 RID: 150452 RVA: 0x00946EAC File Offset: 0x009450AC
		public unsafe float dis1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170048C5 RID: 18629
		// (get) Token: 0x06024BB5 RID: 150453 RVA: 0x00946EBD File Offset: 0x009450BD
		// (set) Token: 0x06024BB6 RID: 150454 RVA: 0x00946ECD File Offset: 0x009450CD
		public unsafe float dis2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170048C6 RID: 18630
		// (get) Token: 0x06024BB7 RID: 150455 RVA: 0x00946EDE File Offset: 0x009450DE
		// (set) Token: 0x06024BB8 RID: 150456 RVA: 0x00946EEE File Offset: 0x009450EE
		public unsafe float dis3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170048C7 RID: 18631
		// (get) Token: 0x06024BB9 RID: 150457 RVA: 0x00946EFF File Offset: 0x009450FF
		// (set) Token: 0x06024BBA RID: 150458 RVA: 0x00946F0F File Offset: 0x0094510F
		public unsafe float dis4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170048C8 RID: 18632
		// (get) Token: 0x06024BBB RID: 150459 RVA: 0x00946F20 File Offset: 0x00945120
		// (set) Token: 0x06024BBC RID: 150460 RVA: 0x00946F30 File Offset: 0x00945130
		public unsafe float dis5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170048C9 RID: 18633
		// (get) Token: 0x06024BBD RID: 150461 RVA: 0x00946F41 File Offset: 0x00945141
		// (set) Token: 0x06024BBE RID: 150462 RVA: 0x00946F51 File Offset: 0x00945151
		public unsafe float dis6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170048CA RID: 18634
		// (get) Token: 0x06024BBF RID: 150463 RVA: 0x00946F62 File Offset: 0x00945162
		// (set) Token: 0x06024BC0 RID: 150464 RVA: 0x00946F76 File Offset: 0x00945176
		public unsafe FVector N
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170048CB RID: 18635
		// (get) Token: 0x06024BC1 RID: 150465 RVA: 0x00946F8B File Offset: 0x0094518B
		// (set) Token: 0x06024BC2 RID: 150466 RVA: 0x00946F9B File Offset: 0x0094519B
		public unsafe int neighbour7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170048CC RID: 18636
		// (get) Token: 0x06024BC3 RID: 150467 RVA: 0x00946FAC File Offset: 0x009451AC
		// (set) Token: 0x06024BC4 RID: 150468 RVA: 0x00946FBC File Offset: 0x009451BC
		public unsafe int neighbour8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170048CD RID: 18637
		// (get) Token: 0x06024BC5 RID: 150469 RVA: 0x00946FCD File Offset: 0x009451CD
		// (set) Token: 0x06024BC6 RID: 150470 RVA: 0x00946FDD File Offset: 0x009451DD
		public unsafe float dis7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170048CE RID: 18638
		// (get) Token: 0x06024BC7 RID: 150471 RVA: 0x00946FEE File Offset: 0x009451EE
		// (set) Token: 0x06024BC8 RID: 150472 RVA: 0x00946FFE File Offset: 0x009451FE
		public unsafe float dis8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_XPBD.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x06024BC9 RID: 150473 RVA: 0x0094700F File Offset: 0x0094520F
		public struct_XPBD()
		{
		}

		// Token: 0x06024BCA RID: 150474 RVA: 0x00947018 File Offset: 0x00945218
		public struct_XPBD(int Index, FVector Pos, int neighbour1, int neighbour2, int neighbour3, int neighbour4, int neighbour5, int neighbour6, float dis1, float dis2, float dis3, float dis4, float dis5, float dis6, FVector N, int neighbour7, int neighbour8, float dis7, float dis8)
		{
			this.Index = Index;
			this.Pos = Pos;
			this.neighbour1 = neighbour1;
			this.neighbour2 = neighbour2;
			this.neighbour3 = neighbour3;
			this.neighbour4 = neighbour4;
			this.neighbour5 = neighbour5;
			this.neighbour6 = neighbour6;
			this.dis1 = dis1;
			this.dis2 = dis2;
			this.dis3 = dis3;
			this.dis4 = dis4;
			this.dis5 = dis5;
			this.dis6 = dis6;
			this.N = N;
			this.neighbour7 = neighbour7;
			this.neighbour8 = neighbour8;
			this.dis7 = dis7;
			this.dis8 = dis8;
		}

		// Token: 0x06024BCB RID: 150475 RVA: 0x009470C0 File Offset: 0x009452C0
		protected override IntPtr GetUStructPtr()
		{
			return struct_XPBD.StaticStruct();
		}

		// Token: 0x06024BCC RID: 150476 RVA: 0x009470CC File Offset: 0x009452CC
		[NullableContext(2)]
		public struct_XPBD(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024BCD RID: 150477 RVA: 0x009470D6 File Offset: 0x009452D6
		public struct_XPBD(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024BCE RID: 150478 RVA: 0x009470E1 File Offset: 0x009452E1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new struct_XPBD(Pointer, false, true);
		}

		// Token: 0x06024BCF RID: 150479 RVA: 0x009470EB File Offset: 0x009452EB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new struct_XPBD(Pointer, MemoryOwner);
		}

		// Token: 0x040123F5 RID: 74741
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/struct_XPBD.struct_XPBD";

		// Token: 0x040123F6 RID: 74742
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040123F7 RID: 74743
		internal static int __PropertyOffset_0;

		// Token: 0x040123F8 RID: 74744
		internal static int __PropertyOffset_1;

		// Token: 0x040123F9 RID: 74745
		internal static int __PropertyOffset_2;

		// Token: 0x040123FA RID: 74746
		internal static int __PropertyOffset_3;

		// Token: 0x040123FB RID: 74747
		internal static int __PropertyOffset_4;

		// Token: 0x040123FC RID: 74748
		internal static int __PropertyOffset_5;

		// Token: 0x040123FD RID: 74749
		internal static int __PropertyOffset_6;

		// Token: 0x040123FE RID: 74750
		internal static int __PropertyOffset_7;

		// Token: 0x040123FF RID: 74751
		internal static int __PropertyOffset_8;

		// Token: 0x04012400 RID: 74752
		internal static int __PropertyOffset_9;

		// Token: 0x04012401 RID: 74753
		internal static int __PropertyOffset_10;

		// Token: 0x04012402 RID: 74754
		internal static int __PropertyOffset_11;

		// Token: 0x04012403 RID: 74755
		internal static int __PropertyOffset_12;

		// Token: 0x04012404 RID: 74756
		internal static int __PropertyOffset_13;

		// Token: 0x04012405 RID: 74757
		internal static int __PropertyOffset_14;

		// Token: 0x04012406 RID: 74758
		internal static int __PropertyOffset_15;

		// Token: 0x04012407 RID: 74759
		internal static int __PropertyOffset_16;

		// Token: 0x04012408 RID: 74760
		internal static int __PropertyOffset_17;

		// Token: 0x04012409 RID: 74761
		internal static int __PropertyOffset_18;
	}
}
