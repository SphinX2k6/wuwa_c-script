using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000897 RID: 2199
	[NullableContext(1)]
	[Nullable(0)]
	public class SimpleCombatComponent : IComponentBase
	{
		// Token: 0x06003113 RID: 12563 RVA: 0x0007E2A0 File Offset: 0x0007C4A0
		private SimpleCombatComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SimpleCombatComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SimpleCombatComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SimpleCombatComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x0007E2D8 File Offset: 0x0007C4D8
		public static SimpleCombatComponent Create([Nullable(2)] SimpleCombatComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SimpleCombatComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x0007E2EB File Offset: 0x0007C4EB
		public static SimpleCombatComponent CreateFromSetValue([Nullable(2)] SimpleCombatComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SimpleCombatComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x0007E2FE File Offset: 0x0007C4FE
		public new SimpleCombatComponent_SetValue ToSetValue()
		{
			return new SimpleCombatComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Id = this.Id
			};
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06003117 RID: 12567 RVA: 0x0007E32C File Offset: 0x0007C52C
		// (set) Token: 0x06003118 RID: 12568 RVA: 0x0007E366 File Offset: 0x0007C566
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SimpleCombatComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06003119 RID: 12569 RVA: 0x0007E374 File Offset: 0x0007C574
		// (set) Token: 0x0600311A RID: 12570 RVA: 0x0007E39E File Offset: 0x0007C59E
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

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x0600311B RID: 12571 RVA: 0x0007E3AC File Offset: 0x0007C5AC
		// (set) Token: 0x0600311C RID: 12572 RVA: 0x0007E3D7 File Offset: 0x0007C5D7
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04002046 RID: 8262
		[Nullable(2)]
		protected new SimpleCombatComponent FbInstance;

		// Token: 0x04002047 RID: 8263
		[Nullable(2)]
		protected new SimpleCombatComponent_SetValue PocoInterface;
	}
}
