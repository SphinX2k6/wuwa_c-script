using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003187 RID: 12679
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomization.SQtaCustomization")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class SQtaCustomization : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F456 RID: 128086 RVA: 0x0092A197 File Offset: 0x00928397
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaCustomization._ScriptStructPtr != 0) ? SQtaCustomization._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomization.SQtaCustomization", ref SQtaCustomization._ScriptStructPtr);
		}

		// Token: 0x17003863 RID: 14435
		// (get) Token: 0x0601F457 RID: 128087 RVA: 0x0092A1BB File Offset: 0x009283BB
		// (set) Token: 0x0601F458 RID: 128088 RVA: 0x0092A1CF File Offset: 0x009283CF
		[Nullable(0)]
		public unsafe TEnumAsByte<EQtaCustomizationViewType> ViewType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCustomization.__PropertyOffset_ViewType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCustomization.__PropertyOffset_ViewType) = value;
			}
		}

		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x0601F459 RID: 128089 RVA: 0x0092A1E4 File Offset: 0x009283E4
		// (set) Token: 0x0601F45A RID: 128090 RVA: 0x0092A1F8 File Offset: 0x009283F8
		public unsafe string ViewName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SQtaCustomization.__PropertyOffset_ViewName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SQtaCustomization.__PropertyOffset_ViewName)), value);
			}
		}

		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x0601F45B RID: 128091 RVA: 0x0092A20D File Offset: 0x0092840D
		// (set) Token: 0x0601F45C RID: 128092 RVA: 0x0092A22C File Offset: 0x0092842C
		public TSoftObjectPtr<BP_QtaCustomizationBase_C> DaConfig
		{
			get
			{
				return new TSoftObjectPtr<BP_QtaCustomizationBase_C>(base.NativePtr + (IntPtr)SQtaCustomization.__PropertyOffset_DaConfig, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SQtaCustomization.__PropertyOffset_DaConfig, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601F45D RID: 128093 RVA: 0x0092A251 File Offset: 0x00928451
		public SQtaCustomization()
		{
		}

		// Token: 0x0601F45E RID: 128094 RVA: 0x0092A259 File Offset: 0x00928459
		protected override IntPtr GetUStructPtr()
		{
			return SQtaCustomization.StaticStruct();
		}

		// Token: 0x0601F45F RID: 128095 RVA: 0x0092A265 File Offset: 0x00928465
		[NullableContext(2)]
		public SQtaCustomization(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F460 RID: 128096 RVA: 0x0092A26F File Offset: 0x0092846F
		public SQtaCustomization(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F461 RID: 128097 RVA: 0x0092A27A File Offset: 0x0092847A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaCustomization(Pointer, false, true);
		}

		// Token: 0x0601F462 RID: 128098 RVA: 0x0092A284 File Offset: 0x00928484
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaCustomization(Pointer, MemoryOwner);
		}

		// Token: 0x04010BCC RID: 68556
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/Customization/SQtaCustomization.SQtaCustomization";

		// Token: 0x04010BCD RID: 68557
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010BCE RID: 68558
		internal static int __PropertyOffset_ViewType;

		// Token: 0x04010BCF RID: 68559
		internal static int __PropertyOffset_ViewName;

		// Token: 0x04010BD0 RID: 68560
		internal static int __PropertyOffset_DaConfig;
	}
}
