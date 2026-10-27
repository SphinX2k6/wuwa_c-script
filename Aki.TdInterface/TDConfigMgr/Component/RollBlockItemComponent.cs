using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000881 RID: 2177
	[NullableContext(1)]
	[Nullable(0)]
	public class RollBlockItemComponent : IComponentBase
	{
		// Token: 0x06003061 RID: 12385 RVA: 0x0007C750 File Offset: 0x0007A950
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

		// Token: 0x06003062 RID: 12386 RVA: 0x0007C788 File Offset: 0x0007A988
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

		// Token: 0x06003063 RID: 12387 RVA: 0x0007C79B File Offset: 0x0007A99B
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

		// Token: 0x06003064 RID: 12388 RVA: 0x0007C7AE File Offset: 0x0007A9AE
		public new RollBlockItemComponent_SetValue ToSetValue()
		{
			return new RollBlockItemComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06003065 RID: 12389 RVA: 0x0007C7D0 File Offset: 0x0007A9D0
		// (set) Token: 0x06003066 RID: 12390 RVA: 0x0007C80A File Offset: 0x0007AA0A
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

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06003067 RID: 12391 RVA: 0x0007C818 File Offset: 0x0007AA18
		// (set) Token: 0x06003068 RID: 12392 RVA: 0x0007C842 File Offset: 0x0007AA42
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

		// Token: 0x04001FD0 RID: 8144
		[Nullable(2)]
		protected new RollBlockItemComponent FbInstance;

		// Token: 0x04001FD1 RID: 8145
		[Nullable(2)]
		protected new RollBlockItemComponent_SetValue PocoInterface;
	}
}
