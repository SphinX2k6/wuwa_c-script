using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020032A3 RID: 12963
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/BP_SpecialTagConfig.BP_SpecialTagConfig_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class BP_SpecialTagConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060209A9 RID: 133545 RVA: 0x0094ABD7 File Offset: 0x00948DD7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SpecialTagConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/Structure/BP_SpecialTagConfig.BP_SpecialTagConfig_C");
			}
			return BP_SpecialTagConfig_C._ClassPtr;
		}

		// Token: 0x060209AA RID: 133546 RVA: 0x0094ABFC File Offset: 0x00948DFC
		public BP_SpecialTagConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SpecialTagConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060209AB RID: 133547 RVA: 0x0094AC24 File Offset: 0x00948E24
		public BP_SpecialTagConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SpecialTagConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004004 RID: 16388
		// (get) Token: 0x060209AC RID: 133548 RVA: 0x0094AC58 File Offset: 0x00948E58
		// (set) Token: 0x060209AD RID: 133549 RVA: 0x0094AC91 File Offset: 0x00948E91
		public SSpecialTagListenerInfo SpecialTagListener
		{
			get
			{
				base.FastCheckIsValid();
				SSpecialTagListenerInfo result;
				if ((result = this._SpecialTagListener) == null)
				{
					result = (this._SpecialTagListener = new SSpecialTagListenerInfo(base.NativePtr + (IntPtr)BP_SpecialTagConfig_C.__PropertyOffset_SpecialTagListener, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSpecialTagListenerInfo.StaticStruct(), base.NativePtr + (IntPtr)BP_SpecialTagConfig_C.__PropertyOffset_SpecialTagListener, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060209AE RID: 133550 RVA: 0x0094ACB2 File Offset: 0x00948EB2
		protected BP_SpecialTagConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040119FC RID: 72188
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/BP_SpecialTagConfig.BP_SpecialTagConfig_C";

		// Token: 0x040119FD RID: 72189
		private static IntPtr _ClassPtr;

		// Token: 0x040119FE RID: 72190
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040119FF RID: 72191
		internal static int __PropertyOffset_SpecialTagListener;

		// Token: 0x04011A00 RID: 72192
		[Nullable(2)]
		private SSpecialTagListenerInfo _SpecialTagListener;
	}
}
