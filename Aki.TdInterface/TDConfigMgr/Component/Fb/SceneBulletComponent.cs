using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D51 RID: 3409
	public class SceneBulletComponent : IComponentBase
	{
		// Token: 0x06004DA4 RID: 19876 RVA: 0x000C1D3F File Offset: 0x000BFF3F
		public static SceneBulletComponent Create(ISceneBulletComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SceneBulletComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06004DA5 RID: 19877 RVA: 0x000C1D60 File Offset: 0x000BFF60
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

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x06004DA6 RID: 19878 RVA: 0x000C1D98 File Offset: 0x000BFF98
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06004DA7 RID: 19879 RVA: 0x000C1DB0 File Offset: 0x000BFFB0
		public virtual bool? DisableGenerateByRange
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableGenerateByRange);
			}
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06004DA8 RID: 19880 RVA: 0x000C1DE8 File Offset: 0x000BFFE8
		public virtual List<ISceneBulletGroup> BulletGroups
		{
			get
			{
				if (this._BulletGroupsInited)
				{
					return this._BulletGroupsCache;
				}
				this._BulletGroupsInited = true;
				int bulletGroupsLength = this.Instance.BulletGroupsLength;
				this._BulletGroupsCache = new List<ISceneBulletGroup>(bulletGroupsLength);
				for (int i = 0; i < bulletGroupsLength; i++)
				{
					this._BulletGroupsCache.Add(ISceneBulletGroup.Create(this.Instance.BulletGroups(i)));
				}
				return this._BulletGroupsCache;
			}
		}

		// Token: 0x04002C18 RID: 11288
		private ISceneBulletComponent Instance;

		// Token: 0x04002C19 RID: 11289
		private List<ISceneBulletGroup> _BulletGroupsCache;

		// Token: 0x04002C1A RID: 11290
		private bool _BulletGroupsInited;
	}
}
