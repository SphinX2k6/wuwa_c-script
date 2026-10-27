using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000044 RID: 68
	[NullableContext(1)]
	[Nullable(0)]
	public class CombatComponent : IComponentBase
	{
		// Token: 0x0600024A RID: 586 RVA: 0x000192CC File Offset: 0x000174CC
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

		// Token: 0x0600024B RID: 587 RVA: 0x00019304 File Offset: 0x00017504
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

		// Token: 0x0600024C RID: 588 RVA: 0x00019317 File Offset: 0x00017517
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

		// Token: 0x0600024D RID: 589 RVA: 0x0001932A File Offset: 0x0001752A
		public new CombatComponent_SetValue ToSetValue()
		{
			return new CombatComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0001934C File Offset: 0x0001754C
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00019386 File Offset: 0x00017586
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

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00019394 File Offset: 0x00017594
		// (set) Token: 0x06000251 RID: 593 RVA: 0x000193BE File Offset: 0x000175BE
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

		// Token: 0x04000176 RID: 374
		[Nullable(2)]
		protected new CombatComponent FbInstance;

		// Token: 0x04000177 RID: 375
		[Nullable(2)]
		protected new CombatComponent_SetValue PocoInterface;
	}
}
