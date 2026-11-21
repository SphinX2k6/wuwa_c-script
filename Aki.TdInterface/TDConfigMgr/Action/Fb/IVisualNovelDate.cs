using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002833 RID: 10291
	public class IVisualNovelDate
	{
		// Token: 0x0600E50F RID: 58639 RVA: 0x0021D85E File Offset: 0x0021BA5E
		public static IVisualNovelDate Create(IVisualNovelDate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004157 RID: 16727
		// (get) Token: 0x0600E510 RID: 58640 RVA: 0x0021D87D File Offset: 0x0021BA7D
		public virtual int Month
		{
			get
			{
				return this.Instance.Month;
			}
		}

		// Token: 0x17004158 RID: 16728
		// (get) Token: 0x0600E511 RID: 58641 RVA: 0x0021D88A File Offset: 0x0021BA8A
		public virtual int Day
		{
			get
			{
				return this.Instance.Day;
			}
		}

		// Token: 0x04007DAF RID: 32175
		private IVisualNovelDate Instance;
	}
}
