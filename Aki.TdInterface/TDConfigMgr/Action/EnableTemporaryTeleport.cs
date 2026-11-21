using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017B9 RID: 6073
	public class EnableTemporaryTeleport : ActionParams
	{
		// Token: 0x06008375 RID: 33653 RVA: 0x0013A80C File Offset: 0x00138A0C
		private EnableTemporaryTeleport_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableTemporaryTeleport 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableTemporaryTeleport_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableTemporaryTeleport_SetValue());
			}
			return result;
		}

		// Token: 0x06008376 RID: 33654 RVA: 0x0013A844 File Offset: 0x00138A44
		public static EnableTemporaryTeleport Create([Nullable(2)] EnableTemporaryTeleport instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableTemporaryTeleport
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008377 RID: 33655 RVA: 0x0013A857 File Offset: 0x00138A57
		public static EnableTemporaryTeleport CreateFromSetValue([Nullable(2)] EnableTemporaryTeleport_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableTemporaryTeleport
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008378 RID: 33656 RVA: 0x0013A86A File Offset: 0x00138A6A
		public EnableTemporaryTeleport_SetValue ToSetValue()
		{
			return new EnableTemporaryTeleport_SetValue
			{
				Enable = this.Enable,
				RangeEntity = this.RangeEntity
			};
		}

		// Token: 0x17002B17 RID: 11031
		// (get) Token: 0x06008379 RID: 33657 RVA: 0x0013A889 File Offset: 0x00138A89
		// (set) Token: 0x0600837A RID: 33658 RVA: 0x0013A8B4 File Offset: 0x00138AB4
		public virtual bool Enable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Enable;
				}
				return this.PocoInterface != null && this.PocoInterface.Enable;
			}
			set
			{
				this.GetOrCreatePoco().Enable = value;
			}
		}

		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x0600837B RID: 33659 RVA: 0x0013A8C2 File Offset: 0x00138AC2
		// (set) Token: 0x0600837C RID: 33660 RVA: 0x0013A8ED File Offset: 0x00138AED
		public virtual int RangeEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RangeEntity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RangeEntity;
			}
			set
			{
				this.GetOrCreatePoco().RangeEntity = value;
			}
		}

		// Token: 0x04005072 RID: 20594
		[Nullable(2)]
		protected new EnableTemporaryTeleport FbInstance;

		// Token: 0x04005073 RID: 20595
		[Nullable(2)]
		protected EnableTemporaryTeleport_SetValue PocoInterface;
	}
}
