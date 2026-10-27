using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007684 RID: 30340
	public class TClientTeleportConfigUnion
	{
		// Token: 0x1700E5EB RID: 58859
		// (get) Token: 0x06037340 RID: 226112 RVA: 0x0077B6E6 File Offset: 0x007798E6
		// (set) Token: 0x06037341 RID: 226113 RVA: 0x0077B6EE File Offset: 0x007798EE
		public TClientTeleportConfig Type { get; set; }

		// Token: 0x1700E5EC RID: 58860
		// (get) Token: 0x06037342 RID: 226114 RVA: 0x0077B6F7 File Offset: 0x007798F7
		// (set) Token: 0x06037343 RID: 226115 RVA: 0x0077B6FF File Offset: 0x007798FF
		public object Value { get; set; }

		// Token: 0x06037344 RID: 226116 RVA: 0x0077B708 File Offset: 0x00779908
		public TClientTeleportConfigUnion()
		{
			this.Type = TClientTeleportConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06037345 RID: 226117 RVA: 0x0077B71E File Offset: 0x0077991E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037346 RID: 226118 RVA: 0x0077B730 File Offset: 0x00779930
		public IClientTpRelativeEntityPosT AsIClientTpRelativeEntityPos()
		{
			return this.As<IClientTpRelativeEntityPosT>();
		}

		// Token: 0x06037347 RID: 226119 RVA: 0x0077B738 File Offset: 0x00779938
		public static TClientTeleportConfigUnion FromIClientTpRelativeEntityPos(IClientTpRelativeEntityPosT _iclienttprelativeentitypos)
		{
			return new TClientTeleportConfigUnion
			{
				Type = TClientTeleportConfig.IClientTpRelativeEntityPos,
				Value = _iclienttprelativeentitypos
			};
		}

		// Token: 0x06037348 RID: 226120 RVA: 0x0077B74D File Offset: 0x0077994D
		public IClientTpToStreamingTargetPointT AsIClientTpToStreamingTargetPoint()
		{
			return this.As<IClientTpToStreamingTargetPointT>();
		}

		// Token: 0x06037349 RID: 226121 RVA: 0x0077B755 File Offset: 0x00779955
		public static TClientTeleportConfigUnion FromIClientTpToStreamingTargetPoint(IClientTpToStreamingTargetPointT _iclienttptostreamingtargetpoint)
		{
			return new TClientTeleportConfigUnion
			{
				Type = TClientTeleportConfig.IClientTpToStreamingTargetPoint,
				Value = _iclienttptostreamingtargetpoint
			};
		}

		// Token: 0x0603734A RID: 226122 RVA: 0x0077B76C File Offset: 0x0077996C
		public static int Pack(FlatBufferBuilder builder, TClientTeleportConfigUnion _o)
		{
			TClientTeleportConfig type = _o.Type;
			if (type == TClientTeleportConfig.IClientTpRelativeEntityPos)
			{
				return IClientTpRelativeEntityPos.Pack(builder, _o.AsIClientTpRelativeEntityPos()).Value;
			}
			if (type != TClientTeleportConfig.IClientTpToStreamingTargetPoint)
			{
				return 0;
			}
			return IClientTpToStreamingTargetPoint.Pack(builder, _o.AsIClientTpToStreamingTargetPoint()).Value;
		}
	}
}
