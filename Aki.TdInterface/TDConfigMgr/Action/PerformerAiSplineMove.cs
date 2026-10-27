using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020FD RID: 8445
	[NullableContext(1)]
	[Nullable(0)]
	public class PerformerAiSplineMove : ActionParams
	{
		// Token: 0x0600B9CC RID: 47564 RVA: 0x001AD88C File Offset: 0x001ABA8C
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

		// Token: 0x0600B9CD RID: 47565 RVA: 0x001AD8C4 File Offset: 0x001ABAC4
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

		// Token: 0x0600B9CE RID: 47566 RVA: 0x001AD8D7 File Offset: 0x001ABAD7
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

		// Token: 0x0600B9CF RID: 47567 RVA: 0x001AD8EA File Offset: 0x001ABAEA
		public PerformerAiSplineMove_SetValue ToSetValue()
		{
			return new PerformerAiSplineMove_SetValue
			{
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x170038C4 RID: 14532
		// (get) Token: 0x0600B9D0 RID: 47568 RVA: 0x001AD900 File Offset: 0x001ABB00
		// (set) Token: 0x0600B9D1 RID: 47569 RVA: 0x001AD93A File Offset: 0x001ABB3A
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

		// Token: 0x04006F45 RID: 28485
		[Nullable(2)]
		protected new PerformerAiSplineMove FbInstance;

		// Token: 0x04006F46 RID: 28486
		[Nullable(2)]
		protected PerformerAiSplineMove_SetValue PocoInterface;
	}
}
