using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200144B RID: 5195
	[NullableContext(2)]
	[Nullable(0)]
	public class ISavePoint : ISaveConfigType
	{
		// Token: 0x0600761E RID: 30238 RVA: 0x0011A219 File Offset: 0x00118419
		[NullableContext(1)]
		public static ISavePoint Create(ISavePoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISavePoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700275B RID: 10075
		// (get) Token: 0x0600761F RID: 30239 RVA: 0x0011A238 File Offset: 0x00118438
		public override ESaveConfig Type
		{
			get
			{
				return (ESaveConfig)this.Instance.Type;
			}
		}

		// Token: 0x1700275C RID: 10076
		// (get) Token: 0x06007620 RID: 30240 RVA: 0x0011A248 File Offset: 0x00118448
		public virtual bool? RelinkRollback
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.RelinkRollback);
			}
		}

		// Token: 0x1700275D RID: 10077
		// (get) Token: 0x06007621 RID: 30241 RVA: 0x0011A27E File Offset: 0x0011847E
		public virtual IPositionRollbackConfig PosRollbackCfg
		{
			get
			{
				if (this._PosRollbackCfgInited)
				{
					return this._PosRollbackCfgCache;
				}
				this._PosRollbackCfgInited = true;
				this._PosRollbackCfgCache = IPositionRollbackConfig.Create(this.Instance.PosRollbackCfg);
				return this._PosRollbackCfgCache;
			}
		}

		// Token: 0x04004493 RID: 17555
		private ISavePoint Instance;

		// Token: 0x04004494 RID: 17556
		private IPositionRollbackConfig _PosRollbackCfgCache;

		// Token: 0x04004495 RID: 17557
		private bool _PosRollbackCfgInited;
	}
}
