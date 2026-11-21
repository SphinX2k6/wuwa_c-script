using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007990 RID: 31120
	public class IStartSlidePerformType_UnionUnion
	{
		// Token: 0x1700E42F RID: 58415
		// (get) Token: 0x06036D00 RID: 224512 RVA: 0x00754E2D File Offset: 0x0075302D
		// (set) Token: 0x06036D01 RID: 224513 RVA: 0x00754E35 File Offset: 0x00753035
		public IStartSlidePerformType_Union Type { get; set; }

		// Token: 0x1700E430 RID: 58416
		// (get) Token: 0x06036D02 RID: 224514 RVA: 0x00754E3E File Offset: 0x0075303E
		// (set) Token: 0x06036D03 RID: 224515 RVA: 0x00754E46 File Offset: 0x00753046
		public object Value { get; set; }

		// Token: 0x06036D04 RID: 224516 RVA: 0x00754E4F File Offset: 0x0075304F
		public IStartSlidePerformType_UnionUnion()
		{
			this.Type = IStartSlidePerformType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036D05 RID: 224517 RVA: 0x00754E65 File Offset: 0x00753065
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036D06 RID: 224518 RVA: 0x00754E77 File Offset: 0x00753077
		public IStartSlidePerformTypeT AsIStartSlidePerformType()
		{
			return this.As<IStartSlidePerformTypeT>();
		}

		// Token: 0x06036D07 RID: 224519 RVA: 0x00754E7F File Offset: 0x0075307F
		public static IStartSlidePerformType_UnionUnion FromIStartSlidePerformType(IStartSlidePerformTypeT _istartslideperformtype)
		{
			return new IStartSlidePerformType_UnionUnion
			{
				Type = IStartSlidePerformType_Union.IStartSlidePerformType,
				Value = _istartslideperformtype
			};
		}

		// Token: 0x06036D08 RID: 224520 RVA: 0x00754E94 File Offset: 0x00753094
		public ISlopeSlidePerformStartT AsISlopeSlidePerformStart()
		{
			return this.As<ISlopeSlidePerformStartT>();
		}

		// Token: 0x06036D09 RID: 224521 RVA: 0x00754E9C File Offset: 0x0075309C
		public static IStartSlidePerformType_UnionUnion FromISlopeSlidePerformStart(ISlopeSlidePerformStartT _islopeslideperformstart)
		{
			return new IStartSlidePerformType_UnionUnion
			{
				Type = IStartSlidePerformType_Union.ISlopeSlidePerformStart,
				Value = _islopeslideperformstart
			};
		}

		// Token: 0x06036D0A RID: 224522 RVA: 0x00754EB4 File Offset: 0x007530B4
		public static int Pack(FlatBufferBuilder builder, IStartSlidePerformType_UnionUnion _o)
		{
			IStartSlidePerformType_Union type = _o.Type;
			if (type == IStartSlidePerformType_Union.IStartSlidePerformType)
			{
				return IStartSlidePerformType.Pack(builder, _o.AsIStartSlidePerformType()).Value;
			}
			if (type != IStartSlidePerformType_Union.ISlopeSlidePerformStart)
			{
				return 0;
			}
			return ISlopeSlidePerformStart.Pack(builder, _o.AsISlopeSlidePerformStart()).Value;
		}
	}
}
