using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005809 RID: 22537
	public class IFollowShooterConfig_UnionUnion
	{
		// Token: 0x1700A31B RID: 41755
		// (get) Token: 0x0602474C RID: 149324 RVA: 0x00502835 File Offset: 0x00500A35
		// (set) Token: 0x0602474D RID: 149325 RVA: 0x0050283D File Offset: 0x00500A3D
		public IFollowShooterConfig_Union Type { get; set; }

		// Token: 0x1700A31C RID: 41756
		// (get) Token: 0x0602474E RID: 149326 RVA: 0x00502846 File Offset: 0x00500A46
		// (set) Token: 0x0602474F RID: 149327 RVA: 0x0050284E File Offset: 0x00500A4E
		public object Value { get; set; }

		// Token: 0x06024750 RID: 149328 RVA: 0x00502857 File Offset: 0x00500A57
		public IFollowShooterConfig_UnionUnion()
		{
			this.Type = IFollowShooterConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024751 RID: 149329 RVA: 0x0050286D File Offset: 0x00500A6D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024752 RID: 149330 RVA: 0x0050287F File Offset: 0x00500A7F
		public IFollowShooterConfigT AsIFollowShooterConfig()
		{
			return this.As<IFollowShooterConfigT>();
		}

		// Token: 0x06024753 RID: 149331 RVA: 0x00502887 File Offset: 0x00500A87
		public static IFollowShooterConfig_UnionUnion FromIFollowShooterConfig(IFollowShooterConfigT _ifollowshooterconfig)
		{
			return new IFollowShooterConfig_UnionUnion
			{
				Type = IFollowShooterConfig_Union.IFollowShooterConfig,
				Value = _ifollowshooterconfig
			};
		}

		// Token: 0x06024754 RID: 149332 RVA: 0x0050289C File Offset: 0x00500A9C
		public IFollowShooterJellyFishConfigT AsIFollowShooterJellyFishConfig()
		{
			return this.As<IFollowShooterJellyFishConfigT>();
		}

		// Token: 0x06024755 RID: 149333 RVA: 0x005028A4 File Offset: 0x00500AA4
		public static IFollowShooterConfig_UnionUnion FromIFollowShooterJellyFishConfig(IFollowShooterJellyFishConfigT _ifollowshooterjellyfishconfig)
		{
			return new IFollowShooterConfig_UnionUnion
			{
				Type = IFollowShooterConfig_Union.IFollowShooterJellyFishConfig,
				Value = _ifollowshooterjellyfishconfig
			};
		}

		// Token: 0x06024756 RID: 149334 RVA: 0x005028BC File Offset: 0x00500ABC
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
