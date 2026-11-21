using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B0C RID: 11020
	public class IInstrumentConfig
	{
		// Token: 0x0600F272 RID: 62066 RVA: 0x00236A59 File Offset: 0x00234C59
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

		// Token: 0x17004908 RID: 18696
		// (get) Token: 0x0600F273 RID: 62067 RVA: 0x00236A78 File Offset: 0x00234C78
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004909 RID: 18697
		// (get) Token: 0x0600F274 RID: 62068 RVA: 0x00236A85 File Offset: 0x00234C85
		public virtual EInstrumentType InstrumentType
		{
			get
			{
				return (EInstrumentType)this.Instance.InstrumentType;
			}
		}

		// Token: 0x1700490A RID: 18698
		// (get) Token: 0x0600F275 RID: 62069 RVA: 0x00236A92 File Offset: 0x00234C92
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

		// Token: 0x0400850E RID: 34062
		private IInstrumentConfig Instance;

		// Token: 0x0400850F RID: 34063
		[Nullable(2)]
		private IInstrumentKeyConfigs _KeyConfigsCache;

		// Token: 0x04008510 RID: 34064
		private bool _KeyConfigsInited;
	}
}
