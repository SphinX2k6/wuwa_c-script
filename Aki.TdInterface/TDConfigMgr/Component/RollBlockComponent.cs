using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200087D RID: 2173
	[NullableContext(1)]
	[Nullable(0)]
	public class RollBlockComponent : IComponentBase
	{
		// Token: 0x0600304D RID: 12365 RVA: 0x0007C530 File Offset: 0x0007A730
		private RollBlockComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RollBlockComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RollBlockComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RollBlockComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x0007C568 File Offset: 0x0007A768
		public static RollBlockComponent Create([Nullable(2)] RollBlockComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RollBlockComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x0007C57B File Offset: 0x0007A77B
		public static RollBlockComponent CreateFromSetValue([Nullable(2)] RollBlockComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RollBlockComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x0007C58E File Offset: 0x0007A78E
		public new RollBlockComponent_SetValue ToSetValue()
		{
			return new RollBlockComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06003051 RID: 12369 RVA: 0x0007C5B0 File Offset: 0x0007A7B0
		// (set) Token: 0x06003052 RID: 12370 RVA: 0x0007C5EA File Offset: 0x0007A7EA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				RollBlockComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06003053 RID: 12371 RVA: 0x0007C5F8 File Offset: 0x0007A7F8
		// (set) Token: 0x06003054 RID: 12372 RVA: 0x0007C622 File Offset: 0x0007A822
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

		// Token: 0x04001FC8 RID: 8136
		[Nullable(2)]
		protected new RollBlockComponent FbInstance;

		// Token: 0x04001FC9 RID: 8137
		[Nullable(2)]
		protected new RollBlockComponent_SetValue PocoInterface;
	}
}
