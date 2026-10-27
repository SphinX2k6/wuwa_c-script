using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A65 RID: 14949
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Scene/NewGacha/BP/Struct_GachaShowData.Struct_GachaShowData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class Struct_GachaShowData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F932 RID: 129330 RVA: 0x008BC5D6 File Offset: 0x008BA7D6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (Struct_GachaShowData._ScriptStructPtr != 0) ? Struct_GachaShowData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Scene/NewGacha/BP/Struct_GachaShowData.Struct_GachaShowData", ref Struct_GachaShowData._ScriptStructPtr);
		}

		// Token: 0x17002BD0 RID: 11216
		// (get) Token: 0x0601F933 RID: 129331 RVA: 0x008BC5FA File Offset: 0x008BA7FA
		// (set) Token: 0x0601F934 RID: 129332 RVA: 0x008BC60A File Offset: 0x008BA80A
		public unsafe int ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_GachaShowData.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_GachaShowData.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17002BD1 RID: 11217
		// (get) Token: 0x0601F935 RID: 129333 RVA: 0x008BC61B File Offset: 0x008BA81B
		// (set) Token: 0x0601F936 RID: 129334 RVA: 0x008BC62F File Offset: 0x008BA82F
		public unsafe UMaterialInterface SkyMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_GachaShowData.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_GachaShowData.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002BD2 RID: 11218
		// (get) Token: 0x0601F937 RID: 129335 RVA: 0x008BC644 File Offset: 0x008BA844
		// (set) Token: 0x0601F938 RID: 129336 RVA: 0x008BC658 File Offset: 0x008BA858
		public unsafe UMaterialInterface FloorMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_GachaShowData.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_GachaShowData.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002BD3 RID: 11219
		// (get) Token: 0x0601F939 RID: 129337 RVA: 0x008BC66D File Offset: 0x008BA86D
		// (set) Token: 0x0601F93A RID: 129338 RVA: 0x008BC681 File Offset: 0x008BA881
		public unsafe FLinearColor ParticleColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_GachaShowData.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_GachaShowData.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002BD4 RID: 11220
		// (get) Token: 0x0601F93B RID: 129339 RVA: 0x008BC696 File Offset: 0x008BA896
		// (set) Token: 0x0601F93C RID: 129340 RVA: 0x008BC6AA File Offset: 0x008BA8AA
		public unsafe UKuroWeatherDataAsset GachaDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_GachaShowData.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_GachaShowData.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x0601F93D RID: 129341 RVA: 0x008BC6BF File Offset: 0x008BA8BF
		// (set) Token: 0x0601F93E RID: 129342 RVA: 0x008BC6D3 File Offset: 0x008BA8D3
		public unsafe FVector FloorScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_GachaShowData.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_GachaShowData.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x0601F93F RID: 129343 RVA: 0x008BC6E8 File Offset: 0x008BA8E8
		// (set) Token: 0x0601F940 RID: 129344 RVA: 0x008BC6FC File Offset: 0x008BA8FC
		public unsafe FVector SkyScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_GachaShowData.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_GachaShowData.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x0601F941 RID: 129345 RVA: 0x008BC711 File Offset: 0x008BA911
		// (set) Token: 0x0601F942 RID: 129346 RVA: 0x008BC721 File Offset: 0x008BA921
		public unsafe bool MeshHidden
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_GachaShowData.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_GachaShowData.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x0601F943 RID: 129347 RVA: 0x008BC732 File Offset: 0x008BA932
		// (set) Token: 0x0601F944 RID: 129348 RVA: 0x008BC742 File Offset: 0x008BA942
		public unsafe float MotionBlur
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_GachaShowData.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_GachaShowData.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x0601F945 RID: 129349 RVA: 0x008BC753 File Offset: 0x008BA953
		public Struct_GachaShowData()
		{
		}

		// Token: 0x0601F946 RID: 129350 RVA: 0x008BC75C File Offset: 0x008BA95C
		[NullableContext(1)]
		public Struct_GachaShowData(int ID, UMaterialInterface SkyMaterial, UMaterialInterface FloorMaterial, FLinearColor ParticleColor, UKuroWeatherDataAsset GachaDataAsset, FVector FloorScale, FVector SkyScale, bool MeshHidden, float MotionBlur)
		{
			this.ID = ID;
			this.SkyMaterial = SkyMaterial;
			this.FloorMaterial = FloorMaterial;
			this.ParticleColor = ParticleColor;
			this.GachaDataAsset = GachaDataAsset;
			this.FloorScale = FloorScale;
			this.SkyScale = SkyScale;
			this.MeshHidden = MeshHidden;
			this.MotionBlur = MotionBlur;
		}

		// Token: 0x0601F947 RID: 129351 RVA: 0x008BC7B4 File Offset: 0x008BA9B4
		protected override IntPtr GetUStructPtr()
		{
			return Struct_GachaShowData.StaticStruct();
		}

		// Token: 0x0601F948 RID: 129352 RVA: 0x008BC7C0 File Offset: 0x008BA9C0
		public Struct_GachaShowData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F949 RID: 129353 RVA: 0x008BC7CA File Offset: 0x008BA9CA
		public Struct_GachaShowData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F94A RID: 129354 RVA: 0x008BC7D5 File Offset: 0x008BA9D5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new Struct_GachaShowData(Pointer, false, true);
		}

		// Token: 0x0601F94B RID: 129355 RVA: 0x008BC7DF File Offset: 0x008BA9DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new Struct_GachaShowData(Pointer, MemoryOwner);
		}

		// Token: 0x0400F2E4 RID: 62180
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/Struct_GachaShowData.Struct_GachaShowData";

		// Token: 0x0400F2E5 RID: 62181
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F2E6 RID: 62182
		internal static int __PropertyOffset_0;

		// Token: 0x0400F2E7 RID: 62183
		internal static int __PropertyOffset_1;

		// Token: 0x0400F2E8 RID: 62184
		internal static int __PropertyOffset_2;

		// Token: 0x0400F2E9 RID: 62185
		internal static int __PropertyOffset_3;

		// Token: 0x0400F2EA RID: 62186
		internal static int __PropertyOffset_4;

		// Token: 0x0400F2EB RID: 62187
		internal static int __PropertyOffset_5;

		// Token: 0x0400F2EC RID: 62188
		internal static int __PropertyOffset_6;

		// Token: 0x0400F2ED RID: 62189
		internal static int __PropertyOffset_7;

		// Token: 0x0400F2EE RID: 62190
		internal static int __PropertyOffset_8;
	}
}
