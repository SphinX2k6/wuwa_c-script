using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004015 RID: 16405
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataMain.SReBulletDataMain")]
	[UnrealStructLayout(1992, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1992)]
	public class SReBulletDataMain : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602A095 RID: 172181 RVA: 0x009D3E75 File Offset: 0x009D2075
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataMain._ScriptStructPtr != 0) ? SReBulletDataMain._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataMain.SReBulletDataMain", ref SReBulletDataMain._ScriptStructPtr);
		}

		// Token: 0x17006667 RID: 26215
		// (get) Token: 0x0602A096 RID: 172182 RVA: 0x009D3E99 File Offset: 0x009D2099
		// (set) Token: 0x0602A097 RID: 172183 RVA: 0x009D3EAD File Offset: 0x009D20AD
		public unsafe FName 子弹名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006668 RID: 26216
		// (get) Token: 0x0602A098 RID: 172184 RVA: 0x009D3EC4 File Offset: 0x009D20C4
		// (set) Token: 0x0602A099 RID: 172185 RVA: 0x009D3F07 File Offset: 0x009D2107
		public SReBulletDataBase 基础设置
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataBase result;
				if ((result = this._基础设置) == null)
				{
					result = (this._基础设置 = new SReBulletDataBase(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataBase.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006669 RID: 26217
		// (get) Token: 0x0602A09A RID: 172186 RVA: 0x009D3F28 File Offset: 0x009D2128
		// (set) Token: 0x0602A09B RID: 172187 RVA: 0x009D3F6B File Offset: 0x009D216B
		public SReBulletDataLogic 逻辑设置
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataLogic result;
				if ((result = this._逻辑设置) == null)
				{
					result = (this._逻辑设置 = new SReBulletDataLogic(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataLogic.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700666A RID: 26218
		// (get) Token: 0x0602A09C RID: 172188 RVA: 0x009D3F8C File Offset: 0x009D218C
		// (set) Token: 0x0602A09D RID: 172189 RVA: 0x009D3FA0 File Offset: 0x009D21A0
		public unsafe SReBulletDataAimed 瞄准设置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700666B RID: 26219
		// (get) Token: 0x0602A09E RID: 172190 RVA: 0x009D3FB8 File Offset: 0x009D21B8
		// (set) Token: 0x0602A09F RID: 172191 RVA: 0x009D3FFB File Offset: 0x009D21FB
		public SReBulletDataMove 移动设置
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataMove result;
				if ((result = this._移动设置) == null)
				{
					result = (this._移动设置 = new SReBulletDataMove(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataMove.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700666C RID: 26220
		// (get) Token: 0x0602A0A0 RID: 172192 RVA: 0x009D401C File Offset: 0x009D221C
		// (set) Token: 0x0602A0A1 RID: 172193 RVA: 0x009D405F File Offset: 0x009D225F
		public SReBulletDataPerformance 表现效果设置
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataPerformance result;
				if ((result = this._表现效果设置) == null)
				{
					result = (this._表现效果设置 = new SReBulletDataPerformance(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataPerformance.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700666D RID: 26221
		// (get) Token: 0x0602A0A2 RID: 172194 RVA: 0x009D4080 File Offset: 0x009D2280
		// (set) Token: 0x0602A0A3 RID: 172195 RVA: 0x009D40C3 File Offset: 0x009D22C3
		public SReBulletDataTime 时间膨胀
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataTime result;
				if ((result = this._时间膨胀) == null)
				{
					result = (this._时间膨胀 = new SReBulletDataTime(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataTime.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700666E RID: 26222
		// (get) Token: 0x0602A0A4 RID: 172196 RVA: 0x009D40E4 File Offset: 0x009D22E4
		// (set) Token: 0x0602A0A5 RID: 172197 RVA: 0x009D4127 File Offset: 0x009D2327
		public SReBulletDataExe 执行逻辑
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataExe result;
				if ((result = this._执行逻辑) == null)
				{
					result = (this._执行逻辑 = new SReBulletDataExe(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataExe.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700666F RID: 26223
		// (get) Token: 0x0602A0A6 RID: 172198 RVA: 0x009D4148 File Offset: 0x009D2348
		// (set) Token: 0x0602A0A7 RID: 172199 RVA: 0x009D418B File Offset: 0x009D238B
		public SReBulletDataScale 缩放设置
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataScale result;
				if ((result = this._缩放设置) == null)
				{
					result = (this._缩放设置 = new SReBulletDataScale(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataScale.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006670 RID: 26224
		// (get) Token: 0x0602A0A8 RID: 172200 RVA: 0x009D41AC File Offset: 0x009D23AC
		// (set) Token: 0x0602A0A9 RID: 172201 RVA: 0x009D41C0 File Offset: 0x009D23C0
		public unsafe SReBulletDataEntity 召唤实体
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006671 RID: 26225
		// (get) Token: 0x0602A0AA RID: 172202 RVA: 0x009D41D8 File Offset: 0x009D23D8
		// (set) Token: 0x0602A0AB RID: 172203 RVA: 0x009D421B File Offset: 0x009D241B
		public TArray<SReBulletDataChildren> 子子弹设置
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SReBulletDataChildren> result;
				if ((result = this._子子弹设置) == null)
				{
					result = (this._子子弹设置 = new TArray<SReBulletDataChildren>(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_10, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.子子弹设置.CopyAssign(value);
			}
		}

		// Token: 0x17006672 RID: 26226
		// (get) Token: 0x0602A0AC RID: 172204 RVA: 0x009D4229 File Offset: 0x009D2429
		// (set) Token: 0x0602A0AD RID: 172205 RVA: 0x009D423D File Offset: 0x009D243D
		public unsafe SReBulletDataObstacles 障碍检测
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006673 RID: 26227
		// (get) Token: 0x0602A0AE RID: 172206 RVA: 0x009D4254 File Offset: 0x009D2454
		// (set) Token: 0x0602A0AF RID: 172207 RVA: 0x009D4297 File Offset: 0x009D2497
		public SReBulletDataInteraction 环境交互
		{
			get
			{
				base.FastCheckIsValid();
				SReBulletDataInteraction result;
				if ((result = this._环境交互) == null)
				{
					result = (this._环境交互 = new SReBulletDataInteraction(base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataInteraction.StaticStruct(), base.NativePtr + (IntPtr)SReBulletDataMain.__PropertyOffset_12, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602A0B0 RID: 172208 RVA: 0x009D42B8 File Offset: 0x009D24B8
		public SReBulletDataMain()
		{
		}

		// Token: 0x0602A0B1 RID: 172209 RVA: 0x009D42C0 File Offset: 0x009D24C0
		public SReBulletDataMain(FName 子弹名称, SReBulletDataBase 基础设置, SReBulletDataLogic 逻辑设置, SReBulletDataAimed 瞄准设置, SReBulletDataMove 移动设置, SReBulletDataPerformance 表现效果设置, SReBulletDataTime 时间膨胀, SReBulletDataExe 执行逻辑, SReBulletDataScale 缩放设置, SReBulletDataEntity 召唤实体, TArray<SReBulletDataChildren> 子子弹设置, SReBulletDataObstacles 障碍检测, SReBulletDataInteraction 环境交互)
		{
			this.子弹名称 = 子弹名称;
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

		// Token: 0x0602A0B2 RID: 172210 RVA: 0x009D4338 File Offset: 0x009D2538
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataMain.StaticStruct();
		}

		// Token: 0x0602A0B3 RID: 172211 RVA: 0x009D4344 File Offset: 0x009D2544
		[NullableContext(2)]
		public SReBulletDataMain(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A0B4 RID: 172212 RVA: 0x009D434E File Offset: 0x009D254E
		public SReBulletDataMain(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A0B5 RID: 172213 RVA: 0x009D4359 File Offset: 0x009D2559
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataMain(Pointer, false, true);
		}

		// Token: 0x0602A0B6 RID: 172214 RVA: 0x009D4363 File Offset: 0x009D2563
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataMain(Pointer, MemoryOwner);
		}

		// Token: 0x04015A5A RID: 88666
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataMain.SReBulletDataMain";

		// Token: 0x04015A5B RID: 88667
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015A5C RID: 88668
		internal static int __PropertyOffset_0;

		// Token: 0x04015A5D RID: 88669
		internal static int __PropertyOffset_1;

		// Token: 0x04015A5E RID: 88670
		[Nullable(2)]
		private SReBulletDataBase _基础设置;

		// Token: 0x04015A5F RID: 88671
		internal static int __PropertyOffset_2;

		// Token: 0x04015A60 RID: 88672
		[Nullable(2)]
		private SReBulletDataLogic _逻辑设置;

		// Token: 0x04015A61 RID: 88673
		internal static int __PropertyOffset_3;

		// Token: 0x04015A62 RID: 88674
		internal static int __PropertyOffset_4;

		// Token: 0x04015A63 RID: 88675
		[Nullable(2)]
		private SReBulletDataMove _移动设置;

		// Token: 0x04015A64 RID: 88676
		internal static int __PropertyOffset_5;

		// Token: 0x04015A65 RID: 88677
		[Nullable(2)]
		private SReBulletDataPerformance _表现效果设置;

		// Token: 0x04015A66 RID: 88678
		internal static int __PropertyOffset_6;

		// Token: 0x04015A67 RID: 88679
		[Nullable(2)]
		private SReBulletDataTime _时间膨胀;

		// Token: 0x04015A68 RID: 88680
		internal static int __PropertyOffset_7;

		// Token: 0x04015A69 RID: 88681
		[Nullable(2)]
		private SReBulletDataExe _执行逻辑;

		// Token: 0x04015A6A RID: 88682
		internal static int __PropertyOffset_8;

		// Token: 0x04015A6B RID: 88683
		[Nullable(2)]
		private SReBulletDataScale _缩放设置;

		// Token: 0x04015A6C RID: 88684
		internal static int __PropertyOffset_9;

		// Token: 0x04015A6D RID: 88685
		internal static int __PropertyOffset_10;

		// Token: 0x04015A6E RID: 88686
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SReBulletDataChildren> _子子弹设置;

		// Token: 0x04015A6F RID: 88687
		internal static int __PropertyOffset_11;

		// Token: 0x04015A70 RID: 88688
		internal static int __PropertyOffset_12;

		// Token: 0x04015A71 RID: 88689
		[Nullable(2)]
		private SReBulletDataInteraction _环境交互;
	}
}
