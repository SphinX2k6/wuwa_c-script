using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E8E RID: 24206
	public class TGravityDirectionUnion
	{
		// Token: 0x1700B4DB RID: 46299
		// (get) Token: 0x0602973E RID: 169790 RVA: 0x005AE1C6 File Offset: 0x005AC3C6
		// (set) Token: 0x0602973F RID: 169791 RVA: 0x005AE1CE File Offset: 0x005AC3CE
		public TGravityDirection Type { get; set; }

		// Token: 0x1700B4DC RID: 46300
		// (get) Token: 0x06029740 RID: 169792 RVA: 0x005AE1D7 File Offset: 0x005AC3D7
		// (set) Token: 0x06029741 RID: 169793 RVA: 0x005AE1DF File Offset: 0x005AC3DF
		public object Value { get; set; }

		// Token: 0x06029742 RID: 169794 RVA: 0x005AE1E8 File Offset: 0x005AC3E8
		public TGravityDirectionUnion()
		{
			this.Type = TGravityDirection.NONE;
			this.Value = null;
		}

		// Token: 0x06029743 RID: 169795 RVA: 0x005AE1FE File Offset: 0x005AC3FE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029744 RID: 169796 RVA: 0x005AE210 File Offset: 0x005AC410
		public IGravityDirectionByEntityGravityT AsIGravityDirectionByEntityGravity()
		{
			return this.As<IGravityDirectionByEntityGravityT>();
		}

		// Token: 0x06029745 RID: 169797 RVA: 0x005AE218 File Offset: 0x005AC418
		public static TGravityDirectionUnion FromIGravityDirectionByEntityGravity(IGravityDirectionByEntityGravityT _igravitydirectionbyentitygravity)
		{
			return new TGravityDirectionUnion
			{
				Type = TGravityDirection.IGravityDirectionByEntityGravity,
				Value = _igravitydirectionbyentitygravity
			};
		}

		// Token: 0x06029746 RID: 169798 RVA: 0x005AE22D File Offset: 0x005AC42D
		public IGravityDirectionSelfRotationT AsIGravityDirectionSelfRotation()
		{
			return this.As<IGravityDirectionSelfRotationT>();
		}

		// Token: 0x06029747 RID: 169799 RVA: 0x005AE235 File Offset: 0x005AC435
		public static TGravityDirectionUnion FromIGravityDirectionSelfRotation(IGravityDirectionSelfRotationT _igravitydirectionselfrotation)
		{
			return new TGravityDirectionUnion
			{
				Type = TGravityDirection.IGravityDirectionSelfRotation,
				Value = _igravitydirectionselfrotation
			};
		}

		// Token: 0x06029748 RID: 169800 RVA: 0x005AE24A File Offset: 0x005AC44A
		public IGravityDirectionVectorInfoT AsIGravityDirectionVectorInfo()
		{
			return this.As<IGravityDirectionVectorInfoT>();
		}

		// Token: 0x06029749 RID: 169801 RVA: 0x005AE252 File Offset: 0x005AC452
		public static TGravityDirectionUnion FromIGravityDirectionVectorInfo(IGravityDirectionVectorInfoT _igravitydirectionvectorinfo)
		{
			return new TGravityDirectionUnion
			{
				Type = TGravityDirection.IGravityDirectionVectorInfo,
				Value = _igravitydirectionvectorinfo
			};
		}

		// Token: 0x0602974A RID: 169802 RVA: 0x005AE267 File Offset: 0x005AC467
		public IGravityDirectionWorldAxisT AsIGravityDirectionWorldAxis()
		{
			return this.As<IGravityDirectionWorldAxisT>();
		}

		// Token: 0x0602974B RID: 169803 RVA: 0x005AE26F File Offset: 0x005AC46F
		public static TGravityDirectionUnion FromIGravityDirectionWorldAxis(IGravityDirectionWorldAxisT _igravitydirectionworldaxis)
		{
			return new TGravityDirectionUnion
			{
				Type = TGravityDirection.IGravityDirectionWorldAxis,
				Value = _igravitydirectionworldaxis
			};
		}

		// Token: 0x0602974C RID: 169804 RVA: 0x005AE284 File Offset: 0x005AC484
		public static int Pack(FlatBufferBuilder builder, TGravityDirectionUnion _o)
		{
			switch (_o.Type)
			{
			case TGravityDirection.IGravityDirectionByEntityGravity:
				return IGravityDirectionByEntityGravity.Pack(builder, _o.AsIGravityDirectionByEntityGravity()).Value;
			case TGravityDirection.IGravityDirectionSelfRotation:
				return IGravityDirectionSelfRotation.Pack(builder, _o.AsIGravityDirectionSelfRotation()).Value;
			case TGravityDirection.IGravityDirectionVectorInfo:
				return IGravityDirectionVectorInfo.Pack(builder, _o.AsIGravityDirectionVectorInfo()).Value;
			case TGravityDirection.IGravityDirectionWorldAxis:
				return IGravityDirectionWorldAxis.Pack(builder, _o.AsIGravityDirectionWorldAxis()).Value;
			default:
				return 0;
			}
		}
	}
}
