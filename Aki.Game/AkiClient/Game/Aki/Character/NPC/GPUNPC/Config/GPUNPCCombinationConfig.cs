using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.GPUNPC.Config
{
	// Token: 0x02004191 RID: 16785
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/NPC/GPUNPC/Config/GPUNPCCombinationConfig.GPUNPCCombinationConfig")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class GPUNPCCombinationConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602B8AE RID: 178350 RVA: 0x00A0398D File Offset: 0x00A01B8D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (GPUNPCCombinationConfig._ScriptStructPtr != 0) ? GPUNPCCombinationConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/NPC/GPUNPC/Config/GPUNPCCombinationConfig.GPUNPCCombinationConfig", ref GPUNPCCombinationConfig._ScriptStructPtr);
		}

		// Token: 0x17006BC1 RID: 27585
		// (get) Token: 0x0602B8AF RID: 178351 RVA: 0x00A039B1 File Offset: 0x00A01BB1
		// (set) Token: 0x0602B8B0 RID: 178352 RVA: 0x00A039C5 File Offset: 0x00A01BC5
		public unsafe USkeletalMesh MergedSkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCCombinationConfig.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCCombinationConfig.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006BC2 RID: 27586
		// (get) Token: 0x0602B8B1 RID: 178353 RVA: 0x00A039DA File Offset: 0x00A01BDA
		// (set) Token: 0x0602B8B2 RID: 178354 RVA: 0x00A039EA File Offset: 0x00A01BEA
		public unsafe int AnimTextureIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GPUNPCCombinationConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GPUNPCCombinationConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006BC3 RID: 27587
		// (get) Token: 0x0602B8B3 RID: 178355 RVA: 0x00A039FB File Offset: 0x00A01BFB
		// (set) Token: 0x0602B8B4 RID: 178356 RVA: 0x00A03A0F File Offset: 0x00A01C0F
		public unsafe UBakedBoneTexture2D Combined_BakedBone_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBakedBoneTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCCombinationConfig.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCCombinationConfig.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602B8B5 RID: 178357 RVA: 0x00A03A24 File Offset: 0x00A01C24
		public GPUNPCCombinationConfig()
		{
		}

		// Token: 0x0602B8B6 RID: 178358 RVA: 0x00A03A2C File Offset: 0x00A01C2C
		[NullableContext(1)]
		public GPUNPCCombinationConfig(USkeletalMesh MergedSkeletalMesh, int AnimTextureIndex, UBakedBoneTexture2D Combined_BakedBone_Texture)
		{
			this.MergedSkeletalMesh = MergedSkeletalMesh;
			this.AnimTextureIndex = AnimTextureIndex;
			this.Combined_BakedBone_Texture = Combined_BakedBone_Texture;
		}

		// Token: 0x0602B8B7 RID: 178359 RVA: 0x00A03A49 File Offset: 0x00A01C49
		protected override IntPtr GetUStructPtr()
		{
			return GPUNPCCombinationConfig.StaticStruct();
		}

		// Token: 0x0602B8B8 RID: 178360 RVA: 0x00A03A55 File Offset: 0x00A01C55
		public GPUNPCCombinationConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602B8B9 RID: 178361 RVA: 0x00A03A5F File Offset: 0x00A01C5F
		public GPUNPCCombinationConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602B8BA RID: 178362 RVA: 0x00A03A6A File Offset: 0x00A01C6A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new GPUNPCCombinationConfig(Pointer, false, true);
		}

		// Token: 0x0602B8BB RID: 178363 RVA: 0x00A03A74 File Offset: 0x00A01C74
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new GPUNPCCombinationConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04016ABC RID: 92860
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/NPC/GPUNPC/Config/GPUNPCCombinationConfig.GPUNPCCombinationConfig";

		// Token: 0x04016ABD RID: 92861
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016ABE RID: 92862
		internal static int __PropertyOffset_0;

		// Token: 0x04016ABF RID: 92863
		internal static int __PropertyOffset_1;

		// Token: 0x04016AC0 RID: 92864
		internal static int __PropertyOffset_2;
	}
}
