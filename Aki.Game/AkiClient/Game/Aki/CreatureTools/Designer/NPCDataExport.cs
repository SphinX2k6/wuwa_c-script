using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.CreatureTools.Designer
{
	// Token: 0x02003FCE RID: 16334
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/CreatureTools/Designer/NPCDataExport.NPCDataExport")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class NPCDataExport : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029D19 RID: 171289 RVA: 0x009CD2AA File Offset: 0x009CB4AA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (NPCDataExport._ScriptStructPtr != 0) ? NPCDataExport._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/CreatureTools/Designer/NPCDataExport.NPCDataExport", ref NPCDataExport._ScriptStructPtr);
		}

		// Token: 0x17006563 RID: 25955
		// (get) Token: 0x06029D1A RID: 171290 RVA: 0x009CD2CE File Offset: 0x009CB4CE
		// (set) Token: 0x06029D1B RID: 171291 RVA: 0x009CD2E2 File Offset: 0x009CB4E2
		public unsafe string 名称
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NPCDataExport.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NPCDataExport.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006564 RID: 25956
		// (get) Token: 0x06029D1C RID: 171292 RVA: 0x009CD2F7 File Offset: 0x009CB4F7
		// (set) Token: 0x06029D1D RID: 171293 RVA: 0x009CD30B File Offset: 0x009CB50B
		public unsafe string 实体描述
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NPCDataExport.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NPCDataExport.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006565 RID: 25957
		// (get) Token: 0x06029D1E RID: 171294 RVA: 0x009CD320 File Offset: 0x009CB520
		// (set) Token: 0x06029D1F RID: 171295 RVA: 0x009CD334 File Offset: 0x009CB534
		public unsafe string 负责人
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NPCDataExport.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NPCDataExport.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17006566 RID: 25958
		// (get) Token: 0x06029D20 RID: 171296 RVA: 0x009CD349 File Offset: 0x009CB549
		// (set) Token: 0x06029D21 RID: 171297 RVA: 0x009CD35D File Offset: 0x009CB55D
		public unsafe string 所属区域
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NPCDataExport.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NPCDataExport.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17006567 RID: 25959
		// (get) Token: 0x06029D22 RID: 171298 RVA: 0x009CD372 File Offset: 0x009CB572
		// (set) Token: 0x06029D23 RID: 171299 RVA: 0x009CD382 File Offset: 0x009CB582
		public unsafe long 造物ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCDataExport.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCDataExport.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006568 RID: 25960
		// (get) Token: 0x06029D24 RID: 171300 RVA: 0x009CD393 File Offset: 0x009CB593
		// (set) Token: 0x06029D25 RID: 171301 RVA: 0x009CD3A7 File Offset: 0x009CB5A7
		public unsafe FIntVector 位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCDataExport.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCDataExport.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006569 RID: 25961
		// (get) Token: 0x06029D26 RID: 171302 RVA: 0x009CD3BC File Offset: 0x009CB5BC
		// (set) Token: 0x06029D27 RID: 171303 RVA: 0x009CD3DB File Offset: 0x009CB5DB
		public TSoftObjectPtr<USkeletalMesh> 模型
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)NPCDataExport.__PropertyOffset_6, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)NPCDataExport.__PropertyOffset_6, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700656A RID: 25962
		// (get) Token: 0x06029D28 RID: 171304 RVA: 0x009CD400 File Offset: 0x009CB600
		// (set) Token: 0x06029D29 RID: 171305 RVA: 0x009CD414 File Offset: 0x009CB614
		public unsafe string 类型
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NPCDataExport.__PropertyOffset_7)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NPCDataExport.__PropertyOffset_7)), value);
			}
		}

		// Token: 0x1700656B RID: 25963
		// (get) Token: 0x06029D2A RID: 171306 RVA: 0x009CD429 File Offset: 0x009CB629
		// (set) Token: 0x06029D2B RID: 171307 RVA: 0x009CD43D File Offset: 0x009CB63D
		public unsafe string 所在任务
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NPCDataExport.__PropertyOffset_8)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NPCDataExport.__PropertyOffset_8)), value);
			}
		}

		// Token: 0x1700656C RID: 25964
		// (get) Token: 0x06029D2C RID: 171308 RVA: 0x009CD452 File Offset: 0x009CB652
		// (set) Token: 0x06029D2D RID: 171309 RVA: 0x009CD462 File Offset: 0x009CB662
		public unsafe int 生成任务步骤
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCDataExport.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCDataExport.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700656D RID: 25965
		// (get) Token: 0x06029D2E RID: 171310 RVA: 0x009CD473 File Offset: 0x009CB673
		// (set) Token: 0x06029D2F RID: 171311 RVA: 0x009CD483 File Offset: 0x009CB683
		public unsafe int 销毁任务步骤
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCDataExport.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCDataExport.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700656E RID: 25966
		// (get) Token: 0x06029D30 RID: 171312 RVA: 0x009CD494 File Offset: 0x009CB694
		// (set) Token: 0x06029D31 RID: 171313 RVA: 0x009CD4A4 File Offset: 0x009CB6A4
		public unsafe int 造物生成条件组
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCDataExport.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCDataExport.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700656F RID: 25967
		// (get) Token: 0x06029D32 RID: 171314 RVA: 0x009CD4B5 File Offset: 0x009CB6B5
		// (set) Token: 0x06029D33 RID: 171315 RVA: 0x009CD4C5 File Offset: 0x009CB6C5
		public unsafe int 挂载AI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCDataExport.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCDataExport.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x06029D34 RID: 171316 RVA: 0x009CD4D6 File Offset: 0x009CB6D6
		public NPCDataExport()
		{
		}

		// Token: 0x06029D35 RID: 171317 RVA: 0x009CD4E0 File Offset: 0x009CB6E0
		public NPCDataExport(string 名称, string 实体描述, string 负责人, string 所属区域, long 造物ID, FIntVector 位置, TSoftObjectPtr<USkeletalMesh> 模型, string 类型, string 所在任务, int 生成任务步骤, int 销毁任务步骤, int 造物生成条件组, int 挂载AI)
		{
			this.名称 = 名称;
			this.实体描述 = 实体描述;
			this.负责人 = 负责人;
			this.所属区域 = 所属区域;
			this.造物ID = 造物ID;
			this.位置 = 位置;
			this.模型 = 模型;
			this.类型 = 类型;
			this.所在任务 = 所在任务;
			this.生成任务步骤 = 生成任务步骤;
			this.销毁任务步骤 = 销毁任务步骤;
			this.造物生成条件组 = 造物生成条件组;
			this.挂载AI = 挂载AI;
		}

		// Token: 0x06029D36 RID: 171318 RVA: 0x009CD558 File Offset: 0x009CB758
		protected override IntPtr GetUStructPtr()
		{
			return NPCDataExport.StaticStruct();
		}

		// Token: 0x06029D37 RID: 171319 RVA: 0x009CD564 File Offset: 0x009CB764
		[NullableContext(2)]
		public NPCDataExport(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029D38 RID: 171320 RVA: 0x009CD56E File Offset: 0x009CB76E
		public NPCDataExport(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029D39 RID: 171321 RVA: 0x009CD579 File Offset: 0x009CB779
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new NPCDataExport(Pointer, false, true);
		}

		// Token: 0x06029D3A RID: 171322 RVA: 0x009CD583 File Offset: 0x009CB783
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new NPCDataExport(Pointer, MemoryOwner);
		}

		// Token: 0x0401579F RID: 87967
		public const string __ObjectPath = "/Game/Aki/CreatureTools/Designer/NPCDataExport.NPCDataExport";

		// Token: 0x040157A0 RID: 87968
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040157A1 RID: 87969
		internal static int __PropertyOffset_0;

		// Token: 0x040157A2 RID: 87970
		internal static int __PropertyOffset_1;

		// Token: 0x040157A3 RID: 87971
		internal static int __PropertyOffset_2;

		// Token: 0x040157A4 RID: 87972
		internal static int __PropertyOffset_3;

		// Token: 0x040157A5 RID: 87973
		internal static int __PropertyOffset_4;

		// Token: 0x040157A6 RID: 87974
		internal static int __PropertyOffset_5;

		// Token: 0x040157A7 RID: 87975
		internal static int __PropertyOffset_6;

		// Token: 0x040157A8 RID: 87976
		internal static int __PropertyOffset_7;

		// Token: 0x040157A9 RID: 87977
		internal static int __PropertyOffset_8;

		// Token: 0x040157AA RID: 87978
		internal static int __PropertyOffset_9;

		// Token: 0x040157AB RID: 87979
		internal static int __PropertyOffset_10;

		// Token: 0x040157AC RID: 87980
		internal static int __PropertyOffset_11;

		// Token: 0x040157AD RID: 87981
		internal static int __PropertyOffset_12;
	}
}
