using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200016B RID: 363
	[NullableContext(1)]
	[Nullable(0)]
	public class ExploreSkillInteractGroupComponent : IComponentBase
	{
		// Token: 0x06000498 RID: 1176 RVA: 0x0001E7C0 File Offset: 0x0001C9C0
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

		// Token: 0x06000499 RID: 1177 RVA: 0x0001E7F8 File Offset: 0x0001C9F8
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

		// Token: 0x0600049A RID: 1178 RVA: 0x0001E80B File Offset: 0x0001CA0B
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

		// Token: 0x0600049B RID: 1179 RVA: 0x0001E81E File Offset: 0x0001CA1E
		public new ExploreSkillInteractGroupComponent_SetValue ToSetValue()
		{
			return new ExploreSkillInteractGroupComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ExploreSkillInteractList = this.ExploreSkillInteractList
			};
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0001E84C File Offset: 0x0001CA4C
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x0001E886 File Offset: 0x0001CA86
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

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0001E894 File Offset: 0x0001CA94
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x0001E8BE File Offset: 0x0001CABE
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

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0001E8CC File Offset: 0x0001CACC
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x0001E95F File Offset: 0x0001CB5F
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

		// Token: 0x040006E5 RID: 1765
		[Nullable(2)]
		protected new ExploreSkillInteractGroupComponent FbInstance;

		// Token: 0x040006E6 RID: 1766
		[Nullable(2)]
		protected new ExploreSkillInteractGroupComponent_SetValue PocoInterface;

		// Token: 0x040006E7 RID: 1767
		private List<IExploreSkillInteract> _ExploreSkillInteractListCache;

		// Token: 0x040006E8 RID: 1768
		private bool _ExploreSkillInteractListInited;
	}
}
