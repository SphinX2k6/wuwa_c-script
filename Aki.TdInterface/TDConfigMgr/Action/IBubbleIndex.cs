using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019A9 RID: 6569
	public class IBubbleIndex : IFlowIndex
	{
		// Token: 0x06008BA5 RID: 35749 RVA: 0x0014B1A8 File Offset: 0x001493A8
		private IBubbleIndex_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBubbleIndex 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBubbleIndex_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBubbleIndex_SetValue());
			}
			return result;
		}

		// Token: 0x06008BA6 RID: 35750 RVA: 0x0014B1E0 File Offset: 0x001493E0
		public static IBubbleIndex Create([Nullable(2)] IBubbleIndex instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBubbleIndex
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008BA7 RID: 35751 RVA: 0x0014B1F3 File Offset: 0x001493F3
		public static IBubbleIndex CreateFromSetValue([Nullable(2)] IBubbleIndex_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBubbleIndex
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008BA8 RID: 35752 RVA: 0x0014B206 File Offset: 0x00149406
		public new IBubbleIndex_SetValue ToSetValue()
		{
			return new IBubbleIndex_SetValue
			{
				FlowListName = this.FlowListName,
				FlowId = this.FlowId,
				StateId = this.StateId
			};
		}

		// Token: 0x17002D61 RID: 11617
		// (get) Token: 0x06008BA9 RID: 35753 RVA: 0x0014B231 File Offset: 0x00149431
		// (set) Token: 0x06008BAA RID: 35754 RVA: 0x0014B25C File Offset: 0x0014945C
		public override string FlowListName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlowListName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.FlowListName;
			}
			set
			{
				this.GetOrCreatePoco().FlowListName = value;
			}
		}

		// Token: 0x17002D62 RID: 11618
		// (get) Token: 0x06008BAB RID: 35755 RVA: 0x0014B26A File Offset: 0x0014946A
		// (set) Token: 0x06008BAC RID: 35756 RVA: 0x0014B295 File Offset: 0x00149495
		public override int FlowId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlowId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FlowId;
			}
			set
			{
				this.GetOrCreatePoco().FlowId = value;
			}
		}

		// Token: 0x17002D63 RID: 11619
		// (get) Token: 0x06008BAD RID: 35757 RVA: 0x0014B2A4 File Offset: 0x001494A4
		// (set) Token: 0x06008BAE RID: 35758 RVA: 0x0014B2DE File Offset: 0x001494DE
		public virtual int? StateId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StateId;
				}
				IBubbleIndex_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StateId;
			}
			set
			{
				this.GetOrCreatePoco().StateId = value;
			}
		}

		// Token: 0x04005824 RID: 22564
		[Nullable(2)]
		protected new IBubbleIndex FbInstance;

		// Token: 0x04005825 RID: 22565
		[Nullable(2)]
		protected new IBubbleIndex_SetValue PocoInterface;
	}
}
