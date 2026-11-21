using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200104E RID: 4174
	public class IDarkTideBossEvent
	{
		// Token: 0x06005C0A RID: 23562 RVA: 0x000E0290 File Offset: 0x000DE490
		private IDarkTideBossEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDarkTideBossEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDarkTideBossEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDarkTideBossEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06005C0B RID: 23563 RVA: 0x000E02C8 File Offset: 0x000DE4C8
		public static IDarkTideBossEvent Create([Nullable(2)] IDarkTideBossEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideBossEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x000E02DB File Offset: 0x000DE4DB
		public static IDarkTideBossEvent CreateFromSetValue([Nullable(2)] IDarkTideBossEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDarkTideBossEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C0D RID: 23565 RVA: 0x000E02EE File Offset: 0x000DE4EE
		public IDarkTideBossEvent_SetValue ToSetValue()
		{
			return new IDarkTideBossEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x06005C0E RID: 23566 RVA: 0x000E0301 File Offset: 0x000DE501
		// (set) Token: 0x06005C0F RID: 23567 RVA: 0x000E032C File Offset: 0x000DE52C
		public virtual EDarkTideBossEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDarkTideBossEventType.XinjilemuChase;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003782 RID: 14210
		[Nullable(2)]
		protected IDarkTideBossEvent FbInstance;

		// Token: 0x04003783 RID: 14211
		[Nullable(2)]
		protected IDarkTideBossEvent_SetValue PocoInterface;
	}
}
