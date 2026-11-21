using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064D1 RID: 25809
	public class TGravityDirectionUnion
	{
		// Token: 0x1700BE46 RID: 48710
		// (get) Token: 0x0602BDE6 RID: 179686 RVA: 0x005F716A File Offset: 0x005F536A
		// (set) Token: 0x0602BDE7 RID: 179687 RVA: 0x005F7172 File Offset: 0x005F5372
		public TGravityDirection Type { get; set; }

		// Token: 0x1700BE47 RID: 48711
		// (get) Token: 0x0602BDE8 RID: 179688 RVA: 0x005F717B File Offset: 0x005F537B
		// (set) Token: 0x0602BDE9 RID: 179689 RVA: 0x005F7183 File Offset: 0x005F5383
		public object Value { get; set; }

		// Token: 0x0602BDEA RID: 179690 RVA: 0x005F718C File Offset: 0x005F538C
		public TGravityDirectionUnion()
		{
			this.Type = TGravityDirection.NONE;
			this.Value = null;
		}

		// Token: 0x0602BDEB RID: 179691 RVA: 0x005F71A2 File Offset: 0x005F53A2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BDEC RID: 179692 RVA: 0x005F71B4 File Offset: 0x005F53B4
		public IGravityDirectionByEntityGravityT AsIGravityDirectionByEntityGravity()
		{
			return this.As<IGravityDirectionByEntityGravityT>();
		}

		// Token: 0x0602BDED RID: 179693 RVA: 0x005F71BC File Offset: 0x005F53BC
		public static TGravityDirectionUnion FromIGravityDirectionByEntityGravity(IGravityDirectionByEntityGravityT _igravitydirectionbyentitygravity)
		{
			return new TGravityDirectionUnion
			{
				Type = TGravityDirection.IGravityDirectionByEntityGravity,
				Value = _igravitydirectionbyentitygravity
			};
		}

		// Token: 0x0602BDEE RID: 179694 RVA: 0x005F71D1 File Offset: 0x005F53D1
		public IGravityDirectionSelfRotationT AsIGravityDirectionSelfRotation()
		{
			return this.As<IGravityDirectionSelfRotationT>();
		}

		// Token: 0x0602BDEF RID: 179695 RVA: 0x005F71D9 File Offset: 0x005F53D9
		public static TGravityDirectionUnion FromIGravityDirectionSelfRotation(IGravityDirectionSelfRotationT _igravitydirectionselfrotation)
		{
			return new TGravityDirectionUnion
			{
				Type = TGravityDirection.IGravityDirectionSelfRotation,
				Value = _igravitydirectionselfrotation
			};
		}

		// Token: 0x0602BDF0 RID: 179696 RVA: 0x005F71EE File Offset: 0x005F53EE
		public IGravityDirectionVectorInfoT AsIGravityDirectionVectorInfo()
		{
			return this.As<IGravityDirectionVectorInfoT>();
		}

		// Token: 0x0602BDF1 RID: 179697 RVA: 0x005F71F6 File Offset: 0x005F53F6
		public static TGravityDirectionUnion FromIGravityDirectionVectorInfo(IGravityDirectionVectorInfoT _igravitydirectionvectorinfo)
		{
			return new TGravityDirectionUnion
			{
				Type = TGravityDirection.IGravityDirectionVectorInfo,
				Value = _igravitydirectionvectorinfo
			};
		}

		// Token: 0x0602BDF2 RID: 179698 RVA: 0x005F720B File Offset: 0x005F540B
		public IGravityDirectionWorldAxisT AsIGravityDirectionWorldAxis()
		{
			return this.As<IGravityDirectionWorldAxisT>();
		}

		// Token: 0x0602BDF3 RID: 179699 RVA: 0x005F7213 File Offset: 0x005F5413
		public static TGravityDirectionUnion FromIGravityDirectionWorldAxis(IGravityDirectionWorldAxisT _igravitydirectionworldaxis)
		{
			return new TGravityDirectionUnion
			{
				Type = TGravityDirection.IGravityDirectionWorldAxis,
				Value = _igravitydirectionworldaxis
			};
		}

		// Token: 0x0602BDF4 RID: 179700 RVA: 0x005F7228 File Offset: 0x005F5428
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
