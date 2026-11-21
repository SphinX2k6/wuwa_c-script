using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003276 RID: 12918
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataMain.SReBulletDataMain")]
	[UnrealStructLayout(1992, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1992)]
	public class SReBulletDataMain : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020441 RID: 132161 RVA: 0x00941630 File Offset: 0x0093F830
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataMain._ScriptStructPtr != 0) ? SReBulletDataMain._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataMain.SReBulletDataMain", ref SReBulletDataMain._ScriptStructPtr);
		}

		// Token: 0x17003E2D RID: 15917
		// (get) Token: 0x06020442 RID: 132162 RVA: 0x00941654 File Offset: 0x0093F854
		// (set) Token: 0x06020443 RID: 132163 RVA: 0x00941668 File Offset: 0x0093F868
		public unsafe FName 子弹名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_子弹名称);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_子弹名称) = value;
			}
		}

		// Token: 0x17003E2E RID: 15918
		// (get) Token: 0x06020444 RID: 132164 RVA: 0x00941680 File Offset: 0x0093F880
		// (set) Token: 0x06020445 RID: 132165 RVA: 0x009416C3 File Offset: 0x0093F8C3
		public SReBulletDataBase 基础设置
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataBase result;
				if ((result = this._基础设置) == null)
				{
					result = (this._基础设置 = new SReBulletDataBase(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_基础设置, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataBase.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_基础设置, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E2F RID: 15919
		// (get) Token: 0x06020446 RID: 132166 RVA: 0x009416E4 File Offset: 0x0093F8E4
		// (set) Token: 0x06020447 RID: 132167 RVA: 0x00941727 File Offset: 0x0093F927
		public SReBulletDataLogic 逻辑设置
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataLogic result;
				if ((result = this._逻辑设置) == null)
				{
					result = (this._逻辑设置 = new SReBulletDataLogic(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_逻辑设置, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataLogic.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_逻辑设置, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E30 RID: 15920
		// (get) Token: 0x06020448 RID: 132168 RVA: 0x00941748 File Offset: 0x0093F948
		// (set) Token: 0x06020449 RID: 132169 RVA: 0x0094175C File Offset: 0x0093F95C
		public unsafe SReBulletDataAimed 瞄准设置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_瞄准设置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_瞄准设置) = value;
			}
		}

		// Token: 0x17003E31 RID: 15921
		// (get) Token: 0x0602044A RID: 132170 RVA: 0x00941774 File Offset: 0x0093F974
		// (set) Token: 0x0602044B RID: 132171 RVA: 0x009417B7 File Offset: 0x0093F9B7
		public SReBulletDataMove 移动设置
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataMove result;
				if ((result = this._移动设置) == null)
				{
					result = (this._移动设置 = new SReBulletDataMove(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_移动设置, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataMove.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_移动设置, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E32 RID: 15922
		// (get) Token: 0x0602044C RID: 132172 RVA: 0x009417D8 File Offset: 0x0093F9D8
		// (set) Token: 0x0602044D RID: 132173 RVA: 0x0094181B File Offset: 0x0093FA1B
		public SReBulletDataPerformance 表现效果设置
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataPerformance result;
				if ((result = this._表现效果设置) == null)
				{
					result = (this._表现效果设置 = new SReBulletDataPerformance(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_表现效果设置, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataPerformance.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_表现效果设置, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E33 RID: 15923
		// (get) Token: 0x0602044E RID: 132174 RVA: 0x0094183C File Offset: 0x0093FA3C
		// (set) Token: 0x0602044F RID: 132175 RVA: 0x0094187F File Offset: 0x0093FA7F
		public SReBulletDataTime 时间膨胀
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataTime result;
				if ((result = this._时间膨胀) == null)
				{
					result = (this._时间膨胀 = new SReBulletDataTime(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_时间膨胀, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataTime.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_时间膨胀, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E34 RID: 15924
		// (get) Token: 0x06020450 RID: 132176 RVA: 0x009418A0 File Offset: 0x0093FAA0
		// (set) Token: 0x06020451 RID: 132177 RVA: 0x009418E3 File Offset: 0x0093FAE3
		public SReBulletDataExe 执行逻辑
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataExe result;
				if ((result = this._执行逻辑) == null)
				{
					result = (this._执行逻辑 = new SReBulletDataExe(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_执行逻辑, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataExe.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_执行逻辑, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E35 RID: 15925
		// (get) Token: 0x06020452 RID: 132178 RVA: 0x00941904 File Offset: 0x0093FB04
		// (set) Token: 0x06020453 RID: 132179 RVA: 0x00941947 File Offset: 0x0093FB47
		public SReBulletDataScale 缩放设置
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataScale result;
				if ((result = this._缩放设置) == null)
				{
					result = (this._缩放设置 = new SReBulletDataScale(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_缩放设置, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataScale.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_缩放设置, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E36 RID: 15926
		// (get) Token: 0x06020454 RID: 132180 RVA: 0x00941968 File Offset: 0x0093FB68
		// (set) Token: 0x06020455 RID: 132181 RVA: 0x0094197C File Offset: 0x0093FB7C
		public unsafe SReBulletDataEntity 召唤实体
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_召唤实体);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_召唤实体) = value;
			}
		}

		// Token: 0x17003E37 RID: 15927
		// (get) Token: 0x06020456 RID: 132182 RVA: 0x00941994 File Offset: 0x0093FB94
		// (set) Token: 0x06020457 RID: 132183 RVA: 0x009419D7 File Offset: 0x0093FBD7
		public TArray<SReBulletDataChildren> 子子弹设置
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SReBulletDataChildren> result;
				if ((result = this._子子弹设置) == null)
				{
					result = (this._子子弹设置 = new TArray<SReBulletDataChildren>(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_子子弹设置, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.子子弹设置.CopyAssign(value);
			}
		}

		// Token: 0x17003E38 RID: 15928
		// (get) Token: 0x06020458 RID: 132184 RVA: 0x009419E5 File Offset: 0x0093FBE5
		// (set) Token: 0x06020459 RID: 132185 RVA: 0x009419F9 File Offset: 0x0093FBF9
		public unsafe SReBulletDataObstacles 障碍检测
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_障碍检测);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_障碍检测) = value;
			}
		}

		// Token: 0x17003E39 RID: 15929
		// (get) Token: 0x0602045A RID: 132186 RVA: 0x00941A10 File Offset: 0x0093FC10
		// (set) Token: 0x0602045B RID: 132187 RVA: 0x00941A53 File Offset: 0x0093FC53
		public SReBulletDataInteraction 环境交互
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataInteraction result;
				if ((result = this._环境交互) == null)
				{
					result = (this._环境交互 = new SReBulletDataInteraction(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_环境交互, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataInteraction.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_环境交互, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602045C RID: 132188 RVA: 0x00941A74 File Offset: 0x0093FC74
		public SReBulletDataMain()
		{
		}

		// Token: 0x0602045D RID: 132189 RVA: 0x00941A7C File Offset: 0x0093FC7C
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataMain.StaticStruct();
		}

		// Token: 0x0602045E RID: 132190 RVA: 0x00941A88 File Offset: 0x0093FC88
		[NullableContext(2)]
		public SReBulletDataMain(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602045F RID: 132191 RVA: 0x00941A92 File Offset: 0x0093FC92
		public SReBulletDataMain(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020460 RID: 132192 RVA: 0x00941A9D File Offset: 0x0093FC9D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataMain(Pointer, false, true);
		}

		// Token: 0x06020461 RID: 132193 RVA: 0x00941AA7 File Offset: 0x0093FCA7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataMain(Pointer, MemoryOwner);
		}

		// Token: 0x040116AC RID: 71340
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataMain.SReBulletDataMain";

		// Token: 0x040116AD RID: 71341
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040116AE RID: 71342
		internal static int __PropertyOffset_子弹名称;

		// Token: 0x040116AF RID: 71343
		internal static int __PropertyOffset_基础设置;

		// Token: 0x040116B0 RID: 71344
		[Nullable(2)]
		private SReBulletDataBase _基础设置;

		// Token: 0x040116B1 RID: 71345
		internal static int __PropertyOffset_逻辑设置;

		// Token: 0x040116B2 RID: 71346
		[Nullable(2)]
		private SReBulletDataLogic _逻辑设置;

		// Token: 0x040116B3 RID: 71347
		internal static int __PropertyOffset_瞄准设置;

		// Token: 0x040116B4 RID: 71348
		internal static int __PropertyOffset_移动设置;

		// Token: 0x040116B5 RID: 71349
		[Nullable(2)]
		private SReBulletDataMove _移动设置;

		// Token: 0x040116B6 RID: 71350
		internal static int __PropertyOffset_表现效果设置;

		// Token: 0x040116B7 RID: 71351
		[Nullable(2)]
		private SReBulletDataPerformance _表现效果设置;

		// Token: 0x040116B8 RID: 71352
		internal static int __PropertyOffset_时间膨胀;

		// Token: 0x040116B9 RID: 71353
		[Nullable(2)]
		private SReBulletDataTime _时间膨胀;

		// Token: 0x040116BA RID: 71354
		internal static int __PropertyOffset_执行逻辑;

		// Token: 0x040116BB RID: 71355
		[Nullable(2)]
		private SReBulletDataExe _执行逻辑;

		// Token: 0x040116BC RID: 71356
		internal static int __PropertyOffset_缩放设置;

		// Token: 0x040116BD RID: 71357
		[Nullable(2)]
		private SReBulletDataScale _缩放设置;

		// Token: 0x040116BE RID: 71358
		internal static int __PropertyOffset_召唤实体;

		// Token: 0x040116BF RID: 71359
		internal static int __PropertyOffset_子子弹设置;

		// Token: 0x040116C0 RID: 71360
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SReBulletDataChildren> _子子弹设置;

		// Token: 0x040116C1 RID: 71361
		internal static int __PropertyOffset_障碍检测;

		// Token: 0x040116C2 RID: 71362
		internal static int __PropertyOffset_环境交互;

		// Token: 0x040116C3 RID: 71363
		[Nullable(2)]
		private SReBulletDataInteraction _环境交互;
	}
}
