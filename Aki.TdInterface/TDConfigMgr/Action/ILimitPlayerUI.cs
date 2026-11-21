using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D45 RID: 7493
	public class ILimitPlayerUI : ILimitPlayerOption
	{
		// Token: 0x06009F1D RID: 40733 RVA: 0x0016D9B4 File Offset: 0x0016BBB4
		private ILimitPlayerUI_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILimitPlayerUI 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILimitPlayerUI_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILimitPlayerUI_SetValue());
			}
			return result;
		}

		// Token: 0x06009F1E RID: 40734 RVA: 0x0016D9EC File Offset: 0x0016BBEC
		public static ILimitPlayerUI Create([Nullable(2)] ILimitPlayerUI instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerUI
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F1F RID: 40735 RVA: 0x0016D9FF File Offset: 0x0016BBFF
		public static ILimitPlayerUI CreateFromSetValue([Nullable(2)] ILimitPlayerUI_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILimitPlayerUI
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F20 RID: 40736 RVA: 0x0016DA12 File Offset: 0x0016BC12
		public new ILimitPlayerUI_SetValue ToSetValue()
		{
			return new ILimitPlayerUI_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031B5 RID: 12725
		// (get) Token: 0x06009F21 RID: 40737 RVA: 0x0016DA25 File Offset: 0x0016BC25
		// (set) Token: 0x06009F22 RID: 40738 RVA: 0x0016DA50 File Offset: 0x0016BC50
		public override ELimitPlayOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040060EC RID: 24812
		[Nullable(2)]
		protected new ILimitPlayerUI FbInstance;

		// Token: 0x040060ED RID: 24813
		[Nullable(2)]
		protected new ILimitPlayerUI_SetValue PocoInterface;
	}
}
