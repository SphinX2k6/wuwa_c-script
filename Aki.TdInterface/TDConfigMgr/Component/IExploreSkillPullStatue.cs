using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000358 RID: 856
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillPullStatue : IExploreSkillInteractType
	{
		// Token: 0x060010FF RID: 4351 RVA: 0x0003A27C File Offset: 0x0003847C
		private IExploreSkillPullStatue_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExploreSkillPullStatue 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExploreSkillPullStatue_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExploreSkillPullStatue_SetValue());
			}
			return result;
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x0003A2B4 File Offset: 0x000384B4
		public static IExploreSkillPullStatue Create([Nullable(2)] IExploreSkillPullStatue instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillPullStatue
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x0003A2C7 File Offset: 0x000384C7
		public static IExploreSkillPullStatue CreateFromSetValue([Nullable(2)] IExploreSkillPullStatue_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExploreSkillPullStatue
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x0003A2DA File Offset: 0x000384DA
		public new IExploreSkillPullStatue_SetValue ToSetValue()
		{
			return new IExploreSkillPullStatue_SetValue
			{
				Type = this.Type,
				Condition = this.Condition,
				StatueInteractPointId = this.StatueInteractPointId
			};
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x0003A305 File Offset: 0x00038505
		// (set) Token: 0x06001104 RID: 4356 RVA: 0x0003A330 File Offset: 0x00038530
		public override EExploreSkillInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x0003A340 File Offset: 0x00038540
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x0003A3A1 File Offset: 0x000385A1
		public virtual ICategoryMatchingCondition Condition
		{
			get
			{
				if (this._ConditionInited)
				{
					return this._ConditionCache;
				}
				this._ConditionInited = true;
				if (this.FbInstance != null)
				{
					this._ConditionCache = ICategoryMatchingCondition.Create(this.FbInstance.Condition);
				}
				else
				{
					IExploreSkillPullStatue_SetValue pocoInterface = this.PocoInterface;
					this._ConditionCache = ((pocoInterface != null) ? pocoInterface.Condition : null);
				}
				return this._ConditionCache;
			}
			set
			{
				this.GetOrCreatePoco().Condition = value;
				this._ConditionInited = false;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x0003A3B6 File Offset: 0x000385B6
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x0003A3E1 File Offset: 0x000385E1
		public virtual int StatueInteractPointId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StatueInteractPointId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.StatueInteractPointId;
			}
			set
			{
				this.GetOrCreatePoco().StatueInteractPointId = value;
			}
		}

		// Token: 0x04000E22 RID: 3618
		[Nullable(2)]
		protected new IExploreSkillPullStatue FbInstance;

		// Token: 0x04000E23 RID: 3619
		[Nullable(2)]
		protected new IExploreSkillPullStatue_SetValue PocoInterface;

		// Token: 0x04000E24 RID: 3620
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x04000E25 RID: 3621
		private bool _ConditionInited;
	}
}
