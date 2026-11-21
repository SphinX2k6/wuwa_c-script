using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006A1 RID: 1697
	public class IPlayerAttachTarget : IAttachTarget
	{
		// Token: 0x060023E8 RID: 9192 RVA: 0x00062394 File Offset: 0x00060594
		private IPlayerAttachTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerAttachTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerAttachTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerAttachTarget_SetValue());
			}
			return result;
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x000623CC File Offset: 0x000605CC
		public static IPlayerAttachTarget Create([Nullable(2)] IPlayerAttachTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerAttachTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x000623DF File Offset: 0x000605DF
		public static IPlayerAttachTarget CreateFromSetValue([Nullable(2)] IPlayerAttachTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerAttachTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x000623F2 File Offset: 0x000605F2
		public new IPlayerAttachTarget_SetValue ToSetValue()
		{
			return new IPlayerAttachTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x00062405 File Offset: 0x00060605
		// (set) Token: 0x060023ED RID: 9197 RVA: 0x00062430 File Offset: 0x00060630
		public override EAttachType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAttachType.Actor;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040018FC RID: 6396
		[Nullable(2)]
		protected new IPlayerAttachTarget FbInstance;

		// Token: 0x040018FD RID: 6397
		[Nullable(2)]
		protected new IPlayerAttachTarget_SetValue PocoInterface;
	}
}
