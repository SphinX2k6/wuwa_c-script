using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023F6 RID: 9206
	public class SeqEventAddTagToSelf : ActionParams
	{
		// Token: 0x0600C866 RID: 51302 RVA: 0x001CA37C File Offset: 0x001C857C
		private SeqEventAddTagToSelf_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SeqEventAddTagToSelf 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SeqEventAddTagToSelf_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SeqEventAddTagToSelf_SetValue());
			}
			return result;
		}

		// Token: 0x0600C867 RID: 51303 RVA: 0x001CA3B4 File Offset: 0x001C85B4
		public static SeqEventAddTagToSelf Create([Nullable(2)] SeqEventAddTagToSelf instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SeqEventAddTagToSelf
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C868 RID: 51304 RVA: 0x001CA3C7 File Offset: 0x001C85C7
		public static SeqEventAddTagToSelf CreateFromSetValue([Nullable(2)] SeqEventAddTagToSelf_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SeqEventAddTagToSelf
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C869 RID: 51305 RVA: 0x001CA3DA File Offset: 0x001C85DA
		public SeqEventAddTagToSelf_SetValue ToSetValue()
		{
			return new SeqEventAddTagToSelf_SetValue
			{
				Tags = this.Tags
			};
		}

		// Token: 0x17003C5A RID: 15450
		// (get) Token: 0x0600C86A RID: 51306 RVA: 0x001CA3ED File Offset: 0x001C85ED
		// (set) Token: 0x0600C86B RID: 51307 RVA: 0x001CA414 File Offset: 0x001C8614
		public virtual List<int> Tags
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Tags;
				}
				SeqEventAddTagToSelf_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Tags;
			}
			set
			{
				this.GetOrCreatePoco().Tags = value;
			}
		}

		// Token: 0x040076EB RID: 30443
		[Nullable(2)]
		protected new SeqEventAddTagToSelf FbInstance;

		// Token: 0x040076EC RID: 30444
		[Nullable(2)]
		protected SeqEventAddTagToSelf_SetValue PocoInterface;
	}
}
