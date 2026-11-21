using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004771 RID: 18289
	public class TSaveConfigUnion
	{
		// Token: 0x17007FA1 RID: 32673
		// (get) Token: 0x0601AEE3 RID: 110307 RVA: 0x003D1B0A File Offset: 0x003CFD0A
		// (set) Token: 0x0601AEE4 RID: 110308 RVA: 0x003D1B12 File Offset: 0x003CFD12
		public TSaveConfig Type { get; set; }

		// Token: 0x17007FA2 RID: 32674
		// (get) Token: 0x0601AEE5 RID: 110309 RVA: 0x003D1B1B File Offset: 0x003CFD1B
		// (set) Token: 0x0601AEE6 RID: 110310 RVA: 0x003D1B23 File Offset: 0x003CFD23
		public object Value { get; set; }

		// Token: 0x0601AEE7 RID: 110311 RVA: 0x003D1B2C File Offset: 0x003CFD2C
		public TSaveConfigUnion()
		{
			this.Type = TSaveConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0601AEE8 RID: 110312 RVA: 0x003D1B42 File Offset: 0x003CFD42
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AEE9 RID: 110313 RVA: 0x003D1B54 File Offset: 0x003CFD54
		public ISaveNewT AsISaveNew()
		{
			return this.As<ISaveNewT>();
		}

		// Token: 0x0601AEEA RID: 110314 RVA: 0x003D1B5C File Offset: 0x003CFD5C
		public static TSaveConfigUnion FromISaveNew(ISaveNewT _isavenew)
		{
			return new TSaveConfigUnion
			{
				Type = TSaveConfig.ISaveNew,
				Value = _isavenew
			};
		}

		// Token: 0x0601AEEB RID: 110315 RVA: 0x003D1B71 File Offset: 0x003CFD71
		public ISavePointT AsISavePoint()
		{
			return this.As<ISavePointT>();
		}

		// Token: 0x0601AEEC RID: 110316 RVA: 0x003D1B79 File Offset: 0x003CFD79
		public static TSaveConfigUnion FromISavePoint(ISavePointT _isavepoint)
		{
			return new TSaveConfigUnion
			{
				Type = TSaveConfig.ISavePoint,
				Value = _isavepoint
			};
		}

		// Token: 0x0601AEED RID: 110317 RVA: 0x003D1B90 File Offset: 0x003CFD90
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
