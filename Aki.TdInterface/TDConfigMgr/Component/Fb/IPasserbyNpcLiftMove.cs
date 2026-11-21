using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DBC RID: 3516
	public class IPasserbyNpcLiftMove : IPasserbyNpcMoveBase
	{
		// Token: 0x06004FE3 RID: 20451 RVA: 0x000C6A69 File Offset: 0x000C4C69
		public static IPasserbyNpcLiftMove Create(IPasserbyNpcLiftMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcLiftMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x06004FE4 RID: 20452 RVA: 0x000C6A88 File Offset: 0x000C4C88
		public override EPasserbyNpcMoveType Type
		{
			get
			{
				return (EPasserbyNpcMoveType)this.Instance.Type;
			}
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x06004FE5 RID: 20453 RVA: 0x000C6A95 File Offset: 0x000C4C95
		public virtual IPasserbyNpcRideLiftLeaveOnArrivalMove NpcLiftConfig
		{
			get
			{
				if (this._NpcLiftConfigInited)
				{
					return this._NpcLiftConfigCache;
				}
				this._NpcLiftConfigInited = true;
				this._NpcLiftConfigCache = IPasserbyNpcRideLiftLeaveOnArrivalMove.Create(this.Instance.NpcLiftConfig);
				return this._NpcLiftConfigCache;
			}
		}

		// Token: 0x04002D87 RID: 11655
		private IPasserbyNpcLiftMove Instance;

		// Token: 0x04002D88 RID: 11656
		[Nullable(2)]
		private IPasserbyNpcRideLiftLeaveOnArrivalMove _NpcLiftConfigCache;

		// Token: 0x04002D89 RID: 11657
		private bool _NpcLiftConfigInited;
	}
}
