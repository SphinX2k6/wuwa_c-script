using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000044 RID: 68
	public class CombatComponent : IComponentBase
	{
		// Token: 0x0600024E RID: 590 RVA: 0x00019C40 File Offset: 0x00017E40
		private CombatComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CombatComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CombatComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CombatComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00019C78 File Offset: 0x00017E78
		public static CombatComponent Create([Nullable(2)] CombatComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CombatComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00019C8B File Offset: 0x00017E8B
		public static CombatComponent CreateFromSetValue([Nullable(2)] CombatComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CombatComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00019C9E File Offset: 0x00017E9E
		public new CombatComponent_SetValue ToSetValue()
		{
			return new CombatComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00019CC0 File Offset: 0x00017EC0
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00019CFA File Offset: 0x00017EFA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				CombatComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00019D08 File Offset: 0x00017F08
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00019D32 File Offset: 0x00017F32
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

		// Token: 0x0400017B RID: 379
		[Nullable(2)]
		protected new CombatComponent FbInstance;

		// Token: 0x0400017C RID: 380
		[Nullable(2)]
		protected new CombatComponent_SetValue PocoInterface;
	}
}
