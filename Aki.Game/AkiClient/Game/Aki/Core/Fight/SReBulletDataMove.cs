using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004016 RID: 16406
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataMove.SReBulletDataMove")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 296)]
	public class SReBulletDataMove : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602A0B7 RID: 172215 RVA: 0x009D436C File Offset: 0x009D256C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataMove._ScriptStructPtr != 0) ? SReBulletDataMove._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataMove.SReBulletDataMove", ref SReBulletDataMove._ScriptStructPtr);
		}

		// Token: 0x17006674 RID: 26228
		// (get) Token: 0x0602A0B8 RID: 172216 RVA: 0x009D4390 File Offset: 0x009D2590
		// (set) Token: 0x0602A0B9 RID: 172217 RVA: 0x009D43A4 File Offset: 0x009D25A4
		[Nullable(0)]
		public unsafe TEnumAsByte<EBulletFollowType> 子弹跟随类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_0);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006675 RID: 26229
		// (get) Token: 0x0602A0BA RID: 172218 RVA: 0x009D43B9 File Offset: 0x009D25B9
		// (set) Token: 0x0602A0BB RID: 172219 RVA: 0x009D43CD File Offset: 0x009D25CD
		public unsafe string 骨骼网格体名字
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006676 RID: 26230
		// (get) Token: 0x0602A0BC RID: 172220 RVA: 0x009D43E2 File Offset: 0x009D25E2
		// (set) Token: 0x0602A0BD RID: 172221 RVA: 0x009D43F6 File Offset: 0x009D25F6
		public unsafe FName 骨骼名字
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006677 RID: 26231
		// (get) Token: 0x0602A0BE RID: 172222 RVA: 0x009D440B File Offset: 0x009D260B
		// (set) Token: 0x0602A0BF RID: 172223 RVA: 0x009D441B File Offset: 0x009D261B
		public unsafe bool 是否锁定缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006678 RID: 26232
		// (get) Token: 0x0602A0C0 RID: 172224 RVA: 0x009D442C File Offset: 0x009D262C
		// (set) Token: 0x0602A0C1 RID: 172225 RVA: 0x009D443C File Offset: 0x009D263C
		public unsafe bool 技能结束解除跟随骨骼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006679 RID: 26233
		// (get) Token: 0x0602A0C2 RID: 172226 RVA: 0x009D444D File Offset: 0x009D264D
		// (set) Token: 0x0602A0C3 RID: 172227 RVA: 0x009D4461 File Offset: 0x009D2661
		public unsafe FVector 跟随骨骼限制旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700667A RID: 26234
		// (get) Token: 0x0602A0C4 RID: 172228 RVA: 0x009D4476 File Offset: 0x009D2676
		// (set) Token: 0x0602A0C5 RID: 172229 RVA: 0x009D448A File Offset: 0x009D268A
		[Nullable(0)]
		public unsafe TEnumAsByte<EInitialVelocityDirection> 出生初速度方向基准
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_6);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700667B RID: 26235
		// (get) Token: 0x0602A0C6 RID: 172230 RVA: 0x009D449F File Offset: 0x009D269F
		// (set) Token: 0x0602A0C7 RID: 172231 RVA: 0x009D44B3 File Offset: 0x009D26B3
		public unsafe string 出生初速度方向基准参数
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_7)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_7)), value);
			}
		}

		// Token: 0x1700667C RID: 26236
		// (get) Token: 0x0602A0C8 RID: 172232 RVA: 0x009D44C8 File Offset: 0x009D26C8
		// (set) Token: 0x0602A0C9 RID: 172233 RVA: 0x009D44D8 File Offset: 0x009D26D8
		public unsafe bool 初速度仅Z轴朝向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700667D RID: 26237
		// (get) Token: 0x0602A0CA RID: 172234 RVA: 0x009D44E9 File Offset: 0x009D26E9
		// (set) Token: 0x0602A0CB RID: 172235 RVA: 0x009D44FD File Offset: 0x009D26FD
		public unsafe FRotator 初速度偏移方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700667E RID: 26238
		// (get) Token: 0x0602A0CC RID: 172236 RVA: 0x009D4512 File Offset: 0x009D2712
		// (set) Token: 0x0602A0CD RID: 172237 RVA: 0x009D4526 File Offset: 0x009D2726
		public unsafe FVector 初速度方向随机
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700667F RID: 26239
		// (get) Token: 0x0602A0CE RID: 172238 RVA: 0x009D453C File Offset: 0x009D273C
		// (set) Token: 0x0602A0CF RID: 172239 RVA: 0x009D457F File Offset: 0x009D277F
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
					result = (this._初速度角度限制 = new TMap<TEnumAsByte<EBulletBeginVelocityLimit>, float>(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_11, base.MemoryOwner ?? this));
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

		// Token: 0x17006680 RID: 26240
		// (get) Token: 0x0602A0D0 RID: 172240 RVA: 0x009D458D File Offset: 0x009D278D
		// (set) Token: 0x0602A0D1 RID: 172241 RVA: 0x009D459D File Offset: 0x009D279D
		public unsafe float 发射上下角度限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006681 RID: 26241
		// (get) Token: 0x0602A0D2 RID: 172242 RVA: 0x009D45AE File Offset: 0x009D27AE
		// (set) Token: 0x0602A0D3 RID: 172243 RVA: 0x009D45BE File Offset: 0x009D27BE
		public unsafe float 移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006682 RID: 26242
		// (get) Token: 0x0602A0D4 RID: 172244 RVA: 0x009D45CF File Offset: 0x009D27CF
		// (set) Token: 0x0602A0D5 RID: 172245 RVA: 0x009D45E3 File Offset: 0x009D27E3
		[Nullable(2)]
		public unsafe UCurveFloat 移动速度曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SReBulletDataMove.__PropertyOffset_14);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SReBulletDataMove.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17006683 RID: 26243
		// (get) Token: 0x0602A0D6 RID: 172246 RVA: 0x009D45F8 File Offset: 0x009D27F8
		// (set) Token: 0x0602A0D7 RID: 172247 RVA: 0x009D460C File Offset: 0x009D280C
		[Nullable(0)]
		public unsafe TEnumAsByte<EMoveTrajectory> 运动轨迹类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_15);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006684 RID: 26244
		// (get) Token: 0x0602A0D8 RID: 172248 RVA: 0x009D4624 File Offset: 0x009D2824
		// (set) Token: 0x0602A0D9 RID: 172249 RVA: 0x009D4667 File Offset: 0x009D2867
		public TArray<FVector> 运动轨迹参数数据
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._运动轨迹参数数据) == null)
				{
					result = (this._运动轨迹参数数据 = new TArray<FVector>(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_16, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.运动轨迹参数数据.CopyAssign(value);
			}
		}

		// Token: 0x17006685 RID: 26245
		// (get) Token: 0x0602A0DA RID: 172250 RVA: 0x009D4678 File Offset: 0x009D2878
		// (set) Token: 0x0602A0DB RID: 172251 RVA: 0x009D46BB File Offset: 0x009D28BB
		public TArray<UCurveVector> 运动轨迹参数曲线
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UCurveVector> result;
				if ((result = this._运动轨迹参数曲线) == null)
				{
					result = (this._运动轨迹参数曲线 = new TArray<UCurveVector>(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_17, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.运动轨迹参数曲线.CopyAssign(value);
			}
		}

		// Token: 0x17006686 RID: 26246
		// (get) Token: 0x0602A0DC RID: 172252 RVA: 0x009D46C9 File Offset: 0x009D28C9
		// (set) Token: 0x0602A0DD RID: 172253 RVA: 0x009D46DD File Offset: 0x009D28DD
		[Nullable(0)]
		public unsafe TEnumAsByte<EBulletTarget> 运动轨迹参数目标
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_18);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006687 RID: 26247
		// (get) Token: 0x0602A0DE RID: 172254 RVA: 0x009D46F2 File Offset: 0x009D28F2
		// (set) Token: 0x0602A0DF RID: 172255 RVA: 0x009D4706 File Offset: 0x009D2906
		public unsafe string 运动轨迹目标黑板Key值
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_19)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_19)), value);
			}
		}

		// Token: 0x17006688 RID: 26248
		// (get) Token: 0x0602A0E0 RID: 172256 RVA: 0x009D471B File Offset: 0x009D291B
		// (set) Token: 0x0602A0E1 RID: 172257 RVA: 0x009D472F File Offset: 0x009D292F
		[Nullable(0)]
		public unsafe TEnumAsByte<EBulletDestOffset> 终点偏移基准朝向
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_20);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17006689 RID: 26249
		// (get) Token: 0x0602A0E2 RID: 172258 RVA: 0x009D4744 File Offset: 0x009D2944
		// (set) Token: 0x0602A0E3 RID: 172259 RVA: 0x009D4758 File Offset: 0x009D2958
		public unsafe FVector 终点偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMove.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700668A RID: 26250
		// (get) Token: 0x0602A0E4 RID: 172260 RVA: 0x009D476D File Offset: 0x009D296D
		// (set) Token: 0x0602A0E5 RID: 172261 RVA: 0x009D4781 File Offset: 0x009D2981
		public unsafe string 运动轨迹目标骨骼
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_22)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SReBulletDataMove.__PropertyOffset_22)), value);
			}
		}

		// Token: 0x0602A0E6 RID: 172262 RVA: 0x009D4796 File Offset: 0x009D2996
		public SReBulletDataMove()
		{
		}

		// Token: 0x0602A0E7 RID: 172263 RVA: 0x009D47A0 File Offset: 0x009D29A0
		public SReBulletDataMove([Nullable(0)] TEnumAsByte<EBulletFollowType> 子弹跟随类型, string 骨骼网格体名字, FName 骨骼名字, bool 是否锁定缩放, bool 技能结束解除跟随骨骼, FVector 跟随骨骼限制旋转, [Nullable(0)] TEnumAsByte<EInitialVelocityDirection> 出生初速度方向基准, string 出生初速度方向基准参数, bool 初速度仅Z轴朝向, FRotator 初速度偏移方向, FVector 初速度方向随机, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EBulletBeginVelocityLimit>, float> 初速度角度限制, float 发射上下角度限制, float 移动速度, UCurveFloat 移动速度曲线, [Nullable(0)] TEnumAsByte<EMoveTrajectory> 运动轨迹类型, TArray<FVector> 运动轨迹参数数据, TArray<UCurveVector> 运动轨迹参数曲线, [Nullable(0)] TEnumAsByte<EBulletTarget> 运动轨迹参数目标, string 运动轨迹目标黑板Key值, [Nullable(0)] TEnumAsByte<EBulletDestOffset> 终点偏移基准朝向, FVector 终点偏移, string 运动轨迹目标骨骼)
		{
			this.子弹跟随类型 = 子弹跟随类型;
			this.骨骼网格体名字 = 骨骼网格体名字;
			this.骨骼名字 = 骨骼名字;
			this.是否锁定缩放 = 是否锁定缩放;
			this.技能结束解除跟随骨骼 = 技能结束解除跟随骨骼;
			this.跟随骨骼限制旋转 = 跟随骨骼限制旋转;
			this.出生初速度方向基准 = 出生初速度方向基准;
			this.出生初速度方向基准参数 = 出生初速度方向基准参数;
			this.初速度仅Z轴朝向 = 初速度仅Z轴朝向;
			this.初速度偏移方向 = 初速度偏移方向;
			this.初速度方向随机 = 初速度方向随机;
			this.初速度角度限制 = 初速度角度限制;
			this.发射上下角度限制 = 发射上下角度限制;
			this.移动速度 = 移动速度;
			this.移动速度曲线 = 移动速度曲线;
			this.运动轨迹类型 = 运动轨迹类型;
			this.运动轨迹参数数据 = 运动轨迹参数数据;
			this.运动轨迹参数曲线 = 运动轨迹参数曲线;
			this.运动轨迹参数目标 = 运动轨迹参数目标;
			this.运动轨迹目标黑板Key值 = 运动轨迹目标黑板Key值;
			this.终点偏移基准朝向 = 终点偏移基准朝向;
			this.终点偏移 = 终点偏移;
			this.运动轨迹目标骨骼 = 运动轨迹目标骨骼;
		}

		// Token: 0x0602A0E8 RID: 172264 RVA: 0x009D4868 File Offset: 0x009D2A68
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataMove.StaticStruct();
		}

		// Token: 0x0602A0E9 RID: 172265 RVA: 0x009D4874 File Offset: 0x009D2A74
		[NullableContext(2)]
		public SReBulletDataMove(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A0EA RID: 172266 RVA: 0x009D487E File Offset: 0x009D2A7E
		public SReBulletDataMove(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A0EB RID: 172267 RVA: 0x009D4889 File Offset: 0x009D2A89
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataMove(Pointer, false, true);
		}

		// Token: 0x0602A0EC RID: 172268 RVA: 0x009D4893 File Offset: 0x009D2A93
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataMove(Pointer, MemoryOwner);
		}

		// Token: 0x04015A72 RID: 88690
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataMove.SReBulletDataMove";

		// Token: 0x04015A73 RID: 88691
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015A74 RID: 88692
		internal static int __PropertyOffset_0;

		// Token: 0x04015A75 RID: 88693
		internal static int __PropertyOffset_1;

		// Token: 0x04015A76 RID: 88694
		internal static int __PropertyOffset_2;

		// Token: 0x04015A77 RID: 88695
		internal static int __PropertyOffset_3;

		// Token: 0x04015A78 RID: 88696
		internal static int __PropertyOffset_4;

		// Token: 0x04015A79 RID: 88697
		internal static int __PropertyOffset_5;

		// Token: 0x04015A7A RID: 88698
		internal static int __PropertyOffset_6;

		// Token: 0x04015A7B RID: 88699
		internal static int __PropertyOffset_7;

		// Token: 0x04015A7C RID: 88700
		internal static int __PropertyOffset_8;

		// Token: 0x04015A7D RID: 88701
		internal static int __PropertyOffset_9;

		// Token: 0x04015A7E RID: 88702
		internal static int __PropertyOffset_10;

		// Token: 0x04015A7F RID: 88703
		internal static int __PropertyOffset_11;

		// Token: 0x04015A80 RID: 88704
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EBulletBeginVelocityLimit>, float> _初速度角度限制;

		// Token: 0x04015A81 RID: 88705
		internal static int __PropertyOffset_12;

		// Token: 0x04015A82 RID: 88706
		internal static int __PropertyOffset_13;

		// Token: 0x04015A83 RID: 88707
		internal static int __PropertyOffset_14;

		// Token: 0x04015A84 RID: 88708
		internal static int __PropertyOffset_15;

		// Token: 0x04015A85 RID: 88709
		internal static int __PropertyOffset_16;

		// Token: 0x04015A86 RID: 88710
		[Nullable(2)]
		private TArray<FVector> _运动轨迹参数数据;

		// Token: 0x04015A87 RID: 88711
		internal static int __PropertyOffset_17;

		// Token: 0x04015A88 RID: 88712
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UCurveVector> _运动轨迹参数曲线;

		// Token: 0x04015A89 RID: 88713
		internal static int __PropertyOffset_18;

		// Token: 0x04015A8A RID: 88714
		internal static int __PropertyOffset_19;

		// Token: 0x04015A8B RID: 88715
		internal static int __PropertyOffset_20;

		// Token: 0x04015A8C RID: 88716
		internal static int __PropertyOffset_21;

		// Token: 0x04015A8D RID: 88717
		internal static int __PropertyOffset_22;
	}
}
