using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002139 RID: 8505
	[NullableContext(1)]
	[Nullable(0)]
	public class ReignsCallCard : ActionParams
	{
		// Token: 0x0600BB4C RID: 47948 RVA: 0x001B0938 File Offset: 0x001AEB38
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

		// Token: 0x0600BB4D RID: 47949 RVA: 0x001B0970 File Offset: 0x001AEB70
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

		// Token: 0x0600BB4E RID: 47950 RVA: 0x001B0983 File Offset: 0x001AEB83
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

		// Token: 0x0600BB4F RID: 47951 RVA: 0x001B0996 File Offset: 0x001AEB96
		public ReignsCallCard_SetValue ToSetValue()
		{
			return new ReignsCallCard_SetValue
			{
				CardId = this.CardId
			};
		}

		// Token: 0x1700392D RID: 14637
		// (get) Token: 0x0600BB50 RID: 47952 RVA: 0x001B09A9 File Offset: 0x001AEBA9
		// (set) Token: 0x0600BB51 RID: 47953 RVA: 0x001B09D4 File Offset: 0x001AEBD4
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

		// Token: 0x04007008 RID: 28680
		[Nullable(2)]
		protected new ReignsCallCard FbInstance;

		// Token: 0x04007009 RID: 28681
		[Nullable(2)]
		protected ReignsCallCard_SetValue PocoInterface;
	}
}
