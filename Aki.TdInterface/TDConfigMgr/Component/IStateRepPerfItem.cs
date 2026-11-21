using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007B6 RID: 1974
	public class IStateRepPerfItem
	{
		// Token: 0x06002A1D RID: 10781 RVA: 0x0006EF34 File Offset: 0x0006D134
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

		// Token: 0x06002A1E RID: 10782 RVA: 0x0006EF6C File Offset: 0x0006D16C
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

		// Token: 0x06002A1F RID: 10783 RVA: 0x0006EF7F File Offset: 0x0006D17F
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

		// Token: 0x06002A20 RID: 10784 RVA: 0x0006EF92 File Offset: 0x0006D192
		public IStateRepPerfItem_SetValue ToSetValue()
		{
			return new IStateRepPerfItem_SetValue
			{
				StateTag = this.StateTag,
				ReplacePerformance = this.ReplacePerformance
			};
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06002A21 RID: 10785 RVA: 0x0006EFB1 File Offset: 0x0006D1B1
		// (set) Token: 0x06002A22 RID: 10786 RVA: 0x0006EFDC File Offset: 0x0006D1DC
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

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x0006EFEA File Offset: 0x0006D1EA
		// (set) Token: 0x06002A24 RID: 10788 RVA: 0x0006F011 File Offset: 0x0006D211
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

		// Token: 0x04001C56 RID: 7254
		[Nullable(2)]
		protected IStateRepPerfItem FbInstance;

		// Token: 0x04001C57 RID: 7255
		[Nullable(2)]
		protected IStateRepPerfItem_SetValue PocoInterface;
	}
}
