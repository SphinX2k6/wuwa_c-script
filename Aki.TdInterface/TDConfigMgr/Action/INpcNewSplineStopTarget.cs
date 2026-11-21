using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E7F RID: 7807
	public class INpcNewSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x0600A5EB RID: 42475 RVA: 0x0017A2A4 File Offset: 0x001784A4
		private INpcNewSplineStopTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcNewSplineStopTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcNewSplineStopTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcNewSplineStopTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600A5EC RID: 42476 RVA: 0x0017A2DC File Offset: 0x001784DC
		public static INpcNewSplineStopTarget Create([Nullable(2)] INpcNewSplineStopTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcNewSplineStopTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A5ED RID: 42477 RVA: 0x0017A2EF File Offset: 0x001784EF
		public static INpcNewSplineStopTarget CreateFromSetValue([Nullable(2)] INpcNewSplineStopTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcNewSplineStopTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A5EE RID: 42478 RVA: 0x0017A302 File Offset: 0x00178502
		public new INpcNewSplineStopTarget_SetValue ToSetValue()
		{
			return new INpcNewSplineStopTarget_SetValue
			{
				Type = this.Type,
				NpcId = this.NpcId
			};
		}

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x0600A5EF RID: 42479 RVA: 0x0017A321 File Offset: 0x00178521
		// (set) Token: 0x0600A5F0 RID: 42480 RVA: 0x0017A34C File Offset: 0x0017854C
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x0600A5F1 RID: 42481 RVA: 0x0017A35A File Offset: 0x0017855A
		// (set) Token: 0x0600A5F2 RID: 42482 RVA: 0x0017A385 File Offset: 0x00178585
		public virtual int NpcId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NpcId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.NpcId;
			}
			set
			{
				this.GetOrCreatePoco().NpcId = value;
			}
		}

		// Token: 0x04006420 RID: 25632
		[Nullable(2)]
		protected new INpcNewSplineStopTarget FbInstance;

		// Token: 0x04006421 RID: 25633
		[Nullable(2)]
		protected new INpcNewSplineStopTarget_SetValue PocoInterface;
	}
}
