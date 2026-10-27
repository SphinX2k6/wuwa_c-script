using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.AI.AIMoveSplineCount
{
	// Token: 0x0200443A RID: 17466
	[UnrealObjectPath("/Game/Aki/AI/AIMoveSplineCount/CommonEffectMoveSpline2.CommonEffectMoveSpline2_C")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class CommonEffectMoveSpline2_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D374 RID: 185204 RVA: 0x00A365CD File Offset: 0x00A347CD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CommonEffectMoveSpline2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/AI/AIMoveSplineCount/CommonEffectMoveSpline2.CommonEffectMoveSpline2_C");
			}
			return CommonEffectMoveSpline2_C._ClassPtr;
		}

		// Token: 0x0602D375 RID: 185205 RVA: 0x00A365F4 File Offset: 0x00A347F4
		public CommonEffectMoveSpline2_C() : this(BuiltinUtils.AllocNativeUObject(CommonEffectMoveSpline2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D376 RID: 185206 RVA: 0x00A3661C File Offset: 0x00A3481C
		[NullableContext(1)]
		public CommonEffectMoveSpline2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CommonEffectMoveSpline2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007294 RID: 29332
		// (get) Token: 0x0602D377 RID: 185207 RVA: 0x00A3664F File Offset: 0x00A3484F
		// (set) Token: 0x0602D378 RID: 185208 RVA: 0x00A36663 File Offset: 0x00A34863
		[Nullable(2)]
		public unsafe UKuroMoveSplineComponent KuroMoveSpline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMoveSplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + CommonEffectMoveSpline2_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + CommonEffectMoveSpline2_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602D379 RID: 185209 RVA: 0x00A36678 File Offset: 0x00A34878
		protected CommonEffectMoveSpline2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04018095 RID: 98453
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/AI/AIMoveSplineCount/CommonEffectMoveSpline2.CommonEffectMoveSpline2_C";

		// Token: 0x04018096 RID: 98454
		private static IntPtr _ClassPtr;

		// Token: 0x04018097 RID: 98455
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04018098 RID: 98456
		internal static int __PropertyOffset_0;
	}
}
