using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C72 RID: 3186
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneBulletComponent : IComponentBase
	{
		// Token: 0x06004905 RID: 18693 RVA: 0x000B753B File Offset: 0x000B573B
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

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06004906 RID: 18694 RVA: 0x000B755C File Offset: 0x000B575C
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

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06004907 RID: 18695 RVA: 0x000B7594 File Offset: 0x000B5794
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x06004908 RID: 18696 RVA: 0x000B75AC File Offset: 0x000B57AC
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

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x06004909 RID: 18697 RVA: 0x000B75E4 File Offset: 0x000B57E4
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

		// Token: 0x040029AB RID: 10667
		private ISceneBulletComponent Instance;

		// Token: 0x040029AC RID: 10668
		private List<ISceneBulletGroup> _BulletGroupsCache;

		// Token: 0x040029AD RID: 10669
		private bool _BulletGroupsInited;
	}
}
