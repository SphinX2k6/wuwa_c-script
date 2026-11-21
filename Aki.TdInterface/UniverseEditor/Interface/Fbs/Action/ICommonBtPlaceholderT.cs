using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ADD RID: 27357
	public class ICommonBtPlaceholderT
	{
		// Token: 0x1700C8DF RID: 51423
		// (get) Token: 0x0602F012 RID: 192530 RVA: 0x00669221 File Offset: 0x00667421
		// (set) Token: 0x0602F013 RID: 192531 RVA: 0x00669229 File Offset: 0x00667429
		public int Id { get; set; }

		// Token: 0x1700C8E0 RID: 51424
		// (get) Token: 0x0602F014 RID: 192532 RVA: 0x00669232 File Offset: 0x00667432
		// (set) Token: 0x0602F015 RID: 192533 RVA: 0x0066923A File Offset: 0x0066743A
		public string Name { get; set; }

		// Token: 0x1700C8E1 RID: 51425
		// (get) Token: 0x0602F016 RID: 192534 RVA: 0x00669243 File Offset: 0x00667443
		// (set) Token: 0x0602F017 RID: 192535 RVA: 0x0066924B File Offset: 0x0066744B
		public TCommonBtPlaceholderValueUnion Value { get; set; }

		// Token: 0x1700C8E2 RID: 51426
		// (get) Token: 0x0602F018 RID: 192536 RVA: 0x00669254 File Offset: 0x00667454
		// (set) Token: 0x0602F019 RID: 192537 RVA: 0x0066925C File Offset: 0x0066745C
		public List<int> RefTaskIds { get; set; }

		// Token: 0x0602F01A RID: 192538 RVA: 0x00669265 File Offset: 0x00667465
		public ICommonBtPlaceholderT()
		{
			this.Id = 0;
			this.Name = null;
			this.Value = null;
			this.RefTaskIds = null;
		}
	}
}
