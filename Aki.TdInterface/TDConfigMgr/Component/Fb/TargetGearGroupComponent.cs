using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C78 RID: 3192
	public class TargetGearGroupComponent : IComponentBase
	{
		// Token: 0x060048DD RID: 18653 RVA: 0x000B80F9 File Offset: 0x000B62F9
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

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x060048DE RID: 18654 RVA: 0x000B8118 File Offset: 0x000B6318
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

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x060048DF RID: 18655 RVA: 0x000B8150 File Offset: 0x000B6350
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x060048E0 RID: 18656 RVA: 0x000B8166 File Offset: 0x000B6366
		public virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x060048E1 RID: 18657 RVA: 0x000B8174 File Offset: 0x000B6374
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

		// Token: 0x040028FF RID: 10495
		private ITargetGearGroupComponent Instance;

		// Token: 0x04002900 RID: 10496
		private List<ITargetGearGroupConfig> _GroupConfigsCache;

		// Token: 0x04002901 RID: 10497
		private bool _GroupConfigsInited;
	}
}
