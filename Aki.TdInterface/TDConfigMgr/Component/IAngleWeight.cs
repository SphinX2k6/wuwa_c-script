using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001C1 RID: 449
	[NullableContext(1)]
	[Nullable(0)]
	public class IAngleWeight : IExploreSkillSearchTargetCfg
	{
		// Token: 0x06000720 RID: 1824 RVA: 0x00024558 File Offset: 0x00022758
		private IAngleWeight_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAngleWeight 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAngleWeight_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAngleWeight_SetValue());
			}
			return result;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00024590 File Offset: 0x00022790
		public static IAngleWeight Create([Nullable(2)] IAngleWeight instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAngleWeight
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000245A3 File Offset: 0x000227A3
		public static IAngleWeight CreateFromSetValue([Nullable(2)] IAngleWeight_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAngleWeight
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000245B6 File Offset: 0x000227B6
		public new IAngleWeight_SetValue ToSetValue()
		{
			return new IAngleWeight_SetValue
			{
				Type = this.Type,
				AngleWeight = this.AngleWeight
			};
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x000245D5 File Offset: 0x000227D5
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x00024600 File Offset: 0x00022800
		public override EExploreSkillSearchTargetCfg Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreSkillSearchTargetCfg.AngleWeight;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00024610 File Offset: 0x00022810
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x000246A3 File Offset: 0x000228A3
		public virtual List<IEntityAngleWeight> AngleWeight
		{
			get
			{
				if (this._AngleWeightInited)
				{
					return this._AngleWeightCache;
				}
				this._AngleWeightInited = true;
				if (this.FbInstance != null)
				{
					List<IEntityAngleWeight> angleWeight = this.FbInstance.AngleWeight;
					if (angleWeight != null)
					{
						this._AngleWeightCache = new List<IEntityAngleWeight>(angleWeight.Count);
						for (int i = 0; i < angleWeight.Count; i++)
						{
							this._AngleWeightCache.Add(IEntityAngleWeight.Create(angleWeight[i]));
						}
					}
				}
				else
				{
					IAngleWeight_SetValue pocoInterface = this.PocoInterface;
					this._AngleWeightCache = ((pocoInterface != null) ? pocoInterface.AngleWeight : null);
				}
				return this._AngleWeightCache;
			}
			set
			{
				this.GetOrCreatePoco().AngleWeight = value;
				this._AngleWeightInited = false;
			}
		}

		// Token: 0x04000876 RID: 2166
		[Nullable(2)]
		protected new IAngleWeight FbInstance;

		// Token: 0x04000877 RID: 2167
		[Nullable(2)]
		protected new IAngleWeight_SetValue PocoInterface;

		// Token: 0x04000878 RID: 2168
		private List<IEntityAngleWeight> _AngleWeightCache;

		// Token: 0x04000879 RID: 2169
		private bool _AngleWeightInited;
	}
}
