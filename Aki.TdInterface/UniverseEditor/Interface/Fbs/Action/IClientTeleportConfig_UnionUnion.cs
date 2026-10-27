using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063FB RID: 25595
	public class IClientTeleportConfig_UnionUnion
	{
		// Token: 0x1700BE96 RID: 48790
		// (get) Token: 0x0602C467 RID: 181351 RVA: 0x0061395D File Offset: 0x00611B5D
		// (set) Token: 0x0602C468 RID: 181352 RVA: 0x00613965 File Offset: 0x00611B65
		public IClientTeleportConfig_Union Type { get; set; }

		// Token: 0x1700BE97 RID: 48791
		// (get) Token: 0x0602C469 RID: 181353 RVA: 0x0061396E File Offset: 0x00611B6E
		// (set) Token: 0x0602C46A RID: 181354 RVA: 0x00613976 File Offset: 0x00611B76
		public object Value { get; set; }

		// Token: 0x0602C46B RID: 181355 RVA: 0x0061397F File Offset: 0x00611B7F
		public IClientTeleportConfig_UnionUnion()
		{
			this.Type = IClientTeleportConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C46C RID: 181356 RVA: 0x00613995 File Offset: 0x00611B95
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C46D RID: 181357 RVA: 0x006139A7 File Offset: 0x00611BA7
		public IClientTeleportConfigT AsIClientTeleportConfig()
		{
			return this.As<IClientTeleportConfigT>();
		}

		// Token: 0x0602C46E RID: 181358 RVA: 0x006139AF File Offset: 0x00611BAF
		public static IClientTeleportConfig_UnionUnion FromIClientTeleportConfig(IClientTeleportConfigT _iclientteleportconfig)
		{
			return new IClientTeleportConfig_UnionUnion
			{
				Type = IClientTeleportConfig_Union.IClientTeleportConfig,
				Value = _iclientteleportconfig
			};
		}

		// Token: 0x0602C46F RID: 181359 RVA: 0x006139C4 File Offset: 0x00611BC4
		public IClientTpRelativeEntityPosT AsIClientTpRelativeEntityPos()
		{
			return this.As<IClientTpRelativeEntityPosT>();
		}

		// Token: 0x0602C470 RID: 181360 RVA: 0x006139CC File Offset: 0x00611BCC
		public static IClientTeleportConfig_UnionUnion FromIClientTpRelativeEntityPos(IClientTpRelativeEntityPosT _iclienttprelativeentitypos)
		{
			return new IClientTeleportConfig_UnionUnion
			{
				Type = IClientTeleportConfig_Union.IClientTpRelativeEntityPos,
				Value = _iclienttprelativeentitypos
			};
		}

		// Token: 0x0602C471 RID: 181361 RVA: 0x006139E1 File Offset: 0x00611BE1
		public IClientTpToStreamingTargetPointT AsIClientTpToStreamingTargetPoint()
		{
			return this.As<IClientTpToStreamingTargetPointT>();
		}

		// Token: 0x0602C472 RID: 181362 RVA: 0x006139E9 File Offset: 0x00611BE9
		public static IClientTeleportConfig_UnionUnion FromIClientTpToStreamingTargetPoint(IClientTpToStreamingTargetPointT _iclienttptostreamingtargetpoint)
		{
			return new IClientTeleportConfig_UnionUnion
			{
				Type = IClientTeleportConfig_Union.IClientTpToStreamingTargetPoint,
				Value = _iclienttptostreamingtargetpoint
			};
		}

		// Token: 0x0602C473 RID: 181363 RVA: 0x00613A00 File Offset: 0x00611C00
		public static int Pack(FlatBufferBuilder builder, IClientTeleportConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IClientTeleportConfig_Union.IClientTeleportConfig:
				return IClientTeleportConfig.Pack(builder, _o.AsIClientTeleportConfig()).Value;
			case IClientTeleportConfig_Union.IClientTpRelativeEntityPos:
				return IClientTpRelativeEntityPos.Pack(builder, _o.AsIClientTpRelativeEntityPos()).Value;
			case IClientTeleportConfig_Union.IClientTpToStreamingTargetPoint:
				return IClientTpToStreamingTargetPoint.Pack(builder, _o.AsIClientTpToStreamingTargetPoint()).Value;
			default:
				return 0;
			}
		}
	}
}
