using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002173 RID: 8563
	public class ITalkItemAvgRoleConfig
	{
		// Token: 0x0600B732 RID: 46898 RVA: 0x0019E890 File Offset: 0x0019CA90
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

		// Token: 0x0600B733 RID: 46899 RVA: 0x0019E8C8 File Offset: 0x0019CAC8
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

		// Token: 0x0600B734 RID: 46900 RVA: 0x0019E8DB File Offset: 0x0019CADB
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

		// Token: 0x0600B735 RID: 46901 RVA: 0x0019E8EE File Offset: 0x0019CAEE
		public ITalkItemAvgRoleConfig_SetValue ToSetValue()
		{
			return new ITalkItemAvgRoleConfig_SetValue
			{
				VisualEffect = this.VisualEffect,
				AnimationType = this.AnimationType,
				IsAnimationLoop = this.IsAnimationLoop
			};
		}

		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x0600B736 RID: 46902 RVA: 0x0019E91C File Offset: 0x0019CB1C
		// (set) Token: 0x0600B737 RID: 46903 RVA: 0x0019E956 File Offset: 0x0019CB56
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

		// Token: 0x1700377D RID: 14205
		// (get) Token: 0x0600B738 RID: 46904 RVA: 0x0019E964 File Offset: 0x0019CB64
		// (set) Token: 0x0600B739 RID: 46905 RVA: 0x0019E98F File Offset: 0x0019CB8F
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

		// Token: 0x1700377E RID: 14206
		// (get) Token: 0x0600B73A RID: 46906 RVA: 0x0019E9A0 File Offset: 0x0019CBA0
		// (set) Token: 0x0600B73B RID: 46907 RVA: 0x0019E9DA File Offset: 0x0019CBDA
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

		// Token: 0x04006CF2 RID: 27890
		[Nullable(2)]
		protected ITalkItemAvgRoleConfig FbInstance;

		// Token: 0x04006CF3 RID: 27891
		[Nullable(2)]
		protected ITalkItemAvgRoleConfig_SetValue PocoInterface;
	}
}
