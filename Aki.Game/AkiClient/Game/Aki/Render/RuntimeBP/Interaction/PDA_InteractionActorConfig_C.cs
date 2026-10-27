using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D1E RID: 15646
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/PDA_InteractionActorConfig.PDA_InteractionActorConfig_C")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class PDA_InteractionActorConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025901 RID: 153857 RVA: 0x0095D374 File Offset: 0x0095B574
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_InteractionActorConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/PDA_InteractionActorConfig.PDA_InteractionActorConfig_C");
			}
			return PDA_InteractionActorConfig_C._ClassPtr;
		}

		// Token: 0x06025902 RID: 153858 RVA: 0x0095D398 File Offset: 0x0095B598
		public PDA_InteractionActorConfig_C() : this(BuiltinUtils.AllocNativeUObject(PDA_InteractionActorConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025903 RID: 153859 RVA: 0x0095D3C0 File Offset: 0x0095B5C0
		public PDA_InteractionActorConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_InteractionActorConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D4A RID: 19786
		// (get) Token: 0x06025904 RID: 153860 RVA: 0x0095D3F3 File Offset: 0x0095B5F3
		// (set) Token: 0x06025905 RID: 153861 RVA: 0x0095D403 File Offset: 0x0095B603
		public unsafe bool 启用水面交互
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D4B RID: 19787
		// (get) Token: 0x06025906 RID: 153862 RVA: 0x0095D414 File Offset: 0x0095B614
		// (set) Token: 0x06025907 RID: 153863 RVA: 0x0095D424 File Offset: 0x0095B624
		public unsafe float 水面交互半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17004D4C RID: 19788
		// (get) Token: 0x06025908 RID: 153864 RVA: 0x0095D435 File Offset: 0x0095B635
		// (set) Token: 0x06025909 RID: 153865 RVA: 0x0095D445 File Offset: 0x0095B645
		public unsafe float 水面交互过渡值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17004D4D RID: 19789
		// (get) Token: 0x0602590A RID: 153866 RVA: 0x0095D456 File Offset: 0x0095B656
		// (set) Token: 0x0602590B RID: 153867 RVA: 0x0095D466 File Offset: 0x0095B666
		public unsafe float 水面交互时间间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004D4E RID: 19790
		// (get) Token: 0x0602590C RID: 153868 RVA: 0x0095D477 File Offset: 0x0095B677
		// (set) Token: 0x0602590D RID: 153869 RVA: 0x0095D487 File Offset: 0x0095B687
		public unsafe float 时间间隔随机
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004D4F RID: 19791
		// (get) Token: 0x0602590E RID: 153870 RVA: 0x0095D498 File Offset: 0x0095B698
		// (set) Token: 0x0602590F RID: 153871 RVA: 0x0095D4A8 File Offset: 0x0095B6A8
		public unsafe float 水面交互站立强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004D50 RID: 19792
		// (get) Token: 0x06025910 RID: 153872 RVA: 0x0095D4B9 File Offset: 0x0095B6B9
		// (set) Token: 0x06025911 RID: 153873 RVA: 0x0095D4C9 File Offset: 0x0095B6C9
		public unsafe float 水面交互移动强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004D51 RID: 19793
		// (get) Token: 0x06025912 RID: 153874 RVA: 0x0095D4DA File Offset: 0x0095B6DA
		// (set) Token: 0x06025913 RID: 153875 RVA: 0x0095D4EA File Offset: 0x0095B6EA
		public unsafe float 水面交互最大移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004D52 RID: 19794
		// (get) Token: 0x06025914 RID: 153876 RVA: 0x0095D4FC File Offset: 0x0095B6FC
		// (set) Token: 0x06025915 RID: 153877 RVA: 0x0095D535 File Offset: 0x0095B735
		public FKuroCurveFloat 交互速度_强度曲线
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._交互速度_强度曲线) == null)
				{
					result = (this._交互速度_强度曲线 = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D53 RID: 19795
		// (get) Token: 0x06025916 RID: 153878 RVA: 0x0095D556 File Offset: 0x0095B756
		// (set) Token: 0x06025917 RID: 153879 RVA: 0x0095D566 File Offset: 0x0095B766
		public unsafe float 交互强度抖动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004D54 RID: 19796
		// (get) Token: 0x06025918 RID: 153880 RVA: 0x0095D577 File Offset: 0x0095B777
		// (set) Token: 0x06025919 RID: 153881 RVA: 0x0095D587 File Offset: 0x0095B787
		public unsafe float 交互位置抖动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionActorConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x0602591A RID: 153882 RVA: 0x0095D598 File Offset: 0x0095B798
		protected PDA_InteractionActorConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012C0A RID: 76810
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/PDA_InteractionActorConfig.PDA_InteractionActorConfig_C";

		// Token: 0x04012C0B RID: 76811
		private static IntPtr _ClassPtr;

		// Token: 0x04012C0C RID: 76812
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012C0D RID: 76813
		internal static int __PropertyOffset_0;

		// Token: 0x04012C0E RID: 76814
		internal static int __PropertyOffset_1;

		// Token: 0x04012C0F RID: 76815
		internal static int __PropertyOffset_2;

		// Token: 0x04012C10 RID: 76816
		internal static int __PropertyOffset_3;

		// Token: 0x04012C11 RID: 76817
		internal static int __PropertyOffset_4;

		// Token: 0x04012C12 RID: 76818
		internal static int __PropertyOffset_5;

		// Token: 0x04012C13 RID: 76819
		internal static int __PropertyOffset_6;

		// Token: 0x04012C14 RID: 76820
		internal static int __PropertyOffset_7;

		// Token: 0x04012C15 RID: 76821
		internal static int __PropertyOffset_8;

		// Token: 0x04012C16 RID: 76822
		[Nullable(2)]
		private FKuroCurveFloat _交互速度_强度曲线;

		// Token: 0x04012C17 RID: 76823
		internal static int __PropertyOffset_9;

		// Token: 0x04012C18 RID: 76824
		internal static int __PropertyOffset_10;
	}
}
