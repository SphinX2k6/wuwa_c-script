using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUBoxSimulation
{
	// Token: 0x02003CBD RID: 15549
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/struct_genCloth_33.struct_genCloth_33")]
	[UnrealStructLayout(168, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class struct_genCloth_33 : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024B5A RID: 150362 RVA: 0x009467B0 File Offset: 0x009449B0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (struct_genCloth_33._ScriptStructPtr != 0) ? struct_genCloth_33._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/struct_genCloth_33.struct_genCloth_33", ref struct_genCloth_33._ScriptStructPtr);
		}

		// Token: 0x1700489C RID: 18588
		// (get) Token: 0x06024B5B RID: 150363 RVA: 0x009467D4 File Offset: 0x009449D4
		// (set) Token: 0x06024B5C RID: 150364 RVA: 0x009467E4 File Offset: 0x009449E4
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700489D RID: 18589
		// (get) Token: 0x06024B5D RID: 150365 RVA: 0x009467F5 File Offset: 0x009449F5
		// (set) Token: 0x06024B5E RID: 150366 RVA: 0x00946809 File Offset: 0x00944A09
		public unsafe FVector Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700489E RID: 18590
		// (get) Token: 0x06024B5F RID: 150367 RVA: 0x0094681E File Offset: 0x00944A1E
		// (set) Token: 0x06024B60 RID: 150368 RVA: 0x0094682E File Offset: 0x00944A2E
		public unsafe int neighbour1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700489F RID: 18591
		// (get) Token: 0x06024B61 RID: 150369 RVA: 0x0094683F File Offset: 0x00944A3F
		// (set) Token: 0x06024B62 RID: 150370 RVA: 0x0094684F File Offset: 0x00944A4F
		public unsafe int neighbour2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170048A0 RID: 18592
		// (get) Token: 0x06024B63 RID: 150371 RVA: 0x00946860 File Offset: 0x00944A60
		// (set) Token: 0x06024B64 RID: 150372 RVA: 0x00946870 File Offset: 0x00944A70
		public unsafe int neighbour3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170048A1 RID: 18593
		// (get) Token: 0x06024B65 RID: 150373 RVA: 0x00946881 File Offset: 0x00944A81
		// (set) Token: 0x06024B66 RID: 150374 RVA: 0x00946891 File Offset: 0x00944A91
		public unsafe int neighbour4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170048A2 RID: 18594
		// (get) Token: 0x06024B67 RID: 150375 RVA: 0x009468A2 File Offset: 0x00944AA2
		// (set) Token: 0x06024B68 RID: 150376 RVA: 0x009468B2 File Offset: 0x00944AB2
		public unsafe int neighbour5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170048A3 RID: 18595
		// (get) Token: 0x06024B69 RID: 150377 RVA: 0x009468C3 File Offset: 0x00944AC3
		// (set) Token: 0x06024B6A RID: 150378 RVA: 0x009468D3 File Offset: 0x00944AD3
		public unsafe int neighbour6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170048A4 RID: 18596
		// (get) Token: 0x06024B6B RID: 150379 RVA: 0x009468E4 File Offset: 0x00944AE4
		// (set) Token: 0x06024B6C RID: 150380 RVA: 0x009468F4 File Offset: 0x00944AF4
		public unsafe int neighbour7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170048A5 RID: 18597
		// (get) Token: 0x06024B6D RID: 150381 RVA: 0x00946905 File Offset: 0x00944B05
		// (set) Token: 0x06024B6E RID: 150382 RVA: 0x00946915 File Offset: 0x00944B15
		public unsafe int neighbour8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170048A6 RID: 18598
		// (get) Token: 0x06024B6F RID: 150383 RVA: 0x00946926 File Offset: 0x00944B26
		// (set) Token: 0x06024B70 RID: 150384 RVA: 0x00946936 File Offset: 0x00944B36
		public unsafe float dis1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170048A7 RID: 18599
		// (get) Token: 0x06024B71 RID: 150385 RVA: 0x00946947 File Offset: 0x00944B47
		// (set) Token: 0x06024B72 RID: 150386 RVA: 0x00946957 File Offset: 0x00944B57
		public unsafe float dis2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170048A8 RID: 18600
		// (get) Token: 0x06024B73 RID: 150387 RVA: 0x00946968 File Offset: 0x00944B68
		// (set) Token: 0x06024B74 RID: 150388 RVA: 0x00946978 File Offset: 0x00944B78
		public unsafe float dis3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170048A9 RID: 18601
		// (get) Token: 0x06024B75 RID: 150389 RVA: 0x00946989 File Offset: 0x00944B89
		// (set) Token: 0x06024B76 RID: 150390 RVA: 0x00946999 File Offset: 0x00944B99
		public unsafe float dis4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170048AA RID: 18602
		// (get) Token: 0x06024B77 RID: 150391 RVA: 0x009469AA File Offset: 0x00944BAA
		// (set) Token: 0x06024B78 RID: 150392 RVA: 0x009469BA File Offset: 0x00944BBA
		public unsafe float dis5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170048AB RID: 18603
		// (get) Token: 0x06024B79 RID: 150393 RVA: 0x009469CB File Offset: 0x00944BCB
		// (set) Token: 0x06024B7A RID: 150394 RVA: 0x009469DB File Offset: 0x00944BDB
		public unsafe float dis6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170048AC RID: 18604
		// (get) Token: 0x06024B7B RID: 150395 RVA: 0x009469EC File Offset: 0x00944BEC
		// (set) Token: 0x06024B7C RID: 150396 RVA: 0x009469FC File Offset: 0x00944BFC
		public unsafe float dis7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170048AD RID: 18605
		// (get) Token: 0x06024B7D RID: 150397 RVA: 0x00946A0D File Offset: 0x00944C0D
		// (set) Token: 0x06024B7E RID: 150398 RVA: 0x00946A1D File Offset: 0x00944C1D
		public unsafe float dis8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170048AE RID: 18606
		// (get) Token: 0x06024B7F RID: 150399 RVA: 0x00946A2E File Offset: 0x00944C2E
		// (set) Token: 0x06024B80 RID: 150400 RVA: 0x00946A3E File Offset: 0x00944C3E
		public unsafe int isPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170048AF RID: 18607
		// (get) Token: 0x06024B81 RID: 150401 RVA: 0x00946A4F File Offset: 0x00944C4F
		// (set) Token: 0x06024B82 RID: 150402 RVA: 0x00946A5F File Offset: 0x00944C5F
		public unsafe float bending_rest_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170048B0 RID: 18608
		// (get) Token: 0x06024B83 RID: 150403 RVA: 0x00946A70 File Offset: 0x00944C70
		// (set) Token: 0x06024B84 RID: 150404 RVA: 0x00946A80 File Offset: 0x00944C80
		public unsafe float bending_rest_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170048B1 RID: 18609
		// (get) Token: 0x06024B85 RID: 150405 RVA: 0x00946A91 File Offset: 0x00944C91
		// (set) Token: 0x06024B86 RID: 150406 RVA: 0x00946AA1 File Offset: 0x00944CA1
		public unsafe float bending_rest_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170048B2 RID: 18610
		// (get) Token: 0x06024B87 RID: 150407 RVA: 0x00946AB2 File Offset: 0x00944CB2
		// (set) Token: 0x06024B88 RID: 150408 RVA: 0x00946AC2 File Offset: 0x00944CC2
		public unsafe float bending_rest_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170048B3 RID: 18611
		// (get) Token: 0x06024B89 RID: 150409 RVA: 0x00946AD3 File Offset: 0x00944CD3
		// (set) Token: 0x06024B8A RID: 150410 RVA: 0x00946AE3 File Offset: 0x00944CE3
		public unsafe int bending_self_idx_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170048B4 RID: 18612
		// (get) Token: 0x06024B8B RID: 150411 RVA: 0x00946AF4 File Offset: 0x00944CF4
		// (set) Token: 0x06024B8C RID: 150412 RVA: 0x00946B04 File Offset: 0x00944D04
		public unsafe int bending_self_idx_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170048B5 RID: 18613
		// (get) Token: 0x06024B8D RID: 150413 RVA: 0x00946B15 File Offset: 0x00944D15
		// (set) Token: 0x06024B8E RID: 150414 RVA: 0x00946B25 File Offset: 0x00944D25
		public unsafe int bending_self_idx_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170048B6 RID: 18614
		// (get) Token: 0x06024B8F RID: 150415 RVA: 0x00946B36 File Offset: 0x00944D36
		// (set) Token: 0x06024B90 RID: 150416 RVA: 0x00946B46 File Offset: 0x00944D46
		public unsafe int bending_self_idx_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170048B7 RID: 18615
		// (get) Token: 0x06024B91 RID: 150417 RVA: 0x00946B57 File Offset: 0x00944D57
		// (set) Token: 0x06024B92 RID: 150418 RVA: 0x00946B6B File Offset: 0x00944D6B
		public unsafe FVector bending_nbs_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x170048B8 RID: 18616
		// (get) Token: 0x06024B93 RID: 150419 RVA: 0x00946B80 File Offset: 0x00944D80
		// (set) Token: 0x06024B94 RID: 150420 RVA: 0x00946B94 File Offset: 0x00944D94
		public unsafe FVector bending_nbs_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170048B9 RID: 18617
		// (get) Token: 0x06024B95 RID: 150421 RVA: 0x00946BA9 File Offset: 0x00944DA9
		// (set) Token: 0x06024B96 RID: 150422 RVA: 0x00946BBD File Offset: 0x00944DBD
		public unsafe FVector bending_nbs_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170048BA RID: 18618
		// (get) Token: 0x06024B97 RID: 150423 RVA: 0x00946BD2 File Offset: 0x00944DD2
		// (set) Token: 0x06024B98 RID: 150424 RVA: 0x00946BE6 File Offset: 0x00944DE6
		public unsafe FVector bending_nbs_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x170048BB RID: 18619
		// (get) Token: 0x06024B99 RID: 150425 RVA: 0x00946BFB File Offset: 0x00944DFB
		// (set) Token: 0x06024B9A RID: 150426 RVA: 0x00946C0B File Offset: 0x00944E0B
		public unsafe int deadNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth_33.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x06024B9B RID: 150427 RVA: 0x00946C1C File Offset: 0x00944E1C
		public struct_genCloth_33()
		{
		}

		// Token: 0x06024B9C RID: 150428 RVA: 0x00946C24 File Offset: 0x00944E24
		public struct_genCloth_33(int Index, FVector Pos, int neighbour1, int neighbour2, int neighbour3, int neighbour4, int neighbour5, int neighbour6, int neighbour7, int neighbour8, float dis1, float dis2, float dis3, float dis4, float dis5, float dis6, float dis7, float dis8, int isPinned, float bending_rest_0, float bending_rest_1, float bending_rest_2, float bending_rest_3, int bending_self_idx_0, int bending_self_idx_1, int bending_self_idx_2, int bending_self_idx_3, FVector bending_nbs_0, FVector bending_nbs_1, FVector bending_nbs_2, FVector bending_nbs_3, int deadNode)
		{
			this.Index = Index;
			this.Pos = Pos;
			this.neighbour1 = neighbour1;
			this.neighbour2 = neighbour2;
			this.neighbour3 = neighbour3;
			this.neighbour4 = neighbour4;
			this.neighbour5 = neighbour5;
			this.neighbour6 = neighbour6;
			this.neighbour7 = neighbour7;
			this.neighbour8 = neighbour8;
			this.dis1 = dis1;
			this.dis2 = dis2;
			this.dis3 = dis3;
			this.dis4 = dis4;
			this.dis5 = dis5;
			this.dis6 = dis6;
			this.dis7 = dis7;
			this.dis8 = dis8;
			this.isPinned = isPinned;
			this.bending_rest_0 = bending_rest_0;
			this.bending_rest_1 = bending_rest_1;
			this.bending_rest_2 = bending_rest_2;
			this.bending_rest_3 = bending_rest_3;
			this.bending_self_idx_0 = bending_self_idx_0;
			this.bending_self_idx_1 = bending_self_idx_1;
			this.bending_self_idx_2 = bending_self_idx_2;
			this.bending_self_idx_3 = bending_self_idx_3;
			this.bending_nbs_0 = bending_nbs_0;
			this.bending_nbs_1 = bending_nbs_1;
			this.bending_nbs_2 = bending_nbs_2;
			this.bending_nbs_3 = bending_nbs_3;
			this.deadNode = deadNode;
		}

		// Token: 0x06024B9D RID: 150429 RVA: 0x00946D34 File Offset: 0x00944F34
		protected override IntPtr GetUStructPtr()
		{
			return struct_genCloth_33.StaticStruct();
		}

		// Token: 0x06024B9E RID: 150430 RVA: 0x00946D40 File Offset: 0x00944F40
		[NullableContext(2)]
		public struct_genCloth_33(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024B9F RID: 150431 RVA: 0x00946D4A File Offset: 0x00944F4A
		public struct_genCloth_33(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024BA0 RID: 150432 RVA: 0x00946D55 File Offset: 0x00944F55
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new struct_genCloth_33(Pointer, false, true);
		}

		// Token: 0x06024BA1 RID: 150433 RVA: 0x00946D5F File Offset: 0x00944F5F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new struct_genCloth_33(Pointer, MemoryOwner);
		}

		// Token: 0x040123D3 RID: 74707
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/struct_genCloth_33.struct_genCloth_33";

		// Token: 0x040123D4 RID: 74708
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040123D5 RID: 74709
		internal static int __PropertyOffset_0;

		// Token: 0x040123D6 RID: 74710
		internal static int __PropertyOffset_1;

		// Token: 0x040123D7 RID: 74711
		internal static int __PropertyOffset_2;

		// Token: 0x040123D8 RID: 74712
		internal static int __PropertyOffset_3;

		// Token: 0x040123D9 RID: 74713
		internal static int __PropertyOffset_4;

		// Token: 0x040123DA RID: 74714
		internal static int __PropertyOffset_5;

		// Token: 0x040123DB RID: 74715
		internal static int __PropertyOffset_6;

		// Token: 0x040123DC RID: 74716
		internal static int __PropertyOffset_7;

		// Token: 0x040123DD RID: 74717
		internal static int __PropertyOffset_8;

		// Token: 0x040123DE RID: 74718
		internal static int __PropertyOffset_9;

		// Token: 0x040123DF RID: 74719
		internal static int __PropertyOffset_10;

		// Token: 0x040123E0 RID: 74720
		internal static int __PropertyOffset_11;

		// Token: 0x040123E1 RID: 74721
		internal static int __PropertyOffset_12;

		// Token: 0x040123E2 RID: 74722
		internal static int __PropertyOffset_13;

		// Token: 0x040123E3 RID: 74723
		internal static int __PropertyOffset_14;

		// Token: 0x040123E4 RID: 74724
		internal static int __PropertyOffset_15;

		// Token: 0x040123E5 RID: 74725
		internal static int __PropertyOffset_16;

		// Token: 0x040123E6 RID: 74726
		internal static int __PropertyOffset_17;

		// Token: 0x040123E7 RID: 74727
		internal static int __PropertyOffset_18;

		// Token: 0x040123E8 RID: 74728
		internal static int __PropertyOffset_19;

		// Token: 0x040123E9 RID: 74729
		internal static int __PropertyOffset_20;

		// Token: 0x040123EA RID: 74730
		internal static int __PropertyOffset_21;

		// Token: 0x040123EB RID: 74731
		internal static int __PropertyOffset_22;

		// Token: 0x040123EC RID: 74732
		internal static int __PropertyOffset_23;

		// Token: 0x040123ED RID: 74733
		internal static int __PropertyOffset_24;

		// Token: 0x040123EE RID: 74734
		internal static int __PropertyOffset_25;

		// Token: 0x040123EF RID: 74735
		internal static int __PropertyOffset_26;

		// Token: 0x040123F0 RID: 74736
		internal static int __PropertyOffset_27;

		// Token: 0x040123F1 RID: 74737
		internal static int __PropertyOffset_28;

		// Token: 0x040123F2 RID: 74738
		internal static int __PropertyOffset_29;

		// Token: 0x040123F3 RID: 74739
		internal static int __PropertyOffset_30;

		// Token: 0x040123F4 RID: 74740
		internal static int __PropertyOffset_31;
	}
}
