using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EA9 RID: 24233
	public class ICommonBtConditionDecoratorT
	{
		// Token: 0x1700B515 RID: 46357
		// (get) Token: 0x06029840 RID: 170048 RVA: 0x005B0255 File Offset: 0x005AE455
		// (set) Token: 0x06029841 RID: 170049 RVA: 0x005B025D File Offset: 0x005AE45D
		public ECommonBtDecoratorType Type { get; set; }

		// Token: 0x1700B516 RID: 46358
		// (get) Token: 0x06029842 RID: 170050 RVA: 0x005B0266 File Offset: 0x005AE466
		// (set) Token: 0x06029843 RID: 170051 RVA: 0x005B026E File Offset: 0x005AE46E
		public ICommonBtConditionGroupT Condition { get; set; }

		// Token: 0x1700B517 RID: 46359
		// (get) Token: 0x06029844 RID: 170052 RVA: 0x005B0277 File Offset: 0x005AE477
		// (set) Token: 0x06029845 RID: 170053 RVA: 0x005B027F File Offset: 0x005AE47F
		public bool Reverse { get; set; }

		// Token: 0x1700B518 RID: 46360
		// (get) Token: 0x06029846 RID: 170054 RVA: 0x005B0288 File Offset: 0x005AE488
		// (set) Token: 0x06029847 RID: 170055 RVA: 0x005B0290 File Offset: 0x005AE490
		public ECommonBtAbortType AbortType { get; set; }

		// Token: 0x1700B519 RID: 46361
		// (get) Token: 0x06029848 RID: 170056 RVA: 0x005B0299 File Offset: 0x005AE499
		// (set) Token: 0x06029849 RID: 170057 RVA: 0x005B02A1 File Offset: 0x005AE4A1
		public byte NullMask { get; set; }

		// Token: 0x0602984A RID: 170058 RVA: 0x005B02AA File Offset: 0x005AE4AA
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
