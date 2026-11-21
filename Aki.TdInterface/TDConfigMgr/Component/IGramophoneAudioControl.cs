using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000431 RID: 1073
	public class IGramophoneAudioControl : IAudioControlType
	{
		// Token: 0x06001561 RID: 5473 RVA: 0x00043BAC File Offset: 0x00041DAC
		private IGramophoneAudioControl_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGramophoneAudioControl 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGramophoneAudioControl_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGramophoneAudioControl_SetValue());
			}
			return result;
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00043BE4 File Offset: 0x00041DE4
		public static IGramophoneAudioControl Create([Nullable(2)] IGramophoneAudioControl instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGramophoneAudioControl
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00043BF7 File Offset: 0x00041DF7
		public static IGramophoneAudioControl CreateFromSetValue([Nullable(2)] IGramophoneAudioControl_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGramophoneAudioControl
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00043C0A File Offset: 0x00041E0A
		public new IGramophoneAudioControl_SetValue ToSetValue()
		{
			return new IGramophoneAudioControl_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x00043C1D File Offset: 0x00041E1D
		// (set) Token: 0x06001566 RID: 5478 RVA: 0x00043C48 File Offset: 0x00041E48
		public override EAudioControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAudioControlType.Gramophone;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040010D4 RID: 4308
		[Nullable(2)]
		protected new IGramophoneAudioControl FbInstance;

		// Token: 0x040010D5 RID: 4309
		[Nullable(2)]
		protected new IGramophoneAudioControl_SetValue PocoInterface;
	}
}
