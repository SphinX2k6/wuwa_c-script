using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Destructible;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Water.BP
{
	// Token: 0x02003A88 RID: 14984
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Water/BP/BP_OceanHeight_Offset.BP_OceanHeight_Offset_C")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class BP_OceanHeight_Offset_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FD43 RID: 130371 RVA: 0x008C3B40 File Offset: 0x008C1D40
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_OceanHeight_Offset_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Water/BP/BP_OceanHeight_Offset.BP_OceanHeight_Offset_C");
			}
			return BP_OceanHeight_Offset_C._ClassPtr;
		}

		// Token: 0x0601FD44 RID: 130372 RVA: 0x008C3B64 File Offset: 0x008C1D64
		public BP_OceanHeight_Offset_C() : this(BuiltinUtils.AllocNativeUObject(BP_OceanHeight_Offset_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FD45 RID: 130373 RVA: 0x008C3B8C File Offset: 0x008C1D8C
		[NullableContext(1)]
		public BP_OceanHeight_Offset_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_OceanHeight_Offset_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D20 RID: 11552
		// (get) Token: 0x0601FD46 RID: 130374 RVA: 0x008C3BBF File Offset: 0x008C1DBF
		// (set) Token: 0x0601FD47 RID: 130375 RVA: 0x008C3BD3 File Offset: 0x008C1DD3
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanHeight_Offset_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanHeight_Offset_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002D21 RID: 11553
		// (get) Token: 0x0601FD48 RID: 130376 RVA: 0x008C3BE8 File Offset: 0x008C1DE8
		// (set) Token: 0x0601FD49 RID: 130377 RVA: 0x008C3BFC File Offset: 0x008C1DFC
		public unsafe UMaterialInstance Mat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanHeight_Offset_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanHeight_Offset_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002D22 RID: 11554
		// (get) Token: 0x0601FD4A RID: 130378 RVA: 0x008C3C11 File Offset: 0x008C1E11
		// (set) Token: 0x0601FD4B RID: 130379 RVA: 0x008C3C25 File Offset: 0x008C1E25
		public unsafe UStaticMeshComponent Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanHeight_Offset_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanHeight_Offset_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002D23 RID: 11555
		// (get) Token: 0x0601FD4C RID: 130380 RVA: 0x008C3C3A File Offset: 0x008C1E3A
		// (set) Token: 0x0601FD4D RID: 130381 RVA: 0x008C3C4E File Offset: 0x008C1E4E
		public unsafe BP_KuroSkeletalMeshDestructibleActor_C ParentActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_KuroSkeletalMeshDestructibleActor_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanHeight_Offset_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanHeight_Offset_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002D24 RID: 11556
		// (get) Token: 0x0601FD4E RID: 130382 RVA: 0x008C3C64 File Offset: 0x008C1E64
		// (set) Token: 0x0601FD4F RID: 130383 RVA: 0x008C3C9D File Offset: 0x008C1E9D
		[Nullable(1)]
		public TArray<UMaterialInstance> MaterialsArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._MaterialsArray) == null)
				{
					result = (this._MaterialsArray = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)BP_OceanHeight_Offset_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialsArray.CopyAssign(value);
			}
		}

		// Token: 0x17002D25 RID: 11557
		// (get) Token: 0x0601FD50 RID: 130384 RVA: 0x008C3CAC File Offset: 0x008C1EAC
		// (set) Token: 0x0601FD51 RID: 130385 RVA: 0x008C3CE5 File Offset: 0x008C1EE5
		[Nullable(1)]
		public TArray<FLinearColor> OceanRange
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._OceanRange) == null)
				{
					result = (this._OceanRange = new TArray<FLinearColor>(base.NativePtr + (IntPtr)BP_OceanHeight_Offset_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OceanRange.CopyAssign(value);
			}
		}

		// Token: 0x17002D26 RID: 11558
		// (get) Token: 0x0601FD52 RID: 130386 RVA: 0x008C3CF3 File Offset: 0x008C1EF3
		// (set) Token: 0x0601FD53 RID: 130387 RVA: 0x008C3D07 File Offset: 0x008C1F07
		public unsafe UMaterialInstance Mat_LOD
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanHeight_Offset_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanHeight_Offset_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x0601FD54 RID: 130388 RVA: 0x008C3D1C File Offset: 0x008C1F1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_OceanHeight_Offset_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FD55 RID: 130389 RVA: 0x008C3D30 File Offset: 0x008C1F30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_OceanHeight_Offset_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FD56 RID: 130390 RVA: 0x008C3D45 File Offset: 0x008C1F45
		protected BP_OceanHeight_Offset_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F57A RID: 62842
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Water/BP/BP_OceanHeight_Offset.BP_OceanHeight_Offset_C";

		// Token: 0x0400F57B RID: 62843
		private static IntPtr _ClassPtr;

		// Token: 0x0400F57C RID: 62844
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F57D RID: 62845
		internal static int __PropertyOffset_1;

		// Token: 0x0400F57E RID: 62846
		internal static int __PropertyOffset_2;

		// Token: 0x0400F57F RID: 62847
		internal static int __PropertyOffset_3;

		// Token: 0x0400F580 RID: 62848
		internal static int __PropertyOffset_4;

		// Token: 0x0400F581 RID: 62849
		internal static int __PropertyOffset_5;

		// Token: 0x0400F582 RID: 62850
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _MaterialsArray;

		// Token: 0x0400F583 RID: 62851
		internal static int __PropertyOffset_6;

		// Token: 0x0400F584 RID: 62852
		private TArray<FLinearColor> _OceanRange;

		// Token: 0x0400F585 RID: 62853
		internal static int __PropertyOffset_7;

		// Token: 0x0400F586 RID: 62854
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
