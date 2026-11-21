using System;
using System.Runtime.CompilerServices;

// Token: 0x0200002D RID: 45
[NullableContext(1)]
[Nullable(0)]
public class LanguageDefine
{
	// Token: 0x17000015 RID: 21
	// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000752A File Offset: 0x0000572A
	public int LanguageType { get; }

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x060000F7 RID: 247 RVA: 0x00007532 File Offset: 0x00005732
	public string LanguageCode { get; }

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000753A File Offset: 0x0000573A
	public string AudioCode { get; }

	// Token: 0x060000F9 RID: 249 RVA: 0x00007542 File Offset: 0x00005742
	public LanguageDefine(int languageType, string languageCode, string audioCode)
	{
		this.LanguageType = languageType;
		this.LanguageCode = languageCode;
		this.AudioCode = audioCode;
	}
}
