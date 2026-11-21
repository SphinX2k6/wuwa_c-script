using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F65 RID: 8037
	[JsonConverter(typeof(IPresentationTypeConverter))]
	public class IPresentationType
	{
		// Token: 0x0600AAF9 RID: 43769 RVA: 0x001835B8 File Offset: 0x001817B8
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

		// Token: 0x0600AAFA RID: 43770 RVA: 0x001835F0 File Offset: 0x001817F0
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

		// Token: 0x0600AAFB RID: 43771 RVA: 0x00183603 File Offset: 0x00181803
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

		// Token: 0x0600AAFC RID: 43772 RVA: 0x00183616 File Offset: 0x00181816
		public IPresentationType_SetValue ToSetValue()
		{
			return new IPresentationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003473 RID: 13427
		// (get) Token: 0x0600AAFD RID: 43773 RVA: 0x00183629 File Offset: 0x00181829
		// (set) Token: 0x0600AAFE RID: 43774 RVA: 0x00183654 File Offset: 0x00181854
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

		// Token: 0x04006676 RID: 26230
		[Nullable(2)]
		protected IPresentationType FbInstance;

		// Token: 0x04006677 RID: 26231
		[Nullable(2)]
		protected IPresentationType_SetValue PocoInterface;
	}
}
