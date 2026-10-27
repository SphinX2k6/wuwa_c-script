using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common
{
	// Token: 0x020040A1 RID: 16545
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abp_YangYang_Seq.Abp_YangYang_Seq_C")]
	[UnrealStructLayout(4432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4421)]
	public class Abp_YangYang_Seq_C : ABP_BaseSequenceRole_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AB5D RID: 174941 RVA: 0x009E9983 File Offset: 0x009E7B83
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (Abp_YangYang_Seq_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abp_YangYang_Seq.Abp_YangYang_Seq_C");
			}
			return Abp_YangYang_Seq_C._ClassPtr;
		}

		// Token: 0x0602AB5E RID: 174942 RVA: 0x009E99A8 File Offset: 0x009E7BA8
		public Abp_YangYang_Seq_C() : this(BuiltinUtils.AllocNativeUObject(Abp_YangYang_Seq_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AB5F RID: 174943 RVA: 0x009E99D0 File Offset: 0x009E7BD0
		[NullableContext(1)]
		public Abp_YangYang_Seq_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(Abp_YangYang_Seq_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AB60 RID: 174944 RVA: 0x009E9A03 File Offset: 0x009E7C03
		protected Abp_YangYang_Seq_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040161AC RID: 90540
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abp_YangYang_Seq.Abp_YangYang_Seq_C";

		// Token: 0x040161AD RID: 90541
		private static IntPtr _ClassPtr;

		// Token: 0x040161AE RID: 90542
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
