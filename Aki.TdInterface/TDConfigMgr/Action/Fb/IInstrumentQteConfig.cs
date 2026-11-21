using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B0D RID: 11021
	public class IInstrumentQteConfig
	{
		// Token: 0x0600F277 RID: 62071 RVA: 0x00236ACE File Offset: 0x00234CCE
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

		// Token: 0x1700490B RID: 18699
		// (get) Token: 0x0600F278 RID: 62072 RVA: 0x00236AED File Offset: 0x00234CED
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x1700490C RID: 18700
		// (get) Token: 0x0600F279 RID: 62073 RVA: 0x00236AFA File Offset: 0x00234CFA
		public virtual EInstrumentType InstrumentType
		{
			get
			{
				return (EInstrumentType)this.Instance.InstrumentType;
			}
		}

		// Token: 0x1700490D RID: 18701
		// (get) Token: 0x0600F27A RID: 62074 RVA: 0x00236B07 File Offset: 0x00234D07
		public virtual string Description
		{
			get
			{
				return this.Instance.Description;
			}
		}

		// Token: 0x1700490E RID: 18702
		// (get) Token: 0x0600F27B RID: 62075 RVA: 0x00236B14 File Offset: 0x00234D14
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

		// Token: 0x1700490F RID: 18703
		// (get) Token: 0x0600F27C RID: 62076 RVA: 0x00236B7D File Offset: 0x00234D7D
		public virtual string PreludeAsset
		{
			get
			{
				return this.Instance.PreludeAsset;
			}
		}

		// Token: 0x04008511 RID: 34065
		private IInstrumentQteConfig Instance;

		// Token: 0x04008512 RID: 34066
		private List<IInstrumentQteConfig_QteSequenceRow> _QteSequenceCache;

		// Token: 0x04008513 RID: 34067
		private bool _QteSequenceInited;
	}
}
