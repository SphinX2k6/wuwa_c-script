using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200286E RID: 10350
	public class IInstrumentQteGameplay : IUiGame
	{
		// Token: 0x0600E559 RID: 58713 RVA: 0x0021B99A File Offset: 0x00219B9A
		[NullableContext(1)]
		public static IInstrumentQteGameplay Create(IInstrumentQteGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentQteGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700463F RID: 17983
		// (get) Token: 0x0600E55A RID: 58714 RVA: 0x0021B9B9 File Offset: 0x00219BB9
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004640 RID: 17984
		// (get) Token: 0x0600E55B RID: 58715 RVA: 0x0021B9C6 File Offset: 0x00219BC6
		public virtual EInstrumentType InstrumentType
		{
			get
			{
				return (EInstrumentType)this.Instance.InstrumentType;
			}
		}

		// Token: 0x17004641 RID: 17985
		// (get) Token: 0x0600E55C RID: 58716 RVA: 0x0021B9D3 File Offset: 0x00219BD3
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007ED4 RID: 32468
		private IInstrumentQteGameplay Instance;
	}
}
