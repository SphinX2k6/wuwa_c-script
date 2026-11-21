using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002474 RID: 9332
	public class ShowTargetRange : ActionParams
	{
		// Token: 0x0600CB0A RID: 51978 RVA: 0x001CF490 File Offset: 0x001CD690
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

		// Token: 0x0600CB0B RID: 51979 RVA: 0x001CF4C8 File Offset: 0x001CD6C8
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

		// Token: 0x0600CB0C RID: 51980 RVA: 0x001CF4DB File Offset: 0x001CD6DB
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

		// Token: 0x0600CB0D RID: 51981 RVA: 0x001CF4EE File Offset: 0x001CD6EE
		public ShowTargetRange_SetValue ToSetValue()
		{
			return new ShowTargetRange_SetValue
			{
				RangeEntities = this.RangeEntities,
				DelayShow = this.DelayShow
			};
		}

		// Token: 0x17003CF2 RID: 15602
		// (get) Token: 0x0600CB0E RID: 51982 RVA: 0x001CF50D File Offset: 0x001CD70D
		// (set) Token: 0x0600CB0F RID: 51983 RVA: 0x001CF534 File Offset: 0x001CD734
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

		// Token: 0x17003CF3 RID: 15603
		// (get) Token: 0x0600CB10 RID: 51984 RVA: 0x001CF542 File Offset: 0x001CD742
		// (set) Token: 0x0600CB11 RID: 51985 RVA: 0x001CF56D File Offset: 0x001CD76D
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

		// Token: 0x0400785B RID: 30811
		[Nullable(2)]
		protected new ShowTargetRange FbInstance;

		// Token: 0x0400785C RID: 30812
		[Nullable(2)]
		protected ShowTargetRange_SetValue PocoInterface;
	}
}
