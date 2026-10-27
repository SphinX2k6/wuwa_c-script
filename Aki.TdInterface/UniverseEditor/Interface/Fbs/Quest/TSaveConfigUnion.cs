using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004312 RID: 17170
	public class TSaveConfigUnion
	{
		// Token: 0x1700796E RID: 31086
		// (get) Token: 0x06019761 RID: 104289 RVA: 0x003A61DA File Offset: 0x003A43DA
		// (set) Token: 0x06019762 RID: 104290 RVA: 0x003A61E2 File Offset: 0x003A43E2
		public TSaveConfig Type { get; set; }

		// Token: 0x1700796F RID: 31087
		// (get) Token: 0x06019763 RID: 104291 RVA: 0x003A61EB File Offset: 0x003A43EB
		// (set) Token: 0x06019764 RID: 104292 RVA: 0x003A61F3 File Offset: 0x003A43F3
		public object Value { get; set; }

		// Token: 0x06019765 RID: 104293 RVA: 0x003A61FC File Offset: 0x003A43FC
		public TSaveConfigUnion()
		{
			this.Type = TSaveConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06019766 RID: 104294 RVA: 0x003A6212 File Offset: 0x003A4412
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019767 RID: 104295 RVA: 0x003A6224 File Offset: 0x003A4424
		public ISaveNewT AsISaveNew()
		{
			return this.As<ISaveNewT>();
		}

		// Token: 0x06019768 RID: 104296 RVA: 0x003A622C File Offset: 0x003A442C
		public static TSaveConfigUnion FromISaveNew(ISaveNewT _isavenew)
		{
			return new TSaveConfigUnion
			{
				Type = TSaveConfig.ISaveNew,
				Value = _isavenew
			};
		}

		// Token: 0x06019769 RID: 104297 RVA: 0x003A6241 File Offset: 0x003A4441
		public ISavePointT AsISavePoint()
		{
			return this.As<ISavePointT>();
		}

		// Token: 0x0601976A RID: 104298 RVA: 0x003A6249 File Offset: 0x003A4449
		public static TSaveConfigUnion FromISavePoint(ISavePointT _isavepoint)
		{
			return new TSaveConfigUnion
			{
				Type = TSaveConfig.ISavePoint,
				Value = _isavepoint
			};
		}

		// Token: 0x0601976B RID: 104299 RVA: 0x003A6260 File Offset: 0x003A4460
		public static int Pack(FlatBufferBuilder builder, TSaveConfigUnion _o)
		{
			TSaveConfig type = _o.Type;
			if (type == TSaveConfig.ISaveNew)
			{
				return ISaveNew.Pack(builder, _o.AsISaveNew()).Value;
			}
			if (type != TSaveConfig.ISavePoint)
			{
				return 0;
			}
			return ISavePoint.Pack(builder, _o.AsISavePoint()).Value;
		}
	}
}
