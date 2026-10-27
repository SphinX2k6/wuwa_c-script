using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008D6 RID: 2262
	[NullableContext(1)]
	[Nullable(0)]
	public class UnUseComponent : IComponentBase
	{
		// Token: 0x0600332F RID: 13103 RVA: 0x000833B0 File Offset: 0x000815B0
		private UnUseComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("UnUseComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			UnUseComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new UnUseComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x000833E8 File Offset: 0x000815E8
		public static UnUseComponent Create([Nullable(2)] UnUseComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnUseComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x000833FB File Offset: 0x000815FB
		public static UnUseComponent CreateFromSetValue([Nullable(2)] UnUseComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new UnUseComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x0008340E File Offset: 0x0008160E
		public new UnUseComponent_SetValue ToSetValue()
		{
			return new UnUseComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked
			};
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06003333 RID: 13107 RVA: 0x00083430 File Offset: 0x00081630
		// (set) Token: 0x06003334 RID: 13108 RVA: 0x0008346A File Offset: 0x0008166A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				UnUseComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06003335 RID: 13109 RVA: 0x00083478 File Offset: 0x00081678
		// (set) Token: 0x06003336 RID: 13110 RVA: 0x000834A2 File Offset: 0x000816A2
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

		// Token: 0x04002195 RID: 8597
		[Nullable(2)]
		protected new UnUseComponent FbInstance;

		// Token: 0x04002196 RID: 8598
		[Nullable(2)]
		protected new UnUseComponent_SetValue PocoInterface;
	}
}
