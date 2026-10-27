using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003EBB RID: 16059
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomization.SQtaCustomization")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class SQtaCustomization : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060289BC RID: 166332 RVA: 0x009B06B0 File Offset: 0x009AE8B0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaCustomization._ScriptStructPtr != 0) ? SQtaCustomization._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomization.SQtaCustomization", ref SQtaCustomization._ScriptStructPtr);
		}

		// Token: 0x17005EB3 RID: 24243
		// (get) Token: 0x060289BD RID: 166333 RVA: 0x009B06D4 File Offset: 0x009AE8D4
		// (set) Token: 0x060289BE RID: 166334 RVA: 0x009B06E8 File Offset: 0x009AE8E8
		[Nullable(0)]
		public unsafe TEnumAsByte<EQtaCustomizationViewType> ViewType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomization.__PropertyOffset_0);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomization.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005EB4 RID: 24244
		// (get) Token: 0x060289BF RID: 166335 RVA: 0x009B06FD File Offset: 0x009AE8FD
		// (set) Token: 0x060289C0 RID: 166336 RVA: 0x009B0711 File Offset: 0x009AE911
		public unsafe string ViewName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SQtaCustomization.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SQtaCustomization.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17005EB5 RID: 24245
		// (get) Token: 0x060289C1 RID: 166337 RVA: 0x009B0726 File Offset: 0x009AE926
		// (set) Token: 0x060289C2 RID: 166338 RVA: 0x009B0745 File Offset: 0x009AE945
		public TSoftObjectPtr<BP_QtaCustomizationBase_C> DaConfig
		{
			get
			{
				return new TSoftObjectPtr<BP_QtaCustomizationBase_C>(base.NativePtr + (IntPtr)SQtaCustomization.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SQtaCustomization.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x060289C3 RID: 166339 RVA: 0x009B076A File Offset: 0x009AE96A
		public SQtaCustomization()
		{
		}

		// Token: 0x060289C4 RID: 166340 RVA: 0x009B0772 File Offset: 0x009AE972
		public SQtaCustomization([Nullable(0)] TEnumAsByte<EQtaCustomizationViewType> ViewType, string ViewName, TSoftObjectPtr<BP_QtaCustomizationBase_C> DaConfig)
		{
			this.ViewType = ViewType;
			this.ViewName = ViewName;
			this.DaConfig = DaConfig;
		}

		// Token: 0x060289C5 RID: 166341 RVA: 0x009B078F File Offset: 0x009AE98F
		protected override IntPtr GetUStructPtr()
		{
			return SQtaCustomization.StaticStruct();
		}

		// Token: 0x060289C6 RID: 166342 RVA: 0x009B079B File Offset: 0x009AE99B
		[NullableContext(2)]
		public SQtaCustomization(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060289C7 RID: 166343 RVA: 0x009B07A5 File Offset: 0x009AE9A5
		public SQtaCustomization(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060289C8 RID: 166344 RVA: 0x009B07B0 File Offset: 0x009AE9B0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaCustomization(Pointer, false, true);
		}

		// Token: 0x060289C9 RID: 166345 RVA: 0x009B07BA File Offset: 0x009AE9BA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaCustomization(Pointer, MemoryOwner);
		}

		// Token: 0x04014BA7 RID: 84903
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomization.SQtaCustomization";

		// Token: 0x04014BA8 RID: 84904
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014BA9 RID: 84905
		internal static int __PropertyOffset_0;

		// Token: 0x04014BAA RID: 84906
		internal static int __PropertyOffset_1;

		// Token: 0x04014BAB RID: 84907
		internal static int __PropertyOffset_2;
	}
}
