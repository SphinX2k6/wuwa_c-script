using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200737A RID: 29562
	public class ITeleportConfig_UnionUnion
	{
		// Token: 0x1700E066 RID: 57446
		// (get) Token: 0x06035A5C RID: 219740 RVA: 0x0074DEF5 File Offset: 0x0074C0F5
		// (set) Token: 0x06035A5D RID: 219741 RVA: 0x0074DEFD File Offset: 0x0074C0FD
		public ITeleportConfig_Union Type { get; set; }

		// Token: 0x1700E067 RID: 57447
		// (get) Token: 0x06035A5E RID: 219742 RVA: 0x0074DF06 File Offset: 0x0074C106
		// (set) Token: 0x06035A5F RID: 219743 RVA: 0x0074DF0E File Offset: 0x0074C10E
		public object Value { get; set; }

		// Token: 0x06035A60 RID: 219744 RVA: 0x0074DF17 File Offset: 0x0074C117
		public ITeleportConfig_UnionUnion()
		{
			this.Type = ITeleportConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035A61 RID: 219745 RVA: 0x0074DF2D File Offset: 0x0074C12D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035A62 RID: 219746 RVA: 0x0074DF3F File Offset: 0x0074C13F
		public ITeleportConfigT AsITeleportConfig()
		{
			return this.As<ITeleportConfigT>();
		}

		// Token: 0x06035A63 RID: 219747 RVA: 0x0074DF47 File Offset: 0x0074C147
		public static ITeleportConfig_UnionUnion FromITeleportConfig(ITeleportConfigT _iteleportconfig)
		{
			return new ITeleportConfig_UnionUnion
			{
				Type = ITeleportConfig_Union.ITeleportConfig,
				Value = _iteleportconfig
			};
		}

		// Token: 0x06035A64 RID: 219748 RVA: 0x0074DF5C File Offset: 0x0074C15C
		public IFixedPosT AsIFixedPos()
		{
			return this.As<IFixedPosT>();
		}

		// Token: 0x06035A65 RID: 219749 RVA: 0x0074DF64 File Offset: 0x0074C164
		public static ITeleportConfig_UnionUnion FromIFixedPos(IFixedPosT _ifixedpos)
		{
			return new ITeleportConfig_UnionUnion
			{
				Type = ITeleportConfig_Union.IFixedPos,
				Value = _ifixedpos
			};
		}

		// Token: 0x06035A66 RID: 219750 RVA: 0x0074DF79 File Offset: 0x0074C179
		public INearestEntityT AsINearestEntity()
		{
			return this.As<INearestEntityT>();
		}

		// Token: 0x06035A67 RID: 219751 RVA: 0x0074DF81 File Offset: 0x0074C181
		public static ITeleportConfig_UnionUnion FromINearestEntity(INearestEntityT _inearestentity)
		{
			return new ITeleportConfig_UnionUnion
			{
				Type = ITeleportConfig_Union.INearestEntity,
				Value = _inearestentity
			};
		}

		// Token: 0x06035A68 RID: 219752 RVA: 0x0074DF96 File Offset: 0x0074C196
		public IGravityFlipFixedPosT AsIGravityFlipFixedPos()
		{
			return this.As<IGravityFlipFixedPosT>();
		}

		// Token: 0x06035A69 RID: 219753 RVA: 0x0074DF9E File Offset: 0x0074C19E
		public static ITeleportConfig_UnionUnion FromIGravityFlipFixedPos(IGravityFlipFixedPosT _igravityflipfixedpos)
		{
			return new ITeleportConfig_UnionUnion
			{
				Type = ITeleportConfig_Union.IGravityFlipFixedPos,
				Value = _igravityflipfixedpos
			};
		}

		// Token: 0x06035A6A RID: 219754 RVA: 0x0074DFB3 File Offset: 0x0074C1B3
		public ISafePosT AsISafePos()
		{
			return this.As<ISafePosT>();
		}

		// Token: 0x06035A6B RID: 219755 RVA: 0x0074DFBB File Offset: 0x0074C1BB
		public static ITeleportConfig_UnionUnion FromISafePos(ISafePosT _isafepos)
		{
			return new ITeleportConfig_UnionUnion
			{
				Type = ITeleportConfig_Union.ISafePos,
				Value = _isafepos
			};
		}

		// Token: 0x06035A6C RID: 219756 RVA: 0x0074DFD0 File Offset: 0x0074C1D0
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
