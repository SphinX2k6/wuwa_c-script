using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000916 RID: 2326
	public class ResetSelfPosComponent : IComponentBase
	{
		// Token: 0x06003335 RID: 13109 RVA: 0x00082E30 File Offset: 0x00081030
		private ResetSelfPosComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ResetSelfPosComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ResetSelfPosComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ResetSelfPosComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x00082E68 File Offset: 0x00081068
		public static ResetSelfPosComponent Create([Nullable(2)] ResetSelfPosComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResetSelfPosComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x00082E7B File Offset: 0x0008107B
		public static ResetSelfPosComponent CreateFromSetValue([Nullable(2)] ResetSelfPosComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ResetSelfPosComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x00082E90 File Offset: 0x00081090
		public new ResetSelfPosComponent_SetValue ToSetValue()
		{
			return new ResetSelfPosComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ResetRadius = this.ResetRadius,
				IsDisableResetPosAfterThrow = this.IsDisableResetPosAfterThrow,
				IsResetPosAfterThrow = this.IsResetPosAfterThrow,
				ResetPosDelayTime = this.ResetPosDelayTime
			};
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06003339 RID: 13113 RVA: 0x00082EEC File Offset: 0x000810EC
		// (set) Token: 0x0600333A RID: 13114 RVA: 0x00082F26 File Offset: 0x00081126
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ResetSelfPosComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x0600333B RID: 13115 RVA: 0x00082F34 File Offset: 0x00081134
		// (set) Token: 0x0600333C RID: 13116 RVA: 0x00082F5E File Offset: 0x0008115E
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

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x0600333D RID: 13117 RVA: 0x00082F6C File Offset: 0x0008116C
		// (set) Token: 0x0600333E RID: 13118 RVA: 0x00082F9B File Offset: 0x0008119B
		public virtual float ResetRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResetRadius;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.ResetRadius;
			}
			set
			{
				this.GetOrCreatePoco().ResetRadius = value;
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x0600333F RID: 13119 RVA: 0x00082FAC File Offset: 0x000811AC
		// (set) Token: 0x06003340 RID: 13120 RVA: 0x00082FE6 File Offset: 0x000811E6
		public virtual bool? IsDisableResetPosAfterThrow
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDisableResetPosAfterThrow;
				}
				ResetSelfPosComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsDisableResetPosAfterThrow;
			}
			set
			{
				this.GetOrCreatePoco().IsDisableResetPosAfterThrow = value;
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06003341 RID: 13121 RVA: 0x00082FF4 File Offset: 0x000811F4
		// (set) Token: 0x06003342 RID: 13122 RVA: 0x0008302E File Offset: 0x0008122E
		public virtual bool? IsResetPosAfterThrow
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsResetPosAfterThrow;
				}
				ResetSelfPosComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsResetPosAfterThrow;
			}
			set
			{
				this.GetOrCreatePoco().IsResetPosAfterThrow = value;
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06003343 RID: 13123 RVA: 0x0008303C File Offset: 0x0008123C
		// (set) Token: 0x06003344 RID: 13124 RVA: 0x00083076 File Offset: 0x00081276
		public virtual float? ResetPosDelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResetPosDelayTime;
				}
				ResetSelfPosComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ResetPosDelayTime;
			}
			set
			{
				this.GetOrCreatePoco().ResetPosDelayTime = value;
			}
		}

		// Token: 0x040021A9 RID: 8617
		[Nullable(2)]
		protected new ResetSelfPosComponent FbInstance;

		// Token: 0x040021AA RID: 8618
		[Nullable(2)]
		protected new ResetSelfPosComponent_SetValue PocoInterface;
	}
}
