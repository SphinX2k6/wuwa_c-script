using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200643B RID: 25659
	public class IGravityDirectionType_UnionUnion
	{
		// Token: 0x1700BD70 RID: 48496
		// (get) Token: 0x0602B97E RID: 178558 RVA: 0x005EF521 File Offset: 0x005ED721
		// (set) Token: 0x0602B97F RID: 178559 RVA: 0x005EF529 File Offset: 0x005ED729
		public IGravityDirectionType_Union Type { get; set; }

		// Token: 0x1700BD71 RID: 48497
		// (get) Token: 0x0602B980 RID: 178560 RVA: 0x005EF532 File Offset: 0x005ED732
		// (set) Token: 0x0602B981 RID: 178561 RVA: 0x005EF53A File Offset: 0x005ED73A
		public object Value { get; set; }

		// Token: 0x0602B982 RID: 178562 RVA: 0x005EF543 File Offset: 0x005ED743
		public IGravityDirectionType_UnionUnion()
		{
			this.Type = IGravityDirectionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B983 RID: 178563 RVA: 0x005EF559 File Offset: 0x005ED759
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B984 RID: 178564 RVA: 0x005EF56B File Offset: 0x005ED76B
		public IGravityDirectionTypeT AsIGravityDirectionType()
		{
			return this.As<IGravityDirectionTypeT>();
		}

		// Token: 0x0602B985 RID: 178565 RVA: 0x005EF573 File Offset: 0x005ED773
		public static IGravityDirectionType_UnionUnion FromIGravityDirectionType(IGravityDirectionTypeT _igravitydirectiontype)
		{
			return new IGravityDirectionType_UnionUnion
			{
				Type = IGravityDirectionType_Union.IGravityDirectionType,
				Value = _igravitydirectiontype
			};
		}

		// Token: 0x0602B986 RID: 178566 RVA: 0x005EF588 File Offset: 0x005ED788
		public IGravityDirectionSelfRotationT AsIGravityDirectionSelfRotation()
		{
			return this.As<IGravityDirectionSelfRotationT>();
		}

		// Token: 0x0602B987 RID: 178567 RVA: 0x005EF590 File Offset: 0x005ED790
		public static IGravityDirectionType_UnionUnion FromIGravityDirectionSelfRotation(IGravityDirectionSelfRotationT _igravitydirectionselfrotation)
		{
			return new IGravityDirectionType_UnionUnion
			{
				Type = IGravityDirectionType_Union.IGravityDirectionSelfRotation,
				Value = _igravitydirectionselfrotation
			};
		}

		// Token: 0x0602B988 RID: 178568 RVA: 0x005EF5A5 File Offset: 0x005ED7A5
		public IGravityDirectionVectorInfoT AsIGravityDirectionVectorInfo()
		{
			return this.As<IGravityDirectionVectorInfoT>();
		}

		// Token: 0x0602B989 RID: 178569 RVA: 0x005EF5AD File Offset: 0x005ED7AD
		public static IGravityDirectionType_UnionUnion FromIGravityDirectionVectorInfo(IGravityDirectionVectorInfoT _igravitydirectionvectorinfo)
		{
			return new IGravityDirectionType_UnionUnion
			{
				Type = IGravityDirectionType_Union.IGravityDirectionVectorInfo,
				Value = _igravitydirectionvectorinfo
			};
		}

		// Token: 0x0602B98A RID: 178570 RVA: 0x005EF5C2 File Offset: 0x005ED7C2
		public IGravityDirectionWorldAxisT AsIGravityDirectionWorldAxis()
		{
			return this.As<IGravityDirectionWorldAxisT>();
		}

		// Token: 0x0602B98B RID: 178571 RVA: 0x005EF5CA File Offset: 0x005ED7CA
		public static IGravityDirectionType_UnionUnion FromIGravityDirectionWorldAxis(IGravityDirectionWorldAxisT _igravitydirectionworldaxis)
		{
			return new IGravityDirectionType_UnionUnion
			{
				Type = IGravityDirectionType_Union.IGravityDirectionWorldAxis,
				Value = _igravitydirectionworldaxis
			};
		}

		// Token: 0x0602B98C RID: 178572 RVA: 0x005EF5DF File Offset: 0x005ED7DF
		public IGravityDirectionByEntityGravityT AsIGravityDirectionByEntityGravity()
		{
			return this.As<IGravityDirectionByEntityGravityT>();
		}

		// Token: 0x0602B98D RID: 178573 RVA: 0x005EF5E7 File Offset: 0x005ED7E7
		public static IGravityDirectionType_UnionUnion FromIGravityDirectionByEntityGravity(IGravityDirectionByEntityGravityT _igravitydirectionbyentitygravity)
		{
			return new IGravityDirectionType_UnionUnion
			{
				Type = IGravityDirectionType_Union.IGravityDirectionByEntityGravity,
				Value = _igravitydirectionbyentitygravity
			};
		}

		// Token: 0x0602B98E RID: 178574 RVA: 0x005EF5FC File Offset: 0x005ED7FC
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
