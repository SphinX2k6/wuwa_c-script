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
	// Token: 0x02003FEA RID: 16362
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/QuestSystem/BP_QuestTrigger_BOX.BP_QuestTrigger_BOX_C")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public class BP_QuestTrigger_BOX_C : ATriggerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029EB0 RID: 171696 RVA: 0x009D0447 File Offset: 0x009CE647
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_QuestTrigger_BOX_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/QuestSystem/BP_QuestTrigger_BOX.BP_QuestTrigger_BOX_C");
			}
			return BP_QuestTrigger_BOX_C._ClassPtr;
		}

		// Token: 0x06029EB1 RID: 171697 RVA: 0x009D046C File Offset: 0x009CE66C
		public BP_QuestTrigger_BOX_C() : this(BuiltinUtils.AllocNativeUObject(BP_QuestTrigger_BOX_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029EB2 RID: 171698 RVA: 0x009D0494 File Offset: 0x009CE694
		[NullableContext(1)]
		public BP_QuestTrigger_BOX_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_QuestTrigger_BOX_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170065CB RID: 26059
		// (get) Token: 0x06029EB3 RID: 171699 RVA: 0x009D04C7 File Offset: 0x009CE6C7
		// (set) Token: 0x06029EB4 RID: 171700 RVA: 0x009D04DB File Offset: 0x009CE6DB
		public unsafe UBoxComponent CollisonBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrigger_BOX_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrigger_BOX_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170065CC RID: 26060
		// (get) Token: 0x06029EB5 RID: 171701 RVA: 0x009D04F0 File Offset: 0x009CE6F0
		// (set) Token: 0x06029EB6 RID: 171702 RVA: 0x009D0504 File Offset: 0x009CE704
		public unsafe UTextRenderComponent TextRenderTime
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrigger_BOX_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrigger_BOX_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170065CD RID: 26061
		// (get) Token: 0x06029EB7 RID: 171703 RVA: 0x009D0519 File Offset: 0x009CE719
		// (set) Token: 0x06029EB8 RID: 171704 RVA: 0x009D052D File Offset: 0x009CE72D
		public unsafe UTextRenderComponent TextRenderDes
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrigger_BOX_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrigger_BOX_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170065CE RID: 26062
		// (get) Token: 0x06029EB9 RID: 171705 RVA: 0x009D0542 File Offset: 0x009CE742
		// (set) Token: 0x06029EBA RID: 171706 RVA: 0x009D0556 File Offset: 0x009CE756
		public unsafe AActor player
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrigger_BOX_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrigger_BOX_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170065CF RID: 26063
		// (get) Token: 0x06029EBB RID: 171707 RVA: 0x009D056C File Offset: 0x009CE76C
		// (set) Token: 0x06029EBC RID: 171708 RVA: 0x009D05A5 File Offset: 0x009CE7A5
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
					result = (this._QuestTriggerInfo = new TArray<SQuestRequest>(base.NativePtr + (IntPtr)BP_QuestTrigger_BOX_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.QuestTriggerInfo.CopyAssign(value);
			}
		}

		// Token: 0x170065D0 RID: 26064
		// (get) Token: 0x06029EBD RID: 171709 RVA: 0x009D05B3 File Offset: 0x009CE7B3
		// (set) Token: 0x06029EBE RID: 171710 RVA: 0x009D05C3 File Offset: 0x009CE7C3
		public unsafe int currindex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrigger_BOX_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrigger_BOX_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170065D1 RID: 26065
		// (get) Token: 0x06029EBF RID: 171711 RVA: 0x009D05D4 File Offset: 0x009CE7D4
		// (set) Token: 0x06029EC0 RID: 171712 RVA: 0x009D05E4 File Offset: 0x009CE7E4
		public unsafe bool bIsEnableInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrigger_BOX_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrigger_BOX_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170065D2 RID: 26066
		// (get) Token: 0x06029EC1 RID: 171713 RVA: 0x009D05F8 File Offset: 0x009CE7F8
		// (set) Token: 0x06029EC2 RID: 171714 RVA: 0x009D0631 File Offset: 0x009CE831
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
					result = (this._QuestDescription = new FText(base.NativePtr + (IntPtr)BP_QuestTrigger_BOX_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)BP_QuestTrigger_BOX_C.__PropertyOffset_8)), value.NativePtr, 1);
			}
		}

		// Token: 0x170065D3 RID: 26067
		// (get) Token: 0x06029EC3 RID: 171715 RVA: 0x009D064C File Offset: 0x009CE84C
		// (set) Token: 0x06029EC4 RID: 171716 RVA: 0x009D0685 File Offset: 0x009CE885
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
					result = (this._timerhandler = new FTimerHandle(base.NativePtr + (IntPtr)BP_QuestTrigger_BOX_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimerHandle.StaticStruct(), base.NativePtr + (IntPtr)BP_QuestTrigger_BOX_C.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170065D4 RID: 26068
		// (get) Token: 0x06029EC5 RID: 171717 RVA: 0x009D06A6 File Offset: 0x009CE8A6
		// (set) Token: 0x06029EC6 RID: 171718 RVA: 0x009D06B6 File Offset: 0x009CE8B6
		public unsafe bool bIsEnableDisplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrigger_BOX_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrigger_BOX_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170065D5 RID: 26069
		// (get) Token: 0x06029EC7 RID: 171719 RVA: 0x009D06C7 File Offset: 0x009CE8C7
		// (set) Token: 0x06029EC8 RID: 171720 RVA: 0x009D06D7 File Offset: 0x009CE8D7
		public unsafe bool bIsAutoTriggered
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrigger_BOX_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrigger_BOX_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170065D6 RID: 26070
		// (get) Token: 0x06029EC9 RID: 171721 RVA: 0x009D06E8 File Offset: 0x009CE8E8
		// (set) Token: 0x06029ECA RID: 171722 RVA: 0x009D06FC File Offset: 0x009CE8FC
		public unsafe FColor DescriptionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrigger_BOX_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrigger_BOX_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x06029ECB RID: 171723 RVA: 0x009D0711 File Offset: 0x009CE911
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_BOX_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06029ECC RID: 171724 RVA: 0x009D0725 File Offset: 0x009CE925
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QuestTrigger_BOX_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06029ECD RID: 171725 RVA: 0x009D073C File Offset: 0x009CE93C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_G_K2Node_InputKeyEvent_0(FKey Key)
		{
			BP_QuestTrigger_BOX_C.__InpActEvt_G_K2Node_InputKeyEvent_0_FunctionParams* ptr = stackalloc BP_QuestTrigger_BOX_C.__InpActEvt_G_K2Node_InputKeyEvent_0_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_QuestTrigger_BOX_C.__InpActEvt_G_K2Node_InputKeyEvent_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrigger_BOX_C.__InpActEvt_G_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_BOX_C.__InpActEvt_G_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_QuestTrigger_BOX_C.__InpActEvt_G_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029ECE RID: 171726 RVA: 0x009D07AE File Offset: 0x009CE9AE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_BOX_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06029ECF RID: 171727 RVA: 0x009D07C2 File Offset: 0x009CE9C2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QuestTrigger_BOX_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06029ED0 RID: 171728 RVA: 0x009D07D8 File Offset: 0x009CE9D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			BP_QuestTrigger_BOX_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_QuestTrigger_BOX_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_QuestTrigger_BOX_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrigger_BOX_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_BOX_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029ED1 RID: 171729 RVA: 0x009D0830 File Offset: 0x009CEA30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorBeginOverlap_Implementation(AActor OtherActor)
		{
			BP_QuestTrigger_BOX_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_QuestTrigger_BOX_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_QuestTrigger_BOX_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrigger_BOX_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QuestTrigger_BOX_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06029ED2 RID: 171730 RVA: 0x009D0888 File Offset: 0x009CEA88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_QuestTrigger_BOX_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_QuestTrigger_BOX_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_QuestTrigger_BOX_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrigger_BOX_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_BOX_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029ED3 RID: 171731 RVA: 0x009D08D0 File Offset: 0x009CEAD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_QuestTrigger_BOX_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_QuestTrigger_BOX_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_QuestTrigger_BOX_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrigger_BOX_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QuestTrigger_BOX_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06029ED4 RID: 171732 RVA: 0x009D0918 File Offset: 0x009CEB18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorEndOverlap(AActor OtherActor)
		{
			BP_QuestTrigger_BOX_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_QuestTrigger_BOX_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_QuestTrigger_BOX_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrigger_BOX_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_BOX_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029ED5 RID: 171733 RVA: 0x009D0970 File Offset: 0x009CEB70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorEndOverlap_Implementation(AActor OtherActor)
		{
			BP_QuestTrigger_BOX_C.__ReceiveActorEndOverlap_FunctionParams* ptr = stackalloc BP_QuestTrigger_BOX_C.__ReceiveActorEndOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_QuestTrigger_BOX_C.__ReceiveActorEndOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrigger_BOX_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QuestTrigger_BOX_C.__ReceiveActorEndOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06029ED6 RID: 171734 RVA: 0x009D09C6 File Offset: 0x009CEBC6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TimeDisplay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_BOX_C.__TimeDisplay_NativeFunctionPtr, null);
		}

		// Token: 0x06029ED7 RID: 171735 RVA: 0x009D09DA File Offset: 0x009CEBDA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void QuestRequest()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrigger_BOX_C.__QuestRequest_NativeFunctionPtr, null);
		}

		// Token: 0x06029ED8 RID: 171736 RVA: 0x009D09EE File Offset: 0x009CEBEE
		protected BP_QuestTrigger_BOX_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015890 RID: 88208
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/QuestSystem/BP_QuestTrigger_BOX.BP_QuestTrigger_BOX_C";

		// Token: 0x04015891 RID: 88209
		private static IntPtr _ClassPtr;

		// Token: 0x04015892 RID: 88210
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015893 RID: 88211
		internal static int __PropertyOffset_1;

		// Token: 0x04015894 RID: 88212
		internal static int __PropertyOffset_2;

		// Token: 0x04015895 RID: 88213
		internal static int __PropertyOffset_3;

		// Token: 0x04015896 RID: 88214
		internal static int __PropertyOffset_4;

		// Token: 0x04015897 RID: 88215
		internal static int __PropertyOffset_5;

		// Token: 0x04015898 RID: 88216
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SQuestRequest> _QuestTriggerInfo;

		// Token: 0x04015899 RID: 88217
		internal static int __PropertyOffset_6;

		// Token: 0x0401589A RID: 88218
		internal static int __PropertyOffset_7;

		// Token: 0x0401589B RID: 88219
		internal static int __PropertyOffset_8;

		// Token: 0x0401589C RID: 88220
		private FText _QuestDescription;

		// Token: 0x0401589D RID: 88221
		internal static int __PropertyOffset_9;

		// Token: 0x0401589E RID: 88222
		private FTimerHandle _timerhandler;

		// Token: 0x0401589F RID: 88223
		internal static int __PropertyOffset_10;

		// Token: 0x040158A0 RID: 88224
		internal static int __PropertyOffset_11;

		// Token: 0x040158A1 RID: 88225
		internal static int __PropertyOffset_12;

		// Token: 0x040158A2 RID: 88226
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040158A3 RID: 88227
		private static IntPtr __InpActEvt_G_K2Node_InputKeyEvent_0_NativeFunctionPtr;

		// Token: 0x040158A4 RID: 88228
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040158A5 RID: 88229
		private static IntPtr __ReceiveActorBeginOverlap_NativeFunctionPtr;

		// Token: 0x040158A6 RID: 88230
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040158A7 RID: 88231
		private static IntPtr __ReceiveActorEndOverlap_NativeFunctionPtr;

		// Token: 0x040158A8 RID: 88232
		private static IntPtr __TimeDisplay_NativeFunctionPtr;

		// Token: 0x040158A9 RID: 88233
		private static IntPtr __QuestRequest_NativeFunctionPtr;

		// Token: 0x0200A305 RID: 41733
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_G_K2Node_InputKeyEvent_0_FunctionParams
		{
			// Token: 0x0403207C RID: 204924
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A306 RID: 41734
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorBeginOverlap_FunctionParams
		{
			// Token: 0x0403207D RID: 204925
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x0200A307 RID: 41735
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403207E RID: 204926
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A308 RID: 41736
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorEndOverlap_FunctionParams
		{
			// Token: 0x0403207F RID: 204927
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}
	}
}
