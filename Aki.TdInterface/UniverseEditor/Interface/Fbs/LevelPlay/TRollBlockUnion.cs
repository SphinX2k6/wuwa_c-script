using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A7A RID: 19066
	public class TRollBlockUnion
	{
		// Token: 0x170085AC RID: 34220
		// (get) Token: 0x0601CA9A RID: 117402 RVA: 0x0040B162 File Offset: 0x00409362
		// (set) Token: 0x0601CA9B RID: 117403 RVA: 0x0040B16A File Offset: 0x0040936A
		public TRollBlock Type { get; set; }

		// Token: 0x170085AD RID: 34221
		// (get) Token: 0x0601CA9C RID: 117404 RVA: 0x0040B173 File Offset: 0x00409373
		// (set) Token: 0x0601CA9D RID: 117405 RVA: 0x0040B17B File Offset: 0x0040937B
		public object Value { get; set; }

		// Token: 0x0601CA9E RID: 117406 RVA: 0x0040B184 File Offset: 0x00409384
		public TRollBlockUnion()
		{
			this.Type = TRollBlock.NONE;
			this.Value = null;
		}

		// Token: 0x0601CA9F RID: 117407 RVA: 0x0040B19A File Offset: 0x0040939A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CAA0 RID: 117408 RVA: 0x0040B1AC File Offset: 0x004093AC
		public IRollBlock1T AsIRollBlock1()
		{
			return this.As<IRollBlock1T>();
		}

		// Token: 0x0601CAA1 RID: 117409 RVA: 0x0040B1B4 File Offset: 0x004093B4
		public static TRollBlockUnion FromIRollBlock1(IRollBlock1T _irollblock1)
		{
			return new TRollBlockUnion
			{
				Type = TRollBlock.IRollBlock1,
				Value = _irollblock1
			};
		}

		// Token: 0x0601CAA2 RID: 117410 RVA: 0x0040B1C9 File Offset: 0x004093C9
		public IRollBlock2T AsIRollBlock2()
		{
			return this.As<IRollBlock2T>();
		}

		// Token: 0x0601CAA3 RID: 117411 RVA: 0x0040B1D1 File Offset: 0x004093D1
		public static TRollBlockUnion FromIRollBlock2(IRollBlock2T _irollblock2)
		{
			return new TRollBlockUnion
			{
				Type = TRollBlock.IRollBlock2,
				Value = _irollblock2
			};
		}

		// Token: 0x0601CAA4 RID: 117412 RVA: 0x0040B1E8 File Offset: 0x004093E8
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
