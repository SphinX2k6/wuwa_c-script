using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062F5 RID: 25333
	public class TThrowMotionUnion
	{
		// Token: 0x1700BBBA RID: 48058
		// (get) Token: 0x0602B0A5 RID: 176293 RVA: 0x005DE376 File Offset: 0x005DC576
		// (set) Token: 0x0602B0A6 RID: 176294 RVA: 0x005DE37E File Offset: 0x005DC57E
		public TThrowMotion Type { get; set; }

		// Token: 0x1700BBBB RID: 48059
		// (get) Token: 0x0602B0A7 RID: 176295 RVA: 0x005DE387 File Offset: 0x005DC587
		// (set) Token: 0x0602B0A8 RID: 176296 RVA: 0x005DE38F File Offset: 0x005DC58F
		public object Value { get; set; }

		// Token: 0x0602B0A9 RID: 176297 RVA: 0x005DE398 File Offset: 0x005DC598
		public TThrowMotionUnion()
		{
			this.Type = TThrowMotion.NONE;
			this.Value = null;
		}

		// Token: 0x0602B0AA RID: 176298 RVA: 0x005DE3AE File Offset: 0x005DC5AE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B0AB RID: 176299 RVA: 0x005DE3C0 File Offset: 0x005DC5C0
		public ICircumnutationT AsICircumnutation()
		{
			return this.As<ICircumnutationT>();
		}

		// Token: 0x0602B0AC RID: 176300 RVA: 0x005DE3C8 File Offset: 0x005DC5C8
		public static TThrowMotionUnion FromICircumnutation(ICircumnutationT _icircumnutation)
		{
			return new TThrowMotionUnion
			{
				Type = TThrowMotion.ICircumnutation,
				Value = _icircumnutation
			};
		}

		// Token: 0x0602B0AD RID: 176301 RVA: 0x005DE3DD File Offset: 0x005DC5DD
		public IProjectileMotionT AsIProjectileMotion()
		{
			return this.As<IProjectileMotionT>();
		}

		// Token: 0x0602B0AE RID: 176302 RVA: 0x005DE3E5 File Offset: 0x005DC5E5
		public static TThrowMotionUnion FromIProjectileMotion(IProjectileMotionT _iprojectilemotion)
		{
			return new TThrowMotionUnion
			{
				Type = TThrowMotion.IProjectileMotion,
				Value = _iprojectilemotion
			};
		}

		// Token: 0x0602B0AF RID: 176303 RVA: 0x005DE3FA File Offset: 0x005DC5FA
		public IThrowMotionFreeFallT AsIThrowMotionFreeFall()
		{
			return this.As<IThrowMotionFreeFallT>();
		}

		// Token: 0x0602B0B0 RID: 176304 RVA: 0x005DE402 File Offset: 0x005DC602
		public static TThrowMotionUnion FromIThrowMotionFreeFall(IThrowMotionFreeFallT _ithrowmotionfreefall)
		{
			return new TThrowMotionUnion
			{
				Type = TThrowMotion.IThrowMotionFreeFall,
				Value = _ithrowmotionfreefall
			};
		}

		// Token: 0x0602B0B1 RID: 176305 RVA: 0x005DE417 File Offset: 0x005DC617
		public IThrowMotionLevitateT AsIThrowMotionLevitate()
		{
			return this.As<IThrowMotionLevitateT>();
		}

		// Token: 0x0602B0B2 RID: 176306 RVA: 0x005DE41F File Offset: 0x005DC61F
		public static TThrowMotionUnion FromIThrowMotionLevitate(IThrowMotionLevitateT _ithrowmotionlevitate)
		{
			return new TThrowMotionUnion
			{
				Type = TThrowMotion.IThrowMotionLevitate,
				Value = _ithrowmotionlevitate
			};
		}

		// Token: 0x0602B0B3 RID: 176307 RVA: 0x005DE434 File Offset: 0x005DC634
		public IThrowMotionTrackTargetT AsIThrowMotionTrackTarget()
		{
			return this.As<IThrowMotionTrackTargetT>();
		}

		// Token: 0x0602B0B4 RID: 176308 RVA: 0x005DE43C File Offset: 0x005DC63C
		public static TThrowMotionUnion FromIThrowMotionTrackTarget(IThrowMotionTrackTargetT _ithrowmotiontracktarget)
		{
			return new TThrowMotionUnion
			{
				Type = TThrowMotion.IThrowMotionTrackTarget,
				Value = _ithrowmotiontracktarget
			};
		}

		// Token: 0x0602B0B5 RID: 176309 RVA: 0x005DE454 File Offset: 0x005DC654
		public static int Pack(FlatBufferBuilder builder, TThrowMotionUnion _o)
		{
			switch (_o.Type)
			{
			case TThrowMotion.ICircumnutation:
				return ICircumnutation.Pack(builder, _o.AsICircumnutation()).Value;
			case TThrowMotion.IProjectileMotion:
				return IProjectileMotion.Pack(builder, _o.AsIProjectileMotion()).Value;
			case TThrowMotion.IThrowMotionFreeFall:
				return IThrowMotionFreeFall.Pack(builder, _o.AsIThrowMotionFreeFall()).Value;
			case TThrowMotion.IThrowMotionLevitate:
				return IThrowMotionLevitate.Pack(builder, _o.AsIThrowMotionLevitate()).Value;
			case TThrowMotion.IThrowMotionTrackTarget:
				return IThrowMotionTrackTarget.Pack(builder, _o.AsIThrowMotionTrackTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
