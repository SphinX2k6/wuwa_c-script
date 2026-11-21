using System;
using System.Runtime.CompilerServices;

namespace System.Security.Permissions
{
	// Token: 0x02000274 RID: 628
	[Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	public sealed class SecurityPermissionAttribute : CodeAccessSecurityAttribute
	{
		// Token: 0x06002DF3 RID: 11763 RVA: 0x00093E6B File Offset: 0x0009206B
		public SecurityPermissionAttribute(SecurityAction action) : base((SecurityAction)0)
		{
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06002DF4 RID: 11764 RVA: 0x00093E74 File Offset: 0x00092074
		// (set) Token: 0x06002DF5 RID: 11765 RVA: 0x00093E7C File Offset: 0x0009207C
		public bool Assertion { get; set; }

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06002DF6 RID: 11766 RVA: 0x00093E85 File Offset: 0x00092085
		// (set) Token: 0x06002DF7 RID: 11767 RVA: 0x00093E8D File Offset: 0x0009208D
		public bool BindingRedirects { get; set; }

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06002DF8 RID: 11768 RVA: 0x00093E96 File Offset: 0x00092096
		// (set) Token: 0x06002DF9 RID: 11769 RVA: 0x00093E9E File Offset: 0x0009209E
		public bool ControlAppDomain { get; set; }

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06002DFA RID: 11770 RVA: 0x00093EA7 File Offset: 0x000920A7
		// (set) Token: 0x06002DFB RID: 11771 RVA: 0x00093EAF File Offset: 0x000920AF
		public bool ControlDomainPolicy { get; set; }

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06002DFC RID: 11772 RVA: 0x00093EB8 File Offset: 0x000920B8
		// (set) Token: 0x06002DFD RID: 11773 RVA: 0x00093EC0 File Offset: 0x000920C0
		public bool ControlEvidence { get; set; }

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06002DFE RID: 11774 RVA: 0x00093EC9 File Offset: 0x000920C9
		// (set) Token: 0x06002DFF RID: 11775 RVA: 0x00093ED1 File Offset: 0x000920D1
		public bool ControlPolicy { get; set; }

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06002E00 RID: 11776 RVA: 0x00093EDA File Offset: 0x000920DA
		// (set) Token: 0x06002E01 RID: 11777 RVA: 0x00093EE2 File Offset: 0x000920E2
		public bool ControlPrincipal { get; set; }

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x00093EEB File Offset: 0x000920EB
		// (set) Token: 0x06002E03 RID: 11779 RVA: 0x00093EF3 File Offset: 0x000920F3
		public bool ControlThread { get; set; }

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06002E04 RID: 11780 RVA: 0x00093EFC File Offset: 0x000920FC
		// (set) Token: 0x06002E05 RID: 11781 RVA: 0x00093F04 File Offset: 0x00092104
		public bool Execution { get; set; }

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06002E06 RID: 11782 RVA: 0x00093F0D File Offset: 0x0009210D
		// (set) Token: 0x06002E07 RID: 11783 RVA: 0x00093F15 File Offset: 0x00092115
		public SecurityPermissionFlag Flags { get; set; }

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x00093F1E File Offset: 0x0009211E
		// (set) Token: 0x06002E09 RID: 11785 RVA: 0x00093F26 File Offset: 0x00092126
		public bool Infrastructure { get; set; }

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06002E0A RID: 11786 RVA: 0x00093F2F File Offset: 0x0009212F
		// (set) Token: 0x06002E0B RID: 11787 RVA: 0x00093F37 File Offset: 0x00092137
		public bool RemotingConfiguration { get; set; }

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06002E0C RID: 11788 RVA: 0x00093F40 File Offset: 0x00092140
		// (set) Token: 0x06002E0D RID: 11789 RVA: 0x00093F48 File Offset: 0x00092148
		public bool SerializationFormatter { get; set; }

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06002E0E RID: 11790 RVA: 0x00093F51 File Offset: 0x00092151
		// (set) Token: 0x06002E0F RID: 11791 RVA: 0x00093F59 File Offset: 0x00092159
		public bool SkipVerification { get; set; }

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06002E10 RID: 11792 RVA: 0x00093F62 File Offset: 0x00092162
		// (set) Token: 0x06002E11 RID: 11793 RVA: 0x00093F6A File Offset: 0x0009216A
		public bool UnmanagedCode { get; set; }

		// Token: 0x06002E12 RID: 11794 RVA: 0x0001A4BA File Offset: 0x000186BA
		[NullableContext(2)]
		public override IPermission CreatePermission()
		{
			return null;
		}
	}
}
