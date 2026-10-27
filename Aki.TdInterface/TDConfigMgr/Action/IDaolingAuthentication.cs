using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001964 RID: 6500
	[NullableContext(1)]
	[Nullable(0)]
	public class IDaolingAuthentication : IUiGame
	{
		// Token: 0x06008B41 RID: 35649 RVA: 0x001478C4 File Offset: 0x00145AC4
		private IDaolingAuthentication_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDaolingAuthentication 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDaolingAuthentication_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDaolingAuthentication_SetValue());
			}
			return result;
		}

		// Token: 0x06008B42 RID: 35650 RVA: 0x001478FC File Offset: 0x00145AFC
		public static IDaolingAuthentication Create([Nullable(2)] IDaolingAuthentication instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDaolingAuthentication
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B43 RID: 35651 RVA: 0x0014790F File Offset: 0x00145B0F
		public static IDaolingAuthentication CreateFromSetValue([Nullable(2)] IDaolingAuthentication_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDaolingAuthentication
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B44 RID: 35652 RVA: 0x00147922 File Offset: 0x00145B22
		public new IDaolingAuthentication_SetValue ToSetValue()
		{
			return new IDaolingAuthentication_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CDF RID: 11487
		// (get) Token: 0x06008B45 RID: 35653 RVA: 0x00147935 File Offset: 0x00145B35
		// (set) Token: 0x06008B46 RID: 35654 RVA: 0x00147960 File Offset: 0x00145B60
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

		// Token: 0x040056EA RID: 22250
		[Nullable(2)]
		protected new IDaolingAuthentication FbInstance;

		// Token: 0x040056EB RID: 22251
		[Nullable(2)]
		protected new IDaolingAuthentication_SetValue PocoInterface;
	}
}
