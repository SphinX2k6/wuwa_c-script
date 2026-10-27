using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B10 RID: 11024
	[NullableContext(1)]
	[Nullable(0)]
	public class Record_Int_IFlowTextConfig
	{
		// Token: 0x0600F157 RID: 61783 RVA: 0x0022FEFD File Offset: 0x0022E0FD
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

		// Token: 0x17004CF9 RID: 19705
		// (get) Token: 0x0600F158 RID: 61784 RVA: 0x0022FF1C File Offset: 0x0022E11C
		public virtual int Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17004CFA RID: 19706
		// (get) Token: 0x0600F159 RID: 61785 RVA: 0x0022FF29 File Offset: 0x0022E129
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

		// Token: 0x040084BA RID: 33978
		private Record_Int_IFlowTextConfig Instance;

		// Token: 0x040084BB RID: 33979
		[Nullable(2)]
		private IFlowTextConfig _ValueCache;

		// Token: 0x040084BC RID: 33980
		private bool _ValueInited;
	}
}
