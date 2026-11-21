using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A7B RID: 27259
	public class IClientTeleportConfig_UnionUnion
	{
		// Token: 0x1700C830 RID: 51248
		// (get) Token: 0x0602EC3D RID: 191549 RVA: 0x0065F7E9 File Offset: 0x0065D9E9
		// (set) Token: 0x0602EC3E RID: 191550 RVA: 0x0065F7F1 File Offset: 0x0065D9F1
		public IClientTeleportConfig_Union Type { get; set; }

		// Token: 0x1700C831 RID: 51249
		// (get) Token: 0x0602EC3F RID: 191551 RVA: 0x0065F7FA File Offset: 0x0065D9FA
		// (set) Token: 0x0602EC40 RID: 191552 RVA: 0x0065F802 File Offset: 0x0065DA02
		public object Value { get; set; }

		// Token: 0x0602EC41 RID: 191553 RVA: 0x0065F80B File Offset: 0x0065DA0B
		public IClientTeleportConfig_UnionUnion()
		{
			this.Type = IClientTeleportConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EC42 RID: 191554 RVA: 0x0065F821 File Offset: 0x0065DA21
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EC43 RID: 191555 RVA: 0x0065F833 File Offset: 0x0065DA33
		public IClientTeleportConfigT AsIClientTeleportConfig()
		{
			return this.As<IClientTeleportConfigT>();
		}

		// Token: 0x0602EC44 RID: 191556 RVA: 0x0065F83B File Offset: 0x0065DA3B
		public static IClientTeleportConfig_UnionUnion FromIClientTeleportConfig(IClientTeleportConfigT _iclientteleportconfig)
		{
			return new IClientTeleportConfig_UnionUnion
			{
				Type = IClientTeleportConfig_Union.IClientTeleportConfig,
				Value = _iclientteleportconfig
			};
		}

		// Token: 0x0602EC45 RID: 191557 RVA: 0x0065F850 File Offset: 0x0065DA50
		public IClientTpRelativeEntityPosT AsIClientTpRelativeEntityPos()
		{
			return this.As<IClientTpRelativeEntityPosT>();
		}

		// Token: 0x0602EC46 RID: 191558 RVA: 0x0065F858 File Offset: 0x0065DA58
		public static IClientTeleportConfig_UnionUnion FromIClientTpRelativeEntityPos(IClientTpRelativeEntityPosT _iclienttprelativeentitypos)
		{
			return new IClientTeleportConfig_UnionUnion
			{
				Type = IClientTeleportConfig_Union.IClientTpRelativeEntityPos,
				Value = _iclienttprelativeentitypos
			};
		}

		// Token: 0x0602EC47 RID: 191559 RVA: 0x0065F86D File Offset: 0x0065DA6D
		public IClientTpToStreamingTargetPointT AsIClientTpToStreamingTargetPoint()
		{
			return this.As<IClientTpToStreamingTargetPointT>();
		}

		// Token: 0x0602EC48 RID: 191560 RVA: 0x0065F875 File Offset: 0x0065DA75
		public static IClientTeleportConfig_UnionUnion FromIClientTpToStreamingTargetPoint(IClientTpToStreamingTargetPointT _iclienttptostreamingtargetpoint)
		{
			return new IClientTeleportConfig_UnionUnion
			{
				Type = IClientTeleportConfig_Union.IClientTpToStreamingTargetPoint,
				Value = _iclienttptostreamingtargetpoint
			};
		}

		// Token: 0x0602EC49 RID: 191561 RVA: 0x0065F88C File Offset: 0x0065DA8C
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
