using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene
{
	// Token: 0x02003DCE RID: 15822
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Scene/PDA_RandomLightening.PDA_RandomLightening_C")]
	[UnrealStructLayout(560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 560)]
	public class PDA_RandomLightening_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060276CF RID: 161487 RVA: 0x00990BAB File Offset: 0x0098EDAB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_RandomLightening_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Scene/PDA_RandomLightening.PDA_RandomLightening_C");
			}
			return PDA_RandomLightening_C._ClassPtr;
		}

		// Token: 0x060276D0 RID: 161488 RVA: 0x00990BD0 File Offset: 0x0098EDD0
		public PDA_RandomLightening_C() : this(BuiltinUtils.AllocNativeUObject(PDA_RandomLightening_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060276D1 RID: 161489 RVA: 0x00990BF8 File Offset: 0x0098EDF8
		[NullableContext(1)]
		public PDA_RandomLightening_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_RandomLightening_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005815 RID: 22549
		// (get) Token: 0x060276D2 RID: 161490 RVA: 0x00990C2B File Offset: 0x0098EE2B
		// (set) Token: 0x060276D3 RID: 161491 RVA: 0x00990C3B File Offset: 0x0098EE3B
		public unsafe float 发生频率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RandomLightening_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RandomLightening_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005816 RID: 22550
		// (get) Token: 0x060276D4 RID: 161492 RVA: 0x00990C4C File Offset: 0x0098EE4C
		// (set) Token: 0x060276D5 RID: 161493 RVA: 0x00990C5C File Offset: 0x0098EE5C
		public unsafe float 发生频率随机
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RandomLightening_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RandomLightening_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005817 RID: 22551
		// (get) Token: 0x060276D6 RID: 161494 RVA: 0x00990C70 File Offset: 0x0098EE70
		// (set) Token: 0x060276D7 RID: 161495 RVA: 0x00990CA9 File Offset: 0x0098EEA9
		[Nullable(1)]
		public FKuroCurveFloat 灯光强度曲线
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._灯光强度曲线) == null)
				{
					result = (this._灯光强度曲线 = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_RandomLightening_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_RandomLightening_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005818 RID: 22552
		// (get) Token: 0x060276D8 RID: 161496 RVA: 0x00990CCC File Offset: 0x0098EECC
		// (set) Token: 0x060276D9 RID: 161497 RVA: 0x00990D05 File Offset: 0x0098EF05
		[Nullable(1)]
		public FKuroCurveFloat 灯光距离强度曲线
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._灯光距离强度曲线) == null)
				{
					result = (this._灯光距离强度曲线 = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_RandomLightening_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_RandomLightening_C.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005819 RID: 22553
		// (get) Token: 0x060276DA RID: 161498 RVA: 0x00990D28 File Offset: 0x0098EF28
		// (set) Token: 0x060276DB RID: 161499 RVA: 0x00990D61 File Offset: 0x0098EF61
		[Nullable(1)]
		public FKuroCurveFloat 后处理强度曲线
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._后处理强度曲线) == null)
				{
					result = (this._后处理强度曲线 = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_RandomLightening_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_RandomLightening_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700581A RID: 22554
		// (get) Token: 0x060276DC RID: 161500 RVA: 0x00990D82 File Offset: 0x0098EF82
		// (set) Token: 0x060276DD RID: 161501 RVA: 0x00990D96 File Offset: 0x0098EF96
		public unsafe UNiagaraSystem NiagaraSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RandomLightening_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RandomLightening_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700581B RID: 22555
		// (get) Token: 0x060276DE RID: 161502 RVA: 0x00990DAB File Offset: 0x0098EFAB
		// (set) Token: 0x060276DF RID: 161503 RVA: 0x00990DBF File Offset: 0x0098EFBF
		public unsafe UAkAudioEvent 音频事件
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RandomLightening_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RandomLightening_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700581C RID: 22556
		// (get) Token: 0x060276E0 RID: 161504 RVA: 0x00990DD4 File Offset: 0x0098EFD4
		// (set) Token: 0x060276E1 RID: 161505 RVA: 0x00990DE8 File Offset: 0x0098EFE8
		public unsafe FName MPC参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_RandomLightening_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_RandomLightening_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700581D RID: 22557
		// (get) Token: 0x060276E2 RID: 161506 RVA: 0x00990DFD File Offset: 0x0098EFFD
		// (set) Token: 0x060276E3 RID: 161507 RVA: 0x00990E11 File Offset: 0x0098F011
		public unsafe UMaterialParameterCollection MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RandomLightening_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_RandomLightening_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x060276E4 RID: 161508 RVA: 0x00990E26 File Offset: 0x0098F026
		protected PDA_RandomLightening_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E80 RID: 81536
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Scene/PDA_RandomLightening.PDA_RandomLightening_C";

		// Token: 0x04013E81 RID: 81537
		private static IntPtr _ClassPtr;

		// Token: 0x04013E82 RID: 81538
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013E83 RID: 81539
		internal static int __PropertyOffset_0;

		// Token: 0x04013E84 RID: 81540
		internal static int __PropertyOffset_1;

		// Token: 0x04013E85 RID: 81541
		internal static int __PropertyOffset_2;

		// Token: 0x04013E86 RID: 81542
		private FKuroCurveFloat _灯光强度曲线;

		// Token: 0x04013E87 RID: 81543
		internal static int __PropertyOffset_3;

		// Token: 0x04013E88 RID: 81544
		private FKuroCurveFloat _灯光距离强度曲线;

		// Token: 0x04013E89 RID: 81545
		internal static int __PropertyOffset_4;

		// Token: 0x04013E8A RID: 81546
		private FKuroCurveFloat _后处理强度曲线;

		// Token: 0x04013E8B RID: 81547
		internal static int __PropertyOffset_5;

		// Token: 0x04013E8C RID: 81548
		internal static int __PropertyOffset_6;

		// Token: 0x04013E8D RID: 81549
		internal static int __PropertyOffset_7;

		// Token: 0x04013E8E RID: 81550
		internal static int __PropertyOffset_8;
	}
}
