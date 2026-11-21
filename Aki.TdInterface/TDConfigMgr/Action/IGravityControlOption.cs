using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C80 RID: 7296
	public class IGravityControlOption : ISystemOptionType
	{
		// Token: 0x06009B0A RID: 39690 RVA: 0x00166688 File Offset: 0x00164888
		private IGravityControlOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGravityControlOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGravityControlOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGravityControlOption_SetValue());
			}
			return result;
		}

		// Token: 0x06009B0B RID: 39691 RVA: 0x001666C0 File Offset: 0x001648C0
		public static IGravityControlOption Create([Nullable(2)] IGravityControlOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGravityControlOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B0C RID: 39692 RVA: 0x001666D3 File Offset: 0x001648D3
		public static IGravityControlOption CreateFromSetValue([Nullable(2)] IGravityControlOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGravityControlOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B0D RID: 39693 RVA: 0x001666E6 File Offset: 0x001648E6
		public new IGravityControlOption_SetValue ToSetValue()
		{
			return new IGravityControlOption_SetValue
			{
				Type = this.Type,
				SystemOptions = this.SystemOptions,
				KeepPreTalkItem = this.KeepPreTalkItem
			};
		}

		// Token: 0x170030D2 RID: 12498
		// (get) Token: 0x06009B0E RID: 39694 RVA: 0x00166711 File Offset: 0x00164911
		// (set) Token: 0x06009B0F RID: 39695 RVA: 0x0016673C File Offset: 0x0016493C
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

		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x06009B10 RID: 39696 RVA: 0x0016674C File Offset: 0x0016494C
		// (set) Token: 0x06009B11 RID: 39697 RVA: 0x001667DF File Offset: 0x001649DF
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
					IGravityControlOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x06009B12 RID: 39698 RVA: 0x001667F4 File Offset: 0x001649F4
		// (set) Token: 0x06009B13 RID: 39699 RVA: 0x0016682E File Offset: 0x00164A2E
		public override bool? KeepPreTalkItem
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepPreTalkItem;
				}
				IGravityControlOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005F15 RID: 24341
		[Nullable(2)]
		protected new IGravityControlOption FbInstance;

		// Token: 0x04005F16 RID: 24342
		[Nullable(2)]
		protected new IGravityControlOption_SetValue PocoInterface;

		// Token: 0x04005F17 RID: 24343
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x04005F18 RID: 24344
		private bool _SystemOptionsInited;
	}
}
