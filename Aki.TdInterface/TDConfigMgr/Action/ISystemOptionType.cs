using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F13 RID: 7955
	[NullableContext(1)]
	[Nullable(0)]
	public class ISystemOptionType
	{
		// Token: 0x0600AA1C RID: 43548 RVA: 0x0017F2EC File Offset: 0x0017D4EC
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

		// Token: 0x0600AA1D RID: 43549 RVA: 0x0017F324 File Offset: 0x0017D524
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

		// Token: 0x0600AA1E RID: 43550 RVA: 0x0017F337 File Offset: 0x0017D537
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

		// Token: 0x0600AA1F RID: 43551 RVA: 0x0017F34A File Offset: 0x0017D54A
		public ISystemOptionType_SetValue ToSetValue()
		{
			return new ISystemOptionType_SetValue
			{
				Type = this.Type,
				SystemOptions = this.SystemOptions,
				KeepPreTalkItem = this.KeepPreTalkItem
			};
		}

		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x0600AA20 RID: 43552 RVA: 0x0017F375 File Offset: 0x0017D575
		// (set) Token: 0x0600AA21 RID: 43553 RVA: 0x0017F3A0 File Offset: 0x0017D5A0
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

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x0600AA22 RID: 43554 RVA: 0x0017F3B0 File Offset: 0x0017D5B0
		// (set) Token: 0x0600AA23 RID: 43555 RVA: 0x0017F443 File Offset: 0x0017D643
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

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x0600AA24 RID: 43556 RVA: 0x0017F458 File Offset: 0x0017D658
		// (set) Token: 0x0600AA25 RID: 43557 RVA: 0x0017F492 File Offset: 0x0017D692
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

		// Token: 0x04006516 RID: 25878
		[Nullable(2)]
		protected ISystemOptionType FbInstance;

		// Token: 0x04006517 RID: 25879
		[Nullable(2)]
		protected ISystemOptionType_SetValue PocoInterface;

		// Token: 0x04006518 RID: 25880
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x04006519 RID: 25881
		private bool _SystemOptionsInited;
	}
}
