using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200239A RID: 9114
	public class ReignsCallCard : ActionParams
	{
		// Token: 0x0600C6DA RID: 50906 RVA: 0x001C7AEC File Offset: 0x001C5CEC
		private ReignsCallCard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ReignsCallCard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ReignsCallCard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ReignsCallCard_SetValue());
			}
			return result;
		}

		// Token: 0x0600C6DB RID: 50907 RVA: 0x001C7B24 File Offset: 0x001C5D24
		public static ReignsCallCard Create([Nullable(2)] ReignsCallCard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsCallCard
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C6DC RID: 50908 RVA: 0x001C7B37 File Offset: 0x001C5D37
		public static ReignsCallCard CreateFromSetValue([Nullable(2)] ReignsCallCard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ReignsCallCard
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C6DD RID: 50909 RVA: 0x001C7B4A File Offset: 0x001C5D4A
		public ReignsCallCard_SetValue ToSetValue()
		{
			return new ReignsCallCard_SetValue
			{
				CardId = this.CardId
			};
		}

		// Token: 0x17003C1A RID: 15386
		// (get) Token: 0x0600C6DE RID: 50910 RVA: 0x001C7B5D File Offset: 0x001C5D5D
		// (set) Token: 0x0600C6DF RID: 50911 RVA: 0x001C7B88 File Offset: 0x001C5D88
		public virtual int CardId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CardId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CardId;
			}
			set
			{
				this.GetOrCreatePoco().CardId = value;
			}
		}

		// Token: 0x0400763D RID: 30269
		[Nullable(2)]
		protected new ReignsCallCard FbInstance;

		// Token: 0x0400763E RID: 30270
		[Nullable(2)]
		protected ReignsCallCard_SetValue PocoInterface;
	}
}
