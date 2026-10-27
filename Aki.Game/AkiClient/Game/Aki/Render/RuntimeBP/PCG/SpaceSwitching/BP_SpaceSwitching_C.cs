using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SpaceSwitching
{
	// Token: 0x02003BF1 RID: 15345
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SpaceSwitching/BP_SpaceSwitching.BP_SpaceSwitching_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class BP_SpaceSwitching_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022DB7 RID: 142775 RVA: 0x00914298 File Offset: 0x00912498
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SpaceSwitching_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SpaceSwitching/BP_SpaceSwitching.BP_SpaceSwitching_C");
			}
			return BP_SpaceSwitching_C._ClassPtr;
		}

		// Token: 0x06022DB8 RID: 142776 RVA: 0x009142BC File Offset: 0x009124BC
		public BP_SpaceSwitching_C() : this(BuiltinUtils.AllocNativeUObject(BP_SpaceSwitching_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022DB9 RID: 142777 RVA: 0x009142E4 File Offset: 0x009124E4
		[NullableContext(1)]
		public BP_SpaceSwitching_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SpaceSwitching_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E2C RID: 15916
		// (get) Token: 0x06022DBA RID: 142778 RVA: 0x00914317 File Offset: 0x00912517
		// (set) Token: 0x06022DBB RID: 142779 RVA: 0x0091432B File Offset: 0x0091252B
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceSwitching_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceSwitching_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003E2D RID: 15917
		// (get) Token: 0x06022DBC RID: 142780 RVA: 0x00914340 File Offset: 0x00912540
		// (set) Token: 0x06022DBD RID: 142781 RVA: 0x00914354 File Offset: 0x00912554
		public unsafe UStaticMeshComponent SM_Div_Doo_01AM1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceSwitching_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceSwitching_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003E2E RID: 15918
		// (get) Token: 0x06022DBE RID: 142782 RVA: 0x00914369 File Offset: 0x00912569
		// (set) Token: 0x06022DBF RID: 142783 RVA: 0x0091437D File Offset: 0x0091257D
		public unsafe UStaticMeshComponent SM_Div_Doo_01AM
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceSwitching_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceSwitching_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003E2F RID: 15919
		// (get) Token: 0x06022DC0 RID: 142784 RVA: 0x00914392 File Offset: 0x00912592
		// (set) Token: 0x06022DC1 RID: 142785 RVA: 0x009143A6 File Offset: 0x009125A6
		public unsafe UNiagaraComponent NS_Fx_SpaceSwitching
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceSwitching_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceSwitching_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003E30 RID: 15920
		// (get) Token: 0x06022DC2 RID: 142786 RVA: 0x009143BB File Offset: 0x009125BB
		// (set) Token: 0x06022DC3 RID: 142787 RVA: 0x009143CF File Offset: 0x009125CF
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceSwitching_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceSwitching_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003E31 RID: 15921
		// (get) Token: 0x06022DC4 RID: 142788 RVA: 0x009143E4 File Offset: 0x009125E4
		// (set) Token: 0x06022DC5 RID: 142789 RVA: 0x009143F8 File Offset: 0x009125F8
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceSwitching_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpaceSwitching_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003E32 RID: 15922
		// (get) Token: 0x06022DC6 RID: 142790 RVA: 0x0091440D File Offset: 0x0091260D
		// (set) Token: 0x06022DC7 RID: 142791 RVA: 0x0091441D File Offset: 0x0091261D
		public unsafe float DoorDissolveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpaceSwitching_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpaceSwitching_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003E33 RID: 15923
		// (get) Token: 0x06022DC8 RID: 142792 RVA: 0x0091442E File Offset: 0x0091262E
		// (set) Token: 0x06022DC9 RID: 142793 RVA: 0x0091443E File Offset: 0x0091263E
		public unsafe float ParticleDisplayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpaceSwitching_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpaceSwitching_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003E34 RID: 15924
		// (get) Token: 0x06022DCA RID: 142794 RVA: 0x00914450 File Offset: 0x00912650
		// (set) Token: 0x06022DCB RID: 142795 RVA: 0x00914489 File Offset: 0x00912689
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> DMI
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._DMI) == null)
				{
					result = (this._DMI = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_SpaceSwitching_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DMI.CopyAssign(value);
			}
		}

		// Token: 0x06022DCC RID: 142796 RVA: 0x00914497 File Offset: 0x00912697
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpaceSwitching_C.__SetParam_NativeFunctionPtr, null);
		}

		// Token: 0x06022DCD RID: 142797 RVA: 0x009144AB File Offset: 0x009126AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpaceSwitching_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022DCE RID: 142798 RVA: 0x009144BF File Offset: 0x009126BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SpaceSwitching_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022DCF RID: 142799 RVA: 0x009144D4 File Offset: 0x009126D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParamFromSequence()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpaceSwitching_C.__SetParamFromSequence_NativeFunctionPtr, null);
		}

		// Token: 0x06022DD0 RID: 142800 RVA: 0x009144E8 File Offset: 0x009126E8
		protected BP_SpaceSwitching_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401126D RID: 70253
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SpaceSwitching/BP_SpaceSwitching.BP_SpaceSwitching_C";

		// Token: 0x0401126E RID: 70254
		private static IntPtr _ClassPtr;

		// Token: 0x0401126F RID: 70255
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011270 RID: 70256
		internal static int __PropertyOffset_1;

		// Token: 0x04011271 RID: 70257
		internal static int __PropertyOffset_2;

		// Token: 0x04011272 RID: 70258
		internal static int __PropertyOffset_3;

		// Token: 0x04011273 RID: 70259
		internal static int __PropertyOffset_4;

		// Token: 0x04011274 RID: 70260
		internal static int __PropertyOffset_5;

		// Token: 0x04011275 RID: 70261
		internal static int __PropertyOffset_6;

		// Token: 0x04011276 RID: 70262
		internal static int __PropertyOffset_7;

		// Token: 0x04011277 RID: 70263
		internal static int __PropertyOffset_8;

		// Token: 0x04011278 RID: 70264
		internal static int __PropertyOffset_9;

		// Token: 0x04011279 RID: 70265
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _DMI;

		// Token: 0x0401127A RID: 70266
		private static IntPtr __SetParam_NativeFunctionPtr;

		// Token: 0x0401127B RID: 70267
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401127C RID: 70268
		private static IntPtr __SetParamFromSequence_NativeFunctionPtr;
	}
}
