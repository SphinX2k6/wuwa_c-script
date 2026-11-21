using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003277 RID: 12919
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataMove.SReBulletDataMove")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 296)]
	public class SReBulletDataMove : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020462 RID: 132194 RVA: 0x00941AB0 File Offset: 0x0093FCB0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataMove._ScriptStructPtr != 0) ? SReBulletDataMove._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataMove.SReBulletDataMove", ref SReBulletDataMove._ScriptStructPtr);
		}

		// Token: 0x17003E3A RID: 15930
		// (get) Token: 0x06020463 RID: 132195 RVA: 0x00941AD4 File Offset: 0x0093FCD4
		// (set) Token: 0x06020464 RID: 132196 RVA: 0x00941AE8 File Offset: 0x0093FCE8
		[Nullable(0)]
		public unsafe TEnumAsByte<EBulletFollowType> 子弹跟随类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_子弹跟随类型);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_子弹跟随类型) = value;
			}
		}

		// Token: 0x17003E3B RID: 15931
		// (get) Token: 0x06020465 RID: 132197 RVA: 0x00941AFD File Offset: 0x0093FCFD
		// (set) Token: 0x06020466 RID: 132198 RVA: 0x00941B11 File Offset: 0x0093FD11
		public unsafe string 骨骼网格体名字
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_骨骼网格体名字)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_骨骼网格体名字)), value);
			}
		}

		// Token: 0x17003E3C RID: 15932
		// (get) Token: 0x06020467 RID: 132199 RVA: 0x00941B26 File Offset: 0x0093FD26
		// (set) Token: 0x06020468 RID: 132200 RVA: 0x00941B3A File Offset: 0x0093FD3A
		public unsafe FName 骨骼名字
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_骨骼名字);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_骨骼名字) = value;
			}
		}

		// Token: 0x17003E3D RID: 15933
		// (get) Token: 0x06020469 RID: 132201 RVA: 0x00941B4F File Offset: 0x0093FD4F
		// (set) Token: 0x0602046A RID: 132202 RVA: 0x00941B5F File Offset: 0x0093FD5F
		public unsafe bool 是否锁定缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_是否锁定缩放) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_是否锁定缩放) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E3E RID: 15934
		// (get) Token: 0x0602046B RID: 132203 RVA: 0x00941B70 File Offset: 0x0093FD70
		// (set) Token: 0x0602046C RID: 132204 RVA: 0x00941B80 File Offset: 0x0093FD80
		public unsafe bool 技能结束解除跟随骨骼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_技能结束解除跟随骨骼) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_技能结束解除跟随骨骼) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E3F RID: 15935
		// (get) Token: 0x0602046D RID: 132205 RVA: 0x00941B91 File Offset: 0x0093FD91
		// (set) Token: 0x0602046E RID: 132206 RVA: 0x00941BA5 File Offset: 0x0093FDA5
		public unsafe FVector 跟随骨骼限制旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_跟随骨骼限制旋转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_跟随骨骼限制旋转) = value;
			}
		}

		// Token: 0x17003E40 RID: 15936
		// (get) Token: 0x0602046F RID: 132207 RVA: 0x00941BBA File Offset: 0x0093FDBA
		// (set) Token: 0x06020470 RID: 132208 RVA: 0x00941BCE File Offset: 0x0093FDCE
		[Nullable(0)]
		public unsafe TEnumAsByte<EInitialVelocityDirection> 出生初速度方向基准
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_出生初速度方向基准);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_出生初速度方向基准) = value;
			}
		}

		// Token: 0x17003E41 RID: 15937
		// (get) Token: 0x06020471 RID: 132209 RVA: 0x00941BE3 File Offset: 0x0093FDE3
		// (set) Token: 0x06020472 RID: 132210 RVA: 0x00941BF7 File Offset: 0x0093FDF7
		public unsafe string 出生初速度方向基准参数
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_出生初速度方向基准参数)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_出生初速度方向基准参数)), value);
			}
		}

		// Token: 0x17003E42 RID: 15938
		// (get) Token: 0x06020473 RID: 132211 RVA: 0x00941C0C File Offset: 0x0093FE0C
		// (set) Token: 0x06020474 RID: 132212 RVA: 0x00941C1C File Offset: 0x0093FE1C
		public unsafe bool 初速度仅Z轴朝向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_初速度仅Z轴朝向) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_初速度仅Z轴朝向) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E43 RID: 15939
		// (get) Token: 0x06020475 RID: 132213 RVA: 0x00941C2D File Offset: 0x0093FE2D
		// (set) Token: 0x06020476 RID: 132214 RVA: 0x00941C41 File Offset: 0x0093FE41
		public unsafe FRotator 初速度偏移方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_初速度偏移方向);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_初速度偏移方向) = value;
			}
		}

		// Token: 0x17003E44 RID: 15940
		// (get) Token: 0x06020477 RID: 132215 RVA: 0x00941C56 File Offset: 0x0093FE56
		// (set) Token: 0x06020478 RID: 132216 RVA: 0x00941C6A File Offset: 0x0093FE6A
		public unsafe FVector 初速度方向随机
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_初速度方向随机);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_初速度方向随机) = value;
			}
		}

		// Token: 0x17003E45 RID: 15941
		// (get) Token: 0x06020479 RID: 132217 RVA: 0x00941C80 File Offset: 0x0093FE80
		// (set) Token: 0x0602047A RID: 132218 RVA: 0x00941CC3 File Offset: 0x0093FEC3
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EBulletBeginVelocityLimit>, float> 初速度角度限制
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EBulletBeginVelocityLimit>, float> result;
				if ((result = this._初速度角度限制) == null)
				{
					result = (this._初速度角度限制 = new TMap<TEnumAsByte<EBulletBeginVelocityLimit>, float>(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_初速度角度限制, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.初速度角度限制.CopyAssign(value);
			}
		}

		// Token: 0x17003E46 RID: 15942
		// (get) Token: 0x0602047B RID: 132219 RVA: 0x00941CD1 File Offset: 0x0093FED1
		// (set) Token: 0x0602047C RID: 132220 RVA: 0x00941CE1 File Offset: 0x0093FEE1
		public unsafe float 发射上下角度限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_发射上下角度限制);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_发射上下角度限制) = value;
			}
		}

		// Token: 0x17003E47 RID: 15943
		// (get) Token: 0x0602047D RID: 132221 RVA: 0x00941CF2 File Offset: 0x0093FEF2
		// (set) Token: 0x0602047E RID: 132222 RVA: 0x00941D02 File Offset: 0x0093FF02
		public unsafe float 移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_移动速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_移动速度) = value;
			}
		}

		// Token: 0x17003E48 RID: 15944
		// (get) Token: 0x0602047F RID: 132223 RVA: 0x00941D13 File Offset: 0x0093FF13
		// (set) Token: 0x06020480 RID: 132224 RVA: 0x00941D27 File Offset: 0x0093FF27
		[Nullable(2)]
		public unsafe UCurveFloat 移动速度曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SReBulletDataMove.__PropertyOffset_移动速度曲线);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SReBulletDataMove.__PropertyOffset_移动速度曲线, value);
			}
		}

		// Token: 0x17003E49 RID: 15945
		// (get) Token: 0x06020481 RID: 132225 RVA: 0x00941D3C File Offset: 0x0093FF3C
		// (set) Token: 0x06020482 RID: 132226 RVA: 0x00941D50 File Offset: 0x0093FF50
		[Nullable(0)]
		public unsafe TEnumAsByte<EMoveTrajectory> 运动轨迹类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_运动轨迹类型);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_运动轨迹类型) = value;
			}
		}

		// Token: 0x17003E4A RID: 15946
		// (get) Token: 0x06020483 RID: 132227 RVA: 0x00941D68 File Offset: 0x0093FF68
		// (set) Token: 0x06020484 RID: 132228 RVA: 0x00941DAB File Offset: 0x0093FFAB
		public TArray<FVector> 运动轨迹参数数据
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._运动轨迹参数数据) == null)
				{
					result = (this._运动轨迹参数数据 = new TArray<FVector>(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_运动轨迹参数数据, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.运动轨迹参数数据.CopyAssign(value);
			}
		}

		// Token: 0x17003E4B RID: 15947
		// (get) Token: 0x06020485 RID: 132229 RVA: 0x00941DBC File Offset: 0x0093FFBC
		// (set) Token: 0x06020486 RID: 132230 RVA: 0x00941DFF File Offset: 0x0093FFFF
		public TArray<UCurveVector> 运动轨迹参数曲线
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UCurveVector> result;
				if ((result = this._运动轨迹参数曲线) == null)
				{
					result = (this._运动轨迹参数曲线 = new TArray<UCurveVector>(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_运动轨迹参数曲线, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.运动轨迹参数曲线.CopyAssign(value);
			}
		}

		// Token: 0x17003E4C RID: 15948
		// (get) Token: 0x06020487 RID: 132231 RVA: 0x00941E0D File Offset: 0x0094000D
		// (set) Token: 0x06020488 RID: 132232 RVA: 0x00941E21 File Offset: 0x00940021
		[Nullable(0)]
		public unsafe TEnumAsByte<EBulletTarget> 运动轨迹参数目标
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_运动轨迹参数目标);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_运动轨迹参数目标) = value;
			}
		}

		// Token: 0x17003E4D RID: 15949
		// (get) Token: 0x06020489 RID: 132233 RVA: 0x00941E36 File Offset: 0x00940036
		// (set) Token: 0x0602048A RID: 132234 RVA: 0x00941E4A File Offset: 0x0094004A
		public unsafe string 运动轨迹目标黑板Key值
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_运动轨迹目标黑板Key值)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_运动轨迹目标黑板Key值)), value);
			}
		}

		// Token: 0x17003E4E RID: 15950
		// (get) Token: 0x0602048B RID: 132235 RVA: 0x00941E5F File Offset: 0x0094005F
		// (set) Token: 0x0602048C RID: 132236 RVA: 0x00941E73 File Offset: 0x00940073
		[Nullable(0)]
		public unsafe TEnumAsByte<EBulletDestOffset> 终点偏移基准朝向
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_终点偏移基准朝向);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_终点偏移基准朝向) = value;
			}
		}

		// Token: 0x17003E4F RID: 15951
		// (get) Token: 0x0602048D RID: 132237 RVA: 0x00941E88 File Offset: 0x00940088
		// (set) Token: 0x0602048E RID: 132238 RVA: 0x00941E9C File Offset: 0x0094009C
		public unsafe FVector 终点偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_终点偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_终点偏移) = value;
			}
		}

		// Token: 0x17003E50 RID: 15952
		// (get) Token: 0x0602048F RID: 132239 RVA: 0x00941EB1 File Offset: 0x009400B1
		// (set) Token: 0x06020490 RID: 132240 RVA: 0x00941EC5 File Offset: 0x009400C5
		public unsafe string 运动轨迹目标骨骼
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_运动轨迹目标骨骼)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_运动轨迹目标骨骼)), value);
			}
		}

		// Token: 0x06020491 RID: 132241 RVA: 0x00941EDA File Offset: 0x009400DA
		public SReBulletDataMove()
		{
		}

		// Token: 0x06020492 RID: 132242 RVA: 0x00941EE2 File Offset: 0x009400E2
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataMove.StaticStruct();
		}

		// Token: 0x06020493 RID: 132243 RVA: 0x00941EEE File Offset: 0x009400EE
		[NullableContext(2)]
		public SReBulletDataMove(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020494 RID: 132244 RVA: 0x00941EF8 File Offset: 0x009400F8
		public SReBulletDataMove(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020495 RID: 132245 RVA: 0x00941F03 File Offset: 0x00940103
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataMove(Pointer, false, true);
		}

		// Token: 0x06020496 RID: 132246 RVA: 0x00941F0D File Offset: 0x0094010D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataMove(Pointer, MemoryOwner);
		}

		// Token: 0x040116C4 RID: 71364
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataMove.SReBulletDataMove";

		// Token: 0x040116C5 RID: 71365
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040116C6 RID: 71366
		internal static int __PropertyOffset_子弹跟随类型;

		// Token: 0x040116C7 RID: 71367
		internal static int __PropertyOffset_骨骼网格体名字;

		// Token: 0x040116C8 RID: 71368
		internal static int __PropertyOffset_骨骼名字;

		// Token: 0x040116C9 RID: 71369
		internal static int __PropertyOffset_是否锁定缩放;

		// Token: 0x040116CA RID: 71370
		internal static int __PropertyOffset_技能结束解除跟随骨骼;

		// Token: 0x040116CB RID: 71371
		internal static int __PropertyOffset_跟随骨骼限制旋转;

		// Token: 0x040116CC RID: 71372
		internal static int __PropertyOffset_出生初速度方向基准;

		// Token: 0x040116CD RID: 71373
		internal static int __PropertyOffset_出生初速度方向基准参数;

		// Token: 0x040116CE RID: 71374
		internal static int __PropertyOffset_初速度仅Z轴朝向;

		// Token: 0x040116CF RID: 71375
		internal static int __PropertyOffset_初速度偏移方向;

		// Token: 0x040116D0 RID: 71376
		internal static int __PropertyOffset_初速度方向随机;

		// Token: 0x040116D1 RID: 71377
		internal static int __PropertyOffset_初速度角度限制;

		// Token: 0x040116D2 RID: 71378
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EBulletBeginVelocityLimit>, float> _初速度角度限制;

		// Token: 0x040116D3 RID: 71379
		internal static int __PropertyOffset_发射上下角度限制;

		// Token: 0x040116D4 RID: 71380
		internal static int __PropertyOffset_移动速度;

		// Token: 0x040116D5 RID: 71381
		internal static int __PropertyOffset_移动速度曲线;

		// Token: 0x040116D6 RID: 71382
		internal static int __PropertyOffset_运动轨迹类型;

		// Token: 0x040116D7 RID: 71383
		internal static int __PropertyOffset_运动轨迹参数数据;

		// Token: 0x040116D8 RID: 71384
		[Nullable(2)]
		private TArray<FVector> _运动轨迹参数数据;

		// Token: 0x040116D9 RID: 71385
		internal static int __PropertyOffset_运动轨迹参数曲线;

		// Token: 0x040116DA RID: 71386
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UCurveVector> _运动轨迹参数曲线;

		// Token: 0x040116DB RID: 71387
		internal static int __PropertyOffset_运动轨迹参数目标;

		// Token: 0x040116DC RID: 71388
		internal static int __PropertyOffset_运动轨迹目标黑板Key值;

		// Token: 0x040116DD RID: 71389
		internal static int __PropertyOffset_终点偏移基准朝向;

		// Token: 0x040116DE RID: 71390
		internal static int __PropertyOffset_终点偏移;

		// Token: 0x040116DF RID: 71391
		internal static int __PropertyOffset_运动轨迹目标骨骼;
	}
}
