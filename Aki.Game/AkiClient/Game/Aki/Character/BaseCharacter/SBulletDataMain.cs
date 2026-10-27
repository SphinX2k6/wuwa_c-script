using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042F8 RID: 17144
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBulletDataMain.SBulletDataMain")]
	[UnrealStructLayout(704, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 704)]
	public class SBulletDataMain : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C4B0 RID: 181424 RVA: 0x00A1C522 File Offset: 0x00A1A722
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletDataMain._ScriptStructPtr != 0) ? SBulletDataMain._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBulletDataMain.SBulletDataMain", ref SBulletDataMain._ScriptStructPtr);
		}

		// Token: 0x17006E90 RID: 28304
		// (get) Token: 0x0602C4B1 RID: 181425 RVA: 0x00A1C546 File Offset: 0x00A1A746
		// (set) Token: 0x0602C4B2 RID: 181426 RVA: 0x00A1C55A File Offset: 0x00A1A75A
		public unsafe FName 子弹名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006E91 RID: 28305
		// (get) Token: 0x0602C4B3 RID: 181427 RVA: 0x00A1C570 File Offset: 0x00A1A770
		// (set) Token: 0x0602C4B4 RID: 181428 RVA: 0x00A1C5B3 File Offset: 0x00A1A7B3
		public SBulletDataBase 基础设置
		{
			get
			{
				base.FastCheckIsValid();
				SBulletDataBase result;
				if ((result = this._基础设置) == null)
				{
					result = (this._基础设置 = new SBulletDataBase(base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBulletDataBase.StaticStruct(), base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E92 RID: 28306
		// (get) Token: 0x0602C4B5 RID: 181429 RVA: 0x00A1C5D4 File Offset: 0x00A1A7D4
		// (set) Token: 0x0602C4B6 RID: 181430 RVA: 0x00A1C617 File Offset: 0x00A1A817
		public SBulletDataMove 移动设置
		{
			get
			{
				base.FastCheckIsValid();
				SBulletDataMove result;
				if ((result = this._移动设置) == null)
				{
					result = (this._移动设置 = new SBulletDataMove(base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBulletDataMove.StaticStruct(), base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E93 RID: 28307
		// (get) Token: 0x0602C4B7 RID: 181431 RVA: 0x00A1C638 File Offset: 0x00A1A838
		// (set) Token: 0x0602C4B8 RID: 181432 RVA: 0x00A1C67B File Offset: 0x00A1A87B
		public SBulletDataEffect 效果设置
		{
			get
			{
				base.FastCheckIsValid();
				SBulletDataEffect result;
				if ((result = this._效果设置) == null)
				{
					result = (this._效果设置 = new SBulletDataEffect(base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBulletDataEffect.StaticStruct(), base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E94 RID: 28308
		// (get) Token: 0x0602C4B9 RID: 181433 RVA: 0x00A1C69C File Offset: 0x00A1A89C
		// (set) Token: 0x0602C4BA RID: 181434 RVA: 0x00A1C6DF File Offset: 0x00A1A8DF
		public SBulletDataTime 时间膨胀
		{
			get
			{
				base.FastCheckIsValid();
				SBulletDataTime result;
				if ((result = this._时间膨胀) == null)
				{
					result = (this._时间膨胀 = new SBulletDataTime(base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBulletDataTime.StaticStruct(), base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E95 RID: 28309
		// (get) Token: 0x0602C4BB RID: 181435 RVA: 0x00A1C700 File Offset: 0x00A1A900
		// (set) Token: 0x0602C4BC RID: 181436 RVA: 0x00A1C743 File Offset: 0x00A1A943
		public SBulletDataCollision 碰撞设置
		{
			get
			{
				base.FastCheckIsValid();
				SBulletDataCollision result;
				if ((result = this._碰撞设置) == null)
				{
					result = (this._碰撞设置 = new SBulletDataCollision(base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBulletDataCollision.StaticStruct(), base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E96 RID: 28310
		// (get) Token: 0x0602C4BD RID: 181437 RVA: 0x00A1C764 File Offset: 0x00A1A964
		// (set) Token: 0x0602C4BE RID: 181438 RVA: 0x00A1C7A7 File Offset: 0x00A1A9A7
		public SBulletDataExe 执行逻辑
		{
			get
			{
				base.FastCheckIsValid();
				SBulletDataExe result;
				if ((result = this._执行逻辑) == null)
				{
					result = (this._执行逻辑 = new SBulletDataExe(base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBulletDataExe.StaticStruct(), base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E97 RID: 28311
		// (get) Token: 0x0602C4BF RID: 181439 RVA: 0x00A1C7C8 File Offset: 0x00A1A9C8
		// (set) Token: 0x0602C4C0 RID: 181440 RVA: 0x00A1C80B File Offset: 0x00A1AA0B
		public SBulletDataScale 缩放设置
		{
			get
			{
				base.FastCheckIsValid();
				SBulletDataScale result;
				if ((result = this._缩放设置) == null)
				{
					result = (this._缩放设置 = new SBulletDataScale(base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBulletDataScale.StaticStruct(), base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E98 RID: 28312
		// (get) Token: 0x0602C4C1 RID: 181441 RVA: 0x00A1C82C File Offset: 0x00A1AA2C
		// (set) Token: 0x0602C4C2 RID: 181442 RVA: 0x00A1C86F File Offset: 0x00A1AA6F
		public TArray<SBulletDataChild> 子子弹
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SBulletDataChild> result;
				if ((result = this._子子弹) == null)
				{
					result = (this._子子弹 = new TArray<SBulletDataChild>(base.NativePtr + (IntPtr)SBulletDataMain.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.子子弹.CopyAssign(value);
			}
		}

		// Token: 0x0602C4C3 RID: 181443 RVA: 0x00A1C87D File Offset: 0x00A1AA7D
		public SBulletDataMain()
		{
		}

		// Token: 0x0602C4C4 RID: 181444 RVA: 0x00A1C888 File Offset: 0x00A1AA88
		public SBulletDataMain(FName 子弹名称, SBulletDataBase 基础设置, SBulletDataMove 移动设置, SBulletDataEffect 效果设置, SBulletDataTime 时间膨胀, SBulletDataCollision 碰撞设置, SBulletDataExe 执行逻辑, SBulletDataScale 缩放设置, TArray<SBulletDataChild> 子子弹)
		{
			this.子弹名称 = 子弹名称;
			this.基础设置 = 基础设置;
			this.移动设置 = 移动设置;
			this.效果设置 = 效果设置;
			this.时间膨胀 = 时间膨胀;
			this.碰撞设置 = 碰撞设置;
			this.执行逻辑 = 执行逻辑;
			this.缩放设置 = 缩放设置;
			this.子子弹 = 子子弹;
		}

		// Token: 0x0602C4C5 RID: 181445 RVA: 0x00A1C8E0 File Offset: 0x00A1AAE0
		protected override IntPtr GetUStructPtr()
		{
			return SBulletDataMain.StaticStruct();
		}

		// Token: 0x0602C4C6 RID: 181446 RVA: 0x00A1C8EC File Offset: 0x00A1AAEC
		[NullableContext(2)]
		public SBulletDataMain(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C4C7 RID: 181447 RVA: 0x00A1C8F6 File Offset: 0x00A1AAF6
		public SBulletDataMain(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C4C8 RID: 181448 RVA: 0x00A1C901 File Offset: 0x00A1AB01
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletDataMain(Pointer, false, true);
		}

		// Token: 0x0602C4C9 RID: 181449 RVA: 0x00A1C90B File Offset: 0x00A1AB0B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletDataMain(Pointer, MemoryOwner);
		}

		// Token: 0x040175B1 RID: 95665
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBulletDataMain.SBulletDataMain";

		// Token: 0x040175B2 RID: 95666
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040175B3 RID: 95667
		internal static int __PropertyOffset_0;

		// Token: 0x040175B4 RID: 95668
		internal static int __PropertyOffset_1;

		// Token: 0x040175B5 RID: 95669
		[Nullable(2)]
		private SBulletDataBase _基础设置;

		// Token: 0x040175B6 RID: 95670
		internal static int __PropertyOffset_2;

		// Token: 0x040175B7 RID: 95671
		[Nullable(2)]
		private SBulletDataMove _移动设置;

		// Token: 0x040175B8 RID: 95672
		internal static int __PropertyOffset_3;

		// Token: 0x040175B9 RID: 95673
		[Nullable(2)]
		private SBulletDataEffect _效果设置;

		// Token: 0x040175BA RID: 95674
		internal static int __PropertyOffset_4;

		// Token: 0x040175BB RID: 95675
		[Nullable(2)]
		private SBulletDataTime _时间膨胀;

		// Token: 0x040175BC RID: 95676
		internal static int __PropertyOffset_5;

		// Token: 0x040175BD RID: 95677
		[Nullable(2)]
		private SBulletDataCollision _碰撞设置;

		// Token: 0x040175BE RID: 95678
		internal static int __PropertyOffset_6;

		// Token: 0x040175BF RID: 95679
		[Nullable(2)]
		private SBulletDataExe _执行逻辑;

		// Token: 0x040175C0 RID: 95680
		internal static int __PropertyOffset_7;

		// Token: 0x040175C1 RID: 95681
		[Nullable(2)]
		private SBulletDataScale _缩放设置;

		// Token: 0x040175C2 RID: 95682
		internal static int __PropertyOffset_8;

		// Token: 0x040175C3 RID: 95683
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SBulletDataChild> _子子弹;
	}
}
