using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200235E RID: 9054
	public class PerformerAiSplineMove : ActionParams
	{
		// Token: 0x0600C558 RID: 50520 RVA: 0x001C49EC File Offset: 0x001C2BEC
		private PerformerAiSplineMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PerformerAiSplineMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PerformerAiSplineMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PerformerAiSplineMove_SetValue());
			}
			return result;
		}

		// Token: 0x0600C559 RID: 50521 RVA: 0x001C4A24 File Offset: 0x001C2C24
		public static PerformerAiSplineMove Create([Nullable(2)] PerformerAiSplineMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PerformerAiSplineMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C55A RID: 50522 RVA: 0x001C4A37 File Offset: 0x001C2C37
		public static PerformerAiSplineMove CreateFromSetValue([Nullable(2)] PerformerAiSplineMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PerformerAiSplineMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C55B RID: 50523 RVA: 0x001C4A4A File Offset: 0x001C2C4A
		public PerformerAiSplineMove_SetValue ToSetValue()
		{
			return new PerformerAiSplineMove_SetValue
			{
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x17003BB0 RID: 15280
		// (get) Token: 0x0600C55C RID: 50524 RVA: 0x001C4A60 File Offset: 0x001C2C60
		// (set) Token: 0x0600C55D RID: 50525 RVA: 0x001C4A9A File Offset: 0x001C2C9A
		public virtual int? SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				PerformerAiSplineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x04007579 RID: 30073
		[Nullable(2)]
		protected new PerformerAiSplineMove FbInstance;

		// Token: 0x0400757A RID: 30074
		[Nullable(2)]
		protected PerformerAiSplineMove_SetValue PocoInterface;
	}
}
