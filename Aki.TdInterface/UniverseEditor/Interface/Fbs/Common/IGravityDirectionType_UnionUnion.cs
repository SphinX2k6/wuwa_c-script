using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DFE RID: 24062
	public class IGravityDirectionType_UnionUnion
	{
		// Token: 0x1700B40A RID: 46090
		// (get) Token: 0x060292F4 RID: 168692 RVA: 0x005A67F1 File Offset: 0x005A49F1
		// (set) Token: 0x060292F5 RID: 168693 RVA: 0x005A67F9 File Offset: 0x005A49F9
		public IGravityDirectionType_Union Type { get; set; }

		// Token: 0x1700B40B RID: 46091
		// (get) Token: 0x060292F6 RID: 168694 RVA: 0x005A6802 File Offset: 0x005A4A02
		// (set) Token: 0x060292F7 RID: 168695 RVA: 0x005A680A File Offset: 0x005A4A0A
		public object Value { get; set; }

		// Token: 0x060292F8 RID: 168696 RVA: 0x005A6813 File Offset: 0x005A4A13
		public IGravityDirectionType_UnionUnion()
		{
			this.Type = IGravityDirectionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060292F9 RID: 168697 RVA: 0x005A6829 File Offset: 0x005A4A29
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060292FA RID: 168698 RVA: 0x005A683B File Offset: 0x005A4A3B
		public IGravityDirectionTypeT AsIGravityDirectionType()
		{
			return this.As<IGravityDirectionTypeT>();
		}

		// Token: 0x060292FB RID: 168699 RVA: 0x005A6843 File Offset: 0x005A4A43
		public static IGravityDirectionType_UnionUnion FromIGravityDirectionType(IGravityDirectionTypeT _igravitydirectiontype)
		{
			return new IGravityDirectionType_UnionUnion
			{
				Type = IGravityDirectionType_Union.IGravityDirectionType,
				Value = _igravitydirectiontype
			};
		}

		// Token: 0x060292FC RID: 168700 RVA: 0x005A6858 File Offset: 0x005A4A58
		public IGravityDirectionSelfRotationT AsIGravityDirectionSelfRotation()
		{
			return this.As<IGravityDirectionSelfRotationT>();
		}

		// Token: 0x060292FD RID: 168701 RVA: 0x005A6860 File Offset: 0x005A4A60
		public static IGravityDirectionType_UnionUnion FromIGravityDirectionSelfRotation(IGravityDirectionSelfRotationT _igravitydirectionselfrotation)
		{
			return new IGravityDirectionType_UnionUnion
			{
				Type = IGravityDirectionType_Union.IGravityDirectionSelfRotation,
				Value = _igravitydirectionselfrotation
			};
		}

		// Token: 0x060292FE RID: 168702 RVA: 0x005A6875 File Offset: 0x005A4A75
		public IGravityDirectionVectorInfoT AsIGravityDirectionVectorInfo()
		{
			return this.As<IGravityDirectionVectorInfoT>();
		}

		// Token: 0x060292FF RID: 168703 RVA: 0x005A687D File Offset: 0x005A4A7D
		public static IGravityDirectionType_UnionUnion FromIGravityDirectionVectorInfo(IGravityDirectionVectorInfoT _igravitydirectionvectorinfo)
		{
			return new IGravityDirectionType_UnionUnion
			{
				Type = IGravityDirectionType_Union.IGravityDirectionVectorInfo,
				Value = _igravitydirectionvectorinfo
			};
		}

		// Token: 0x06029300 RID: 168704 RVA: 0x005A6892 File Offset: 0x005A4A92
		public IGravityDirectionWorldAxisT AsIGravityDirectionWorldAxis()
		{
			return this.As<IGravityDirectionWorldAxisT>();
		}

		// Token: 0x06029301 RID: 168705 RVA: 0x005A689A File Offset: 0x005A4A9A
		public static IGravityDirectionType_UnionUnion FromIGravityDirectionWorldAxis(IGravityDirectionWorldAxisT _igravitydirectionworldaxis)
		{
			return new IGravityDirectionType_UnionUnion
			{
				Type = IGravityDirectionType_Union.IGravityDirectionWorldAxis,
				Value = _igravitydirectionworldaxis
			};
		}

		// Token: 0x06029302 RID: 168706 RVA: 0x005A68AF File Offset: 0x005A4AAF
		public IGravityDirectionByEntityGravityT AsIGravityDirectionByEntityGravity()
		{
			return this.As<IGravityDirectionByEntityGravityT>();
		}

		// Token: 0x06029303 RID: 168707 RVA: 0x005A68B7 File Offset: 0x005A4AB7
		public static IGravityDirectionType_UnionUnion FromIGravityDirectionByEntityGravity(IGravityDirectionByEntityGravityT _igravitydirectionbyentitygravity)
		{
			return new IGravityDirectionType_UnionUnion
			{
				Type = IGravityDirectionType_Union.IGravityDirectionByEntityGravity,
				Value = _igravitydirectionbyentitygravity
			};
		}

		// Token: 0x06029304 RID: 168708 RVA: 0x005A68CC File Offset: 0x005A4ACC
		public static int Pack(FlatBufferBuilder builder, IGravityDirectionType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IGravityDirectionType_Union.IGravityDirectionType:
				return IGravityDirectionType.Pack(builder, _o.AsIGravityDirectionType()).Value;
			case IGravityDirectionType_Union.IGravityDirectionSelfRotation:
				return IGravityDirectionSelfRotation.Pack(builder, _o.AsIGravityDirectionSelfRotation()).Value;
			case IGravityDirectionType_Union.IGravityDirectionVectorInfo:
				return IGravityDirectionVectorInfo.Pack(builder, _o.AsIGravityDirectionVectorInfo()).Value;
			case IGravityDirectionType_Union.IGravityDirectionWorldAxis:
				return IGravityDirectionWorldAxis.Pack(builder, _o.AsIGravityDirectionWorldAxis()).Value;
			case IGravityDirectionType_Union.IGravityDirectionByEntityGravity:
				return IGravityDirectionByEntityGravity.Pack(builder, _o.AsIGravityDirectionByEntityGravity()).Value;
			default:
				return 0;
			}
		}
	}
}
