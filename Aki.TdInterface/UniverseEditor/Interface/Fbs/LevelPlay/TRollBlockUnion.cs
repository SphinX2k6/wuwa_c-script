using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004612 RID: 17938
	public class TRollBlockUnion
	{
		// Token: 0x17007F6B RID: 32619
		// (get) Token: 0x0601B2C5 RID: 111301 RVA: 0x003DEEC6 File Offset: 0x003DD0C6
		// (set) Token: 0x0601B2C6 RID: 111302 RVA: 0x003DEECE File Offset: 0x003DD0CE
		public TRollBlock Type { get; set; }

		// Token: 0x17007F6C RID: 32620
		// (get) Token: 0x0601B2C7 RID: 111303 RVA: 0x003DEED7 File Offset: 0x003DD0D7
		// (set) Token: 0x0601B2C8 RID: 111304 RVA: 0x003DEEDF File Offset: 0x003DD0DF
		public object Value { get; set; }

		// Token: 0x0601B2C9 RID: 111305 RVA: 0x003DEEE8 File Offset: 0x003DD0E8
		public TRollBlockUnion()
		{
			this.Type = TRollBlock.NONE;
			this.Value = null;
		}

		// Token: 0x0601B2CA RID: 111306 RVA: 0x003DEEFE File Offset: 0x003DD0FE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B2CB RID: 111307 RVA: 0x003DEF10 File Offset: 0x003DD110
		public IRollBlock1T AsIRollBlock1()
		{
			return this.As<IRollBlock1T>();
		}

		// Token: 0x0601B2CC RID: 111308 RVA: 0x003DEF18 File Offset: 0x003DD118
		public static TRollBlockUnion FromIRollBlock1(IRollBlock1T _irollblock1)
		{
			return new TRollBlockUnion
			{
				Type = TRollBlock.IRollBlock1,
				Value = _irollblock1
			};
		}

		// Token: 0x0601B2CD RID: 111309 RVA: 0x003DEF2D File Offset: 0x003DD12D
		public IRollBlock2T AsIRollBlock2()
		{
			return this.As<IRollBlock2T>();
		}

		// Token: 0x0601B2CE RID: 111310 RVA: 0x003DEF35 File Offset: 0x003DD135
		public static TRollBlockUnion FromIRollBlock2(IRollBlock2T _irollblock2)
		{
			return new TRollBlockUnion
			{
				Type = TRollBlock.IRollBlock2,
				Value = _irollblock2
			};
		}

		// Token: 0x0601B2CF RID: 111311 RVA: 0x003DEF4C File Offset: 0x003DD14C
		public static int Pack(FlatBufferBuilder builder, TRollBlockUnion _o)
		{
			TRollBlock type = _o.Type;
			if (type == TRollBlock.IRollBlock1)
			{
				return IRollBlock1.Pack(builder, _o.AsIRollBlock1()).Value;
			}
			if (type != TRollBlock.IRollBlock2)
			{
				return 0;
			}
			return IRollBlock2.Pack(builder, _o.AsIRollBlock2()).Value;
		}
	}
}
