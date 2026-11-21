using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001905 RID: 6405
[NullableContext(1)]
[Nullable(0)]
public class PhantomBattleInstance
{
	// Token: 0x0600FCDE RID: 64734 RVA: 0x0049CBFA File Offset: 0x0049ADFA
	public PhantomBattleInstance(PhantomItem data)
	{
		this.PhantomId = data.MonsterId;
		this.PhantomItem = new PhantomItem?(data);
		this.PhantomSkill = new List<PhantomSkill>(PhantomBattleConfig.Instance.GetPhantomSkillList(data.SkillId));
	}

	// Token: 0x17001840 RID: 6208
	// (get) Token: 0x0600FCDF RID: 64735 RVA: 0x0049CC37 File Offset: 0x0049AE37
	// (set) Token: 0x0600FCE0 RID: 64736 RVA: 0x0049CC3F File Offset: 0x0049AE3F
	public int PhantomId
	{
		get
		{
			return this.Id;
		}
		set
		{
			this.Id = value;
		}
	}

	// Token: 0x17001841 RID: 6209
	// (get) Token: 0x0600FCE1 RID: 64737 RVA: 0x0049CC48 File Offset: 0x0049AE48
	// (set) Token: 0x0600FCE2 RID: 64738 RVA: 0x0049CC50 File Offset: 0x0049AE50
	public PhantomItem? PhantomItem
	{
		get
		{
			return this.Item;
		}
		set
		{
			this.Item = value;
		}
	}

	// Token: 0x17001842 RID: 6210
	// (get) Token: 0x0600FCE3 RID: 64739 RVA: 0x0049CC59 File Offset: 0x0049AE59
	// (set) Token: 0x0600FCE4 RID: 64740 RVA: 0x0049CC61 File Offset: 0x0049AE61
	[Nullable(2)]
	public List<PhantomSkill> PhantomSkill
	{
		[NullableContext(2)]
		get
		{
			return this.Skill;
		}
		[NullableContext(2)]
		set
		{
			this.Skill = value;
		}
	}

	// Token: 0x0600FCE5 RID: 64741 RVA: 0x0049CC6C File Offset: 0x0049AE6C
	public int? GetPhantomSkillId()
	{
		return new int?(this.Skill[0].Id);
	}

	// Token: 0x0600FCE6 RID: 64742 RVA: 0x0049CC94 File Offset: 0x0049AE94
	public PhantomSkill? GetPhantomSkillInfoByLevel()
	{
		if (this.PhantomSkill.Count <= 0)
		{
			return null;
		}
		return new PhantomSkill?(this.PhantomSkill[0]);
	}

	// Token: 0x0600FCE7 RID: 64743 RVA: 0x0049CCCC File Offset: 0x0049AECC
	public float[] GetModelZoom()
	{
		return this.PhantomItem.Value.Zoom();
	}

	// Token: 0x0600FCE8 RID: 64744 RVA: 0x0049CCF0 File Offset: 0x0049AEF0
	public float[] GetModelLocation()
	{
		return this.PhantomItem.Value.Location();
	}

	// Token: 0x0600FCE9 RID: 64745 RVA: 0x0049CD14 File Offset: 0x0049AF14
	public float[] GetModelRotator()
	{
		return this.PhantomItem.Value.Rotator();
	}

	// Token: 0x0600FCEA RID: 64746 RVA: 0x0049CD38 File Offset: 0x0049AF38
	public string GetStandAnim()
	{
		return this.PhantomItem.Value.StandAnim;
	}

	// Token: 0x04008CF4 RID: 36084
	private int Id;

	// Token: 0x04008CF5 RID: 36085
	private PhantomItem? Item;

	// Token: 0x04008CF6 RID: 36086
	[Nullable(2)]
	private List<PhantomSkill> Skill;
}
