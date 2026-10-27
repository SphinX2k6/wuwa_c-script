using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common
{
	// Token: 0x02003B5D RID: 15197
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/BP_FloatingStaticMesh_UI.BP_FloatingStaticMesh_UI_C")]
	[UnrealStructLayout(2784, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2776)]
	public class BP_FloatingStaticMesh_UI_C : AKuroFloatingStaticMesh, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021B76 RID: 138102 RVA: 0x008F3D98 File Offset: 0x008F1F98
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FloatingStaticMesh_UI_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_FloatingStaticMesh_UI.BP_FloatingStaticMesh_UI_C");
			}
			return BP_FloatingStaticMesh_UI_C._ClassPtr;
		}

		// Token: 0x06021B77 RID: 138103 RVA: 0x008F3DBC File Offset: 0x008F1FBC
		public BP_FloatingStaticMesh_UI_C() : this(BuiltinUtils.AllocNativeUObject(BP_FloatingStaticMesh_UI_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021B78 RID: 138104 RVA: 0x008F3DE4 File Offset: 0x008F1FE4
		public BP_FloatingStaticMesh_UI_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FloatingStaticMesh_UI_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170037F3 RID: 14323
		// (get) Token: 0x06021B79 RID: 138105 RVA: 0x008F3E17 File Offset: 0x008F2017
		// (set) Token: 0x06021B7A RID: 138106 RVA: 0x008F3E2B File Offset: 0x008F202B
		[Nullable(2)]
		public unsafe UKuroVirtualAttachmentParentComponent KuroVirtualAttachmentParent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroVirtualAttachmentParentComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_UI_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_UI_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170037F4 RID: 14324
		// (get) Token: 0x06021B7B RID: 138107 RVA: 0x008F3E40 File Offset: 0x008F2040
		// (set) Token: 0x06021B7C RID: 138108 RVA: 0x008F3E54 File Offset: 0x008F2054
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMeshComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_UI_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_UI_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170037F5 RID: 14325
		// (get) Token: 0x06021B7D RID: 138109 RVA: 0x008F3E69 File Offset: 0x008F2069
		// (set) Token: 0x06021B7E RID: 138110 RVA: 0x008F3E7D File Offset: 0x008F207D
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_UI_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_UI_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x06021B7F RID: 138111 RVA: 0x008F3E92 File Offset: 0x008F2092
		// (set) Token: 0x06021B80 RID: 138112 RVA: 0x008F3EA2 File Offset: 0x008F20A2
		public unsafe bool 使用材质参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_UI_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_UI_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037F7 RID: 14327
		// (get) Token: 0x06021B81 RID: 138113 RVA: 0x008F3EB4 File Offset: 0x008F20B4
		// (set) Token: 0x06021B82 RID: 138114 RVA: 0x008F3EED File Offset: 0x008F20ED
		public TMap<FName, float> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_UI_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x170037F8 RID: 14328
		// (get) Token: 0x06021B83 RID: 138115 RVA: 0x008F3EFC File Offset: 0x008F20FC
		// (set) Token: 0x06021B84 RID: 138116 RVA: 0x008F3F35 File Offset: 0x008F2135
		public TMap<FName, FLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_UI_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x170037F9 RID: 14329
		// (get) Token: 0x06021B85 RID: 138117 RVA: 0x008F3F43 File Offset: 0x008F2143
		// (set) Token: 0x06021B86 RID: 138118 RVA: 0x008F3F57 File Offset: 0x008F2157
		public unsafe FLinearColor EmissionDayColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_UI_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_UI_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170037FA RID: 14330
		// (get) Token: 0x06021B87 RID: 138119 RVA: 0x008F3F6C File Offset: 0x008F216C
		// (set) Token: 0x06021B88 RID: 138120 RVA: 0x008F3F80 File Offset: 0x008F2180
		public unsafe FLinearColor EmissionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_UI_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_UI_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170037FB RID: 14331
		// (get) Token: 0x06021B89 RID: 138121 RVA: 0x008F3F95 File Offset: 0x008F2195
		// (set) Token: 0x06021B8A RID: 138122 RVA: 0x008F3FA5 File Offset: 0x008F21A5
		public unsafe bool UseWholeDayEmission
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_UI_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_UI_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037FC RID: 14332
		// (get) Token: 0x06021B8B RID: 138123 RVA: 0x008F3FB8 File Offset: 0x008F21B8
		// (set) Token: 0x06021B8C RID: 138124 RVA: 0x008F3FF1 File Offset: 0x008F21F1
		public TMap<AActor, FTransformDouble> ChildActors
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AActor, FTransformDouble> result;
				if ((result = this._ChildActors) == null)
				{
					result = (this._ChildActors = new TMap<AActor, FTransformDouble>(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_UI_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				this.ChildActors.CopyAssign(value);
			}
		}

		// Token: 0x06021B8D RID: 138125 RVA: 0x008F3FFF File Offset: 0x008F21FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RefreshChildActors()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_UI_C.__RefreshChildActors_NativeFunctionPtr, null);
		}

		// Token: 0x06021B8E RID: 138126 RVA: 0x008F4013 File Offset: 0x008F2213
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetMaterialParams()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_UI_C.__SetMaterialParams_NativeFunctionPtr, null);
		}

		// Token: 0x06021B8F RID: 138127 RVA: 0x008F4027 File Offset: 0x008F2227
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_UI_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021B90 RID: 138128 RVA: 0x008F403B File Offset: 0x008F223B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingStaticMesh_UI_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021B91 RID: 138129 RVA: 0x008F4050 File Offset: 0x008F2250
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_UI_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021B92 RID: 138130 RVA: 0x008F4064 File Offset: 0x008F2264
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingStaticMesh_UI_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021B93 RID: 138131 RVA: 0x008F4079 File Offset: 0x008F2279
		protected BP_FloatingStaticMesh_UI_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010739 RID: 67385
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_FloatingStaticMesh_UI.BP_FloatingStaticMesh_UI_C";

		// Token: 0x0401073A RID: 67386
		private static IntPtr _ClassPtr;

		// Token: 0x0401073B RID: 67387
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401073C RID: 67388
		internal static int __PropertyOffset_1;

		// Token: 0x0401073D RID: 67389
		internal static int __PropertyOffset_2;

		// Token: 0x0401073E RID: 67390
		internal static int __PropertyOffset_3;

		// Token: 0x0401073F RID: 67391
		internal static int __PropertyOffset_4;

		// Token: 0x04010740 RID: 67392
		internal static int __PropertyOffset_5;

		// Token: 0x04010741 RID: 67393
		[Nullable(2)]
		private TMap<FName, float> _FloatParameters;

		// Token: 0x04010742 RID: 67394
		internal static int __PropertyOffset_6;

		// Token: 0x04010743 RID: 67395
		[Nullable(2)]
		private TMap<FName, FLinearColor> _ColorParameters;

		// Token: 0x04010744 RID: 67396
		internal static int __PropertyOffset_7;

		// Token: 0x04010745 RID: 67397
		internal static int __PropertyOffset_8;

		// Token: 0x04010746 RID: 67398
		internal static int __PropertyOffset_9;

		// Token: 0x04010747 RID: 67399
		internal static int __PropertyOffset_10;

		// Token: 0x04010748 RID: 67400
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<AActor, FTransformDouble> _ChildActors;

		// Token: 0x04010749 RID: 67401
		private static IntPtr __RefreshChildActors_NativeFunctionPtr;

		// Token: 0x0401074A RID: 67402
		private static IntPtr __SetMaterialParams_NativeFunctionPtr;

		// Token: 0x0401074B RID: 67403
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401074C RID: 67404
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
