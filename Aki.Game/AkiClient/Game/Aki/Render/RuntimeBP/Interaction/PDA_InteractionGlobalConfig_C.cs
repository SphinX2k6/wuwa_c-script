using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D20 RID: 15648
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/PDA_InteractionGlobalConfig.PDA_InteractionGlobalConfig_C")]
	[UnrealStructLayout(528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 522)]
	public class PDA_InteractionGlobalConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025935 RID: 153909 RVA: 0x0095D797 File Offset: 0x0095B997
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_InteractionGlobalConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/PDA_InteractionGlobalConfig.PDA_InteractionGlobalConfig_C");
			}
			return PDA_InteractionGlobalConfig_C._ClassPtr;
		}

		// Token: 0x06025936 RID: 153910 RVA: 0x0095D7BC File Offset: 0x0095B9BC
		public PDA_InteractionGlobalConfig_C() : this(BuiltinUtils.AllocNativeUObject(PDA_InteractionGlobalConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025937 RID: 153911 RVA: 0x0095D7E4 File Offset: 0x0095B9E4
		public PDA_InteractionGlobalConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_InteractionGlobalConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D60 RID: 19808
		// (get) Token: 0x06025938 RID: 153912 RVA: 0x0095D817 File Offset: 0x0095BA17
		// (set) Token: 0x06025939 RID: 153913 RVA: 0x0095D827 File Offset: 0x0095BA27
		public unsafe bool 屏蔽所有水面交互物体
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D61 RID: 19809
		// (get) Token: 0x0602593A RID: 153914 RVA: 0x0095D838 File Offset: 0x0095BA38
		// (set) Token: 0x0602593B RID: 153915 RVA: 0x0095D871 File Offset: 0x0095BA71
		public FSoftObjectPath 植被恢复材质
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._植被恢复材质) == null)
				{
					result = (this._植被恢复材质 = new FSoftObjectPath(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D62 RID: 19810
		// (get) Token: 0x0602593C RID: 153916 RVA: 0x0095D894 File Offset: 0x0095BA94
		// (set) Token: 0x0602593D RID: 153917 RVA: 0x0095D8CD File Offset: 0x0095BACD
		public FSoftObjectPath 植被交互计算材质
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._植被交互计算材质) == null)
				{
					result = (this._植被交互计算材质 = new FSoftObjectPath(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D63 RID: 19811
		// (get) Token: 0x0602593E RID: 153918 RVA: 0x0095D8F0 File Offset: 0x0095BAF0
		// (set) Token: 0x0602593F RID: 153919 RVA: 0x0095D929 File Offset: 0x0095BB29
		public FSoftObjectPath 植被结果材质
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._植被结果材质) == null)
				{
					result = (this._植被结果材质 = new FSoftObjectPath(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D64 RID: 19812
		// (get) Token: 0x06025940 RID: 153920 RVA: 0x0095D94C File Offset: 0x0095BB4C
		// (set) Token: 0x06025941 RID: 153921 RVA: 0x0095D985 File Offset: 0x0095BB85
		public FSoftObjectPath 水面波纹触发材质
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._水面波纹触发材质) == null)
				{
					result = (this._水面波纹触发材质 = new FSoftObjectPath(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D65 RID: 19813
		// (get) Token: 0x06025942 RID: 153922 RVA: 0x0095D9A8 File Offset: 0x0095BBA8
		// (set) Token: 0x06025943 RID: 153923 RVA: 0x0095D9E1 File Offset: 0x0095BBE1
		public FSoftObjectPath 水面波纹计算材质
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._水面波纹计算材质) == null)
				{
					result = (this._水面波纹计算材质 = new FSoftObjectPath(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D66 RID: 19814
		// (get) Token: 0x06025944 RID: 153924 RVA: 0x0095DA04 File Offset: 0x0095BC04
		// (set) Token: 0x06025945 RID: 153925 RVA: 0x0095DA3D File Offset: 0x0095BC3D
		public FSoftObjectPath 高斯模糊材质
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._高斯模糊材质) == null)
				{
					result = (this._高斯模糊材质 = new FSoftObjectPath(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D67 RID: 19815
		// (get) Token: 0x06025946 RID: 153926 RVA: 0x0095DA60 File Offset: 0x0095BC60
		// (set) Token: 0x06025947 RID: 153927 RVA: 0x0095DA99 File Offset: 0x0095BC99
		public FSoftObjectPath 水面波纹结果材质
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._水面波纹结果材质) == null)
				{
					result = (this._水面波纹结果材质 = new FSoftObjectPath(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D68 RID: 19816
		// (get) Token: 0x06025948 RID: 153928 RVA: 0x0095DABC File Offset: 0x0095BCBC
		// (set) Token: 0x06025949 RID: 153929 RVA: 0x0095DAF5 File Offset: 0x0095BCF5
		public FSoftObjectPath 植被交互纹理
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._植被交互纹理) == null)
				{
					result = (this._植被交互纹理 = new FSoftObjectPath(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D69 RID: 19817
		// (get) Token: 0x0602594A RID: 153930 RVA: 0x0095DB18 File Offset: 0x0095BD18
		// (set) Token: 0x0602594B RID: 153931 RVA: 0x0095DB51 File Offset: 0x0095BD51
		public FSoftObjectPath 植被交互临时纹理
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._植被交互临时纹理) == null)
				{
					result = (this._植被交互临时纹理 = new FSoftObjectPath(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D6A RID: 19818
		// (get) Token: 0x0602594C RID: 153932 RVA: 0x0095DB74 File Offset: 0x0095BD74
		// (set) Token: 0x0602594D RID: 153933 RVA: 0x0095DBAD File Offset: 0x0095BDAD
		public FSoftObjectPath 水面交互纹理
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._水面交互纹理) == null)
				{
					result = (this._水面交互纹理 = new FSoftObjectPath(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D6B RID: 19819
		// (get) Token: 0x0602594E RID: 153934 RVA: 0x0095DBD0 File Offset: 0x0095BDD0
		// (set) Token: 0x0602594F RID: 153935 RVA: 0x0095DC09 File Offset: 0x0095BE09
		public FSoftObjectPath 水面交互临时纹理1
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._水面交互临时纹理1) == null)
				{
					result = (this._水面交互临时纹理1 = new FSoftObjectPath(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_11, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D6C RID: 19820
		// (get) Token: 0x06025950 RID: 153936 RVA: 0x0095DC2C File Offset: 0x0095BE2C
		// (set) Token: 0x06025951 RID: 153937 RVA: 0x0095DC65 File Offset: 0x0095BE65
		public FSoftObjectPath 水面交互临时纹理2
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._水面交互临时纹理2) == null)
				{
					result = (this._水面交互临时纹理2 = new FSoftObjectPath(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_12, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D6D RID: 19821
		// (get) Token: 0x06025952 RID: 153938 RVA: 0x0095DC88 File Offset: 0x0095BE88
		// (set) Token: 0x06025953 RID: 153939 RVA: 0x0095DCC1 File Offset: 0x0095BEC1
		public FSoftObjectPath 水面交互临时纹理3
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._水面交互临时纹理3) == null)
				{
					result = (this._水面交互临时纹理3 = new FSoftObjectPath(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_13, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D6E RID: 19822
		// (get) Token: 0x06025954 RID: 153940 RVA: 0x0095DCE2 File Offset: 0x0095BEE2
		// (set) Token: 0x06025955 RID: 153941 RVA: 0x0095DCF2 File Offset: 0x0095BEF2
		public unsafe bool 屏蔽所有草地交互物体
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D6F RID: 19823
		// (get) Token: 0x06025956 RID: 153942 RVA: 0x0095DD03 File Offset: 0x0095BF03
		// (set) Token: 0x06025957 RID: 153943 RVA: 0x0095DD13 File Offset: 0x0095BF13
		public unsafe bool 停止水模拟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D70 RID: 19824
		// (get) Token: 0x06025958 RID: 153944 RVA: 0x0095DD24 File Offset: 0x0095BF24
		// (set) Token: 0x06025959 RID: 153945 RVA: 0x0095DD34 File Offset: 0x0095BF34
		public unsafe bool 停止草模拟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D71 RID: 19825
		// (get) Token: 0x0602595A RID: 153946 RVA: 0x0095DD45 File Offset: 0x0095BF45
		// (set) Token: 0x0602595B RID: 153947 RVA: 0x0095DD59 File Offset: 0x0095BF59
		[Nullable(2)]
		public unsafe PDA_InteractionGlobalConfigParameters_C 交互参数
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_InteractionGlobalConfigParameters_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_InteractionGlobalConfig_C.__PropertyOffset_17);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_InteractionGlobalConfig_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17004D72 RID: 19826
		// (get) Token: 0x0602595C RID: 153948 RVA: 0x0095DD6E File Offset: 0x0095BF6E
		// (set) Token: 0x0602595D RID: 153949 RVA: 0x0095DD7E File Offset: 0x0095BF7E
		public unsafe bool 强制启用水模拟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D73 RID: 19827
		// (get) Token: 0x0602595E RID: 153950 RVA: 0x0095DD8F File Offset: 0x0095BF8F
		// (set) Token: 0x0602595F RID: 153951 RVA: 0x0095DD9F File Offset: 0x0095BF9F
		public unsafe bool 强制启用草模拟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionGlobalConfig_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x06025960 RID: 153952 RVA: 0x0095DDB0 File Offset: 0x0095BFB0
		protected PDA_InteractionGlobalConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012C27 RID: 76839
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/PDA_InteractionGlobalConfig.PDA_InteractionGlobalConfig_C";

		// Token: 0x04012C28 RID: 76840
		private static IntPtr _ClassPtr;

		// Token: 0x04012C29 RID: 76841
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012C2A RID: 76842
		internal static int __PropertyOffset_0;

		// Token: 0x04012C2B RID: 76843
		internal static int __PropertyOffset_1;

		// Token: 0x04012C2C RID: 76844
		[Nullable(2)]
		private FSoftObjectPath _植被恢复材质;

		// Token: 0x04012C2D RID: 76845
		internal static int __PropertyOffset_2;

		// Token: 0x04012C2E RID: 76846
		[Nullable(2)]
		private FSoftObjectPath _植被交互计算材质;

		// Token: 0x04012C2F RID: 76847
		internal static int __PropertyOffset_3;

		// Token: 0x04012C30 RID: 76848
		[Nullable(2)]
		private FSoftObjectPath _植被结果材质;

		// Token: 0x04012C31 RID: 76849
		internal static int __PropertyOffset_4;

		// Token: 0x04012C32 RID: 76850
		[Nullable(2)]
		private FSoftObjectPath _水面波纹触发材质;

		// Token: 0x04012C33 RID: 76851
		internal static int __PropertyOffset_5;

		// Token: 0x04012C34 RID: 76852
		[Nullable(2)]
		private FSoftObjectPath _水面波纹计算材质;

		// Token: 0x04012C35 RID: 76853
		internal static int __PropertyOffset_6;

		// Token: 0x04012C36 RID: 76854
		[Nullable(2)]
		private FSoftObjectPath _高斯模糊材质;

		// Token: 0x04012C37 RID: 76855
		internal static int __PropertyOffset_7;

		// Token: 0x04012C38 RID: 76856
		[Nullable(2)]
		private FSoftObjectPath _水面波纹结果材质;

		// Token: 0x04012C39 RID: 76857
		internal static int __PropertyOffset_8;

		// Token: 0x04012C3A RID: 76858
		[Nullable(2)]
		private FSoftObjectPath _植被交互纹理;

		// Token: 0x04012C3B RID: 76859
		internal static int __PropertyOffset_9;

		// Token: 0x04012C3C RID: 76860
		[Nullable(2)]
		private FSoftObjectPath _植被交互临时纹理;

		// Token: 0x04012C3D RID: 76861
		internal static int __PropertyOffset_10;

		// Token: 0x04012C3E RID: 76862
		[Nullable(2)]
		private FSoftObjectPath _水面交互纹理;

		// Token: 0x04012C3F RID: 76863
		internal static int __PropertyOffset_11;

		// Token: 0x04012C40 RID: 76864
		[Nullable(2)]
		private FSoftObjectPath _水面交互临时纹理1;

		// Token: 0x04012C41 RID: 76865
		internal static int __PropertyOffset_12;

		// Token: 0x04012C42 RID: 76866
		[Nullable(2)]
		private FSoftObjectPath _水面交互临时纹理2;

		// Token: 0x04012C43 RID: 76867
		internal static int __PropertyOffset_13;

		// Token: 0x04012C44 RID: 76868
		[Nullable(2)]
		private FSoftObjectPath _水面交互临时纹理3;

		// Token: 0x04012C45 RID: 76869
		internal static int __PropertyOffset_14;

		// Token: 0x04012C46 RID: 76870
		internal static int __PropertyOffset_15;

		// Token: 0x04012C47 RID: 76871
		internal static int __PropertyOffset_16;

		// Token: 0x04012C48 RID: 76872
		internal static int __PropertyOffset_17;

		// Token: 0x04012C49 RID: 76873
		internal static int __PropertyOffset_18;

		// Token: 0x04012C4A RID: 76874
		internal static int __PropertyOffset_19;
	}
}
