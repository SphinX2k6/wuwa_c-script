using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008E2 RID: 2274
	public class MoveComponent : IComponentBase
	{
		// Token: 0x0600317F RID: 12671 RVA: 0x0007EF64 File Offset: 0x0007D164
		private MoveComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("MoveComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			MoveComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new MoveComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x0007EF9C File Offset: 0x0007D19C
		public static MoveComponent Create([Nullable(2)] MoveComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MoveComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x0007EFAF File Offset: 0x0007D1AF
		public static MoveComponent CreateFromSetValue([Nullable(2)] MoveComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new MoveComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x0007EFC2 File Offset: 0x0007D1C2
		public new MoveComponent_SetValue ToSetValue()
		{
			return new MoveComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				InitSpeed = this.InitSpeed
			};
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06003183 RID: 12675 RVA: 0x0007EFF0 File Offset: 0x0007D1F0
		// (set) Token: 0x06003184 RID: 12676 RVA: 0x0007F02A File Offset: 0x0007D22A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				MoveComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06003185 RID: 12677 RVA: 0x0007F038 File Offset: 0x0007D238
		// (set) Token: 0x06003186 RID: 12678 RVA: 0x0007F062 File Offset: 0x0007D262
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

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x0007F070 File Offset: 0x0007D270
		// (set) Token: 0x06003188 RID: 12680 RVA: 0x0007F09F File Offset: 0x0007D29F
		public virtual float InitSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.InitSpeed;
			}
			set
			{
				this.GetOrCreatePoco().InitSpeed = value;
			}
		}

		// Token: 0x040020A2 RID: 8354
		[Nullable(2)]
		protected new MoveComponent FbInstance;

		// Token: 0x040020A3 RID: 8355
		[Nullable(2)]
		protected new MoveComponent_SetValue PocoInterface;
	}
}
