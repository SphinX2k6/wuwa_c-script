using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002839 RID: 10297
	[NullableContext(1)]
	[Nullable(0)]
	public class IInstrumentConfig
	{
		// Token: 0x0600E44D RID: 58445 RVA: 0x00219BF5 File Offset: 0x00217DF5
		public static IInstrumentConfig Create(IInstrumentConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700459D RID: 17821
		// (get) Token: 0x0600E44E RID: 58446 RVA: 0x00219C14 File Offset: 0x00217E14
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x1700459E RID: 17822
		// (get) Token: 0x0600E44F RID: 58447 RVA: 0x00219C21 File Offset: 0x00217E21
		public virtual EInstrumentType InstrumentType
		{
			get
			{
				return (EInstrumentType)this.Instance.InstrumentType;
			}
		}

		// Token: 0x1700459F RID: 17823
		// (get) Token: 0x0600E450 RID: 58448 RVA: 0x00219C2E File Offset: 0x00217E2E
		public virtual IInstrumentKeyConfigs KeyConfigs
		{
			get
			{
				if (this._KeyConfigsInited)
				{
					return this._KeyConfigsCache;
				}
				this._KeyConfigsInited = true;
				this._KeyConfigsCache = IInstrumentKeyConfigs.Create(this.Instance.KeyConfigs);
				return this._KeyConfigsCache;
			}
		}

		// Token: 0x04007E51 RID: 32337
		private IInstrumentConfig Instance;

		// Token: 0x04007E52 RID: 32338
		[Nullable(2)]
		private IInstrumentKeyConfigs _KeyConfigsCache;

		// Token: 0x04007E53 RID: 32339
		private bool _KeyConfigsInited;
	}
}
