using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001559 RID: 5465
	[NullableContext(1)]
	[Nullable(0)]
	public class Destroy : ActionParams
	{
		// Token: 0x06007B7F RID: 31615 RVA: 0x001298EC File Offset: 0x00127AEC
		private Destroy_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("Destroy 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			Destroy_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new Destroy_SetValue());
			}
			return result;
		}

		// Token: 0x06007B80 RID: 31616 RVA: 0x00129924 File Offset: 0x00127B24
		public static Destroy Create([Nullable(2)] Destroy instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Destroy
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007B81 RID: 31617 RVA: 0x00129937 File Offset: 0x00127B37
		public static Destroy CreateFromSetValue([Nullable(2)] Destroy_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new Destroy
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007B82 RID: 31618 RVA: 0x0012994A File Offset: 0x00127B4A
		public Destroy_SetValue ToSetValue()
		{
			return new Destroy_SetValue
			{
				DelayDestroy = this.DelayDestroy
			};
		}

		// Token: 0x170028F4 RID: 10484
		// (get) Token: 0x06007B83 RID: 31619 RVA: 0x00129960 File Offset: 0x00127B60
		// (set) Token: 0x06007B84 RID: 31620 RVA: 0x0012999A File Offset: 0x00127B9A
		public virtual bool? DelayDestroy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayDestroy;
				}
				Destroy_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04004721 RID: 18209
		[Nullable(2)]
		protected new Destroy FbInstance;

		// Token: 0x04004722 RID: 18210
		[Nullable(2)]
		protected Destroy_SetValue PocoInterface;
	}
}
