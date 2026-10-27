using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.KuroSceneSwitch
{
	// Token: 0x02003D01 RID: 15617
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/KuroSceneSwitch/BP_KuroSceneSwitch.BP_KuroSceneSwitch_C")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1228)]
	public class BP_KuroSceneSwitch_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602553B RID: 152891 RVA: 0x009571F0 File Offset: 0x009553F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroSceneSwitch_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/KuroSceneSwitch/BP_KuroSceneSwitch.BP_KuroSceneSwitch_C");
			}
			return BP_KuroSceneSwitch_C._ClassPtr;
		}

		// Token: 0x0602553C RID: 152892 RVA: 0x00957214 File Offset: 0x00955414
		public BP_KuroSceneSwitch_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroSceneSwitch_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602553D RID: 152893 RVA: 0x0095723C File Offset: 0x0095543C
		public BP_KuroSceneSwitch_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroSceneSwitch_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C0C RID: 19468
		// (get) Token: 0x0602553E RID: 152894 RVA: 0x0095726F File Offset: 0x0095546F
		// (set) Token: 0x0602553F RID: 152895 RVA: 0x00957283 File Offset: 0x00955483
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroSceneSwitch_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroSceneSwitch_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17004C0D RID: 19469
		// (get) Token: 0x06025540 RID: 152896 RVA: 0x00957298 File Offset: 0x00955498
		// (set) Token: 0x06025541 RID: 152897 RVA: 0x009572D1 File Offset: 0x009554D1
		public TSet<AActor> PrimitiveB
		{
			get
			{
				base.FastCheckIsValid();
				TSet<AActor> result;
				if ((result = this._PrimitiveB) == null)
				{
					result = (this._PrimitiveB = new TSet<AActor>(base.NativePtr + (IntPtr)BP_KuroSceneSwitch_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.PrimitiveB.CopyAssign(value);
			}
		}

		// Token: 0x17004C0E RID: 19470
		// (get) Token: 0x06025542 RID: 152898 RVA: 0x009572E0 File Offset: 0x009554E0
		// (set) Token: 0x06025543 RID: 152899 RVA: 0x00957319 File Offset: 0x00955519
		public TSet<AActor> PrimitiveA
		{
			get
			{
				base.FastCheckIsValid();
				TSet<AActor> result;
				if ((result = this._PrimitiveA) == null)
				{
					result = (this._PrimitiveA = new TSet<AActor>(base.NativePtr + (IntPtr)BP_KuroSceneSwitch_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.PrimitiveA.CopyAssign(value);
			}
		}

		// Token: 0x17004C0F RID: 19471
		// (get) Token: 0x06025544 RID: 152900 RVA: 0x00957327 File Offset: 0x00955527
		// (set) Token: 0x06025545 RID: 152901 RVA: 0x0095733B File Offset: 0x0095553B
		public unsafe FVector Sphere_Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroSceneSwitch_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroSceneSwitch_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004C10 RID: 19472
		// (get) Token: 0x06025546 RID: 152902 RVA: 0x00957350 File Offset: 0x00955550
		// (set) Token: 0x06025547 RID: 152903 RVA: 0x00957360 File Offset: 0x00955560
		public unsafe float Sphere_Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroSceneSwitch_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroSceneSwitch_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004C11 RID: 19473
		// (get) Token: 0x06025548 RID: 152904 RVA: 0x00957371 File Offset: 0x00955571
		// (set) Token: 0x06025549 RID: 152905 RVA: 0x00957381 File Offset: 0x00955581
		public unsafe float Edge_Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroSceneSwitch_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroSceneSwitch_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x0602554A RID: 152906 RVA: 0x00957392 File Offset: 0x00955592
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Uninit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSceneSwitch_C.__Uninit_NativeFunctionPtr, null);
		}

		// Token: 0x0602554B RID: 152907 RVA: 0x009573A6 File Offset: 0x009555A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSceneSwitch_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x0602554C RID: 152908 RVA: 0x009573BA File Offset: 0x009555BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CheckABOverlap()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSceneSwitch_C.__CheckABOverlap_NativeFunctionPtr, null);
		}

		// Token: 0x0602554D RID: 152909 RVA: 0x009573CE File Offset: 0x009555CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UnInitSceneB()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSceneSwitch_C.__UnInitSceneB_NativeFunctionPtr, null);
		}

		// Token: 0x0602554E RID: 152910 RVA: 0x009573E2 File Offset: 0x009555E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UnInitSceneA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSceneSwitch_C.__UnInitSceneA_NativeFunctionPtr, null);
		}

		// Token: 0x0602554F RID: 152911 RVA: 0x009573F6 File Offset: 0x009555F6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetRadius()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSceneSwitch_C.__SetRadius_NativeFunctionPtr, null);
		}

		// Token: 0x06025550 RID: 152912 RVA: 0x0095740A File Offset: 0x0095560A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitSceneB()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSceneSwitch_C.__InitSceneB_NativeFunctionPtr, null);
		}

		// Token: 0x06025551 RID: 152913 RVA: 0x0095741E File Offset: 0x0095561E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitSceneA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSceneSwitch_C.__InitSceneA_NativeFunctionPtr, null);
		}

		// Token: 0x06025552 RID: 152914 RVA: 0x00957432 File Offset: 0x00955632
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSceneSwitch_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025553 RID: 152915 RVA: 0x00957446 File Offset: 0x00955646
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroSceneSwitch_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025554 RID: 152916 RVA: 0x0095745B File Offset: 0x0095565B
		protected BP_KuroSceneSwitch_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040129C8 RID: 76232
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/KuroSceneSwitch/BP_KuroSceneSwitch.BP_KuroSceneSwitch_C";

		// Token: 0x040129C9 RID: 76233
		private static IntPtr _ClassPtr;

		// Token: 0x040129CA RID: 76234
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040129CB RID: 76235
		internal static int __PropertyOffset_0;

		// Token: 0x040129CC RID: 76236
		internal static int __PropertyOffset_1;

		// Token: 0x040129CD RID: 76237
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<AActor> _PrimitiveB;

		// Token: 0x040129CE RID: 76238
		internal static int __PropertyOffset_2;

		// Token: 0x040129CF RID: 76239
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<AActor> _PrimitiveA;

		// Token: 0x040129D0 RID: 76240
		internal static int __PropertyOffset_3;

		// Token: 0x040129D1 RID: 76241
		internal static int __PropertyOffset_4;

		// Token: 0x040129D2 RID: 76242
		internal static int __PropertyOffset_5;

		// Token: 0x040129D3 RID: 76243
		private static IntPtr __Uninit_NativeFunctionPtr;

		// Token: 0x040129D4 RID: 76244
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x040129D5 RID: 76245
		private static IntPtr __CheckABOverlap_NativeFunctionPtr;

		// Token: 0x040129D6 RID: 76246
		private static IntPtr __UnInitSceneB_NativeFunctionPtr;

		// Token: 0x040129D7 RID: 76247
		private static IntPtr __UnInitSceneA_NativeFunctionPtr;

		// Token: 0x040129D8 RID: 76248
		private static IntPtr __SetRadius_NativeFunctionPtr;

		// Token: 0x040129D9 RID: 76249
		private static IntPtr __InitSceneB_NativeFunctionPtr;

		// Token: 0x040129DA RID: 76250
		private static IntPtr __InitSceneA_NativeFunctionPtr;

		// Token: 0x040129DB RID: 76251
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
