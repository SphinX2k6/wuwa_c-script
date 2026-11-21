using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Swing
{
	// Token: 0x020031BF RID: 12735
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Swing/BP_RoleSwingConfig.BP_RoleSwingConfig_C")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class BP_RoleSwingConfig_C : BP_BaseSwingConfig_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F7D7 RID: 128983 RVA: 0x0092EED2 File Offset: 0x0092D0D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RoleSwingConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Swing/BP_RoleSwingConfig.BP_RoleSwingConfig_C");
			}
			return BP_RoleSwingConfig_C._ClassPtr;
		}

		// Token: 0x0601F7D8 RID: 128984 RVA: 0x0092EEF8 File Offset: 0x0092D0F8
		public BP_RoleSwingConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_RoleSwingConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F7D9 RID: 128985 RVA: 0x0092EF20 File Offset: 0x0092D120
		public BP_RoleSwingConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RoleSwingConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700399A RID: 14746
		// (get) Token: 0x0601F7DA RID: 128986 RVA: 0x0092EF54 File Offset: 0x0092D154
		// (set) Token: 0x0601F7DB RID: 128987 RVA: 0x0092EF8D File Offset: 0x0092D18D
		public TArray<SRoleSwingConfig> SwingAnimation
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SRoleSwingConfig> result;
				if ((result = this._SwingAnimation) == null)
				{
					result = (this._SwingAnimation = new TArray<SRoleSwingConfig>(base.NativePtr + (IntPtr)BP_RoleSwingConfig_C.__PropertyOffset_SwingAnimation, this));
				}
				return result;
			}
			set
			{
				this.SwingAnimation.CopyAssign(value);
			}
		}

		// Token: 0x0601F7DC RID: 128988 RVA: 0x0092EF9B File Offset: 0x0092D19B
		protected BP_RoleSwingConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010E3B RID: 69179
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Swing/BP_RoleSwingConfig.BP_RoleSwingConfig_C";

		// Token: 0x04010E3C RID: 69180
		private static IntPtr _ClassPtr;

		// Token: 0x04010E3D RID: 69181
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010E3E RID: 69182
		internal static int __PropertyOffset_SwingAnimation;

		// Token: 0x04010E3F RID: 69183
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SRoleSwingConfig> _SwingAnimation;
	}
}
