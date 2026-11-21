using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002316 RID: 8982
	public class IWriteLetter : IUiGame
	{
		// Token: 0x0600C3AC RID: 50092 RVA: 0x001C1608 File Offset: 0x001BF808
		private IWriteLetter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWriteLetter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWriteLetter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWriteLetter_SetValue());
			}
			return result;
		}

		// Token: 0x0600C3AD RID: 50093 RVA: 0x001C1640 File Offset: 0x001BF840
		public static IWriteLetter Create([Nullable(2)] IWriteLetter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWriteLetter
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C3AE RID: 50094 RVA: 0x001C1653 File Offset: 0x001BF853
		public static IWriteLetter CreateFromSetValue([Nullable(2)] IWriteLetter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWriteLetter
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C3AF RID: 50095 RVA: 0x001C1666 File Offset: 0x001BF866
		public new IWriteLetter_SetValue ToSetValue()
		{
			return new IWriteLetter_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17003B45 RID: 15173
		// (get) Token: 0x0600C3B0 RID: 50096 RVA: 0x001C1685 File Offset: 0x001BF885
		// (set) Token: 0x0600C3B1 RID: 50097 RVA: 0x001C16B0 File Offset: 0x001BF8B0
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003B46 RID: 15174
		// (get) Token: 0x0600C3B2 RID: 50098 RVA: 0x001C16BE File Offset: 0x001BF8BE
		// (set) Token: 0x0600C3B3 RID: 50099 RVA: 0x001C16E9 File Offset: 0x001BF8E9
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

		// Token: 0x0400749E RID: 29854
		[Nullable(2)]
		protected new IWriteLetter FbInstance;

		// Token: 0x0400749F RID: 29855
		[Nullable(2)]
		protected new IWriteLetter_SetValue PocoInterface;
	}
}
