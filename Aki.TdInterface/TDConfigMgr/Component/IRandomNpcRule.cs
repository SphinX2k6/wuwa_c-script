using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006F1 RID: 1777
	public class IRandomNpcRule : IRefreshRule
	{
		// Token: 0x060025AE RID: 9646 RVA: 0x000660A0 File Offset: 0x000642A0
		private IRandomNpcRule_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRandomNpcRule 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRandomNpcRule_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRandomNpcRule_SetValue());
			}
			return result;
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x000660D8 File Offset: 0x000642D8
		public static IRandomNpcRule Create([Nullable(2)] IRandomNpcRule instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomNpcRule
			{
				FbInstance = instance
			};
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x000660EB File Offset: 0x000642EB
		public static IRandomNpcRule CreateFromSetValue([Nullable(2)] IRandomNpcRule_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRandomNpcRule
			{
				PocoInterface = value
			};
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x000660FE File Offset: 0x000642FE
		public new IRandomNpcRule_SetValue ToSetValue()
		{
			return new IRandomNpcRule_SetValue
			{
				Type = this.Type,
				DateTimeList = this.DateTimeList,
				ProbabilityRefreshGroup = this.ProbabilityRefreshGroup
			};
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x00066129 File Offset: 0x00064329
		// (set) Token: 0x060025B3 RID: 9651 RVA: 0x00066154 File Offset: 0x00064354
		public override ERefreshRule Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERefreshRule.CD;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060025B4 RID: 9652 RVA: 0x00066164 File Offset: 0x00064364
		// (set) Token: 0x060025B5 RID: 9653 RVA: 0x000661F7 File Offset: 0x000643F7
		public virtual List<IFixedDateTime> DateTimeList
		{
			get
			{
				if (this._DateTimeListInited)
				{
					return this._DateTimeListCache;
				}
				this._DateTimeListInited = true;
				if (this.FbInstance != null)
				{
					List<IFixedDateTime> dateTimeList = this.FbInstance.DateTimeList;
					if (dateTimeList != null)
					{
						this._DateTimeListCache = new List<IFixedDateTime>(dateTimeList.Count);
						for (int i = 0; i < dateTimeList.Count; i++)
						{
							this._DateTimeListCache.Add(IFixedDateTime.Create(dateTimeList[i]));
						}
					}
				}
				else
				{
					IRandomNpcRule_SetValue pocoInterface = this.PocoInterface;
					this._DateTimeListCache = ((pocoInterface != null) ? pocoInterface.DateTimeList : null);
				}
				return this._DateTimeListCache;
			}
			set
			{
				this.GetOrCreatePoco().DateTimeList = value;
				this._DateTimeListInited = false;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060025B6 RID: 9654 RVA: 0x0006620C File Offset: 0x0006440C
		// (set) Token: 0x060025B7 RID: 9655 RVA: 0x0006626D File Offset: 0x0006446D
		public virtual IProbabilityRefreshGroup ProbabilityRefreshGroup
		{
			get
			{
				if (this._ProbabilityRefreshGroupInited)
				{
					return this._ProbabilityRefreshGroupCache;
				}
				this._ProbabilityRefreshGroupInited = true;
				if (this.FbInstance != null)
				{
					this._ProbabilityRefreshGroupCache = IProbabilityRefreshGroup.Create(this.FbInstance.ProbabilityRefreshGroup);
				}
				else
				{
					IRandomNpcRule_SetValue pocoInterface = this.PocoInterface;
					this._ProbabilityRefreshGroupCache = ((pocoInterface != null) ? pocoInterface.ProbabilityRefreshGroup : null);
				}
				return this._ProbabilityRefreshGroupCache;
			}
			set
			{
				this.GetOrCreatePoco().ProbabilityRefreshGroup = value;
				this._ProbabilityRefreshGroupInited = false;
			}
		}

		// Token: 0x04001A03 RID: 6659
		[Nullable(2)]
		protected new IRandomNpcRule FbInstance;

		// Token: 0x04001A04 RID: 6660
		[Nullable(2)]
		protected new IRandomNpcRule_SetValue PocoInterface;

		// Token: 0x04001A05 RID: 6661
		private List<IFixedDateTime> _DateTimeListCache;

		// Token: 0x04001A06 RID: 6662
		private bool _DateTimeListInited;

		// Token: 0x04001A07 RID: 6663
		private IProbabilityRefreshGroup _ProbabilityRefreshGroupCache;

		// Token: 0x04001A08 RID: 6664
		private bool _ProbabilityRefreshGroupInited;
	}
}
