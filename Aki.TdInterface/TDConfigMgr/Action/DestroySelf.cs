using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001567 RID: 5479
	[NullableContext(1)]
	[Nullable(0)]
	public class DestroySelf : ActionParams
	{
		// Token: 0x06007BBB RID: 31675 RVA: 0x00129F04 File Offset: 0x00128104
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

		// Token: 0x06007BBC RID: 31676 RVA: 0x00129F3C File Offset: 0x0012813C
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

		// Token: 0x06007BBD RID: 31677 RVA: 0x00129F4F File Offset: 0x0012814F
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

		// Token: 0x06007BBE RID: 31678 RVA: 0x00129F62 File Offset: 0x00128162
		public DestroySelf_SetValue ToSetValue()
		{
			return new DestroySelf_SetValue
			{
				DelayDestroy = this.DelayDestroy
			};
		}

		// Token: 0x170028FE RID: 10494
		// (get) Token: 0x06007BBF RID: 31679 RVA: 0x00129F78 File Offset: 0x00128178
		// (set) Token: 0x06007BC0 RID: 31680 RVA: 0x00129FB2 File Offset: 0x001281B2
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

		// Token: 0x0400473B RID: 18235
		[Nullable(2)]
		protected new DestroySelf FbInstance;

		// Token: 0x0400473C RID: 18236
		[Nullable(2)]
		protected DestroySelf_SetValue PocoInterface;
	}
}
