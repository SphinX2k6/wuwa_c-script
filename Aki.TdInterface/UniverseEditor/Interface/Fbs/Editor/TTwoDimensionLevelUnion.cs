using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048F4 RID: 18676
	public class TTwoDimensionLevelUnion
	{
		// Token: 0x17008776 RID: 34678
		// (get) Token: 0x0601D31A RID: 119578 RVA: 0x0041E9FE File Offset: 0x0041CBFE
		// (set) Token: 0x0601D31B RID: 119579 RVA: 0x0041EA06 File Offset: 0x0041CC06
		public TTwoDimensionLevel Type { get; set; }

		// Token: 0x17008777 RID: 34679
		// (get) Token: 0x0601D31C RID: 119580 RVA: 0x0041EA0F File Offset: 0x0041CC0F
		// (set) Token: 0x0601D31D RID: 119581 RVA: 0x0041EA17 File Offset: 0x0041CC17
		public object Value { get; set; }

		// Token: 0x0601D31E RID: 119582 RVA: 0x0041EA20 File Offset: 0x0041CC20
		public TTwoDimensionLevelUnion()
		{
			this.Type = TTwoDimensionLevel.NONE;
			this.Value = null;
		}

		// Token: 0x0601D31F RID: 119583 RVA: 0x0041EA36 File Offset: 0x0041CC36
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601D320 RID: 119584 RVA: 0x0041EA48 File Offset: 0x0041CC48
		public IDangoBrawlLevelT AsIDangoBrawlLevel()
		{
			return this.As<IDangoBrawlLevelT>();
		}

		// Token: 0x0601D321 RID: 119585 RVA: 0x0041EA50 File Offset: 0x0041CC50
		public static TTwoDimensionLevelUnion FromIDangoBrawlLevel(IDangoBrawlLevelT _idangobrawllevel)
		{
			return new TTwoDimensionLevelUnion
			{
				Type = TTwoDimensionLevel.IDangoBrawlLevel,
				Value = _idangobrawllevel
			};
		}

		// Token: 0x0601D322 RID: 119586 RVA: 0x0041EA65 File Offset: 0x0041CC65
		public IMarbleLevelT AsIMarbleLevel()
		{
			return this.As<IMarbleLevelT>();
		}

		// Token: 0x0601D323 RID: 119587 RVA: 0x0041EA6D File Offset: 0x0041CC6D
		public static TTwoDimensionLevelUnion FromIMarbleLevel(IMarbleLevelT _imarblelevel)
		{
			return new TTwoDimensionLevelUnion
			{
				Type = TTwoDimensionLevel.IMarbleLevel,
				Value = _imarblelevel
			};
		}

		// Token: 0x0601D324 RID: 119588 RVA: 0x0041EA84 File Offset: 0x0041CC84
		public static int Pack(FlatBufferBuilder builder, TTwoDimensionLevelUnion _o)
		{
			TTwoDimensionLevel type = _o.Type;
			if (type == TTwoDimensionLevel.IDangoBrawlLevel)
			{
				return IDangoBrawlLevel.Pack(builder, _o.AsIDangoBrawlLevel()).Value;
			}
			if (type != TTwoDimensionLevel.IMarbleLevel)
			{
				return 0;
			}
			return IMarbleLevel.Pack(builder, _o.AsIMarbleLevel()).Value;
		}
	}
}
