using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E79 RID: 20089
	public class ICheckDangoCultivationProgressType_UnionUnion
	{
		// Token: 0x17008F42 RID: 36674
		// (get) Token: 0x0601F1CF RID: 127439 RVA: 0x004574A1 File Offset: 0x004556A1
		// (set) Token: 0x0601F1D0 RID: 127440 RVA: 0x004574A9 File Offset: 0x004556A9
		public ICheckDangoCultivationProgressType_Union Type { get; set; }

		// Token: 0x17008F43 RID: 36675
		// (get) Token: 0x0601F1D1 RID: 127441 RVA: 0x004574B2 File Offset: 0x004556B2
		// (set) Token: 0x0601F1D2 RID: 127442 RVA: 0x004574BA File Offset: 0x004556BA
		public object Value { get; set; }

		// Token: 0x0601F1D3 RID: 127443 RVA: 0x004574C3 File Offset: 0x004556C3
		public ICheckDangoCultivationProgressType_UnionUnion()
		{
			this.Type = ICheckDangoCultivationProgressType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F1D4 RID: 127444 RVA: 0x004574D9 File Offset: 0x004556D9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F1D5 RID: 127445 RVA: 0x004574EB File Offset: 0x004556EB
		public ICheckDangoCultivationProgressTypeT AsICheckDangoCultivationProgressType()
		{
			return this.As<ICheckDangoCultivationProgressTypeT>();
		}

		// Token: 0x0601F1D6 RID: 127446 RVA: 0x004574F3 File Offset: 0x004556F3
		public static ICheckDangoCultivationProgressType_UnionUnion FromICheckDangoCultivationProgressType(ICheckDangoCultivationProgressTypeT _icheckdangocultivationprogresstype)
		{
			return new ICheckDangoCultivationProgressType_UnionUnion
			{
				Type = ICheckDangoCultivationProgressType_Union.ICheckDangoCultivationProgressType,
				Value = _icheckdangocultivationprogresstype
			};
		}

		// Token: 0x0601F1D7 RID: 127447 RVA: 0x00457508 File Offset: 0x00455708
		public ICountDangoOverTargetLevelT AsICountDangoOverTargetLevel()
		{
			return this.As<ICountDangoOverTargetLevelT>();
		}

		// Token: 0x0601F1D8 RID: 127448 RVA: 0x00457510 File Offset: 0x00455710
		public static ICheckDangoCultivationProgressType_UnionUnion FromICountDangoOverTargetLevel(ICountDangoOverTargetLevelT _icountdangoovertargetlevel)
		{
			return new ICheckDangoCultivationProgressType_UnionUnion
			{
				Type = ICheckDangoCultivationProgressType_Union.ICountDangoOverTargetLevel,
				Value = _icountdangoovertargetlevel
			};
		}

		// Token: 0x0601F1D9 RID: 127449 RVA: 0x00457528 File Offset: 0x00455728
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
