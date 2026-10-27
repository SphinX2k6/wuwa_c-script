using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000873 RID: 2163
	[NullableContext(1)]
	[Nullable(0)]
	public class ResetSelfPosComponent : IComponentBase
	{
		// Token: 0x06002FF9 RID: 12281 RVA: 0x0007B948 File Offset: 0x00079B48
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

		// Token: 0x06002FFA RID: 12282 RVA: 0x0007B980 File Offset: 0x00079B80
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

		// Token: 0x06002FFB RID: 12283 RVA: 0x0007B993 File Offset: 0x00079B93
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

		// Token: 0x06002FFC RID: 12284 RVA: 0x0007B9A8 File Offset: 0x00079BA8
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

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002FFD RID: 12285 RVA: 0x0007BA04 File Offset: 0x00079C04
		// (set) Token: 0x06002FFE RID: 12286 RVA: 0x0007BA3E File Offset: 0x00079C3E
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

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06002FFF RID: 12287 RVA: 0x0007BA4C File Offset: 0x00079C4C
		// (set) Token: 0x06003000 RID: 12288 RVA: 0x0007BA76 File Offset: 0x00079C76
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

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06003001 RID: 12289 RVA: 0x0007BA84 File Offset: 0x00079C84
		// (set) Token: 0x06003002 RID: 12290 RVA: 0x0007BAB3 File Offset: 0x00079CB3
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

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06003003 RID: 12291 RVA: 0x0007BAC4 File Offset: 0x00079CC4
		// (set) Token: 0x06003004 RID: 12292 RVA: 0x0007BAFE File Offset: 0x00079CFE
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

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06003005 RID: 12293 RVA: 0x0007BB0C File Offset: 0x00079D0C
		// (set) Token: 0x06003006 RID: 12294 RVA: 0x0007BB46 File Offset: 0x00079D46
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

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06003007 RID: 12295 RVA: 0x0007BB54 File Offset: 0x00079D54
		// (set) Token: 0x06003008 RID: 12296 RVA: 0x0007BB8E File Offset: 0x00079D8E
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

		// Token: 0x04001F97 RID: 8087
		[Nullable(2)]
		protected new ResetSelfPosComponent FbInstance;

		// Token: 0x04001F98 RID: 8088
		[Nullable(2)]
		protected new ResetSelfPosComponent_SetValue PocoInterface;
	}
}
