using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.ItemInspect
{
	// Token: 0x02003F10 RID: 16144
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/ItemInspect/BP_ItemInspectGlobalConfig.BP_ItemInspectGlobalConfig_C")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class BP_ItemInspectGlobalConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028FCE RID: 167886 RVA: 0x009B9008 File Offset: 0x009B7208
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ItemInspectGlobalConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/ItemInspect/BP_ItemInspectGlobalConfig.BP_ItemInspectGlobalConfig_C");
			}
			return BP_ItemInspectGlobalConfig_C._ClassPtr;
		}

		// Token: 0x06028FCF RID: 167887 RVA: 0x009B902C File Offset: 0x009B722C
		public BP_ItemInspectGlobalConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_ItemInspectGlobalConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028FD0 RID: 167888 RVA: 0x009B9054 File Offset: 0x009B7254
		public BP_ItemInspectGlobalConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ItemInspectGlobalConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170060D2 RID: 24786
		// (get) Token: 0x06028FD1 RID: 167889 RVA: 0x009B9087 File Offset: 0x009B7287
		// (set) Token: 0x06028FD2 RID: 167890 RVA: 0x009B9097 File Offset: 0x009B7297
		public unsafe float 输入速度限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170060D3 RID: 24787
		// (get) Token: 0x06028FD3 RID: 167891 RVA: 0x009B90A8 File Offset: 0x009B72A8
		// (set) Token: 0x06028FD4 RID: 167892 RVA: 0x009B90B8 File Offset: 0x009B72B8
		public unsafe float 平滑插值旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170060D4 RID: 24788
		// (get) Token: 0x06028FD5 RID: 167893 RVA: 0x009B90C9 File Offset: 0x009B72C9
		// (set) Token: 0x06028FD6 RID: 167894 RVA: 0x009B90D9 File Offset: 0x009B72D9
		public unsafe float 重置旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170060D5 RID: 24789
		// (get) Token: 0x06028FD7 RID: 167895 RVA: 0x009B90EA File Offset: 0x009B72EA
		// (set) Token: 0x06028FD8 RID: 167896 RVA: 0x009B90FF File Offset: 0x009B72FF
		public TSoftObjectPtr<UStaticMesh> 压暗网格体
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_3, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_3, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170060D6 RID: 24790
		// (get) Token: 0x06028FD9 RID: 167897 RVA: 0x009B9124 File Offset: 0x009B7324
		// (set) Token: 0x06028FDA RID: 167898 RVA: 0x009B9139 File Offset: 0x009B7339
		public TSoftObjectPtr<UMaterialInstance> 压暗材质
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_4, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_4, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170060D7 RID: 24791
		// (get) Token: 0x06028FDB RID: 167899 RVA: 0x009B915E File Offset: 0x009B735E
		// (set) Token: 0x06028FDC RID: 167900 RVA: 0x009B916E File Offset: 0x009B736E
		public unsafe float 压暗不透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170060D8 RID: 24792
		// (get) Token: 0x06028FDD RID: 167901 RVA: 0x009B917F File Offset: 0x009B737F
		// (set) Token: 0x06028FDE RID: 167902 RVA: 0x009B918F File Offset: 0x009B738F
		public unsafe float 压暗过渡时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170060D9 RID: 24793
		// (get) Token: 0x06028FDF RID: 167903 RVA: 0x009B91A0 File Offset: 0x009B73A0
		// (set) Token: 0x06028FE0 RID: 167904 RVA: 0x009B91B0 File Offset: 0x009B73B0
		public unsafe float 压暗过渡间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170060DA RID: 24794
		// (get) Token: 0x06028FE1 RID: 167905 RVA: 0x009B91C1 File Offset: 0x009B73C1
		// (set) Token: 0x06028FE2 RID: 167906 RVA: 0x009B91D1 File Offset: 0x009B73D1
		public unsafe float 压暗屏幕深度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x06028FE3 RID: 167907 RVA: 0x009B91E2 File Offset: 0x009B73E2
		protected BP_ItemInspectGlobalConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014F78 RID: 85880
		public new const string __ObjectPath = "/Game/Aki/Data/Level/ItemInspect/BP_ItemInspectGlobalConfig.BP_ItemInspectGlobalConfig_C";

		// Token: 0x04014F79 RID: 85881
		private static IntPtr _ClassPtr;

		// Token: 0x04014F7A RID: 85882
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014F7B RID: 85883
		internal static int __PropertyOffset_0;

		// Token: 0x04014F7C RID: 85884
		internal static int __PropertyOffset_1;

		// Token: 0x04014F7D RID: 85885
		internal static int __PropertyOffset_2;

		// Token: 0x04014F7E RID: 85886
		internal static int __PropertyOffset_3;

		// Token: 0x04014F7F RID: 85887
		internal static int __PropertyOffset_4;

		// Token: 0x04014F80 RID: 85888
		internal static int __PropertyOffset_5;

		// Token: 0x04014F81 RID: 85889
		internal static int __PropertyOffset_6;

		// Token: 0x04014F82 RID: 85890
		internal static int __PropertyOffset_7;

		// Token: 0x04014F83 RID: 85891
		internal static int __PropertyOffset_8;
	}
}
