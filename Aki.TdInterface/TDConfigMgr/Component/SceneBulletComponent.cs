using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000889 RID: 2185
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneBulletComponent : IComponentBase
	{
		// Token: 0x060030B3 RID: 12467 RVA: 0x0007D540 File Offset: 0x0007B740
		private SceneBulletComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SceneBulletComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SceneBulletComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SceneBulletComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x0007D578 File Offset: 0x0007B778
		public static SceneBulletComponent Create([Nullable(2)] SceneBulletComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SceneBulletComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x0007D58B File Offset: 0x0007B78B
		public static SceneBulletComponent CreateFromSetValue([Nullable(2)] SceneBulletComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SceneBulletComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x0007D59E File Offset: 0x0007B79E
		public new SceneBulletComponent_SetValue ToSetValue()
		{
			return new SceneBulletComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				DisableGenerateByRange = this.DisableGenerateByRange,
				BulletGroups = this.BulletGroups
			};
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060030B7 RID: 12471 RVA: 0x0007D5D8 File Offset: 0x0007B7D8
		// (set) Token: 0x060030B8 RID: 12472 RVA: 0x0007D612 File Offset: 0x0007B812
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SceneBulletComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060030B9 RID: 12473 RVA: 0x0007D620 File Offset: 0x0007B820
		// (set) Token: 0x060030BA RID: 12474 RVA: 0x0007D64A File Offset: 0x0007B84A
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

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060030BB RID: 12475 RVA: 0x0007D658 File Offset: 0x0007B858
		// (set) Token: 0x060030BC RID: 12476 RVA: 0x0007D692 File Offset: 0x0007B892
		public virtual bool? DisableGenerateByRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableGenerateByRange;
				}
				SceneBulletComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableGenerateByRange;
			}
			set
			{
				this.GetOrCreatePoco().DisableGenerateByRange = value;
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060030BD RID: 12477 RVA: 0x0007D6A0 File Offset: 0x0007B8A0
		// (set) Token: 0x060030BE RID: 12478 RVA: 0x0007D733 File Offset: 0x0007B933
		public virtual List<ISceneBulletGroup> BulletGroups
		{
			get
			{
				if (this._BulletGroupsInited)
				{
					return this._BulletGroupsCache;
				}
				this._BulletGroupsInited = true;
				if (this.FbInstance != null)
				{
					List<ISceneBulletGroup> bulletGroups = this.FbInstance.BulletGroups;
					if (bulletGroups != null)
					{
						this._BulletGroupsCache = new List<ISceneBulletGroup>(bulletGroups.Count);
						for (int i = 0; i < bulletGroups.Count; i++)
						{
							this._BulletGroupsCache.Add(ISceneBulletGroup.Create(bulletGroups[i]));
						}
					}
				}
				else
				{
					SceneBulletComponent_SetValue pocoInterface = this.PocoInterface;
					this._BulletGroupsCache = ((pocoInterface != null) ? pocoInterface.BulletGroups : null);
				}
				return this._BulletGroupsCache;
			}
			set
			{
				this.GetOrCreatePoco().BulletGroups = value;
				this._BulletGroupsInited = false;
			}
		}

		// Token: 0x0400200D RID: 8205
		[Nullable(2)]
		protected new SceneBulletComponent FbInstance;

		// Token: 0x0400200E RID: 8206
		[Nullable(2)]
		protected new SceneBulletComponent_SetValue PocoInterface;

		// Token: 0x0400200F RID: 8207
		private List<ISceneBulletGroup> _BulletGroupsCache;

		// Token: 0x04002010 RID: 8208
		private bool _BulletGroupsInited;
	}
}
