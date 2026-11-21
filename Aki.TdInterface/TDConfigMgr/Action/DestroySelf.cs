using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016C5 RID: 5829
	public class DestroySelf : ActionParams
	{
		// Token: 0x06008299 RID: 33433 RVA: 0x00138FB0 File Offset: 0x001371B0
		private DestroySelf_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DestroySelf 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DestroySelf_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DestroySelf_SetValue());
			}
			return result;
		}

		// Token: 0x0600829A RID: 33434 RVA: 0x00138FE8 File Offset: 0x001371E8
		public static DestroySelf Create([Nullable(2)] DestroySelf instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroySelf
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600829B RID: 33435 RVA: 0x00138FFB File Offset: 0x001371FB
		public static DestroySelf CreateFromSetValue([Nullable(2)] DestroySelf_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DestroySelf
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600829C RID: 33436 RVA: 0x0013900E File Offset: 0x0013720E
		public DestroySelf_SetValue ToSetValue()
		{
			return new DestroySelf_SetValue
			{
				DelayDestroy = this.DelayDestroy
			};
		}

		// Token: 0x17002AE9 RID: 10985
		// (get) Token: 0x0600829D RID: 33437 RVA: 0x00139024 File Offset: 0x00137224
		// (set) Token: 0x0600829E RID: 33438 RVA: 0x0013905E File Offset: 0x0013725E
		public virtual bool? DelayDestroy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayDestroy;
				}
				DestroySelf_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayDestroy;
			}
			set
			{
				this.GetOrCreatePoco().DelayDestroy = value;
			}
		}

		// Token: 0x04004ADB RID: 19163
		[Nullable(2)]
		protected new DestroySelf FbInstance;

		// Token: 0x04004ADC RID: 19164
		[Nullable(2)]
		protected DestroySelf_SetValue PocoInterface;
	}
}
