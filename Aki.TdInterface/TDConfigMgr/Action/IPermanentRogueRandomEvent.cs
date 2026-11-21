using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EDF RID: 7903
	public class IPermanentRogueRandomEvent : ISystemOptionType
	{
		// Token: 0x0600A833 RID: 43059 RVA: 0x0017E494 File Offset: 0x0017C694
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

		// Token: 0x0600A834 RID: 43060 RVA: 0x0017E4CC File Offset: 0x0017C6CC
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

		// Token: 0x0600A835 RID: 43061 RVA: 0x0017E4DF File Offset: 0x0017C6DF
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

		// Token: 0x0600A836 RID: 43062 RVA: 0x0017E4F2 File Offset: 0x0017C6F2
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

		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x0600A837 RID: 43063 RVA: 0x0017E529 File Offset: 0x0017C729
		// (set) Token: 0x0600A838 RID: 43064 RVA: 0x0017E554 File Offset: 0x0017C754
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

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x0600A839 RID: 43065 RVA: 0x0017E564 File Offset: 0x0017C764
		// (set) Token: 0x0600A83A RID: 43066 RVA: 0x0017E5F7 File Offset: 0x0017C7F7
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

		// Token: 0x170033DB RID: 13275
		// (get) Token: 0x0600A83B RID: 43067 RVA: 0x0017E60C File Offset: 0x0017C80C
		// (set) Token: 0x0600A83C RID: 43068 RVA: 0x0017E646 File Offset: 0x0017C846
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

		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x0600A83D RID: 43069 RVA: 0x0017E654 File Offset: 0x0017C854
		// (set) Token: 0x0600A83E RID: 43070 RVA: 0x0017E67F File Offset: 0x0017C87F
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

		// Token: 0x04006526 RID: 25894
		[Nullable(2)]
		protected new IPermanentRogueRandomEvent FbInstance;

		// Token: 0x04006527 RID: 25895
		[Nullable(2)]
		protected new IPermanentRogueRandomEvent_SetValue PocoInterface;

		// Token: 0x04006528 RID: 25896
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x04006529 RID: 25897
		private bool _SystemOptionsInited;
	}
}
