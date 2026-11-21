using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000459 RID: 1113
	public class IGroupFinishDestroy : IGroupFinishConfig
	{
		// Token: 0x06001641 RID: 5697 RVA: 0x00045930 File Offset: 0x00043B30
		private IGroupFinishDestroy_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupFinishDestroy 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupFinishDestroy_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupFinishDestroy_SetValue());
			}
			return result;
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00045968 File Offset: 0x00043B68
		public static IGroupFinishDestroy Create([Nullable(2)] IGroupFinishDestroy instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupFinishDestroy
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0004597B File Offset: 0x00043B7B
		public static IGroupFinishDestroy CreateFromSetValue([Nullable(2)] IGroupFinishDestroy_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupFinishDestroy
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0004598E File Offset: 0x00043B8E
		public new IGroupFinishDestroy_SetValue ToSetValue()
		{
			return new IGroupFinishDestroy_SetValue
			{
				Type = this.Type,
				SwitchSpecifiedStatus = this.SwitchSpecifiedStatus
			};
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x000459AD File Offset: 0x00043BAD
		// (set) Token: 0x06001646 RID: 5702 RVA: 0x000459D8 File Offset: 0x00043BD8
		public override EGroupFinishConfig Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGroupFinishConfig.Silence;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x000459E8 File Offset: 0x00043BE8
		// (set) Token: 0x06001648 RID: 5704 RVA: 0x00045A49 File Offset: 0x00043C49
		[Nullable(2)]
		public virtual IEntityState SwitchSpecifiedStatus
		{
			[NullableContext(2)]
			get
			{
				if (this._SwitchSpecifiedStatusInited)
				{
					return this._SwitchSpecifiedStatusCache;
				}
				this._SwitchSpecifiedStatusInited = true;
				if (this.FbInstance != null)
				{
					this._SwitchSpecifiedStatusCache = IEntityState.Create(this.FbInstance.SwitchSpecifiedStatus);
				}
				else
				{
					IGroupFinishDestroy_SetValue pocoInterface = this.PocoInterface;
					this._SwitchSpecifiedStatusCache = ((pocoInterface != null) ? pocoInterface.SwitchSpecifiedStatus : null);
				}
				return this._SwitchSpecifiedStatusCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SwitchSpecifiedStatus = value;
				this._SwitchSpecifiedStatusInited = false;
			}
		}

		// Token: 0x04001152 RID: 4434
		[Nullable(2)]
		protected new IGroupFinishDestroy FbInstance;

		// Token: 0x04001153 RID: 4435
		[Nullable(2)]
		protected new IGroupFinishDestroy_SetValue PocoInterface;

		// Token: 0x04001154 RID: 4436
		private IEntityState _SwitchSpecifiedStatusCache;

		// Token: 0x04001155 RID: 4437
		private bool _SwitchSpecifiedStatusInited;
	}
}
