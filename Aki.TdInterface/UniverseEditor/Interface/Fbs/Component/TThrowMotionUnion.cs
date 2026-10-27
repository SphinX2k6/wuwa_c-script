using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CC4 RID: 23748
	public class TThrowMotionUnion
	{
		// Token: 0x1700B260 RID: 45664
		// (get) Token: 0x06028A5D RID: 166493 RVA: 0x00595C02 File Offset: 0x00593E02
		// (set) Token: 0x06028A5E RID: 166494 RVA: 0x00595C0A File Offset: 0x00593E0A
		public TThrowMotion Type { get; set; }

		// Token: 0x1700B261 RID: 45665
		// (get) Token: 0x06028A5F RID: 166495 RVA: 0x00595C13 File Offset: 0x00593E13
		// (set) Token: 0x06028A60 RID: 166496 RVA: 0x00595C1B File Offset: 0x00593E1B
		public object Value { get; set; }

		// Token: 0x06028A61 RID: 166497 RVA: 0x00595C24 File Offset: 0x00593E24
		public TThrowMotionUnion()
		{
			this.Type = TThrowMotion.NONE;
			this.Value = null;
		}

		// Token: 0x06028A62 RID: 166498 RVA: 0x00595C3A File Offset: 0x00593E3A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028A63 RID: 166499 RVA: 0x00595C4C File Offset: 0x00593E4C
		public ICircumnutationT AsICircumnutation()
		{
			return this.As<ICircumnutationT>();
		}

		// Token: 0x06028A64 RID: 166500 RVA: 0x00595C54 File Offset: 0x00593E54
		public static TThrowMotionUnion FromICircumnutation(ICircumnutationT _icircumnutation)
		{
			return new TThrowMotionUnion
			{
				Type = TThrowMotion.ICircumnutation,
				Value = _icircumnutation
			};
		}

		// Token: 0x06028A65 RID: 166501 RVA: 0x00595C69 File Offset: 0x00593E69
		public IProjectileMotionT AsIProjectileMotion()
		{
			return this.As<IProjectileMotionT>();
		}

		// Token: 0x06028A66 RID: 166502 RVA: 0x00595C71 File Offset: 0x00593E71
		public static TThrowMotionUnion FromIProjectileMotion(IProjectileMotionT _iprojectilemotion)
		{
			return new TThrowMotionUnion
			{
				Type = TThrowMotion.IProjectileMotion,
				Value = _iprojectilemotion
			};
		}

		// Token: 0x06028A67 RID: 166503 RVA: 0x00595C86 File Offset: 0x00593E86
		public IThrowMotionFreeFallT AsIThrowMotionFreeFall()
		{
			return this.As<IThrowMotionFreeFallT>();
		}

		// Token: 0x06028A68 RID: 166504 RVA: 0x00595C8E File Offset: 0x00593E8E
		public static TThrowMotionUnion FromIThrowMotionFreeFall(IThrowMotionFreeFallT _ithrowmotionfreefall)
		{
			return new TThrowMotionUnion
			{
				Type = TThrowMotion.IThrowMotionFreeFall,
				Value = _ithrowmotionfreefall
			};
		}

		// Token: 0x06028A69 RID: 166505 RVA: 0x00595CA3 File Offset: 0x00593EA3
		public IThrowMotionLevitateT AsIThrowMotionLevitate()
		{
			return this.As<IThrowMotionLevitateT>();
		}

		// Token: 0x06028A6A RID: 166506 RVA: 0x00595CAB File Offset: 0x00593EAB
		public static TThrowMotionUnion FromIThrowMotionLevitate(IThrowMotionLevitateT _ithrowmotionlevitate)
		{
			return new TThrowMotionUnion
			{
				Type = TThrowMotion.IThrowMotionLevitate,
				Value = _ithrowmotionlevitate
			};
		}

		// Token: 0x06028A6B RID: 166507 RVA: 0x00595CC0 File Offset: 0x00593EC0
		public IThrowMotionTrackTargetT AsIThrowMotionTrackTarget()
		{
			return this.As<IThrowMotionTrackTargetT>();
		}

		// Token: 0x06028A6C RID: 166508 RVA: 0x00595CC8 File Offset: 0x00593EC8
		public static TThrowMotionUnion FromIThrowMotionTrackTarget(IThrowMotionTrackTargetT _ithrowmotiontracktarget)
		{
			return new TThrowMotionUnion
			{
				Type = TThrowMotion.IThrowMotionTrackTarget,
				Value = _ithrowmotiontracktarget
			};
		}

		// Token: 0x06028A6D RID: 166509 RVA: 0x00595CE0 File Offset: 0x00593EE0
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
