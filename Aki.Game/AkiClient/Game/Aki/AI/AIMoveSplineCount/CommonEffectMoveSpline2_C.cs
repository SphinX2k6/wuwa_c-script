using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.AI.AIMoveSplineCount
{
	// Token: 0x02003401 RID: 13313
	[UnrealObjectPath("/Game/Aki/AI/AIMoveSplineCount/CommonEffectMoveSpline2.CommonEffectMoveSpline2_C")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class CommonEffectMoveSpline2_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021CB8 RID: 138424 RVA: 0x0096B40F File Offset: 0x0096960F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CommonEffectMoveSpline2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/AI/AIMoveSplineCount/CommonEffectMoveSpline2.CommonEffectMoveSpline2_C");
			}
			return CommonEffectMoveSpline2_C._ClassPtr;
		}

		// Token: 0x06021CB9 RID: 138425 RVA: 0x0096B434 File Offset: 0x00969634
		public CommonEffectMoveSpline2_C() : this(BuiltinUtils.AllocNativeUObject(CommonEffectMoveSpline2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021CBA RID: 138426 RVA: 0x0096B45C File Offset: 0x0096965C
		[NullableContext(1)]
		public CommonEffectMoveSpline2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CommonEffectMoveSpline2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700461A RID: 17946
		// (get) Token: 0x06021CBB RID: 138427 RVA: 0x0096B48F File Offset: 0x0096968F
		// (set) Token: 0x06021CBC RID: 138428 RVA: 0x0096B4A3 File Offset: 0x009696A3
		[Nullable(2)]
		public unsafe UKuroMoveSplineComponent KuroMoveSpline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMoveSplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + CommonEffectMoveSpline2_C.__PropertyOffset_KuroMoveSpline);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + CommonEffectMoveSpline2_C.__PropertyOffset_KuroMoveSpline, value);
			}
		}

		// Token: 0x06021CBD RID: 138429 RVA: 0x0096B4B8 File Offset: 0x009696B8
		protected CommonEffectMoveSpline2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A24 RID: 76324
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/AI/AIMoveSplineCount/CommonEffectMoveSpline2.CommonEffectMoveSpline2_C";

		// Token: 0x04012A25 RID: 76325
		private static IntPtr _ClassPtr;

		// Token: 0x04012A26 RID: 76326
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A27 RID: 76327
		internal static int __PropertyOffset_KuroMoveSpline;
	}
}
