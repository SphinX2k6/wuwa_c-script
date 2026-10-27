using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002420 RID: 9248
[NullableContext(1)]
[Nullable(0)]
public class PhantomBattleInstance
{
	// Token: 0x06012828 RID: 75816 RVA: 0x0048F5DE File Offset: 0x0048D7DE
	public PhantomBattleInstance(PhantomItem data)
	{
		this.PhantomId = data.MonsterId;
		this.PhantomItem = new PhantomItem?(data);
		this.PhantomSkill = PhantomBattleConfig.Instance.GetPhantomSkillList(data.SkillId).ToList<PhantomSkill>();
	}

	// Token: 0x17001806 RID: 6150
	// (get) Token: 0x06012829 RID: 75817 RVA: 0x0048F61B File Offset: 0x0048D81B
	// (set) Token: 0x0601282A RID: 75818 RVA: 0x0048F623 File Offset: 0x0048D823
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

	// Token: 0x17001807 RID: 6151
	// (get) Token: 0x0601282B RID: 75819 RVA: 0x0048F62C File Offset: 0x0048D82C
	// (set) Token: 0x0601282C RID: 75820 RVA: 0x0048F634 File Offset: 0x0048D834
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

	// Token: 0x17001808 RID: 6152
	// (get) Token: 0x0601282D RID: 75821 RVA: 0x0048F63D File Offset: 0x0048D83D
	// (set) Token: 0x0601282E RID: 75822 RVA: 0x0048F645 File Offset: 0x0048D845
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

	// Token: 0x0601282F RID: 75823 RVA: 0x0048F650 File Offset: 0x0048D850
	public int? GetPhantomSkillId()
	{
		return new int?(this.Skill[0].Id);
	}

	// Token: 0x06012830 RID: 75824 RVA: 0x0048F678 File Offset: 0x0048D878
	public PhantomSkill? GetPhantomSkillInfoByLevel()
	{
		if (this.PhantomSkill.Count <= 0)
		{
			return null;
		}
		return new PhantomSkill?(this.PhantomSkill[0]);
	}

	// Token: 0x06012831 RID: 75825 RVA: 0x0048F6B0 File Offset: 0x0048D8B0
	public float[] GetModelZoom()
	{
		return this.PhantomItem.Value.Zoom();
	}

	// Token: 0x06012832 RID: 75826 RVA: 0x0048F6D4 File Offset: 0x0048D8D4
	public float[] GetModelLocation()
	{
		return this.PhantomItem.Value.Location();
	}

	// Token: 0x06012833 RID: 75827 RVA: 0x0048F6F8 File Offset: 0x0048D8F8
	public float[] GetModelRotator()
	{
		return this.PhantomItem.Value.Rotator();
	}

	// Token: 0x06012834 RID: 75828 RVA: 0x0048F71C File Offset: 0x0048D91C
	public string GetStandAnim()
	{
		return this.PhantomItem.Value.StandAnim;
	}

	// Token: 0x04008BAD RID: 35757
	private int Id;

	// Token: 0x04008BAE RID: 35758
	private PhantomItem? Item;

	// Token: 0x04008BAF RID: 35759
	[Nullable(2)]
	private List<PhantomSkill> Skill;
}
