using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200004A RID: 74
	[NullableContext(1)]
	[Nullable(0)]
	public class ConnectorComponent : IComponentBase
	{
		// Token: 0x06000270 RID: 624 RVA: 0x00019784 File Offset: 0x00017984
		private ConnectorComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ConnectorComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ConnectorComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ConnectorComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000197BC File Offset: 0x000179BC
		public static ConnectorComponent Create([Nullable(2)] ConnectorComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ConnectorComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000197CF File Offset: 0x000179CF
		public static ConnectorComponent CreateFromSetValue([Nullable(2)] ConnectorComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ConnectorComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000197E2 File Offset: 0x000179E2
		public new ConnectorComponent_SetValue ToSetValue()
		{
			return new ConnectorComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				LogicType = this.LogicType
			};
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00019810 File Offset: 0x00017A10
		// (set) Token: 0x06000275 RID: 629 RVA: 0x0001984A File Offset: 0x00017A4A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ConnectorComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00019858 File Offset: 0x00017A58
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00019882 File Offset: 0x00017A82
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00019890 File Offset: 0x00017A90
		// (set) Token: 0x06000279 RID: 633 RVA: 0x000198B7 File Offset: 0x00017AB7
		public virtual IConnectorLogicType LogicType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LogicType;
				}
				ConnectorComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LogicType;
			}
			set
			{
				this.GetOrCreatePoco().LogicType = value;
			}
		}

		// Token: 0x04000188 RID: 392
		[Nullable(2)]
		protected new ConnectorComponent FbInstance;

		// Token: 0x04000189 RID: 393
		[Nullable(2)]
		protected new ConnectorComponent_SetValue PocoInterface;
	}
}
