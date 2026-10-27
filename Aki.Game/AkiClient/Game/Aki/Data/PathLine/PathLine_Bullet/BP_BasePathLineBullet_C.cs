using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.PathLine.PathLine_Bullet
{
	// Token: 0x02003EE8 RID: 16104
	[UnrealObjectPath("/Game/Aki/Data/PathLine/PathLine_Bullet/BP_BasePathLineBullet.BP_BasePathLineBullet_C")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class BP_BasePathLineBullet_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028C76 RID: 167030 RVA: 0x009B46A9 File Offset: 0x009B28A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BasePathLineBullet_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/PathLine/PathLine_Bullet/BP_BasePathLineBullet.BP_BasePathLineBullet_C");
			}
			return BP_BasePathLineBullet_C._ClassPtr;
		}

		// Token: 0x06028C77 RID: 167031 RVA: 0x009B46D0 File Offset: 0x009B28D0
		public BP_BasePathLineBullet_C() : this(BuiltinUtils.AllocNativeUObject(BP_BasePathLineBullet_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028C78 RID: 167032 RVA: 0x009B46F8 File Offset: 0x009B28F8
		[NullableContext(1)]
		public BP_BasePathLineBullet_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BasePathLineBullet_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F94 RID: 24468
		// (get) Token: 0x06028C79 RID: 167033 RVA: 0x009B472B File Offset: 0x009B292B
		// (set) Token: 0x06028C7A RID: 167034 RVA: 0x009B473F File Offset: 0x009B293F
		[Nullable(2)]
		public unsafe USplineComponent Spline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLineBullet_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLineBullet_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06028C7B RID: 167035 RVA: 0x009B4754 File Offset: 0x009B2954
		protected BP_BasePathLineBullet_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014D84 RID: 85380
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/PathLine/PathLine_Bullet/BP_BasePathLineBullet.BP_BasePathLineBullet_C";

		// Token: 0x04014D85 RID: 85381
		private static IntPtr _ClassPtr;

		// Token: 0x04014D86 RID: 85382
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014D87 RID: 85383
		internal static int __PropertyOffset_0;
	}
}
