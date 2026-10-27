using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001976 RID: 6518
	[NullableContext(1)]
	[Nullable(0)]
	public class IDeadeyeFadeOutConfig
	{
		// Token: 0x06008BA1 RID: 35745 RVA: 0x001482A8 File Offset: 0x001464A8
		private IDeadeyeFadeOutConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDeadeyeFadeOutConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDeadeyeFadeOutConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDeadeyeFadeOutConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008BA2 RID: 35746 RVA: 0x001482E0 File Offset: 0x001464E0
		public static IDeadeyeFadeOutConfig Create([Nullable(2)] IDeadeyeFadeOutConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadeyeFadeOutConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008BA3 RID: 35747 RVA: 0x001482F3 File Offset: 0x001464F3
		public static IDeadeyeFadeOutConfig CreateFromSetValue([Nullable(2)] IDeadeyeFadeOutConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDeadeyeFadeOutConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008BA4 RID: 35748 RVA: 0x00148306 File Offset: 0x00146506
		public IDeadeyeFadeOutConfig_SetValue ToSetValue()
		{
			return new IDeadeyeFadeOutConfig_SetValue
			{
				TransitionTime = this.TransitionTime
			};
		}

		// Token: 0x17002CF4 RID: 11508
		// (get) Token: 0x06008BA5 RID: 35749 RVA: 0x00148319 File Offset: 0x00146519
		// (set) Token: 0x06008BA6 RID: 35750 RVA: 0x00148348 File Offset: 0x00146548
		public virtual float TransitionTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TransitionTime;
			}
			set
			{
				this.GetOrCreatePoco().TransitionTime = value;
			}
		}

		// Token: 0x04005711 RID: 22289
		[Nullable(2)]
		protected IDeadeyeFadeOutConfig FbInstance;

		// Token: 0x04005712 RID: 22290
		[Nullable(2)]
		protected IDeadeyeFadeOutConfig_SetValue PocoInterface;
	}
}
