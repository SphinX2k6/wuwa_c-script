using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000180 RID: 384
	public class ExploreSkillInteractGroupComponent : IComponentBase
	{
		// Token: 0x0600049C RID: 1180 RVA: 0x0001F134 File Offset: 0x0001D334
		private ExploreSkillInteractGroupComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ExploreSkillInteractGroupComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ExploreSkillInteractGroupComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ExploreSkillInteractGroupComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0001F16C File Offset: 0x0001D36C
		public static ExploreSkillInteractGroupComponent Create([Nullable(2)] ExploreSkillInteractGroupComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExploreSkillInteractGroupComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0001F17F File Offset: 0x0001D37F
		public static ExploreSkillInteractGroupComponent CreateFromSetValue([Nullable(2)] ExploreSkillInteractGroupComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ExploreSkillInteractGroupComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0001F192 File Offset: 0x0001D392
		public new ExploreSkillInteractGroupComponent_SetValue ToSetValue()
		{
			return new ExploreSkillInteractGroupComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ExploreSkillInteractList = this.ExploreSkillInteractList
			};
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0001F1C0 File Offset: 0x0001D3C0
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x0001F1FA File Offset: 0x0001D3FA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ExploreSkillInteractGroupComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0001F208 File Offset: 0x0001D408
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x0001F232 File Offset: 0x0001D432
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

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0001F240 File Offset: 0x0001D440
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x0001F2D3 File Offset: 0x0001D4D3
		public virtual List<IExploreSkillInteract> ExploreSkillInteractList
		{
			get
			{
				if (this._ExploreSkillInteractListInited)
				{
					return this._ExploreSkillInteractListCache;
				}
				this._ExploreSkillInteractListInited = true;
				if (this.FbInstance != null)
				{
					List<IExploreSkillInteract> exploreSkillInteractList = this.FbInstance.ExploreSkillInteractList;
					if (exploreSkillInteractList != null)
					{
						this._ExploreSkillInteractListCache = new List<IExploreSkillInteract>(exploreSkillInteractList.Count);
						for (int i = 0; i < exploreSkillInteractList.Count; i++)
						{
							this._ExploreSkillInteractListCache.Add(IExploreSkillInteract.Create(exploreSkillInteractList[i]));
						}
					}
				}
				else
				{
					ExploreSkillInteractGroupComponent_SetValue pocoInterface = this.PocoInterface;
					this._ExploreSkillInteractListCache = ((pocoInterface != null) ? pocoInterface.ExploreSkillInteractList : null);
				}
				return this._ExploreSkillInteractListCache;
			}
			set
			{
				this.GetOrCreatePoco().ExploreSkillInteractList = value;
				this._ExploreSkillInteractListInited = false;
			}
		}

		// Token: 0x04000732 RID: 1842
		[Nullable(2)]
		protected new ExploreSkillInteractGroupComponent FbInstance;

		// Token: 0x04000733 RID: 1843
		[Nullable(2)]
		protected new ExploreSkillInteractGroupComponent_SetValue PocoInterface;

		// Token: 0x04000734 RID: 1844
		private List<IExploreSkillInteract> _ExploreSkillInteractListCache;

		// Token: 0x04000735 RID: 1845
		private bool _ExploreSkillInteractListInited;
	}
}
