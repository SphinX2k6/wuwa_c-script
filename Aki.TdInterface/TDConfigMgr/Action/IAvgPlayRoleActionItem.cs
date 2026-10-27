using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017EE RID: 6126
	[NullableContext(1)]
	[Nullable(0)]
	public class IAvgPlayRoleActionItem
	{
		// Token: 0x0600838D RID: 33677 RVA: 0x0013A070 File Offset: 0x00138270
		private IAvgPlayRoleActionItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAvgPlayRoleActionItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAvgPlayRoleActionItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAvgPlayRoleActionItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600838E RID: 33678 RVA: 0x0013A0A8 File Offset: 0x001382A8
		public static IAvgPlayRoleActionItem Create([Nullable(2)] IAvgPlayRoleActionItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAvgPlayRoleActionItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600838F RID: 33679 RVA: 0x0013A0BB File Offset: 0x001382BB
		public static IAvgPlayRoleActionItem CreateFromSetValue([Nullable(2)] IAvgPlayRoleActionItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAvgPlayRoleActionItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008390 RID: 33680 RVA: 0x0013A0D0 File Offset: 0x001382D0
		public IAvgPlayRoleActionItem_SetValue ToSetValue()
		{
			return new IAvgPlayRoleActionItem_SetValue
			{
				ActionType = this.ActionType,
				RoleId = this.RoleId,
				PositionConfig = this.PositionConfig,
				AnimationType = this.AnimationType,
				IsAnimationLoop = this.IsAnimationLoop,
				VisualEffect = this.VisualEffect
			};
		}

		// Token: 0x17002B36 RID: 11062
		// (get) Token: 0x06008391 RID: 33681 RVA: 0x0013A12A File Offset: 0x0013832A
		// (set) Token: 0x06008392 RID: 33682 RVA: 0x0013A155 File Offset: 0x00138355
		public virtual EAvgPlayRoleActionType ActionType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActionType;
				}
				if (this.PocoInterface == null)
				{
					return EAvgPlayRoleActionType.Enter;
				}
				return this.PocoInterface.ActionType;
			}
			set
			{
				this.GetOrCreatePoco().ActionType = value;
			}
		}

		// Token: 0x17002B37 RID: 11063
		// (get) Token: 0x06008393 RID: 33683 RVA: 0x0013A163 File Offset: 0x00138363
		// (set) Token: 0x06008394 RID: 33684 RVA: 0x0013A18E File Offset: 0x0013838E
		public virtual int RoleId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RoleId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RoleId;
			}
			set
			{
				this.GetOrCreatePoco().RoleId = value;
			}
		}

		// Token: 0x17002B38 RID: 11064
		// (get) Token: 0x06008395 RID: 33685 RVA: 0x0013A19C File Offset: 0x0013839C
		// (set) Token: 0x06008396 RID: 33686 RVA: 0x0013A1D6 File Offset: 0x001383D6
		public virtual EAvgRolePosition? PositionConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionConfig;
				}
				IAvgPlayRoleActionItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PositionConfig;
			}
			set
			{
				this.GetOrCreatePoco().PositionConfig = value;
			}
		}

		// Token: 0x17002B39 RID: 11065
		// (get) Token: 0x06008397 RID: 33687 RVA: 0x0013A1E4 File Offset: 0x001383E4
		// (set) Token: 0x06008398 RID: 33688 RVA: 0x0013A20F File Offset: 0x0013840F
		public virtual EAvgRoleAnimationType AnimationType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AnimationType;
				}
				if (this.PocoInterface == null)
				{
					return EAvgRoleAnimationType.Idle;
				}
				return this.PocoInterface.AnimationType;
			}
			set
			{
				this.GetOrCreatePoco().AnimationType = value;
			}
		}

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x06008399 RID: 33689 RVA: 0x0013A220 File Offset: 0x00138420
		// (set) Token: 0x0600839A RID: 33690 RVA: 0x0013A25A File Offset: 0x0013845A
		public virtual bool? IsAnimationLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAnimationLoop;
				}
				IAvgPlayRoleActionItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAnimationLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsAnimationLoop = value;
			}
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x0600839B RID: 33691 RVA: 0x0013A268 File Offset: 0x00138468
		// (set) Token: 0x0600839C RID: 33692 RVA: 0x0013A2A2 File Offset: 0x001384A2
		public virtual EAvgVisualEffect? VisualEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VisualEffect;
				}
				IAvgPlayRoleActionItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.VisualEffect;
			}
			set
			{
				this.GetOrCreatePoco().VisualEffect = value;
			}
		}

		// Token: 0x04005373 RID: 21363
		[Nullable(2)]
		protected IAvgPlayRoleActionItem FbInstance;

		// Token: 0x04005374 RID: 21364
		[Nullable(2)]
		protected IAvgPlayRoleActionItem_SetValue PocoInterface;
	}
}
