using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.WuWaGo
{
	// Token: 0x02003F2B RID: 16171
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo_WallBox.BP_WuWaGo_WallBox_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1096)]
	public class BP_WuWaGo_WallBox_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029192 RID: 168338 RVA: 0x009BBC44 File Offset: 0x009B9E44
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WuWaGo_WallBox_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo_WallBox.BP_WuWaGo_WallBox_C");
			}
			return BP_WuWaGo_WallBox_C._ClassPtr;
		}

		// Token: 0x06029193 RID: 168339 RVA: 0x009BBC68 File Offset: 0x009B9E68
		public BP_WuWaGo_WallBox_C() : this(BuiltinUtils.AllocNativeUObject(BP_WuWaGo_WallBox_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029194 RID: 168340 RVA: 0x009BBC90 File Offset: 0x009B9E90
		[NullableContext(1)]
		public BP_WuWaGo_WallBox_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WuWaGo_WallBox_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006173 RID: 24947
		// (get) Token: 0x06029195 RID: 168341 RVA: 0x009BBCC3 File Offset: 0x009B9EC3
		// (set) Token: 0x06029196 RID: 168342 RVA: 0x009BBCD7 File Offset: 0x009B9ED7
		public unsafe UStaticMeshComponent 模型
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006174 RID: 24948
		// (get) Token: 0x06029197 RID: 168343 RVA: 0x009BBCEC File Offset: 0x009B9EEC
		// (set) Token: 0x06029198 RID: 168344 RVA: 0x009BBD00 File Offset: 0x009B9F00
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006175 RID: 24949
		// (get) Token: 0x06029199 RID: 168345 RVA: 0x009BBD15 File Offset: 0x009B9F15
		// (set) Token: 0x0602919A RID: 168346 RVA: 0x009BBD29 File Offset: 0x009B9F29
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17006176 RID: 24950
		// (get) Token: 0x0602919B RID: 168347 RVA: 0x009BBD3E File Offset: 0x009B9F3E
		// (set) Token: 0x0602919C RID: 168348 RVA: 0x009BBD52 File Offset: 0x009B9F52
		public unsafe UMaterialInstance W_默认贴花
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17006177 RID: 24951
		// (get) Token: 0x0602919D RID: 168349 RVA: 0x009BBD67 File Offset: 0x009B9F67
		// (set) Token: 0x0602919E RID: 168350 RVA: 0x009BBD7B File Offset: 0x009B9F7B
		public unsafe UStaticMesh W_默认模型
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x0602919F RID: 168351 RVA: 0x009BBD90 File Offset: 0x009B9F90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WuWaGo_WallBox_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060291A0 RID: 168352 RVA: 0x009BBDA4 File Offset: 0x009B9FA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WuWaGo_WallBox_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060291A1 RID: 168353 RVA: 0x009BBDB9 File Offset: 0x009B9FB9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WuWaGo_WallBox_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060291A2 RID: 168354 RVA: 0x009BBDCD File Offset: 0x009B9FCD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WuWaGo_WallBox_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060291A3 RID: 168355 RVA: 0x009BBDE2 File Offset: 0x009B9FE2
		protected BP_WuWaGo_WallBox_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015094 RID: 86164
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo_WallBox.BP_WuWaGo_WallBox_C";

		// Token: 0x04015095 RID: 86165
		private static IntPtr _ClassPtr;

		// Token: 0x04015096 RID: 86166
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015097 RID: 86167
		internal static int __PropertyOffset_1;

		// Token: 0x04015098 RID: 86168
		internal static int __PropertyOffset_2;

		// Token: 0x04015099 RID: 86169
		internal static int __PropertyOffset_3;

		// Token: 0x0401509A RID: 86170
		internal static int __PropertyOffset_4;

		// Token: 0x0401509B RID: 86171
		internal static int __PropertyOffset_5;

		// Token: 0x0401509C RID: 86172
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401509D RID: 86173
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
