using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200004A RID: 74
	public class ConnectorComponent : IComponentBase
	{
		// Token: 0x06000274 RID: 628 RVA: 0x0001A0F8 File Offset: 0x000182F8
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

		// Token: 0x06000275 RID: 629 RVA: 0x0001A130 File Offset: 0x00018330
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

		// Token: 0x06000276 RID: 630 RVA: 0x0001A143 File Offset: 0x00018343
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

		// Token: 0x06000277 RID: 631 RVA: 0x0001A156 File Offset: 0x00018356
		public new ConnectorComponent_SetValue ToSetValue()
		{
			return new ConnectorComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				LogicType = this.LogicType
			};
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0001A184 File Offset: 0x00018384
		// (set) Token: 0x06000279 RID: 633 RVA: 0x0001A1BE File Offset: 0x000183BE
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

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0001A1CC File Offset: 0x000183CC
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0001A1F6 File Offset: 0x000183F6
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

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0001A204 File Offset: 0x00018404
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0001A22B File Offset: 0x0001842B
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

		// Token: 0x0400018D RID: 397
		[Nullable(2)]
		protected new ConnectorComponent FbInstance;

		// Token: 0x0400018E RID: 398
		[Nullable(2)]
		protected new ConnectorComponent_SetValue PocoInterface;
	}
}
