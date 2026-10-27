using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CD8 RID: 7384
	[NullableContext(1)]
	[Nullable(0)]
	public class IPermanentRogueRandomEvent : ISystemOptionType
	{
		// Token: 0x06009E85 RID: 40581 RVA: 0x0016A834 File Offset: 0x00168A34
		private IPermanentRogueRandomEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPermanentRogueRandomEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPermanentRogueRandomEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPermanentRogueRandomEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06009E86 RID: 40582 RVA: 0x0016A86C File Offset: 0x00168A6C
		public static IPermanentRogueRandomEvent Create([Nullable(2)] IPermanentRogueRandomEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPermanentRogueRandomEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E87 RID: 40583 RVA: 0x0016A87F File Offset: 0x00168A7F
		public static IPermanentRogueRandomEvent CreateFromSetValue([Nullable(2)] IPermanentRogueRandomEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPermanentRogueRandomEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E88 RID: 40584 RVA: 0x0016A892 File Offset: 0x00168A92
		public new IPermanentRogueRandomEvent_SetValue ToSetValue()
		{
			return new IPermanentRogueRandomEvent_SetValue
			{
				Type = this.Type,
				SystemOptions = this.SystemOptions,
				KeepPreTalkItem = this.KeepPreTalkItem,
				EventId = this.EventId
			};
		}

		// Token: 0x17003155 RID: 12629
		// (get) Token: 0x06009E89 RID: 40585 RVA: 0x0016A8C9 File Offset: 0x00168AC9
		// (set) Token: 0x06009E8A RID: 40586 RVA: 0x0016A8F4 File Offset: 0x00168AF4
		public override ESystemOptionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESystemOptionType.RogueRandomEvent;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003156 RID: 12630
		// (get) Token: 0x06009E8B RID: 40587 RVA: 0x0016A904 File Offset: 0x00168B04
		// (set) Token: 0x06009E8C RID: 40588 RVA: 0x0016A997 File Offset: 0x00168B97
		public override List<ISystemOption> SystemOptions
		{
			get
			{
				if (this._SystemOptionsInited)
				{
					return this._SystemOptionsCache;
				}
				this._SystemOptionsInited = true;
				if (this.FbInstance != null)
				{
					List<ISystemOption> systemOptions = this.FbInstance.SystemOptions;
					if (systemOptions != null)
					{
						this._SystemOptionsCache = new List<ISystemOption>(systemOptions.Count);
						for (int i = 0; i < systemOptions.Count; i++)
						{
							this._SystemOptionsCache.Add(ISystemOption.Create(systemOptions[i]));
						}
					}
				}
				else
				{
					IPermanentRogueRandomEvent_SetValue pocoInterface = this.PocoInterface;
					this._SystemOptionsCache = ((pocoInterface != null) ? pocoInterface.SystemOptions : null);
				}
				return this._SystemOptionsCache;
			}
			set
			{
				this.GetOrCreatePoco().SystemOptions = value;
				this._SystemOptionsInited = false;
			}
		}

		// Token: 0x17003157 RID: 12631
		// (get) Token: 0x06009E8D RID: 40589 RVA: 0x0016A9AC File Offset: 0x00168BAC
		// (set) Token: 0x06009E8E RID: 40590 RVA: 0x0016A9E6 File Offset: 0x00168BE6
		public override bool? KeepPreTalkItem
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepPreTalkItem;
				}
				IPermanentRogueRandomEvent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepPreTalkItem;
			}
			set
			{
				this.GetOrCreatePoco().KeepPreTalkItem = value;
			}
		}

		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x06009E8F RID: 40591 RVA: 0x0016A9F4 File Offset: 0x00168BF4
		// (set) Token: 0x06009E90 RID: 40592 RVA: 0x0016AA1F File Offset: 0x00168C1F
		public virtual int EventId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EventId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EventId;
			}
			set
			{
				this.GetOrCreatePoco().EventId = value;
			}
		}

		// Token: 0x04005FCA RID: 24522
		[Nullable(2)]
		protected new IPermanentRogueRandomEvent FbInstance;

		// Token: 0x04005FCB RID: 24523
		[Nullable(2)]
		protected new IPermanentRogueRandomEvent_SetValue PocoInterface;

		// Token: 0x04005FCC RID: 24524
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x04005FCD RID: 24525
		private bool _SystemOptionsInited;
	}
}
