using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D6A RID: 23914
	public struct IBvbStartRoundData : IFlatbufferObject
	{
		// Token: 0x1700B31F RID: 45855
		// (get) Token: 0x06028E88 RID: 167560 RVA: 0x0059EA75 File Offset: 0x0059CC75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028E89 RID: 167561 RVA: 0x0059EA82 File Offset: 0x0059CC82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028E8A RID: 167562 RVA: 0x0059EA8C File Offset: 0x0059CC8C
		public static IBvbStartRoundData GetRootAsIBvbStartRoundData(ByteBuffer _bb)
		{
			return IBvbStartRoundData.GetRootAsIBvbStartRoundData(_bb, default(IBvbStartRoundData));
		}

		// Token: 0x06028E8B RID: 167563 RVA: 0x0059EAA8 File Offset: 0x0059CCA8
		public static IBvbStartRoundData GetRootAsIBvbStartRoundData(ByteBuffer _bb, IBvbStartRoundData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028E8C RID: 167564 RVA: 0x0059EAC5 File Offset: 0x0059CCC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028E8D RID: 167565 RVA: 0x0059EAD4 File Offset: 0x0059CCD4
		public IBvbStartRoundData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B320 RID: 45856
		// (get) Token: 0x06028E8E RID: 167566 RVA: 0x0059EAE4 File Offset: 0x0059CCE4
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

		// Token: 0x06028E8F RID: 167567 RVA: 0x0059EB20 File Offset: 0x0059CD20
		public static Offset<IBvbStartRoundData> CreateIBvbStartRoundData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbStartRoundData.AddType(builder, Type);
			return IBvbStartRoundData.EndIBvbStartRoundData(builder);
		}

		// Token: 0x06028E90 RID: 167568 RVA: 0x0059EB36 File Offset: 0x0059CD36
		public static void StartIBvbStartRoundData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028E91 RID: 167569 RVA: 0x0059EB3F File Offset: 0x0059CD3F
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028E92 RID: 167570 RVA: 0x0059EB4A File Offset: 0x0059CD4A
		public static Offset<IBvbStartRoundData> EndIBvbStartRoundData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbStartRoundData>(builder.EndTable());
		}

		// Token: 0x06028E93 RID: 167571 RVA: 0x0059EB58 File Offset: 0x0059CD58
		public IBvbStartRoundDataT UnPack()
		{
			IBvbStartRoundDataT bvbStartRoundDataT = new IBvbStartRoundDataT();
			this.UnPackTo(bvbStartRoundDataT);
			return bvbStartRoundDataT;
		}

		// Token: 0x06028E94 RID: 167572 RVA: 0x0059EB73 File Offset: 0x0059CD73
		public void UnPackTo(IBvbStartRoundDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028E95 RID: 167573 RVA: 0x0059EB84 File Offset: 0x0059CD84
		public static Offset<IBvbStartRoundData> Pack(FlatBufferBuilder builder, IBvbStartRoundDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbStartRoundData>);
			}
			return IBvbStartRoundData.CreateIBvbStartRoundData(builder, _o.Type);
		}

		// Token: 0x0400F734 RID: 63284
		private Table __p;
	}
}
