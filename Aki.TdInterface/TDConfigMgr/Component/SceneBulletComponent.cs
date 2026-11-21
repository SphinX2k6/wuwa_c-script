using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200092C RID: 2348
	public class SceneBulletComponent : IComponentBase
	{
		// Token: 0x060033EF RID: 13295 RVA: 0x00084A28 File Offset: 0x00082C28
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

		// Token: 0x060033F0 RID: 13296 RVA: 0x00084A60 File Offset: 0x00082C60
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

		// Token: 0x060033F1 RID: 13297 RVA: 0x00084A73 File Offset: 0x00082C73
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

		// Token: 0x060033F2 RID: 13298 RVA: 0x00084A86 File Offset: 0x00082C86
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

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x060033F3 RID: 13299 RVA: 0x00084AC0 File Offset: 0x00082CC0
		// (set) Token: 0x060033F4 RID: 13300 RVA: 0x00084AFA File Offset: 0x00082CFA
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

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x060033F5 RID: 13301 RVA: 0x00084B08 File Offset: 0x00082D08
		// (set) Token: 0x060033F6 RID: 13302 RVA: 0x00084B32 File Offset: 0x00082D32
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

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x060033F7 RID: 13303 RVA: 0x00084B40 File Offset: 0x00082D40
		// (set) Token: 0x060033F8 RID: 13304 RVA: 0x00084B7A File Offset: 0x00082D7A
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

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x060033F9 RID: 13305 RVA: 0x00084B88 File Offset: 0x00082D88
		// (set) Token: 0x060033FA RID: 13306 RVA: 0x00084C1B File Offset: 0x00082E1B
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

		// Token: 0x0400221F RID: 8735
		[Nullable(2)]
		protected new SceneBulletComponent FbInstance;

		// Token: 0x04002220 RID: 8736
		[Nullable(2)]
		protected new SceneBulletComponent_SetValue PocoInterface;

		// Token: 0x04002221 RID: 8737
		private List<ISceneBulletGroup> _BulletGroupsCache;

		// Token: 0x04002222 RID: 8738
		private bool _BulletGroupsInited;
	}
}
