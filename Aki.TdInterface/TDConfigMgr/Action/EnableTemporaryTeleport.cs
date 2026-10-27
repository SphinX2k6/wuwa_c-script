using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200164C RID: 5708
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableTemporaryTeleport : ActionParams
	{
		// Token: 0x06007C97 RID: 31895 RVA: 0x0012B760 File Offset: 0x00129960
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

		// Token: 0x06007C98 RID: 31896 RVA: 0x0012B798 File Offset: 0x00129998
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

		// Token: 0x06007C99 RID: 31897 RVA: 0x0012B7AB File Offset: 0x001299AB
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

		// Token: 0x06007C9A RID: 31898 RVA: 0x0012B7BE File Offset: 0x001299BE
		public EnableTemporaryTeleport_SetValue ToSetValue()
		{
			return new EnableTemporaryTeleport_SetValue
			{
				Enable = this.Enable,
				RangeEntity = this.RangeEntity
			};
		}

		// Token: 0x1700292C RID: 10540
		// (get) Token: 0x06007C9B RID: 31899 RVA: 0x0012B7DD File Offset: 0x001299DD
		// (set) Token: 0x06007C9C RID: 31900 RVA: 0x0012B808 File Offset: 0x00129A08
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

		// Token: 0x1700292D RID: 10541
		// (get) Token: 0x06007C9D RID: 31901 RVA: 0x0012B816 File Offset: 0x00129A16
		// (set) Token: 0x06007C9E RID: 31902 RVA: 0x0012B841 File Offset: 0x00129A41
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

		// Token: 0x04004C7E RID: 19582
		[Nullable(2)]
		protected new EnableTemporaryTeleport FbInstance;

		// Token: 0x04004C7F RID: 19583
		[Nullable(2)]
		protected EnableTemporaryTeleport_SetValue PocoInterface;
	}
}
