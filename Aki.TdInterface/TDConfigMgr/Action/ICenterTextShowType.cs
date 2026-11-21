using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019E9 RID: 6633
	public class ICenterTextShowType
	{
		// Token: 0x06008D31 RID: 36145 RVA: 0x0014E25C File Offset: 0x0014C45C
		private ICenterTextShowType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICenterTextShowType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICenterTextShowType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICenterTextShowType_SetValue());
			}
			return result;
		}

		// Token: 0x06008D32 RID: 36146 RVA: 0x0014E294 File Offset: 0x0014C494
		public static ICenterTextShowType Create([Nullable(2)] ICenterTextShowType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICenterTextShowType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D33 RID: 36147 RVA: 0x0014E2A7 File Offset: 0x0014C4A7
		public static ICenterTextShowType CreateFromSetValue([Nullable(2)] ICenterTextShowType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICenterTextShowType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D34 RID: 36148 RVA: 0x0014E2BA File Offset: 0x0014C4BA
		public ICenterTextShowType_SetValue ToSetValue()
		{
			return new ICenterTextShowType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DC7 RID: 11719
		// (get) Token: 0x06008D35 RID: 36149 RVA: 0x0014E2CD File Offset: 0x0014C4CD
		// (set) Token: 0x06008D36 RID: 36150 RVA: 0x0014E2F8 File Offset: 0x0014C4F8
		public virtual ECenterTextShowAnim Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECenterTextShowAnim.ShowAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040058EA RID: 22762
		[Nullable(2)]
		protected ICenterTextShowType FbInstance;

		// Token: 0x040058EB RID: 22763
		[Nullable(2)]
		protected ICenterTextShowType_SetValue PocoInterface;
	}
}
