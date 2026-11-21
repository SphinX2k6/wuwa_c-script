using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E43 RID: 28227
	public class IFireBulletType_UnionUnion
	{
		// Token: 0x1700CEE6 RID: 52966
		// (get) Token: 0x06030C15 RID: 199701 RVA: 0x0069E111 File Offset: 0x0069C311
		// (set) Token: 0x06030C16 RID: 199702 RVA: 0x0069E119 File Offset: 0x0069C319
		public IFireBulletType_Union Type { get; set; }

		// Token: 0x1700CEE7 RID: 52967
		// (get) Token: 0x06030C17 RID: 199703 RVA: 0x0069E122 File Offset: 0x0069C322
		// (set) Token: 0x06030C18 RID: 199704 RVA: 0x0069E12A File Offset: 0x0069C32A
		public object Value { get; set; }

		// Token: 0x06030C19 RID: 199705 RVA: 0x0069E133 File Offset: 0x0069C333
		public IFireBulletType_UnionUnion()
		{
			this.Type = IFireBulletType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030C1A RID: 199706 RVA: 0x0069E149 File Offset: 0x0069C349
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030C1B RID: 199707 RVA: 0x0069E15B File Offset: 0x0069C35B
		public IFireBulletTypeT AsIFireBulletType()
		{
			return this.As<IFireBulletTypeT>();
		}

		// Token: 0x06030C1C RID: 199708 RVA: 0x0069E163 File Offset: 0x0069C363
		public static IFireBulletType_UnionUnion FromIFireBulletType(IFireBulletTypeT _ifirebullettype)
		{
			return new IFireBulletType_UnionUnion
			{
				Type = IFireBulletType_Union.IFireBulletType,
				Value = _ifirebullettype
			};
		}

		// Token: 0x06030C1D RID: 199709 RVA: 0x0069E178 File Offset: 0x0069C378
		public IFireBulletTrackTargetT AsIFireBulletTrackTarget()
		{
			return this.As<IFireBulletTrackTargetT>();
		}

		// Token: 0x06030C1E RID: 199710 RVA: 0x0069E180 File Offset: 0x0069C380
		public static IFireBulletType_UnionUnion FromIFireBulletTrackTarget(IFireBulletTrackTargetT _ifirebullettracktarget)
		{
			return new IFireBulletType_UnionUnion
			{
				Type = IFireBulletType_Union.IFireBulletTrackTarget,
				Value = _ifirebullettracktarget
			};
		}

		// Token: 0x06030C1F RID: 199711 RVA: 0x0069E195 File Offset: 0x0069C395
		public IFireBulletForwardFrontT AsIFireBulletForwardFront()
		{
			return this.As<IFireBulletForwardFrontT>();
		}

		// Token: 0x06030C20 RID: 199712 RVA: 0x0069E19D File Offset: 0x0069C39D
		public static IFireBulletType_UnionUnion FromIFireBulletForwardFront(IFireBulletForwardFrontT _ifirebulletforwardfront)
		{
			return new IFireBulletType_UnionUnion
			{
				Type = IFireBulletType_Union.IFireBulletForwardFront,
				Value = _ifirebulletforwardfront
			};
		}

		// Token: 0x06030C21 RID: 199713 RVA: 0x0069E1B2 File Offset: 0x0069C3B2
		public IFireBulletTrackPositionT AsIFireBulletTrackPosition()
		{
			return this.As<IFireBulletTrackPositionT>();
		}

		// Token: 0x06030C22 RID: 199714 RVA: 0x0069E1BA File Offset: 0x0069C3BA
		public static IFireBulletType_UnionUnion FromIFireBulletTrackPosition(IFireBulletTrackPositionT _ifirebullettrackposition)
		{
			return new IFireBulletType_UnionUnion
			{
				Type = IFireBulletType_Union.IFireBulletTrackPosition,
				Value = _ifirebullettrackposition
			};
		}

		// Token: 0x06030C23 RID: 199715 RVA: 0x0069E1D0 File Offset: 0x0069C3D0
		public static int Pack(FlatBufferBuilder builder, IFireBulletType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFireBulletType_Union.IFireBulletType:
				return IFireBulletType.Pack(builder, _o.AsIFireBulletType()).Value;
			case IFireBulletType_Union.IFireBulletTrackTarget:
				return IFireBulletTrackTarget.Pack(builder, _o.AsIFireBulletTrackTarget()).Value;
			case IFireBulletType_Union.IFireBulletForwardFront:
				return IFireBulletForwardFront.Pack(builder, _o.AsIFireBulletForwardFront()).Value;
			case IFireBulletType_Union.IFireBulletTrackPosition:
				return IFireBulletTrackPosition.Pack(builder, _o.AsIFireBulletTrackPosition()).Value;
			default:
				return 0;
			}
		}
	}
}
