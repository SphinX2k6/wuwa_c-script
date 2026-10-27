using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core
{
	// Token: 0x02003FDC RID: 16348
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/BP_TestGameMode.BP_TestGameMode_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class BP_TestGameMode_C : AKuroSilenceGameMode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029DDC RID: 171484 RVA: 0x009CE460 File Offset: 0x009CC660
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TestGameMode_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/BP_TestGameMode.BP_TestGameMode_C");
			}
			return BP_TestGameMode_C._ClassPtr;
		}

		// Token: 0x06029DDD RID: 171485 RVA: 0x009CE484 File Offset: 0x009CC684
		public BP_TestGameMode_C() : this(BuiltinUtils.AllocNativeUObject(BP_TestGameMode_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029DDE RID: 171486 RVA: 0x009CE4AC File Offset: 0x009CC6AC
		public BP_TestGameMode_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TestGameMode_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700659B RID: 26011
		// (get) Token: 0x06029DDF RID: 171487 RVA: 0x009CE4DF File Offset: 0x009CC6DF
		// (set) Token: 0x06029DE0 RID: 171488 RVA: 0x009CE4F3 File Offset: 0x009CC6F3
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TestGameMode_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TestGameMode_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700659C RID: 26012
		// (get) Token: 0x06029DE1 RID: 171489 RVA: 0x009CE508 File Offset: 0x009CC708
		// (set) Token: 0x06029DE2 RID: 171490 RVA: 0x009CE51C File Offset: 0x009CC71C
		[Nullable(2)]
		public unsafe AActor StreamingSource
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TestGameMode_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TestGameMode_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700659D RID: 26013
		// (get) Token: 0x06029DE3 RID: 171491 RVA: 0x009CE534 File Offset: 0x009CC734
		// (set) Token: 0x06029DE4 RID: 171492 RVA: 0x009CE56D File Offset: 0x009CC76D
		public TArray<APlayerStart> PlayerStarts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<APlayerStart> result;
				if ((result = this._PlayerStarts) == null)
				{
					result = (this._PlayerStarts = new TArray<APlayerStart>(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.PlayerStarts.CopyAssign(value);
			}
		}

		// Token: 0x1700659E RID: 26014
		// (get) Token: 0x06029DE5 RID: 171493 RVA: 0x009CE57C File Offset: 0x009CC77C
		// (set) Token: 0x06029DE6 RID: 171494 RVA: 0x009CE5B5 File Offset: 0x009CC7B5
		public TArray<FWorldPartitionStreamingQuerySource> QuerySources
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWorldPartitionStreamingQuerySource> result;
				if ((result = this._QuerySources) == null)
				{
					result = (this._QuerySources = new TArray<FWorldPartitionStreamingQuerySource>(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.QuerySources.CopyAssign(value);
			}
		}

		// Token: 0x1700659F RID: 26015
		// (get) Token: 0x06029DE7 RID: 171495 RVA: 0x009CE5C4 File Offset: 0x009CC7C4
		// (set) Token: 0x06029DE8 RID: 171496 RVA: 0x009CE5FD File Offset: 0x009CC7FD
		public FTimerHandle Handler
		{
			get
			{
				base.FastCheckIsValid();
				FTimerHandle result;
				if ((result = this._Handler) == null)
				{
					result = (this._Handler = new FTimerHandle(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimerHandle.StaticStruct(), base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170065A0 RID: 26016
		// (get) Token: 0x06029DE9 RID: 171497 RVA: 0x009CE61E File Offset: 0x009CC81E
		// (set) Token: 0x06029DEA RID: 171498 RVA: 0x009CE62E File Offset: 0x009CC82E
		public unsafe bool IsMovieRenderQueueMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170065A1 RID: 26017
		// (get) Token: 0x06029DEB RID: 171499 RVA: 0x009CE63F File Offset: 0x009CC83F
		// (set) Token: 0x06029DEC RID: 171500 RVA: 0x009CE653 File Offset: 0x009CC853
		[Nullable(2)]
		public unsafe AActor StreamingSourceActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TestGameMode_C.__PropertyOffset_8);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TestGameMode_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170065A2 RID: 26018
		// (get) Token: 0x06029DED RID: 171501 RVA: 0x009CE668 File Offset: 0x009CC868
		// (set) Token: 0x06029DEE RID: 171502 RVA: 0x009CE678 File Offset: 0x009CC878
		public unsafe bool IsLoginServerReady
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170065A3 RID: 26019
		// (get) Token: 0x06029DEF RID: 171503 RVA: 0x009CE689 File Offset: 0x009CC889
		// (set) Token: 0x06029DF0 RID: 171504 RVA: 0x009CE699 File Offset: 0x009CC899
		public unsafe bool IsWaitingLoginHttpResponse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170065A4 RID: 26020
		// (get) Token: 0x06029DF1 RID: 171505 RVA: 0x009CE6AA File Offset: 0x009CC8AA
		// (set) Token: 0x06029DF2 RID: 171506 RVA: 0x009CE6BE File Offset: 0x009CC8BE
		public unsafe string LoginUrl
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_TestGameMode_C.__PropertyOffset_11)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_TestGameMode_C.__PropertyOffset_11)), value);
			}
		}

		// Token: 0x170065A5 RID: 26021
		// (get) Token: 0x06029DF3 RID: 171507 RVA: 0x009CE6D3 File Offset: 0x009CC8D3
		// (set) Token: 0x06029DF4 RID: 171508 RVA: 0x009CE6E3 File Offset: 0x009CC8E3
		public unsafe bool IsWaitingApiHttpResponse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170065A6 RID: 26022
		// (get) Token: 0x06029DF5 RID: 171509 RVA: 0x009CE6F4 File Offset: 0x009CC8F4
		// (set) Token: 0x06029DF6 RID: 171510 RVA: 0x009CE704 File Offset: 0x009CC904
		public unsafe bool IsApiServerReady
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170065A7 RID: 26023
		// (get) Token: 0x06029DF7 RID: 171511 RVA: 0x009CE715 File Offset: 0x009CC915
		// (set) Token: 0x06029DF8 RID: 171512 RVA: 0x009CE729 File Offset: 0x009CC929
		public unsafe string ApiUrl
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_TestGameMode_C.__PropertyOffset_14)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_TestGameMode_C.__PropertyOffset_14)), value);
			}
		}

		// Token: 0x170065A8 RID: 26024
		// (get) Token: 0x06029DF9 RID: 171513 RVA: 0x009CE73E File Offset: 0x009CC93E
		// (set) Token: 0x06029DFA RID: 171514 RVA: 0x009CE74E File Offset: 0x009CC94E
		public unsafe bool bTriggerLoginOnce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x170065A9 RID: 26025
		// (get) Token: 0x06029DFB RID: 171515 RVA: 0x009CE760 File Offset: 0x009CC960
		// (set) Token: 0x06029DFC RID: 171516 RVA: 0x009CE799 File Offset: 0x009CC999
		public TMap<string, string> LevelNameMapping
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._LevelNameMapping) == null)
				{
					result = (this._LevelNameMapping = new TMap<string, string>(base.NativePtr + (IntPtr)BP_TestGameMode_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				this.LevelNameMapping.CopyAssign(value);
			}
		}

		// Token: 0x06029DFD RID: 171517 RVA: 0x009CE7A8 File Offset: 0x009CC9A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetServerIpAndPort(ref string ServerIp, ref string ApiServerPort, ref string LoginServerPort)
		{
			BP_TestGameMode_C.__GetServerIpAndPort_FunctionParams* ptr = stackalloc BP_TestGameMode_C.__GetServerIpAndPort_FunctionParams[(UIntPtr)335] + 15L / (long)sizeof(BP_TestGameMode_C.__GetServerIpAndPort_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TestGameMode_C.__GetServerIpAndPort_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ServerIp), ServerIp);
			FString.CopyFrom((void*)(&ptr->ApiServerPort), ApiServerPort);
			FString.CopyFrom((void*)(&ptr->LoginServerPort), LoginServerPort);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TestGameMode_C.__GetServerIpAndPort_NativeFunctionPtr, (void*)ptr);
			ServerIp = FString.ToString((void*)(&ptr->ServerIp));
			ApiServerPort = FString.ToString((void*)(&ptr->ApiServerPort));
			LoginServerPort = FString.ToString((void*)(&ptr->LoginServerPort));
			UnrealReflectionUtils.DestroyStruct(BP_TestGameMode_C.__GetServerIpAndPort_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029DFE RID: 171518 RVA: 0x009CE84F File Offset: 0x009CCA4F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DelayStreamingSource()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TestGameMode_C.__DelayStreamingSource_NativeFunctionPtr, null);
		}

		// Token: 0x06029DFF RID: 171519 RVA: 0x009CE863 File Offset: 0x009CCA63
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StreamingCompleted()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TestGameMode_C.__StreamingCompleted_NativeFunctionPtr, null);
		}

		// Token: 0x06029E00 RID: 171520 RVA: 0x009CE878 File Offset: 0x009CCA78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Player_Starts(ref bool Exist, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<APlayerStart> PlayerStarts)
		{
			BP_TestGameMode_C.__Get_Player_Starts_FunctionParams* ptr = stackalloc BP_TestGameMode_C.__Get_Player_Starts_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_TestGameMode_C.__Get_Player_Starts_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TestGameMode_C.__Get_Player_Starts_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Exist = Exist;
			TArray<APlayerStart> tarray = PlayerStarts;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->PlayerStarts);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TestGameMode_C.__Get_Player_Starts_NativeFunctionPtr, (void*)ptr);
			Exist = ptr->Exist;
			TArray<APlayerStart> tarray2 = PlayerStarts;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->PlayerStarts);
			}
			UnrealReflectionUtils.DestroyStruct(BP_TestGameMode_C.__Get_Player_Starts_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029E01 RID: 171521 RVA: 0x009CE900 File Offset: 0x009CCB00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CheckStreamingHandler()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TestGameMode_C.__CheckStreamingHandler_NativeFunctionPtr, null);
		}

		// Token: 0x06029E02 RID: 171522 RVA: 0x009CE914 File Offset: 0x009CCB14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Check()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TestGameMode_C.__Check_NativeFunctionPtr, null);
		}

		// Token: 0x06029E03 RID: 171523 RVA: 0x009CE928 File Offset: 0x009CCB28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TestGameMode_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06029E04 RID: 171524 RVA: 0x009CE93C File Offset: 0x009CCB3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TestGameMode_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06029E05 RID: 171525 RVA: 0x009CE954 File Offset: 0x009CCB54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_TestGameMode_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TestGameMode_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TestGameMode_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TestGameMode_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TestGameMode_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029E06 RID: 171526 RVA: 0x009CE99C File Offset: 0x009CCB9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_TestGameMode_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TestGameMode_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TestGameMode_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TestGameMode_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TestGameMode_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06029E07 RID: 171527 RVA: 0x009CE9E4 File Offset: 0x009CCBE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LoginServerStatusResponse(bool bConnectedSuccessfully, int HttpResponseCode, string Data)
		{
			BP_TestGameMode_C.__LoginServerStatusResponse_FunctionParams* ptr = stackalloc BP_TestGameMode_C.__LoginServerStatusResponse_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_TestGameMode_C.__LoginServerStatusResponse_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TestGameMode_C.__LoginServerStatusResponse_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bConnectedSuccessfully = bConnectedSuccessfully;
			ptr->HttpResponseCode = HttpResponseCode;
			FString.CopyFrom((void*)(&ptr->Data), Data);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TestGameMode_C.__LoginServerStatusResponse_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_TestGameMode_C.__LoginServerStatusResponse_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029E08 RID: 171528 RVA: 0x009CEA50 File Offset: 0x009CCC50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ApiServereStatusResponse(bool bConnectedSuccessfully, int HttpResponseCode, string Data)
		{
			BP_TestGameMode_C.__ApiServereStatusResponse_FunctionParams* ptr = stackalloc BP_TestGameMode_C.__ApiServereStatusResponse_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_TestGameMode_C.__ApiServereStatusResponse_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TestGameMode_C.__ApiServereStatusResponse_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bConnectedSuccessfully = bConnectedSuccessfully;
			ptr->HttpResponseCode = HttpResponseCode;
			FString.CopyFrom((void*)(&ptr->Data), Data);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TestGameMode_C.__ApiServereStatusResponse_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_TestGameMode_C.__ApiServereStatusResponse_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029E09 RID: 171529 RVA: 0x009CEABB File Offset: 0x009CCCBB
		protected BP_TestGameMode_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015802 RID: 88066
		public new const string __ObjectPath = "/Game/Aki/Core/BP_TestGameMode.BP_TestGameMode_C";

		// Token: 0x04015803 RID: 88067
		private static IntPtr _ClassPtr;

		// Token: 0x04015804 RID: 88068
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015805 RID: 88069
		internal static int __PropertyOffset_1;

		// Token: 0x04015806 RID: 88070
		internal static int __PropertyOffset_2;

		// Token: 0x04015807 RID: 88071
		internal static int __PropertyOffset_3;

		// Token: 0x04015808 RID: 88072
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<APlayerStart> _PlayerStarts;

		// Token: 0x04015809 RID: 88073
		internal static int __PropertyOffset_4;

		// Token: 0x0401580A RID: 88074
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWorldPartitionStreamingQuerySource> _QuerySources;

		// Token: 0x0401580B RID: 88075
		internal static int __PropertyOffset_5;

		// Token: 0x0401580C RID: 88076
		[Nullable(2)]
		private FTimerHandle _Handler;

		// Token: 0x0401580D RID: 88077
		internal static int __PropertyOffset_6;

		// Token: 0x0401580E RID: 88078
		internal static int __PropertyOffset_7;

		// Token: 0x0401580F RID: 88079
		internal static int __PropertyOffset_8;

		// Token: 0x04015810 RID: 88080
		internal static int __PropertyOffset_9;

		// Token: 0x04015811 RID: 88081
		internal static int __PropertyOffset_10;

		// Token: 0x04015812 RID: 88082
		internal static int __PropertyOffset_11;

		// Token: 0x04015813 RID: 88083
		internal static int __PropertyOffset_12;

		// Token: 0x04015814 RID: 88084
		internal static int __PropertyOffset_13;

		// Token: 0x04015815 RID: 88085
		internal static int __PropertyOffset_14;

		// Token: 0x04015816 RID: 88086
		internal static int __PropertyOffset_15;

		// Token: 0x04015817 RID: 88087
		internal static int __PropertyOffset_16;

		// Token: 0x04015818 RID: 88088
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _LevelNameMapping;

		// Token: 0x04015819 RID: 88089
		private static IntPtr __GetServerIpAndPort_NativeFunctionPtr;

		// Token: 0x0401581A RID: 88090
		private static IntPtr __DelayStreamingSource_NativeFunctionPtr;

		// Token: 0x0401581B RID: 88091
		private static IntPtr __StreamingCompleted_NativeFunctionPtr;

		// Token: 0x0401581C RID: 88092
		private static IntPtr __Get_Player_Starts_NativeFunctionPtr;

		// Token: 0x0401581D RID: 88093
		private static IntPtr __CheckStreamingHandler_NativeFunctionPtr;

		// Token: 0x0401581E RID: 88094
		private static IntPtr __Check_NativeFunctionPtr;

		// Token: 0x0401581F RID: 88095
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04015820 RID: 88096
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04015821 RID: 88097
		private static IntPtr __LoginServerStatusResponse_NativeFunctionPtr;

		// Token: 0x04015822 RID: 88098
		private static IntPtr __ApiServereStatusResponse_NativeFunctionPtr;

		// Token: 0x0200A2E7 RID: 41703
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 320)]
		protected ref struct __GetServerIpAndPort_FunctionParams
		{
			// Token: 0x04032035 RID: 204853
			[FieldOffset(0)]
			public FString ServerIp;

			// Token: 0x04032036 RID: 204854
			[FieldOffset(16)]
			public FString ApiServerPort;

			// Token: 0x04032037 RID: 204855
			[FieldOffset(32)]
			public FString LoginServerPort;
		}

		// Token: 0x0200A2E8 RID: 41704
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __Get_Player_Starts_FunctionParams
		{
			// Token: 0x04032038 RID: 204856
			[FieldOffset(0)]
			public bool Exist;

			// Token: 0x04032039 RID: 204857
			[FieldOffset(8)]
			public byte PlayerStarts;
		}

		// Token: 0x0200A2E9 RID: 41705
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403203A RID: 204858
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A2EA RID: 41706
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __LoginServerStatusResponse_FunctionParams
		{
			// Token: 0x0403203B RID: 204859
			[FieldOffset(0)]
			public bool bConnectedSuccessfully;

			// Token: 0x0403203C RID: 204860
			[FieldOffset(4)]
			public int HttpResponseCode;

			// Token: 0x0403203D RID: 204861
			[FieldOffset(8)]
			public FString Data;
		}

		// Token: 0x0200A2EB RID: 41707
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ApiServereStatusResponse_FunctionParams
		{
			// Token: 0x0403203E RID: 204862
			[FieldOffset(0)]
			public bool bConnectedSuccessfully;

			// Token: 0x0403203F RID: 204863
			[FieldOffset(4)]
			public int HttpResponseCode;

			// Token: 0x04032040 RID: 204864
			[FieldOffset(8)]
			public FString Data;
		}
	}
}
