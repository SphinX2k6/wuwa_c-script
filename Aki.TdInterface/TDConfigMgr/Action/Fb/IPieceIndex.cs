using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C4F RID: 11343
	public class IPieceIndex
	{
		// Token: 0x0600F96F RID: 63855 RVA: 0x00243ACE File Offset: 0x00241CCE
		public static IPieceIndex Create(IPieceIndex? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPieceIndex
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D7F RID: 19839
		// (get) Token: 0x0600F970 RID: 63856 RVA: 0x00243AED File Offset: 0x00241CED
		public virtual int RowIndex
		{
			get
			{
				return this.Instance.RowIndex;
			}
		}

		// Token: 0x17004D80 RID: 19840
		// (get) Token: 0x0600F971 RID: 63857 RVA: 0x00243AFA File Offset: 0x00241CFA
		public virtual int ColumnIndex
		{
			get
			{
				return this.Instance.ColumnIndex;
			}
		}

		// Token: 0x04008855 RID: 34901
		private IPieceIndex Instance;
	}
}
