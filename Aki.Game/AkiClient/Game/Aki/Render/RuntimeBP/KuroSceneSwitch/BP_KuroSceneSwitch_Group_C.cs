using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.KuroSceneSwitch
{
	// Token: 0x02003D02 RID: 15618
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/KuroSceneSwitch/BP_KuroSceneSwitch_Group.BP_KuroSceneSwitch_Group_C")]
	[UnrealStructLayout(1144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1140)]
	public class BP_KuroSceneSwitch_Group_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025555 RID: 152917 RVA: 0x00957464 File Offset: 0x00955664
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroSceneSwitch_Group_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/KuroSceneSwitch/BP_KuroSceneSwitch_Group.BP_KuroSceneSwitch_Group_C");
			}
			return BP_KuroSceneSwitch_Group_C._ClassPtr;
		}

		// Token: 0x06025556 RID: 152918 RVA: 0x00957488 File Offset: 0x00955688
		public BP_KuroSceneSwitch_Group_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroSceneSwitch_Group_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025557 RID: 152919 RVA: 0x009574B0 File Offset: 0x009556B0
		public BP_KuroSceneSwitch_Group_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroSceneSwitch_Group_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C12 RID: 19474
		// (get) Token: 0x06025558 RID: 152920 RVA: 0x009574E3 File Offset: 0x009556E3
		// (set) Token: 0x06025559 RID: 152921 RVA: 0x009574F7 File Offset: 0x009556F7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroSceneSwitch_Group_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroSceneSwitch_Group_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17004C13 RID: 19475
		// (get) Token: 0x0602555A RID: 152922 RVA: 0x0095750C File Offset: 0x0095570C
		// (set) Token: 0x0602555B RID: 152923 RVA: 0x00957545 File Offset: 0x00955745
		public TSet<AActor> Primitive
		{
			get
			{
				base.FastCheckIsValid();
				TSet<AActor> result;
				if ((result = this._Primitive) == null)
				{
					result = (this._Primitive = new TSet<AActor>(base.NativePtr + (IntPtr)BP_KuroSceneSwitch_Group_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.Primitive.CopyAssign(value);
			}
		}

		// Token: 0x17004C14 RID: 19476
		// (get) Token: 0x0602555C RID: 152924 RVA: 0x00957553 File Offset: 0x00955753
		// (set) Token: 0x0602555D RID: 152925 RVA: 0x00957563 File Offset: 0x00955763
		public unsafe float Sphere_Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroSceneSwitch_Group_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroSceneSwitch_Group_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17004C15 RID: 19477
		// (get) Token: 0x0602555E RID: 152926 RVA: 0x00957574 File Offset: 0x00955774
		// (set) Token: 0x0602555F RID: 152927 RVA: 0x00957584 File Offset: 0x00955784
		public unsafe float Edge_Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroSceneSwitch_Group_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroSceneSwitch_Group_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004C16 RID: 19478
		// (get) Token: 0x06025560 RID: 152928 RVA: 0x00957595 File Offset: 0x00955795
		// (set) Token: 0x06025561 RID: 152929 RVA: 0x009575A5 File Offset: 0x009557A5
		public unsafe int Side
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroSceneSwitch_Group_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroSceneSwitch_Group_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x06025562 RID: 152930 RVA: 0x009575B6 File Offset: 0x009557B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Uninit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSceneSwitch_Group_C.__Uninit_NativeFunctionPtr, null);
		}

		// Token: 0x06025563 RID: 152931 RVA: 0x009575CA File Offset: 0x009557CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSceneSwitch_Group_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x06025564 RID: 152932 RVA: 0x009575DE File Offset: 0x009557DE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UnInitScene()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSceneSwitch_Group_C.__UnInitScene_NativeFunctionPtr, null);
		}

		// Token: 0x06025565 RID: 152933 RVA: 0x009575F2 File Offset: 0x009557F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetRadius()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSceneSwitch_Group_C.__SetRadius_NativeFunctionPtr, null);
		}

		// Token: 0x06025566 RID: 152934 RVA: 0x00957606 File Offset: 0x00955806
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitScene()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSceneSwitch_Group_C.__InitScene_NativeFunctionPtr, null);
		}

		// Token: 0x06025567 RID: 152935 RVA: 0x0095761A File Offset: 0x0095581A
		protected BP_KuroSceneSwitch_Group_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040129DC RID: 76252
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/KuroSceneSwitch/BP_KuroSceneSwitch_Group.BP_KuroSceneSwitch_Group_C";

		// Token: 0x040129DD RID: 76253
		private static IntPtr _ClassPtr;

		// Token: 0x040129DE RID: 76254
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040129DF RID: 76255
		internal static int __PropertyOffset_0;

		// Token: 0x040129E0 RID: 76256
		internal static int __PropertyOffset_1;

		// Token: 0x040129E1 RID: 76257
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<AActor> _Primitive;

		// Token: 0x040129E2 RID: 76258
		internal static int __PropertyOffset_2;

		// Token: 0x040129E3 RID: 76259
		internal static int __PropertyOffset_3;

		// Token: 0x040129E4 RID: 76260
		internal static int __PropertyOffset_4;

		// Token: 0x040129E5 RID: 76261
		private static IntPtr __Uninit_NativeFunctionPtr;

		// Token: 0x040129E6 RID: 76262
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x040129E7 RID: 76263
		private static IntPtr __UnInitScene_NativeFunctionPtr;

		// Token: 0x040129E8 RID: 76264
		private static IntPtr __SetRadius_NativeFunctionPtr;

		// Token: 0x040129E9 RID: 76265
		private static IntPtr __InitScene_NativeFunctionPtr;
	}
}
