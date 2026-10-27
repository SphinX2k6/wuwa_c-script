using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AD9 RID: 6873
	[NullableContext(1)]
	[Nullable(0)]
	public class IGravityControlOption : ISystemOptionType
	{
		// Token: 0x0600934C RID: 37708 RVA: 0x00155E68 File Offset: 0x00154068
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

		// Token: 0x0600934D RID: 37709 RVA: 0x00155EA0 File Offset: 0x001540A0
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

		// Token: 0x0600934E RID: 37710 RVA: 0x00155EB3 File Offset: 0x001540B3
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

		// Token: 0x0600934F RID: 37711 RVA: 0x00155EC6 File Offset: 0x001540C6
		public new IGravityControlOption_SetValue ToSetValue()
		{
			return new IGravityControlOption_SetValue
			{
				Type = this.Type,
				SystemOptions = this.SystemOptions,
				KeepPreTalkItem = this.KeepPreTalkItem
			};
		}

		// Token: 0x17002EB6 RID: 11958
		// (get) Token: 0x06009350 RID: 37712 RVA: 0x00155EF1 File Offset: 0x001540F1
		// (set) Token: 0x06009351 RID: 37713 RVA: 0x00155F1C File Offset: 0x0015411C
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

		// Token: 0x17002EB7 RID: 11959
		// (get) Token: 0x06009352 RID: 37714 RVA: 0x00155F2C File Offset: 0x0015412C
		// (set) Token: 0x06009353 RID: 37715 RVA: 0x00155FBF File Offset: 0x001541BF
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

		// Token: 0x17002EB8 RID: 11960
		// (get) Token: 0x06009354 RID: 37716 RVA: 0x00155FD4 File Offset: 0x001541D4
		// (set) Token: 0x06009355 RID: 37717 RVA: 0x0015600E File Offset: 0x0015420E
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

		// Token: 0x04005A8B RID: 23179
		[Nullable(2)]
		protected new IGravityControlOption FbInstance;

		// Token: 0x04005A8C RID: 23180
		[Nullable(2)]
		protected new IGravityControlOption_SetValue PocoInterface;

		// Token: 0x04005A8D RID: 23181
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x04005A8E RID: 23182
		private bool _SystemOptionsInited;
	}
}
