using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200637A RID: 25466
	public struct IBvbAiTurnEndData : IFlatbufferObject
	{
		// Token: 0x1700BC5B RID: 48219
		// (get) Token: 0x0602B3E4 RID: 177124 RVA: 0x005E5C60 File Offset: 0x005E3E60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B3E5 RID: 177125 RVA: 0x005E5C6D File Offset: 0x005E3E6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B3E6 RID: 177126 RVA: 0x005E5C74 File Offset: 0x005E3E74
		public static IBvbAiTurnEndData GetRootAsIBvbAiTurnEndData(ByteBuffer _bb)
		{
			return IBvbAiTurnEndData.GetRootAsIBvbAiTurnEndData(_bb, default(IBvbAiTurnEndData));
		}

		// Token: 0x0602B3E7 RID: 177127 RVA: 0x005E5C90 File Offset: 0x005E3E90
		public static IBvbAiTurnEndData GetRootAsIBvbAiTurnEndData(ByteBuffer _bb, IBvbAiTurnEndData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B3E8 RID: 177128 RVA: 0x005E5CAD File Offset: 0x005E3EAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B3E9 RID: 177129 RVA: 0x005E5CBC File Offset: 0x005E3EBC
		public IBvbAiTurnEndData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC5C RID: 48220
		// (get) Token: 0x0602B3EA RID: 177130 RVA: 0x005E5CCC File Offset: 0x005E3ECC
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

		// Token: 0x0602B3EB RID: 177131 RVA: 0x005E5D08 File Offset: 0x005E3F08
		public static Offset<IBvbAiTurnEndData> CreateIBvbAiTurnEndData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbAiTurnEndData.AddType(builder, Type);
			return IBvbAiTurnEndData.EndIBvbAiTurnEndData(builder);
		}

		// Token: 0x0602B3EC RID: 177132 RVA: 0x005E5D1E File Offset: 0x005E3F1E
		public static void StartIBvbAiTurnEndData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B3ED RID: 177133 RVA: 0x005E5D27 File Offset: 0x005E3F27
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B3EE RID: 177134 RVA: 0x005E5D32 File Offset: 0x005E3F32
		public static Offset<IBvbAiTurnEndData> EndIBvbAiTurnEndData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiTurnEndData>(builder.EndTable());
		}

		// Token: 0x0602B3EF RID: 177135 RVA: 0x005E5D40 File Offset: 0x005E3F40
		public IBvbAiTurnEndDataT UnPack()
		{
			IBvbAiTurnEndDataT bvbAiTurnEndDataT = new IBvbAiTurnEndDataT();
			this.UnPackTo(bvbAiTurnEndDataT);
			return bvbAiTurnEndDataT;
		}

		// Token: 0x0602B3F0 RID: 177136 RVA: 0x005E5D5B File Offset: 0x005E3F5B
		public void UnPackTo(IBvbAiTurnEndDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B3F1 RID: 177137 RVA: 0x005E5D6C File Offset: 0x005E3F6C
		public static Offset<IBvbAiTurnEndData> Pack(FlatBufferBuilder builder, IBvbAiTurnEndDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiTurnEndData>);
			}
			return IBvbAiTurnEndData.CreateIBvbAiTurnEndData(builder, _o.Type);
		}

		// Token: 0x0401044C RID: 66636
		private Table __p;
	}
}
