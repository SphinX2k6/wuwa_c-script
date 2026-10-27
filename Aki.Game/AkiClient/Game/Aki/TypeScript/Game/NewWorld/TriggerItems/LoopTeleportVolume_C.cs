using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.TypeScript.Game.NewWorld.TriggerItems
{
	// Token: 0x02003A0F RID: 14863
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/LoopTeleportVolume.LoopTeleportVolume_C")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class LoopTeleportVolume_C : AKuroLoopTeleportVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F297 RID: 127639 RVA: 0x008AE62C File Offset: 0x008AC82C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (LoopTeleportVolume_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/LoopTeleportVolume.LoopTeleportVolume_C");
			}
			return LoopTeleportVolume_C._ClassPtr;
		}

		// Token: 0x0601F298 RID: 127640 RVA: 0x008AE650 File Offset: 0x008AC850
		public LoopTeleportVolume_C() : this(BuiltinUtils.AllocNativeUObject(LoopTeleportVolume_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F299 RID: 127641 RVA: 0x008AE678 File Offset: 0x008AC878
		[NullableContext(1)]
		public LoopTeleportVolume_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LoopTeleportVolume_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A0F RID: 10767
		// (get) Token: 0x0601F29A RID: 127642 RVA: 0x008AE6AB File Offset: 0x008AC8AB
		// (set) Token: 0x0601F29B RID: 127643 RVA: 0x008AE6BF File Offset: 0x008AC8BF
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + LoopTeleportVolume_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + LoopTeleportVolume_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0601F29C RID: 127644 RVA: 0x008AE6D4 File Offset: 0x008AC8D4
		protected LoopTeleportVolume_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EEC1 RID: 61121
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/TriggerItems/LoopTeleportVolume.LoopTeleportVolume_C";

		// Token: 0x0400EEC2 RID: 61122
		private static IntPtr _ClassPtr;

		// Token: 0x0400EEC3 RID: 61123
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EEC4 RID: 61124
		internal static int __PropertyOffset_0;
	}
}
