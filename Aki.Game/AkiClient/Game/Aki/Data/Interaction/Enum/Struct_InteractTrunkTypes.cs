using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Interaction.Enum
{
	// Token: 0x02003F23 RID: 16163
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Interaction/Enum/Struct_InteractTrunkTypes.Struct_InteractTrunkTypes")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class Struct_InteractTrunkTypes : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602909B RID: 168091 RVA: 0x009BA456 File Offset: 0x009B8656
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (Struct_InteractTrunkTypes._ScriptStructPtr != 0) ? Struct_InteractTrunkTypes._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Interaction/Enum/Struct_InteractTrunkTypes.Struct_InteractTrunkTypes", ref Struct_InteractTrunkTypes._ScriptStructPtr);
		}

		// Token: 0x17006114 RID: 24852
		// (get) Token: 0x0602909C RID: 168092 RVA: 0x009BA47A File Offset: 0x009B867A
		// (set) Token: 0x0602909D RID: 168093 RVA: 0x009BA48E File Offset: 0x009B868E
		public unsafe UStaticMesh StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_InteractTrunkTypes.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_InteractTrunkTypes.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006115 RID: 24853
		// (get) Token: 0x0602909E RID: 168094 RVA: 0x009BA4A3 File Offset: 0x009B86A3
		// (set) Token: 0x0602909F RID: 168095 RVA: 0x009BA4B3 File Offset: 0x009B86B3
		public unsafe float TrunkMaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_InteractTrunkTypes.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_InteractTrunkTypes.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006116 RID: 24854
		// (get) Token: 0x060290A0 RID: 168096 RVA: 0x009BA4C4 File Offset: 0x009B86C4
		// (set) Token: 0x060290A1 RID: 168097 RVA: 0x009BA4D8 File Offset: 0x009B86D8
		public unsafe UTexture2D TreePosTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_InteractTrunkTypes.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_InteractTrunkTypes.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006117 RID: 24855
		// (get) Token: 0x060290A2 RID: 168098 RVA: 0x009BA4ED File Offset: 0x009B86ED
		// (set) Token: 0x060290A3 RID: 168099 RVA: 0x009BA501 File Offset: 0x009B8701
		public unsafe UMaterialInstance TreeSkinMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_InteractTrunkTypes.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_InteractTrunkTypes.__PropertyOffset_3, value);
			}
		}

		// Token: 0x060290A4 RID: 168100 RVA: 0x009BA516 File Offset: 0x009B8716
		public Struct_InteractTrunkTypes()
		{
		}

		// Token: 0x060290A5 RID: 168101 RVA: 0x009BA51E File Offset: 0x009B871E
		[NullableContext(1)]
		public Struct_InteractTrunkTypes(UStaticMesh StaticMesh, float TrunkMaterialIndex, UTexture2D TreePosTexture, UMaterialInstance TreeSkinMaterial)
		{
			this.StaticMesh = StaticMesh;
			this.TrunkMaterialIndex = TrunkMaterialIndex;
			this.TreePosTexture = TreePosTexture;
			this.TreeSkinMaterial = TreeSkinMaterial;
		}

		// Token: 0x060290A6 RID: 168102 RVA: 0x009BA543 File Offset: 0x009B8743
		protected override IntPtr GetUStructPtr()
		{
			return Struct_InteractTrunkTypes.StaticStruct();
		}

		// Token: 0x060290A7 RID: 168103 RVA: 0x009BA54F File Offset: 0x009B874F
		public Struct_InteractTrunkTypes(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060290A8 RID: 168104 RVA: 0x009BA559 File Offset: 0x009B8759
		public Struct_InteractTrunkTypes(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060290A9 RID: 168105 RVA: 0x009BA564 File Offset: 0x009B8764
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new Struct_InteractTrunkTypes(Pointer, false, true);
		}

		// Token: 0x060290AA RID: 168106 RVA: 0x009BA56E File Offset: 0x009B876E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new Struct_InteractTrunkTypes(Pointer, MemoryOwner);
		}

		// Token: 0x04015015 RID: 86037
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Interaction/Enum/Struct_InteractTrunkTypes.Struct_InteractTrunkTypes";

		// Token: 0x04015016 RID: 86038
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015017 RID: 86039
		internal static int __PropertyOffset_0;

		// Token: 0x04015018 RID: 86040
		internal static int __PropertyOffset_1;

		// Token: 0x04015019 RID: 86041
		internal static int __PropertyOffset_2;

		// Token: 0x0401501A RID: 86042
		internal static int __PropertyOffset_3;
	}
}
