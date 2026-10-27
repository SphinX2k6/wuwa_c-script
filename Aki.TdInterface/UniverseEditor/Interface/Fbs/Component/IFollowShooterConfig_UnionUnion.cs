using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052A1 RID: 21153
	public class IFollowShooterConfig_UnionUnion
	{
		// Token: 0x17009B1D RID: 39709
		// (get) Token: 0x060227B2 RID: 141234 RVA: 0x004C7CC5 File Offset: 0x004C5EC5
		// (set) Token: 0x060227B3 RID: 141235 RVA: 0x004C7CCD File Offset: 0x004C5ECD
		public IFollowShooterConfig_Union Type { get; set; }

		// Token: 0x17009B1E RID: 39710
		// (get) Token: 0x060227B4 RID: 141236 RVA: 0x004C7CD6 File Offset: 0x004C5ED6
		// (set) Token: 0x060227B5 RID: 141237 RVA: 0x004C7CDE File Offset: 0x004C5EDE
		public object Value { get; set; }

		// Token: 0x060227B6 RID: 141238 RVA: 0x004C7CE7 File Offset: 0x004C5EE7
		public IFollowShooterConfig_UnionUnion()
		{
			this.Type = IFollowShooterConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060227B7 RID: 141239 RVA: 0x004C7CFD File Offset: 0x004C5EFD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060227B8 RID: 141240 RVA: 0x004C7D0F File Offset: 0x004C5F0F
		public IFollowShooterConfigT AsIFollowShooterConfig()
		{
			return this.As<IFollowShooterConfigT>();
		}

		// Token: 0x060227B9 RID: 141241 RVA: 0x004C7D17 File Offset: 0x004C5F17
		public static IFollowShooterConfig_UnionUnion FromIFollowShooterConfig(IFollowShooterConfigT _ifollowshooterconfig)
		{
			return new IFollowShooterConfig_UnionUnion
			{
				Type = IFollowShooterConfig_Union.IFollowShooterConfig,
				Value = _ifollowshooterconfig
			};
		}

		// Token: 0x060227BA RID: 141242 RVA: 0x004C7D2C File Offset: 0x004C5F2C
		public IFollowShooterJellyFishConfigT AsIFollowShooterJellyFishConfig()
		{
			return this.As<IFollowShooterJellyFishConfigT>();
		}

		// Token: 0x060227BB RID: 141243 RVA: 0x004C7D34 File Offset: 0x004C5F34
		public static IFollowShooterConfig_UnionUnion FromIFollowShooterJellyFishConfig(IFollowShooterJellyFishConfigT _ifollowshooterjellyfishconfig)
		{
			return new IFollowShooterConfig_UnionUnion
			{
				Type = IFollowShooterConfig_Union.IFollowShooterJellyFishConfig,
				Value = _ifollowshooterjellyfishconfig
			};
		}

		// Token: 0x060227BC RID: 141244 RVA: 0x004C7D4C File Offset: 0x004C5F4C
		public static int Pack(FlatBufferBuilder builder, IFollowShooterConfig_UnionUnion _o)
		{
			IFollowShooterConfig_Union type = _o.Type;
			if (type == IFollowShooterConfig_Union.IFollowShooterConfig)
			{
				return IFollowShooterConfig.Pack(builder, _o.AsIFollowShooterConfig()).Value;
			}
			if (type != IFollowShooterConfig_Union.IFollowShooterJellyFishConfig)
			{
				return 0;
			}
			return IFollowShooterJellyFishConfig.Pack(builder, _o.AsIFollowShooterJellyFishConfig()).Value;
		}
	}
}
