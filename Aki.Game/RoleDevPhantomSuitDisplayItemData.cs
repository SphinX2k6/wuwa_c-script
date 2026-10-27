using System;
using System.Runtime.CompilerServices;

// Token: 0x02002803 RID: 10243
[NullableContext(2)]
[Nullable(0)]
public class RoleDevPhantomSuitDisplayItemData : IRoleDevPhantomSuitDisplayItemData
{
	// Token: 0x17001BAE RID: 7086
	// (get) Token: 0x06015044 RID: 86084 RVA: 0x00552A88 File Offset: 0x00550C88
	// (set) Token: 0x06015045 RID: 86085 RVA: 0x00552A90 File Offset: 0x00550C90
	public IPhantomMonsterItemData MonsterData { get; set; }

	// Token: 0x17001BAF RID: 7087
	// (get) Token: 0x06015046 RID: 86086 RVA: 0x00552A99 File Offset: 0x00550C99
	// (set) Token: 0x06015047 RID: 86087 RVA: 0x00552AA1 File Offset: 0x00550CA1
	public IDropRewardItemData RewardData { get; set; }
}
