using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F13 RID: 7955
	public class IPlayerHandInHandInitiator : IHandInHandInitiatorType
	{
		// Token: 0x0600A951 RID: 43345 RVA: 0x0018067C File Offset: 0x0017E87C
		private IPlayerHandInHandInitiator_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerHandInHandInitiator 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerHandInHandInitiator_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerHandInHandInitiator_SetValue());
			}
			return result;
		}

		// Token: 0x0600A952 RID: 43346 RVA: 0x001806B4 File Offset: 0x0017E8B4
		public static IPlayerHandInHandInitiator Create([Nullable(2)] IPlayerHandInHandInitiator instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerHandInHandInitiator
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A953 RID: 43347 RVA: 0x001806C7 File Offset: 0x0017E8C7
		public static IPlayerHandInHandInitiator CreateFromSetValue([Nullable(2)] IPlayerHandInHandInitiator_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerHandInHandInitiator
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A954 RID: 43348 RVA: 0x001806DA File Offset: 0x0017E8DA
		public new IPlayerHandInHandInitiator_SetValue ToSetValue()
		{
			return new IPlayerHandInHandInitiator_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700341A RID: 13338
		// (get) Token: 0x0600A955 RID: 43349 RVA: 0x001806ED File Offset: 0x0017E8ED
		// (set) Token: 0x0600A956 RID: 43350 RVA: 0x00180718 File Offset: 0x0017E918
		public override EHandInHandInitiatorType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHandInHandInitiatorType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040065B1 RID: 26033
		[Nullable(2)]
		protected new IPlayerHandInHandInitiator FbInstance;

		// Token: 0x040065B2 RID: 26034
		[Nullable(2)]
		protected new IPlayerHandInHandInitiator_SetValue PocoInterface;
	}
}
