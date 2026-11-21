using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B91 RID: 7057
	public class IEnterMovieModeDurationType
	{
		// Token: 0x060095EF RID: 38383 RVA: 0x0015D448 File Offset: 0x0015B648
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

		// Token: 0x060095F0 RID: 38384 RVA: 0x0015D480 File Offset: 0x0015B680
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

		// Token: 0x060095F1 RID: 38385 RVA: 0x0015D493 File Offset: 0x0015B693
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

		// Token: 0x060095F2 RID: 38386 RVA: 0x0015D4A6 File Offset: 0x0015B6A6
		public IEnterMovieModeDurationType_SetValue ToSetValue()
		{
			return new IEnterMovieModeDurationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FAA RID: 12202
		// (get) Token: 0x060095F3 RID: 38387 RVA: 0x0015D4B9 File Offset: 0x0015B6B9
		// (set) Token: 0x060095F4 RID: 38388 RVA: 0x0015D4E4 File Offset: 0x0015B6E4
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

		// Token: 0x04005CB9 RID: 23737
		[Nullable(2)]
		protected IEnterMovieModeDurationType FbInstance;

		// Token: 0x04005CBA RID: 23738
		[Nullable(2)]
		protected IEnterMovieModeDurationType_SetValue PocoInterface;
	}
}
