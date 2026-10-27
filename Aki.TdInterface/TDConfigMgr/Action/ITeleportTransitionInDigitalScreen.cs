using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FA2 RID: 8098
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportTransitionInDigitalScreen : ITeleportTransitionType
	{
		// Token: 0x0600B206 RID: 45574 RVA: 0x0019F01C File Offset: 0x0019D21C
		private ITeleportTransitionInDigitalScreen_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportTransitionInDigitalScreen 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportTransitionInDigitalScreen_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportTransitionInDigitalScreen_SetValue());
			}
			return result;
		}

		// Token: 0x0600B207 RID: 45575 RVA: 0x0019F054 File Offset: 0x0019D254
		public static ITeleportTransitionInDigitalScreen Create([Nullable(2)] ITeleportTransitionInDigitalScreen instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionInDigitalScreen
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B208 RID: 45576 RVA: 0x0019F067 File Offset: 0x0019D267
		public static ITeleportTransitionInDigitalScreen CreateFromSetValue([Nullable(2)] ITeleportTransitionInDigitalScreen_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportTransitionInDigitalScreen
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B209 RID: 45577 RVA: 0x0019F07A File Offset: 0x0019D27A
		public new ITeleportTransitionInDigitalScreen_SetValue ToSetValue()
		{
			return new ITeleportTransitionInDigitalScreen_SetValue
			{
				Type = this.Type,
				ConfigId = this.ConfigId
			};
		}

		// Token: 0x170036E8 RID: 14056
		// (get) Token: 0x0600B20A RID: 45578 RVA: 0x0019F099 File Offset: 0x0019D299
		// (set) Token: 0x0600B20B RID: 45579 RVA: 0x0019F0C4 File Offset: 0x0019D2C4
		public override ETeleportTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170036E9 RID: 14057
		// (get) Token: 0x0600B20C RID: 45580 RVA: 0x0019F0D2 File Offset: 0x0019D2D2
		// (set) Token: 0x0600B20D RID: 45581 RVA: 0x0019F0FD File Offset: 0x0019D2FD
		public virtual int ConfigId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ConfigId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ConfigId;
			}
			set
			{
				this.GetOrCreatePoco().ConfigId = value;
			}
		}

		// Token: 0x04006B89 RID: 27529
		[Nullable(2)]
		protected new ITeleportTransitionInDigitalScreen FbInstance;

		// Token: 0x04006B8A RID: 27530
		[Nullable(2)]
		protected new ITeleportTransitionInDigitalScreen_SetValue PocoInterface;
	}
}
