using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D59 RID: 19801
	public class TTwoDimensionLevelUnion
	{
		// Token: 0x17008DBE RID: 36286
		// (get) Token: 0x0601EB07 RID: 125703 RVA: 0x0044B19A File Offset: 0x0044939A
		// (set) Token: 0x0601EB08 RID: 125704 RVA: 0x0044B1A2 File Offset: 0x004493A2
		public TTwoDimensionLevel Type { get; set; }

		// Token: 0x17008DBF RID: 36287
		// (get) Token: 0x0601EB09 RID: 125705 RVA: 0x0044B1AB File Offset: 0x004493AB
		// (set) Token: 0x0601EB0A RID: 125706 RVA: 0x0044B1B3 File Offset: 0x004493B3
		public object Value { get; set; }

		// Token: 0x0601EB0B RID: 125707 RVA: 0x0044B1BC File Offset: 0x004493BC
		public TTwoDimensionLevelUnion()
		{
			this.Type = TTwoDimensionLevel.NONE;
			this.Value = null;
		}

		// Token: 0x0601EB0C RID: 125708 RVA: 0x0044B1D2 File Offset: 0x004493D2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EB0D RID: 125709 RVA: 0x0044B1E4 File Offset: 0x004493E4
		public IDangoBrawlLevelT AsIDangoBrawlLevel()
		{
			return this.As<IDangoBrawlLevelT>();
		}

		// Token: 0x0601EB0E RID: 125710 RVA: 0x0044B1EC File Offset: 0x004493EC
		public static TTwoDimensionLevelUnion FromIDangoBrawlLevel(IDangoBrawlLevelT _idangobrawllevel)
		{
			return new TTwoDimensionLevelUnion
			{
				Type = TTwoDimensionLevel.IDangoBrawlLevel,
				Value = _idangobrawllevel
			};
		}

		// Token: 0x0601EB0F RID: 125711 RVA: 0x0044B201 File Offset: 0x00449401
		public IMarbleLevelT AsIMarbleLevel()
		{
			return this.As<IMarbleLevelT>();
		}

		// Token: 0x0601EB10 RID: 125712 RVA: 0x0044B209 File Offset: 0x00449409
		public static TTwoDimensionLevelUnion FromIMarbleLevel(IMarbleLevelT _imarblelevel)
		{
			return new TTwoDimensionLevelUnion
			{
				Type = TTwoDimensionLevel.IMarbleLevel,
				Value = _imarblelevel
			};
		}

		// Token: 0x0601EB11 RID: 125713 RVA: 0x0044B220 File Offset: 0x00449420
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
