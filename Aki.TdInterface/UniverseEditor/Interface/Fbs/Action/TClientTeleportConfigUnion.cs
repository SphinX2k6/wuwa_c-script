using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E92 RID: 32402
	public class TClientTeleportConfigUnion
	{
		// Token: 0x1700F229 RID: 61993
		// (get) Token: 0x0603A7E7 RID: 239591 RVA: 0x007DF82E File Offset: 0x007DDA2E
		// (set) Token: 0x0603A7E8 RID: 239592 RVA: 0x007DF836 File Offset: 0x007DDA36
		public TClientTeleportConfig Type { get; set; }

		// Token: 0x1700F22A RID: 61994
		// (get) Token: 0x0603A7E9 RID: 239593 RVA: 0x007DF83F File Offset: 0x007DDA3F
		// (set) Token: 0x0603A7EA RID: 239594 RVA: 0x007DF847 File Offset: 0x007DDA47
		public object Value { get; set; }

		// Token: 0x0603A7EB RID: 239595 RVA: 0x007DF850 File Offset: 0x007DDA50
		public TClientTeleportConfigUnion()
		{
			this.Type = TClientTeleportConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603A7EC RID: 239596 RVA: 0x007DF866 File Offset: 0x007DDA66
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A7ED RID: 239597 RVA: 0x007DF878 File Offset: 0x007DDA78
		public IClientTpRelativeEntityPosT AsIClientTpRelativeEntityPos()
		{
			return this.As<IClientTpRelativeEntityPosT>();
		}

		// Token: 0x0603A7EE RID: 239598 RVA: 0x007DF880 File Offset: 0x007DDA80
		public static TClientTeleportConfigUnion FromIClientTpRelativeEntityPos(IClientTpRelativeEntityPosT _iclienttprelativeentitypos)
		{
			return new TClientTeleportConfigUnion
			{
				Type = TClientTeleportConfig.IClientTpRelativeEntityPos,
				Value = _iclienttprelativeentitypos
			};
		}

		// Token: 0x0603A7EF RID: 239599 RVA: 0x007DF895 File Offset: 0x007DDA95
		public IClientTpToStreamingTargetPointT AsIClientTpToStreamingTargetPoint()
		{
			return this.As<IClientTpToStreamingTargetPointT>();
		}

		// Token: 0x0603A7F0 RID: 239600 RVA: 0x007DF89D File Offset: 0x007DDA9D
		public static TClientTeleportConfigUnion FromIClientTpToStreamingTargetPoint(IClientTpToStreamingTargetPointT _iclienttptostreamingtargetpoint)
		{
			return new TClientTeleportConfigUnion
			{
				Type = TClientTeleportConfig.IClientTpToStreamingTargetPoint,
				Value = _iclienttptostreamingtargetpoint
			};
		}

		// Token: 0x0603A7F1 RID: 239601 RVA: 0x007DF8B4 File Offset: 0x007DDAB4
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
