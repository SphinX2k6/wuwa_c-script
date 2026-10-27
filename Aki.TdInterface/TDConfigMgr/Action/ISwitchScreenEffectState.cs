using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F05 RID: 7941
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchScreenEffectState : ISwitchEffectStateEffectBase
	{
		// Token: 0x0600A9D0 RID: 43472 RVA: 0x0017EA78 File Offset: 0x0017CC78
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

		// Token: 0x0600A9D1 RID: 43473 RVA: 0x0017EAB0 File Offset: 0x0017CCB0
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

		// Token: 0x0600A9D2 RID: 43474 RVA: 0x0017EAC3 File Offset: 0x0017CCC3
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

		// Token: 0x0600A9D3 RID: 43475 RVA: 0x0017EAD6 File Offset: 0x0017CCD6
		public new ISwitchScreenEffectState_SetValue ToSetValue()
		{
			return new ISwitchScreenEffectState_SetValue
			{
				Type = this.Type,
				Path = this.Path
			};
		}

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x0600A9D4 RID: 43476 RVA: 0x0017EAF5 File Offset: 0x0017CCF5
		// (set) Token: 0x0600A9D5 RID: 43477 RVA: 0x0017EB20 File Offset: 0x0017CD20
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

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x0600A9D6 RID: 43478 RVA: 0x0017EB2E File Offset: 0x0017CD2E
		// (set) Token: 0x0600A9D7 RID: 43479 RVA: 0x0017EB59 File Offset: 0x0017CD59
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

		// Token: 0x040064F5 RID: 25845
		[Nullable(2)]
		protected new ISwitchScreenEffectState FbInstance;

		// Token: 0x040064F6 RID: 25846
		[Nullable(2)]
		protected new ISwitchScreenEffectState_SetValue PocoInterface;
	}
}
