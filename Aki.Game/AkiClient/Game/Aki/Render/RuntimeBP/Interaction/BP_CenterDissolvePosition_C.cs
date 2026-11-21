using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x020030EF RID: 12527
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_CenterDissolvePosition.BP_CenterDissolvePosition_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1545)]
	public class BP_CenterDissolvePosition_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E6A4 RID: 124580 RVA: 0x00913413 File Offset: 0x00911613
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CenterDissolvePosition_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_CenterDissolvePosition.BP_CenterDissolvePosition_C");
			}
			return BP_CenterDissolvePosition_C._ClassPtr;
		}

		// Token: 0x0601E6A5 RID: 124581 RVA: 0x00913438 File Offset: 0x00911638
		public BP_CenterDissolvePosition_C() : this(BuiltinUtils.AllocNativeUObject(BP_CenterDissolvePosition_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E6A6 RID: 124582 RVA: 0x00913460 File Offset: 0x00911660
		[NullableContext(1)]
		public BP_CenterDissolvePosition_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CenterDissolvePosition_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x0601E6A7 RID: 124583 RVA: 0x00913493 File Offset: 0x00911693
		// (set) Token: 0x0601E6A8 RID: 124584 RVA: 0x009134A7 File Offset: 0x009116A7
		public unsafe USceneComponent DissolveCenter
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CenterDissolvePosition_C.__PropertyOffset_DissolveCenter);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CenterDissolvePosition_C.__PropertyOffset_DissolveCenter, value);
			}
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x0601E6A9 RID: 124585 RVA: 0x009134BC File Offset: 0x009116BC
		// (set) Token: 0x0601E6AA RID: 124586 RVA: 0x009134D0 File Offset: 0x009116D0
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CenterDissolvePosition_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CenterDissolvePosition_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x0601E6AB RID: 124587 RVA: 0x009134E5 File Offset: 0x009116E5
		// (set) Token: 0x0601E6AC RID: 124588 RVA: 0x009134F9 File Offset: 0x009116F9
		public unsafe UTexture2D T_Noise
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CenterDissolvePosition_C.__PropertyOffset_T_Noise);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CenterDissolvePosition_C.__PropertyOffset_T_Noise, value);
			}
		}

		// Token: 0x170033A7 RID: 13223
		// (get) Token: 0x0601E6AD RID: 124589 RVA: 0x0091350E File Offset: 0x0091170E
		// (set) Token: 0x0601E6AE RID: 124590 RVA: 0x0091351E File Offset: 0x0091171E
		public unsafe float Dist_UV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_Dist_UV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_Dist_UV) = value;
			}
		}

		// Token: 0x170033A8 RID: 13224
		// (get) Token: 0x0601E6AF RID: 124591 RVA: 0x0091352F File Offset: 0x0091172F
		// (set) Token: 0x0601E6B0 RID: 124592 RVA: 0x00913543 File Offset: 0x00911743
		public unsafe FLinearColor EmissiveColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_EmissiveColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_EmissiveColor) = value;
			}
		}

		// Token: 0x170033A9 RID: 13225
		// (get) Token: 0x0601E6B1 RID: 124593 RVA: 0x00913558 File Offset: 0x00911758
		// (set) Token: 0x0601E6B2 RID: 124594 RVA: 0x0091356C File Offset: 0x0091176C
		public unsafe FVector CubeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_CubeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_CubeSize) = value;
			}
		}

		// Token: 0x170033AA RID: 13226
		// (get) Token: 0x0601E6B3 RID: 124595 RVA: 0x00913581 File Offset: 0x00911781
		// (set) Token: 0x0601E6B4 RID: 124596 RVA: 0x00913591 File Offset: 0x00911791
		public unsafe float DissolveRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_DissolveRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_DissolveRadius) = value;
			}
		}

		// Token: 0x170033AB RID: 13227
		// (get) Token: 0x0601E6B5 RID: 124597 RVA: 0x009135A2 File Offset: 0x009117A2
		// (set) Token: 0x0601E6B6 RID: 124598 RVA: 0x009135B2 File Offset: 0x009117B2
		public unsafe float EdgeFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_EdgeFade);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_EdgeFade) = value;
			}
		}

		// Token: 0x170033AC RID: 13228
		// (get) Token: 0x0601E6B7 RID: 124599 RVA: 0x009135C3 File Offset: 0x009117C3
		// (set) Token: 0x0601E6B8 RID: 124600 RVA: 0x009135D3 File Offset: 0x009117D3
		public unsafe float DissolveEdgeWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_DissolveEdgeWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_DissolveEdgeWidth) = value;
			}
		}

		// Token: 0x170033AD RID: 13229
		// (get) Token: 0x0601E6B9 RID: 124601 RVA: 0x009135E4 File Offset: 0x009117E4
		// (set) Token: 0x0601E6BA RID: 124602 RVA: 0x0091361D File Offset: 0x0091181D
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> StaticMeshDMI
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._StaticMeshDMI) == null)
				{
					result = (this._StaticMeshDMI = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_StaticMeshDMI, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StaticMeshDMI.CopyAssign(value);
			}
		}

		// Token: 0x170033AE RID: 13230
		// (get) Token: 0x0601E6BB RID: 124603 RVA: 0x0091362B File Offset: 0x0091182B
		// (set) Token: 0x0601E6BC RID: 124604 RVA: 0x0091363B File Offset: 0x0091183B
		public unsafe bool DMISet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_DMISet) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_DMISet) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E6BD RID: 124605 RVA: 0x0091364C File Offset: 0x0091184C
		[SkipLocalsInit]
		public virtual void Set_Dissolve_Param()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__Set_Dissolve_Param_NativeFunctionPtr, null);
		}

		// Token: 0x0601E6BE RID: 124606 RVA: 0x00913660 File Offset: 0x00911860
		[SkipLocalsInit]
		public virtual void Create_Dynamic_Material_Instance()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__Create_Dynamic_Material_Instance_NativeFunctionPtr, null);
		}

		// Token: 0x0601E6BF RID: 124607 RVA: 0x00913674 File Offset: 0x00911874
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E6C0 RID: 124608 RVA: 0x00913688 File Offset: 0x00911888
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E6C1 RID: 124609 RVA: 0x0091369C File Offset: 0x0091189C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CenterDissolvePosition_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CenterDissolvePosition_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CenterDissolvePosition_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CenterDissolvePosition_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E6C2 RID: 124610 RVA: 0x009136E4 File Offset: 0x009118E4
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CenterDissolvePosition_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CenterDissolvePosition_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CenterDissolvePosition_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CenterDissolvePosition_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E6C3 RID: 124611 RVA: 0x0091372C File Offset: 0x0091192C
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CenterDissolvePosition_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CenterDissolvePosition_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CenterDissolvePosition_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CenterDissolvePosition_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E6C4 RID: 124612 RVA: 0x00913774 File Offset: 0x00911974
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CenterDissolvePosition_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CenterDissolvePosition_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CenterDissolvePosition_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CenterDissolvePosition_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E6C5 RID: 124613 RVA: 0x009137BA File Offset: 0x009119BA
		protected BP_CenterDissolvePosition_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040101B7 RID: 65975
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_CenterDissolvePosition.BP_CenterDissolvePosition_C";

		// Token: 0x040101B8 RID: 65976
		private static IntPtr _ClassPtr;

		// Token: 0x040101B9 RID: 65977
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040101BA RID: 65978
		internal static int __PropertyOffset_DissolveCenter;

		// Token: 0x040101BB RID: 65979
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x040101BC RID: 65980
		internal static int __PropertyOffset_T_Noise;

		// Token: 0x040101BD RID: 65981
		internal static int __PropertyOffset_Dist_UV;

		// Token: 0x040101BE RID: 65982
		internal static int __PropertyOffset_EmissiveColor;

		// Token: 0x040101BF RID: 65983
		internal static int __PropertyOffset_CubeSize;

		// Token: 0x040101C0 RID: 65984
		internal static int __PropertyOffset_DissolveRadius;

		// Token: 0x040101C1 RID: 65985
		internal static int __PropertyOffset_EdgeFade;

		// Token: 0x040101C2 RID: 65986
		internal static int __PropertyOffset_DissolveEdgeWidth;

		// Token: 0x040101C3 RID: 65987
		internal static int __PropertyOffset_StaticMeshDMI;

		// Token: 0x040101C4 RID: 65988
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _StaticMeshDMI;

		// Token: 0x040101C5 RID: 65989
		internal static int __PropertyOffset_DMISet;

		// Token: 0x040101C6 RID: 65990
		private static IntPtr __Set_Dissolve_Param_NativeFunctionPtr;

		// Token: 0x040101C7 RID: 65991
		private static IntPtr __Create_Dynamic_Material_Instance_NativeFunctionPtr;

		// Token: 0x040101C8 RID: 65992
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040101C9 RID: 65993
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040101CA RID: 65994
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02008E76 RID: 36470
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CAC3 RID: 182979
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E77 RID: 36471
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CAC4 RID: 182980
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
