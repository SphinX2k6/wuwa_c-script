using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019FE RID: 6654
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnterMovieModeDurationType
	{
		// Token: 0x06008E8D RID: 36493 RVA: 0x0014D5D8 File Offset: 0x0014B7D8
		private IEnterMovieModeDurationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnterMovieModeDurationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnterMovieModeDurationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnterMovieModeDurationType_SetValue());
			}
			return result;
		}

		// Token: 0x06008E8E RID: 36494 RVA: 0x0014D610 File Offset: 0x0014B810
		public static IEnterMovieModeDurationType Create([Nullable(2)] IEnterMovieModeDurationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterMovieModeDurationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E8F RID: 36495 RVA: 0x0014D623 File Offset: 0x0014B823
		public static IEnterMovieModeDurationType CreateFromSetValue([Nullable(2)] IEnterMovieModeDurationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnterMovieModeDurationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E90 RID: 36496 RVA: 0x0014D636 File Offset: 0x0014B836
		public IEnterMovieModeDurationType_SetValue ToSetValue()
		{
			return new IEnterMovieModeDurationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D9E RID: 11678
		// (get) Token: 0x06008E91 RID: 36497 RVA: 0x0014D649 File Offset: 0x0014B849
		// (set) Token: 0x06008E92 RID: 36498 RVA: 0x0014D674 File Offset: 0x0014B874
		public virtual EEnterMovieModeDurationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnterMovieModeDurationType.BorderAnimFinished;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005857 RID: 22615
		[Nullable(2)]
		protected IEnterMovieModeDurationType FbInstance;

		// Token: 0x04005858 RID: 22616
		[Nullable(2)]
		protected IEnterMovieModeDurationType_SetValue PocoInterface;
	}
}
