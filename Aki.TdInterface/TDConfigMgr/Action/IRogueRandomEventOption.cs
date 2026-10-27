using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DC6 RID: 7622
	[NullableContext(1)]
	[Nullable(0)]
	public class IRogueRandomEventOption : ISystemOptionType
	{
		// Token: 0x0600A33D RID: 41789 RVA: 0x00172C34 File Offset: 0x00170E34
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

		// Token: 0x0600A33E RID: 41790 RVA: 0x00172C6C File Offset: 0x00170E6C
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

		// Token: 0x0600A33F RID: 41791 RVA: 0x00172C7F File Offset: 0x00170E7F
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

		// Token: 0x0600A340 RID: 41792 RVA: 0x00172C92 File Offset: 0x00170E92
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

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x0600A341 RID: 41793 RVA: 0x00172CC9 File Offset: 0x00170EC9
		// (set) Token: 0x0600A342 RID: 41794 RVA: 0x00172CF4 File Offset: 0x00170EF4
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

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x0600A343 RID: 41795 RVA: 0x00172D04 File Offset: 0x00170F04
		// (set) Token: 0x0600A344 RID: 41796 RVA: 0x00172D97 File Offset: 0x00170F97
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

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x0600A345 RID: 41797 RVA: 0x00172DAC File Offset: 0x00170FAC
		// (set) Token: 0x0600A346 RID: 41798 RVA: 0x00172DE6 File Offset: 0x00170FE6
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

		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0600A347 RID: 41799 RVA: 0x00172DF4 File Offset: 0x00170FF4
		// (set) Token: 0x0600A348 RID: 41800 RVA: 0x00172E1F File Offset: 0x0017101F
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

		// Token: 0x040061E7 RID: 25063
		[Nullable(2)]
		protected new IRogueRandomEventOption FbInstance;

		// Token: 0x040061E8 RID: 25064
		[Nullable(2)]
		protected new IRogueRandomEventOption_SetValue PocoInterface;

		// Token: 0x040061E9 RID: 25065
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x040061EA RID: 25066
		private bool _SystemOptionsInited;
	}
}
