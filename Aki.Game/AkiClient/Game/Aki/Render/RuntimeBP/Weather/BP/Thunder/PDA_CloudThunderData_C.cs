using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Weather.BP.Thunder
{
	// Token: 0x02003A82 RID: 14978
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/PDA_CloudThunderData.PDA_CloudThunderData_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class PDA_CloudThunderData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FC8E RID: 130190 RVA: 0x008C2921 File Offset: 0x008C0B21
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_CloudThunderData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/PDA_CloudThunderData.PDA_CloudThunderData_C");
			}
			return PDA_CloudThunderData_C._ClassPtr;
		}

		// Token: 0x0601FC8F RID: 130191 RVA: 0x008C2948 File Offset: 0x008C0B48
		public PDA_CloudThunderData_C() : this(BuiltinUtils.AllocNativeUObject(PDA_CloudThunderData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FC90 RID: 130192 RVA: 0x008C2970 File Offset: 0x008C0B70
		public PDA_CloudThunderData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_CloudThunderData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CDC RID: 11484
		// (get) Token: 0x0601FC91 RID: 130193 RVA: 0x008C29A4 File Offset: 0x008C0BA4
		// (set) Token: 0x0601FC92 RID: 130194 RVA: 0x008C29DD File Offset: 0x008C0BDD
		public TArray<SCloudThunderInfo> DataInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCloudThunderInfo> result;
				if ((result = this._DataInfos) == null)
				{
					result = (this._DataInfos = new TArray<SCloudThunderInfo>(base.NativePtr + (IntPtr)PDA_CloudThunderData_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.DataInfos.CopyAssign(value);
			}
		}

		// Token: 0x0601FC93 RID: 130195 RVA: 0x008C29EB File Offset: 0x008C0BEB
		protected PDA_CloudThunderData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F510 RID: 62736
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/PDA_CloudThunderData.PDA_CloudThunderData_C";

		// Token: 0x0400F511 RID: 62737
		private static IntPtr _ClassPtr;

		// Token: 0x0400F512 RID: 62738
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F513 RID: 62739
		internal static int __PropertyOffset_0;

		// Token: 0x0400F514 RID: 62740
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCloudThunderInfo> _DataInfos;
	}
}
