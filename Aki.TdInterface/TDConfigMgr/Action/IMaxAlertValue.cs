using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BC2 RID: 7106
	[NullableContext(1)]
	[Nullable(0)]
	public class IMaxAlertValue : ISetAlertValueType
	{
		// Token: 0x0600982B RID: 38955 RVA: 0x0015ECF8 File Offset: 0x0015CEF8
		private IMaxAlertValue_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMaxAlertValue 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMaxAlertValue_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMaxAlertValue_SetValue());
			}
			return result;
		}

		// Token: 0x0600982C RID: 38956 RVA: 0x0015ED30 File Offset: 0x0015CF30
		public static IMaxAlertValue Create([Nullable(2)] IMaxAlertValue instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMaxAlertValue
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600982D RID: 38957 RVA: 0x0015ED43 File Offset: 0x0015CF43
		public static IMaxAlertValue CreateFromSetValue([Nullable(2)] IMaxAlertValue_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMaxAlertValue
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600982E RID: 38958 RVA: 0x0015ED56 File Offset: 0x0015CF56
		public new IMaxAlertValue_SetValue ToSetValue()
		{
			return new IMaxAlertValue_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FC9 RID: 12233
		// (get) Token: 0x0600982F RID: 38959 RVA: 0x0015ED69 File Offset: 0x0015CF69
		// (set) Token: 0x06009830 RID: 38960 RVA: 0x0015ED94 File Offset: 0x0015CF94
		public override EValueChangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EValueChangeType.AddOrSub;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005CD8 RID: 23768
		[Nullable(2)]
		protected new IMaxAlertValue FbInstance;

		// Token: 0x04005CD9 RID: 23769
		[Nullable(2)]
		protected new IMaxAlertValue_SetValue PocoInterface;
	}
}
