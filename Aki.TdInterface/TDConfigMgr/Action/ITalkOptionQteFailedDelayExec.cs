using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021B7 RID: 8631
	public class ITalkOptionQteFailedDelayExec : ITalkOptionParamType
	{
		// Token: 0x0600BC2C RID: 48172 RVA: 0x001B3D3C File Offset: 0x001B1F3C
		private ITalkOptionQteFailedDelayExec_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionQteFailedDelayExec 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionQteFailedDelayExec_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionQteFailedDelayExec_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC2D RID: 48173 RVA: 0x001B3D74 File Offset: 0x001B1F74
		public static ITalkOptionQteFailedDelayExec Create([Nullable(2)] ITalkOptionQteFailedDelayExec instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionQteFailedDelayExec
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC2E RID: 48174 RVA: 0x001B3D87 File Offset: 0x001B1F87
		public static ITalkOptionQteFailedDelayExec CreateFromSetValue([Nullable(2)] ITalkOptionQteFailedDelayExec_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionQteFailedDelayExec
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC2F RID: 48175 RVA: 0x001B3D9A File Offset: 0x001B1F9A
		public new ITalkOptionQteFailedDelayExec_SetValue ToSetValue()
		{
			return new ITalkOptionQteFailedDelayExec_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003993 RID: 14739
		// (get) Token: 0x0600BC30 RID: 48176 RVA: 0x001B3DAD File Offset: 0x001B1FAD
		// (set) Token: 0x0600BC31 RID: 48177 RVA: 0x001B3DD8 File Offset: 0x001B1FD8
		public override ETalkOptionParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007128 RID: 28968
		[Nullable(2)]
		protected new ITalkOptionQteFailedDelayExec FbInstance;

		// Token: 0x04007129 RID: 28969
		[Nullable(2)]
		protected new ITalkOptionQteFailedDelayExec_SetValue PocoInterface;
	}
}
