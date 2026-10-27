using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002209 RID: 8713
	[NullableContext(1)]
	[Nullable(0)]
	public class ShowTargetRange : ActionParams
	{
		// Token: 0x0600BF4E RID: 48974 RVA: 0x001B7E04 File Offset: 0x001B6004
		private ShowTargetRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ShowTargetRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ShowTargetRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ShowTargetRange_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF4F RID: 48975 RVA: 0x001B7E3C File Offset: 0x001B603C
		public static ShowTargetRange Create([Nullable(2)] ShowTargetRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowTargetRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF50 RID: 48976 RVA: 0x001B7E4F File Offset: 0x001B604F
		public static ShowTargetRange CreateFromSetValue([Nullable(2)] ShowTargetRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ShowTargetRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF51 RID: 48977 RVA: 0x001B7E62 File Offset: 0x001B6062
		public ShowTargetRange_SetValue ToSetValue()
		{
			return new ShowTargetRange_SetValue
			{
				RangeEntities = this.RangeEntities,
				DelayShow = this.DelayShow
			};
		}

		// Token: 0x170039FD RID: 14845
		// (get) Token: 0x0600BF52 RID: 48978 RVA: 0x001B7E81 File Offset: 0x001B6081
		// (set) Token: 0x0600BF53 RID: 48979 RVA: 0x001B7EA8 File Offset: 0x001B60A8
		public virtual List<int> RangeEntities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RangeEntities;
				}
				ShowTargetRange_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RangeEntities;
			}
			set
			{
				this.GetOrCreatePoco().RangeEntities = value;
			}
		}

		// Token: 0x170039FE RID: 14846
		// (get) Token: 0x0600BF54 RID: 48980 RVA: 0x001B7EB6 File Offset: 0x001B60B6
		// (set) Token: 0x0600BF55 RID: 48981 RVA: 0x001B7EE1 File Offset: 0x001B60E1
		public virtual bool DelayShow
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayShow;
				}
				return this.PocoInterface != null && this.PocoInterface.DelayShow;
			}
			set
			{
				this.GetOrCreatePoco().DelayShow = value;
			}
		}

		// Token: 0x04007212 RID: 29202
		[Nullable(2)]
		protected new ShowTargetRange FbInstance;

		// Token: 0x04007213 RID: 29203
		[Nullable(2)]
		protected ShowTargetRange_SetValue PocoInterface;
	}
}
