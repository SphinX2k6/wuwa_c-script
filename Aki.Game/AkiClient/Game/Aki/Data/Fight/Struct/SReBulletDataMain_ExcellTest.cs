using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F74 RID: 16244
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SReBulletDataMain_ExcellTest.SReBulletDataMain_ExcellTest")]
	[UnrealStructLayout(1984, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1984)]
	public class SReBulletDataMain_ExcellTest : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602973A RID: 169786 RVA: 0x009C47CC File Offset: 0x009C29CC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataMain_ExcellTest._ScriptStructPtr != 0) ? SReBulletDataMain_ExcellTest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SReBulletDataMain_ExcellTest.SReBulletDataMain_ExcellTest", ref SReBulletDataMain_ExcellTest._ScriptStructPtr);
		}

		// Token: 0x17006353 RID: 25427
		// (get) Token: 0x0602973B RID: 169787 RVA: 0x009C47F0 File Offset: 0x009C29F0
		// (set) Token: 0x0602973C RID: 169788 RVA: 0x009C4804 File Offset: 0x009C2A04
		public unsafe FName 子弹名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006354 RID: 25428
		// (get) Token: 0x0602973D RID: 169789 RVA: 0x009C4819 File Offset: 0x009C2A19
		// (set) Token: 0x0602973E RID: 169790 RVA: 0x009C482D File Offset: 0x009C2A2D
		public unsafe string 新增备注列
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006355 RID: 25429
		// (get) Token: 0x0602973F RID: 169791 RVA: 0x009C4844 File Offset: 0x009C2A44
		// (set) Token: 0x06029740 RID: 169792 RVA: 0x009C4887 File Offset: 0x009C2A87
		public SReBulletDataBase_ExcelTest 基础设置
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataBase_ExcelTest result;
				if ((result = this._基础设置) == null)
				{
					result = (this._基础设置 = new SReBulletDataBase_ExcelTest(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataBase_ExcelTest.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006356 RID: 25430
		// (get) Token: 0x06029741 RID: 169793 RVA: 0x009C48A8 File Offset: 0x009C2AA8
		// (set) Token: 0x06029742 RID: 169794 RVA: 0x009C48EB File Offset: 0x009C2AEB
		public SReBulletDataLogic 逻辑设置
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataLogic result;
				if ((result = this._逻辑设置) == null)
				{
					result = (this._逻辑设置 = new SReBulletDataLogic(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataLogic.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006357 RID: 25431
		// (get) Token: 0x06029743 RID: 169795 RVA: 0x009C490C File Offset: 0x009C2B0C
		// (set) Token: 0x06029744 RID: 169796 RVA: 0x009C4920 File Offset: 0x009C2B20
		public unsafe SReBulletDataAimed 瞄准设置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006358 RID: 25432
		// (get) Token: 0x06029745 RID: 169797 RVA: 0x009C4938 File Offset: 0x009C2B38
		// (set) Token: 0x06029746 RID: 169798 RVA: 0x009C497B File Offset: 0x009C2B7B
		public SReBulletDataMove 移动设置
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataMove result;
				if ((result = this._移动设置) == null)
				{
					result = (this._移动设置 = new SReBulletDataMove(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataMove.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006359 RID: 25433
		// (get) Token: 0x06029747 RID: 169799 RVA: 0x009C499C File Offset: 0x009C2B9C
		// (set) Token: 0x06029748 RID: 169800 RVA: 0x009C49DF File Offset: 0x009C2BDF
		public SReBulletDataPerformance 表现效果设置
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataPerformance result;
				if ((result = this._表现效果设置) == null)
				{
					result = (this._表现效果设置 = new SReBulletDataPerformance(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataPerformance.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700635A RID: 25434
		// (get) Token: 0x06029749 RID: 169801 RVA: 0x009C4A00 File Offset: 0x009C2C00
		// (set) Token: 0x0602974A RID: 169802 RVA: 0x009C4A43 File Offset: 0x009C2C43
		public SReBulletDataTime 时间膨胀
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataTime result;
				if ((result = this._时间膨胀) == null)
				{
					result = (this._时间膨胀 = new SReBulletDataTime(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataTime.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700635B RID: 25435
		// (get) Token: 0x0602974B RID: 169803 RVA: 0x009C4A64 File Offset: 0x009C2C64
		// (set) Token: 0x0602974C RID: 169804 RVA: 0x009C4AA7 File Offset: 0x009C2CA7
		public SReBulletDataExe 执行逻辑
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataExe result;
				if ((result = this._执行逻辑) == null)
				{
					result = (this._执行逻辑 = new SReBulletDataExe(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataExe.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700635C RID: 25436
		// (get) Token: 0x0602974D RID: 169805 RVA: 0x009C4AC8 File Offset: 0x009C2CC8
		// (set) Token: 0x0602974E RID: 169806 RVA: 0x009C4B0B File Offset: 0x009C2D0B
		public SReBulletDataScale 缩放设置
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataScale result;
				if ((result = this._缩放设置) == null)
				{
					result = (this._缩放设置 = new SReBulletDataScale(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataScale.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700635D RID: 25437
		// (get) Token: 0x0602974F RID: 169807 RVA: 0x009C4B2C File Offset: 0x009C2D2C
		// (set) Token: 0x06029750 RID: 169808 RVA: 0x009C4B40 File Offset: 0x009C2D40
		public unsafe SReBulletDataEntity 召唤实体
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700635E RID: 25438
		// (get) Token: 0x06029751 RID: 169809 RVA: 0x009C4B58 File Offset: 0x009C2D58
		// (set) Token: 0x06029752 RID: 169810 RVA: 0x009C4B9B File Offset: 0x009C2D9B
		public TArray<SReBulletDataChildren> 子子弹设置
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SReBulletDataChildren> result;
				if ((result = this._子子弹设置) == null)
				{
					result = (this._子子弹设置 = new TArray<SReBulletDataChildren>(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_11, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.子子弹设置.CopyAssign(value);
			}
		}

		// Token: 0x1700635F RID: 25439
		// (get) Token: 0x06029753 RID: 169811 RVA: 0x009C4BA9 File Offset: 0x009C2DA9
		// (set) Token: 0x06029754 RID: 169812 RVA: 0x009C4BBD File Offset: 0x009C2DBD
		public unsafe SReBulletDataObstacles 障碍检测
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006360 RID: 25440
		// (get) Token: 0x06029755 RID: 169813 RVA: 0x009C4BD4 File Offset: 0x009C2DD4
		// (set) Token: 0x06029756 RID: 169814 RVA: 0x009C4C17 File Offset: 0x009C2E17
		public SReBulletDataInteraction 环境交互
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataInteraction result;
				if ((result = this._环境交互) == null)
				{
					result = (this._环境交互 = new SReBulletDataInteraction(base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_13, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataInteraction.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain_ExcellTest.__PropertyOffset_13, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06029757 RID: 169815 RVA: 0x009C4C38 File Offset: 0x009C2E38
		public SReBulletDataMain_ExcellTest()
		{
		}

		// Token: 0x06029758 RID: 169816 RVA: 0x009C4C40 File Offset: 0x009C2E40
		public SReBulletDataMain_ExcellTest(FName 子弹名称, string 新增备注列, SReBulletDataBase_ExcelTest 基础设置, SReBulletDataLogic 逻辑设置, SReBulletDataAimed 瞄准设置, SReBulletDataMove 移动设置, SReBulletDataPerformance 表现效果设置, SReBulletDataTime 时间膨胀, SReBulletDataExe 执行逻辑, SReBulletDataScale 缩放设置, SReBulletDataEntity 召唤实体, TArray<SReBulletDataChildren> 子子弹设置, SReBulletDataObstacles 障碍检测, SReBulletDataInteraction 环境交互)
		{
			this.子弹名称 = 子弹名称;
			this.新增备注列 = 新增备注列;
			this.基础设置 = 基础设置;
			this.逻辑设置 = 逻辑设置;
			this.瞄准设置 = 瞄准设置;
			this.移动设置 = 移动设置;
			this.表现效果设置 = 表现效果设置;
			this.时间膨胀 = 时间膨胀;
			this.执行逻辑 = 执行逻辑;
			this.缩放设置 = 缩放设置;
			this.召唤实体 = 召唤实体;
			this.子子弹设置 = 子子弹设置;
			this.障碍检测 = 障碍检测;
			this.环境交互 = 环境交互;
		}

		// Token: 0x06029759 RID: 169817 RVA: 0x009C4CC0 File Offset: 0x009C2EC0
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataMain_ExcellTest.StaticStruct();
		}

		// Token: 0x0602975A RID: 169818 RVA: 0x009C4CCC File Offset: 0x009C2ECC
		[NullableContext(2)]
		public SReBulletDataMain_ExcellTest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602975B RID: 169819 RVA: 0x009C4CD6 File Offset: 0x009C2ED6
		public SReBulletDataMain_ExcellTest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602975C RID: 169820 RVA: 0x009C4CE1 File Offset: 0x009C2EE1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataMain_ExcellTest(Pointer, false, true);
		}

		// Token: 0x0602975D RID: 169821 RVA: 0x009C4CEB File Offset: 0x009C2EEB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataMain_ExcellTest(Pointer, MemoryOwner);
		}

		// Token: 0x040153CF RID: 86991
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SReBulletDataMain_ExcellTest.SReBulletDataMain_ExcellTest";

		// Token: 0x040153D0 RID: 86992
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040153D1 RID: 86993
		internal static int __PropertyOffset_0;

		// Token: 0x040153D2 RID: 86994
		internal static int __PropertyOffset_1;

		// Token: 0x040153D3 RID: 86995
		internal static int __PropertyOffset_2;

		// Token: 0x040153D4 RID: 86996
		[Nullable(2)]
		private SReBulletDataBase_ExcelTest _基础设置;

		// Token: 0x040153D5 RID: 86997
		internal static int __PropertyOffset_3;

		// Token: 0x040153D6 RID: 86998
		[Nullable(2)]
		private SReBulletDataLogic _逻辑设置;

		// Token: 0x040153D7 RID: 86999
		internal static int __PropertyOffset_4;

		// Token: 0x040153D8 RID: 87000
		internal static int __PropertyOffset_5;

		// Token: 0x040153D9 RID: 87001
		[Nullable(2)]
		private SReBulletDataMove _移动设置;

		// Token: 0x040153DA RID: 87002
		internal static int __PropertyOffset_6;

		// Token: 0x040153DB RID: 87003
		[Nullable(2)]
		private SReBulletDataPerformance _表现效果设置;

		// Token: 0x040153DC RID: 87004
		internal static int __PropertyOffset_7;

		// Token: 0x040153DD RID: 87005
		[Nullable(2)]
		private SReBulletDataTime _时间膨胀;

		// Token: 0x040153DE RID: 87006
		internal static int __PropertyOffset_8;

		// Token: 0x040153DF RID: 87007
		[Nullable(2)]
		private SReBulletDataExe _执行逻辑;

		// Token: 0x040153E0 RID: 87008
		internal static int __PropertyOffset_9;

		// Token: 0x040153E1 RID: 87009
		[Nullable(2)]
		private SReBulletDataScale _缩放设置;

		// Token: 0x040153E2 RID: 87010
		internal static int __PropertyOffset_10;

		// Token: 0x040153E3 RID: 87011
		internal static int __PropertyOffset_11;

		// Token: 0x040153E4 RID: 87012
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SReBulletDataChildren> _子子弹设置;

		// Token: 0x040153E5 RID: 87013
		internal static int __PropertyOffset_12;

		// Token: 0x040153E6 RID: 87014
		internal static int __PropertyOffset_13;

		// Token: 0x040153E7 RID: 87015
		[Nullable(2)]
		private SReBulletDataInteraction _环境交互;
	}
}
