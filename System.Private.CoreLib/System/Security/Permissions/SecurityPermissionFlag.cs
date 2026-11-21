using System;

namespace System.Security.Permissions
{
	// Token: 0x02000275 RID: 629
	[Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	[Flags]
	public enum SecurityPermissionFlag
	{
		// Token: 0x0400085C RID: 2140
		AllFlags = 16383,
		// Token: 0x0400085D RID: 2141
		Assertion = 1,
		// Token: 0x0400085E RID: 2142
		BindingRedirects = 8192,
		// Token: 0x0400085F RID: 2143
		ControlAppDomain = 1024,
		// Token: 0x04000860 RID: 2144
		ControlDomainPolicy = 256,
		// Token: 0x04000861 RID: 2145
		ControlEvidence = 32,
		// Token: 0x04000862 RID: 2146
		ControlPolicy = 64,
		// Token: 0x04000863 RID: 2147
		ControlPrincipal = 512,
		// Token: 0x04000864 RID: 2148
		ControlThread = 16,
		// Token: 0x04000865 RID: 2149
		Execution = 8,
		// Token: 0x04000866 RID: 2150
		Infrastructure = 4096,
		// Token: 0x04000867 RID: 2151
		NoFlags = 0,
		// Token: 0x04000868 RID: 2152
		RemotingConfiguration = 2048,
		// Token: 0x04000869 RID: 2153
		SerializationFormatter = 128,
		// Token: 0x0400086A RID: 2154
		SkipVerification = 4,
		// Token: 0x0400086B RID: 2155
		UnmanagedCode = 2
	}
}
