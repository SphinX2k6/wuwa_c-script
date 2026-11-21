using System;

namespace System.Reflection.Emit
{
	// Token: 0x020007D2 RID: 2002
	public enum StackBehaviour
	{
		// Token: 0x04001AA3 RID: 6819
		Pop0,
		// Token: 0x04001AA4 RID: 6820
		Pop1,
		// Token: 0x04001AA5 RID: 6821
		Pop1_pop1,
		// Token: 0x04001AA6 RID: 6822
		Popi,
		// Token: 0x04001AA7 RID: 6823
		Popi_pop1,
		// Token: 0x04001AA8 RID: 6824
		Popi_popi,
		// Token: 0x04001AA9 RID: 6825
		Popi_popi8,
		// Token: 0x04001AAA RID: 6826
		Popi_popi_popi,
		// Token: 0x04001AAB RID: 6827
		Popi_popr4,
		// Token: 0x04001AAC RID: 6828
		Popi_popr8,
		// Token: 0x04001AAD RID: 6829
		Popref,
		// Token: 0x04001AAE RID: 6830
		Popref_pop1,
		// Token: 0x04001AAF RID: 6831
		Popref_popi,
		// Token: 0x04001AB0 RID: 6832
		Popref_popi_popi,
		// Token: 0x04001AB1 RID: 6833
		Popref_popi_popi8,
		// Token: 0x04001AB2 RID: 6834
		Popref_popi_popr4,
		// Token: 0x04001AB3 RID: 6835
		Popref_popi_popr8,
		// Token: 0x04001AB4 RID: 6836
		Popref_popi_popref,
		// Token: 0x04001AB5 RID: 6837
		Push0,
		// Token: 0x04001AB6 RID: 6838
		Push1,
		// Token: 0x04001AB7 RID: 6839
		Push1_push1,
		// Token: 0x04001AB8 RID: 6840
		Pushi,
		// Token: 0x04001AB9 RID: 6841
		Pushi8,
		// Token: 0x04001ABA RID: 6842
		Pushr4,
		// Token: 0x04001ABB RID: 6843
		Pushr8,
		// Token: 0x04001ABC RID: 6844
		Pushref,
		// Token: 0x04001ABD RID: 6845
		Varpop,
		// Token: 0x04001ABE RID: 6846
		Varpush,
		// Token: 0x04001ABF RID: 6847
		Popref_popi_pop1
	}
}
