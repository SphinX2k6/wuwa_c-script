using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneInteraction
{
	// Token: 0x02003C1D RID: 15389
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_SplitCloth.BP_SplitCloth_C")]
	[UnrealStructLayout(1176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1176)]
	public class BP_SplitCloth_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060233FD RID: 144381 RVA: 0x0091ECD0 File Offset: 0x0091CED0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplitCloth_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_SplitCloth.BP_SplitCloth_C");
			}
			return BP_SplitCloth_C._ClassPtr;
		}

		// Token: 0x060233FE RID: 144382 RVA: 0x0091ECF4 File Offset: 0x0091CEF4
		public BP_SplitCloth_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplitCloth_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060233FF RID: 144383 RVA: 0x0091ED1C File Offset: 0x0091CF1C
		[NullableContext(1)]
		public BP_SplitCloth_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplitCloth_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004049 RID: 16457
		// (get) Token: 0x06023400 RID: 144384 RVA: 0x0091ED4F File Offset: 0x0091CF4F
		// (set) Token: 0x06023401 RID: 144385 RVA: 0x0091ED63 File Offset: 0x0091CF63
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitCloth_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitCloth_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700404A RID: 16458
		// (get) Token: 0x06023402 RID: 144386 RVA: 0x0091ED78 File Offset: 0x0091CF78
		// (set) Token: 0x06023403 RID: 144387 RVA: 0x0091ED8C File Offset: 0x0091CF8C
		public unsafe UStaticMeshComponent SM_Com3_Gra_06BS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitCloth_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitCloth_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700404B RID: 16459
		// (get) Token: 0x06023404 RID: 144388 RVA: 0x0091EDA1 File Offset: 0x0091CFA1
		// (set) Token: 0x06023405 RID: 144389 RVA: 0x0091EDB5 File Offset: 0x0091CFB5
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitCloth_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitCloth_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700404C RID: 16460
		// (get) Token: 0x06023406 RID: 144390 RVA: 0x0091EDCA File Offset: 0x0091CFCA
		// (set) Token: 0x06023407 RID: 144391 RVA: 0x0091EDDE File Offset: 0x0091CFDE
		public unsafe FVectorDouble AttackPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitCloth_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitCloth_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700404D RID: 16461
		// (get) Token: 0x06023408 RID: 144392 RVA: 0x0091EDF3 File Offset: 0x0091CFF3
		// (set) Token: 0x06023409 RID: 144393 RVA: 0x0091EE07 File Offset: 0x0091D007
		public unsafe FVectorDouble PlayerDirectory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitCloth_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitCloth_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700404E RID: 16462
		// (get) Token: 0x0602340A RID: 144394 RVA: 0x0091EE1C File Offset: 0x0091D01C
		// (set) Token: 0x0602340B RID: 144395 RVA: 0x0091EE30 File Offset: 0x0091D030
		public unsafe FVectorDouble PlayerPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitCloth_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitCloth_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700404F RID: 16463
		// (get) Token: 0x0602340C RID: 144396 RVA: 0x0091EE45 File Offset: 0x0091D045
		// (set) Token: 0x0602340D RID: 144397 RVA: 0x0091EE55 File Offset: 0x0091D055
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitCloth_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitCloth_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004050 RID: 16464
		// (get) Token: 0x0602340E RID: 144398 RVA: 0x0091EE66 File Offset: 0x0091D066
		// (set) Token: 0x0602340F RID: 144399 RVA: 0x0091EE76 File Offset: 0x0091D076
		public unsafe bool Splited
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitCloth_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitCloth_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004051 RID: 16465
		// (get) Token: 0x06023410 RID: 144400 RVA: 0x0091EE88 File Offset: 0x0091D088
		// (set) Token: 0x06023411 RID: 144401 RVA: 0x0091EEC1 File Offset: 0x0091D0C1
		[Nullable(1)]
		public TArray<TSoftObjectPtr<UObject>> Staticmesh
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UObject>> result;
				if ((result = this._Staticmesh) == null)
				{
					result = (this._Staticmesh = new TArray<TSoftObjectPtr<UObject>>(base.NativePtr + (IntPtr)BP_SplitCloth_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Staticmesh.CopyAssign(value);
			}
		}

		// Token: 0x06023412 RID: 144402 RVA: 0x0091EED0 File Offset: 0x0091D0D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnLoaded_25EAD0904F67E109FC4DF08D3AFE9413(UObject Loaded)
		{
			BP_SplitCloth_C.__OnLoaded_25EAD0904F67E109FC4DF08D3AFE9413_FunctionParams* ptr = stackalloc BP_SplitCloth_C.__OnLoaded_25EAD0904F67E109FC4DF08D3AFE9413_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SplitCloth_C.__OnLoaded_25EAD0904F67E109FC4DF08D3AFE9413_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitCloth_C.__OnLoaded_25EAD0904F67E109FC4DF08D3AFE9413_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Loaded = ((Loaded != null) ? Loaded.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitCloth_C.__OnLoaded_25EAD0904F67E109FC4DF08D3AFE9413_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023413 RID: 144403 RVA: 0x0091EF25 File Offset: 0x0091D125
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitCloth_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023414 RID: 144404 RVA: 0x0091EF39 File Offset: 0x0091D139
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplitCloth_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023415 RID: 144405 RVA: 0x0091EF50 File Offset: 0x0091D150
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_SplitCloth_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_SplitCloth_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_SplitCloth_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitCloth_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitCloth_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023416 RID: 144406 RVA: 0x0091EFB3 File Offset: 0x0091D1B3
		protected BP_SplitCloth_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011619 RID: 71193
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_SplitCloth.BP_SplitCloth_C";

		// Token: 0x0401161A RID: 71194
		private static IntPtr _ClassPtr;

		// Token: 0x0401161B RID: 71195
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401161C RID: 71196
		internal static int __PropertyOffset_1;

		// Token: 0x0401161D RID: 71197
		internal static int __PropertyOffset_2;

		// Token: 0x0401161E RID: 71198
		internal static int __PropertyOffset_3;

		// Token: 0x0401161F RID: 71199
		internal static int __PropertyOffset_4;

		// Token: 0x04011620 RID: 71200
		internal static int __PropertyOffset_5;

		// Token: 0x04011621 RID: 71201
		internal static int __PropertyOffset_6;

		// Token: 0x04011622 RID: 71202
		internal static int __PropertyOffset_7;

		// Token: 0x04011623 RID: 71203
		internal static int __PropertyOffset_8;

		// Token: 0x04011624 RID: 71204
		internal static int __PropertyOffset_9;

		// Token: 0x04011625 RID: 71205
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UObject>> _Staticmesh;

		// Token: 0x04011626 RID: 71206
		private static IntPtr __OnLoaded_25EAD0904F67E109FC4DF08D3AFE9413_NativeFunctionPtr;

		// Token: 0x04011627 RID: 71207
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011628 RID: 71208
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x02009E42 RID: 40514
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnLoaded_25EAD0904F67E109FC4DF08D3AFE9413_FunctionParams
		{
			// Token: 0x040316B1 RID: 202417
			[FieldOffset(0)]
			public IntPtr Loaded;
		}

		// Token: 0x02009E43 RID: 40515
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x040316B2 RID: 202418
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x040316B3 RID: 202419
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x040316B4 RID: 202420
			[FieldOffset(32)]
			public int Id;
		}
	}
}
