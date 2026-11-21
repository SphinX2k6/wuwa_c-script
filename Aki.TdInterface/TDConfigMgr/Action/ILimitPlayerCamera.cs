using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D3B RID: 7483
	public class ILimitPlayerCamera : ILimitPlayerOption
	{
		// Token: 0x06009EEB RID: 40683 RVA: 0x0016D494 File Offset: 0x0016B694
		private ILimitPlayerCamera_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILimitPlayerCamera 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILimitPlayerCamera_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILimitPlayerCamera_SetValue());
			}
			return result;
		}

		// Token: 0x06009EEC RID: 40684 RVA: 0x0016D4CC File Offset: 0x0016B6CC
		public static ILimitPlayerCamera Create([Nullable(2)] ILimitPlayerCamera instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerCamera
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009EED RID: 40685 RVA: 0x0016D4DF File Offset: 0x0016B6DF
		public static ILimitPlayerCamera CreateFromSetValue([Nullable(2)] ILimitPlayerCamera_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILimitPlayerCamera
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009EEE RID: 40686 RVA: 0x0016D4F2 File Offset: 0x0016B6F2
		public new ILimitPlayerCamera_SetValue ToSetValue()
		{
			return new ILimitPlayerCamera_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x06009EEF RID: 40687 RVA: 0x0016D505 File Offset: 0x0016B705
		// (set) Token: 0x06009EF0 RID: 40688 RVA: 0x0016D530 File Offset: 0x0016B730
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

		// Token: 0x040060D8 RID: 24792
		[Nullable(2)]
		protected new ILimitPlayerCamera FbInstance;

		// Token: 0x040060D9 RID: 24793
		[Nullable(2)]
		protected new ILimitPlayerCamera_SetValue PocoInterface;
	}
}
