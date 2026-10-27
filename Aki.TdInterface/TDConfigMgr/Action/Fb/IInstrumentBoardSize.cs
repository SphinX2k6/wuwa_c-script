using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002837 RID: 10295
	public class IInstrumentBoardSize
	{
		// Token: 0x0600E445 RID: 58437 RVA: 0x00219AEF File Offset: 0x00217CEF
		[NullableContext(1)]
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

		// Token: 0x17004599 RID: 17817
		// (get) Token: 0x0600E446 RID: 58438 RVA: 0x00219B0E File Offset: 0x00217D0E
		public virtual int X
		{
			get
			{
				return this.Instance.X;
			}
		}

		// Token: 0x1700459A RID: 17818
		// (get) Token: 0x0600E447 RID: 58439 RVA: 0x00219B1B File Offset: 0x00217D1B
		public virtual int Y
		{
			get
			{
				return this.Instance.Y;
			}
		}

		// Token: 0x04007E4B RID: 32331
		private IInstrumentBoardSize Instance;
	}
}
