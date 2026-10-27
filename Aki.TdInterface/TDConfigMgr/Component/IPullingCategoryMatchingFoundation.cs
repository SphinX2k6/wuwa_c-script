using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000630 RID: 1584
	[NullableContext(1)]
	[Nullable(0)]
	public class IPullingCategoryMatchingFoundation : IPullingFoundationType
	{
		// Token: 0x060021DA RID: 8666 RVA: 0x0005D624 File Offset: 0x0005B824
		private IPullingCategoryMatchingFoundation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPullingCategoryMatchingFoundation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPullingCategoryMatchingFoundation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPullingCategoryMatchingFoundation_SetValue());
			}
			return result;
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x0005D65C File Offset: 0x0005B85C
		public static IPullingCategoryMatchingFoundation Create([Nullable(2)] IPullingCategoryMatchingFoundation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPullingCategoryMatchingFoundation
			{
				FbInstance = instance
			};
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x0005D66F File Offset: 0x0005B86F
		public static IPullingCategoryMatchingFoundation CreateFromSetValue([Nullable(2)] IPullingCategoryMatchingFoundation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPullingCategoryMatchingFoundation
			{
				PocoInterface = value
			};
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x0005D682 File Offset: 0x0005B882
		public new IPullingCategoryMatchingFoundation_SetValue ToSetValue()
		{
			return new IPullingCategoryMatchingFoundation_SetValue
			{
				Type = this.Type,
				InitMatchEntity = this.InitMatchEntity,
				MatchingConfigs = this.MatchingConfigs
			};
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x0005D6AD File Offset: 0x0005B8AD
		// (set) Token: 0x060021DF RID: 8671 RVA: 0x0005D6D8 File Offset: 0x0005B8D8
		public override EPullingFoundation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPullingFoundation.CategoryMatching;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x060021E0 RID: 8672 RVA: 0x0005D6E8 File Offset: 0x0005B8E8
		// (set) Token: 0x060021E1 RID: 8673 RVA: 0x0005D722 File Offset: 0x0005B922
		public virtual int? InitMatchEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitMatchEntity;
				}
				IPullingCategoryMatchingFoundation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitMatchEntity;
			}
			set
			{
				this.GetOrCreatePoco().InitMatchEntity = value;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x0005D730 File Offset: 0x0005B930
		// (set) Token: 0x060021E3 RID: 8675 RVA: 0x0005D7C3 File Offset: 0x0005B9C3
		public virtual List<ICategoryMatchingConfigBase> MatchingConfigs
		{
			get
			{
				if (this._MatchingConfigsInited)
				{
					return this._MatchingConfigsCache;
				}
				this._MatchingConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<ICategoryMatchingConfigBase> matchingConfigs = this.FbInstance.MatchingConfigs;
					if (matchingConfigs != null)
					{
						this._MatchingConfigsCache = new List<ICategoryMatchingConfigBase>(matchingConfigs.Count);
						for (int i = 0; i < matchingConfigs.Count; i++)
						{
							this._MatchingConfigsCache.Add(ICategoryMatchingConfigBase.Create(matchingConfigs[i]));
						}
					}
				}
				else
				{
					IPullingCategoryMatchingFoundation_SetValue pocoInterface = this.PocoInterface;
					this._MatchingConfigsCache = ((pocoInterface != null) ? pocoInterface.MatchingConfigs : null);
				}
				return this._MatchingConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().MatchingConfigs = value;
				this._MatchingConfigsInited = false;
			}
		}

		// Token: 0x04001794 RID: 6036
		[Nullable(2)]
		protected new IPullingCategoryMatchingFoundation FbInstance;

		// Token: 0x04001795 RID: 6037
		[Nullable(2)]
		protected new IPullingCategoryMatchingFoundation_SetValue PocoInterface;

		// Token: 0x04001796 RID: 6038
		private List<ICategoryMatchingConfigBase> _MatchingConfigsCache;

		// Token: 0x04001797 RID: 6039
		private bool _MatchingConfigsInited;
	}
}
