using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F3A RID: 7994
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkItemAvgRoleConfig
	{
		// Token: 0x0600AC60 RID: 44128 RVA: 0x00188898 File Offset: 0x00186A98
		private ITalkItemAvgRoleConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemAvgRoleConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemAvgRoleConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemAvgRoleConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC61 RID: 44129 RVA: 0x001888D0 File Offset: 0x00186AD0
		public static ITalkItemAvgRoleConfig Create([Nullable(2)] ITalkItemAvgRoleConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAvgRoleConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC62 RID: 44130 RVA: 0x001888E3 File Offset: 0x00186AE3
		public static ITalkItemAvgRoleConfig CreateFromSetValue([Nullable(2)] ITalkItemAvgRoleConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemAvgRoleConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC63 RID: 44131 RVA: 0x001888F6 File Offset: 0x00186AF6
		public ITalkItemAvgRoleConfig_SetValue ToSetValue()
		{
			return new ITalkItemAvgRoleConfig_SetValue
			{
				VisualEffect = this.VisualEffect,
				AnimationType = this.AnimationType,
				IsAnimationLoop = this.IsAnimationLoop
			};
		}

		// Token: 0x170034B1 RID: 13489
		// (get) Token: 0x0600AC64 RID: 44132 RVA: 0x00188924 File Offset: 0x00186B24
		// (set) Token: 0x0600AC65 RID: 44133 RVA: 0x0018895E File Offset: 0x00186B5E
		public virtual EAvgVisualEffect? VisualEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VisualEffect;
				}
				ITalkItemAvgRoleConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x0600AC66 RID: 44134 RVA: 0x0018896C File Offset: 0x00186B6C
		// (set) Token: 0x0600AC67 RID: 44135 RVA: 0x00188997 File Offset: 0x00186B97
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

		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x0600AC68 RID: 44136 RVA: 0x001889A8 File Offset: 0x00186BA8
		// (set) Token: 0x0600AC69 RID: 44137 RVA: 0x001889E2 File Offset: 0x00186BE2
		public virtual bool? IsAnimationLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAnimationLoop;
				}
				ITalkItemAvgRoleConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006703 RID: 26371
		[Nullable(2)]
		protected ITalkItemAvgRoleConfig FbInstance;

		// Token: 0x04006704 RID: 26372
		[Nullable(2)]
		protected ITalkItemAvgRoleConfig_SetValue PocoInterface;
	}
}
