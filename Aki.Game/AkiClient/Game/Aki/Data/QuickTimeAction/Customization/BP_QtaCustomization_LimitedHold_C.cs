using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003EB7 RID: 16055
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/BP_QtaCustomization_LimitedHold.BP_QtaCustomization_LimitedHold_C")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class BP_QtaCustomization_LimitedHold_C : BP_QtaCustomizationBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060289B2 RID: 166322 RVA: 0x009B0544 File Offset: 0x009AE744
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_QtaCustomization_LimitedHold_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/QuickTimeAction/Customization/BP_QtaCustomization_LimitedHold.BP_QtaCustomization_LimitedHold_C");
			}
			return BP_QtaCustomization_LimitedHold_C._ClassPtr;
		}

		// Token: 0x060289B3 RID: 166323 RVA: 0x009B0568 File Offset: 0x009AE768
		public BP_QtaCustomization_LimitedHold_C() : this(BuiltinUtils.AllocNativeUObject(BP_QtaCustomization_LimitedHold_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060289B4 RID: 166324 RVA: 0x009B0590 File Offset: 0x009AE790
		public BP_QtaCustomization_LimitedHold_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_QtaCustomization_LimitedHold_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005EB2 RID: 24242
		// (get) Token: 0x060289B5 RID: 166325 RVA: 0x009B05C4 File Offset: 0x009AE7C4
		// (set) Token: 0x060289B6 RID: 166326 RVA: 0x009B05FD File Offset: 0x009AE7FD
		public SQtaCustomization_LimitedHold Config
		{
			get
			{
				base.FastCheckIsValid();
				SQtaCustomization_LimitedHold result;
				if ((result = this._Config) == null)
				{
					result = (this._Config = new SQtaCustomization_LimitedHold(base.NativePtr + (IntPtr)BP_QtaCustomization_LimitedHold_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaCustomization_LimitedHold.StaticStruct(), base.NativePtr + (IntPtr)BP_QtaCustomization_LimitedHold_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060289B7 RID: 166327 RVA: 0x009B061E File Offset: 0x009AE81E
		protected BP_QtaCustomization_LimitedHold_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014B93 RID: 84883
		public new const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/Customization/BP_QtaCustomization_LimitedHold.BP_QtaCustomization_LimitedHold_C";

		// Token: 0x04014B94 RID: 84884
		private static IntPtr _ClassPtr;

		// Token: 0x04014B95 RID: 84885
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014B96 RID: 84886
		internal static int __PropertyOffset_0;

		// Token: 0x04014B97 RID: 84887
		[Nullable(2)]
		private SQtaCustomization_LimitedHold _Config;
	}
}
