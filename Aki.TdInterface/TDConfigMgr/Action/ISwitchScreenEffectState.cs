using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200213E RID: 8510
	public class ISwitchScreenEffectState : ISwitchEffectStateEffectBase
	{
		// Token: 0x0600B4A2 RID: 46242 RVA: 0x00194A70 File Offset: 0x00192C70
		private ISwitchScreenEffectState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwitchScreenEffectState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwitchScreenEffectState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwitchScreenEffectState_SetValue());
			}
			return result;
		}

		// Token: 0x0600B4A3 RID: 46243 RVA: 0x00194AA8 File Offset: 0x00192CA8
		public static ISwitchScreenEffectState Create([Nullable(2)] ISwitchScreenEffectState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchScreenEffectState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B4A4 RID: 46244 RVA: 0x00194ABB File Offset: 0x00192CBB
		public static ISwitchScreenEffectState CreateFromSetValue([Nullable(2)] ISwitchScreenEffectState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwitchScreenEffectState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B4A5 RID: 46245 RVA: 0x00194ACE File Offset: 0x00192CCE
		public new ISwitchScreenEffectState_SetValue ToSetValue()
		{
			return new ISwitchScreenEffectState_SetValue
			{
				Type = this.Type,
				Path = this.Path
			};
		}

		// Token: 0x17003683 RID: 13955
		// (get) Token: 0x0600B4A6 RID: 46246 RVA: 0x00194AED File Offset: 0x00192CED
		// (set) Token: 0x0600B4A7 RID: 46247 RVA: 0x00194B18 File Offset: 0x00192D18
		public override ESwitchEffectStateEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESwitchEffectStateEffectType.ScreenEffect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003684 RID: 13956
		// (get) Token: 0x0600B4A8 RID: 46248 RVA: 0x00194B26 File Offset: 0x00192D26
		// (set) Token: 0x0600B4A9 RID: 46249 RVA: 0x00194B51 File Offset: 0x00192D51
		public virtual string Path
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Path;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Path;
			}
			set
			{
				this.GetOrCreatePoco().Path = value;
			}
		}

		// Token: 0x04006AE4 RID: 27364
		[Nullable(2)]
		protected new ISwitchScreenEffectState FbInstance;

		// Token: 0x04006AE5 RID: 27365
		[Nullable(2)]
		protected new ISwitchScreenEffectState_SetValue PocoInterface;
	}
}
