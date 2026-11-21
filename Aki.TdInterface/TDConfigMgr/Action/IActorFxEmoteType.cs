using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018F5 RID: 6389
	public class IActorFxEmoteType
	{
		// Token: 0x0600860F RID: 34319 RVA: 0x0013F368 File Offset: 0x0013D568
		private IActorFxEmoteType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorFxEmoteType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorFxEmoteType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorFxEmoteType_SetValue());
			}
			return result;
		}

		// Token: 0x06008610 RID: 34320 RVA: 0x0013F3A0 File Offset: 0x0013D5A0
		public static IActorFxEmoteType Create([Nullable(2)] IActorFxEmoteType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmoteType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008611 RID: 34321 RVA: 0x0013F3B3 File Offset: 0x0013D5B3
		public static IActorFxEmoteType CreateFromSetValue([Nullable(2)] IActorFxEmoteType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorFxEmoteType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008612 RID: 34322 RVA: 0x0013F3C6 File Offset: 0x0013D5C6
		public IActorFxEmoteType_SetValue ToSetValue()
		{
			return new IActorFxEmoteType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x06008613 RID: 34323 RVA: 0x0013F3D9 File Offset: 0x0013D5D9
		// (set) Token: 0x06008614 RID: 34324 RVA: 0x0013F404 File Offset: 0x0013D604
		public virtual EActorFxEmoteType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorFxEmoteType.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005511 RID: 21777
		[Nullable(2)]
		protected IActorFxEmoteType FbInstance;

		// Token: 0x04005512 RID: 21778
		[Nullable(2)]
		protected IActorFxEmoteType_SetValue PocoInterface;
	}
}
