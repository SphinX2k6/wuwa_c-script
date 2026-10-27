using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021FD RID: 8701
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffUnlockProgress : ActionParams
	{
		// Token: 0x0600BF0F RID: 48911 RVA: 0x001B770C File Offset: 0x001B590C
		private SheriffUnlockProgress_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SheriffUnlockProgress 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SheriffUnlockProgress_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SheriffUnlockProgress_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF10 RID: 48912 RVA: 0x001B7744 File Offset: 0x001B5944
		public static SheriffUnlockProgress Create([Nullable(2)] SheriffUnlockProgress instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SheriffUnlockProgress
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF11 RID: 48913 RVA: 0x001B7757 File Offset: 0x001B5957
		public static SheriffUnlockProgress CreateFromSetValue([Nullable(2)] SheriffUnlockProgress_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SheriffUnlockProgress
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF12 RID: 48914 RVA: 0x001B776A File Offset: 0x001B596A
		public SheriffUnlockProgress_SetValue ToSetValue()
		{
			return new SheriffUnlockProgress_SetValue
			{
				ProgressId = this.ProgressId
			};
		}

		// Token: 0x170039EE RID: 14830
		// (get) Token: 0x0600BF13 RID: 48915 RVA: 0x001B777D File Offset: 0x001B597D
		// (set) Token: 0x0600BF14 RID: 48916 RVA: 0x001B77A8 File Offset: 0x001B59A8
		public virtual int ProgressId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProgressId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ProgressId;
			}
			set
			{
				this.GetOrCreatePoco().ProgressId = value;
			}
		}

		// Token: 0x040071E9 RID: 29161
		[Nullable(2)]
		protected new SheriffUnlockProgress FbInstance;

		// Token: 0x040071EA RID: 29162
		[Nullable(2)]
		protected SheriffUnlockProgress_SetValue PocoInterface;
	}
}
