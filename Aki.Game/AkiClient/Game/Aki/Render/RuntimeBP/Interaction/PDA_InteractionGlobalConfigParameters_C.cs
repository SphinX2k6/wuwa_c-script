using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D1F RID: 15647
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/PDA_InteractionGlobalConfigParameters.PDA_InteractionGlobalConfigParameters_C")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 124)]
	public class PDA_InteractionGlobalConfigParameters_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602591B RID: 153883 RVA: 0x0095D5A1 File Offset: 0x0095B7A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_InteractionGlobalConfigParameters_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/PDA_InteractionGlobalConfigParameters.PDA_InteractionGlobalConfigParameters_C");
			}
			return PDA_InteractionGlobalConfigParameters_C._ClassPtr;
		}

		// Token: 0x0602591C RID: 153884 RVA: 0x0095D5C8 File Offset: 0x0095B7C8
		public PDA_InteractionGlobalConfigParameters_C() : this(BuiltinUtils.AllocNativeUObject(PDA_InteractionGlobalConfigParameters_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602591D RID: 153885 RVA: 0x0095D5F0 File Offset: 0x0095B7F0
		[NullableContext(1)]
		public PDA_InteractionGlobalConfigParameters_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_InteractionGlobalConfigParameters_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D55 RID: 19797
		// (get) Token: 0x0602591E RID: 153886 RVA: 0x0095D623 File Offset: 0x0095B823
		// (set) Token: 0x0602591F RID: 153887 RVA: 0x0095D633 File Offset: 0x0095B833
		public unsafe bool 启用植被交互
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D56 RID: 19798
		// (get) Token: 0x06025920 RID: 153888 RVA: 0x0095D644 File Offset: 0x0095B844
		// (set) Token: 0x06025921 RID: 153889 RVA: 0x0095D654 File Offset: 0x0095B854
		public unsafe float 植被交互范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17004D57 RID: 19799
		// (get) Token: 0x06025922 RID: 153890 RVA: 0x0095D665 File Offset: 0x0095B865
		// (set) Token: 0x06025923 RID: 153891 RVA: 0x0095D675 File Offset: 0x0095B875
		public unsafe bool 启用水面交互
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D58 RID: 19800
		// (get) Token: 0x06025924 RID: 153892 RVA: 0x0095D686 File Offset: 0x0095B886
		// (set) Token: 0x06025925 RID: 153893 RVA: 0x0095D696 File Offset: 0x0095B896
		public unsafe float 水面交互范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004D59 RID: 19801
		// (get) Token: 0x06025926 RID: 153894 RVA: 0x0095D6A7 File Offset: 0x0095B8A7
		// (set) Token: 0x06025927 RID: 153895 RVA: 0x0095D6B7 File Offset: 0x0095B8B7
		public unsafe float 水面交互更新频率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004D5A RID: 19802
		// (get) Token: 0x06025928 RID: 153896 RVA: 0x0095D6C8 File Offset: 0x0095B8C8
		// (set) Token: 0x06025929 RID: 153897 RVA: 0x0095D6D8 File Offset: 0x0095B8D8
		public unsafe float 水波纹停止更新时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004D5B RID: 19803
		// (get) Token: 0x0602592A RID: 153898 RVA: 0x0095D6E9 File Offset: 0x0095B8E9
		// (set) Token: 0x0602592B RID: 153899 RVA: 0x0095D6F9 File Offset: 0x0095B8F9
		public unsafe float 植被恢复速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004D5C RID: 19804
		// (get) Token: 0x0602592C RID: 153900 RVA: 0x0095D70A File Offset: 0x0095B90A
		// (set) Token: 0x0602592D RID: 153901 RVA: 0x0095D71A File Offset: 0x0095B91A
		public unsafe float 水波纹扩散速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004D5D RID: 19805
		// (get) Token: 0x0602592E RID: 153902 RVA: 0x0095D72B File Offset: 0x0095B92B
		// (set) Token: 0x0602592F RID: 153903 RVA: 0x0095D73B File Offset: 0x0095B93B
		public unsafe float 水波纹消退速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004D5E RID: 19806
		// (get) Token: 0x06025930 RID: 153904 RVA: 0x0095D74C File Offset: 0x0095B94C
		// (set) Token: 0x06025931 RID: 153905 RVA: 0x0095D75C File Offset: 0x0095B95C
		public unsafe float 水粘度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004D5F RID: 19807
		// (get) Token: 0x06025932 RID: 153906 RVA: 0x0095D76D File Offset: 0x0095B96D
		// (set) Token: 0x06025933 RID: 153907 RVA: 0x0095D77D File Offset: 0x0095B97D
		public unsafe float 水波纹强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfigParameters_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x06025934 RID: 153908 RVA: 0x0095D78E File Offset: 0x0095B98E
		protected PDA_InteractionGlobalConfigParameters_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012C19 RID: 76825
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/PDA_InteractionGlobalConfigParameters.PDA_InteractionGlobalConfigParameters_C";

		// Token: 0x04012C1A RID: 76826
		private static IntPtr _ClassPtr;

		// Token: 0x04012C1B RID: 76827
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012C1C RID: 76828
		internal static int __PropertyOffset_0;

		// Token: 0x04012C1D RID: 76829
		internal static int __PropertyOffset_1;

		// Token: 0x04012C1E RID: 76830
		internal static int __PropertyOffset_2;

		// Token: 0x04012C1F RID: 76831
		internal static int __PropertyOffset_3;

		// Token: 0x04012C20 RID: 76832
		internal static int __PropertyOffset_4;

		// Token: 0x04012C21 RID: 76833
		internal static int __PropertyOffset_5;

		// Token: 0x04012C22 RID: 76834
		internal static int __PropertyOffset_6;

		// Token: 0x04012C23 RID: 76835
		internal static int __PropertyOffset_7;

		// Token: 0x04012C24 RID: 76836
		internal static int __PropertyOffset_8;

		// Token: 0x04012C25 RID: 76837
		internal static int __PropertyOffset_9;

		// Token: 0x04012C26 RID: 76838
		internal static int __PropertyOffset_10;
	}
}
