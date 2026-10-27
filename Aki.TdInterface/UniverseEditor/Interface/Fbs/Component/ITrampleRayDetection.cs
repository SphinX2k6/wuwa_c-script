using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ACC RID: 23244
	public struct ITrampleRayDetection : IFlatbufferObject
	{
		// Token: 0x1700AF34 RID: 44852
		// (get) Token: 0x06027A41 RID: 162369 RVA: 0x005740D7 File Offset: 0x005722D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027A42 RID: 162370 RVA: 0x005740E4 File Offset: 0x005722E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027A43 RID: 162371 RVA: 0x005740EC File Offset: 0x005722EC
		public static ITrampleRayDetection GetRootAsITrampleRayDetection(ByteBuffer _bb)
		{
			return ITrampleRayDetection.GetRootAsITrampleRayDetection(_bb, default(ITrampleRayDetection));
		}

		// Token: 0x06027A44 RID: 162372 RVA: 0x00574108 File Offset: 0x00572308
		public static ITrampleRayDetection GetRootAsITrampleRayDetection(ByteBuffer _bb, ITrampleRayDetection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027A45 RID: 162373 RVA: 0x00574125 File Offset: 0x00572325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027A46 RID: 162374 RVA: 0x00574134 File Offset: 0x00572334
		public ITrampleRayDetection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06027A47 RID: 162375 RVA: 0x00574144 File Offset: 0x00572344
		public static void StartITrampleRayDetection(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06027A48 RID: 162376 RVA: 0x0057414D File Offset: 0x0057234D
		public static Offset<ITrampleRayDetection> EndITrampleRayDetection(FlatBufferBuilder builder)
		{
			return new Offset<ITrampleRayDetection>(builder.EndTable());
		}

		// Token: 0x06027A49 RID: 162377 RVA: 0x0057415C File Offset: 0x0057235C
		public ITrampleRayDetectionT UnPack()
		{
			ITrampleRayDetectionT trampleRayDetectionT = new ITrampleRayDetectionT();
			this.UnPackTo(trampleRayDetectionT);
			return trampleRayDetectionT;
		}

		// Token: 0x06027A4A RID: 162378 RVA: 0x00574177 File Offset: 0x00572377
		public void UnPackTo(ITrampleRayDetectionT _o)
		{
		}

		// Token: 0x06027A4B RID: 162379 RVA: 0x0057417C File Offset: 0x0057237C
		public static Offset<ITrampleRayDetection> Pack(FlatBufferBuilder builder, ITrampleRayDetectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrampleRayDetection>);
			}
			ITrampleRayDetection.StartITrampleRayDetection(builder);
			return ITrampleRayDetection.EndITrampleRayDetection(builder);
		}

		// Token: 0x0400F1AA RID: 61866
		private Table __p;
	}
}
