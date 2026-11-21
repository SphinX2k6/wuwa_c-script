using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003A1 RID: 929
	public class IExploreSkillPullStatue : IExploreSkillInteractType
	{
		// Token: 0x06001243 RID: 4675 RVA: 0x0003D560 File Offset: 0x0003B760
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

		// Token: 0x06001244 RID: 4676 RVA: 0x0003D598 File Offset: 0x0003B798
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

		// Token: 0x06001245 RID: 4677 RVA: 0x0003D5AB File Offset: 0x0003B7AB
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

		// Token: 0x06001246 RID: 4678 RVA: 0x0003D5BE File Offset: 0x0003B7BE
		public new IExploreSkillPullStatue_SetValue ToSetValue()
		{
			return new IExploreSkillPullStatue_SetValue
			{
				Type = this.Type,
				Condition = this.Condition,
				StatueInteractPointId = this.StatueInteractPointId
			};
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x0003D5E9 File Offset: 0x0003B7E9
		// (set) Token: 0x06001248 RID: 4680 RVA: 0x0003D614 File Offset: 0x0003B814
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

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x0003D624 File Offset: 0x0003B824
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x0003D685 File Offset: 0x0003B885
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

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x0003D69A File Offset: 0x0003B89A
		// (set) Token: 0x0600124C RID: 4684 RVA: 0x0003D6C5 File Offset: 0x0003B8C5
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

		// Token: 0x04000F19 RID: 3865
		[Nullable(2)]
		protected new IExploreSkillPullStatue FbInstance;

		// Token: 0x04000F1A RID: 3866
		[Nullable(2)]
		protected new IExploreSkillPullStatue_SetValue PocoInterface;

		// Token: 0x04000F1B RID: 3867
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x04000F1C RID: 3868
		private bool _ConditionInited;
	}
}
