using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D26 RID: 7462
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlotAudioConfig
	{
		// Token: 0x0600A025 RID: 40997 RVA: 0x0016D844 File Offset: 0x0016BA44
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

		// Token: 0x0600A026 RID: 40998 RVA: 0x0016D87C File Offset: 0x0016BA7C
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

		// Token: 0x0600A027 RID: 40999 RVA: 0x0016D88F File Offset: 0x0016BA8F
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

		// Token: 0x0600A028 RID: 41000 RVA: 0x0016D8A2 File Offset: 0x0016BAA2
		public IPlotAudioConfig_SetValue ToSetValue()
		{
			return new IPlotAudioConfig_SetValue
			{
				VoiceFadeOutOnInterrupt = this.VoiceFadeOutOnInterrupt
			};
		}

		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x0600A029 RID: 41001 RVA: 0x0016D8B8 File Offset: 0x0016BAB8
		// (set) Token: 0x0600A02A RID: 41002 RVA: 0x0016D919 File Offset: 0x0016BB19
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

		// Token: 0x0400608F RID: 24719
		[Nullable(2)]
		protected IPlotAudioConfig FbInstance;

		// Token: 0x04006090 RID: 24720
		[Nullable(2)]
		protected IPlotAudioConfig_SetValue PocoInterface;

		// Token: 0x04006091 RID: 24721
		private IPlotVoiceFadeOutOnInterrupt _VoiceFadeOutOnInterruptCache;

		// Token: 0x04006092 RID: 24722
		private bool _VoiceFadeOutOnInterruptInited;
	}
}
