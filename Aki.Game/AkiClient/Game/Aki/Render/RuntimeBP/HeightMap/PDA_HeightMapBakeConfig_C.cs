using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.HeightMap
{
	// Token: 0x02003D26 RID: 15654
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/HeightMap/PDA_HeightMapBakeConfig.PDA_HeightMapBakeConfig_C")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class PDA_HeightMapBakeConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025A5E RID: 154206 RVA: 0x0095F5F7 File Offset: 0x0095D7F7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_HeightMapBakeConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/HeightMap/PDA_HeightMapBakeConfig.PDA_HeightMapBakeConfig_C");
			}
			return PDA_HeightMapBakeConfig_C._ClassPtr;
		}

		// Token: 0x06025A5F RID: 154207 RVA: 0x0095F61C File Offset: 0x0095D81C
		public PDA_HeightMapBakeConfig_C() : this(BuiltinUtils.AllocNativeUObject(PDA_HeightMapBakeConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025A60 RID: 154208 RVA: 0x0095F644 File Offset: 0x0095D844
		public PDA_HeightMapBakeConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_HeightMapBakeConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DD9 RID: 19929
		// (get) Token: 0x06025A61 RID: 154209 RVA: 0x0095F677 File Offset: 0x0095D877
		// (set) Token: 0x06025A62 RID: 154210 RVA: 0x0095F68B File Offset: 0x0095D88B
		public unsafe string Path
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)PDA_HeightMapBakeConfig_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)PDA_HeightMapBakeConfig_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17004DDA RID: 19930
		// (get) Token: 0x06025A63 RID: 154211 RVA: 0x0095F6A0 File Offset: 0x0095D8A0
		// (set) Token: 0x06025A64 RID: 154212 RVA: 0x0095F6B0 File Offset: 0x0095D8B0
		public unsafe float CellLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_HeightMapBakeConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_HeightMapBakeConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17004DDB RID: 19931
		// (get) Token: 0x06025A65 RID: 154213 RVA: 0x0095F6C1 File Offset: 0x0095D8C1
		// (set) Token: 0x06025A66 RID: 154214 RVA: 0x0095F6D1 File Offset: 0x0095D8D1
		public unsafe float ShotHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_HeightMapBakeConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_HeightMapBakeConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17004DDC RID: 19932
		// (get) Token: 0x06025A67 RID: 154215 RVA: 0x0095F6E2 File Offset: 0x0095D8E2
		// (set) Token: 0x06025A68 RID: 154216 RVA: 0x0095F6F2 File Offset: 0x0095D8F2
		public unsafe int HalfSideCellNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_HeightMapBakeConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_HeightMapBakeConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004DDD RID: 19933
		// (get) Token: 0x06025A69 RID: 154217 RVA: 0x0095F703 File Offset: 0x0095D903
		// (set) Token: 0x06025A6A RID: 154218 RVA: 0x0095F713 File Offset: 0x0095D913
		public unsafe float TextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_HeightMapBakeConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_HeightMapBakeConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004DDE RID: 19934
		// (get) Token: 0x06025A6B RID: 154219 RVA: 0x0095F724 File Offset: 0x0095D924
		// (set) Token: 0x06025A6C RID: 154220 RVA: 0x0095F738 File Offset: 0x0095D938
		[Nullable(2)]
		public unsafe UKuroHeightMapSettings HeightMapSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroHeightMapSettings>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_HeightMapBakeConfig_C.__PropertyOffset_5);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_HeightMapBakeConfig_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x06025A6D RID: 154221 RVA: 0x0095F74D File Offset: 0x0095D94D
		protected PDA_HeightMapBakeConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012CD7 RID: 77015
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/HeightMap/PDA_HeightMapBakeConfig.PDA_HeightMapBakeConfig_C";

		// Token: 0x04012CD8 RID: 77016
		private static IntPtr _ClassPtr;

		// Token: 0x04012CD9 RID: 77017
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012CDA RID: 77018
		internal static int __PropertyOffset_0;

		// Token: 0x04012CDB RID: 77019
		internal static int __PropertyOffset_1;

		// Token: 0x04012CDC RID: 77020
		internal static int __PropertyOffset_2;

		// Token: 0x04012CDD RID: 77021
		internal static int __PropertyOffset_3;

		// Token: 0x04012CDE RID: 77022
		internal static int __PropertyOffset_4;

		// Token: 0x04012CDF RID: 77023
		internal static int __PropertyOffset_5;
	}
}
