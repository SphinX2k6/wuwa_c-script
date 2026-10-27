using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D2 RID: 30418
	public class TFireBulletUnion
	{
		// Token: 0x1700E625 RID: 58917
		// (get) Token: 0x0603750C RID: 226572 RVA: 0x0077E786 File Offset: 0x0077C986
		// (set) Token: 0x0603750D RID: 226573 RVA: 0x0077E78E File Offset: 0x0077C98E
		public TFireBullet Type { get; set; }

		// Token: 0x1700E626 RID: 58918
		// (get) Token: 0x0603750E RID: 226574 RVA: 0x0077E797 File Offset: 0x0077C997
		// (set) Token: 0x0603750F RID: 226575 RVA: 0x0077E79F File Offset: 0x0077C99F
		public object Value { get; set; }

		// Token: 0x06037510 RID: 226576 RVA: 0x0077E7A8 File Offset: 0x0077C9A8
		public TFireBulletUnion()
		{
			this.Type = TFireBullet.NONE;
			this.Value = null;
		}

		// Token: 0x06037511 RID: 226577 RVA: 0x0077E7BE File Offset: 0x0077C9BE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037512 RID: 226578 RVA: 0x0077E7D0 File Offset: 0x0077C9D0
		public IFireBulletForwardFrontT AsIFireBulletForwardFront()
		{
			return this.As<IFireBulletForwardFrontT>();
		}

		// Token: 0x06037513 RID: 226579 RVA: 0x0077E7D8 File Offset: 0x0077C9D8
		public static TFireBulletUnion FromIFireBulletForwardFront(IFireBulletForwardFrontT _ifirebulletforwardfront)
		{
			return new TFireBulletUnion
			{
				Type = TFireBullet.IFireBulletForwardFront,
				Value = _ifirebulletforwardfront
			};
		}

		// Token: 0x06037514 RID: 226580 RVA: 0x0077E7ED File Offset: 0x0077C9ED
		public IFireBulletTrackPositionT AsIFireBulletTrackPosition()
		{
			return this.As<IFireBulletTrackPositionT>();
		}

		// Token: 0x06037515 RID: 226581 RVA: 0x0077E7F5 File Offset: 0x0077C9F5
		public static TFireBulletUnion FromIFireBulletTrackPosition(IFireBulletTrackPositionT _ifirebullettrackposition)
		{
			return new TFireBulletUnion
			{
				Type = TFireBullet.IFireBulletTrackPosition,
				Value = _ifirebullettrackposition
			};
		}

		// Token: 0x06037516 RID: 226582 RVA: 0x0077E80A File Offset: 0x0077CA0A
		public IFireBulletTrackTargetT AsIFireBulletTrackTarget()
		{
			return this.As<IFireBulletTrackTargetT>();
		}

		// Token: 0x06037517 RID: 226583 RVA: 0x0077E812 File Offset: 0x0077CA12
		public static TFireBulletUnion FromIFireBulletTrackTarget(IFireBulletTrackTargetT _ifirebullettracktarget)
		{
			return new TFireBulletUnion
			{
				Type = TFireBullet.IFireBulletTrackTarget,
				Value = _ifirebullettracktarget
			};
		}

		// Token: 0x06037518 RID: 226584 RVA: 0x0077E828 File Offset: 0x0077CA28
		public static int Pack(FlatBufferBuilder builder, TFireBulletUnion _o)
		{
			switch (_o.Type)
			{
			case TFireBullet.IFireBulletForwardFront:
				return IFireBulletForwardFront.Pack(builder, _o.AsIFireBulletForwardFront()).Value;
			case TFireBullet.IFireBulletTrackPosition:
				return IFireBulletTrackPosition.Pack(builder, _o.AsIFireBulletTrackPosition()).Value;
			case TFireBullet.IFireBulletTrackTarget:
				return IFireBulletTrackTarget.Pack(builder, _o.AsIFireBulletTrackTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
