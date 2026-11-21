using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024B3 RID: 9395
	public class ToggleMapMarkState : ActionParams
	{
		// Token: 0x0600CC54 RID: 52308 RVA: 0x001D1C40 File Offset: 0x001CFE40
		private ToggleMapMarkState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ToggleMapMarkState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ToggleMapMarkState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ToggleMapMarkState_SetValue());
			}
			return result;
		}

		// Token: 0x0600CC55 RID: 52309 RVA: 0x001D1C78 File Offset: 0x001CFE78
		public static ToggleMapMarkState Create([Nullable(2)] ToggleMapMarkState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleMapMarkState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CC56 RID: 52310 RVA: 0x001D1C8B File Offset: 0x001CFE8B
		public static ToggleMapMarkState CreateFromSetValue([Nullable(2)] ToggleMapMarkState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ToggleMapMarkState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CC57 RID: 52311 RVA: 0x001D1C9E File Offset: 0x001CFE9E
		public ToggleMapMarkState_SetValue ToSetValue()
		{
			return new ToggleMapMarkState_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003D40 RID: 15680
		// (get) Token: 0x0600CC58 RID: 52312 RVA: 0x001D1CB1 File Offset: 0x001CFEB1
		// (set) Token: 0x0600CC59 RID: 52313 RVA: 0x001D1CDC File Offset: 0x001CFEDC
		public virtual EMapMarkState Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMapMarkState.Show;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007918 RID: 31000
		[Nullable(2)]
		protected new ToggleMapMarkState FbInstance;

		// Token: 0x04007919 RID: 31001
		[Nullable(2)]
		protected ToggleMapMarkState_SetValue PocoInterface;
	}
}
