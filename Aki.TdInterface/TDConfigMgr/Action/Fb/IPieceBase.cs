using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C50 RID: 11344
	public class IPieceBase
	{
		// Token: 0x0600F973 RID: 63859 RVA: 0x00243B0F File Offset: 0x00241D0F
		public static IPieceBase Create(IPieceBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPieceBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D81 RID: 19841
		// (get) Token: 0x0600F974 RID: 63860 RVA: 0x00243B2E File Offset: 0x00241D2E
		public virtual IPieceIndex Index
		{
			get
			{
				if (this._IndexInited)
				{
					return this._IndexCache;
				}
				this._IndexInited = true;
				this._IndexCache = IPieceIndex.Create(this.Instance.Index);
				return this._IndexCache;
			}
		}

		// Token: 0x17004D82 RID: 19842
		// (get) Token: 0x0600F975 RID: 63861 RVA: 0x00243B62 File Offset: 0x00241D62
		public virtual bool Active
		{
			get
			{
				return this.Instance.Active;
			}
		}

		// Token: 0x04008856 RID: 34902
		private IPieceBase Instance;

		// Token: 0x04008857 RID: 34903
		[Nullable(2)]
		private IPieceIndex _IndexCache;

		// Token: 0x04008858 RID: 34904
		private bool _IndexInited;
	}
}
