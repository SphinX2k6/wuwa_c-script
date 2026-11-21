using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000388 RID: 904
public class TDPlayerDefine
{
	// Token: 0x020066BE RID: 26302
	public enum ESkillType
	{
		// Token: 0x04021F7D RID: 139133
		KscSkill,
		// Token: 0x04021F7E RID: 139134
		MontageSkill
	}

	// Token: 0x020066BF RID: 26303
	public enum EFollowerState
	{
		// Token: 0x04021F80 RID: 139136
		None,
		// Token: 0x04021F81 RID: 139137
		InCD,
		// Token: 0x04021F82 RID: 139138
		CDReady
	}

	// Token: 0x020066C0 RID: 26304
	[NullableContext(1)]
	public interface ISkill
	{
		// Token: 0x170077BB RID: 30651
		// (get) Token: 0x0603EFE8 RID: 258024
		// (set) Token: 0x0603EFE9 RID: 258025
		TDPlayerDefine.ESkillType SkillType { get; set; }

		// Token: 0x170077BC RID: 30652
		// (get) Token: 0x0603EFEA RID: 258026
		// (set) Token: 0x0603EFEB RID: 258027
		int SkillId { get; set; }

		// Token: 0x170077BD RID: 30653
		// (get) Token: 0x0603EFEC RID: 258028
		// (set) Token: 0x0603EFED RID: 258029
		float Time { get; set; }

		// Token: 0x170077BE RID: 30654
		// (get) Token: 0x0603EFEE RID: 258030
		// (set) Token: 0x0603EFEF RID: 258031
		int ChargeCueId { get; set; }

		// Token: 0x170077BF RID: 30655
		// (get) Token: 0x0603EFF0 RID: 258032
		// (set) Token: 0x0603EFF1 RID: 258033
		int ChargeFullCueId { get; set; }

		// Token: 0x170077C0 RID: 30656
		// (get) Token: 0x0603EFF2 RID: 258034
		// (set) Token: 0x0603EFF3 RID: 258035
		string PsFeedback { get; set; }

		// Token: 0x170077C1 RID: 30657
		// (get) Token: 0x0603EFF4 RID: 258036
		// (set) Token: 0x0603EFF5 RID: 258037
		EKSC_OperateType OperateType { get; set; }
	}

	// Token: 0x020066C1 RID: 26305
	[NullableContext(1)]
	[Nullable(0)]
	public class Skill : TDPlayerDefine.ISkill
	{
		// Token: 0x170077C2 RID: 30658
		// (get) Token: 0x0603EFF6 RID: 258038 RVA: 0x0125B036 File Offset: 0x01259236
		// (set) Token: 0x0603EFF7 RID: 258039 RVA: 0x0125B03E File Offset: 0x0125923E
		public TDPlayerDefine.ESkillType SkillType { get; set; }

		// Token: 0x170077C3 RID: 30659
		// (get) Token: 0x0603EFF8 RID: 258040 RVA: 0x0125B047 File Offset: 0x01259247
		// (set) Token: 0x0603EFF9 RID: 258041 RVA: 0x0125B04F File Offset: 0x0125924F
		public int SkillId { get; set; }

		// Token: 0x170077C4 RID: 30660
		// (get) Token: 0x0603EFFA RID: 258042 RVA: 0x0125B058 File Offset: 0x01259258
		// (set) Token: 0x0603EFFB RID: 258043 RVA: 0x0125B060 File Offset: 0x01259260
		public float Time { get; set; }

		// Token: 0x170077C5 RID: 30661
		// (get) Token: 0x0603EFFC RID: 258044 RVA: 0x0125B069 File Offset: 0x01259269
		// (set) Token: 0x0603EFFD RID: 258045 RVA: 0x0125B071 File Offset: 0x01259271
		public int ChargeCueId { get; set; }

		// Token: 0x170077C6 RID: 30662
		// (get) Token: 0x0603EFFE RID: 258046 RVA: 0x0125B07A File Offset: 0x0125927A
		// (set) Token: 0x0603EFFF RID: 258047 RVA: 0x0125B082 File Offset: 0x01259282
		public int ChargeFullCueId { get; set; }

		// Token: 0x170077C7 RID: 30663
		// (get) Token: 0x0603F000 RID: 258048 RVA: 0x0125B08B File Offset: 0x0125928B
		// (set) Token: 0x0603F001 RID: 258049 RVA: 0x0125B093 File Offset: 0x01259293
		public string PsFeedback { get; set; } = "";

		// Token: 0x170077C8 RID: 30664
		// (get) Token: 0x0603F002 RID: 258050 RVA: 0x0125B09C File Offset: 0x0125929C
		// (set) Token: 0x0603F003 RID: 258051 RVA: 0x0125B0A4 File Offset: 0x012592A4
		public EKSC_OperateType OperateType { get; set; }
	}
}
