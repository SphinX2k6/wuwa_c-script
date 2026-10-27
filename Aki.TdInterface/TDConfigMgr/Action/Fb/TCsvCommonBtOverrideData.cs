using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B15 RID: 11029
	[NullableContext(1)]
	[Nullable(0)]
	public class TCsvCommonBtOverrideData
	{
		// Token: 0x0600F169 RID: 61801 RVA: 0x0023017B File Offset: 0x0022E37B
		public static TCsvCommonBtOverrideData Create(TCsvCommonBtOverrideData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TCsvCommonBtOverrideData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D01 RID: 19713
		// (get) Token: 0x0600F16A RID: 61802 RVA: 0x0023019A File Offset: 0x0022E39A
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004D02 RID: 19714
		// (get) Token: 0x0600F16B RID: 61803 RVA: 0x002301A7 File Offset: 0x0022E3A7
		public virtual ICommonBtOverride Data
		{
			get
			{
				if (this._DataInited)
				{
					return this._DataCache;
				}
				this._DataInited = true;
				this._DataCache = ICommonBtOverride.Create(this.Instance.Data);
				return this._DataCache;
			}
		}

		// Token: 0x040084C9 RID: 33993
		private TCsvCommonBtOverrideData Instance;

		// Token: 0x040084CA RID: 33994
		[Nullable(2)]
		private ICommonBtOverride _DataCache;

		// Token: 0x040084CB RID: 33995
		private bool _DataInited;
	}
}
