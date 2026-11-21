using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001977 RID: 6519
	public class IAvgPlayRoleActionItem
	{
		// Token: 0x06008AA9 RID: 35497 RVA: 0x00149758 File Offset: 0x00147958
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

		// Token: 0x06008AAA RID: 35498 RVA: 0x00149790 File Offset: 0x00147990
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

		// Token: 0x06008AAB RID: 35499 RVA: 0x001497A3 File Offset: 0x001479A3
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

		// Token: 0x06008AAC RID: 35500 RVA: 0x001497B8 File Offset: 0x001479B8
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

		// Token: 0x17002D2E RID: 11566
		// (get) Token: 0x06008AAD RID: 35501 RVA: 0x00149812 File Offset: 0x00147A12
		// (set) Token: 0x06008AAE RID: 35502 RVA: 0x0014983D File Offset: 0x00147A3D
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

		// Token: 0x17002D2F RID: 11567
		// (get) Token: 0x06008AAF RID: 35503 RVA: 0x0014984B File Offset: 0x00147A4B
		// (set) Token: 0x06008AB0 RID: 35504 RVA: 0x00149876 File Offset: 0x00147A76
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

		// Token: 0x17002D30 RID: 11568
		// (get) Token: 0x06008AB1 RID: 35505 RVA: 0x00149884 File Offset: 0x00147A84
		// (set) Token: 0x06008AB2 RID: 35506 RVA: 0x001498BE File Offset: 0x00147ABE
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

		// Token: 0x17002D31 RID: 11569
		// (get) Token: 0x06008AB3 RID: 35507 RVA: 0x001498CC File Offset: 0x00147ACC
		// (set) Token: 0x06008AB4 RID: 35508 RVA: 0x001498F7 File Offset: 0x00147AF7
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

		// Token: 0x17002D32 RID: 11570
		// (get) Token: 0x06008AB5 RID: 35509 RVA: 0x00149908 File Offset: 0x00147B08
		// (set) Token: 0x06008AB6 RID: 35510 RVA: 0x00149942 File Offset: 0x00147B42
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

		// Token: 0x17002D33 RID: 11571
		// (get) Token: 0x06008AB7 RID: 35511 RVA: 0x00149950 File Offset: 0x00147B50
		// (set) Token: 0x06008AB8 RID: 35512 RVA: 0x0014998A File Offset: 0x00147B8A
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

		// Token: 0x040057BB RID: 22459
		[Nullable(2)]
		protected IAvgPlayRoleActionItem FbInstance;

		// Token: 0x040057BC RID: 22460
		[Nullable(2)]
		protected IAvgPlayRoleActionItem_SetValue PocoInterface;
	}
}
