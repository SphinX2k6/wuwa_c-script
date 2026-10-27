using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008B7 RID: 2231
	[NullableContext(1)]
	[Nullable(0)]
	public class TargetGearGroupComponent : IComponentBase
	{
		// Token: 0x06003221 RID: 12833 RVA: 0x000808E0 File Offset: 0x0007EAE0
		private TargetGearGroupComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TargetGearGroupComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TargetGearGroupComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TargetGearGroupComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x00080918 File Offset: 0x0007EB18
		public static TargetGearGroupComponent Create([Nullable(2)] TargetGearGroupComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TargetGearGroupComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x0008092B File Offset: 0x0007EB2B
		public static TargetGearGroupComponent CreateFromSetValue([Nullable(2)] TargetGearGroupComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TargetGearGroupComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x0008093E File Offset: 0x0007EB3E
		public new TargetGearGroupComponent_SetValue ToSetValue()
		{
			return new TargetGearGroupComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Type = this.Type,
				GroupConfigs = this.GroupConfigs
			};
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06003225 RID: 12837 RVA: 0x00080978 File Offset: 0x0007EB78
		// (set) Token: 0x06003226 RID: 12838 RVA: 0x000809B2 File Offset: 0x0007EBB2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				TargetGearGroupComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06003227 RID: 12839 RVA: 0x000809C0 File Offset: 0x0007EBC0
		// (set) Token: 0x06003228 RID: 12840 RVA: 0x000809EA File Offset: 0x0007EBEA
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06003229 RID: 12841 RVA: 0x000809F8 File Offset: 0x0007EBF8
		// (set) Token: 0x0600322A RID: 12842 RVA: 0x00080A23 File Offset: 0x0007EC23
		public virtual string Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x0600322B RID: 12843 RVA: 0x00080A34 File Offset: 0x0007EC34
		// (set) Token: 0x0600322C RID: 12844 RVA: 0x00080AC7 File Offset: 0x0007ECC7
		public virtual List<ITargetGearGroupConfig> GroupConfigs
		{
			get
			{
				if (this._GroupConfigsInited)
				{
					return this._GroupConfigsCache;
				}
				this._GroupConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<ITargetGearGroupConfig> groupConfigs = this.FbInstance.GroupConfigs;
					if (groupConfigs != null)
					{
						this._GroupConfigsCache = new List<ITargetGearGroupConfig>(groupConfigs.Count);
						for (int i = 0; i < groupConfigs.Count; i++)
						{
							this._GroupConfigsCache.Add(ITargetGearGroupConfig.Create(groupConfigs[i]));
						}
					}
				}
				else
				{
					TargetGearGroupComponent_SetValue pocoInterface = this.PocoInterface;
					this._GroupConfigsCache = ((pocoInterface != null) ? pocoInterface.GroupConfigs : null);
				}
				return this._GroupConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().GroupConfigs = value;
				this._GroupConfigsInited = false;
			}
		}

		// Token: 0x040020DD RID: 8413
		[Nullable(2)]
		protected new TargetGearGroupComponent FbInstance;

		// Token: 0x040020DE RID: 8414
		[Nullable(2)]
		protected new TargetGearGroupComponent_SetValue PocoInterface;

		// Token: 0x040020DF RID: 8415
		private List<ITargetGearGroupConfig> _GroupConfigsCache;

		// Token: 0x040020E0 RID: 8416
		private bool _GroupConfigsInited;
	}
}
