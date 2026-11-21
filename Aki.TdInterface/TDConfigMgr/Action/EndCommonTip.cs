using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017BB RID: 6075
	public class EndCommonTip : ActionParams
	{
		// Token: 0x0600837F RID: 33663 RVA: 0x0013A90C File Offset: 0x00138B0C
		private EndCommonTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EndCommonTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EndCommonTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EndCommonTip_SetValue());
			}
			return result;
		}

		// Token: 0x06008380 RID: 33664 RVA: 0x0013A944 File Offset: 0x00138B44
		public static EndCommonTip Create([Nullable(2)] EndCommonTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EndCommonTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008381 RID: 33665 RVA: 0x0013A957 File Offset: 0x00138B57
		public static EndCommonTip CreateFromSetValue([Nullable(2)] EndCommonTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EndCommonTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008382 RID: 33666 RVA: 0x0013A96A File Offset: 0x00138B6A
		public EndCommonTip_SetValue ToSetValue()
		{
			return new EndCommonTip_SetValue
			{
				Token = this.Token
			};
		}

		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x06008383 RID: 33667 RVA: 0x0013A97D File Offset: 0x00138B7D
		// (set) Token: 0x06008384 RID: 33668 RVA: 0x0013A9A8 File Offset: 0x00138BA8
		public virtual string Token
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Token;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Token;
			}
			set
			{
				this.GetOrCreatePoco().Token = value;
			}
		}

		// Token: 0x04005076 RID: 20598
		[Nullable(2)]
		protected new EndCommonTip FbInstance;

		// Token: 0x04005077 RID: 20599
		[Nullable(2)]
		protected EndCommonTip_SetValue PocoInterface;
	}
}
