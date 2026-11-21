using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CDC RID: 7388
	public class IInfrActivityRoadProcess : IInfrActivityBuildStageOption
	{
		// Token: 0x06009CD2 RID: 40146 RVA: 0x001694C4 File Offset: 0x001676C4
		private IInfrActivityRoadProcess_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInfrActivityRoadProcess 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInfrActivityRoadProcess_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInfrActivityRoadProcess_SetValue());
			}
			return result;
		}

		// Token: 0x06009CD3 RID: 40147 RVA: 0x001694FC File Offset: 0x001676FC
		public static IInfrActivityRoadProcess Create([Nullable(2)] IInfrActivityRoadProcess instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrActivityRoadProcess
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009CD4 RID: 40148 RVA: 0x0016950F File Offset: 0x0016770F
		public static IInfrActivityRoadProcess CreateFromSetValue([Nullable(2)] IInfrActivityRoadProcess_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInfrActivityRoadProcess
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009CD5 RID: 40149 RVA: 0x00169522 File Offset: 0x00167722
		public new IInfrActivityRoadProcess_SetValue ToSetValue()
		{
			return new IInfrActivityRoadProcess_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x06009CD6 RID: 40150 RVA: 0x00169541 File Offset: 0x00167741
		// (set) Token: 0x06009CD7 RID: 40151 RVA: 0x0016956C File Offset: 0x0016776C
		public override EInfrActivityBuildStageType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInfrActivityBuildStageType.Infrastructure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x06009CD8 RID: 40152 RVA: 0x0016957A File Offset: 0x0016777A
		// (set) Token: 0x06009CD9 RID: 40153 RVA: 0x001695A5 File Offset: 0x001677A5
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04005FCF RID: 24527
		[Nullable(2)]
		protected new IInfrActivityRoadProcess FbInstance;

		// Token: 0x04005FD0 RID: 24528
		[Nullable(2)]
		protected new IInfrActivityRoadProcess_SetValue PocoInterface;
	}
}
