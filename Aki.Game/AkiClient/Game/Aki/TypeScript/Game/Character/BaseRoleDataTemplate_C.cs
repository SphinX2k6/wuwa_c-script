using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.TypeScript.Game.Character
{
	// Token: 0x02003A1B RID: 14875
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/Character/BaseRoleDataTemplate.BaseRoleDataTemplate_C")]
	[UnrealStructLayout(2240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2240)]
	public class BaseRoleDataTemplate_C : __TsBaseCharacter_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F357 RID: 127831 RVA: 0x008B03F7 File Offset: 0x008AE5F7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BaseRoleDataTemplate_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Character/BaseRoleDataTemplate.BaseRoleDataTemplate_C");
			}
			return BaseRoleDataTemplate_C._ClassPtr;
		}

		// Token: 0x0601F358 RID: 127832 RVA: 0x008B041C File Offset: 0x008AE61C
		public BaseRoleDataTemplate_C() : this(BuiltinUtils.AllocNativeUObject(BaseRoleDataTemplate_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F359 RID: 127833 RVA: 0x008B0444 File Offset: 0x008AE644
		[NullableContext(1)]
		public BaseRoleDataTemplate_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BaseRoleDataTemplate_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F35A RID: 127834 RVA: 0x008B0477 File Offset: 0x008AE677
		protected BaseRoleDataTemplate_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EF55 RID: 61269
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Character/BaseRoleDataTemplate.BaseRoleDataTemplate_C";

		// Token: 0x0400EF56 RID: 61270
		private static IntPtr _ClassPtr;

		// Token: 0x0400EF57 RID: 61271
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
