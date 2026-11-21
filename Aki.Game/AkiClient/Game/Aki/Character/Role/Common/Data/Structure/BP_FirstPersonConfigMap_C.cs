using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x0200329E RID: 12958
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/BP_FirstPersonConfigMap.BP_FirstPersonConfigMap_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class BP_FirstPersonConfigMap_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060208FD RID: 133373 RVA: 0x00949D2E File Offset: 0x00947F2E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FirstPersonConfigMap_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/Structure/BP_FirstPersonConfigMap.BP_FirstPersonConfigMap_C");
			}
			return BP_FirstPersonConfigMap_C._ClassPtr;
		}

		// Token: 0x060208FE RID: 133374 RVA: 0x00949D54 File Offset: 0x00947F54
		public BP_FirstPersonConfigMap_C() : this(BuiltinUtils.AllocNativeUObject(BP_FirstPersonConfigMap_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060208FF RID: 133375 RVA: 0x00949D7C File Offset: 0x00947F7C
		public BP_FirstPersonConfigMap_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FirstPersonConfigMap_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FB8 RID: 16312
		// (get) Token: 0x06020900 RID: 133376 RVA: 0x00949DB0 File Offset: 0x00947FB0
		// (set) Token: 0x06020901 RID: 133377 RVA: 0x00949DE9 File Offset: 0x00947FE9
		public TMap<FGameplayTag, TSoftObjectPtr<BP_FirstPersonConfig_C>> TagToConfigMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, TSoftObjectPtr<BP_FirstPersonConfig_C>> result;
				if ((result = this._TagToConfigMap) == null)
				{
					result = (this._TagToConfigMap = new TMap<FGameplayTag, TSoftObjectPtr<BP_FirstPersonConfig_C>>(base.NativePtr + (IntPtr)BP_FirstPersonConfigMap_C.__PropertyOffset_TagToConfigMap, this));
				}
				return result;
			}
			set
			{
				this.TagToConfigMap.CopyAssign(value);
			}
		}

		// Token: 0x06020902 RID: 133378 RVA: 0x00949DF7 File Offset: 0x00947FF7
		protected BP_FirstPersonConfigMap_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011999 RID: 72089
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/BP_FirstPersonConfigMap.BP_FirstPersonConfigMap_C";

		// Token: 0x0401199A RID: 72090
		private static IntPtr _ClassPtr;

		// Token: 0x0401199B RID: 72091
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401199C RID: 72092
		internal static int __PropertyOffset_TagToConfigMap;

		// Token: 0x0401199D RID: 72093
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FGameplayTag, TSoftObjectPtr<BP_FirstPersonConfig_C>> _TagToConfigMap;
	}
}
