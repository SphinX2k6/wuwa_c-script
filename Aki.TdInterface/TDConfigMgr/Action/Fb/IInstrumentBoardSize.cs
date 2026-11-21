using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B0A RID: 11018
	public class IInstrumentBoardSize
	{
		// Token: 0x0600F26A RID: 62058 RVA: 0x00236953 File Offset: 0x00234B53
		public static IInstrumentBoardSize Create(IInstrumentBoardSize? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentBoardSize
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004904 RID: 18692
		// (get) Token: 0x0600F26B RID: 62059 RVA: 0x00236972 File Offset: 0x00234B72
		public virtual int X
		{
			get
			{
				return this.Instance.X;
			}
		}

		// Token: 0x17004905 RID: 18693
		// (get) Token: 0x0600F26C RID: 62060 RVA: 0x0023697F File Offset: 0x00234B7F
		public virtual int Y
		{
			get
			{
				return this.Instance.Y;
			}
		}

		// Token: 0x04008508 RID: 34056
		private IInstrumentBoardSize Instance;
	}
}
