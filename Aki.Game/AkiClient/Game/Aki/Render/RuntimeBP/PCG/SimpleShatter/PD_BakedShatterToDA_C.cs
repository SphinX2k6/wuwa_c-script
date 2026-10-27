using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SimpleShatter
{
	// Token: 0x02003BFD RID: 15357
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SimpleShatter/PD_BakedShatterToDA.PD_BakedShatterToDA_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PD_BakedShatterToDA_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F42 RID: 143170 RVA: 0x00916C92 File Offset: 0x00914E92
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_BakedShatterToDA_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SimpleShatter/PD_BakedShatterToDA.PD_BakedShatterToDA_C");
			}
			return PD_BakedShatterToDA_C._ClassPtr;
		}

		// Token: 0x06022F43 RID: 143171 RVA: 0x00916CB8 File Offset: 0x00914EB8
		public PD_BakedShatterToDA_C() : this(BuiltinUtils.AllocNativeUObject(PD_BakedShatterToDA_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F44 RID: 143172 RVA: 0x00916CE0 File Offset: 0x00914EE0
		public PD_BakedShatterToDA_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_BakedShatterToDA_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EA9 RID: 16041
		// (get) Token: 0x06022F45 RID: 143173 RVA: 0x00916D14 File Offset: 0x00914F14
		// (set) Token: 0x06022F46 RID: 143174 RVA: 0x00916D4D File Offset: 0x00914F4D
		public TMap<int, S_BakedShatter> SMTo2SMArr
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, S_BakedShatter> result;
				if ((result = this._SMTo2SMArr) == null)
				{
					result = (this._SMTo2SMArr = new TMap<int, S_BakedShatter>(base.NativePtr + (IntPtr)PD_BakedShatterToDA_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.SMTo2SMArr.CopyAssign(value);
			}
		}

		// Token: 0x06022F47 RID: 143175 RVA: 0x00916D5B File Offset: 0x00914F5B
		protected PD_BakedShatterToDA_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011351 RID: 70481
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SimpleShatter/PD_BakedShatterToDA.PD_BakedShatterToDA_C";

		// Token: 0x04011352 RID: 70482
		private static IntPtr _ClassPtr;

		// Token: 0x04011353 RID: 70483
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011354 RID: 70484
		internal static int __PropertyOffset_0;

		// Token: 0x04011355 RID: 70485
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, S_BakedShatter> _SMTo2SMArr;
	}
}
