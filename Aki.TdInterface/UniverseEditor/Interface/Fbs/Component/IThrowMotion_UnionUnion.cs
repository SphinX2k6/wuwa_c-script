using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006081 RID: 24705
	public class IThrowMotion_UnionUnion
	{
		// Token: 0x1700B787 RID: 46983
		// (get) Token: 0x06029C1D RID: 171037 RVA: 0x005B37AB File Offset: 0x005B19AB
		// (set) Token: 0x06029C1E RID: 171038 RVA: 0x005B37B3 File Offset: 0x005B19B3
		public IThrowMotion_Union Type { get; set; }

		// Token: 0x1700B788 RID: 46984
		// (get) Token: 0x06029C1F RID: 171039 RVA: 0x005B37BC File Offset: 0x005B19BC
		// (set) Token: 0x06029C20 RID: 171040 RVA: 0x005B37C4 File Offset: 0x005B19C4
		public object Value { get; set; }

		// Token: 0x06029C21 RID: 171041 RVA: 0x005B37CD File Offset: 0x005B19CD
		public IThrowMotion_UnionUnion()
		{
			this.Type = IThrowMotion_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029C22 RID: 171042 RVA: 0x005B37E3 File Offset: 0x005B19E3
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029C23 RID: 171043 RVA: 0x005B37F5 File Offset: 0x005B19F5
		public IThrowMotionT AsIThrowMotion()
		{
			return this.As<IThrowMotionT>();
		}

		// Token: 0x06029C24 RID: 171044 RVA: 0x005B37FD File Offset: 0x005B19FD
		public static IThrowMotion_UnionUnion FromIThrowMotion(IThrowMotionT _ithrowmotion)
		{
			return new IThrowMotion_UnionUnion
			{
				Type = IThrowMotion_Union.IThrowMotion,
				Value = _ithrowmotion
			};
		}

		// Token: 0x06029C25 RID: 171045 RVA: 0x005B3812 File Offset: 0x005B1A12
		public IProjectileMotionT AsIProjectileMotion()
		{
			return this.As<IProjectileMotionT>();
		}

		// Token: 0x06029C26 RID: 171046 RVA: 0x005B381A File Offset: 0x005B1A1A
		public static IThrowMotion_UnionUnion FromIProjectileMotion(IProjectileMotionT _iprojectilemotion)
		{
			return new IThrowMotion_UnionUnion
			{
				Type = IThrowMotion_Union.IProjectileMotion,
				Value = _iprojectilemotion
			};
		}

		// Token: 0x06029C27 RID: 171047 RVA: 0x005B382F File Offset: 0x005B1A2F
		public ICircumnutationT AsICircumnutation()
		{
			return this.As<ICircumnutationT>();
		}

		// Token: 0x06029C28 RID: 171048 RVA: 0x005B3837 File Offset: 0x005B1A37
		public static IThrowMotion_UnionUnion FromICircumnutation(ICircumnutationT _icircumnutation)
		{
			return new IThrowMotion_UnionUnion
			{
				Type = IThrowMotion_Union.ICircumnutation,
				Value = _icircumnutation
			};
		}

		// Token: 0x06029C29 RID: 171049 RVA: 0x005B384C File Offset: 0x005B1A4C
		public IThrowMotionTrackTargetT AsIThrowMotionTrackTarget()
		{
			return this.As<IThrowMotionTrackTargetT>();
		}

		// Token: 0x06029C2A RID: 171050 RVA: 0x005B3854 File Offset: 0x005B1A54
		public static IThrowMotion_UnionUnion FromIThrowMotionTrackTarget(IThrowMotionTrackTargetT _ithrowmotiontracktarget)
		{
			return new IThrowMotion_UnionUnion
			{
				Type = IThrowMotion_Union.IThrowMotionTrackTarget,
				Value = _ithrowmotiontracktarget
			};
		}

		// Token: 0x06029C2B RID: 171051 RVA: 0x005B3869 File Offset: 0x005B1A69
		public IThrowMotionLevitateT AsIThrowMotionLevitate()
		{
			return this.As<IThrowMotionLevitateT>();
		}

		// Token: 0x06029C2C RID: 171052 RVA: 0x005B3871 File Offset: 0x005B1A71
		public static IThrowMotion_UnionUnion FromIThrowMotionLevitate(IThrowMotionLevitateT _ithrowmotionlevitate)
		{
			return new IThrowMotion_UnionUnion
			{
				Type = IThrowMotion_Union.IThrowMotionLevitate,
				Value = _ithrowmotionlevitate
			};
		}

		// Token: 0x06029C2D RID: 171053 RVA: 0x005B3886 File Offset: 0x005B1A86
		public IThrowMotionFreeFallT AsIThrowMotionFreeFall()
		{
			return this.As<IThrowMotionFreeFallT>();
		}

		// Token: 0x06029C2E RID: 171054 RVA: 0x005B388E File Offset: 0x005B1A8E
		public static IThrowMotion_UnionUnion FromIThrowMotionFreeFall(IThrowMotionFreeFallT _ithrowmotionfreefall)
		{
			return new IThrowMotion_UnionUnion
			{
				Type = IThrowMotion_Union.IThrowMotionFreeFall,
				Value = _ithrowmotionfreefall
			};
		}

		// Token: 0x06029C2F RID: 171055 RVA: 0x005B38A4 File Offset: 0x005B1AA4
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
