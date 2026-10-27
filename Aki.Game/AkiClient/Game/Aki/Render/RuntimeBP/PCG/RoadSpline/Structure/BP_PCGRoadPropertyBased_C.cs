using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline.Structure
{
	// Token: 0x02003C2C RID: 15404
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/Structure/BP_PCGRoadPropertyBased.BP_PCGRoadPropertyBased_C")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class BP_PCGRoadPropertyBased_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602362B RID: 144939 RVA: 0x00922AA4 File Offset: 0x00920CA4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PCGRoadPropertyBased_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/Structure/BP_PCGRoadPropertyBased.BP_PCGRoadPropertyBased_C");
			}
			return BP_PCGRoadPropertyBased_C._ClassPtr;
		}

		// Token: 0x0602362C RID: 144940 RVA: 0x00922AC8 File Offset: 0x00920CC8
		public BP_PCGRoadPropertyBased_C() : this(BuiltinUtils.AllocNativeUObject(BP_PCGRoadPropertyBased_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602362D RID: 144941 RVA: 0x00922AF0 File Offset: 0x00920CF0
		public BP_PCGRoadPropertyBased_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PCGRoadPropertyBased_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700410C RID: 16652
		// (get) Token: 0x0602362E RID: 144942 RVA: 0x00922B24 File Offset: 0x00920D24
		// (set) Token: 0x0602362F RID: 144943 RVA: 0x00922B5D File Offset: 0x00920D5D
		public SPCG_RoadPropertyBased 属性列表
		{
			get
			{
				base.FastCheckIsValid();
				SPCG_RoadPropertyBased result;
				if ((result = this._属性列表) == null)
				{
					result = (this._属性列表 = new SPCG_RoadPropertyBased(base.NativePtr + (IntPtr)BP_PCGRoadPropertyBased_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SPCG_RoadPropertyBased.StaticStruct(), base.NativePtr + (IntPtr)BP_PCGRoadPropertyBased_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023630 RID: 144944 RVA: 0x00922B7E File Offset: 0x00920D7E
		protected BP_PCGRoadPropertyBased_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401176E RID: 71534
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/Structure/BP_PCGRoadPropertyBased.BP_PCGRoadPropertyBased_C";

		// Token: 0x0401176F RID: 71535
		private static IntPtr _ClassPtr;

		// Token: 0x04011770 RID: 71536
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011771 RID: 71537
		internal static int __PropertyOffset_0;

		// Token: 0x04011772 RID: 71538
		[Nullable(2)]
		private SPCG_RoadPropertyBased _属性列表;
	}
}
