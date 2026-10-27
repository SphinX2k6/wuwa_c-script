using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200218D RID: 8589
	[NullableContext(1)]
	[Nullable(0)]
	public class SeqEventAddTagToSelf : ActionParams
	{
		// Token: 0x0600BCB6 RID: 48310 RVA: 0x001B2E84 File Offset: 0x001B1084
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

		// Token: 0x0600BCB7 RID: 48311 RVA: 0x001B2EBC File Offset: 0x001B10BC
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

		// Token: 0x0600BCB8 RID: 48312 RVA: 0x001B2ECF File Offset: 0x001B10CF
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

		// Token: 0x0600BCB9 RID: 48313 RVA: 0x001B2EE2 File Offset: 0x001B10E2
		public SeqEventAddTagToSelf_SetValue ToSetValue()
		{
			return new SeqEventAddTagToSelf_SetValue
			{
				Tags = this.Tags
			};
		}

		// Token: 0x17003968 RID: 14696
		// (get) Token: 0x0600BCBA RID: 48314 RVA: 0x001B2EF5 File Offset: 0x001B10F5
		// (set) Token: 0x0600BCBB RID: 48315 RVA: 0x001B2F1C File Offset: 0x001B111C
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

		// Token: 0x040070A9 RID: 28841
		[Nullable(2)]
		protected new SeqEventAddTagToSelf FbInstance;

		// Token: 0x040070AA RID: 28842
		[Nullable(2)]
		protected SeqEventAddTagToSelf_SetValue PocoInterface;
	}
}
