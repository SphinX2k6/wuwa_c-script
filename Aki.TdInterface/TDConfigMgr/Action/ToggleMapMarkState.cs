using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002248 RID: 8776
	[NullableContext(1)]
	[Nullable(0)]
	public class ToggleMapMarkState : ActionParams
	{
		// Token: 0x0600C096 RID: 49302 RVA: 0x001BA574 File Offset: 0x001B8774
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

		// Token: 0x0600C097 RID: 49303 RVA: 0x001BA5AC File Offset: 0x001B87AC
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

		// Token: 0x0600C098 RID: 49304 RVA: 0x001BA5BF File Offset: 0x001B87BF
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

		// Token: 0x0600C099 RID: 49305 RVA: 0x001BA5D2 File Offset: 0x001B87D2
		public ToggleMapMarkState_SetValue ToSetValue()
		{
			return new ToggleMapMarkState_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A4A RID: 14922
		// (get) Token: 0x0600C09A RID: 49306 RVA: 0x001BA5E5 File Offset: 0x001B87E5
		// (set) Token: 0x0600C09B RID: 49307 RVA: 0x001BA610 File Offset: 0x001B8810
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

		// Token: 0x040072CE RID: 29390
		[Nullable(2)]
		protected new ToggleMapMarkState FbInstance;

		// Token: 0x040072CF RID: 29391
		[Nullable(2)]
		protected ToggleMapMarkState_SetValue PocoInterface;
	}
}
