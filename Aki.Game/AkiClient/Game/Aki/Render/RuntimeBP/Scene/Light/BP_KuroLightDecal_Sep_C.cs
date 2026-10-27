using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B0D RID: 15117
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroLightDecal_Sep.BP_KuroLightDecal_Sep_C")]
	[UnrealStructLayout(1408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1408)]
	public class BP_KuroLightDecal_Sep_C : ADecalActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020F36 RID: 134966 RVA: 0x008E10E0 File Offset: 0x008DF2E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroLightDecal_Sep_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroLightDecal_Sep.BP_KuroLightDecal_Sep_C");
			}
			return BP_KuroLightDecal_Sep_C._ClassPtr;
		}

		// Token: 0x06020F37 RID: 134967 RVA: 0x008E1104 File Offset: 0x008DF304
		public BP_KuroLightDecal_Sep_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroLightDecal_Sep_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020F38 RID: 134968 RVA: 0x008E112C File Offset: 0x008DF32C
		public BP_KuroLightDecal_Sep_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroLightDecal_Sep_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x06020F39 RID: 134969 RVA: 0x008E115F File Offset: 0x008DF35F
		// (set) Token: 0x06020F3A RID: 134970 RVA: 0x008E116F File Offset: 0x008DF36F
		public unsafe float FadeScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x06020F3B RID: 134971 RVA: 0x008E1180 File Offset: 0x008DF380
		// (set) Token: 0x06020F3C RID: 134972 RVA: 0x008E1194 File Offset: 0x008DF394
		[Nullable(2)]
		public unsafe UMaterialInstanceConstant DecalMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_Sep_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_Sep_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x06020F3D RID: 134973 RVA: 0x008E11AC File Offset: 0x008DF3AC
		// (set) Token: 0x06020F3E RID: 134974 RVA: 0x008E11E5 File Offset: 0x008DF3E5
		public TMap<FName, float> Scalars
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalars) == null)
				{
					result = (this._Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.Scalars.CopyAssign(value);
			}
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x06020F3F RID: 134975 RVA: 0x008E11F4 File Offset: 0x008DF3F4
		// (set) Token: 0x06020F40 RID: 134976 RVA: 0x008E122D File Offset: 0x008DF42D
		public TMap<FName, UTexture> Textures
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Textures) == null)
				{
					result = (this._Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.Textures.CopyAssign(value);
			}
		}

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x06020F41 RID: 134977 RVA: 0x008E123C File Offset: 0x008DF43C
		// (set) Token: 0x06020F42 RID: 134978 RVA: 0x008E1275 File Offset: 0x008DF475
		public TMap<FName, FLinearColor> Vectors
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vectors) == null)
				{
					result = (this._Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.Vectors.CopyAssign(value);
			}
		}

		// Token: 0x1700337F RID: 13183
		// (get) Token: 0x06020F43 RID: 134979 RVA: 0x008E1283 File Offset: 0x008DF483
		// (set) Token: 0x06020F44 RID: 134980 RVA: 0x008E1293 File Offset: 0x008DF493
		public unsafe float MainTili
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x06020F45 RID: 134981 RVA: 0x008E12A4 File Offset: 0x008DF4A4
		// (set) Token: 0x06020F46 RID: 134982 RVA: 0x008E12B4 File Offset: 0x008DF4B4
		public unsafe float Contrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x06020F47 RID: 134983 RVA: 0x008E12C5 File Offset: 0x008DF4C5
		// (set) Token: 0x06020F48 RID: 134984 RVA: 0x008E12D5 File Offset: 0x008DF4D5
		public unsafe float EmissiveIntensty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x06020F49 RID: 134985 RVA: 0x008E12E6 File Offset: 0x008DF4E6
		// (set) Token: 0x06020F4A RID: 134986 RVA: 0x008E12F6 File Offset: 0x008DF4F6
		public unsafe float MainSpeed_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x06020F4B RID: 134987 RVA: 0x008E1307 File Offset: 0x008DF507
		// (set) Token: 0x06020F4C RID: 134988 RVA: 0x008E1317 File Offset: 0x008DF517
		public unsafe float MainSpeed_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x06020F4D RID: 134989 RVA: 0x008E1328 File Offset: 0x008DF528
		// (set) Token: 0x06020F4E RID: 134990 RVA: 0x008E1338 File Offset: 0x008DF538
		public unsafe float NoiseScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x06020F4F RID: 134991 RVA: 0x008E1349 File Offset: 0x008DF549
		// (set) Token: 0x06020F50 RID: 134992 RVA: 0x008E1359 File Offset: 0x008DF559
		public unsafe float NoiseIntensty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003386 RID: 13190
		// (get) Token: 0x06020F51 RID: 134993 RVA: 0x008E136A File Offset: 0x008DF56A
		// (set) Token: 0x06020F52 RID: 134994 RVA: 0x008E137A File Offset: 0x008DF57A
		public unsafe float NoiseAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003387 RID: 13191
		// (get) Token: 0x06020F53 RID: 134995 RVA: 0x008E138B File Offset: 0x008DF58B
		// (set) Token: 0x06020F54 RID: 134996 RVA: 0x008E139B File Offset: 0x008DF59B
		public unsafe float NoiseSpeed_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003388 RID: 13192
		// (get) Token: 0x06020F55 RID: 134997 RVA: 0x008E13AC File Offset: 0x008DF5AC
		// (set) Token: 0x06020F56 RID: 134998 RVA: 0x008E13BC File Offset: 0x008DF5BC
		public unsafe float NoiseSpeed_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003389 RID: 13193
		// (get) Token: 0x06020F57 RID: 134999 RVA: 0x008E13CD File Offset: 0x008DF5CD
		// (set) Token: 0x06020F58 RID: 135000 RVA: 0x008E13DD File Offset: 0x008DF5DD
		public unsafe float NoisePanX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x06020F59 RID: 135001 RVA: 0x008E13EE File Offset: 0x008DF5EE
		// (set) Token: 0x06020F5A RID: 135002 RVA: 0x008E13FE File Offset: 0x008DF5FE
		public unsafe float NoisePanY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x06020F5B RID: 135003 RVA: 0x008E140F File Offset: 0x008DF60F
		// (set) Token: 0x06020F5C RID: 135004 RVA: 0x008E1423 File Offset: 0x008DF623
		[Nullable(2)]
		public unsafe UTexture Noise
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_Sep_C.__PropertyOffset_17);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_Sep_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x1700338C RID: 13196
		// (get) Token: 0x06020F5D RID: 135005 RVA: 0x008E1438 File Offset: 0x008DF638
		// (set) Token: 0x06020F5E RID: 135006 RVA: 0x008E144C File Offset: 0x008DF64C
		[Nullable(2)]
		public unsafe UTexture MainTex
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_Sep_C.__PropertyOffset_18);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_Sep_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x06020F5F RID: 135007 RVA: 0x008E1461 File Offset: 0x008DF661
		// (set) Token: 0x06020F60 RID: 135008 RVA: 0x008E1475 File Offset: 0x008DF675
		public unsafe FLinearColor ColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_Sep_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x06020F61 RID: 135009 RVA: 0x008E148A File Offset: 0x008DF68A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void updateMaterialParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroLightDecal_Sep_C.__updateMaterialParameters_NativeFunctionPtr, null);
		}

		// Token: 0x06020F62 RID: 135010 RVA: 0x008E149E File Offset: 0x008DF69E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroLightDecal_Sep_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020F63 RID: 135011 RVA: 0x008E14B2 File Offset: 0x008DF6B2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroLightDecal_Sep_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020F64 RID: 135012 RVA: 0x008E14C7 File Offset: 0x008DF6C7
		protected BP_KuroLightDecal_Sep_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401004C RID: 65612
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroLightDecal_Sep.BP_KuroLightDecal_Sep_C";

		// Token: 0x0401004D RID: 65613
		private static IntPtr _ClassPtr;

		// Token: 0x0401004E RID: 65614
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401004F RID: 65615
		internal static int __PropertyOffset_0;

		// Token: 0x04010050 RID: 65616
		internal static int __PropertyOffset_1;

		// Token: 0x04010051 RID: 65617
		internal static int __PropertyOffset_2;

		// Token: 0x04010052 RID: 65618
		[Nullable(2)]
		private TMap<FName, float> _Scalars;

		// Token: 0x04010053 RID: 65619
		internal static int __PropertyOffset_3;

		// Token: 0x04010054 RID: 65620
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Textures;

		// Token: 0x04010055 RID: 65621
		internal static int __PropertyOffset_4;

		// Token: 0x04010056 RID: 65622
		[Nullable(2)]
		private TMap<FName, FLinearColor> _Vectors;

		// Token: 0x04010057 RID: 65623
		internal static int __PropertyOffset_5;

		// Token: 0x04010058 RID: 65624
		internal static int __PropertyOffset_6;

		// Token: 0x04010059 RID: 65625
		internal static int __PropertyOffset_7;

		// Token: 0x0401005A RID: 65626
		internal static int __PropertyOffset_8;

		// Token: 0x0401005B RID: 65627
		internal static int __PropertyOffset_9;

		// Token: 0x0401005C RID: 65628
		internal static int __PropertyOffset_10;

		// Token: 0x0401005D RID: 65629
		internal static int __PropertyOffset_11;

		// Token: 0x0401005E RID: 65630
		internal static int __PropertyOffset_12;

		// Token: 0x0401005F RID: 65631
		internal static int __PropertyOffset_13;

		// Token: 0x04010060 RID: 65632
		internal static int __PropertyOffset_14;

		// Token: 0x04010061 RID: 65633
		internal static int __PropertyOffset_15;

		// Token: 0x04010062 RID: 65634
		internal static int __PropertyOffset_16;

		// Token: 0x04010063 RID: 65635
		internal static int __PropertyOffset_17;

		// Token: 0x04010064 RID: 65636
		internal static int __PropertyOffset_18;

		// Token: 0x04010065 RID: 65637
		internal static int __PropertyOffset_19;

		// Token: 0x04010066 RID: 65638
		private static IntPtr __updateMaterialParameters_NativeFunctionPtr;

		// Token: 0x04010067 RID: 65639
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
