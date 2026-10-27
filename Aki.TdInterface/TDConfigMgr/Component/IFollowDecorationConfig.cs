using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003A6 RID: 934
	[NullableContext(1)]
	[Nullable(0)]
	public class IFollowDecorationConfig
	{
		// Token: 0x060012A1 RID: 4769 RVA: 0x0003D51C File Offset: 0x0003B71C
		private IFollowDecorationConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFollowDecorationConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFollowDecorationConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFollowDecorationConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0003D554 File Offset: 0x0003B754
		public static IFollowDecorationConfig Create([Nullable(2)] IFollowDecorationConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowDecorationConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0003D567 File Offset: 0x0003B767
		public static IFollowDecorationConfig CreateFromSetValue([Nullable(2)] IFollowDecorationConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFollowDecorationConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x0003D57A File Offset: 0x0003B77A
		public IFollowDecorationConfig_SetValue ToSetValue()
		{
			return new IFollowDecorationConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x0003D58D File Offset: 0x0003B78D
		// (set) Token: 0x060012A6 RID: 4774 RVA: 0x0003D5B8 File Offset: 0x0003B7B8
		public virtual EFollowDecorationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFollowDecorationType.Chair;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000EF8 RID: 3832
		[Nullable(2)]
		protected IFollowDecorationConfig FbInstance;

		// Token: 0x04000EF9 RID: 3833
		[Nullable(2)]
		protected IFollowDecorationConfig_SetValue PocoInterface;
	}
}
