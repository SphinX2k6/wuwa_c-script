using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E2E RID: 11822
	public class Record_Int_IFlowTextConfig
	{
		// Token: 0x060100AB RID: 65707 RVA: 0x0024E993 File Offset: 0x0024CB93
		public static Record_Int_IFlowTextConfig Create(Record_Int_IFlowTextConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Record_Int_IFlowTextConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050FD RID: 20733
		// (get) Token: 0x060100AC RID: 65708 RVA: 0x0024E9B2 File Offset: 0x0024CBB2
		public virtual int Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x170050FE RID: 20734
		// (get) Token: 0x060100AD RID: 65709 RVA: 0x0024E9BF File Offset: 0x0024CBBF
		public virtual IFlowTextConfig Value
		{
			get
			{
				if (this._ValueInited)
				{
					return this._ValueCache;
				}
				this._ValueInited = true;
				this._ValueCache = IFlowTextConfig.Create(this.Instance.Value);
				return this._ValueCache;
			}
		}

		// Token: 0x04008C02 RID: 35842
		private Record_Int_IFlowTextConfig Instance;

		// Token: 0x04008C03 RID: 35843
		[Nullable(2)]
		private IFlowTextConfig _ValueCache;

		// Token: 0x04008C04 RID: 35844
		private bool _ValueInited;
	}
}
