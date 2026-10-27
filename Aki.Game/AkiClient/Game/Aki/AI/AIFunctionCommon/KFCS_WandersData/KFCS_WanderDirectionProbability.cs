using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon.KFCS_WandersData
{
	// Token: 0x02004445 RID: 17477
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/KFCS_WanderDirectionProbability.KFCS_WanderDirectionProbability")]
	[UnrealStructLayout(72, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class KFCS_WanderDirectionProbability : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D3C9 RID: 185289 RVA: 0x00A37716 File Offset: 0x00A35916
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (KFCS_WanderDirectionProbability._ScriptStructPtr != 0) ? KFCS_WanderDirectionProbability._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/KFCS_WanderDirectionProbability.KFCS_WanderDirectionProbability", ref KFCS_WanderDirectionProbability._ScriptStructPtr);
		}

		// Token: 0x170072A9 RID: 29353
		// (get) Token: 0x0602D3CA RID: 185290 RVA: 0x00A3773A File Offset: 0x00A3593A
		// (set) Token: 0x0602D3CB RID: 185291 RVA: 0x00A3774A File Offset: 0x00A3594A
		public unsafe float 近距离前走概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170072AA RID: 29354
		// (get) Token: 0x0602D3CC RID: 185292 RVA: 0x00A3775B File Offset: 0x00A3595B
		// (set) Token: 0x0602D3CD RID: 185293 RVA: 0x00A3776B File Offset: 0x00A3596B
		public unsafe float 近距离后走概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170072AB RID: 29355
		// (get) Token: 0x0602D3CE RID: 185294 RVA: 0x00A3777C File Offset: 0x00A3597C
		// (set) Token: 0x0602D3CF RID: 185295 RVA: 0x00A3778C File Offset: 0x00A3598C
		public unsafe float 近距离左走概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170072AC RID: 29356
		// (get) Token: 0x0602D3D0 RID: 185296 RVA: 0x00A3779D File Offset: 0x00A3599D
		// (set) Token: 0x0602D3D1 RID: 185297 RVA: 0x00A377AD File Offset: 0x00A359AD
		public unsafe float 近距离右走概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170072AD RID: 29357
		// (get) Token: 0x0602D3D2 RID: 185298 RVA: 0x00A377BE File Offset: 0x00A359BE
		// (set) Token: 0x0602D3D3 RID: 185299 RVA: 0x00A377CE File Offset: 0x00A359CE
		public unsafe float 近距离发呆概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170072AE RID: 29358
		// (get) Token: 0x0602D3D4 RID: 185300 RVA: 0x00A377DF File Offset: 0x00A359DF
		// (set) Token: 0x0602D3D5 RID: 185301 RVA: 0x00A377EF File Offset: 0x00A359EF
		public unsafe float 中距离前走概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170072AF RID: 29359
		// (get) Token: 0x0602D3D6 RID: 185302 RVA: 0x00A37800 File Offset: 0x00A35A00
		// (set) Token: 0x0602D3D7 RID: 185303 RVA: 0x00A37810 File Offset: 0x00A35A10
		public unsafe float 中距离后走概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170072B0 RID: 29360
		// (get) Token: 0x0602D3D8 RID: 185304 RVA: 0x00A37821 File Offset: 0x00A35A21
		// (set) Token: 0x0602D3D9 RID: 185305 RVA: 0x00A37831 File Offset: 0x00A35A31
		public unsafe float 中距离左走概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170072B1 RID: 29361
		// (get) Token: 0x0602D3DA RID: 185306 RVA: 0x00A37842 File Offset: 0x00A35A42
		// (set) Token: 0x0602D3DB RID: 185307 RVA: 0x00A37852 File Offset: 0x00A35A52
		public unsafe float 中距离右走概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170072B2 RID: 29362
		// (get) Token: 0x0602D3DC RID: 185308 RVA: 0x00A37863 File Offset: 0x00A35A63
		// (set) Token: 0x0602D3DD RID: 185309 RVA: 0x00A37873 File Offset: 0x00A35A73
		public unsafe float 中距离发呆概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170072B3 RID: 29363
		// (get) Token: 0x0602D3DE RID: 185310 RVA: 0x00A37884 File Offset: 0x00A35A84
		// (set) Token: 0x0602D3DF RID: 185311 RVA: 0x00A37894 File Offset: 0x00A35A94
		public unsafe float 远距离前走概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170072B4 RID: 29364
		// (get) Token: 0x0602D3E0 RID: 185312 RVA: 0x00A378A5 File Offset: 0x00A35AA5
		// (set) Token: 0x0602D3E1 RID: 185313 RVA: 0x00A378B5 File Offset: 0x00A35AB5
		public unsafe float 远距离后走概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170072B5 RID: 29365
		// (get) Token: 0x0602D3E2 RID: 185314 RVA: 0x00A378C6 File Offset: 0x00A35AC6
		// (set) Token: 0x0602D3E3 RID: 185315 RVA: 0x00A378D6 File Offset: 0x00A35AD6
		public unsafe float 远距离左走概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170072B6 RID: 29366
		// (get) Token: 0x0602D3E4 RID: 185316 RVA: 0x00A378E7 File Offset: 0x00A35AE7
		// (set) Token: 0x0602D3E5 RID: 185317 RVA: 0x00A378F7 File Offset: 0x00A35AF7
		public unsafe float 远距离右走概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170072B7 RID: 29367
		// (get) Token: 0x0602D3E6 RID: 185318 RVA: 0x00A37908 File Offset: 0x00A35B08
		// (set) Token: 0x0602D3E7 RID: 185319 RVA: 0x00A37918 File Offset: 0x00A35B18
		public unsafe float 远距离发呆概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170072B8 RID: 29368
		// (get) Token: 0x0602D3E8 RID: 185320 RVA: 0x00A37929 File Offset: 0x00A35B29
		// (set) Token: 0x0602D3E9 RID: 185321 RVA: 0x00A37939 File Offset: 0x00A35B39
		public unsafe float 近距离乱序移动的概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170072B9 RID: 29369
		// (get) Token: 0x0602D3EA RID: 185322 RVA: 0x00A3794A File Offset: 0x00A35B4A
		// (set) Token: 0x0602D3EB RID: 185323 RVA: 0x00A3795A File Offset: 0x00A35B5A
		public unsafe float 中距离乱序移动的概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170072BA RID: 29370
		// (get) Token: 0x0602D3EC RID: 185324 RVA: 0x00A3796B File Offset: 0x00A35B6B
		// (set) Token: 0x0602D3ED RID: 185325 RVA: 0x00A3797B File Offset: 0x00A35B7B
		public unsafe float 远距离乱序移动的概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WanderDirectionProbability.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x0602D3EE RID: 185326 RVA: 0x00A3798C File Offset: 0x00A35B8C
		public KFCS_WanderDirectionProbability()
		{
		}

		// Token: 0x0602D3EF RID: 185327 RVA: 0x00A37994 File Offset: 0x00A35B94
		public KFCS_WanderDirectionProbability(float 近距离前走概率, float 近距离后走概率, float 近距离左走概率, float 近距离右走概率, float 近距离发呆概率, float 中距离前走概率, float 中距离后走概率, float 中距离左走概率, float 中距离右走概率, float 中距离发呆概率, float 远距离前走概率, float 远距离后走概率, float 远距离左走概率, float 远距离右走概率, float 远距离发呆概率, float 近距离乱序移动的概率, float 中距离乱序移动的概率, float 远距离乱序移动的概率)
		{
			this.近距离前走概率 = 近距离前走概率;
			this.近距离后走概率 = 近距离后走概率;
			this.近距离左走概率 = 近距离左走概率;
			this.近距离右走概率 = 近距离右走概率;
			this.近距离发呆概率 = 近距离发呆概率;
			this.中距离前走概率 = 中距离前走概率;
			this.中距离后走概率 = 中距离后走概率;
			this.中距离左走概率 = 中距离左走概率;
			this.中距离右走概率 = 中距离右走概率;
			this.中距离发呆概率 = 中距离发呆概率;
			this.远距离前走概率 = 远距离前走概率;
			this.远距离后走概率 = 远距离后走概率;
			this.远距离左走概率 = 远距离左走概率;
			this.远距离右走概率 = 远距离右走概率;
			this.远距离发呆概率 = 远距离发呆概率;
			this.近距离乱序移动的概率 = 近距离乱序移动的概率;
			this.中距离乱序移动的概率 = 中距离乱序移动的概率;
			this.远距离乱序移动的概率 = 远距离乱序移动的概率;
		}

		// Token: 0x0602D3F0 RID: 185328 RVA: 0x00A37A34 File Offset: 0x00A35C34
		protected override IntPtr GetUStructPtr()
		{
			return KFCS_WanderDirectionProbability.StaticStruct();
		}

		// Token: 0x0602D3F1 RID: 185329 RVA: 0x00A37A40 File Offset: 0x00A35C40
		[NullableContext(2)]
		public KFCS_WanderDirectionProbability(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D3F2 RID: 185330 RVA: 0x00A37A4A File Offset: 0x00A35C4A
		public KFCS_WanderDirectionProbability(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D3F3 RID: 185331 RVA: 0x00A37A55 File Offset: 0x00A35C55
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new KFCS_WanderDirectionProbability(Pointer, false, true);
		}

		// Token: 0x0602D3F4 RID: 185332 RVA: 0x00A37A5F File Offset: 0x00A35C5F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new KFCS_WanderDirectionProbability(Pointer, MemoryOwner);
		}

		// Token: 0x0401810F RID: 98575
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/KFCS_WanderDirectionProbability.KFCS_WanderDirectionProbability";

		// Token: 0x04018110 RID: 98576
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04018111 RID: 98577
		internal static int __PropertyOffset_0;

		// Token: 0x04018112 RID: 98578
		internal static int __PropertyOffset_1;

		// Token: 0x04018113 RID: 98579
		internal static int __PropertyOffset_2;

		// Token: 0x04018114 RID: 98580
		internal static int __PropertyOffset_3;

		// Token: 0x04018115 RID: 98581
		internal static int __PropertyOffset_4;

		// Token: 0x04018116 RID: 98582
		internal static int __PropertyOffset_5;

		// Token: 0x04018117 RID: 98583
		internal static int __PropertyOffset_6;

		// Token: 0x04018118 RID: 98584
		internal static int __PropertyOffset_7;

		// Token: 0x04018119 RID: 98585
		internal static int __PropertyOffset_8;

		// Token: 0x0401811A RID: 98586
		internal static int __PropertyOffset_9;

		// Token: 0x0401811B RID: 98587
		internal static int __PropertyOffset_10;

		// Token: 0x0401811C RID: 98588
		internal static int __PropertyOffset_11;

		// Token: 0x0401811D RID: 98589
		internal static int __PropertyOffset_12;

		// Token: 0x0401811E RID: 98590
		internal static int __PropertyOffset_13;

		// Token: 0x0401811F RID: 98591
		internal static int __PropertyOffset_14;

		// Token: 0x04018120 RID: 98592
		internal static int __PropertyOffset_15;

		// Token: 0x04018121 RID: 98593
		internal static int __PropertyOffset_16;

		// Token: 0x04018122 RID: 98594
		internal static int __PropertyOffset_17;
	}
}
