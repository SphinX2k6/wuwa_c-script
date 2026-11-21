using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B6F RID: 7023
	[JsonConverter(typeof(IEnableCameraOperationConverter))]
	public class IEnableCameraOperation : ICameraOperationType
	{
		// Token: 0x06009529 RID: 38185 RVA: 0x0015BE04 File Offset: 0x0015A004
		private IEnableCameraOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableCameraOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableCameraOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableCameraOperation_SetValue());
			}
			return result;
		}

		// Token: 0x0600952A RID: 38186 RVA: 0x0015BE3C File Offset: 0x0015A03C
		public static IEnableCameraOperation Create([Nullable(2)] IEnableCameraOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableCameraOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600952B RID: 38187 RVA: 0x0015BE4F File Offset: 0x0015A04F
		public static IEnableCameraOperation CreateFromSetValue([Nullable(2)] IEnableCameraOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableCameraOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600952C RID: 38188 RVA: 0x0015BE62 File Offset: 0x0015A062
		public new IEnableCameraOperation_SetValue ToSetValue()
		{
			return new IEnableCameraOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F7A RID: 12154
		// (get) Token: 0x0600952D RID: 38189 RVA: 0x0015BE75 File Offset: 0x0015A075
		// (set) Token: 0x0600952E RID: 38190 RVA: 0x0015BEA0 File Offset: 0x0015A0A0
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

		// Token: 0x04005C67 RID: 23655
		[Nullable(2)]
		protected new IEnableCameraOperation FbInstance;

		// Token: 0x04005C68 RID: 23656
		[Nullable(2)]
		protected new IEnableCameraOperation_SetValue PocoInterface;
	}
}
