using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003257 RID: 12887
	[UnrealObjectPath("/Game/Aki/Core/Fight/BulletCampType.BulletCampType_C")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 84)]
	public class BulletCampType_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020343 RID: 131907 RVA: 0x0094005A File Offset: 0x0093E25A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BulletCampType_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/BulletCampType.BulletCampType_C");
			}
			return BulletCampType_C._ClassPtr;
		}

		// Token: 0x06020344 RID: 131908 RVA: 0x00940080 File Offset: 0x0093E280
		public BulletCampType_C() : this(BuiltinUtils.AllocNativeUObject(BulletCampType_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020345 RID: 131909 RVA: 0x009400A8 File Offset: 0x0093E2A8
		[NullableContext(1)]
		public BulletCampType_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BulletCampType_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003DD0 RID: 15824
		// (get) Token: 0x06020346 RID: 131910 RVA: 0x009400DB File Offset: 0x0093E2DB
		// (set) Token: 0x06020347 RID: 131911 RVA: 0x009400EB File Offset: 0x0093E2EB
		public unsafe int 阵营
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletCampType_C.__PropertyOffset_阵营);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletCampType_C.__PropertyOffset_阵营) = value;
			}
		}

		// Token: 0x06020348 RID: 131912 RVA: 0x009400FC File Offset: 0x0093E2FC
		protected BulletCampType_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401156F RID: 71023
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/BulletCampType.BulletCampType_C";

		// Token: 0x04011570 RID: 71024
		private static IntPtr _ClassPtr;

		// Token: 0x04011571 RID: 71025
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011572 RID: 71026
		internal static int __PropertyOffset_阵营;
	}
}
