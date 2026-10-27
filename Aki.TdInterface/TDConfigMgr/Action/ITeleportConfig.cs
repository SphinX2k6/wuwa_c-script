using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F96 RID: 8086
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportConfig
	{
		// Token: 0x0600B1D2 RID: 45522 RVA: 0x0019EB30 File Offset: 0x0019CD30
		private ITeleportConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600B1D3 RID: 45523 RVA: 0x0019EB68 File Offset: 0x0019CD68
		public static ITeleportConfig Create([Nullable(2)] ITeleportConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B1D4 RID: 45524 RVA: 0x0019EB7B File Offset: 0x0019CD7B
		public static ITeleportConfig CreateFromSetValue([Nullable(2)] ITeleportConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B1D5 RID: 45525 RVA: 0x0019EB8E File Offset: 0x0019CD8E
		public ITeleportConfig_SetValue ToSetValue()
		{
			return new ITeleportConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036E0 RID: 14048
		// (get) Token: 0x0600B1D6 RID: 45526 RVA: 0x0019EBA1 File Offset: 0x0019CDA1
		// (set) Token: 0x0600B1D7 RID: 45527 RVA: 0x0019EBCC File Offset: 0x0019CDCC
		public virtual ETeleportType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportType.FixedPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006B75 RID: 27509
		[Nullable(2)]
		protected ITeleportConfig FbInstance;

		// Token: 0x04006B76 RID: 27510
		[Nullable(2)]
		protected ITeleportConfig_SetValue PocoInterface;
	}
}
