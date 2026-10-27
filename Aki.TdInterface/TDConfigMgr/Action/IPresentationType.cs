using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D54 RID: 7508
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IPresentationTypeConverter))]
	public class IPresentationType
	{
		// Token: 0x0600A10D RID: 41229 RVA: 0x0016F194 File Offset: 0x0016D394
		private IPresentationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPresentationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPresentationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPresentationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A10E RID: 41230 RVA: 0x0016F1CC File Offset: 0x0016D3CC
		public static IPresentationType Create([Nullable(2)] IPresentationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPresentationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A10F RID: 41231 RVA: 0x0016F1DF File Offset: 0x0016D3DF
		public static IPresentationType CreateFromSetValue([Nullable(2)] IPresentationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPresentationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A110 RID: 41232 RVA: 0x0016F1F2 File Offset: 0x0016D3F2
		public IPresentationType_SetValue ToSetValue()
		{
			return new IPresentationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x0600A111 RID: 41233 RVA: 0x0016F205 File Offset: 0x0016D405
		// (set) Token: 0x0600A112 RID: 41234 RVA: 0x0016F230 File Offset: 0x0016D430
		public virtual EResetPresentationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EResetPresentationType.Failure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040060FA RID: 24826
		[Nullable(2)]
		protected IPresentationType FbInstance;

		// Token: 0x040060FB RID: 24827
		[Nullable(2)]
		protected IPresentationType_SetValue PocoInterface;
	}
}
