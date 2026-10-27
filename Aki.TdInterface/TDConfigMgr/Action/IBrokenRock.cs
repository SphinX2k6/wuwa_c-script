using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001818 RID: 6168
	[NullableContext(1)]
	[Nullable(0)]
	public class IBrokenRock : IUiGame
	{
		// Token: 0x06008461 RID: 33889 RVA: 0x0013B66C File Offset: 0x0013986C
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

		// Token: 0x06008462 RID: 33890 RVA: 0x0013B6A4 File Offset: 0x001398A4
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

		// Token: 0x06008463 RID: 33891 RVA: 0x0013B6B7 File Offset: 0x001398B7
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

		// Token: 0x06008464 RID: 33892 RVA: 0x0013B6CA File Offset: 0x001398CA
		public new IBrokenRock_SetValue ToSetValue()
		{
			return new IBrokenRock_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002B61 RID: 11105
		// (get) Token: 0x06008465 RID: 33893 RVA: 0x0013B6E9 File Offset: 0x001398E9
		// (set) Token: 0x06008466 RID: 33894 RVA: 0x0013B714 File Offset: 0x00139914
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

		// Token: 0x17002B62 RID: 11106
		// (get) Token: 0x06008467 RID: 33895 RVA: 0x0013B722 File Offset: 0x00139922
		// (set) Token: 0x06008468 RID: 33896 RVA: 0x0013B74D File Offset: 0x0013994D
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

		// Token: 0x040053CA RID: 21450
		[Nullable(2)]
		protected new IBrokenRock FbInstance;

		// Token: 0x040053CB RID: 21451
		[Nullable(2)]
		protected new IBrokenRock_SetValue PocoInterface;
	}
}
