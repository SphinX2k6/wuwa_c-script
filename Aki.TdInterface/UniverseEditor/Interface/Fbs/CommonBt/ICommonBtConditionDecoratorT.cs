using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064EC RID: 25836
	public class ICommonBtConditionDecoratorT
	{
		// Token: 0x1700BE80 RID: 48768
		// (get) Token: 0x0602BEE8 RID: 179944 RVA: 0x005F91F9 File Offset: 0x005F73F9
		// (set) Token: 0x0602BEE9 RID: 179945 RVA: 0x005F9201 File Offset: 0x005F7401
		public ECommonBtDecoratorType Type { get; set; }

		// Token: 0x1700BE81 RID: 48769
		// (get) Token: 0x0602BEEA RID: 179946 RVA: 0x005F920A File Offset: 0x005F740A
		// (set) Token: 0x0602BEEB RID: 179947 RVA: 0x005F9212 File Offset: 0x005F7412
		public ICommonBtConditionGroupT Condition { get; set; }

		// Token: 0x1700BE82 RID: 48770
		// (get) Token: 0x0602BEEC RID: 179948 RVA: 0x005F921B File Offset: 0x005F741B
		// (set) Token: 0x0602BEED RID: 179949 RVA: 0x005F9223 File Offset: 0x005F7423
		public bool Reverse { get; set; }

		// Token: 0x1700BE83 RID: 48771
		// (get) Token: 0x0602BEEE RID: 179950 RVA: 0x005F922C File Offset: 0x005F742C
		// (set) Token: 0x0602BEEF RID: 179951 RVA: 0x005F9234 File Offset: 0x005F7434
		public ECommonBtAbortType AbortType { get; set; }

		// Token: 0x1700BE84 RID: 48772
		// (get) Token: 0x0602BEF0 RID: 179952 RVA: 0x005F923D File Offset: 0x005F743D
		// (set) Token: 0x0602BEF1 RID: 179953 RVA: 0x005F9245 File Offset: 0x005F7445
		public byte NullMask { get; set; }

		// Token: 0x0602BEF2 RID: 179954 RVA: 0x005F924E File Offset: 0x005F744E
		public ICommonBtConditionDecoratorT()
		{
			this.Type = ECommonBtDecoratorType.Condition;
			this.Condition = null;
			this.Reverse = false;
			this.AbortType = ECommonBtAbortType.None;
			this.NullMask = 0;
		}
	}
}
