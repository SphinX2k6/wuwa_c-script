using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020040A7 RID: 16551
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/BP_FirstPersonConfigMap.BP_FirstPersonConfigMap_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class BP_FirstPersonConfigMap_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AB80 RID: 174976 RVA: 0x009E9D5E File Offset: 0x009E7F5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FirstPersonConfigMap_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/Structure/BP_FirstPersonConfigMap.BP_FirstPersonConfigMap_C");
			}
			return BP_FirstPersonConfigMap_C._ClassPtr;
		}

		// Token: 0x0602AB81 RID: 174977 RVA: 0x009E9D84 File Offset: 0x009E7F84
		public BP_FirstPersonConfigMap_C() : this(BuiltinUtils.AllocNativeUObject(BP_FirstPersonConfigMap_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AB82 RID: 174978 RVA: 0x009E9DAC File Offset: 0x009E7FAC
		public BP_FirstPersonConfigMap_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FirstPersonConfigMap_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006915 RID: 26901
		// (get) Token: 0x0602AB83 RID: 174979 RVA: 0x009E9DE0 File Offset: 0x009E7FE0
		// (set) Token: 0x0602AB84 RID: 174980 RVA: 0x009E9E19 File Offset: 0x009E8019
		public TMap<FGameplayTag, TSoftObjectPtr<BP_FirstPersonConfig_C>> TagToConfigMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, TSoftObjectPtr<BP_FirstPersonConfig_C>> result;
				if ((result = this._TagToConfigMap) == null)
				{
					result = (this._TagToConfigMap = new TMap<FGameplayTag, TSoftObjectPtr<BP_FirstPersonConfig_C>>(base.NativePtr + (IntPtr)BP_FirstPersonConfigMap_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.TagToConfigMap.CopyAssign(value);
			}
		}

		// Token: 0x0602AB85 RID: 174981 RVA: 0x009E9E27 File Offset: 0x009E8027
		protected BP_FirstPersonConfigMap_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040161BB RID: 90555
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/BP_FirstPersonConfigMap.BP_FirstPersonConfigMap_C";

		// Token: 0x040161BC RID: 90556
		private static IntPtr _ClassPtr;

		// Token: 0x040161BD RID: 90557
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040161BE RID: 90558
		internal static int __PropertyOffset_0;

		// Token: 0x040161BF RID: 90559
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FGameplayTag, TSoftObjectPtr<BP_FirstPersonConfig_C>> _TagToConfigMap;
	}
}
