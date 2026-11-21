using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FDD RID: 8157
	public class IRogueRandomEventOption : ISystemOptionType
	{
		// Token: 0x0600AD47 RID: 44359 RVA: 0x0018735C File Offset: 0x0018555C
		private IRogueRandomEventOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRogueRandomEventOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRogueRandomEventOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRogueRandomEventOption_SetValue());
			}
			return result;
		}

		// Token: 0x0600AD48 RID: 44360 RVA: 0x00187394 File Offset: 0x00185594
		public static IRogueRandomEventOption Create([Nullable(2)] IRogueRandomEventOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRogueRandomEventOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AD49 RID: 44361 RVA: 0x001873A7 File Offset: 0x001855A7
		public static IRogueRandomEventOption CreateFromSetValue([Nullable(2)] IRogueRandomEventOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRogueRandomEventOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AD4A RID: 44362 RVA: 0x001873BA File Offset: 0x001855BA
		public new IRogueRandomEventOption_SetValue ToSetValue()
		{
			return new IRogueRandomEventOption_SetValue
			{
				Type = this.Type,
				SystemOptions = this.SystemOptions,
				KeepPreTalkItem = this.KeepPreTalkItem,
				EventId = this.EventId
			};
		}

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x0600AD4B RID: 44363 RVA: 0x001873F1 File Offset: 0x001855F1
		// (set) Token: 0x0600AD4C RID: 44364 RVA: 0x0018741C File Offset: 0x0018561C
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

		// Token: 0x170034E7 RID: 13543
		// (get) Token: 0x0600AD4D RID: 44365 RVA: 0x0018742C File Offset: 0x0018562C
		// (set) Token: 0x0600AD4E RID: 44366 RVA: 0x001874BF File Offset: 0x001856BF
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
					IRogueRandomEventOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x0600AD4F RID: 44367 RVA: 0x001874D4 File Offset: 0x001856D4
		// (set) Token: 0x0600AD50 RID: 44368 RVA: 0x0018750E File Offset: 0x0018570E
		public override bool? KeepPreTalkItem
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepPreTalkItem;
				}
				IRogueRandomEventOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x0600AD51 RID: 44369 RVA: 0x0018751C File Offset: 0x0018571C
		// (set) Token: 0x0600AD52 RID: 44370 RVA: 0x00187547 File Offset: 0x00185747
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

		// Token: 0x0400676F RID: 26479
		[Nullable(2)]
		protected new IRogueRandomEventOption FbInstance;

		// Token: 0x04006770 RID: 26480
		[Nullable(2)]
		protected new IRogueRandomEventOption_SetValue PocoInterface;

		// Token: 0x04006771 RID: 26481
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x04006772 RID: 26482
		private bool _SystemOptionsInited;
	}
}
