using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000654 RID: 1620
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomNpcRule : IRefreshRule
	{
		// Token: 0x060022A8 RID: 8872 RVA: 0x0005F38C File Offset: 0x0005D58C
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

		// Token: 0x060022A9 RID: 8873 RVA: 0x0005F3C4 File Offset: 0x0005D5C4
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

		// Token: 0x060022AA RID: 8874 RVA: 0x0005F3D7 File Offset: 0x0005D5D7
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

		// Token: 0x060022AB RID: 8875 RVA: 0x0005F3EA File Offset: 0x0005D5EA
		public new IRandomNpcRule_SetValue ToSetValue()
		{
			return new IRandomNpcRule_SetValue
			{
				Type = this.Type,
				DateTimeList = this.DateTimeList,
				ProbabilityRefreshGroup = this.ProbabilityRefreshGroup
			};
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x0005F415 File Offset: 0x0005D615
		// (set) Token: 0x060022AD RID: 8877 RVA: 0x0005F440 File Offset: 0x0005D640
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

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x0005F450 File Offset: 0x0005D650
		// (set) Token: 0x060022AF RID: 8879 RVA: 0x0005F4E3 File Offset: 0x0005D6E3
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

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x0005F4F8 File Offset: 0x0005D6F8
		// (set) Token: 0x060022B1 RID: 8881 RVA: 0x0005F559 File Offset: 0x0005D759
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

		// Token: 0x04001811 RID: 6161
		[Nullable(2)]
		protected new IRandomNpcRule FbInstance;

		// Token: 0x04001812 RID: 6162
		[Nullable(2)]
		protected new IRandomNpcRule_SetValue PocoInterface;

		// Token: 0x04001813 RID: 6163
		private List<IFixedDateTime> _DateTimeListCache;

		// Token: 0x04001814 RID: 6164
		private bool _DateTimeListInited;

		// Token: 0x04001815 RID: 6165
		private IProbabilityRefreshGroup _ProbabilityRefreshGroupCache;

		// Token: 0x04001816 RID: 6166
		private bool _ProbabilityRefreshGroupInited;
	}
}
