using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUBoxSimulation
{
	// Token: 0x02003CBC RID: 15548
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/struct_genCloth.struct_genCloth")]
	[UnrealStructLayout(128, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class struct_genCloth : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024B1A RID: 150298 RVA: 0x009462B4 File Offset: 0x009444B4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (struct_genCloth._ScriptStructPtr != 0) ? struct_genCloth._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/struct_genCloth.struct_genCloth", ref struct_genCloth._ScriptStructPtr);
		}

		// Token: 0x17004880 RID: 18560
		// (get) Token: 0x06024B1B RID: 150299 RVA: 0x009462D8 File Offset: 0x009444D8
		// (set) Token: 0x06024B1C RID: 150300 RVA: 0x009462E8 File Offset: 0x009444E8
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17004881 RID: 18561
		// (get) Token: 0x06024B1D RID: 150301 RVA: 0x009462F9 File Offset: 0x009444F9
		// (set) Token: 0x06024B1E RID: 150302 RVA: 0x0094630D File Offset: 0x0094450D
		public unsafe FVector Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17004882 RID: 18562
		// (get) Token: 0x06024B1F RID: 150303 RVA: 0x00946322 File Offset: 0x00944522
		// (set) Token: 0x06024B20 RID: 150304 RVA: 0x00946332 File Offset: 0x00944532
		public unsafe int neighbour1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17004883 RID: 18563
		// (get) Token: 0x06024B21 RID: 150305 RVA: 0x00946343 File Offset: 0x00944543
		// (set) Token: 0x06024B22 RID: 150306 RVA: 0x00946353 File Offset: 0x00944553
		public unsafe int neighbour2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004884 RID: 18564
		// (get) Token: 0x06024B23 RID: 150307 RVA: 0x00946364 File Offset: 0x00944564
		// (set) Token: 0x06024B24 RID: 150308 RVA: 0x00946374 File Offset: 0x00944574
		public unsafe int neighbour3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004885 RID: 18565
		// (get) Token: 0x06024B25 RID: 150309 RVA: 0x00946385 File Offset: 0x00944585
		// (set) Token: 0x06024B26 RID: 150310 RVA: 0x00946395 File Offset: 0x00944595
		public unsafe int neighbour4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004886 RID: 18566
		// (get) Token: 0x06024B27 RID: 150311 RVA: 0x009463A6 File Offset: 0x009445A6
		// (set) Token: 0x06024B28 RID: 150312 RVA: 0x009463B6 File Offset: 0x009445B6
		public unsafe int neighbour5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004887 RID: 18567
		// (get) Token: 0x06024B29 RID: 150313 RVA: 0x009463C7 File Offset: 0x009445C7
		// (set) Token: 0x06024B2A RID: 150314 RVA: 0x009463D7 File Offset: 0x009445D7
		public unsafe int neighbour6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004888 RID: 18568
		// (get) Token: 0x06024B2B RID: 150315 RVA: 0x009463E8 File Offset: 0x009445E8
		// (set) Token: 0x06024B2C RID: 150316 RVA: 0x009463F8 File Offset: 0x009445F8
		public unsafe int neighbour7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004889 RID: 18569
		// (get) Token: 0x06024B2D RID: 150317 RVA: 0x00946409 File Offset: 0x00944609
		// (set) Token: 0x06024B2E RID: 150318 RVA: 0x00946419 File Offset: 0x00944619
		public unsafe int neighbour8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700488A RID: 18570
		// (get) Token: 0x06024B2F RID: 150319 RVA: 0x0094642A File Offset: 0x0094462A
		// (set) Token: 0x06024B30 RID: 150320 RVA: 0x0094643A File Offset: 0x0094463A
		public unsafe float dis1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700488B RID: 18571
		// (get) Token: 0x06024B31 RID: 150321 RVA: 0x0094644B File Offset: 0x0094464B
		// (set) Token: 0x06024B32 RID: 150322 RVA: 0x0094645B File Offset: 0x0094465B
		public unsafe float dis2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700488C RID: 18572
		// (get) Token: 0x06024B33 RID: 150323 RVA: 0x0094646C File Offset: 0x0094466C
		// (set) Token: 0x06024B34 RID: 150324 RVA: 0x0094647C File Offset: 0x0094467C
		public unsafe float dis3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700488D RID: 18573
		// (get) Token: 0x06024B35 RID: 150325 RVA: 0x0094648D File Offset: 0x0094468D
		// (set) Token: 0x06024B36 RID: 150326 RVA: 0x0094649D File Offset: 0x0094469D
		public unsafe float dis4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700488E RID: 18574
		// (get) Token: 0x06024B37 RID: 150327 RVA: 0x009464AE File Offset: 0x009446AE
		// (set) Token: 0x06024B38 RID: 150328 RVA: 0x009464BE File Offset: 0x009446BE
		public unsafe float dis5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700488F RID: 18575
		// (get) Token: 0x06024B39 RID: 150329 RVA: 0x009464CF File Offset: 0x009446CF
		// (set) Token: 0x06024B3A RID: 150330 RVA: 0x009464DF File Offset: 0x009446DF
		public unsafe float dis6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004890 RID: 18576
		// (get) Token: 0x06024B3B RID: 150331 RVA: 0x009464F0 File Offset: 0x009446F0
		// (set) Token: 0x06024B3C RID: 150332 RVA: 0x00946500 File Offset: 0x00944700
		public unsafe float dis7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004891 RID: 18577
		// (get) Token: 0x06024B3D RID: 150333 RVA: 0x00946511 File Offset: 0x00944711
		// (set) Token: 0x06024B3E RID: 150334 RVA: 0x00946521 File Offset: 0x00944721
		public unsafe float dis8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004892 RID: 18578
		// (get) Token: 0x06024B3F RID: 150335 RVA: 0x00946532 File Offset: 0x00944732
		// (set) Token: 0x06024B40 RID: 150336 RVA: 0x00946546 File Offset: 0x00944746
		public unsafe FVector N
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004893 RID: 18579
		// (get) Token: 0x06024B41 RID: 150337 RVA: 0x0094655B File Offset: 0x0094475B
		// (set) Token: 0x06024B42 RID: 150338 RVA: 0x0094656B File Offset: 0x0094476B
		public unsafe int isPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004894 RID: 18580
		// (get) Token: 0x06024B43 RID: 150339 RVA: 0x0094657C File Offset: 0x0094477C
		// (set) Token: 0x06024B44 RID: 150340 RVA: 0x0094658C File Offset: 0x0094478C
		public unsafe float bend1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004895 RID: 18581
		// (get) Token: 0x06024B45 RID: 150341 RVA: 0x0094659D File Offset: 0x0094479D
		// (set) Token: 0x06024B46 RID: 150342 RVA: 0x009465AD File Offset: 0x009447AD
		public unsafe float bend2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004896 RID: 18582
		// (get) Token: 0x06024B47 RID: 150343 RVA: 0x009465BE File Offset: 0x009447BE
		// (set) Token: 0x06024B48 RID: 150344 RVA: 0x009465CE File Offset: 0x009447CE
		public unsafe float bend3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004897 RID: 18583
		// (get) Token: 0x06024B49 RID: 150345 RVA: 0x009465DF File Offset: 0x009447DF
		// (set) Token: 0x06024B4A RID: 150346 RVA: 0x009465EF File Offset: 0x009447EF
		public unsafe float bend4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004898 RID: 18584
		// (get) Token: 0x06024B4B RID: 150347 RVA: 0x00946600 File Offset: 0x00944800
		// (set) Token: 0x06024B4C RID: 150348 RVA: 0x00946610 File Offset: 0x00944810
		public unsafe float bend5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004899 RID: 18585
		// (get) Token: 0x06024B4D RID: 150349 RVA: 0x00946621 File Offset: 0x00944821
		// (set) Token: 0x06024B4E RID: 150350 RVA: 0x00946631 File Offset: 0x00944831
		public unsafe float bend6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x1700489A RID: 18586
		// (get) Token: 0x06024B4F RID: 150351 RVA: 0x00946642 File Offset: 0x00944842
		// (set) Token: 0x06024B50 RID: 150352 RVA: 0x00946652 File Offset: 0x00944852
		public unsafe float bend7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x1700489B RID: 18587
		// (get) Token: 0x06024B51 RID: 150353 RVA: 0x00946663 File Offset: 0x00944863
		// (set) Token: 0x06024B52 RID: 150354 RVA: 0x00946673 File Offset: 0x00944873
		public unsafe float bend8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)struct_genCloth.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x06024B53 RID: 150355 RVA: 0x00946684 File Offset: 0x00944884
		public struct_genCloth()
		{
		}

		// Token: 0x06024B54 RID: 150356 RVA: 0x0094668C File Offset: 0x0094488C
		public struct_genCloth(int Index, FVector Pos, int neighbour1, int neighbour2, int neighbour3, int neighbour4, int neighbour5, int neighbour6, int neighbour7, int neighbour8, float dis1, float dis2, float dis3, float dis4, float dis5, float dis6, float dis7, float dis8, FVector N, int isPinned, float bend1, float bend2, float bend3, float bend4, float bend5, float bend6, float bend7, float bend8)
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
			this.N = N;
			this.isPinned = isPinned;
			this.bend1 = bend1;
			this.bend2 = bend2;
			this.bend3 = bend3;
			this.bend4 = bend4;
			this.bend5 = bend5;
			this.bend6 = bend6;
			this.bend7 = bend7;
			this.bend8 = bend8;
		}

		// Token: 0x06024B55 RID: 150357 RVA: 0x0094677C File Offset: 0x0094497C
		protected override IntPtr GetUStructPtr()
		{
			return struct_genCloth.StaticStruct();
		}

		// Token: 0x06024B56 RID: 150358 RVA: 0x00946788 File Offset: 0x00944988
		[NullableContext(2)]
		public struct_genCloth(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024B57 RID: 150359 RVA: 0x00946792 File Offset: 0x00944992
		public struct_genCloth(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024B58 RID: 150360 RVA: 0x0094679D File Offset: 0x0094499D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new struct_genCloth(Pointer, false, true);
		}

		// Token: 0x06024B59 RID: 150361 RVA: 0x009467A7 File Offset: 0x009449A7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new struct_genCloth(Pointer, MemoryOwner);
		}

		// Token: 0x040123B5 RID: 74677
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/struct_genCloth.struct_genCloth";

		// Token: 0x040123B6 RID: 74678
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040123B7 RID: 74679
		internal static int __PropertyOffset_0;

		// Token: 0x040123B8 RID: 74680
		internal static int __PropertyOffset_1;

		// Token: 0x040123B9 RID: 74681
		internal static int __PropertyOffset_2;

		// Token: 0x040123BA RID: 74682
		internal static int __PropertyOffset_3;

		// Token: 0x040123BB RID: 74683
		internal static int __PropertyOffset_4;

		// Token: 0x040123BC RID: 74684
		internal static int __PropertyOffset_5;

		// Token: 0x040123BD RID: 74685
		internal static int __PropertyOffset_6;

		// Token: 0x040123BE RID: 74686
		internal static int __PropertyOffset_7;

		// Token: 0x040123BF RID: 74687
		internal static int __PropertyOffset_8;

		// Token: 0x040123C0 RID: 74688
		internal static int __PropertyOffset_9;

		// Token: 0x040123C1 RID: 74689
		internal static int __PropertyOffset_10;

		// Token: 0x040123C2 RID: 74690
		internal static int __PropertyOffset_11;

		// Token: 0x040123C3 RID: 74691
		internal static int __PropertyOffset_12;

		// Token: 0x040123C4 RID: 74692
		internal static int __PropertyOffset_13;

		// Token: 0x040123C5 RID: 74693
		internal static int __PropertyOffset_14;

		// Token: 0x040123C6 RID: 74694
		internal static int __PropertyOffset_15;

		// Token: 0x040123C7 RID: 74695
		internal static int __PropertyOffset_16;

		// Token: 0x040123C8 RID: 74696
		internal static int __PropertyOffset_17;

		// Token: 0x040123C9 RID: 74697
		internal static int __PropertyOffset_18;

		// Token: 0x040123CA RID: 74698
		internal static int __PropertyOffset_19;

		// Token: 0x040123CB RID: 74699
		internal static int __PropertyOffset_20;

		// Token: 0x040123CC RID: 74700
		internal static int __PropertyOffset_21;

		// Token: 0x040123CD RID: 74701
		internal static int __PropertyOffset_22;

		// Token: 0x040123CE RID: 74702
		internal static int __PropertyOffset_23;

		// Token: 0x040123CF RID: 74703
		internal static int __PropertyOffset_24;

		// Token: 0x040123D0 RID: 74704
		internal static int __PropertyOffset_25;

		// Token: 0x040123D1 RID: 74705
		internal static int __PropertyOffset_26;

		// Token: 0x040123D2 RID: 74706
		internal static int __PropertyOffset_27;
	}
}
