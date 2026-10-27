using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003D8 RID: 984
	[NullableContext(1)]
	[Nullable(0)]
	public class IGramophoneAudioControl : IAudioControlType
	{
		// Token: 0x060013C7 RID: 5063 RVA: 0x0003FE64 File Offset: 0x0003E064
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

		// Token: 0x060013C8 RID: 5064 RVA: 0x0003FE9C File Offset: 0x0003E09C
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

		// Token: 0x060013C9 RID: 5065 RVA: 0x0003FEAF File Offset: 0x0003E0AF
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

		// Token: 0x060013CA RID: 5066 RVA: 0x0003FEC2 File Offset: 0x0003E0C2
		public new IGramophoneAudioControl_SetValue ToSetValue()
		{
			return new IGramophoneAudioControl_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x0003FED5 File Offset: 0x0003E0D5
		// (set) Token: 0x060013CC RID: 5068 RVA: 0x0003FF00 File Offset: 0x0003E100
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

		// Token: 0x04000FB2 RID: 4018
		[Nullable(2)]
		protected new IGramophoneAudioControl FbInstance;

		// Token: 0x04000FB3 RID: 4019
		[Nullable(2)]
		protected new IGramophoneAudioControl_SetValue PocoInterface;
	}
}
