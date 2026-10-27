using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D12 RID: 15634
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_DollGrabLight.BP_DollGrabLight_C")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1496)]
	public class BP_DollGrabLight_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025796 RID: 153494 RVA: 0x0095AB29 File Offset: 0x00958D29
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollGrabLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_DollGrabLight.BP_DollGrabLight_C");
			}
			return BP_DollGrabLight_C._ClassPtr;
		}

		// Token: 0x06025797 RID: 153495 RVA: 0x0095AB50 File Offset: 0x00958D50
		public BP_DollGrabLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollGrabLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025798 RID: 153496 RVA: 0x0095AB78 File Offset: 0x00958D78
		[NullableContext(1)]
		public BP_DollGrabLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollGrabLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004CD9 RID: 19673
		// (get) Token: 0x06025799 RID: 153497 RVA: 0x0095ABAB File Offset: 0x00958DAB
		// (set) Token: 0x0602579A RID: 153498 RVA: 0x0095ABBF File Offset: 0x00958DBF
		public unsafe UStaticMeshComponent Light3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollGrabLight_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollGrabLight_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17004CDA RID: 19674
		// (get) Token: 0x0602579B RID: 153499 RVA: 0x0095ABD4 File Offset: 0x00958DD4
		// (set) Token: 0x0602579C RID: 153500 RVA: 0x0095ABE8 File Offset: 0x00958DE8
		public unsafe UStaticMeshComponent Light2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollGrabLight_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollGrabLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004CDB RID: 19675
		// (get) Token: 0x0602579D RID: 153501 RVA: 0x0095ABFD File Offset: 0x00958DFD
		// (set) Token: 0x0602579E RID: 153502 RVA: 0x0095AC11 File Offset: 0x00958E11
		public unsafe UStaticMeshComponent Light1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollGrabLight_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollGrabLight_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004CDC RID: 19676
		// (get) Token: 0x0602579F RID: 153503 RVA: 0x0095AC26 File Offset: 0x00958E26
		// (set) Token: 0x060257A0 RID: 153504 RVA: 0x0095AC3A File Offset: 0x00958E3A
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollGrabLight_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollGrabLight_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004CDD RID: 19677
		// (get) Token: 0x060257A1 RID: 153505 RVA: 0x0095AC4F File Offset: 0x00958E4F
		// (set) Token: 0x060257A2 RID: 153506 RVA: 0x0095AC5F File Offset: 0x00958E5F
		public unsafe int LightIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabLight_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabLight_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004CDE RID: 19678
		// (get) Token: 0x060257A3 RID: 153507 RVA: 0x0095AC70 File Offset: 0x00958E70
		// (set) Token: 0x060257A4 RID: 153508 RVA: 0x0095ACA9 File Offset: 0x00958EA9
		[Nullable(1)]
		public TArray<UStaticMeshComponent> LightArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._LightArray) == null)
				{
					result = (this._LightArray = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_DollGrabLight_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightArray.CopyAssign(value);
			}
		}

		// Token: 0x060257A5 RID: 153509 RVA: 0x0095ACB7 File Offset: 0x00958EB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void LightOff()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollGrabLight_C.__LightOff_NativeFunctionPtr, null);
		}

		// Token: 0x060257A6 RID: 153510 RVA: 0x0095ACCB File Offset: 0x00958ECB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void LightOn()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollGrabLight_C.__LightOn_NativeFunctionPtr, null);
		}

		// Token: 0x060257A7 RID: 153511 RVA: 0x0095ACDF File Offset: 0x00958EDF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollGrabLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060257A8 RID: 153512 RVA: 0x0095ACF3 File Offset: 0x00958EF3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DollGrabLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060257A9 RID: 153513 RVA: 0x0095AD08 File Offset: 0x00958F08
		protected BP_DollGrabLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B2E RID: 76590
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_DollGrabLight.BP_DollGrabLight_C";

		// Token: 0x04012B2F RID: 76591
		private static IntPtr _ClassPtr;

		// Token: 0x04012B30 RID: 76592
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B31 RID: 76593
		internal static int __PropertyOffset_0;

		// Token: 0x04012B32 RID: 76594
		internal static int __PropertyOffset_1;

		// Token: 0x04012B33 RID: 76595
		internal static int __PropertyOffset_2;

		// Token: 0x04012B34 RID: 76596
		internal static int __PropertyOffset_3;

		// Token: 0x04012B35 RID: 76597
		internal static int __PropertyOffset_4;

		// Token: 0x04012B36 RID: 76598
		internal static int __PropertyOffset_5;

		// Token: 0x04012B37 RID: 76599
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _LightArray;

		// Token: 0x04012B38 RID: 76600
		private static IntPtr __LightOff_NativeFunctionPtr;

		// Token: 0x04012B39 RID: 76601
		private static IntPtr __LightOn_NativeFunctionPtr;

		// Token: 0x04012B3A RID: 76602
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
