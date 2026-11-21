using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.StreamingSource
{
	// Token: 0x0200314A RID: 12618
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/StreamingSource/BP_StreamingSourceActor.BP_StreamingSourceActor_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_StreamingSourceActor_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F076 RID: 127094 RVA: 0x0092480E File Offset: 0x00922A0E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_StreamingSourceActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/StreamingSource/BP_StreamingSourceActor.BP_StreamingSourceActor_C");
			}
			return BP_StreamingSourceActor_C._ClassPtr;
		}

		// Token: 0x0601F077 RID: 127095 RVA: 0x00924834 File Offset: 0x00922A34
		public BP_StreamingSourceActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_StreamingSourceActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F078 RID: 127096 RVA: 0x0092485C File Offset: 0x00922A5C
		[NullableContext(1)]
		public BP_StreamingSourceActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_StreamingSourceActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036F5 RID: 14069
		// (get) Token: 0x0601F079 RID: 127097 RVA: 0x0092488F File Offset: 0x00922A8F
		// (set) Token: 0x0601F07A RID: 127098 RVA: 0x009248A3 File Offset: 0x00922AA3
		public unsafe UWorldPartitionStreamingSourceComponent WorldPartitionStreamingSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorldPartitionStreamingSourceComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StreamingSourceActor_C.__PropertyOffset_WorldPartitionStreamingSource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StreamingSourceActor_C.__PropertyOffset_WorldPartitionStreamingSource, value);
			}
		}

		// Token: 0x170036F6 RID: 14070
		// (get) Token: 0x0601F07B RID: 127099 RVA: 0x009248B8 File Offset: 0x00922AB8
		// (set) Token: 0x0601F07C RID: 127100 RVA: 0x009248CC File Offset: 0x00922ACC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StreamingSourceActor_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StreamingSourceActor_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x0601F07D RID: 127101 RVA: 0x009248E1 File Offset: 0x00922AE1
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StreamingSourceActor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601F07E RID: 127102 RVA: 0x009248F5 File Offset: 0x00922AF5
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StreamingSourceActor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601F07F RID: 127103 RVA: 0x00924909 File Offset: 0x00922B09
		protected BP_StreamingSourceActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010937 RID: 67895
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/StreamingSource/BP_StreamingSourceActor.BP_StreamingSourceActor_C";

		// Token: 0x04010938 RID: 67896
		private static IntPtr _ClassPtr;

		// Token: 0x04010939 RID: 67897
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401093A RID: 67898
		internal static int __PropertyOffset_WorldPartitionStreamingSource;

		// Token: 0x0401093B RID: 67899
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0401093C RID: 67900
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
