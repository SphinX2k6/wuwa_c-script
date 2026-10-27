using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BAA RID: 2986
	[NullableContext(1)]
	[Nullable(0)]
	public class TargetGearGroupComponent : IComponentBase
	{
		// Token: 0x06004484 RID: 17540 RVA: 0x000AE035 File Offset: 0x000AC235
		public static TargetGearGroupComponent Create(ITargetGearGroupComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TargetGearGroupComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06004485 RID: 17541 RVA: 0x000AE054 File Offset: 0x000AC254
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06004486 RID: 17542 RVA: 0x000AE08C File Offset: 0x000AC28C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x000AE0A2 File Offset: 0x000AC2A2
		public virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06004488 RID: 17544 RVA: 0x000AE0B0 File Offset: 0x000AC2B0
		public virtual List<ITargetGearGroupConfig> GroupConfigs
		{
			get
			{
				if (this._GroupConfigsInited)
				{
					return this._GroupConfigsCache;
				}
				this._GroupConfigsInited = true;
				int groupConfigsLength = this.Instance.GroupConfigsLength;
				this._GroupConfigsCache = new List<ITargetGearGroupConfig>(groupConfigsLength);
				for (int i = 0; i < groupConfigsLength; i++)
				{
					this._GroupConfigsCache.Add(ITargetGearGroupConfig.Create(this.Instance.GroupConfigs(i)));
				}
				return this._GroupConfigsCache;
			}
		}

		// Token: 0x040026B7 RID: 9911
		private ITargetGearGroupComponent Instance;

		// Token: 0x040026B8 RID: 9912
		private List<ITargetGearGroupConfig> _GroupConfigsCache;

		// Token: 0x040026B9 RID: 9913
		private bool _GroupConfigsInited;
	}
}
