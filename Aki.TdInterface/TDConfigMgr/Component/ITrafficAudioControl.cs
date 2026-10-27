using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000797 RID: 1943
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrafficAudioControl : IAudioControlType
	{
		// Token: 0x06002A18 RID: 10776 RVA: 0x0006EA78 File Offset: 0x0006CC78
		private ITrafficAudioControl_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrafficAudioControl 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrafficAudioControl_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrafficAudioControl_SetValue());
			}
			return result;
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x0006EAB0 File Offset: 0x0006CCB0
		public static ITrafficAudioControl Create([Nullable(2)] ITrafficAudioControl instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrafficAudioControl
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x0006EAC3 File Offset: 0x0006CCC3
		public static ITrafficAudioControl CreateFromSetValue([Nullable(2)] ITrafficAudioControl_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrafficAudioControl
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x0006EAD8 File Offset: 0x0006CCD8
		public new ITrafficAudioControl_SetValue ToSetValue()
		{
			return new ITrafficAudioControl_SetValue
			{
				Type = this.Type,
				EngineAudio = this.EngineAudio,
				BrakingAudio = this.BrakingAudio,
				BrakingShortAudio = this.BrakingShortAudio,
				HornAudio = this.HornAudio
			};
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002A1C RID: 10780 RVA: 0x0006EB26 File Offset: 0x0006CD26
		// (set) Token: 0x06002A1D RID: 10781 RVA: 0x0006EB51 File Offset: 0x0006CD51
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

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002A1E RID: 10782 RVA: 0x0006EB5F File Offset: 0x0006CD5F
		// (set) Token: 0x06002A1F RID: 10783 RVA: 0x0006EB8A File Offset: 0x0006CD8A
		public virtual string EngineAudio
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EngineAudio;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EngineAudio;
			}
			set
			{
				this.GetOrCreatePoco().EngineAudio = value;
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002A20 RID: 10784 RVA: 0x0006EB98 File Offset: 0x0006CD98
		// (set) Token: 0x06002A21 RID: 10785 RVA: 0x0006EBC3 File Offset: 0x0006CDC3
		public virtual string BrakingAudio
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BrakingAudio;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.BrakingAudio;
			}
			set
			{
				this.GetOrCreatePoco().BrakingAudio = value;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002A22 RID: 10786 RVA: 0x0006EBD1 File Offset: 0x0006CDD1
		// (set) Token: 0x06002A23 RID: 10787 RVA: 0x0006EBFC File Offset: 0x0006CDFC
		public virtual string BrakingShortAudio
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BrakingShortAudio;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.BrakingShortAudio;
			}
			set
			{
				this.GetOrCreatePoco().BrakingShortAudio = value;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x0006EC0A File Offset: 0x0006CE0A
		// (set) Token: 0x06002A25 RID: 10789 RVA: 0x0006EC35 File Offset: 0x0006CE35
		public virtual string HornAudio
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HornAudio;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.HornAudio;
			}
			set
			{
				this.GetOrCreatePoco().HornAudio = value;
			}
		}

		// Token: 0x04001C2A RID: 7210
		[Nullable(2)]
		protected new ITrafficAudioControl FbInstance;

		// Token: 0x04001C2B RID: 7211
		[Nullable(2)]
		protected new ITrafficAudioControl_SetValue PocoInterface;
	}
}
