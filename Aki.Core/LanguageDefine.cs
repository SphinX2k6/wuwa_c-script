using System;
using System.Runtime.CompilerServices;

// Token: 0x0200002D RID: 45
[NullableContext(1)]
[Nullable(0)]
public class LanguageDefine
{
	// Token: 0x17000015 RID: 21
	// (get) Token: 0x060000F4 RID: 244 RVA: 0x000077B2 File Offset: 0x000059B2
	public int LanguageType { get; }

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x060000F5 RID: 245 RVA: 0x000077BA File Offset: 0x000059BA
	public string LanguageCode { get; }

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x060000F6 RID: 246 RVA: 0x000077C2 File Offset: 0x000059C2
	public string AudioCode { get; }

	// Token: 0x060000F7 RID: 247 RVA: 0x000077CA File Offset: 0x000059CA
	public LanguageDefine(int languageType, string languageCode, string audioCode)
	{
		this.LanguageType = languageType;
		this.LanguageCode = languageCode;
		this.AudioCode = audioCode;
	}
}
