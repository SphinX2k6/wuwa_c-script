using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C3 RID: 26563
	public class IFireBulletType_UnionUnion
	{
		// Token: 0x1700C530 RID: 50480
		// (get) Token: 0x0602E3CF RID: 189391 RVA: 0x006509CD File Offset: 0x0064EBCD
		// (set) Token: 0x0602E3D0 RID: 189392 RVA: 0x006509D5 File Offset: 0x0064EBD5
		public IFireBulletType_Union Type { get; set; }

		// Token: 0x1700C531 RID: 50481
		// (get) Token: 0x0602E3D1 RID: 189393 RVA: 0x006509DE File Offset: 0x0064EBDE
		// (set) Token: 0x0602E3D2 RID: 189394 RVA: 0x006509E6 File Offset: 0x0064EBE6
		public object Value { get; set; }

		// Token: 0x0602E3D3 RID: 189395 RVA: 0x006509EF File Offset: 0x0064EBEF
		public IFireBulletType_UnionUnion()
		{
			this.Type = IFireBulletType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E3D4 RID: 189396 RVA: 0x00650A05 File Offset: 0x0064EC05
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E3D5 RID: 189397 RVA: 0x00650A17 File Offset: 0x0064EC17
		public IFireBulletTypeT AsIFireBulletType()
		{
			return this.As<IFireBulletTypeT>();
		}

		// Token: 0x0602E3D6 RID: 189398 RVA: 0x00650A1F File Offset: 0x0064EC1F
		public static IFireBulletType_UnionUnion FromIFireBulletType(IFireBulletTypeT _ifirebullettype)
		{
			return new IFireBulletType_UnionUnion
			{
				Type = IFireBulletType_Union.IFireBulletType,
				Value = _ifirebullettype
			};
		}

		// Token: 0x0602E3D7 RID: 189399 RVA: 0x00650A34 File Offset: 0x0064EC34
		public IFireBulletTrackTargetT AsIFireBulletTrackTarget()
		{
			return this.As<IFireBulletTrackTargetT>();
		}

		// Token: 0x0602E3D8 RID: 189400 RVA: 0x00650A3C File Offset: 0x0064EC3C
		public static IFireBulletType_UnionUnion FromIFireBulletTrackTarget(IFireBulletTrackTargetT _ifirebullettracktarget)
		{
			return new IFireBulletType_UnionUnion
			{
				Type = IFireBulletType_Union.IFireBulletTrackTarget,
				Value = _ifirebullettracktarget
			};
		}

		// Token: 0x0602E3D9 RID: 189401 RVA: 0x00650A51 File Offset: 0x0064EC51
		public IFireBulletForwardFrontT AsIFireBulletForwardFront()
		{
			return this.As<IFireBulletForwardFrontT>();
		}

		// Token: 0x0602E3DA RID: 189402 RVA: 0x00650A59 File Offset: 0x0064EC59
		public static IFireBulletType_UnionUnion FromIFireBulletForwardFront(IFireBulletForwardFrontT _ifirebulletforwardfront)
		{
			return new IFireBulletType_UnionUnion
			{
				Type = IFireBulletType_Union.IFireBulletForwardFront,
				Value = _ifirebulletforwardfront
			};
		}

		// Token: 0x0602E3DB RID: 189403 RVA: 0x00650A6E File Offset: 0x0064EC6E
		public IFireBulletTrackPositionT AsIFireBulletTrackPosition()
		{
			return this.As<IFireBulletTrackPositionT>();
		}

		// Token: 0x0602E3DC RID: 189404 RVA: 0x00650A76 File Offset: 0x0064EC76
		public static IFireBulletType_UnionUnion FromIFireBulletTrackPosition(IFireBulletTrackPositionT _ifirebullettrackposition)
		{
			return new IFireBulletType_UnionUnion
			{
				Type = IFireBulletType_Union.IFireBulletTrackPosition,
				Value = _ifirebullettrackposition
			};
		}

		// Token: 0x0602E3DD RID: 189405 RVA: 0x00650A8C File Offset: 0x0064EC8C
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
