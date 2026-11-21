using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003259 RID: 12889
	[UnrealObjectPath("/Game/Aki/Core/Fight/DefaultBulletSceneInteraction.DefaultBulletSceneInteraction_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class DefaultBulletSceneInteraction_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020373 RID: 131955 RVA: 0x0094045F File Offset: 0x0093E65F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (DefaultBulletSceneInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/DefaultBulletSceneInteraction.DefaultBulletSceneInteraction_C");
			}
			return DefaultBulletSceneInteraction_C._ClassPtr;
		}

		// Token: 0x06020374 RID: 131956 RVA: 0x00940484 File Offset: 0x0093E684
		public DefaultBulletSceneInteraction_C() : this(BuiltinUtils.AllocNativeUObject(DefaultBulletSceneInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020375 RID: 131957 RVA: 0x009404AC File Offset: 0x0093E6AC
		[NullableContext(1)]
		public DefaultBulletSceneInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(DefaultBulletSceneInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06020376 RID: 131958 RVA: 0x009404DF File Offset: 0x0093E6DF
		protected DefaultBulletSceneInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401158A RID: 71050
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/DefaultBulletSceneInteraction.DefaultBulletSceneInteraction_C";

		// Token: 0x0401158B RID: 71051
		private static IntPtr _ClassPtr;

		// Token: 0x0401158C RID: 71052
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
