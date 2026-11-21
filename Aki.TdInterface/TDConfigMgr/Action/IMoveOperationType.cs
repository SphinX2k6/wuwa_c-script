using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E2B RID: 7723
	[JsonConverter(typeof(IMoveOperationTypeConverter))]
	public class IMoveOperationType
	{
		// Token: 0x0600A43F RID: 42047 RVA: 0x00177440 File Offset: 0x00175640
		private IMoveOperationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMoveOperationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMoveOperationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMoveOperationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A440 RID: 42048 RVA: 0x00177478 File Offset: 0x00175678
		public static IMoveOperationType Create([Nullable(2)] IMoveOperationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoveOperationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A441 RID: 42049 RVA: 0x0017748B File Offset: 0x0017568B
		public static IMoveOperationType CreateFromSetValue([Nullable(2)] IMoveOperationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMoveOperationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A442 RID: 42050 RVA: 0x0017749E File Offset: 0x0017569E
		public IMoveOperationType_SetValue ToSetValue()
		{
			return new IMoveOperationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x0600A443 RID: 42051 RVA: 0x001774B1 File Offset: 0x001756B1
		// (set) Token: 0x0600A444 RID: 42052 RVA: 0x001774DC File Offset: 0x001756DC
		public virtual EMoveOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMoveOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006360 RID: 25440
		[Nullable(2)]
		protected IMoveOperationType FbInstance;

		// Token: 0x04006361 RID: 25441
		[Nullable(2)]
		protected IMoveOperationType_SetValue PocoInterface;
	}
}
