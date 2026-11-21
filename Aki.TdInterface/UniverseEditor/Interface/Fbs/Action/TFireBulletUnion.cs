using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EE0 RID: 32480
	public class TFireBulletUnion
	{
		// Token: 0x1700F263 RID: 62051
		// (get) Token: 0x0603A9C1 RID: 240065 RVA: 0x007E2A9A File Offset: 0x007E0C9A
		// (set) Token: 0x0603A9C2 RID: 240066 RVA: 0x007E2AA2 File Offset: 0x007E0CA2
		public TFireBullet Type { get; set; }

		// Token: 0x1700F264 RID: 62052
		// (get) Token: 0x0603A9C3 RID: 240067 RVA: 0x007E2AAB File Offset: 0x007E0CAB
		// (set) Token: 0x0603A9C4 RID: 240068 RVA: 0x007E2AB3 File Offset: 0x007E0CB3
		public object Value { get; set; }

		// Token: 0x0603A9C5 RID: 240069 RVA: 0x007E2ABC File Offset: 0x007E0CBC
		public TFireBulletUnion()
		{
			this.Type = TFireBullet.NONE;
			this.Value = null;
		}

		// Token: 0x0603A9C6 RID: 240070 RVA: 0x007E2AD2 File Offset: 0x007E0CD2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A9C7 RID: 240071 RVA: 0x007E2AE4 File Offset: 0x007E0CE4
		public IFireBulletForwardFrontT AsIFireBulletForwardFront()
		{
			return this.As<IFireBulletForwardFrontT>();
		}

		// Token: 0x0603A9C8 RID: 240072 RVA: 0x007E2AEC File Offset: 0x007E0CEC
		public static TFireBulletUnion FromIFireBulletForwardFront(IFireBulletForwardFrontT _ifirebulletforwardfront)
		{
			return new TFireBulletUnion
			{
				Type = TFireBullet.IFireBulletForwardFront,
				Value = _ifirebulletforwardfront
			};
		}

		// Token: 0x0603A9C9 RID: 240073 RVA: 0x007E2B01 File Offset: 0x007E0D01
		public IFireBulletTrackPositionT AsIFireBulletTrackPosition()
		{
			return this.As<IFireBulletTrackPositionT>();
		}

		// Token: 0x0603A9CA RID: 240074 RVA: 0x007E2B09 File Offset: 0x007E0D09
		public static TFireBulletUnion FromIFireBulletTrackPosition(IFireBulletTrackPositionT _ifirebullettrackposition)
		{
			return new TFireBulletUnion
			{
				Type = TFireBullet.IFireBulletTrackPosition,
				Value = _ifirebullettrackposition
			};
		}

		// Token: 0x0603A9CB RID: 240075 RVA: 0x007E2B1E File Offset: 0x007E0D1E
		public IFireBulletTrackTargetT AsIFireBulletTrackTarget()
		{
			return this.As<IFireBulletTrackTargetT>();
		}

		// Token: 0x0603A9CC RID: 240076 RVA: 0x007E2B26 File Offset: 0x007E0D26
		public static TFireBulletUnion FromIFireBulletTrackTarget(IFireBulletTrackTargetT _ifirebullettracktarget)
		{
			return new TFireBulletUnion
			{
				Type = TFireBullet.IFireBulletTrackTarget,
				Value = _ifirebullettracktarget
			};
		}

		// Token: 0x0603A9CD RID: 240077 RVA: 0x007E2B3C File Offset: 0x007E0D3C
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
