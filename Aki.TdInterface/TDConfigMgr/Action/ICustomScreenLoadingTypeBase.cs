using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001950 RID: 6480
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomScreenLoadingTypeBase
	{
		// Token: 0x06008AD7 RID: 35543 RVA: 0x00146C4C File Offset: 0x00144E4C
		private ICustomScreenLoadingTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomScreenLoadingTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomScreenLoadingTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomScreenLoadingTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06008AD8 RID: 35544 RVA: 0x00146C84 File Offset: 0x00144E84
		public static ICustomScreenLoadingTypeBase Create([Nullable(2)] ICustomScreenLoadingTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenLoadingTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008AD9 RID: 35545 RVA: 0x00146C97 File Offset: 0x00144E97
		public static ICustomScreenLoadingTypeBase CreateFromSetValue([Nullable(2)] ICustomScreenLoadingTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomScreenLoadingTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008ADA RID: 35546 RVA: 0x00146CAA File Offset: 0x00144EAA
		public ICustomScreenLoadingTypeBase_SetValue ToSetValue()
		{
			return new ICustomScreenLoadingTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CC8 RID: 11464
		// (get) Token: 0x06008ADB RID: 35547 RVA: 0x00146CBD File Offset: 0x00144EBD
		// (set) Token: 0x06008ADC RID: 35548 RVA: 0x00146CE8 File Offset: 0x00144EE8
		public virtual ECustomScreenLoading Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECustomScreenLoading.Cyberpunk;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040056B5 RID: 22197
		[Nullable(2)]
		protected ICustomScreenLoadingTypeBase FbInstance;

		// Token: 0x040056B6 RID: 22198
		[Nullable(2)]
		protected ICustomScreenLoadingTypeBase_SetValue PocoInterface;
	}
}
