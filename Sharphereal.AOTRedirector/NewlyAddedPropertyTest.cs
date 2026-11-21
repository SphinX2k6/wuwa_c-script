using System;

namespace Sharphereal.AOTRedirector
{
	// Token: 0x0200000A RID: 10
	public class NewlyAddedPropertyTest
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000027AD File Offset: 0x000009AD
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000027B5 File Offset: 0x000009B5
		public int IntProperty { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000027C0 File Offset: 0x000009C0
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000027E4 File Offset: 0x000009E4
		public int IntProperty_Redirect
		{
			get
			{
				Patch_NewlyAddedPropertyTest fieldRedirectExtensionObject = BackendCache.s_Backend.GetFieldRedirectExtensionObject<Patch_NewlyAddedPropertyTest>(this);
				return fieldRedirectExtensionObject.IntProperty_k_BackingField;
			}
			set
			{
				Patch_NewlyAddedPropertyTest fieldRedirectExtensionObject = BackendCache.s_Backend.GetFieldRedirectExtensionObject<Patch_NewlyAddedPropertyTest>(this);
				fieldRedirectExtensionObject.IntProperty_k_BackingField = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002805 File Offset: 0x00000A05
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0000280C File Offset: 0x00000A0C
		public static int s_IntProperty { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002814 File Offset: 0x00000A14
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002844 File Offset: 0x00000A44
		public int s_IntProperty_Redirect
		{
			get
			{
				Backend backend = new Backend("fake");
				Patch_NewlyAddedPropertyTest fieldRedirectExtensionObject = backend.GetFieldRedirectExtensionObject<Patch_NewlyAddedPropertyTest>(Patch_NewlyAddedPropertyTest.s_NewlyAddedPropertyTestKey);
				return fieldRedirectExtensionObject.IntProperty_k_BackingField;
			}
			set
			{
				Backend backend = new Backend("fake");
				Patch_NewlyAddedPropertyTest fieldRedirectExtensionObject = backend.GetFieldRedirectExtensionObject<Patch_NewlyAddedPropertyTest>(Patch_NewlyAddedPropertyTest.s_NewlyAddedPropertyTestKey);
				fieldRedirectExtensionObject.IntProperty_k_BackingField = value;
			}
		}
	}
}
