using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020040AD RID: 16557
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/BP_SpecialTagConfig.BP_SpecialTagConfig_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class BP_SpecialTagConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AC58 RID: 175192 RVA: 0x009EB014 File Offset: 0x009E9214
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SpecialTagConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/Structure/BP_SpecialTagConfig.BP_SpecialTagConfig_C");
			}
			return BP_SpecialTagConfig_C._ClassPtr;
		}

		// Token: 0x0602AC59 RID: 175193 RVA: 0x009EB038 File Offset: 0x009E9238
		public BP_SpecialTagConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SpecialTagConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AC5A RID: 175194 RVA: 0x009EB060 File Offset: 0x009E9260
		public BP_SpecialTagConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SpecialTagConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006975 RID: 26997
		// (get) Token: 0x0602AC5B RID: 175195 RVA: 0x009EB094 File Offset: 0x009E9294
		// (set) Token: 0x0602AC5C RID: 175196 RVA: 0x009EB0CD File Offset: 0x009E92CD
		public SSpecialTagListenerInfo SpecialTagListener
		{
			get
			{
				base.FastCheckIsValid();
				SSpecialTagListenerInfo result;
				if ((result = this._SpecialTagListener) == null)
				{
					result = (this._SpecialTagListener = new SSpecialTagListenerInfo(base.NativePtr + (IntPtr)BP_SpecialTagConfig_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSpecialTagListenerInfo.StaticStruct(), base.NativePtr + (IntPtr)BP_SpecialTagConfig_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602AC5D RID: 175197 RVA: 0x009EB0EE File Offset: 0x009E92EE
		protected BP_SpecialTagConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016239 RID: 90681
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/BP_SpecialTagConfig.BP_SpecialTagConfig_C";

		// Token: 0x0401623A RID: 90682
		private static IntPtr _ClassPtr;

		// Token: 0x0401623B RID: 90683
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401623C RID: 90684
		internal static int __PropertyOffset_0;

		// Token: 0x0401623D RID: 90685
		[Nullable(2)]
		private SSpecialTagListenerInfo _SpecialTagListener;
	}
}
