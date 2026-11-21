using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000924 RID: 2340
	public class RollBlockItemComponent : IComponentBase
	{
		// Token: 0x0600339D RID: 13213 RVA: 0x00083C38 File Offset: 0x00081E38
		private RollBlockItemComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RollBlockItemComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RollBlockItemComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RollBlockItemComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x00083C70 File Offset: 0x00081E70
		public static RollBlockItemComponent Create([Nullable(2)] RollBlockItemComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RollBlockItemComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x00083C83 File Offset: 0x00081E83
		public static RollBlockItemComponent CreateFromSetValue([Nullable(2)] RollBlockItemComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RollBlockItemComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x00083C96 File Offset: 0x00081E96
		public new RollBlockItemComponent_SetValue ToSetValue()
		{
			return new RollBlockItemComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x060033A1 RID: 13217 RVA: 0x00083CB8 File Offset: 0x00081EB8
		// (set) Token: 0x060033A2 RID: 13218 RVA: 0x00083CF2 File Offset: 0x00081EF2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				RollBlockItemComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x060033A3 RID: 13219 RVA: 0x00083D00 File Offset: 0x00081F00
		// (set) Token: 0x060033A4 RID: 13220 RVA: 0x00083D2A File Offset: 0x00081F2A
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

		// Token: 0x040021E2 RID: 8674
		[Nullable(2)]
		protected new RollBlockItemComponent FbInstance;

		// Token: 0x040021E3 RID: 8675
		[Nullable(2)]
		protected new RollBlockItemComponent_SetValue PocoInterface;
	}
}
