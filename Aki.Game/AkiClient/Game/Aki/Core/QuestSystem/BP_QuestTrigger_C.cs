using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Quest.Structures;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.QuestSystem
{
	// Token: 0x02003FEB RID: 16363
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/QuestSystem/BP_QuestTrigger.BP_QuestTrigger_C")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public class BP_QuestTrigger_C : ATriggerSphere, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029ED9 RID: 171737 RVA: 0x009D09F7 File Offset: 0x009CEBF7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_QuestTrigger_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/QuestSystem/BP_QuestTrigger.BP_QuestTrigger_C");
			}
			return BP_QuestTrigger_C._ClassPtr;
		}

		// Token: 0x06029EDA RID: 171738 RVA: 0x009D0A1C File Offset: 0x009CEC1C
		public BP_QuestTrigger_C() : this(BuiltinUtils.AllocNativeUObject(BP_QuestTrigger_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029EDB RID: 171739 RVA: 0x009D0A44 File Offset: 0x009CEC44
		[NullableContext(1)]
		public BP_QuestTrigger_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_QuestTrigger_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170065D7 RID: 26071
		// (get) Token: 0x06029EDC RID: 171740 RVA: 0x009D0A77 File Offset: 0x009CEC77
		// (set) Token: 0x06029EDD RID: 171741 RVA: 0x009D0A8B File Offset: 0x009CEC8B
		public unsafe UTextRenderComponent TextRenderTime
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrigger_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrigger_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170065D8 RID: 26072
		// (get) Token: 0x06029EDE RID: 171742 RVA: 0x009D0AA0 File Offset: 0x009CECA0
		// (set) Token: 0x06029EDF RID: 171743 RVA: 0x009D0AB4 File Offset: 0x009CECB4
		public unsafe UTextRenderComponent TextRenderDes
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrigger_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrigger_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170065D9 RID: 26073
		// (get) Token: 0x06029EE0 RID: 171744 RVA: 0x009D0AC9 File Offset: 0x009CECC9
		// (set) Token: 0x06029EE1 RID: 171745 RVA: 0x009D0ADD File Offset: 0x009CECDD
		public unsafe AActor player
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrigger_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrigger_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170065DA RID: 26074
		// (get) Token: 0x06029EE2 RID: 171746 RVA: 0x009D0AF4 File Offset: 0x009CECF4
		// (set) Token: 0x06029EE3 RID: 171747 RVA: 0x009D0B2D File Offset: 0x009CED2D
		[Nullable(1)]
		public TArray<SQuestRequest> QuestTriggerInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SQuestRequest> result;
				if ((result = this._QuestTriggerInfo) == null)
				{
					result = (this._QuestTriggerInfo = new TArray<SQuestRequest>(base.NativePtr + (IntPtr)BP_QuestTrigger_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.QuestTriggerInfo.CopyAssign(value);
			}
		}

		// Token: 0x170065DB RID: 26075
		// (get) Token: 0x06029EE4 RID: 171748 RVA: 0x009D0B3B File Offset: 0x009CED3B
		// (set) Token: 0x06029EE5 RID: 171749 RVA: 0x009D0B4B File Offset: 0x009CED4B
		public unsafe int currindex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrigger_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrigger_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170065DC RID: 26076
		// (get) Token: 0x06029EE6 RID: 171750 RVA: 0x009D0B5C File Offset: 0x009CED5C
		// (set) Token: 0x06029EE7 RID: 171751 RVA: 0x009D0B6C File Offset: 0x009CED6C
		public unsafe bool bIsEnableInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrigger_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrigger_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170065DD RID: 26077
		// (get) Token: 0x06029EE8 RID: 171752 RVA: 0x009D0B80 File Offset: 0x009CED80
		// (set) Token: 0x06029EE9 RID: 171753 RVA: 0x009D0BB9 File Offset: 0x009CEDB9
		[Nullable(1)]
		public unsafe FText QuestDescription
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._QuestDescription) == null)
				{
					result = (this._QuestDescription = new FText(base.NativePtr + (IntPtr)BP_QuestTrigger_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)BP_QuestTrigger_C.__PropertyOffset_7)), value.NativePtr, 1);
			}
		}

		// Token: 0x170065DE RID: 26078
		// (get) Token: 0x06029EEA RID: 171754 RVA: 0x009D0BD4 File Offset: 0x009CEDD4
		// (set) Token: 0x06029EEB RID: 171755 RVA: 0x009D0C0D File Offset: 0x009CEE0D
		[Nullable(1)]
		public FTimerHandle timerhandler
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FTimerHandle result;
				if ((result = this._timerhandler) == null)
				{
					result = (this._timerhandler = new FTimerHandle(base.NativePtr + (IntPtr)BP_QuestTrigger_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimerHandle.StaticStruct(), base.NativePtr + (IntPtr)BP_QuestTrigger_C.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170065DF RID: 26079
		// (get) Token: 0x06029EEC RID: 171756 RVA: 0x009D0C2E File Offset: 0x009CEE2E
		// (set) Token: 0x06029EED RID: 171757 RVA: 0x009D0C3E File Offset: 0x009CEE3E
		public unsafe bool bIsEnableDisplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrigger_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrigger_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170065E0 RID: 26080
		// (get) Token: 0x06029EEE RID: 171758 RVA: 0x009D0C4F File Offset: 0x009CEE4F
		// (set) Token: 0x06029EEF RID: 171759 RVA: 0x009D0C5F File Offset: 0x009CEE5F
		public unsafe bool bIsAutoTriggered
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrigger_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrigger_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170065E1 RID: 26081
		// (get) Token: 0x06029EF0 RID: 171760 RVA: 0x009D0C70 File Offset: 0x009CEE70
		// (set) Token: 0x06029EF1 RID: 171761 RVA: 0x009D0C84 File Offset: 0x009CEE84
		public unsafe FColor DescriptionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrigger_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrigger_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x06029EF2 RID: 171762 RVA: 0x009D0C99 File Offset: 0x009CEE99
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06029EF3 RID: 171763 RVA: 0x009D0CAD File Offset: 0x009CEEAD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QuestTrigger_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06029EF4 RID: 171764 RVA: 0x009D0CC4 File Offset: 0x009CEEC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_G_K2Node_InputKeyEvent_0(FKey Key)
		{
			BP_QuestTrigger_C.__InpActEvt_G_K2Node_InputKeyEvent_0_FunctionParams* ptr = stackalloc BP_QuestTrigger_C.__InpActEvt_G_K2Node_InputKeyEvent_0_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_QuestTrigger_C.__InpActEvt_G_K2Node_InputKeyEvent_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrigger_C.__InpActEvt_G_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_C.__InpActEvt_G_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_QuestTrigger_C.__InpActEvt_G_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029EF5 RID: 171765 RVA: 0x009D0D36 File Offset: 0x009CEF36
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06029EF6 RID: 171766 RVA: 0x009D0D4A File Offset: 0x009CEF4A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QuestTrigger_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06029EF7 RID: 171767 RVA: 0x009D0D60 File Offset: 0x009CEF60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			BP_QuestTrigger_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_QuestTrigger_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_QuestTrigger_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrigger_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029EF8 RID: 171768 RVA: 0x009D0DB8 File Offset: 0x009CEFB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorBeginOverlap_Implementation(AActor OtherActor)
		{
			BP_QuestTrigger_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_QuestTrigger_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_QuestTrigger_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrigger_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QuestTrigger_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06029EF9 RID: 171769 RVA: 0x009D0E10 File Offset: 0x009CF010
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_QuestTrigger_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_QuestTrigger_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_QuestTrigger_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029EFA RID: 171770 RVA: 0x009D0E58 File Offset: 0x009CF058
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_QuestTrigger_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_QuestTrigger_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_QuestTrigger_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QuestTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06029EFB RID: 171771 RVA: 0x009D0EA0 File Offset: 0x009CF0A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorEndOverlap(AActor OtherActor)
		{
			BP_QuestTrigger_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_QuestTrigger_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_QuestTrigger_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrigger_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029EFC RID: 171772 RVA: 0x009D0EF8 File Offset: 0x009CF0F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorEndOverlap_Implementation(AActor OtherActor)
		{
			BP_QuestTrigger_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_QuestTrigger_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_QuestTrigger_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrigger_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QuestTrigger_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06029EFD RID: 171773 RVA: 0x009D0F4E File Offset: 0x009CF14E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TimeDisplay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_C.__TimeDisplay_NativeFunctionPtr, null);
		}

		// Token: 0x06029EFE RID: 171774 RVA: 0x009D0F62 File Offset: 0x009CF162
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void QuestRequest()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_C.__QuestRequest_NativeFunctionPtr, null);
		}

		// Token: 0x06029EFF RID: 171775 RVA: 0x009D0F76 File Offset: 0x009CF176
		protected BP_QuestTrigger_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040158AA RID: 88234
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/QuestSystem/BP_QuestTrigger.BP_QuestTrigger_C";

		// Token: 0x040158AB RID: 88235
		private static IntPtr _ClassPtr;

		// Token: 0x040158AC RID: 88236
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040158AD RID: 88237
		internal static int __PropertyOffset_1;

		// Token: 0x040158AE RID: 88238
		internal static int __PropertyOffset_2;

		// Token: 0x040158AF RID: 88239
		internal static int __PropertyOffset_3;

		// Token: 0x040158B0 RID: 88240
		internal static int __PropertyOffset_4;

		// Token: 0x040158B1 RID: 88241
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SQuestRequest> _QuestTriggerInfo;

		// Token: 0x040158B2 RID: 88242
		internal static int __PropertyOffset_5;

		// Token: 0x040158B3 RID: 88243
		internal static int __PropertyOffset_6;

		// Token: 0x040158B4 RID: 88244
		internal static int __PropertyOffset_7;

		// Token: 0x040158B5 RID: 88245
		private FText _QuestDescription;

		// Token: 0x040158B6 RID: 88246
		internal static int __PropertyOffset_8;

		// Token: 0x040158B7 RID: 88247
		private FTimerHandle _timerhandler;

		// Token: 0x040158B8 RID: 88248
		internal static int __PropertyOffset_9;

		// Token: 0x040158B9 RID: 88249
		internal static int __PropertyOffset_10;

		// Token: 0x040158BA RID: 88250
		internal static int __PropertyOffset_11;

		// Token: 0x040158BB RID: 88251
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040158BC RID: 88252
		private static IntPtr __InpActEvt_G_K2Node_InputKeyEvent_0_NativeFunctionPtr;

		// Token: 0x040158BD RID: 88253
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040158BE RID: 88254
		private static IntPtr __ReceiveActorBeginOverlap_NativeFunctionPtr;

		// Token: 0x040158BF RID: 88255
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040158C0 RID: 88256
		private static IntPtr __ReceiveActorEndOverlap_NativeFunctionPtr;

		// Token: 0x040158C1 RID: 88257
		private static IntPtr __TimeDisplay_NativeFunctionPtr;

		// Token: 0x040158C2 RID: 88258
		private static IntPtr __QuestRequest_NativeFunctionPtr;

		// Token: 0x0200A309 RID: 41737
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_G_K2Node_InputKeyEvent_0_FunctionParams
		{
			// Token: 0x04032080 RID: 204928
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A30A RID: 41738
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorBeginOverlap_FunctionParams
		{
			// Token: 0x04032081 RID: 204929
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x0200A30B RID: 41739
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032082 RID: 204930
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A30C RID: 41740
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorEndOverlap_FunctionParams
		{
			// Token: 0x04032083 RID: 204931
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}
	}
}
