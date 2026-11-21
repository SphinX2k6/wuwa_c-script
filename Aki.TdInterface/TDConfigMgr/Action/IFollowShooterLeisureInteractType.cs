using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C50 RID: 7248
	public class IFollowShooterLeisureInteractType
	{
		// Token: 0x06009A24 RID: 39460 RVA: 0x00164E80 File Offset: 0x00163080
		private IFollowShooterLeisureInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFollowShooterLeisureInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFollowShooterLeisureInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFollowShooterLeisureInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x06009A25 RID: 39461 RVA: 0x00164EB8 File Offset: 0x001630B8
		public static IFollowShooterLeisureInteractType Create([Nullable(2)] IFollowShooterLeisureInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowShooterLeisureInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A26 RID: 39462 RVA: 0x00164ECB File Offset: 0x001630CB
		public static IFollowShooterLeisureInteractType CreateFromSetValue([Nullable(2)] IFollowShooterLeisureInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFollowShooterLeisureInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A27 RID: 39463 RVA: 0x00164EDE File Offset: 0x001630DE
		public IFollowShooterLeisureInteractType_SetValue ToSetValue()
		{
			return new IFollowShooterLeisureInteractType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x06009A28 RID: 39464 RVA: 0x00164EF1 File Offset: 0x001630F1
		// (set) Token: 0x06009A29 RID: 39465 RVA: 0x00164F1C File Offset: 0x0016311C
		public virtual EFollowShooterLeisureInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFollowShooterLeisureInteractType.ResetToPlayer;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005EB2 RID: 24242
		[Nullable(2)]
		protected IFollowShooterLeisureInteractType FbInstance;

		// Token: 0x04005EB3 RID: 24243
		[Nullable(2)]
		protected IFollowShooterLeisureInteractType_SetValue PocoInterface;
	}
}
