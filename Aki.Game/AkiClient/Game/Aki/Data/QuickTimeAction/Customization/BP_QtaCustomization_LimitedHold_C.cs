using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction.Customization
{
	// Token: 0x02003184 RID: 12676
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/Customization/BP_QtaCustomization_LimitedHold.BP_QtaCustomization_LimitedHold_C")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class BP_QtaCustomization_LimitedHold_C : BP_QtaCustomizationBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F450 RID: 128080 RVA: 0x0092A0B4 File Offset: 0x009282B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_QtaCustomization_LimitedHold_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/QuickTimeAction/Customization/BP_QtaCustomization_LimitedHold.BP_QtaCustomization_LimitedHold_C");
			}
			return BP_QtaCustomization_LimitedHold_C._ClassPtr;
		}

		// Token: 0x0601F451 RID: 128081 RVA: 0x0092A0D8 File Offset: 0x009282D8
		public BP_QtaCustomization_LimitedHold_C() : this(BuiltinUtils.AllocNativeUObject(BP_QtaCustomization_LimitedHold_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F452 RID: 128082 RVA: 0x0092A100 File Offset: 0x00928300
		public BP_QtaCustomization_LimitedHold_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_QtaCustomization_LimitedHold_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003862 RID: 14434
		// (get) Token: 0x0601F453 RID: 128083 RVA: 0x0092A134 File Offset: 0x00928334
		// (set) Token: 0x0601F454 RID: 128084 RVA: 0x0092A16D File Offset: 0x0092836D
		public SQtaCustomization_LimitedHold Config
		{
			get
			{
				base.FastCheckIsValid();
				SQtaCustomization_LimitedHold result;
				if ((result = this._Config) == null)
				{
					result = (this._Config = new SQtaCustomization_LimitedHold(base.NativePtr + (IntPtr)BP_QtaCustomization_LimitedHold_C.__PropertyOffset_Config, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaCustomization_LimitedHold.StaticStruct(), base.NativePtr + (IntPtr)BP_QtaCustomization_LimitedHold_C.__PropertyOffset_Config, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F455 RID: 128085 RVA: 0x0092A18E File Offset: 0x0092838E
		protected BP_QtaCustomization_LimitedHold_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010BBB RID: 68539
		public new const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/Customization/BP_QtaCustomization_LimitedHold.BP_QtaCustomization_LimitedHold_C";

		// Token: 0x04010BBC RID: 68540
		private static IntPtr _ClassPtr;

		// Token: 0x04010BBD RID: 68541
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010BBE RID: 68542
		internal static int __PropertyOffset_Config;

		// Token: 0x04010BBF RID: 68543
		[Nullable(2)]
		private SQtaCustomization_LimitedHold _Config;
	}
}
