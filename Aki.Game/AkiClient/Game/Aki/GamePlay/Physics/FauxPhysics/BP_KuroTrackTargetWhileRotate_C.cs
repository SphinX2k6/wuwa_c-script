using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.Physics.FauxPhysics
{
	// Token: 0x02003E5A RID: 15962
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/Physics/FauxPhysics/BP_KuroTrackTargetWhileRotate.BP_KuroTrackTargetWhileRotate_C")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class BP_KuroTrackTargetWhileRotate_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602820D RID: 164365 RVA: 0x009A4D12 File Offset: 0x009A2F12
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroTrackTargetWhileRotate_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/Physics/FauxPhysics/BP_KuroTrackTargetWhileRotate.BP_KuroTrackTargetWhileRotate_C");
			}
			return BP_KuroTrackTargetWhileRotate_C._ClassPtr;
		}

		// Token: 0x0602820E RID: 164366 RVA: 0x009A4D38 File Offset: 0x009A2F38
		public BP_KuroTrackTargetWhileRotate_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroTrackTargetWhileRotate_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602820F RID: 164367 RVA: 0x009A4D60 File Offset: 0x009A2F60
		[NullableContext(1)]
		public BP_KuroTrackTargetWhileRotate_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroTrackTargetWhileRotate_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BDB RID: 23515
		// (get) Token: 0x06028210 RID: 164368 RVA: 0x009A4D93 File Offset: 0x009A2F93
		// (set) Token: 0x06028211 RID: 164369 RVA: 0x009A4DA7 File Offset: 0x009A2FA7
		public unsafe UKuroFauxPhysicsAxisRotateComponent KuroFauxPhysicsAxisRotate
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFauxPhysicsAxisRotateComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005BDC RID: 23516
		// (get) Token: 0x06028212 RID: 164370 RVA: 0x009A4DBC File Offset: 0x009A2FBC
		// (set) Token: 0x06028213 RID: 164371 RVA: 0x009A4DD0 File Offset: 0x009A2FD0
		public unsafe UKuroFauxPhysicsConeRotateComponent KuroFauxPhysicsConeRotate
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFauxPhysicsConeRotateComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005BDD RID: 23517
		// (get) Token: 0x06028214 RID: 164372 RVA: 0x009A4DE5 File Offset: 0x009A2FE5
		// (set) Token: 0x06028215 RID: 164373 RVA: 0x009A4DF9 File Offset: 0x009A2FF9
		public unsafe UKuroFauxPhysicsFreeRotateComponent KuroFauxPhysicsFreeRotate
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFauxPhysicsFreeRotateComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005BDE RID: 23518
		// (get) Token: 0x06028216 RID: 164374 RVA: 0x009A4E0E File Offset: 0x009A300E
		// (set) Token: 0x06028217 RID: 164375 RVA: 0x009A4E22 File Offset: 0x009A3022
		public unsafe UKuroFauxPhysicsTrackTargetComponent KuroFauxPhysicsTrackTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFauxPhysicsTrackTargetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x06028218 RID: 164376 RVA: 0x009A4E37 File Offset: 0x009A3037
		protected BP_KuroTrackTargetWhileRotate_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040146CA RID: 83658
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/Physics/FauxPhysics/BP_KuroTrackTargetWhileRotate.BP_KuroTrackTargetWhileRotate_C";

		// Token: 0x040146CB RID: 83659
		private static IntPtr _ClassPtr;

		// Token: 0x040146CC RID: 83660
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040146CD RID: 83661
		internal static int __PropertyOffset_0;

		// Token: 0x040146CE RID: 83662
		internal static int __PropertyOffset_1;

		// Token: 0x040146CF RID: 83663
		internal static int __PropertyOffset_2;

		// Token: 0x040146D0 RID: 83664
		internal static int __PropertyOffset_3;
	}
}
