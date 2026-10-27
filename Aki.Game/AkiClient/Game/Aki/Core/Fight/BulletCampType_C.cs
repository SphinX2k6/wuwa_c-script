using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003FEF RID: 16367
	[UnrealObjectPath("/Game/Aki/Core/Fight/BulletCampType.BulletCampType_C")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 84)]
	public class BulletCampType_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029F5A RID: 171866 RVA: 0x009D1EC6 File Offset: 0x009D00C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BulletCampType_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/BulletCampType.BulletCampType_C");
			}
			return BulletCampType_C._ClassPtr;
		}

		// Token: 0x06029F5B RID: 171867 RVA: 0x009D1EEC File Offset: 0x009D00EC
		public BulletCampType_C() : this(BuiltinUtils.AllocNativeUObject(BulletCampType_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029F5C RID: 171868 RVA: 0x009D1F14 File Offset: 0x009D0114
		[NullableContext(1)]
		public BulletCampType_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BulletCampType_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006600 RID: 26112
		// (get) Token: 0x06029F5D RID: 171869 RVA: 0x009D1F47 File Offset: 0x009D0147
		// (set) Token: 0x06029F5E RID: 171870 RVA: 0x009D1F57 File Offset: 0x009D0157
		public unsafe int 阵营
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletCampType_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletCampType_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x06029F5F RID: 171871 RVA: 0x009D1F68 File Offset: 0x009D0168
		protected BulletCampType_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040158FA RID: 88314
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/BulletCampType.BulletCampType_C";

		// Token: 0x040158FB RID: 88315
		private static IntPtr _ClassPtr;

		// Token: 0x040158FC RID: 88316
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040158FD RID: 88317
		internal static int __PropertyOffset_0;
	}
}
