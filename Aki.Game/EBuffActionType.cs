using System;

// Token: 0x02002E90 RID: 11920
public enum EBuffActionType
{
	// Token: 0x0400BDC4 RID: 48580
	RemoveBuffWhenInstigatorHasSomeTag = 1,
	// Token: 0x0400BDC5 RID: 48581
	RemoveBuffWhenInstigatorHasEveryTag,
	// Token: 0x0400BDC6 RID: 48582
	RemoveBuffWhenInstigatorNotHasSomeTag,
	// Token: 0x0400BDC7 RID: 48583
	RemoveBuffWhenInstigatorNotHasEveryTag,
	// Token: 0x0400BDC8 RID: 48584
	InactiveBuffWhenInstigatorHasSomeTag,
	// Token: 0x0400BDC9 RID: 48585
	InactiveBuffWhenInstigatorHasEveryTag,
	// Token: 0x0400BDCA RID: 48586
	InactiveBuffWhenInstigatorNotHasSomeTag,
	// Token: 0x0400BDCB RID: 48587
	InactiveBuffWhenInstigatorNotHasEveryTag,
	// Token: 0x0400BDCC RID: 48588
	RemoveBuffWhenInstigatorHasSomeBuff,
	// Token: 0x0400BDCD RID: 48589
	RemoveBuffWhenInstigatorHasEveryBuff,
	// Token: 0x0400BDCE RID: 48590
	RemoveBuffWhenInstigatorNotHasSomeBuff,
	// Token: 0x0400BDCF RID: 48591
	RemoveBuffWhenInstigatorNotHasEveryBuff,
	// Token: 0x0400BDD0 RID: 48592
	InactiveBuffWhenInstigatorHasSomeBuff,
	// Token: 0x0400BDD1 RID: 48593
	InactiveBuffWhenInstigatorHasEveryBuff,
	// Token: 0x0400BDD2 RID: 48594
	InactiveBuffWhenInstigatorNotHasSomeBuff,
	// Token: 0x0400BDD3 RID: 48595
	InactiveBuffWhenInstigatorNotHasEveryBuff,
	// Token: 0x0400BDD4 RID: 48596
	RemoveBuffWhenVictimHasSomeTag = 101,
	// Token: 0x0400BDD5 RID: 48597
	RemoveBuffWhenVictimHasEveryTag,
	// Token: 0x0400BDD6 RID: 48598
	RemoveBuffWhenVictimNotHasSomeTag,
	// Token: 0x0400BDD7 RID: 48599
	RemoveBuffWhenVictimNotHasEveryTag,
	// Token: 0x0400BDD8 RID: 48600
	InactiveBuffWhenVictimHasSomeTag,
	// Token: 0x0400BDD9 RID: 48601
	InactiveBuffWhenVictimHasEveryTag,
	// Token: 0x0400BDDA RID: 48602
	InactiveBuffWhenVictimNotHasSomeTag,
	// Token: 0x0400BDDB RID: 48603
	InactiveBuffWhenVictimNotHasEveryTag,
	// Token: 0x0400BDDC RID: 48604
	RemoveBuffWhenVictimHasSomeBuff,
	// Token: 0x0400BDDD RID: 48605
	RemoveBuffWhenVictimHasEveryBuff,
	// Token: 0x0400BDDE RID: 48606
	RemoveBuffWhenVictimNotHasSomeBuff,
	// Token: 0x0400BDDF RID: 48607
	RemoveBuffWhenVictimNotHasEveryBuff,
	// Token: 0x0400BDE0 RID: 48608
	InactiveBuffWhenVictimHasSomeBuff,
	// Token: 0x0400BDE1 RID: 48609
	InactiveBuffWhenVictimHasEveryBuff,
	// Token: 0x0400BDE2 RID: 48610
	InactiveBuffWhenVictimNotHasSomeBuff,
	// Token: 0x0400BDE3 RID: 48611
	InactiveBuffWhenVictimNotHasEveryBuff,
	// Token: 0x0400BDE4 RID: 48612
	RemoveBuffWhenInstigatorDeadOrRemoved
}
