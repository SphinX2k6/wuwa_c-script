using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000ED3 RID: 3795
public class TDPlayerDefine
{
	// Token: 0x0200752A RID: 29994
	public enum ESkillType
	{
		// Token: 0x04026C32 RID: 158770
		KscSkill,
		// Token: 0x04026C33 RID: 158771
		MontageSkill
	}

	// Token: 0x0200752B RID: 29995
	public enum EFollowerState
	{
		// Token: 0x04026C35 RID: 158773
		None,
		// Token: 0x04026C36 RID: 158774
		InCD,
		// Token: 0x04026C37 RID: 158775
		CDReady
	}

	// Token: 0x0200752C RID: 29996
	[NullableContext(1)]
	public interface ISkill
	{
		// Token: 0x1700A01D RID: 40989
		// (get) Token: 0x06048B88 RID: 297864
		// (set) Token: 0x06048B89 RID: 297865
		TDPlayerDefine.ESkillType SkillType { get; set; }

		// Token: 0x1700A01E RID: 40990
		// (get) Token: 0x06048B8A RID: 297866
		// (set) Token: 0x06048B8B RID: 297867
		int SkillId { get; set; }

		// Token: 0x1700A01F RID: 40991
		// (get) Token: 0x06048B8C RID: 297868
		// (set) Token: 0x06048B8D RID: 297869
		float Time { get; set; }

		// Token: 0x1700A020 RID: 40992
		// (get) Token: 0x06048B8E RID: 297870
		// (set) Token: 0x06048B8F RID: 297871
		int ChargeCueId { get; set; }

		// Token: 0x1700A021 RID: 40993
		// (get) Token: 0x06048B90 RID: 297872
		// (set) Token: 0x06048B91 RID: 297873
		int ChargeFullCueId { get; set; }

		// Token: 0x1700A022 RID: 40994
		// (get) Token: 0x06048B92 RID: 297874
		// (set) Token: 0x06048B93 RID: 297875
		string PsFeedback { get; set; }

		// Token: 0x1700A023 RID: 40995
		// (get) Token: 0x06048B94 RID: 297876
		// (set) Token: 0x06048B95 RID: 297877
		EKSC_OperateType OperateType { get; set; }
	}

	// Token: 0x0200752D RID: 29997
	[NullableContext(1)]
	[Nullable(0)]
	public class Skill : TDPlayerDefine.ISkill
	{
		// Token: 0x1700A024 RID: 40996
		// (get) Token: 0x06048B96 RID: 297878 RVA: 0x012B7BC6 File Offset: 0x012B5DC6
		// (set) Token: 0x06048B97 RID: 297879 RVA: 0x012B7BCE File Offset: 0x012B5DCE
		public TDPlayerDefine.ESkillType SkillType { get; set; }

		// Token: 0x1700A025 RID: 40997
		// (get) Token: 0x06048B98 RID: 297880 RVA: 0x012B7BD7 File Offset: 0x012B5DD7
		// (set) Token: 0x06048B99 RID: 297881 RVA: 0x012B7BDF File Offset: 0x012B5DDF
		public int SkillId { get; set; }

		// Token: 0x1700A026 RID: 40998
		// (get) Token: 0x06048B9A RID: 297882 RVA: 0x012B7BE8 File Offset: 0x012B5DE8
		// (set) Token: 0x06048B9B RID: 297883 RVA: 0x012B7BF0 File Offset: 0x012B5DF0
		public float Time { get; set; }

		// Token: 0x1700A027 RID: 40999
		// (get) Token: 0x06048B9C RID: 297884 RVA: 0x012B7BF9 File Offset: 0x012B5DF9
		// (set) Token: 0x06048B9D RID: 297885 RVA: 0x012B7C01 File Offset: 0x012B5E01
		public int ChargeCueId { get; set; }

		// Token: 0x1700A028 RID: 41000
		// (get) Token: 0x06048B9E RID: 297886 RVA: 0x012B7C0A File Offset: 0x012B5E0A
		// (set) Token: 0x06048B9F RID: 297887 RVA: 0x012B7C12 File Offset: 0x012B5E12
		public int ChargeFullCueId { get; set; }

		// Token: 0x1700A029 RID: 41001
		// (get) Token: 0x06048BA0 RID: 297888 RVA: 0x012B7C1B File Offset: 0x012B5E1B
		// (set) Token: 0x06048BA1 RID: 297889 RVA: 0x012B7C23 File Offset: 0x012B5E23
		public string PsFeedback { get; set; } = "";

		// Token: 0x1700A02A RID: 41002
		// (get) Token: 0x06048BA2 RID: 297890 RVA: 0x012B7C2C File Offset: 0x012B5E2C
		// (set) Token: 0x06048BA3 RID: 297891 RVA: 0x012B7C34 File Offset: 0x012B5E34
		public EKSC_OperateType OperateType { get; set; }
	}
}
