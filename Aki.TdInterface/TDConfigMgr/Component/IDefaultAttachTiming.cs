using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002AF RID: 687
	[NullableContext(1)]
	[Nullable(0)]
	public class IDefaultAttachTiming : IAttachTiming
	{
		// Token: 0x06000CD9 RID: 3289 RVA: 0x00030E34 File Offset: 0x0002F034
		private IDefaultAttachTiming_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDefaultAttachTiming 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDefaultAttachTiming_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDefaultAttachTiming_SetValue());
			}
			return result;
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00030E6C File Offset: 0x0002F06C
		public static IDefaultAttachTiming Create([Nullable(2)] IDefaultAttachTiming instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDefaultAttachTiming
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00030E7F File Offset: 0x0002F07F
		public static IDefaultAttachTiming CreateFromSetValue([Nullable(2)] IDefaultAttachTiming_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDefaultAttachTiming
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00030E92 File Offset: 0x0002F092
		public new IDefaultAttachTiming_SetValue ToSetValue()
		{
			return new IDefaultAttachTiming_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00030EA5 File Offset: 0x0002F0A5
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x00030ED0 File Offset: 0x0002F0D0
		public override EAttachTimingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAttachTimingType.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000BDA RID: 3034
		[Nullable(2)]
		protected new IDefaultAttachTiming FbInstance;

		// Token: 0x04000BDB RID: 3035
		[Nullable(2)]
		protected new IDefaultAttachTiming_SetValue PocoInterface;
	}
}
