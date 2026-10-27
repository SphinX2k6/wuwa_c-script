using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.QuestSystem
{
	// Token: 0x02003FE9 RID: 16361
	[UnrealObjectPath("/Game/Aki/Core/QuestSystem/BP_QuestTrackHUD.BP_QuestTrackHUD_C")]
	[UnrealStructLayout(1408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1401)]
	public class BP_QuestTrackHUD_C : AHUD, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029E8A RID: 171658 RVA: 0x009D005F File Offset: 0x009CE25F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_QuestTrackHUD_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/QuestSystem/BP_QuestTrackHUD.BP_QuestTrackHUD_C");
			}
			return BP_QuestTrackHUD_C._ClassPtr;
		}

		// Token: 0x06029E8B RID: 171659 RVA: 0x009D0084 File Offset: 0x009CE284
		public BP_QuestTrackHUD_C() : this(BuiltinUtils.AllocNativeUObject(BP_QuestTrackHUD_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029E8C RID: 171660 RVA: 0x009D00AC File Offset: 0x009CE2AC
		[NullableContext(1)]
		public BP_QuestTrackHUD_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_QuestTrackHUD_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170065BC RID: 26044
		// (get) Token: 0x06029E8D RID: 171661 RVA: 0x009D00DF File Offset: 0x009CE2DF
		// (set) Token: 0x06029E8E RID: 171662 RVA: 0x009D00F3 File Offset: 0x009CE2F3
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrackHUD_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrackHUD_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170065BD RID: 26045
		// (get) Token: 0x06029E8F RID: 171663 RVA: 0x009D0108 File Offset: 0x009CE308
		// (set) Token: 0x06029E90 RID: 171664 RVA: 0x009D011C File Offset: 0x009CE31C
		public unsafe FBox2D LimitedBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170065BE RID: 26046
		// (get) Token: 0x06029E91 RID: 171665 RVA: 0x009D0131 File Offset: 0x009CE331
		// (set) Token: 0x06029E92 RID: 171666 RVA: 0x009D0145 File Offset: 0x009CE345
		public unsafe FVector2D LimitedScaler
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170065BF RID: 26047
		// (get) Token: 0x06029E93 RID: 171667 RVA: 0x009D015A File Offset: 0x009CE35A
		// (set) Token: 0x06029E94 RID: 171668 RVA: 0x009D016E File Offset: 0x009CE36E
		public unsafe FVector2D ScreenPositon
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170065C0 RID: 26048
		// (get) Token: 0x06029E95 RID: 171669 RVA: 0x009D0183 File Offset: 0x009CE383
		// (set) Token: 0x06029E96 RID: 171670 RVA: 0x009D0197 File Offset: 0x009CE397
		[Nullable(2)]
		public unsafe AActor QuestObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrackHUD_C.__PropertyOffset_5);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QuestTrackHUD_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170065C1 RID: 26049
		// (get) Token: 0x06029E97 RID: 171671 RVA: 0x009D01AC File Offset: 0x009CE3AC
		// (set) Token: 0x06029E98 RID: 171672 RVA: 0x009D01C0 File Offset: 0x009CE3C0
		public unsafe FLinearColor CurrentColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170065C2 RID: 26050
		// (get) Token: 0x06029E99 RID: 171673 RVA: 0x009D01D5 File Offset: 0x009CE3D5
		// (set) Token: 0x06029E9A RID: 171674 RVA: 0x009D01E5 File Offset: 0x009CE3E5
		public unsafe float innerRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170065C3 RID: 26051
		// (get) Token: 0x06029E9B RID: 171675 RVA: 0x009D01F6 File Offset: 0x009CE3F6
		// (set) Token: 0x06029E9C RID: 171676 RVA: 0x009D0206 File Offset: 0x009CE406
		public unsafe float tempX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170065C4 RID: 26052
		// (get) Token: 0x06029E9D RID: 171677 RVA: 0x009D0217 File Offset: 0x009CE417
		// (set) Token: 0x06029E9E RID: 171678 RVA: 0x009D0227 File Offset: 0x009CE427
		public unsafe float tempY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170065C5 RID: 26053
		// (get) Token: 0x06029E9F RID: 171679 RVA: 0x009D0238 File Offset: 0x009CE438
		// (set) Token: 0x06029EA0 RID: 171680 RVA: 0x009D0248 File Offset: 0x009CE448
		public unsafe float tempLX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170065C6 RID: 26054
		// (get) Token: 0x06029EA1 RID: 171681 RVA: 0x009D0259 File Offset: 0x009CE459
		// (set) Token: 0x06029EA2 RID: 171682 RVA: 0x009D0269 File Offset: 0x009CE469
		public unsafe float tempLY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170065C7 RID: 26055
		// (get) Token: 0x06029EA3 RID: 171683 RVA: 0x009D027A File Offset: 0x009CE47A
		// (set) Token: 0x06029EA4 RID: 171684 RVA: 0x009D028A File Offset: 0x009CE48A
		public unsafe float tempLZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170065C8 RID: 26056
		// (get) Token: 0x06029EA5 RID: 171685 RVA: 0x009D029B File Offset: 0x009CE49B
		// (set) Token: 0x06029EA6 RID: 171686 RVA: 0x009D02AB File Offset: 0x009CE4AB
		public unsafe float ViewportSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170065C9 RID: 26057
		// (get) Token: 0x06029EA7 RID: 171687 RVA: 0x009D02BC File Offset: 0x009CE4BC
		// (set) Token: 0x06029EA8 RID: 171688 RVA: 0x009D02CC File Offset: 0x009CE4CC
		public unsafe float ViewportSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170065CA RID: 26058
		// (get) Token: 0x06029EA9 RID: 171689 RVA: 0x009D02DD File Offset: 0x009CE4DD
		// (set) Token: 0x06029EAA RID: 171690 RVA: 0x009D02ED File Offset: 0x009CE4ED
		public unsafe bool DisplayDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QuestTrackHUD_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x06029EAB RID: 171691 RVA: 0x009D0300 File Offset: 0x009CE500
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ReCalBounds(float inX, float inY)
		{
			BP_QuestTrackHUD_C.__ReCalBounds_FunctionParams* ptr = stackalloc BP_QuestTrackHUD_C.__ReCalBounds_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_QuestTrackHUD_C.__ReCalBounds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrackHUD_C.__ReCalBounds_NativeFunctionPtr, (void*)ptr, 1);
			ptr->inX = inX;
			ptr->inY = inY;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrackHUD_C.__ReCalBounds_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029EAC RID: 171692 RVA: 0x009D0350 File Offset: 0x009CE550
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CaclBounds(float inX, float inY)
		{
			BP_QuestTrackHUD_C.__CaclBounds_FunctionParams* ptr = stackalloc BP_QuestTrackHUD_C.__CaclBounds_FunctionParams[(UIntPtr)131] + 15L / (long)sizeof(BP_QuestTrackHUD_C.__CaclBounds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrackHUD_C.__CaclBounds_NativeFunctionPtr, (void*)ptr, 1);
			ptr->inX = inX;
			ptr->inY = inY;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrackHUD_C.__CaclBounds_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029EAD RID: 171693 RVA: 0x009D03A0 File Offset: 0x009CE5A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveDrawHUD(int SizeX, int SizeY)
		{
			BP_QuestTrackHUD_C.__ReceiveDrawHUD_FunctionParams* ptr = stackalloc BP_QuestTrackHUD_C.__ReceiveDrawHUD_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_QuestTrackHUD_C.__ReceiveDrawHUD_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrackHUD_C.__ReceiveDrawHUD_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SizeX = SizeX;
			ptr->SizeY = SizeY;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QuestTrackHUD_C.__ReceiveDrawHUD_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06029EAE RID: 171694 RVA: 0x009D03F0 File Offset: 0x009CE5F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveDrawHUD_Implementation(int SizeX, int SizeY)
		{
			BP_QuestTrackHUD_C.__ReceiveDrawHUD_FunctionParams* ptr = stackalloc BP_QuestTrackHUD_C.__ReceiveDrawHUD_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_QuestTrackHUD_C.__ReceiveDrawHUD_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QuestTrackHUD_C.__ReceiveDrawHUD_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SizeX = SizeX;
			ptr->SizeY = SizeY;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QuestTrackHUD_C.__ReceiveDrawHUD_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06029EAF RID: 171695 RVA: 0x009D043E File Offset: 0x009CE63E
		protected BP_QuestTrackHUD_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401587B RID: 88187
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/QuestSystem/BP_QuestTrackHUD.BP_QuestTrackHUD_C";

		// Token: 0x0401587C RID: 88188
		private static IntPtr _ClassPtr;

		// Token: 0x0401587D RID: 88189
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401587E RID: 88190
		internal static int __PropertyOffset_1;

		// Token: 0x0401587F RID: 88191
		internal static int __PropertyOffset_2;

		// Token: 0x04015880 RID: 88192
		internal static int __PropertyOffset_3;

		// Token: 0x04015881 RID: 88193
		internal static int __PropertyOffset_4;

		// Token: 0x04015882 RID: 88194
		internal static int __PropertyOffset_5;

		// Token: 0x04015883 RID: 88195
		internal static int __PropertyOffset_6;

		// Token: 0x04015884 RID: 88196
		internal static int __PropertyOffset_7;

		// Token: 0x04015885 RID: 88197
		internal static int __PropertyOffset_8;

		// Token: 0x04015886 RID: 88198
		internal static int __PropertyOffset_9;

		// Token: 0x04015887 RID: 88199
		internal static int __PropertyOffset_10;

		// Token: 0x04015888 RID: 88200
		internal static int __PropertyOffset_11;

		// Token: 0x04015889 RID: 88201
		internal static int __PropertyOffset_12;

		// Token: 0x0401588A RID: 88202
		internal static int __PropertyOffset_13;

		// Token: 0x0401588B RID: 88203
		internal static int __PropertyOffset_14;

		// Token: 0x0401588C RID: 88204
		internal static int __PropertyOffset_15;

		// Token: 0x0401588D RID: 88205
		private static IntPtr __ReCalBounds_NativeFunctionPtr;

		// Token: 0x0401588E RID: 88206
		private static IntPtr __CaclBounds_NativeFunctionPtr;

		// Token: 0x0401588F RID: 88207
		private static IntPtr __ReceiveDrawHUD_NativeFunctionPtr;

		// Token: 0x0200A302 RID: 41730
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReCalBounds_FunctionParams
		{
			// Token: 0x04032076 RID: 204918
			[FieldOffset(0)]
			public float inX;

			// Token: 0x04032077 RID: 204919
			[FieldOffset(4)]
			public float inY;
		}

		// Token: 0x0200A303 RID: 41731
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 116)]
		protected ref struct __CaclBounds_FunctionParams
		{
			// Token: 0x04032078 RID: 204920
			[FieldOffset(0)]
			public float inX;

			// Token: 0x04032079 RID: 204921
			[FieldOffset(4)]
			public float inY;
		}

		// Token: 0x0200A304 RID: 41732
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveDrawHUD_FunctionParams
		{
			// Token: 0x0403207A RID: 204922
			[FieldOffset(0)]
			public int SizeX;

			// Token: 0x0403207B RID: 204923
			[FieldOffset(4)]
			public int SizeY;
		}
	}
}
