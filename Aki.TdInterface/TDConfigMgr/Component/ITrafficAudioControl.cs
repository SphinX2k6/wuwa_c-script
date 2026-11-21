using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000838 RID: 2104
	public class ITrafficAudioControl : IAudioControlType
	{
		// Token: 0x06002D40 RID: 11584 RVA: 0x00075D20 File Offset: 0x00073F20
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

		// Token: 0x06002D41 RID: 11585 RVA: 0x00075D58 File Offset: 0x00073F58
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

		// Token: 0x06002D42 RID: 11586 RVA: 0x00075D6B File Offset: 0x00073F6B
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

		// Token: 0x06002D43 RID: 11587 RVA: 0x00075D80 File Offset: 0x00073F80
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

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x00075DCE File Offset: 0x00073FCE
		// (set) Token: 0x06002D45 RID: 11589 RVA: 0x00075DF9 File Offset: 0x00073FF9
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

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06002D46 RID: 11590 RVA: 0x00075E07 File Offset: 0x00074007
		// (set) Token: 0x06002D47 RID: 11591 RVA: 0x00075E32 File Offset: 0x00074032
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

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06002D48 RID: 11592 RVA: 0x00075E40 File Offset: 0x00074040
		// (set) Token: 0x06002D49 RID: 11593 RVA: 0x00075E6B File Offset: 0x0007406B
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

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06002D4A RID: 11594 RVA: 0x00075E79 File Offset: 0x00074079
		// (set) Token: 0x06002D4B RID: 11595 RVA: 0x00075EA4 File Offset: 0x000740A4
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

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06002D4C RID: 11596 RVA: 0x00075EB2 File Offset: 0x000740B2
		// (set) Token: 0x06002D4D RID: 11597 RVA: 0x00075EDD File Offset: 0x000740DD
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

		// Token: 0x04001E33 RID: 7731
		[Nullable(2)]
		protected new ITrafficAudioControl FbInstance;

		// Token: 0x04001E34 RID: 7732
		[Nullable(2)]
		protected new ITrafficAudioControl_SetValue PocoInterface;
	}
}
