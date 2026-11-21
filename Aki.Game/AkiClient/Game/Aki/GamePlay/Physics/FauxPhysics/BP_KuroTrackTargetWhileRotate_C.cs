using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.Physics.FauxPhysics
{
	// Token: 0x0200314D RID: 12621
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/Physics/FauxPhysics/BP_KuroTrackTargetWhileRotate.BP_KuroTrackTargetWhileRotate_C")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class BP_KuroTrackTargetWhileRotate_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F0AC RID: 127148 RVA: 0x00924F56 File Offset: 0x00923156
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroTrackTargetWhileRotate_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/Physics/FauxPhysics/BP_KuroTrackTargetWhileRotate.BP_KuroTrackTargetWhileRotate_C");
			}
			return BP_KuroTrackTargetWhileRotate_C._ClassPtr;
		}

		// Token: 0x0601F0AD RID: 127149 RVA: 0x00924F7C File Offset: 0x0092317C
		public BP_KuroTrackTargetWhileRotate_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroTrackTargetWhileRotate_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F0AE RID: 127150 RVA: 0x00924FA4 File Offset: 0x009231A4
		[NullableContext(1)]
		public BP_KuroTrackTargetWhileRotate_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroTrackTargetWhileRotate_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003701 RID: 14081
		// (get) Token: 0x0601F0AF RID: 127151 RVA: 0x00924FD7 File Offset: 0x009231D7
		// (set) Token: 0x0601F0B0 RID: 127152 RVA: 0x00924FEB File Offset: 0x009231EB
		public unsafe UKuroFauxPhysicsAxisRotateComponent KuroFauxPhysicsAxisRotate
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFauxPhysicsAxisRotateComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_KuroFauxPhysicsAxisRotate);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_KuroFauxPhysicsAxisRotate, value);
			}
		}

		// Token: 0x17003702 RID: 14082
		// (get) Token: 0x0601F0B1 RID: 127153 RVA: 0x00925000 File Offset: 0x00923200
		// (set) Token: 0x0601F0B2 RID: 127154 RVA: 0x00925014 File Offset: 0x00923214
		public unsafe UKuroFauxPhysicsConeRotateComponent KuroFauxPhysicsConeRotate
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFauxPhysicsConeRotateComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_KuroFauxPhysicsConeRotate);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_KuroFauxPhysicsConeRotate, value);
			}
		}

		// Token: 0x17003703 RID: 14083
		// (get) Token: 0x0601F0B3 RID: 127155 RVA: 0x00925029 File Offset: 0x00923229
		// (set) Token: 0x0601F0B4 RID: 127156 RVA: 0x0092503D File Offset: 0x0092323D
		public unsafe UKuroFauxPhysicsFreeRotateComponent KuroFauxPhysicsFreeRotate
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFauxPhysicsFreeRotateComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_KuroFauxPhysicsFreeRotate);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_KuroFauxPhysicsFreeRotate, value);
			}
		}

		// Token: 0x17003704 RID: 14084
		// (get) Token: 0x0601F0B5 RID: 127157 RVA: 0x00925052 File Offset: 0x00923252
		// (set) Token: 0x0601F0B6 RID: 127158 RVA: 0x00925066 File Offset: 0x00923266
		public unsafe UKuroFauxPhysicsTrackTargetComponent KuroFauxPhysicsTrackTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFauxPhysicsTrackTargetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_KuroFauxPhysicsTrackTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTrackTargetWhileRotate_C.__PropertyOffset_KuroFauxPhysicsTrackTarget, value);
			}
		}

		// Token: 0x0601F0B7 RID: 127159 RVA: 0x0092507B File Offset: 0x0092327B
		protected BP_KuroTrackTargetWhileRotate_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010956 RID: 67926
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/Physics/FauxPhysics/BP_KuroTrackTargetWhileRotate.BP_KuroTrackTargetWhileRotate_C";

		// Token: 0x04010957 RID: 67927
		private static IntPtr _ClassPtr;

		// Token: 0x04010958 RID: 67928
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010959 RID: 67929
		internal static int __PropertyOffset_KuroFauxPhysicsAxisRotate;

		// Token: 0x0401095A RID: 67930
		internal static int __PropertyOffset_KuroFauxPhysicsConeRotate;

		// Token: 0x0401095B RID: 67931
		internal static int __PropertyOffset_KuroFauxPhysicsFreeRotate;

		// Token: 0x0401095C RID: 67932
		internal static int __PropertyOffset_KuroFauxPhysicsTrackTarget;
	}
}
