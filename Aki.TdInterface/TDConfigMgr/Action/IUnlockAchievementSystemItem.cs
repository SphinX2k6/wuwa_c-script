using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002266 RID: 8806
	public class IUnlockAchievementSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600BFE8 RID: 49128 RVA: 0x001BAA34 File Offset: 0x001B8C34
		private IUnlockAchievementSystemItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUnlockAchievementSystemItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUnlockAchievementSystemItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUnlockAchievementSystemItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600BFE9 RID: 49129 RVA: 0x001BAA6C File Offset: 0x001B8C6C
		public static IUnlockAchievementSystemItem Create([Nullable(2)] IUnlockAchievementSystemItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockAchievementSystemItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BFEA RID: 49130 RVA: 0x001BAA7F File Offset: 0x001B8C7F
		public static IUnlockAchievementSystemItem CreateFromSetValue([Nullable(2)] IUnlockAchievementSystemItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUnlockAchievementSystemItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BFEB RID: 49131 RVA: 0x001BAA92 File Offset: 0x001B8C92
		public new IUnlockAchievementSystemItem_SetValue ToSetValue()
		{
			return new IUnlockAchievementSystemItem_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17003A6B RID: 14955
		// (get) Token: 0x0600BFEC RID: 49132 RVA: 0x001BAAB1 File Offset: 0x001B8CB1
		// (set) Token: 0x0600BFED RID: 49133 RVA: 0x001BAADC File Offset: 0x001B8CDC
		public override EUnlockSystemItemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUnlockSystemItemType.CookSystem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003A6C RID: 14956
		// (get) Token: 0x0600BFEE RID: 49134 RVA: 0x001BAAEA File Offset: 0x001B8CEA
		// (set) Token: 0x0600BFEF RID: 49135 RVA: 0x001BAB15 File Offset: 0x001B8D15
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x040072EC RID: 29420
		[Nullable(2)]
		protected new IUnlockAchievementSystemItem FbInstance;

		// Token: 0x040072ED RID: 29421
		[Nullable(2)]
		protected new IUnlockAchievementSystemItem_SetValue PocoInterface;
	}
}
