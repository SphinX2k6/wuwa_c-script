using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002693 RID: 9875
[NullableContext(2)]
public interface ISkillParam
{
	// Token: 0x17002725 RID: 10021
	// (get) Token: 0x06018B8B RID: 101259
	// (set) Token: 0x06018B8C RID: 101260
	Entity Target { get; set; }

	// Token: 0x17002726 RID: 10022
	// (get) Token: 0x06018B8D RID: 101261
	// (set) Token: 0x06018B8E RID: 101262
	AActor TargetActor { get; set; }

	// Token: 0x17002727 RID: 10023
	// (get) Token: 0x06018B8F RID: 101263
	// (set) Token: 0x06018B90 RID: 101264
	string SocketName { get; set; }

	// Token: 0x17002728 RID: 10024
	// (get) Token: 0x06018B91 RID: 101265
	// (set) Token: 0x06018B92 RID: 101266
	long? ContextId { get; set; }

	// Token: 0x17002729 RID: 10025
	// (get) Token: 0x06018B93 RID: 101267
	// (set) Token: 0x06018B94 RID: 101268
	string Reason { get; set; }

	// Token: 0x1700272A RID: 10026
	// (get) Token: 0x06018B95 RID: 101269
	// (set) Token: 0x06018B96 RID: 101270
	int? MontageIndex { get; set; }

	// Token: 0x1700272B RID: 10027
	// (get) Token: 0x06018B97 RID: 101271
	// (set) Token: 0x06018B98 RID: 101272
	bool? CheckMultiSkill { get; set; }

	// Token: 0x1700272C RID: 10028
	// (get) Token: 0x06018B99 RID: 101273
	// (set) Token: 0x06018B9A RID: 101274
	int? NextSkillId { get; set; }

	// Token: 0x1700272D RID: 10029
	// (get) Token: 0x06018B9B RID: 101275
	// (set) Token: 0x06018B9C RID: 101276
	bool? IsAsync { get; set; }

	// Token: 0x1700272E RID: 10030
	// (get) Token: 0x06018B9D RID: 101277
	// (set) Token: 0x06018B9E RID: 101278
	FVectorDouble? ExtraTargetLocation { get; set; }
}
