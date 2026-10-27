using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.StreamingSource
{
	// Token: 0x02003E53 RID: 15955
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/StreamingSource/BP_StreamingSourceActor.BP_StreamingSourceActor_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_StreamingSourceActor_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602819A RID: 164250 RVA: 0x009A3FA6 File Offset: 0x009A21A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_StreamingSourceActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/StreamingSource/BP_StreamingSourceActor.BP_StreamingSourceActor_C");
			}
			return BP_StreamingSourceActor_C._ClassPtr;
		}

		// Token: 0x0602819B RID: 164251 RVA: 0x009A3FCC File Offset: 0x009A21CC
		public BP_StreamingSourceActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_StreamingSourceActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602819C RID: 164252 RVA: 0x009A3FF4 File Offset: 0x009A21F4
		[NullableContext(1)]
		public BP_StreamingSourceActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_StreamingSourceActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BBF RID: 23487
		// (get) Token: 0x0602819D RID: 164253 RVA: 0x009A4027 File Offset: 0x009A2227
		// (set) Token: 0x0602819E RID: 164254 RVA: 0x009A403B File Offset: 0x009A223B
		public unsafe UWorldPartitionStreamingSourceComponent WorldPartitionStreamingSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorldPartitionStreamingSourceComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StreamingSourceActor_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StreamingSourceActor_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005BC0 RID: 23488
		// (get) Token: 0x0602819F RID: 164255 RVA: 0x009A4050 File Offset: 0x009A2250
		// (set) Token: 0x060281A0 RID: 164256 RVA: 0x009A4064 File Offset: 0x009A2264
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StreamingSourceActor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StreamingSourceActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x060281A1 RID: 164257 RVA: 0x009A4079 File Offset: 0x009A2279
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StreamingSourceActor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060281A2 RID: 164258 RVA: 0x009A408D File Offset: 0x009A228D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StreamingSourceActor_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060281A3 RID: 164259 RVA: 0x009A40A2 File Offset: 0x009A22A2
		protected BP_StreamingSourceActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401468B RID: 83595
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/StreamingSource/BP_StreamingSourceActor.BP_StreamingSourceActor_C";

		// Token: 0x0401468C RID: 83596
		private static IntPtr _ClassPtr;

		// Token: 0x0401468D RID: 83597
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401468E RID: 83598
		internal static int __PropertyOffset_0;

		// Token: 0x0401468F RID: 83599
		internal static int __PropertyOffset_1;

		// Token: 0x04014690 RID: 83600
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
