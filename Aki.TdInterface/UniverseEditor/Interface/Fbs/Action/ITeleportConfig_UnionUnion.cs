using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B61 RID: 31585
	public class ITeleportConfig_UnionUnion
	{
		// Token: 0x1700EC76 RID: 60534
		// (get) Token: 0x06038DF7 RID: 232951 RVA: 0x007B0435 File Offset: 0x007AE635
		// (set) Token: 0x06038DF8 RID: 232952 RVA: 0x007B043D File Offset: 0x007AE63D
		public ITeleportConfig_Union Type { get; set; }

		// Token: 0x1700EC77 RID: 60535
		// (get) Token: 0x06038DF9 RID: 232953 RVA: 0x007B0446 File Offset: 0x007AE646
		// (set) Token: 0x06038DFA RID: 232954 RVA: 0x007B044E File Offset: 0x007AE64E
		public object Value { get; set; }

		// Token: 0x06038DFB RID: 232955 RVA: 0x007B0457 File Offset: 0x007AE657
		public ITeleportConfig_UnionUnion()
		{
			this.Type = ITeleportConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06038DFC RID: 232956 RVA: 0x007B046D File Offset: 0x007AE66D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06038DFD RID: 232957 RVA: 0x007B047F File Offset: 0x007AE67F
		public ITeleportConfigT AsITeleportConfig()
		{
			return this.As<ITeleportConfigT>();
		}

		// Token: 0x06038DFE RID: 232958 RVA: 0x007B0487 File Offset: 0x007AE687
		public static ITeleportConfig_UnionUnion FromITeleportConfig(ITeleportConfigT _iteleportconfig)
		{
			return new ITeleportConfig_UnionUnion
			{
				Type = ITeleportConfig_Union.ITeleportConfig,
				Value = _iteleportconfig
			};
		}

		// Token: 0x06038DFF RID: 232959 RVA: 0x007B049C File Offset: 0x007AE69C
		public IFixedPosT AsIFixedPos()
		{
			return this.As<IFixedPosT>();
		}

		// Token: 0x06038E00 RID: 232960 RVA: 0x007B04A4 File Offset: 0x007AE6A4
		public static ITeleportConfig_UnionUnion FromIFixedPos(IFixedPosT _ifixedpos)
		{
			return new ITeleportConfig_UnionUnion
			{
				Type = ITeleportConfig_Union.IFixedPos,
				Value = _ifixedpos
			};
		}

		// Token: 0x06038E01 RID: 232961 RVA: 0x007B04B9 File Offset: 0x007AE6B9
		public INearestEntityT AsINearestEntity()
		{
			return this.As<INearestEntityT>();
		}

		// Token: 0x06038E02 RID: 232962 RVA: 0x007B04C1 File Offset: 0x007AE6C1
		public static ITeleportConfig_UnionUnion FromINearestEntity(INearestEntityT _inearestentity)
		{
			return new ITeleportConfig_UnionUnion
			{
				Type = ITeleportConfig_Union.INearestEntity,
				Value = _inearestentity
			};
		}

		// Token: 0x06038E03 RID: 232963 RVA: 0x007B04D6 File Offset: 0x007AE6D6
		public IGravityFlipFixedPosT AsIGravityFlipFixedPos()
		{
			return this.As<IGravityFlipFixedPosT>();
		}

		// Token: 0x06038E04 RID: 232964 RVA: 0x007B04DE File Offset: 0x007AE6DE
		public static ITeleportConfig_UnionUnion FromIGravityFlipFixedPos(IGravityFlipFixedPosT _igravityflipfixedpos)
		{
			return new ITeleportConfig_UnionUnion
			{
				Type = ITeleportConfig_Union.IGravityFlipFixedPos,
				Value = _igravityflipfixedpos
			};
		}

		// Token: 0x06038E05 RID: 232965 RVA: 0x007B04F3 File Offset: 0x007AE6F3
		public ISafePosT AsISafePos()
		{
			return this.As<ISafePosT>();
		}

		// Token: 0x06038E06 RID: 232966 RVA: 0x007B04FB File Offset: 0x007AE6FB
		public static ITeleportConfig_UnionUnion FromISafePos(ISafePosT _isafepos)
		{
			return new ITeleportConfig_UnionUnion
			{
				Type = ITeleportConfig_Union.ISafePos,
				Value = _isafepos
			};
		}

		// Token: 0x06038E07 RID: 232967 RVA: 0x007B0510 File Offset: 0x007AE710
		public static int Pack(FlatBufferBuilder builder, ITeleportConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITeleportConfig_Union.ITeleportConfig:
				return ITeleportConfig.Pack(builder, _o.AsITeleportConfig()).Value;
			case ITeleportConfig_Union.IFixedPos:
				return IFixedPos.Pack(builder, _o.AsIFixedPos()).Value;
			case ITeleportConfig_Union.INearestEntity:
				return INearestEntity.Pack(builder, _o.AsINearestEntity()).Value;
			case ITeleportConfig_Union.IGravityFlipFixedPos:
				return IGravityFlipFixedPos.Pack(builder, _o.AsIGravityFlipFixedPos()).Value;
			case ITeleportConfig_Union.ISafePos:
				return ISafePos.Pack(builder, _o.AsISafePos()).Value;
			default:
				return 0;
			}
		}
	}
}
