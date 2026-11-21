using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020A0 RID: 8352
	public class ISignalBreakGameplay : IUiGame
	{
		// Token: 0x0600B164 RID: 45412 RVA: 0x0018EE78 File Offset: 0x0018D078
		private ISignalBreakGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISignalBreakGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISignalBreakGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISignalBreakGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x0600B165 RID: 45413 RVA: 0x0018EEB0 File Offset: 0x0018D0B0
		public static ISignalBreakGameplay Create([Nullable(2)] ISignalBreakGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISignalBreakGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B166 RID: 45414 RVA: 0x0018EEC3 File Offset: 0x0018D0C3
		public static ISignalBreakGameplay CreateFromSetValue([Nullable(2)] ISignalBreakGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISignalBreakGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B167 RID: 45415 RVA: 0x0018EED6 File Offset: 0x0018D0D6
		public new ISignalBreakGameplay_SetValue ToSetValue()
		{
			return new ISignalBreakGameplay_SetValue
			{
				Type = this.Type,
				SignalBreakId = this.SignalBreakId
			};
		}

		// Token: 0x170035D1 RID: 13777
		// (get) Token: 0x0600B168 RID: 45416 RVA: 0x0018EEF5 File Offset: 0x0018D0F5
		// (set) Token: 0x0600B169 RID: 45417 RVA: 0x0018EF20 File Offset: 0x0018D120
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170035D2 RID: 13778
		// (get) Token: 0x0600B16A RID: 45418 RVA: 0x0018EF2E File Offset: 0x0018D12E
		// (set) Token: 0x0600B16B RID: 45419 RVA: 0x0018EF59 File Offset: 0x0018D159
		public virtual string SignalBreakId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SignalBreakId;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SignalBreakId;
			}
			set
			{
				this.GetOrCreatePoco().SignalBreakId = value;
			}
		}

		// Token: 0x0400696E RID: 26990
		[Nullable(2)]
		protected new ISignalBreakGameplay FbInstance;

		// Token: 0x0400696F RID: 26991
		[Nullable(2)]
		protected new ISignalBreakGameplay_SetValue PocoInterface;
	}
}
