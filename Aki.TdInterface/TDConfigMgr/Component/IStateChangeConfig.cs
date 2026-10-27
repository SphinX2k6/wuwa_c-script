using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200070B RID: 1803
	[NullableContext(2)]
	[Nullable(0)]
	public class IStateChangeConfig
	{
		// Token: 0x060026CD RID: 9933 RVA: 0x00067A10 File Offset: 0x00065C10
		[NullableContext(1)]
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

		// Token: 0x060026CE RID: 9934 RVA: 0x00067A48 File Offset: 0x00065C48
		[NullableContext(1)]
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

		// Token: 0x060026CF RID: 9935 RVA: 0x00067A5B File Offset: 0x00065C5B
		[NullableContext(1)]
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

		// Token: 0x060026D0 RID: 9936 RVA: 0x00067A6E File Offset: 0x00065C6E
		[NullableContext(1)]
		public IStateChangeConfig_SetValue ToSetValue()
		{
			return new IStateChangeConfig_SetValue
			{
				RefreshState = this.RefreshState,
				SubDestroyState = this.SubDestroyState
			};
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x00067A8D File Offset: 0x00065C8D
		// (set) Token: 0x060026D2 RID: 9938 RVA: 0x00067AB4 File Offset: 0x00065CB4
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

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x00067AC2 File Offset: 0x00065CC2
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x00067AE9 File Offset: 0x00065CE9
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

		// Token: 0x04001A44 RID: 6724
		protected IStateChangeConfig FbInstance;

		// Token: 0x04001A45 RID: 6725
		protected IStateChangeConfig_SetValue PocoInterface;
	}
}
