using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F37 RID: 7991
	public class IPlotAudioConfig
	{
		// Token: 0x0600AA11 RID: 43537 RVA: 0x00181C68 File Offset: 0x0017FE68
		private IPlotAudioConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlotAudioConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlotAudioConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlotAudioConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA12 RID: 43538 RVA: 0x00181CA0 File Offset: 0x0017FEA0
		public static IPlotAudioConfig Create([Nullable(2)] IPlotAudioConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlotAudioConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA13 RID: 43539 RVA: 0x00181CB3 File Offset: 0x0017FEB3
		public static IPlotAudioConfig CreateFromSetValue([Nullable(2)] IPlotAudioConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlotAudioConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA14 RID: 43540 RVA: 0x00181CC6 File Offset: 0x0017FEC6
		public IPlotAudioConfig_SetValue ToSetValue()
		{
			return new IPlotAudioConfig_SetValue
			{
				VoiceFadeOutOnInterrupt = this.VoiceFadeOutOnInterrupt
			};
		}

		// Token: 0x17003444 RID: 13380
		// (get) Token: 0x0600AA15 RID: 43541 RVA: 0x00181CDC File Offset: 0x0017FEDC
		// (set) Token: 0x0600AA16 RID: 43542 RVA: 0x00181D3D File Offset: 0x0017FF3D
		[Nullable(2)]
		public virtual IPlotVoiceFadeOutOnInterrupt VoiceFadeOutOnInterrupt
		{
			[NullableContext(2)]
			get
			{
				if (this._VoiceFadeOutOnInterruptInited)
				{
					return this._VoiceFadeOutOnInterruptCache;
				}
				this._VoiceFadeOutOnInterruptInited = true;
				if (this.FbInstance != null)
				{
					this._VoiceFadeOutOnInterruptCache = IPlotVoiceFadeOutOnInterrupt.Create(this.FbInstance.VoiceFadeOutOnInterrupt);
				}
				else
				{
					IPlotAudioConfig_SetValue pocoInterface = this.PocoInterface;
					this._VoiceFadeOutOnInterruptCache = ((pocoInterface != null) ? pocoInterface.VoiceFadeOutOnInterrupt : null);
				}
				return this._VoiceFadeOutOnInterruptCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().VoiceFadeOutOnInterrupt = value;
				this._VoiceFadeOutOnInterruptInited = false;
			}
		}

		// Token: 0x0400660B RID: 26123
		[Nullable(2)]
		protected IPlotAudioConfig FbInstance;

		// Token: 0x0400660C RID: 26124
		[Nullable(2)]
		protected IPlotAudioConfig_SetValue PocoInterface;

		// Token: 0x0400660D RID: 26125
		private IPlotVoiceFadeOutOnInterrupt _VoiceFadeOutOnInterruptCache;

		// Token: 0x0400660E RID: 26126
		private bool _VoiceFadeOutOnInterruptInited;
	}
}
