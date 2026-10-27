using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene
{
	// Token: 0x02003DCC RID: 15820
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_SuperFarFog.BP_SuperFarFog_C")]
	[UnrealStructLayout(1872, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1872)]
	public class BP_SuperFarFog_C : AKuroSuperFarFog, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060276B2 RID: 161458 RVA: 0x00990928 File Offset: 0x0098EB28
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SuperFarFog_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_SuperFarFog.BP_SuperFarFog_C");
			}
			return BP_SuperFarFog_C._ClassPtr;
		}

		// Token: 0x060276B3 RID: 161459 RVA: 0x0099094C File Offset: 0x0098EB4C
		public BP_SuperFarFog_C() : this(BuiltinUtils.AllocNativeUObject(BP_SuperFarFog_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060276B4 RID: 161460 RVA: 0x00990974 File Offset: 0x0098EB74
		public BP_SuperFarFog_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SuperFarFog_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700580A RID: 22538
		// (get) Token: 0x060276B5 RID: 161461 RVA: 0x009909A7 File Offset: 0x0098EBA7
		// (set) Token: 0x060276B6 RID: 161462 RVA: 0x009909B7 File Offset: 0x0098EBB7
		public unsafe bool 固定旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700580B RID: 22539
		// (get) Token: 0x060276B7 RID: 161463 RVA: 0x009909C8 File Offset: 0x0098EBC8
		// (set) Token: 0x060276B8 RID: 161464 RVA: 0x009909D8 File Offset: 0x0098EBD8
		public unsafe float 固定旋转弹性
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700580C RID: 22540
		// (get) Token: 0x060276B9 RID: 161465 RVA: 0x009909E9 File Offset: 0x0098EBE9
		// (set) Token: 0x060276BA RID: 161466 RVA: 0x009909F9 File Offset: 0x0098EBF9
		public unsafe int 贴图序号
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700580D RID: 22541
		// (get) Token: 0x060276BB RID: 161467 RVA: 0x00990A0A File Offset: 0x0098EC0A
		// (set) Token: 0x060276BC RID: 161468 RVA: 0x00990A1A File Offset: 0x0098EC1A
		public unsafe float 受光照影响值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700580E RID: 22542
		// (get) Token: 0x060276BD RID: 161469 RVA: 0x00990A2B File Offset: 0x0098EC2B
		// (set) Token: 0x060276BE RID: 161470 RVA: 0x00990A3F File Offset: 0x0098EC3F
		public unsafe FLinearColor 颜色和不透明度调整
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700580F RID: 22543
		// (get) Token: 0x060276BF RID: 161471 RVA: 0x00990A54 File Offset: 0x0098EC54
		// (set) Token: 0x060276C0 RID: 161472 RVA: 0x00990A64 File Offset: 0x0098EC64
		public unsafe bool 夜间给单独的调整值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005810 RID: 22544
		// (get) Token: 0x060276C1 RID: 161473 RVA: 0x00990A75 File Offset: 0x0098EC75
		// (set) Token: 0x060276C2 RID: 161474 RVA: 0x00990A89 File Offset: 0x0098EC89
		public unsafe FLinearColor 夜间的颜色和不透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005811 RID: 22545
		// (get) Token: 0x060276C3 RID: 161475 RVA: 0x00990AA0 File Offset: 0x0098ECA0
		// (set) Token: 0x060276C4 RID: 161476 RVA: 0x00990AD9 File Offset: 0x0098ECD9
		public FKuroCurveFloat 日夜混合曲线
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._日夜混合曲线) == null)
				{
					result = (this._日夜混合曲线 = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005812 RID: 22546
		// (get) Token: 0x060276C5 RID: 161477 RVA: 0x00990AFA File Offset: 0x0098ECFA
		// (set) Token: 0x060276C6 RID: 161478 RVA: 0x00990B0E File Offset: 0x0098ED0E
		public unsafe FVector2D 流动速度_Add_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005813 RID: 22547
		// (get) Token: 0x060276C7 RID: 161479 RVA: 0x00990B23 File Offset: 0x0098ED23
		// (set) Token: 0x060276C8 RID: 161480 RVA: 0x00990B33 File Offset: 0x0098ED33
		public unsafe float 深度渐隐距离缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005814 RID: 22548
		// (get) Token: 0x060276C9 RID: 161481 RVA: 0x00990B44 File Offset: 0x0098ED44
		// (set) Token: 0x060276CA RID: 161482 RVA: 0x00990B54 File Offset: 0x0098ED54
		public unsafe float 相机距离渐隐缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SuperFarFog_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x060276CB RID: 161483 RVA: 0x00990B65 File Offset: 0x0098ED65
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SuperFarFog_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060276CC RID: 161484 RVA: 0x00990B79 File Offset: 0x0098ED79
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SuperFarFog_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060276CD RID: 161485 RVA: 0x00990B8E File Offset: 0x0098ED8E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Refresh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SuperFarFog_C.__Refresh_NativeFunctionPtr, null);
		}

		// Token: 0x060276CE RID: 161486 RVA: 0x00990BA2 File Offset: 0x0098EDA2
		protected BP_SuperFarFog_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E6B RID: 81515
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_SuperFarFog.BP_SuperFarFog_C";

		// Token: 0x04013E6C RID: 81516
		private static IntPtr _ClassPtr;

		// Token: 0x04013E6D RID: 81517
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013E6E RID: 81518
		internal static int __PropertyOffset_1;

		// Token: 0x04013E6F RID: 81519
		internal static int __PropertyOffset_2;

		// Token: 0x04013E70 RID: 81520
		internal static int __PropertyOffset_3;

		// Token: 0x04013E71 RID: 81521
		internal static int __PropertyOffset_4;

		// Token: 0x04013E72 RID: 81522
		internal static int __PropertyOffset_5;

		// Token: 0x04013E73 RID: 81523
		internal static int __PropertyOffset_6;

		// Token: 0x04013E74 RID: 81524
		internal static int __PropertyOffset_7;

		// Token: 0x04013E75 RID: 81525
		internal static int __PropertyOffset_8;

		// Token: 0x04013E76 RID: 81526
		[Nullable(2)]
		private FKuroCurveFloat _日夜混合曲线;

		// Token: 0x04013E77 RID: 81527
		internal static int __PropertyOffset_9;

		// Token: 0x04013E78 RID: 81528
		internal static int __PropertyOffset_10;

		// Token: 0x04013E79 RID: 81529
		internal static int __PropertyOffset_11;

		// Token: 0x04013E7A RID: 81530
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013E7B RID: 81531
		private static IntPtr __Refresh_NativeFunctionPtr;
	}
}
