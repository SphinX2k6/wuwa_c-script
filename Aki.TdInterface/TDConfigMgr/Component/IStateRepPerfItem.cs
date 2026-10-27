using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000715 RID: 1813
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateRepPerfItem
	{
		// Token: 0x060026FD RID: 9981 RVA: 0x00067EC4 File Offset: 0x000660C4
		private IStateRepPerfItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateRepPerfItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateRepPerfItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateRepPerfItem_SetValue());
			}
			return result;
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x00067EFC File Offset: 0x000660FC
		public static IStateRepPerfItem Create([Nullable(2)] IStateRepPerfItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRepPerfItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x00067F0F File Offset: 0x0006610F
		public static IStateRepPerfItem CreateFromSetValue([Nullable(2)] IStateRepPerfItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateRepPerfItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x00067F22 File Offset: 0x00066122
		public IStateRepPerfItem_SetValue ToSetValue()
		{
			return new IStateRepPerfItem_SetValue
			{
				StateTag = this.StateTag,
				ReplacePerformance = this.ReplacePerformance
			};
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x00067F41 File Offset: 0x00066141
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x00067F6C File Offset: 0x0006616C
		public virtual string StateTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StateTag;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.StateTag;
			}
			set
			{
				this.GetOrCreatePoco().StateTag = value;
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x00067F7A File Offset: 0x0006617A
		// (set) Token: 0x06002704 RID: 9988 RVA: 0x00067FA1 File Offset: 0x000661A1
		public virtual IStateRepPerfBase ReplacePerformance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ReplacePerformance;
				}
				IStateRepPerfItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ReplacePerformance;
			}
			set
			{
				this.GetOrCreatePoco().ReplacePerformance = value;
			}
		}

		// Token: 0x04001A57 RID: 6743
		[Nullable(2)]
		protected IStateRepPerfItem FbInstance;

		// Token: 0x04001A58 RID: 6744
		[Nullable(2)]
		protected IStateRepPerfItem_SetValue PocoInterface;
	}
}
