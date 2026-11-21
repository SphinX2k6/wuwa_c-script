using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019A3 RID: 6563
	public class IBrokenRock : IUiGame
	{
		// Token: 0x06008B87 RID: 35719 RVA: 0x0014AE60 File Offset: 0x00149060
		private IBrokenRock_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBrokenRock 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBrokenRock_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBrokenRock_SetValue());
			}
			return result;
		}

		// Token: 0x06008B88 RID: 35720 RVA: 0x0014AE98 File Offset: 0x00149098
		public static IBrokenRock Create([Nullable(2)] IBrokenRock instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBrokenRock
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B89 RID: 35721 RVA: 0x0014AEAB File Offset: 0x001490AB
		public static IBrokenRock CreateFromSetValue([Nullable(2)] IBrokenRock_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBrokenRock
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B8A RID: 35722 RVA: 0x0014AEBE File Offset: 0x001490BE
		public new IBrokenRock_SetValue ToSetValue()
		{
			return new IBrokenRock_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002D5B RID: 11611
		// (get) Token: 0x06008B8B RID: 35723 RVA: 0x0014AEDD File Offset: 0x001490DD
		// (set) Token: 0x06008B8C RID: 35724 RVA: 0x0014AF08 File Offset: 0x00149108
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

		// Token: 0x17002D5C RID: 11612
		// (get) Token: 0x06008B8D RID: 35725 RVA: 0x0014AF16 File Offset: 0x00149116
		// (set) Token: 0x06008B8E RID: 35726 RVA: 0x0014AF41 File Offset: 0x00149141
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

		// Token: 0x04005816 RID: 22550
		[Nullable(2)]
		protected new IBrokenRock FbInstance;

		// Token: 0x04005817 RID: 22551
		[Nullable(2)]
		protected new IBrokenRock_SetValue PocoInterface;
	}
}
