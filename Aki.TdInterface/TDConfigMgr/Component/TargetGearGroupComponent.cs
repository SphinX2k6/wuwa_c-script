using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200095A RID: 2394
	public class TargetGearGroupComponent : IComponentBase
	{
		// Token: 0x0600355D RID: 13661 RVA: 0x00087DC8 File Offset: 0x00085FC8
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

		// Token: 0x0600355E RID: 13662 RVA: 0x00087E00 File Offset: 0x00086000
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

		// Token: 0x0600355F RID: 13663 RVA: 0x00087E13 File Offset: 0x00086013
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

		// Token: 0x06003560 RID: 13664 RVA: 0x00087E26 File Offset: 0x00086026
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

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06003561 RID: 13665 RVA: 0x00087E60 File Offset: 0x00086060
		// (set) Token: 0x06003562 RID: 13666 RVA: 0x00087E9A File Offset: 0x0008609A
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

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06003563 RID: 13667 RVA: 0x00087EA8 File Offset: 0x000860A8
		// (set) Token: 0x06003564 RID: 13668 RVA: 0x00087ED2 File Offset: 0x000860D2
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

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06003565 RID: 13669 RVA: 0x00087EE0 File Offset: 0x000860E0
		// (set) Token: 0x06003566 RID: 13670 RVA: 0x00087F0B File Offset: 0x0008610B
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

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06003567 RID: 13671 RVA: 0x00087F1C File Offset: 0x0008611C
		// (set) Token: 0x06003568 RID: 13672 RVA: 0x00087FAF File Offset: 0x000861AF
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

		// Token: 0x040022EF RID: 8943
		[Nullable(2)]
		protected new TargetGearGroupComponent FbInstance;

		// Token: 0x040022F0 RID: 8944
		[Nullable(2)]
		protected new TargetGearGroupComponent_SetValue PocoInterface;

		// Token: 0x040022F1 RID: 8945
		private List<ITargetGearGroupConfig> _GroupConfigsCache;

		// Token: 0x040022F2 RID: 8946
		private bool _GroupConfigsInited;
	}
}
