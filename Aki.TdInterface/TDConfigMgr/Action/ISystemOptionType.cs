using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200214C RID: 8524
	public class ISystemOptionType
	{
		// Token: 0x0600B4EE RID: 46318 RVA: 0x001952E4 File Offset: 0x001934E4
		private ISystemOptionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISystemOptionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISystemOptionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISystemOptionType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B4EF RID: 46319 RVA: 0x0019531C File Offset: 0x0019351C
		public static ISystemOptionType Create([Nullable(2)] ISystemOptionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISystemOptionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B4F0 RID: 46320 RVA: 0x0019532F File Offset: 0x0019352F
		public static ISystemOptionType CreateFromSetValue([Nullable(2)] ISystemOptionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISystemOptionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B4F1 RID: 46321 RVA: 0x00195342 File Offset: 0x00193542
		public ISystemOptionType_SetValue ToSetValue()
		{
			return new ISystemOptionType_SetValue
			{
				Type = this.Type,
				SystemOptions = this.SystemOptions,
				KeepPreTalkItem = this.KeepPreTalkItem
			};
		}

		// Token: 0x17003694 RID: 13972
		// (get) Token: 0x0600B4F2 RID: 46322 RVA: 0x0019536D File Offset: 0x0019356D
		// (set) Token: 0x0600B4F3 RID: 46323 RVA: 0x00195398 File Offset: 0x00193598
		public virtual ESystemOptionType Type
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

		// Token: 0x17003695 RID: 13973
		// (get) Token: 0x0600B4F4 RID: 46324 RVA: 0x001953A8 File Offset: 0x001935A8
		// (set) Token: 0x0600B4F5 RID: 46325 RVA: 0x0019543B File Offset: 0x0019363B
		public virtual List<ISystemOption> SystemOptions
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
					ISystemOptionType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003696 RID: 13974
		// (get) Token: 0x0600B4F6 RID: 46326 RVA: 0x00195450 File Offset: 0x00193650
		// (set) Token: 0x0600B4F7 RID: 46327 RVA: 0x0019548A File Offset: 0x0019368A
		public virtual bool? KeepPreTalkItem
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepPreTalkItem;
				}
				ISystemOptionType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006B05 RID: 27397
		[Nullable(2)]
		protected ISystemOptionType FbInstance;

		// Token: 0x04006B06 RID: 27398
		[Nullable(2)]
		protected ISystemOptionType_SetValue PocoInterface;

		// Token: 0x04006B07 RID: 27399
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x04006B08 RID: 27400
		private bool _SystemOptionsInited;
	}
}
