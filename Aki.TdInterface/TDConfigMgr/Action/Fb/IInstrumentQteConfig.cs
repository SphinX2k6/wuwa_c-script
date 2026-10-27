using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200283A RID: 10298
	[NullableContext(1)]
	[Nullable(0)]
	public class IInstrumentQteConfig
	{
		// Token: 0x0600E452 RID: 58450 RVA: 0x00219C6A File Offset: 0x00217E6A
		public static IInstrumentQteConfig Create(IInstrumentQteConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentQteConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045A0 RID: 17824
		// (get) Token: 0x0600E453 RID: 58451 RVA: 0x00219C89 File Offset: 0x00217E89
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x170045A1 RID: 17825
		// (get) Token: 0x0600E454 RID: 58452 RVA: 0x00219C96 File Offset: 0x00217E96
		public virtual EInstrumentType InstrumentType
		{
			get
			{
				return (EInstrumentType)this.Instance.InstrumentType;
			}
		}

		// Token: 0x170045A2 RID: 17826
		// (get) Token: 0x0600E455 RID: 58453 RVA: 0x00219CA3 File Offset: 0x00217EA3
		public virtual string Description
		{
			get
			{
				return this.Instance.Description;
			}
		}

		// Token: 0x170045A3 RID: 17827
		// (get) Token: 0x0600E456 RID: 58454 RVA: 0x00219CB0 File Offset: 0x00217EB0
		public virtual List<IInstrumentQteConfig_QteSequenceRow> QteSequence
		{
			get
			{
				if (this._QteSequenceInited)
				{
					return this._QteSequenceCache;
				}
				this._QteSequenceInited = true;
				int qteSequenceLength = this.Instance.QteSequenceLength;
				this._QteSequenceCache = new List<IInstrumentQteConfig_QteSequenceRow>(qteSequenceLength);
				for (int i = 0; i < qteSequenceLength; i++)
				{
					this._QteSequenceCache.Add(IInstrumentQteConfig_QteSequenceRow.Create(this.Instance.QteSequence(i)));
				}
				return this._QteSequenceCache;
			}
		}

		// Token: 0x170045A4 RID: 17828
		// (get) Token: 0x0600E457 RID: 58455 RVA: 0x00219D19 File Offset: 0x00217F19
		public virtual string PreludeAsset
		{
			get
			{
				return this.Instance.PreludeAsset;
			}
		}

		// Token: 0x04007E54 RID: 32340
		private IInstrumentQteConfig Instance;

		// Token: 0x04007E55 RID: 32341
		private List<IInstrumentQteConfig_QteSequenceRow> _QteSequenceCache;

		// Token: 0x04007E56 RID: 32342
		private bool _QteSequenceInited;
	}
}
