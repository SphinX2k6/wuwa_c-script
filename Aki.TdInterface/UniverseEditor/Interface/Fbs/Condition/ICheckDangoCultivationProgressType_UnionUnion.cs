using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049BF RID: 18879
	public class ICheckDangoCultivationProgressType_UnionUnion
	{
		// Token: 0x17008880 RID: 34944
		// (get) Token: 0x0601D790 RID: 120720 RVA: 0x00426D59 File Offset: 0x00424F59
		// (set) Token: 0x0601D791 RID: 120721 RVA: 0x00426D61 File Offset: 0x00424F61
		public ICheckDangoCultivationProgressType_Union Type { get; set; }

		// Token: 0x17008881 RID: 34945
		// (get) Token: 0x0601D792 RID: 120722 RVA: 0x00426D6A File Offset: 0x00424F6A
		// (set) Token: 0x0601D793 RID: 120723 RVA: 0x00426D72 File Offset: 0x00424F72
		public object Value { get; set; }

		// Token: 0x0601D794 RID: 120724 RVA: 0x00426D7B File Offset: 0x00424F7B
		public ICheckDangoCultivationProgressType_UnionUnion()
		{
			this.Type = ICheckDangoCultivationProgressType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601D795 RID: 120725 RVA: 0x00426D91 File Offset: 0x00424F91
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601D796 RID: 120726 RVA: 0x00426DA3 File Offset: 0x00424FA3
		public ICheckDangoCultivationProgressTypeT AsICheckDangoCultivationProgressType()
		{
			return this.As<ICheckDangoCultivationProgressTypeT>();
		}

		// Token: 0x0601D797 RID: 120727 RVA: 0x00426DAB File Offset: 0x00424FAB
		public static ICheckDangoCultivationProgressType_UnionUnion FromICheckDangoCultivationProgressType(ICheckDangoCultivationProgressTypeT _icheckdangocultivationprogresstype)
		{
			return new ICheckDangoCultivationProgressType_UnionUnion
			{
				Type = ICheckDangoCultivationProgressType_Union.ICheckDangoCultivationProgressType,
				Value = _icheckdangocultivationprogresstype
			};
		}

		// Token: 0x0601D798 RID: 120728 RVA: 0x00426DC0 File Offset: 0x00424FC0
		public ICountDangoOverTargetLevelT AsICountDangoOverTargetLevel()
		{
			return this.As<ICountDangoOverTargetLevelT>();
		}

		// Token: 0x0601D799 RID: 120729 RVA: 0x00426DC8 File Offset: 0x00424FC8
		public static ICheckDangoCultivationProgressType_UnionUnion FromICountDangoOverTargetLevel(ICountDangoOverTargetLevelT _icountdangoovertargetlevel)
		{
			return new ICheckDangoCultivationProgressType_UnionUnion
			{
				Type = ICheckDangoCultivationProgressType_Union.ICountDangoOverTargetLevel,
				Value = _icountdangoovertargetlevel
			};
		}

		// Token: 0x0601D79A RID: 120730 RVA: 0x00426DE0 File Offset: 0x00424FE0
		public static int Pack(FlatBufferBuilder builder, ICheckDangoCultivationProgressType_UnionUnion _o)
		{
			ICheckDangoCultivationProgressType_Union type = _o.Type;
			if (type == ICheckDangoCultivationProgressType_Union.ICheckDangoCultivationProgressType)
			{
				return ICheckDangoCultivationProgressType.Pack(builder, _o.AsICheckDangoCultivationProgressType()).Value;
			}
			if (type != ICheckDangoCultivationProgressType_Union.ICountDangoOverTargetLevel)
			{
				return 0;
			}
			return ICountDangoOverTargetLevel.Pack(builder, _o.AsICountDangoOverTargetLevel()).Value;
		}
	}
}
