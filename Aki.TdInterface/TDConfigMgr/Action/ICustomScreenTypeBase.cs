using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001956 RID: 6486
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomScreenTypeBase
	{
		// Token: 0x06008AF5 RID: 35573 RVA: 0x00146F48 File Offset: 0x00145148
		private ICustomScreenTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomScreenTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomScreenTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomScreenTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06008AF6 RID: 35574 RVA: 0x00146F80 File Offset: 0x00145180
		public static ICustomScreenTypeBase Create([Nullable(2)] ICustomScreenTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008AF7 RID: 35575 RVA: 0x00146F93 File Offset: 0x00145193
		public static ICustomScreenTypeBase CreateFromSetValue([Nullable(2)] ICustomScreenTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomScreenTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008AF8 RID: 35576 RVA: 0x00146FA6 File Offset: 0x001451A6
		public ICustomScreenTypeBase_SetValue ToSetValue()
		{
			return new ICustomScreenTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CCE RID: 11470
		// (get) Token: 0x06008AF9 RID: 35577 RVA: 0x00146FB9 File Offset: 0x001451B9
		// (set) Token: 0x06008AFA RID: 35578 RVA: 0x00146FE4 File Offset: 0x001451E4
		public virtual ECustomScreenType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECustomScreenType.Spine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040056C1 RID: 22209
		[Nullable(2)]
		protected ICustomScreenTypeBase FbInstance;

		// Token: 0x040056C2 RID: 22210
		[Nullable(2)]
		protected ICustomScreenTypeBase_SetValue PocoInterface;
	}
}
