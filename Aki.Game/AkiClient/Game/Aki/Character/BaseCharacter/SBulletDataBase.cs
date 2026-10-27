using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042F3 RID: 17139
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBulletDataBase.SBulletDataBase")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 210)]
	public class SBulletDataBase : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C43C RID: 181308 RVA: 0x00A1BB3E File Offset: 0x00A19D3E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletDataBase._ScriptStructPtr != 0) ? SBulletDataBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBulletDataBase.SBulletDataBase", ref SBulletDataBase._ScriptStructPtr);
		}

		// Token: 0x17006E6A RID: 28266
		// (get) Token: 0x0602C43D RID: 181309 RVA: 0x00A1BB62 File Offset: 0x00A19D62
		// (set) Token: 0x0602C43E RID: 181310 RVA: 0x00A1BB76 File Offset: 0x00A19D76
		public unsafe TEnumAsByte<EBulletShape> 子弹形状
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006E6B RID: 28267
		// (get) Token: 0x0602C43F RID: 181311 RVA: 0x00A1BB8B File Offset: 0x00A19D8B
		// (set) Token: 0x0602C440 RID: 181312 RVA: 0x00A1BBAA File Offset: 0x00A19DAA
		[Nullable(1)]
		public TSoftObjectPtr<UStaticMesh> 子弹模型
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006E6C RID: 28268
		// (get) Token: 0x0602C441 RID: 181313 RVA: 0x00A1BBCF File Offset: 0x00A19DCF
		// (set) Token: 0x0602C442 RID: 181314 RVA: 0x00A1BBE3 File Offset: 0x00A19DE3
		public unsafe FVector 初始大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006E6D RID: 28269
		// (get) Token: 0x0602C443 RID: 181315 RVA: 0x00A1BBF8 File Offset: 0x00A19DF8
		// (set) Token: 0x0602C444 RID: 181316 RVA: 0x00A1BC0C File Offset: 0x00A19E0C
		public unsafe FVector 初始位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006E6E RID: 28270
		// (get) Token: 0x0602C445 RID: 181317 RVA: 0x00A1BC21 File Offset: 0x00A19E21
		// (set) Token: 0x0602C446 RID: 181318 RVA: 0x00A1BC35 File Offset: 0x00A19E35
		public unsafe FVector 初始旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006E6F RID: 28271
		// (get) Token: 0x0602C447 RID: 181319 RVA: 0x00A1BC4A File Offset: 0x00A19E4A
		// (set) Token: 0x0602C448 RID: 181320 RVA: 0x00A1BC5A File Offset: 0x00A19E5A
		public unsafe float 持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006E70 RID: 28272
		// (get) Token: 0x0602C449 RID: 181321 RVA: 0x00A1BC6B File Offset: 0x00A19E6B
		// (set) Token: 0x0602C44A RID: 181322 RVA: 0x00A1BC7B File Offset: 0x00A19E7B
		public unsafe int 命中个数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006E71 RID: 28273
		// (get) Token: 0x0602C44B RID: 181323 RVA: 0x00A1BC8C File Offset: 0x00A19E8C
		// (set) Token: 0x0602C44C RID: 181324 RVA: 0x00A1BC9C File Offset: 0x00A19E9C
		public unsafe int 作用次数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006E72 RID: 28274
		// (get) Token: 0x0602C44D RID: 181325 RVA: 0x00A1BCAD File Offset: 0x00A19EAD
		// (set) Token: 0x0602C44E RID: 181326 RVA: 0x00A1BCBD File Offset: 0x00A19EBD
		public unsafe bool 被极限闪避后销毁
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E73 RID: 28275
		// (get) Token: 0x0602C44F RID: 181327 RVA: 0x00A1BCCE File Offset: 0x00A19ECE
		// (set) Token: 0x0602C450 RID: 181328 RVA: 0x00A1BCE2 File Offset: 0x00A19EE2
		public unsafe FName 被击效果
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006E74 RID: 28276
		// (get) Token: 0x0602C451 RID: 181329 RVA: 0x00A1BCF7 File Offset: 0x00A19EF7
		// (set) Token: 0x0602C452 RID: 181330 RVA: 0x00A1BD07 File Offset: 0x00A19F07
		public unsafe float 作用间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006E75 RID: 28277
		// (get) Token: 0x0602C453 RID: 181331 RVA: 0x00A1BD18 File Offset: 0x00A19F18
		// (set) Token: 0x0602C454 RID: 181332 RVA: 0x00A1BD2C File Offset: 0x00A19F2C
		public unsafe TEnumAsByte<EBulletRelativeDir> 受击类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006E76 RID: 28278
		// (get) Token: 0x0602C455 RID: 181333 RVA: 0x00A1BD41 File Offset: 0x00A19F41
		// (set) Token: 0x0602C456 RID: 181334 RVA: 0x00A1BD51 File Offset: 0x00A19F51
		public unsafe int 执行效果ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006E77 RID: 28279
		// (get) Token: 0x0602C457 RID: 181335 RVA: 0x00A1BD62 File Offset: 0x00A19F62
		// (set) Token: 0x0602C458 RID: 181336 RVA: 0x00A1BD76 File Offset: 0x00A19F76
		public unsafe FRotator 子弹攻击方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006E78 RID: 28280
		// (get) Token: 0x0602C459 RID: 181337 RVA: 0x00A1BD8B File Offset: 0x00A19F8B
		// (set) Token: 0x0602C45A RID: 181338 RVA: 0x00A1BD9B File Offset: 0x00A19F9B
		public unsafe bool 技能结束是否销毁子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E79 RID: 28281
		// (get) Token: 0x0602C45B RID: 181339 RVA: 0x00A1BDAC File Offset: 0x00A19FAC
		// (set) Token: 0x0602C45C RID: 181340 RVA: 0x00A1BDBC File Offset: 0x00A19FBC
		public unsafe int 伤害类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006E7A RID: 28282
		// (get) Token: 0x0602C45D RID: 181341 RVA: 0x00A1BDCD File Offset: 0x00A19FCD
		// (set) Token: 0x0602C45E RID: 181342 RVA: 0x00A1BDDD File Offset: 0x00A19FDD
		public unsafe bool 是否可以触发极限闪避
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E7B RID: 28283
		// (get) Token: 0x0602C45F RID: 181343 RVA: 0x00A1BDEE File Offset: 0x00A19FEE
		// (set) Token: 0x0602C460 RID: 181344 RVA: 0x00A1BDFE File Offset: 0x00A19FFE
		public unsafe bool 是否触发拼刀
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E7C RID: 28284
		// (get) Token: 0x0602C461 RID: 181345 RVA: 0x00A1BE0F File Offset: 0x00A1A00F
		// (set) Token: 0x0602C462 RID: 181346 RVA: 0x00A1BE2E File Offset: 0x00A1A02E
		[Nullable(1)]
		public TSoftClassPtr<UMatineeCameraShake> 攻击者震屏
		{
			[NullableContext(1)]
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_18, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_18, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006E7D RID: 28285
		// (get) Token: 0x0602C463 RID: 181347 RVA: 0x00A1BE53 File Offset: 0x00A1A053
		// (set) Token: 0x0602C464 RID: 181348 RVA: 0x00A1BE67 File Offset: 0x00A1A067
		public unsafe TEnumAsByte<EBulletType> 子弹类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006E7E RID: 28286
		// (get) Token: 0x0602C465 RID: 181349 RVA: 0x00A1BE7C File Offset: 0x00A1A07C
		// (set) Token: 0x0602C466 RID: 181350 RVA: 0x00A1BE90 File Offset: 0x00A1A090
		public unsafe TEnumAsByte<EBulletHitDirectionType> 受击角度判定类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataBase.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x0602C467 RID: 181351 RVA: 0x00A1BEA5 File Offset: 0x00A1A0A5
		public SBulletDataBase()
		{
		}

		// Token: 0x0602C468 RID: 181352 RVA: 0x00A1BEB0 File Offset: 0x00A1A0B0
		public SBulletDataBase(TEnumAsByte<EBulletShape> 子弹形状, [Nullable(1)] TSoftObjectPtr<UStaticMesh> 子弹模型, FVector 初始大小, FVector 初始位置, FVector 初始旋转, float 持续时间, int 命中个数, int 作用次数, bool 被极限闪避后销毁, FName 被击效果, float 作用间隔, TEnumAsByte<EBulletRelativeDir> 受击类型, int 执行效果ID, FRotator 子弹攻击方向, bool 技能结束是否销毁子弹, int 伤害类型, bool 是否可以触发极限闪避, bool 是否触发拼刀, [Nullable(1)] TSoftClassPtr<UMatineeCameraShake> 攻击者震屏, TEnumAsByte<EBulletType> 子弹类型, TEnumAsByte<EBulletHitDirectionType> 受击角度判定类型)
		{
			this.子弹形状 = 子弹形状;
			this.子弹模型 = 子弹模型;
			this.初始大小 = 初始大小;
			this.初始位置 = 初始位置;
			this.初始旋转 = 初始旋转;
			this.持续时间 = 持续时间;
			this.命中个数 = 命中个数;
			this.作用次数 = 作用次数;
			this.被极限闪避后销毁 = 被极限闪避后销毁;
			this.被击效果 = 被击效果;
			this.作用间隔 = 作用间隔;
			this.受击类型 = 受击类型;
			this.执行效果ID = 执行效果ID;
			this.子弹攻击方向 = 子弹攻击方向;
			this.技能结束是否销毁子弹 = 技能结束是否销毁子弹;
			this.伤害类型 = 伤害类型;
			this.是否可以触发极限闪避 = 是否可以触发极限闪避;
			this.是否触发拼刀 = 是否触发拼刀;
			this.攻击者震屏 = 攻击者震屏;
			this.子弹类型 = 子弹类型;
			this.受击角度判定类型 = 受击角度判定类型;
		}

		// Token: 0x0602C469 RID: 181353 RVA: 0x00A1BF68 File Offset: 0x00A1A168
		protected override IntPtr GetUStructPtr()
		{
			return SBulletDataBase.StaticStruct();
		}

		// Token: 0x0602C46A RID: 181354 RVA: 0x00A1BF74 File Offset: 0x00A1A174
		[NullableContext(2)]
		public SBulletDataBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C46B RID: 181355 RVA: 0x00A1BF7E File Offset: 0x00A1A17E
		public SBulletDataBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C46C RID: 181356 RVA: 0x00A1BF89 File Offset: 0x00A1A189
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletDataBase(Pointer, false, true);
		}

		// Token: 0x0602C46D RID: 181357 RVA: 0x00A1BF93 File Offset: 0x00A1A193
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletDataBase(Pointer, MemoryOwner);
		}

		// Token: 0x0401757D RID: 95613
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBulletDataBase.SBulletDataBase";

		// Token: 0x0401757E RID: 95614
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401757F RID: 95615
		internal static int __PropertyOffset_0;

		// Token: 0x04017580 RID: 95616
		internal static int __PropertyOffset_1;

		// Token: 0x04017581 RID: 95617
		internal static int __PropertyOffset_2;

		// Token: 0x04017582 RID: 95618
		internal static int __PropertyOffset_3;

		// Token: 0x04017583 RID: 95619
		internal static int __PropertyOffset_4;

		// Token: 0x04017584 RID: 95620
		internal static int __PropertyOffset_5;

		// Token: 0x04017585 RID: 95621
		internal static int __PropertyOffset_6;

		// Token: 0x04017586 RID: 95622
		internal static int __PropertyOffset_7;

		// Token: 0x04017587 RID: 95623
		internal static int __PropertyOffset_8;

		// Token: 0x04017588 RID: 95624
		internal static int __PropertyOffset_9;

		// Token: 0x04017589 RID: 95625
		internal static int __PropertyOffset_10;

		// Token: 0x0401758A RID: 95626
		internal static int __PropertyOffset_11;

		// Token: 0x0401758B RID: 95627
		internal static int __PropertyOffset_12;

		// Token: 0x0401758C RID: 95628
		internal static int __PropertyOffset_13;

		// Token: 0x0401758D RID: 95629
		internal static int __PropertyOffset_14;

		// Token: 0x0401758E RID: 95630
		internal static int __PropertyOffset_15;

		// Token: 0x0401758F RID: 95631
		internal static int __PropertyOffset_16;

		// Token: 0x04017590 RID: 95632
		internal static int __PropertyOffset_17;

		// Token: 0x04017591 RID: 95633
		internal static int __PropertyOffset_18;

		// Token: 0x04017592 RID: 95634
		internal static int __PropertyOffset_19;

		// Token: 0x04017593 RID: 95635
		internal static int __PropertyOffset_20;
	}
}
