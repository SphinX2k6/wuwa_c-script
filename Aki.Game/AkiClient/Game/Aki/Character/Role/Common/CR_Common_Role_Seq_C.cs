using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common
{
	// Token: 0x020040A2 RID: 16546
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/CR_Common_Role_Seq.CR_Common_Role_Seq_C")]
	[UnrealStructLayout(2080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2076)]
	public class CR_Common_Role_Seq_C : UControlRig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AB61 RID: 174945 RVA: 0x009E9A0C File Offset: 0x009E7C0C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CR_Common_Role_Seq_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/CR_Common_Role_Seq.CR_Common_Role_Seq_C");
			}
			return CR_Common_Role_Seq_C._ClassPtr;
		}

		// Token: 0x0602AB62 RID: 174946 RVA: 0x009E9A30 File Offset: 0x009E7C30
		public CR_Common_Role_Seq_C() : this(BuiltinUtils.AllocNativeUObject(CR_Common_Role_Seq_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AB63 RID: 174947 RVA: 0x009E9A58 File Offset: 0x009E7C58
		[NullableContext(1)]
		public CR_Common_Role_Seq_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CR_Common_Role_Seq_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006912 RID: 26898
		// (get) Token: 0x0602AB64 RID: 174948 RVA: 0x009E9A8B File Offset: 0x009E7C8B
		// (set) Token: 0x0602AB65 RID: 174949 RVA: 0x009E9A9B File Offset: 0x009E7C9B
		public unsafe float eye_alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)CR_Common_Role_Seq_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)CR_Common_Role_Seq_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006913 RID: 26899
		// (get) Token: 0x0602AB66 RID: 174950 RVA: 0x009E9AAC File Offset: 0x009E7CAC
		// (set) Token: 0x0602AB67 RID: 174951 RVA: 0x009E9ABC File Offset: 0x009E7CBC
		public unsafe float eyebrow_alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)CR_Common_Role_Seq_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)CR_Common_Role_Seq_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006914 RID: 26900
		// (get) Token: 0x0602AB68 RID: 174952 RVA: 0x009E9ACD File Offset: 0x009E7CCD
		// (set) Token: 0x0602AB69 RID: 174953 RVA: 0x009E9ADD File Offset: 0x009E7CDD
		public unsafe float mouth_alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)CR_Common_Role_Seq_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)CR_Common_Role_Seq_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602AB6A RID: 174954 RVA: 0x009E9AEE File Offset: 0x009E7CEE
		protected CR_Common_Role_Seq_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040161AF RID: 90543
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/CR_Common_Role_Seq.CR_Common_Role_Seq_C";

		// Token: 0x040161B0 RID: 90544
		private static IntPtr _ClassPtr;

		// Token: 0x040161B1 RID: 90545
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040161B2 RID: 90546
		internal static int __PropertyOffset_0;

		// Token: 0x040161B3 RID: 90547
		internal static int __PropertyOffset_1;

		// Token: 0x040161B4 RID: 90548
		internal static int __PropertyOffset_2;
	}
}
