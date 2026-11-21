using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B4F RID: 31567
	public class ITeammateTeleportConfig_UnionUnion
	{
		// Token: 0x1700EC62 RID: 60514
		// (get) Token: 0x06038D8B RID: 232843 RVA: 0x007AFABD File Offset: 0x007ADCBD
		// (set) Token: 0x06038D8C RID: 232844 RVA: 0x007AFAC5 File Offset: 0x007ADCC5
		public ITeammateTeleportConfig_Union Type { get; set; }

		// Token: 0x1700EC63 RID: 60515
		// (get) Token: 0x06038D8D RID: 232845 RVA: 0x007AFACE File Offset: 0x007ADCCE
		// (set) Token: 0x06038D8E RID: 232846 RVA: 0x007AFAD6 File Offset: 0x007ADCD6
		public object Value { get; set; }

		// Token: 0x06038D8F RID: 232847 RVA: 0x007AFADF File Offset: 0x007ADCDF
		public ITeammateTeleportConfig_UnionUnion()
		{
			this.Type = ITeammateTeleportConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06038D90 RID: 232848 RVA: 0x007AFAF5 File Offset: 0x007ADCF5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06038D91 RID: 232849 RVA: 0x007AFB07 File Offset: 0x007ADD07
		public ITeammateTeleportConfigT AsITeammateTeleportConfig()
		{
			return this.As<ITeammateTeleportConfigT>();
		}

		// Token: 0x06038D92 RID: 232850 RVA: 0x007AFB0F File Offset: 0x007ADD0F
		public static ITeammateTeleportConfig_UnionUnion FromITeammateTeleportConfig(ITeammateTeleportConfigT _iteammateteleportconfig)
		{
			return new ITeammateTeleportConfig_UnionUnion
			{
				Type = ITeammateTeleportConfig_Union.ITeammateTeleportConfig,
				Value = _iteammateteleportconfig
			};
		}

		// Token: 0x06038D93 RID: 232851 RVA: 0x007AFB24 File Offset: 0x007ADD24
		public ITelePortAfterTimeOutT AsITelePortAfterTimeOut()
		{
			return this.As<ITelePortAfterTimeOutT>();
		}

		// Token: 0x06038D94 RID: 232852 RVA: 0x007AFB2C File Offset: 0x007ADD2C
		public static ITeammateTeleportConfig_UnionUnion FromITelePortAfterTimeOut(ITelePortAfterTimeOutT _iteleportaftertimeout)
		{
			return new ITeammateTeleportConfig_UnionUnion
			{
				Type = ITeammateTeleportConfig_Union.ITelePortAfterTimeOut,
				Value = _iteleportaftertimeout
			};
		}

		// Token: 0x06038D95 RID: 232853 RVA: 0x007AFB44 File Offset: 0x007ADD44
		public static int Pack(FlatBufferBuilder builder, ITeammateTeleportConfig_UnionUnion _o)
		{
			ITeammateTeleportConfig_Union type = _o.Type;
			if (type == ITeammateTeleportConfig_Union.ITeammateTeleportConfig)
			{
				return ITeammateTeleportConfig.Pack(builder, _o.AsITeammateTeleportConfig()).Value;
			}
			if (type != ITeammateTeleportConfig_Union.ITelePortAfterTimeOut)
			{
				return 0;
			}
			return ITelePortAfterTimeOut.Pack(builder, _o.AsITelePortAfterTimeOut()).Value;
		}
	}
}
