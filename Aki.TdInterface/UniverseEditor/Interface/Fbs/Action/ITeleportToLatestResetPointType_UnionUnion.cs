using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B7C RID: 31612
	public class ITeleportToLatestResetPointType_UnionUnion
	{
		// Token: 0x1700ECA8 RID: 60584
		// (get) Token: 0x06038EDE RID: 233182 RVA: 0x007B2005 File Offset: 0x007B0205
		// (set) Token: 0x06038EDF RID: 233183 RVA: 0x007B200D File Offset: 0x007B020D
		public ITeleportToLatestResetPointType_Union Type { get; set; }

		// Token: 0x1700ECA9 RID: 60585
		// (get) Token: 0x06038EE0 RID: 233184 RVA: 0x007B2016 File Offset: 0x007B0216
		// (set) Token: 0x06038EE1 RID: 233185 RVA: 0x007B201E File Offset: 0x007B021E
		public object Value { get; set; }

		// Token: 0x06038EE2 RID: 233186 RVA: 0x007B2027 File Offset: 0x007B0227
		public ITeleportToLatestResetPointType_UnionUnion()
		{
			this.Type = ITeleportToLatestResetPointType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06038EE3 RID: 233187 RVA: 0x007B203D File Offset: 0x007B023D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06038EE4 RID: 233188 RVA: 0x007B204F File Offset: 0x007B024F
		public ITeleportToLatestResetPointTypeT AsITeleportToLatestResetPointType()
		{
			return this.As<ITeleportToLatestResetPointTypeT>();
		}

		// Token: 0x06038EE5 RID: 233189 RVA: 0x007B2057 File Offset: 0x007B0257
		public static ITeleportToLatestResetPointType_UnionUnion FromITeleportToLatestResetPointType(ITeleportToLatestResetPointTypeT _iteleporttolatestresetpointtype)
		{
			return new ITeleportToLatestResetPointType_UnionUnion
			{
				Type = ITeleportToLatestResetPointType_Union.ITeleportToLatestResetPointType,
				Value = _iteleporttolatestresetpointtype
			};
		}

		// Token: 0x06038EE6 RID: 233190 RVA: 0x007B206C File Offset: 0x007B026C
		public ITeleportToLatestResetPointDirectlyT AsITeleportToLatestResetPointDirectly()
		{
			return this.As<ITeleportToLatestResetPointDirectlyT>();
		}

		// Token: 0x06038EE7 RID: 233191 RVA: 0x007B2074 File Offset: 0x007B0274
		public static ITeleportToLatestResetPointType_UnionUnion FromITeleportToLatestResetPointDirectly(ITeleportToLatestResetPointDirectlyT _iteleporttolatestresetpointdirectly)
		{
			return new ITeleportToLatestResetPointType_UnionUnion
			{
				Type = ITeleportToLatestResetPointType_Union.ITeleportToLatestResetPointDirectly,
				Value = _iteleporttolatestresetpointdirectly
			};
		}

		// Token: 0x06038EE8 RID: 233192 RVA: 0x007B208C File Offset: 0x007B028C
		public static int Pack(FlatBufferBuilder builder, ITeleportToLatestResetPointType_UnionUnion _o)
		{
			ITeleportToLatestResetPointType_Union type = _o.Type;
			if (type == ITeleportToLatestResetPointType_Union.ITeleportToLatestResetPointType)
			{
				return ITeleportToLatestResetPointType.Pack(builder, _o.AsITeleportToLatestResetPointType()).Value;
			}
			if (type != ITeleportToLatestResetPointType_Union.ITeleportToLatestResetPointDirectly)
			{
				return 0;
			}
			return ITeleportToLatestResetPointDirectly.Pack(builder, _o.AsITeleportToLatestResetPointDirectly()).Value;
		}
	}
}
