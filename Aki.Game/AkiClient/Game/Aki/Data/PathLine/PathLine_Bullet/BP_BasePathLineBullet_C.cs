using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.PathLine.PathLine_Bullet
{
	// Token: 0x020031AA RID: 12714
	[UnrealObjectPath("/Game/Aki/Data/PathLine/PathLine_Bullet/BP_BasePathLineBullet.BP_BasePathLineBullet_C")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class BP_BasePathLineBullet_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F653 RID: 128595 RVA: 0x0092CDA8 File Offset: 0x0092AFA8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BasePathLineBullet_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/PathLine/PathLine_Bullet/BP_BasePathLineBullet.BP_BasePathLineBullet_C");
			}
			return BP_BasePathLineBullet_C._ClassPtr;
		}

		// Token: 0x0601F654 RID: 128596 RVA: 0x0092CDCC File Offset: 0x0092AFCC
		public BP_BasePathLineBullet_C() : this(BuiltinUtils.AllocNativeUObject(BP_BasePathLineBullet_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F655 RID: 128597 RVA: 0x0092CDF4 File Offset: 0x0092AFF4
		[NullableContext(1)]
		public BP_BasePathLineBullet_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BasePathLineBullet_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x0601F656 RID: 128598 RVA: 0x0092CE27 File Offset: 0x0092B027
		// (set) Token: 0x0601F657 RID: 128599 RVA: 0x0092CE3B File Offset: 0x0092B03B
		[Nullable(2)]
		public unsafe USplineComponent Spline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLineBullet_C.__PropertyOffset_Spline);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLineBullet_C.__PropertyOffset_Spline, value);
			}
		}

		// Token: 0x0601F658 RID: 128600 RVA: 0x0092CE50 File Offset: 0x0092B050
		protected BP_BasePathLineBullet_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D45 RID: 68933
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/PathLine/PathLine_Bullet/BP_BasePathLineBullet.BP_BasePathLineBullet_C";

		// Token: 0x04010D46 RID: 68934
		private static IntPtr _ClassPtr;

		// Token: 0x04010D47 RID: 68935
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D48 RID: 68936
		internal static int __PropertyOffset_Spline;
	}
}
