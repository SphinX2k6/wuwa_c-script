using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.QuestSystem
{
	// Token: 0x02003FE8 RID: 16360
	[UnrealObjectPath("/Game/Aki/Core/QuestSystem/BP_QuestTrackHUD1.BP_QuestTrackHUD1_C")]
	[UnrealStructLayout(1456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1452)]
	public class BP_QuestTrackHUD1_C : AHUD, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029E68 RID: 171624 RVA: 0x009CFB7F File Offset: 0x009CDD7F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_QuestTrackHUD1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/QuestSystem/BP_QuestTrackHUD1.BP_QuestTrackHUD1_C");
			}
			return BP_QuestTrackHUD1_C._ClassPtr;
		}

		// Token: 0x06029E69 RID: 171625 RVA: 0x009CFBA4 File Offset: 0x009CDDA4
		public BP_QuestTrackHUD1_C() : this(BuiltinUtils.AllocNativeUObject(BP_QuestTrackHUD1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029E6A RID: 171626 RVA: 0x009CFBCC File Offset: 0x009CDDCC
		[NullableContext(1)]
		public BP_QuestTrackHUD1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_QuestTrackHUD1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170065B2 RID: 26034
		// (get) Token: 0x06029E6B RID: 171627 RVA: 0x009CFBFF File Offset: 0x009CDDFF
		// (set) Token: 0x06029E6C RID: 171628 RVA: 0x009CFC13 File Offset: 0x009CDE13
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrackHUD1_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrackHUD1_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170065B3 RID: 26035
		// (get) Token: 0x06029E6D RID: 171629 RVA: 0x009CFC28 File Offset: 0x009CDE28
		// (set) Token: 0x06029E6E RID: 171630 RVA: 0x009CFC3C File Offset: 0x009CDE3C
		public unsafe FBox2D LimitedBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170065B4 RID: 26036
		// (get) Token: 0x06029E6F RID: 171631 RVA: 0x009CFC51 File Offset: 0x009CDE51
		// (set) Token: 0x06029E70 RID: 171632 RVA: 0x009CFC65 File Offset: 0x009CDE65
		public unsafe FVector2D LimitedScaler
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170065B5 RID: 26037
		// (get) Token: 0x06029E71 RID: 171633 RVA: 0x009CFC7A File Offset: 0x009CDE7A
		// (set) Token: 0x06029E72 RID: 171634 RVA: 0x009CFC8E File Offset: 0x009CDE8E
		public unsafe FLinearColor CurrentColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170065B6 RID: 26038
		// (get) Token: 0x06029E73 RID: 171635 RVA: 0x009CFCA3 File Offset: 0x009CDEA3
		// (set) Token: 0x06029E74 RID: 171636 RVA: 0x009CFCB3 File Offset: 0x009CDEB3
		public unsafe float innerRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170065B7 RID: 26039
		// (get) Token: 0x06029E75 RID: 171637 RVA: 0x009CFCC4 File Offset: 0x009CDEC4
		// (set) Token: 0x06029E76 RID: 171638 RVA: 0x009CFCD4 File Offset: 0x009CDED4
		public unsafe float ViewportSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170065B8 RID: 26040
		// (get) Token: 0x06029E77 RID: 171639 RVA: 0x009CFCE5 File Offset: 0x009CDEE5
		// (set) Token: 0x06029E78 RID: 171640 RVA: 0x009CFCF5 File Offset: 0x009CDEF5
		public unsafe float ViewportSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170065B9 RID: 26041
		// (get) Token: 0x06029E79 RID: 171641 RVA: 0x009CFD06 File Offset: 0x009CDF06
		// (set) Token: 0x06029E7A RID: 171642 RVA: 0x009CFD16 File Offset: 0x009CDF16
		public unsafe bool IsShow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170065BA RID: 26042
		// (get) Token: 0x06029E7B RID: 171643 RVA: 0x009CFD28 File Offset: 0x009CDF28
		// (set) Token: 0x06029E7C RID: 171644 RVA: 0x009CFD61 File Offset: 0x009CDF61
		[Nullable(1)]
		public TMap<int, FVector> TrackPositions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<int, FVector> result;
				if ((result = this._TrackPositions) == null)
				{
					result = (this._TrackPositions = new TMap<int, FVector>(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TrackPositions.CopyAssign(value);
			}
		}

		// Token: 0x170065BB RID: 26043
		// (get) Token: 0x06029E7D RID: 171645 RVA: 0x009CFD6F File Offset: 0x009CDF6F
		// (set) Token: 0x06029E7E RID: 171646 RVA: 0x009CFD7F File Offset: 0x009CDF7F
		public unsafe float DefaultScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD1_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x06029E7F RID: 171647 RVA: 0x009CFD90 File Offset: 0x009CDF90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ShowTracks(int X, int Y)
		{
			BP_QuestTrackHUD1_C.__ShowTracks_FunctionParams* ptr = stackalloc BP_QuestTrackHUD1_C.__ShowTracks_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_QuestTrackHUD1_C.__ShowTracks_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrackHUD1_C.__ShowTracks_NativeFunctionPtr, (void*)ptr, 1);
			ptr->X = X;
			ptr->Y = Y;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrackHUD1_C.__ShowTracks_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029E80 RID: 171648 RVA: 0x009CFDE0 File Offset: 0x009CDFE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ShowTrack(int X, int Y, FVector TrackPos)
		{
			BP_QuestTrackHUD1_C.__ShowTrack_FunctionParams* ptr = stackalloc BP_QuestTrackHUD1_C.__ShowTrack_FunctionParams[(UIntPtr)703] + 15L / (long)sizeof(BP_QuestTrackHUD1_C.__ShowTrack_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrackHUD1_C.__ShowTrack_NativeFunctionPtr, (void*)ptr, 1);
			ptr->X = X;
			ptr->Y = Y;
			ptr->TrackPos = TrackPos;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrackHUD1_C.__ShowTrack_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029E81 RID: 171649 RVA: 0x009CFE38 File Offset: 0x009CE038
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetTrackPos(bool valuie, FVector pos, int MarkId)
		{
			BP_QuestTrackHUD1_C.__SetTrackPos_FunctionParams* ptr = stackalloc BP_QuestTrackHUD1_C.__SetTrackPos_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_QuestTrackHUD1_C.__SetTrackPos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrackHUD1_C.__SetTrackPos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->valuie = valuie;
			ptr->pos = pos;
			ptr->MarkId = MarkId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrackHUD1_C.__SetTrackPos_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029E82 RID: 171650 RVA: 0x009CFE8C File Offset: 0x009CE08C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetVectorAngle(FVector2D vector1, FVector2D vector2, ref float value)
		{
			BP_QuestTrackHUD1_C.__GetVectorAngle_FunctionParams* ptr = stackalloc BP_QuestTrackHUD1_C.__GetVectorAngle_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(BP_QuestTrackHUD1_C.__GetVectorAngle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrackHUD1_C.__GetVectorAngle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->vector1 = vector1;
			ptr->vector2 = vector2;
			ptr->value = value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrackHUD1_C.__GetVectorAngle_NativeFunctionPtr, (void*)ptr);
			value = ptr->value;
		}

		// Token: 0x06029E83 RID: 171651 RVA: 0x009CFEEC File Offset: 0x009CE0EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ReCalBounds(float inX, float inY)
		{
			BP_QuestTrackHUD1_C.__ReCalBounds_FunctionParams* ptr = stackalloc BP_QuestTrackHUD1_C.__ReCalBounds_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_QuestTrackHUD1_C.__ReCalBounds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrackHUD1_C.__ReCalBounds_NativeFunctionPtr, (void*)ptr, 1);
			ptr->inX = inX;
			ptr->inY = inY;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrackHUD1_C.__ReCalBounds_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029E84 RID: 171652 RVA: 0x009CFF3C File Offset: 0x009CE13C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CaclBounds(float inX, float inY)
		{
			BP_QuestTrackHUD1_C.__CaclBounds_FunctionParams* ptr = stackalloc BP_QuestTrackHUD1_C.__CaclBounds_FunctionParams[(UIntPtr)131] + 15L / (long)sizeof(BP_QuestTrackHUD1_C.__CaclBounds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrackHUD1_C.__CaclBounds_NativeFunctionPtr, (void*)ptr, 1);
			ptr->inX = inX;
			ptr->inY = inY;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrackHUD1_C.__CaclBounds_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029E85 RID: 171653 RVA: 0x009CFF8C File Offset: 0x009CE18C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrackHUD1_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06029E86 RID: 171654 RVA: 0x009CFFA0 File Offset: 0x009CE1A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QuestTrackHUD1_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06029E87 RID: 171655 RVA: 0x009CFFB8 File Offset: 0x009CE1B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveDrawHUD(int SizeX, int SizeY)
		{
			BP_QuestTrackHUD1_C.__ReceiveDrawHUD_FunctionParams* ptr = stackalloc BP_QuestTrackHUD1_C.__ReceiveDrawHUD_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_QuestTrackHUD1_C.__ReceiveDrawHUD_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrackHUD1_C.__ReceiveDrawHUD_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SizeX = SizeX;
			ptr->SizeY = SizeY;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrackHUD1_C.__ReceiveDrawHUD_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029E88 RID: 171656 RVA: 0x009D0008 File Offset: 0x009CE208
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveDrawHUD_Implementation(int SizeX, int SizeY)
		{
			BP_QuestTrackHUD1_C.__ReceiveDrawHUD_FunctionParams* ptr = stackalloc BP_QuestTrackHUD1_C.__ReceiveDrawHUD_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_QuestTrackHUD1_C.__ReceiveDrawHUD_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrackHUD1_C.__ReceiveDrawHUD_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SizeX = SizeX;
			ptr->SizeY = SizeY;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QuestTrackHUD1_C.__ReceiveDrawHUD_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06029E89 RID: 171657 RVA: 0x009D0056 File Offset: 0x009CE256
		protected BP_QuestTrackHUD1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015865 RID: 88165
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/QuestSystem/BP_QuestTrackHUD1.BP_QuestTrackHUD1_C";

		// Token: 0x04015866 RID: 88166
		private static IntPtr _ClassPtr;

		// Token: 0x04015867 RID: 88167
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015868 RID: 88168
		internal static int __PropertyOffset_1;

		// Token: 0x04015869 RID: 88169
		internal static int __PropertyOffset_2;

		// Token: 0x0401586A RID: 88170
		internal static int __PropertyOffset_3;

		// Token: 0x0401586B RID: 88171
		internal static int __PropertyOffset_4;

		// Token: 0x0401586C RID: 88172
		internal static int __PropertyOffset_5;

		// Token: 0x0401586D RID: 88173
		internal static int __PropertyOffset_6;

		// Token: 0x0401586E RID: 88174
		internal static int __PropertyOffset_7;

		// Token: 0x0401586F RID: 88175
		internal static int __PropertyOffset_8;

		// Token: 0x04015870 RID: 88176
		internal static int __PropertyOffset_9;

		// Token: 0x04015871 RID: 88177
		[Nullable(2)]
		private TMap<int, FVector> _TrackPositions;

		// Token: 0x04015872 RID: 88178
		internal static int __PropertyOffset_10;

		// Token: 0x04015873 RID: 88179
		private static IntPtr __ShowTracks_NativeFunctionPtr;

		// Token: 0x04015874 RID: 88180
		private static IntPtr __ShowTrack_NativeFunctionPtr;

		// Token: 0x04015875 RID: 88181
		private static IntPtr __SetTrackPos_NativeFunctionPtr;

		// Token: 0x04015876 RID: 88182
		private static IntPtr __GetVectorAngle_NativeFunctionPtr;

		// Token: 0x04015877 RID: 88183
		private static IntPtr __ReCalBounds_NativeFunctionPtr;

		// Token: 0x04015878 RID: 88184
		private static IntPtr __CaclBounds_NativeFunctionPtr;

		// Token: 0x04015879 RID: 88185
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401587A RID: 88186
		private static IntPtr __ReceiveDrawHUD_NativeFunctionPtr;

		// Token: 0x0200A2FB RID: 41723
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __ShowTracks_FunctionParams
		{
			// Token: 0x04032065 RID: 204901
			[FieldOffset(0)]
			public int X;

			// Token: 0x04032066 RID: 204902
			[FieldOffset(4)]
			public int Y;
		}

		// Token: 0x0200A2FC RID: 41724
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 688)]
		protected ref struct __ShowTrack_FunctionParams
		{
			// Token: 0x04032067 RID: 204903
			[FieldOffset(0)]
			public int X;

			// Token: 0x04032068 RID: 204904
			[FieldOffset(4)]
			public int Y;

			// Token: 0x04032069 RID: 204905
			[FieldOffset(8)]
			public FVector TrackPos;
		}

		// Token: 0x0200A2FD RID: 41725
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetTrackPos_FunctionParams
		{
			// Token: 0x0403206A RID: 204906
			[FieldOffset(0)]
			public bool valuie;

			// Token: 0x0403206B RID: 204907
			[FieldOffset(4)]
			public FVector pos;

			// Token: 0x0403206C RID: 204908
			[FieldOffset(16)]
			public int MarkId;
		}

		// Token: 0x0200A2FE RID: 41726
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected ref struct __GetVectorAngle_FunctionParams
		{
			// Token: 0x0403206D RID: 204909
			[FieldOffset(0)]
			public FVector2D vector1;

			// Token: 0x0403206E RID: 204910
			[FieldOffset(8)]
			public FVector2D vector2;

			// Token: 0x0403206F RID: 204911
			[FieldOffset(16)]
			public float value;
		}

		// Token: 0x0200A2FF RID: 41727
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReCalBounds_FunctionParams
		{
			// Token: 0x04032070 RID: 204912
			[FieldOffset(0)]
			public float inX;

			// Token: 0x04032071 RID: 204913
			[FieldOffset(4)]
			public float inY;
		}

		// Token: 0x0200A300 RID: 41728
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 116)]
		protected ref struct __CaclBounds_FunctionParams
		{
			// Token: 0x04032072 RID: 204914
			[FieldOffset(0)]
			public float inX;

			// Token: 0x04032073 RID: 204915
			[FieldOffset(4)]
			public float inY;
		}

		// Token: 0x0200A301 RID: 41729
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveDrawHUD_FunctionParams
		{
			// Token: 0x04032074 RID: 204916
			[FieldOffset(0)]
			public int SizeX;

			// Token: 0x04032075 RID: 204917
			[FieldOffset(4)]
			public int SizeY;
		}
	}
}
