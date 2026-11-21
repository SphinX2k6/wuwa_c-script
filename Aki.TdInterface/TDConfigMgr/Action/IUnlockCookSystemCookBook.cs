using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200226A RID: 8810
	public class IUnlockCookSystemCookBook : IUnlockCookSystemType
	{
		// Token: 0x0600BFFC RID: 49148 RVA: 0x001BAC30 File Offset: 0x001B8E30
		private IUnlockCookSystemCookBook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUnlockCookSystemCookBook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUnlockCookSystemCookBook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUnlockCookSystemCookBook_SetValue());
			}
			return result;
		}

		// Token: 0x0600BFFD RID: 49149 RVA: 0x001BAC68 File Offset: 0x001B8E68
		public static IUnlockCookSystemCookBook Create([Nullable(2)] IUnlockCookSystemCookBook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockCookSystemCookBook
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BFFE RID: 49150 RVA: 0x001BAC7B File Offset: 0x001B8E7B
		public static IUnlockCookSystemCookBook CreateFromSetValue([Nullable(2)] IUnlockCookSystemCookBook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUnlockCookSystemCookBook
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BFFF RID: 49151 RVA: 0x001BAC8E File Offset: 0x001B8E8E
		public new IUnlockCookSystemCookBook_SetValue ToSetValue()
		{
			return new IUnlockCookSystemCookBook_SetValue
			{
				Type = this.Type,
				CookBookId = this.CookBookId
			};
		}

		// Token: 0x17003A6F RID: 14959
		// (get) Token: 0x0600C000 RID: 49152 RVA: 0x001BACAD File Offset: 0x001B8EAD
		// (set) Token: 0x0600C001 RID: 49153 RVA: 0x001BACD8 File Offset: 0x001B8ED8
		public override EUnlockCookSystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUnlockCookSystemType.UnlockCookBook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003A70 RID: 14960
		// (get) Token: 0x0600C002 RID: 49154 RVA: 0x001BACE6 File Offset: 0x001B8EE6
		// (set) Token: 0x0600C003 RID: 49155 RVA: 0x001BAD11 File Offset: 0x001B8F11
		public virtual int CookBookId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CookBookId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CookBookId;
			}
			set
			{
				this.GetOrCreatePoco().CookBookId = value;
			}
		}

		// Token: 0x040072F4 RID: 29428
		[Nullable(2)]
		protected new IUnlockCookSystemCookBook FbInstance;

		// Token: 0x040072F5 RID: 29429
		[Nullable(2)]
		protected new IUnlockCookSystemCookBook_SetValue PocoInterface;
	}
}
