using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime.Sensors;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime
{
	// Token: 0x02003AAA RID: 15018
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/BP_TrailsManager.BP_TrailsManager_C")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1234)]
	public class BP_TrailsManager_C : AKuroHighResLandscapeActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602027E RID: 131710 RVA: 0x008CB2F9 File Offset: 0x008C94F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrailsManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/BP_TrailsManager.BP_TrailsManager_C");
			}
			return BP_TrailsManager_C._ClassPtr;
		}

		// Token: 0x0602027F RID: 131711 RVA: 0x008CB320 File Offset: 0x008C9520
		public BP_TrailsManager_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrailsManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020280 RID: 131712 RVA: 0x008CB348 File Offset: 0x008C9548
		public BP_TrailsManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrailsManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F3D RID: 12093
		// (get) Token: 0x06020281 RID: 131713 RVA: 0x008CB37B File Offset: 0x008C957B
		// (set) Token: 0x06020282 RID: 131714 RVA: 0x008CB38F File Offset: 0x008C958F
		[Nullable(2)]
		public unsafe UBillboardComponent Billboard
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailsManager_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailsManager_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002F3E RID: 12094
		// (get) Token: 0x06020283 RID: 131715 RVA: 0x008CB3A4 File Offset: 0x008C95A4
		// (set) Token: 0x06020284 RID: 131716 RVA: 0x008CB3B8 File Offset: 0x008C95B8
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailsManager_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailsManager_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002F3F RID: 12095
		// (get) Token: 0x06020285 RID: 131717 RVA: 0x008CB3D0 File Offset: 0x008C95D0
		// (set) Token: 0x06020286 RID: 131718 RVA: 0x008CB409 File Offset: 0x008C9609
		public TArray<BP_TrailDrawComponent_C> Drawers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_TrailDrawComponent_C> result;
				if ((result = this._Drawers) == null)
				{
					result = (this._Drawers = new TArray<BP_TrailDrawComponent_C>(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.Drawers.CopyAssign(value);
			}
		}

		// Token: 0x17002F40 RID: 12096
		// (get) Token: 0x06020287 RID: 131719 RVA: 0x008CB418 File Offset: 0x008C9618
		// (set) Token: 0x06020288 RID: 131720 RVA: 0x008CB451 File Offset: 0x008C9651
		public TArray<BP_TrailSensorActor_C> TrailFields
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_TrailSensorActor_C> result;
				if ((result = this._TrailFields) == null)
				{
					result = (this._TrailFields = new TArray<BP_TrailSensorActor_C>(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.TrailFields.CopyAssign(value);
			}
		}

		// Token: 0x17002F41 RID: 12097
		// (get) Token: 0x06020289 RID: 131721 RVA: 0x008CB45F File Offset: 0x008C965F
		// (set) Token: 0x0602028A RID: 131722 RVA: 0x008CB473 File Offset: 0x008C9673
		public unsafe FVector2D Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002F42 RID: 12098
		// (get) Token: 0x0602028B RID: 131723 RVA: 0x008CB488 File Offset: 0x008C9688
		// (set) Token: 0x0602028C RID: 131724 RVA: 0x008CB498 File Offset: 0x008C9698
		public unsafe float Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002F43 RID: 12099
		// (get) Token: 0x0602028D RID: 131725 RVA: 0x008CB4A9 File Offset: 0x008C96A9
		// (set) Token: 0x0602028E RID: 131726 RVA: 0x008CB4BD File Offset: 0x008C96BD
		public unsafe FVector2D DrawSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002F44 RID: 12100
		// (get) Token: 0x0602028F RID: 131727 RVA: 0x008CB4D4 File Offset: 0x008C96D4
		// (set) Token: 0x06020290 RID: 131728 RVA: 0x008CB50D File Offset: 0x008C970D
		public TArray<STrailDrawInfo> DrawInfo
		{
			get
			{
				base.FastCheckIsValid();
				TArray<STrailDrawInfo> result;
				if ((result = this._DrawInfo) == null)
				{
					result = (this._DrawInfo = new TArray<STrailDrawInfo>(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				this.DrawInfo.CopyAssign(value);
			}
		}

		// Token: 0x17002F45 RID: 12101
		// (get) Token: 0x06020291 RID: 131729 RVA: 0x008CB51B File Offset: 0x008C971B
		// (set) Token: 0x06020292 RID: 131730 RVA: 0x008CB52B File Offset: 0x008C972B
		public unsafe bool ShouldDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x06020293 RID: 131731 RVA: 0x008CB53C File Offset: 0x008C973C
		// (set) Token: 0x06020294 RID: 131732 RVA: 0x008CB54C File Offset: 0x008C974C
		public unsafe float PixelWidth_Save
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002F47 RID: 12103
		// (get) Token: 0x06020295 RID: 131733 RVA: 0x008CB55D File Offset: 0x008C975D
		// (set) Token: 0x06020296 RID: 131734 RVA: 0x008CB56D File Offset: 0x008C976D
		public unsafe float PixelWidth_Blur
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002F48 RID: 12104
		// (get) Token: 0x06020297 RID: 131735 RVA: 0x008CB57E File Offset: 0x008C977E
		// (set) Token: 0x06020298 RID: 131736 RVA: 0x008CB58E File Offset: 0x008C978E
		public unsafe float EdgeWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002F49 RID: 12105
		// (get) Token: 0x06020299 RID: 131737 RVA: 0x008CB59F File Offset: 0x008C979F
		// (set) Token: 0x0602029A RID: 131738 RVA: 0x008CB5AF File Offset: 0x008C97AF
		public unsafe float BlurWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17002F4A RID: 12106
		// (get) Token: 0x0602029B RID: 131739 RVA: 0x008CB5C0 File Offset: 0x008C97C0
		// (set) Token: 0x0602029C RID: 131740 RVA: 0x008CB5D0 File Offset: 0x008C97D0
		public unsafe float PixelWidth_Capture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002F4B RID: 12107
		// (get) Token: 0x0602029D RID: 131741 RVA: 0x008CB5E4 File Offset: 0x008C97E4
		// (set) Token: 0x0602029E RID: 131742 RVA: 0x008CB61D File Offset: 0x008C981D
		public TArray<BP_TrailSensorActor_C> TrailFields_NeedRemove
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_TrailSensorActor_C> result;
				if ((result = this._TrailFields_NeedRemove) == null)
				{
					result = (this._TrailFields_NeedRemove = new TArray<BP_TrailSensorActor_C>(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				this.TrailFields_NeedRemove.CopyAssign(value);
			}
		}

		// Token: 0x17002F4C RID: 12108
		// (get) Token: 0x0602029F RID: 131743 RVA: 0x008CB62B File Offset: 0x008C982B
		// (set) Token: 0x060202A0 RID: 131744 RVA: 0x008CB63B File Offset: 0x008C983B
		public unsafe bool DebugLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F4D RID: 12109
		// (get) Token: 0x060202A1 RID: 131745 RVA: 0x008CB64C File Offset: 0x008C984C
		// (set) Token: 0x060202A2 RID: 131746 RVA: 0x008CB65C File Offset: 0x008C985C
		public unsafe bool ActiveHighResLandscape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F4E RID: 12110
		// (get) Token: 0x060202A3 RID: 131747 RVA: 0x008CB670 File Offset: 0x008C9870
		// (set) Token: 0x060202A4 RID: 131748 RVA: 0x008CB6A9 File Offset: 0x008C98A9
		public TArray<ALandscapeStreamingProxy> LowLandscapes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ALandscapeStreamingProxy> result;
				if ((result = this._LowLandscapes) == null)
				{
					result = (this._LowLandscapes = new TArray<ALandscapeStreamingProxy>(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_18, this));
				}
				return result;
			}
			set
			{
				this.LowLandscapes.CopyAssign(value);
			}
		}

		// Token: 0x17002F4F RID: 12111
		// (get) Token: 0x060202A5 RID: 131749 RVA: 0x008CB6B8 File Offset: 0x008C98B8
		// (set) Token: 0x060202A6 RID: 131750 RVA: 0x008CB6F1 File Offset: 0x008C98F1
		public TArray<ALandscapeStreamingProxy> HighLandscapes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ALandscapeStreamingProxy> result;
				if ((result = this._HighLandscapes) == null)
				{
					result = (this._HighLandscapes = new TArray<ALandscapeStreamingProxy>(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				this.HighLandscapes.CopyAssign(value);
			}
		}

		// Token: 0x17002F50 RID: 12112
		// (get) Token: 0x060202A7 RID: 131751 RVA: 0x008CB6FF File Offset: 0x008C98FF
		// (set) Token: 0x060202A8 RID: 131752 RVA: 0x008CB70F File Offset: 0x008C990F
		public unsafe bool LandscapeDirty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F51 RID: 12113
		// (get) Token: 0x060202A9 RID: 131753 RVA: 0x008CB720 File Offset: 0x008C9920
		// (set) Token: 0x060202AA RID: 131754 RVA: 0x008CB730 File Offset: 0x008C9930
		public unsafe bool Old_Enabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailsManager_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x060202AB RID: 131755 RVA: 0x008CB741 File Offset: 0x008C9941
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void test()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailsManager_C.__test_NativeFunctionPtr, null);
		}

		// Token: 0x060202AC RID: 131756 RVA: 0x008CB755 File Offset: 0x008C9955
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateLandscapes()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailsManager_C.__UpdateLandscapes_NativeFunctionPtr, null);
		}

		// Token: 0x060202AD RID: 131757 RVA: 0x008CB76C File Offset: 0x008C996C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetTag([Nullable(2)] ALandscapeStreamingProxy Proxy, int Index, ref string Tag)
		{
			BP_TrailsManager_C.__GetTag_FunctionParams* ptr = stackalloc BP_TrailsManager_C.__GetTag_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_TrailsManager_C.__GetTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailsManager_C.__GetTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Proxy = ((Proxy != null) ? Proxy.NativePtr : IntPtr.Zero);
			ptr->Index = Index;
			FString.CopyFrom((void*)(&ptr->Tag), Tag);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailsManager_C.__GetTag_NativeFunctionPtr, (void*)ptr);
			Tag = FString.ToString((void*)(&ptr->Tag));
			UnrealReflectionUtils.DestroyStruct(BP_TrailsManager_C.__GetTag_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060202AE RID: 131758 RVA: 0x008CB7F8 File Offset: 0x008C99F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ContainsTag(ALandscapeStreamingProxy Actor, FName Str, ref bool Ret, ref int Index)
		{
			BP_TrailsManager_C.__ContainsTag_FunctionParams* ptr = stackalloc BP_TrailsManager_C.__ContainsTag_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_TrailsManager_C.__ContainsTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailsManager_C.__ContainsTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->Str = Str;
			ptr->Ret = Ret;
			ptr->Index = Index;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailsManager_C.__ContainsTag_NativeFunctionPtr, (void*)ptr);
			Ret = ptr->Ret;
			Index = ptr->Index;
		}

		// Token: 0x060202AF RID: 131759 RVA: 0x008CB878 File Offset: 0x008C9A78
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HideProxy(ALandscapeStreamingProxy Proxy)
		{
			BP_TrailsManager_C.__HideProxy_FunctionParams* ptr = stackalloc BP_TrailsManager_C.__HideProxy_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_TrailsManager_C.__HideProxy_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailsManager_C.__HideProxy_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Proxy = ((Proxy != null) ? Proxy.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailsManager_C.__HideProxy_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060202B0 RID: 131760 RVA: 0x008CB8D0 File Offset: 0x008C9AD0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ShowProxy(ALandscapeStreamingProxy Proxy)
		{
			BP_TrailsManager_C.__ShowProxy_FunctionParams* ptr = stackalloc BP_TrailsManager_C.__ShowProxy_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_TrailsManager_C.__ShowProxy_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailsManager_C.__ShowProxy_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Proxy = ((Proxy != null) ? Proxy.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailsManager_C.__ShowProxy_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060202B1 RID: 131761 RVA: 0x008CB928 File Offset: 0x008C9B28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsEnable(ref bool IsEnable)
		{
			BP_TrailsManager_C.__IsEnable_FunctionParams* ptr = stackalloc BP_TrailsManager_C.__IsEnable_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(BP_TrailsManager_C.__IsEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailsManager_C.__IsEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEnable = IsEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailsManager_C.__IsEnable_NativeFunctionPtr, (void*)ptr);
			IsEnable = ptr->IsEnable;
		}

		// Token: 0x060202B2 RID: 131762 RVA: 0x008CB978 File Offset: 0x008C9B78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_TrailsManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TrailsManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TrailsManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailsManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailsManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060202B3 RID: 131763 RVA: 0x008CB9C0 File Offset: 0x008C9BC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_TrailsManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TrailsManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TrailsManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailsManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailsManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060202B4 RID: 131764 RVA: 0x008CBA07 File Offset: 0x008C9C07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailsManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060202B5 RID: 131765 RVA: 0x008CBA1B File Offset: 0x008C9C1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailsManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060202B6 RID: 131766 RVA: 0x008CBA30 File Offset: 0x008C9C30
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnProxyShow(ALandscapeStreamingProxy Proxy)
		{
			BP_TrailsManager_C.__OnProxyShow_FunctionParams* ptr = stackalloc BP_TrailsManager_C.__OnProxyShow_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_TrailsManager_C.__OnProxyShow_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailsManager_C.__OnProxyShow_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Proxy = ((Proxy != null) ? Proxy.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailsManager_C.__OnProxyShow_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060202B7 RID: 131767 RVA: 0x008CBA88 File Offset: 0x008C9C88
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnProxyShow_Implementation(ALandscapeStreamingProxy Proxy)
		{
			BP_TrailsManager_C.__OnProxyShow_FunctionParams* ptr = stackalloc BP_TrailsManager_C.__OnProxyShow_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_TrailsManager_C.__OnProxyShow_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailsManager_C.__OnProxyShow_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Proxy = ((Proxy != null) ? Proxy.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailsManager_C.__OnProxyShow_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060202B8 RID: 131768 RVA: 0x008CBAE0 File Offset: 0x008C9CE0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnProxyHide(ALandscapeStreamingProxy Proxy)
		{
			BP_TrailsManager_C.__OnProxyHide_FunctionParams* ptr = stackalloc BP_TrailsManager_C.__OnProxyHide_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_TrailsManager_C.__OnProxyHide_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailsManager_C.__OnProxyHide_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Proxy = ((Proxy != null) ? Proxy.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailsManager_C.__OnProxyHide_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060202B9 RID: 131769 RVA: 0x008CBB38 File Offset: 0x008C9D38
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnProxyHide_Implementation(ALandscapeStreamingProxy Proxy)
		{
			BP_TrailsManager_C.__OnProxyHide_FunctionParams* ptr = stackalloc BP_TrailsManager_C.__OnProxyHide_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_TrailsManager_C.__OnProxyHide_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailsManager_C.__OnProxyHide_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Proxy = ((Proxy != null) ? Proxy.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailsManager_C.__OnProxyHide_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060202BA RID: 131770 RVA: 0x008CBB8E File Offset: 0x008C9D8E
		protected BP_TrailsManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F896 RID: 63638
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/BP_TrailsManager.BP_TrailsManager_C";

		// Token: 0x0400F897 RID: 63639
		private static IntPtr _ClassPtr;

		// Token: 0x0400F898 RID: 63640
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F899 RID: 63641
		internal static int __PropertyOffset_1;

		// Token: 0x0400F89A RID: 63642
		internal static int __PropertyOffset_2;

		// Token: 0x0400F89B RID: 63643
		internal static int __PropertyOffset_3;

		// Token: 0x0400F89C RID: 63644
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_TrailDrawComponent_C> _Drawers;

		// Token: 0x0400F89D RID: 63645
		internal static int __PropertyOffset_4;

		// Token: 0x0400F89E RID: 63646
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_TrailSensorActor_C> _TrailFields;

		// Token: 0x0400F89F RID: 63647
		internal static int __PropertyOffset_5;

		// Token: 0x0400F8A0 RID: 63648
		internal static int __PropertyOffset_6;

		// Token: 0x0400F8A1 RID: 63649
		internal static int __PropertyOffset_7;

		// Token: 0x0400F8A2 RID: 63650
		internal static int __PropertyOffset_8;

		// Token: 0x0400F8A3 RID: 63651
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<STrailDrawInfo> _DrawInfo;

		// Token: 0x0400F8A4 RID: 63652
		internal static int __PropertyOffset_9;

		// Token: 0x0400F8A5 RID: 63653
		internal static int __PropertyOffset_10;

		// Token: 0x0400F8A6 RID: 63654
		internal static int __PropertyOffset_11;

		// Token: 0x0400F8A7 RID: 63655
		internal static int __PropertyOffset_12;

		// Token: 0x0400F8A8 RID: 63656
		internal static int __PropertyOffset_13;

		// Token: 0x0400F8A9 RID: 63657
		internal static int __PropertyOffset_14;

		// Token: 0x0400F8AA RID: 63658
		internal static int __PropertyOffset_15;

		// Token: 0x0400F8AB RID: 63659
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_TrailSensorActor_C> _TrailFields_NeedRemove;

		// Token: 0x0400F8AC RID: 63660
		internal static int __PropertyOffset_16;

		// Token: 0x0400F8AD RID: 63661
		internal static int __PropertyOffset_17;

		// Token: 0x0400F8AE RID: 63662
		internal static int __PropertyOffset_18;

		// Token: 0x0400F8AF RID: 63663
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ALandscapeStreamingProxy> _LowLandscapes;

		// Token: 0x0400F8B0 RID: 63664
		internal static int __PropertyOffset_19;

		// Token: 0x0400F8B1 RID: 63665
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ALandscapeStreamingProxy> _HighLandscapes;

		// Token: 0x0400F8B2 RID: 63666
		internal static int __PropertyOffset_20;

		// Token: 0x0400F8B3 RID: 63667
		internal static int __PropertyOffset_21;

		// Token: 0x0400F8B4 RID: 63668
		private static IntPtr __test_NativeFunctionPtr;

		// Token: 0x0400F8B5 RID: 63669
		private static IntPtr __UpdateLandscapes_NativeFunctionPtr;

		// Token: 0x0400F8B6 RID: 63670
		private static IntPtr __GetTag_NativeFunctionPtr;

		// Token: 0x0400F8B7 RID: 63671
		private static IntPtr __ContainsTag_NativeFunctionPtr;

		// Token: 0x0400F8B8 RID: 63672
		private static IntPtr __HideProxy_NativeFunctionPtr;

		// Token: 0x0400F8B9 RID: 63673
		private static IntPtr __ShowProxy_NativeFunctionPtr;

		// Token: 0x0400F8BA RID: 63674
		private static IntPtr __IsEnable_NativeFunctionPtr;

		// Token: 0x0400F8BB RID: 63675
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F8BC RID: 63676
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F8BD RID: 63677
		private static IntPtr __OnProxyShow_NativeFunctionPtr;

		// Token: 0x0400F8BE RID: 63678
		private static IntPtr __OnProxyHide_NativeFunctionPtr;

		// Token: 0x02009B84 RID: 39812
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetTag_FunctionParams
		{
			// Token: 0x040311D0 RID: 201168
			[FieldOffset(0)]
			public IntPtr Proxy;

			// Token: 0x040311D1 RID: 201169
			[FieldOffset(8)]
			public int Index;

			// Token: 0x040311D2 RID: 201170
			[FieldOffset(16)]
			public FString Tag;
		}

		// Token: 0x02009B85 RID: 39813
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __ContainsTag_FunctionParams
		{
			// Token: 0x040311D3 RID: 201171
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x040311D4 RID: 201172
			[FieldOffset(8)]
			public FName Str;

			// Token: 0x040311D5 RID: 201173
			[FieldOffset(20)]
			public bool Ret;

			// Token: 0x040311D6 RID: 201174
			[FieldOffset(24)]
			public int Index;
		}

		// Token: 0x02009B86 RID: 39814
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __HideProxy_FunctionParams
		{
			// Token: 0x040311D7 RID: 201175
			[FieldOffset(0)]
			public IntPtr Proxy;
		}

		// Token: 0x02009B87 RID: 39815
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __ShowProxy_FunctionParams
		{
			// Token: 0x040311D8 RID: 201176
			[FieldOffset(0)]
			public IntPtr Proxy;
		}

		// Token: 0x02009B88 RID: 39816
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __IsEnable_FunctionParams
		{
			// Token: 0x040311D9 RID: 201177
			[FieldOffset(0)]
			public bool IsEnable;
		}

		// Token: 0x02009B89 RID: 39817
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040311DA RID: 201178
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009B8A RID: 39818
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __OnProxyShow_FunctionParams
		{
			// Token: 0x040311DB RID: 201179
			[FieldOffset(0)]
			public IntPtr Proxy;
		}

		// Token: 0x02009B8B RID: 39819
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __OnProxyHide_FunctionParams
		{
			// Token: 0x040311DC RID: 201180
			[FieldOffset(0)]
			public IntPtr Proxy;
		}
	}
}
