using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A74 RID: 23156
	public class IThrowMotion_UnionUnion
	{
		// Token: 0x1700AE4F RID: 44623
		// (get) Token: 0x060276A5 RID: 161445 RVA: 0x0056C79F File Offset: 0x0056A99F
		// (set) Token: 0x060276A6 RID: 161446 RVA: 0x0056C7A7 File Offset: 0x0056A9A7
		public IThrowMotion_Union Type { get; set; }

		// Token: 0x1700AE50 RID: 44624
		// (get) Token: 0x060276A7 RID: 161447 RVA: 0x0056C7B0 File Offset: 0x0056A9B0
		// (set) Token: 0x060276A8 RID: 161448 RVA: 0x0056C7B8 File Offset: 0x0056A9B8
		public object Value { get; set; }

		// Token: 0x060276A9 RID: 161449 RVA: 0x0056C7C1 File Offset: 0x0056A9C1
		public IThrowMotion_UnionUnion()
		{
			this.Type = IThrowMotion_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060276AA RID: 161450 RVA: 0x0056C7D7 File Offset: 0x0056A9D7
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060276AB RID: 161451 RVA: 0x0056C7E9 File Offset: 0x0056A9E9
		public IThrowMotionT AsIThrowMotion()
		{
			return this.As<IThrowMotionT>();
		}

		// Token: 0x060276AC RID: 161452 RVA: 0x0056C7F1 File Offset: 0x0056A9F1
		public static IThrowMotion_UnionUnion FromIThrowMotion(IThrowMotionT _ithrowmotion)
		{
			return new IThrowMotion_UnionUnion
			{
				Type = IThrowMotion_Union.IThrowMotion,
				Value = _ithrowmotion
			};
		}

		// Token: 0x060276AD RID: 161453 RVA: 0x0056C806 File Offset: 0x0056AA06
		public IProjectileMotionT AsIProjectileMotion()
		{
			return this.As<IProjectileMotionT>();
		}

		// Token: 0x060276AE RID: 161454 RVA: 0x0056C80E File Offset: 0x0056AA0E
		public static IThrowMotion_UnionUnion FromIProjectileMotion(IProjectileMotionT _iprojectilemotion)
		{
			return new IThrowMotion_UnionUnion
			{
				Type = IThrowMotion_Union.IProjectileMotion,
				Value = _iprojectilemotion
			};
		}

		// Token: 0x060276AF RID: 161455 RVA: 0x0056C823 File Offset: 0x0056AA23
		public ICircumnutationT AsICircumnutation()
		{
			return this.As<ICircumnutationT>();
		}

		// Token: 0x060276B0 RID: 161456 RVA: 0x0056C82B File Offset: 0x0056AA2B
		public static IThrowMotion_UnionUnion FromICircumnutation(ICircumnutationT _icircumnutation)
		{
			return new IThrowMotion_UnionUnion
			{
				Type = IThrowMotion_Union.ICircumnutation,
				Value = _icircumnutation
			};
		}

		// Token: 0x060276B1 RID: 161457 RVA: 0x0056C840 File Offset: 0x0056AA40
		public IThrowMotionTrackTargetT AsIThrowMotionTrackTarget()
		{
			return this.As<IThrowMotionTrackTargetT>();
		}

		// Token: 0x060276B2 RID: 161458 RVA: 0x0056C848 File Offset: 0x0056AA48
		public static IThrowMotion_UnionUnion FromIThrowMotionTrackTarget(IThrowMotionTrackTargetT _ithrowmotiontracktarget)
		{
			return new IThrowMotion_UnionUnion
			{
				Type = IThrowMotion_Union.IThrowMotionTrackTarget,
				Value = _ithrowmotiontracktarget
			};
		}

		// Token: 0x060276B3 RID: 161459 RVA: 0x0056C85D File Offset: 0x0056AA5D
		public IThrowMotionLevitateT AsIThrowMotionLevitate()
		{
			return this.As<IThrowMotionLevitateT>();
		}

		// Token: 0x060276B4 RID: 161460 RVA: 0x0056C865 File Offset: 0x0056AA65
		public static IThrowMotion_UnionUnion FromIThrowMotionLevitate(IThrowMotionLevitateT _ithrowmotionlevitate)
		{
			return new IThrowMotion_UnionUnion
			{
				Type = IThrowMotion_Union.IThrowMotionLevitate,
				Value = _ithrowmotionlevitate
			};
		}

		// Token: 0x060276B5 RID: 161461 RVA: 0x0056C87A File Offset: 0x0056AA7A
		public IThrowMotionFreeFallT AsIThrowMotionFreeFall()
		{
			return this.As<IThrowMotionFreeFallT>();
		}

		// Token: 0x060276B6 RID: 161462 RVA: 0x0056C882 File Offset: 0x0056AA82
		public static IThrowMotion_UnionUnion FromIThrowMotionFreeFall(IThrowMotionFreeFallT _ithrowmotionfreefall)
		{
			return new IThrowMotion_UnionUnion
			{
				Type = IThrowMotion_Union.IThrowMotionFreeFall,
				Value = _ithrowmotionfreefall
			};
		}

		// Token: 0x060276B7 RID: 161463 RVA: 0x0056C898 File Offset: 0x0056AA98
		public static int Pack(FlatBufferBuilder builder, IThrowMotion_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IThrowMotion_Union.IThrowMotion:
				return IThrowMotion.Pack(builder, _o.AsIThrowMotion()).Value;
			case IThrowMotion_Union.IProjectileMotion:
				return IProjectileMotion.Pack(builder, _o.AsIProjectileMotion()).Value;
			case IThrowMotion_Union.ICircumnutation:
				return ICircumnutation.Pack(builder, _o.AsICircumnutation()).Value;
			case IThrowMotion_Union.IThrowMotionTrackTarget:
				return IThrowMotionTrackTarget.Pack(builder, _o.AsIThrowMotionTrackTarget()).Value;
			case IThrowMotion_Union.IThrowMotionLevitate:
				return IThrowMotionLevitate.Pack(builder, _o.AsIThrowMotionLevitate()).Value;
			case IThrowMotion_Union.IThrowMotionFreeFall:
				return IThrowMotionFreeFall.Pack(builder, _o.AsIThrowMotionFreeFall()).Value;
			default:
				return 0;
			}
		}
	}
}
