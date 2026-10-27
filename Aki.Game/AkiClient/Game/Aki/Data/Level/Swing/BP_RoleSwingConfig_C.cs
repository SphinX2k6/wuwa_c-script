using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Swing
{
	// Token: 0x02003F03 RID: 16131
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Swing/BP_RoleSwingConfig.BP_RoleSwingConfig_C")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class BP_RoleSwingConfig_C : BP_BaseSwingConfig_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028E43 RID: 167491 RVA: 0x009B6EEA File Offset: 0x009B50EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RoleSwingConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Swing/BP_RoleSwingConfig.BP_RoleSwingConfig_C");
			}
			return BP_RoleSwingConfig_C._ClassPtr;
		}

		// Token: 0x06028E44 RID: 167492 RVA: 0x009B6F10 File Offset: 0x009B5110
		public BP_RoleSwingConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_RoleSwingConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028E45 RID: 167493 RVA: 0x009B6F38 File Offset: 0x009B5138
		public BP_RoleSwingConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RoleSwingConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700602F RID: 24623
		// (get) Token: 0x06028E46 RID: 167494 RVA: 0x009B6F6C File Offset: 0x009B516C
		// (set) Token: 0x06028E47 RID: 167495 RVA: 0x009B6FA5 File Offset: 0x009B51A5
		public TArray<SRoleSwingConfig> SwingAnimation
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SRoleSwingConfig> result;
				if ((result = this._SwingAnimation) == null)
				{
					result = (this._SwingAnimation = new TArray<SRoleSwingConfig>(base.NativePtr + (IntPtr)BP_RoleSwingConfig_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.SwingAnimation.CopyAssign(value);
			}
		}

		// Token: 0x06028E48 RID: 167496 RVA: 0x009B6FB3 File Offset: 0x009B51B3
		protected BP_RoleSwingConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014E9B RID: 85659
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Swing/BP_RoleSwingConfig.BP_RoleSwingConfig_C";

		// Token: 0x04014E9C RID: 85660
		private static IntPtr _ClassPtr;

		// Token: 0x04014E9D RID: 85661
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014E9E RID: 85662
		internal new static int __PropertyOffset_0;

		// Token: 0x04014E9F RID: 85663
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SRoleSwingConfig> _SwingAnimation;
	}
}
