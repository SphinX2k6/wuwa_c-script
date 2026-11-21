using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B2F RID: 6959
	[JsonConverter(typeof(IDisableCameraOperationConverter))]
	public class IDisableCameraOperation : ICameraOperationType
	{
		// Token: 0x060093AF RID: 37807 RVA: 0x00159330 File Offset: 0x00157530
		private IDisableCameraOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableCameraOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableCameraOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableCameraOperation_SetValue());
			}
			return result;
		}

		// Token: 0x060093B0 RID: 37808 RVA: 0x00159368 File Offset: 0x00157568
		public static IDisableCameraOperation Create([Nullable(2)] IDisableCameraOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableCameraOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x060093B1 RID: 37809 RVA: 0x0015937B File Offset: 0x0015757B
		public static IDisableCameraOperation CreateFromSetValue([Nullable(2)] IDisableCameraOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableCameraOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x060093B2 RID: 37810 RVA: 0x0015938E File Offset: 0x0015758E
		public new IDisableCameraOperation_SetValue ToSetValue()
		{
			return new IDisableCameraOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F1D RID: 12061
		// (get) Token: 0x060093B3 RID: 37811 RVA: 0x001593A1 File Offset: 0x001575A1
		// (set) Token: 0x060093B4 RID: 37812 RVA: 0x001593CC File Offset: 0x001575CC
		public override ECameraOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECameraOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005BC0 RID: 23488
		[Nullable(2)]
		protected new IDisableCameraOperation FbInstance;

		// Token: 0x04005BC1 RID: 23489
		[Nullable(2)]
		protected new IDisableCameraOperation_SetValue PocoInterface;
	}
}
