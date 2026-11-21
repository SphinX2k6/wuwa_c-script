using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063A4 RID: 25508
	public struct IBvbWaitForGameBeginData : IFlatbufferObject
	{
		// Token: 0x1700BC83 RID: 48259
		// (get) Token: 0x0602B504 RID: 177412 RVA: 0x005E765D File Offset: 0x005E585D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B505 RID: 177413 RVA: 0x005E766A File Offset: 0x005E586A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B506 RID: 177414 RVA: 0x005E7674 File Offset: 0x005E5874
		public static IBvbWaitForGameBeginData GetRootAsIBvbWaitForGameBeginData(ByteBuffer _bb)
		{
			return IBvbWaitForGameBeginData.GetRootAsIBvbWaitForGameBeginData(_bb, default(IBvbWaitForGameBeginData));
		}

		// Token: 0x0602B507 RID: 177415 RVA: 0x005E7690 File Offset: 0x005E5890
		public static IBvbWaitForGameBeginData GetRootAsIBvbWaitForGameBeginData(ByteBuffer _bb, IBvbWaitForGameBeginData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B508 RID: 177416 RVA: 0x005E76AD File Offset: 0x005E58AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B509 RID: 177417 RVA: 0x005E76BC File Offset: 0x005E58BC
		public IBvbWaitForGameBeginData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC84 RID: 48260
		// (get) Token: 0x0602B50A RID: 177418 RVA: 0x005E76CC File Offset: 0x005E58CC
		public EBvbEventName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbEventName.AIEvolution;
				}
				return (EBvbEventName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B50B RID: 177419 RVA: 0x005E7708 File Offset: 0x005E5908
		public static Offset<IBvbWaitForGameBeginData> CreateIBvbWaitForGameBeginData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbWaitForGameBeginData.AddType(builder, Type);
			return IBvbWaitForGameBeginData.EndIBvbWaitForGameBeginData(builder);
		}

		// Token: 0x0602B50C RID: 177420 RVA: 0x005E771E File Offset: 0x005E591E
		public static void StartIBvbWaitForGameBeginData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B50D RID: 177421 RVA: 0x005E7727 File Offset: 0x005E5927
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B50E RID: 177422 RVA: 0x005E7732 File Offset: 0x005E5932
		public static Offset<IBvbWaitForGameBeginData> EndIBvbWaitForGameBeginData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbWaitForGameBeginData>(builder.EndTable());
		}

		// Token: 0x0602B50F RID: 177423 RVA: 0x005E7740 File Offset: 0x005E5940
		public IBvbWaitForGameBeginDataT UnPack()
		{
			IBvbWaitForGameBeginDataT bvbWaitForGameBeginDataT = new IBvbWaitForGameBeginDataT();
			this.UnPackTo(bvbWaitForGameBeginDataT);
			return bvbWaitForGameBeginDataT;
		}

		// Token: 0x0602B510 RID: 177424 RVA: 0x005E775B File Offset: 0x005E595B
		public void UnPackTo(IBvbWaitForGameBeginDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B511 RID: 177425 RVA: 0x005E776C File Offset: 0x005E596C
		public static Offset<IBvbWaitForGameBeginData> Pack(FlatBufferBuilder builder, IBvbWaitForGameBeginDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbWaitForGameBeginData>);
			}
			return IBvbWaitForGameBeginData.CreateIBvbWaitForGameBeginData(builder, _o.Type);
		}

		// Token: 0x04010488 RID: 66696
		private Table __p;
	}
}
