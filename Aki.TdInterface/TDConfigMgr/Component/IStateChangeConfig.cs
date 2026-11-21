using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007AC RID: 1964
	[NullableContext(2)]
	[Nullable(0)]
	public class IStateChangeConfig
	{
		// Token: 0x060029ED RID: 10733 RVA: 0x0006EA80 File Offset: 0x0006CC80
		[NullableContext(0)]
		private IStateChangeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateChangeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateChangeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateChangeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x0006EAB8 File Offset: 0x0006CCB8
		[NullableContext(0)]
		public static IStateChangeConfig Create([Nullable(2)] IStateChangeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateChangeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x0006EACB File Offset: 0x0006CCCB
		[NullableContext(0)]
		public static IStateChangeConfig CreateFromSetValue([Nullable(2)] IStateChangeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateChangeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x0006EADE File Offset: 0x0006CCDE
		[NullableContext(0)]
		public IStateChangeConfig_SetValue ToSetValue()
		{
			return new IStateChangeConfig_SetValue
			{
				RefreshState = this.RefreshState,
				SubDestroyState = this.SubDestroyState
			};
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x060029F1 RID: 10737 RVA: 0x0006EAFD File Offset: 0x0006CCFD
		// (set) Token: 0x060029F2 RID: 10738 RVA: 0x0006EB24 File Offset: 0x0006CD24
		public virtual string RefreshState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RefreshState;
				}
				IStateChangeConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RefreshState;
			}
			set
			{
				this.GetOrCreatePoco().RefreshState = value;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x0006EB32 File Offset: 0x0006CD32
		// (set) Token: 0x060029F4 RID: 10740 RVA: 0x0006EB59 File Offset: 0x0006CD59
		public virtual string SubDestroyState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SubDestroyState;
				}
				IStateChangeConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SubDestroyState;
			}
			set
			{
				this.GetOrCreatePoco().SubDestroyState = value;
			}
		}

		// Token: 0x04001C43 RID: 7235
		protected IStateChangeConfig FbInstance;

		// Token: 0x04001C44 RID: 7236
		protected IStateChangeConfig_SetValue PocoInterface;
	}
}
