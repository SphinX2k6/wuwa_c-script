using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006380 RID: 25472
	public struct IBvbEnableHatredData : IFlatbufferObject
	{
		// Token: 0x1700BC61 RID: 48225
		// (get) Token: 0x0602B408 RID: 177160 RVA: 0x005E5F4D File Offset: 0x005E414D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B409 RID: 177161 RVA: 0x005E5F5A File Offset: 0x005E415A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B40A RID: 177162 RVA: 0x005E5F64 File Offset: 0x005E4164
		public static IBvbEnableHatredData GetRootAsIBvbEnableHatredData(ByteBuffer _bb)
		{
			return IBvbEnableHatredData.GetRootAsIBvbEnableHatredData(_bb, default(IBvbEnableHatredData));
		}

		// Token: 0x0602B40B RID: 177163 RVA: 0x005E5F80 File Offset: 0x005E4180
		public static IBvbEnableHatredData GetRootAsIBvbEnableHatredData(ByteBuffer _bb, IBvbEnableHatredData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B40C RID: 177164 RVA: 0x005E5F9D File Offset: 0x005E419D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B40D RID: 177165 RVA: 0x005E5FAC File Offset: 0x005E41AC
		public IBvbEnableHatredData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC62 RID: 48226
		// (get) Token: 0x0602B40E RID: 177166 RVA: 0x005E5FBC File Offset: 0x005E41BC
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

		// Token: 0x0602B40F RID: 177167 RVA: 0x005E5FF8 File Offset: 0x005E41F8
		public static Offset<IBvbEnableHatredData> CreateIBvbEnableHatredData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbEnableHatredData.AddType(builder, Type);
			return IBvbEnableHatredData.EndIBvbEnableHatredData(builder);
		}

		// Token: 0x0602B410 RID: 177168 RVA: 0x005E600E File Offset: 0x005E420E
		public static void StartIBvbEnableHatredData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B411 RID: 177169 RVA: 0x005E6017 File Offset: 0x005E4217
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B412 RID: 177170 RVA: 0x005E6022 File Offset: 0x005E4222
		public static Offset<IBvbEnableHatredData> EndIBvbEnableHatredData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbEnableHatredData>(builder.EndTable());
		}

		// Token: 0x0602B413 RID: 177171 RVA: 0x005E6030 File Offset: 0x005E4230
		public IBvbEnableHatredDataT UnPack()
		{
			IBvbEnableHatredDataT bvbEnableHatredDataT = new IBvbEnableHatredDataT();
			this.UnPackTo(bvbEnableHatredDataT);
			return bvbEnableHatredDataT;
		}

		// Token: 0x0602B414 RID: 177172 RVA: 0x005E604B File Offset: 0x005E424B
		public void UnPackTo(IBvbEnableHatredDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B415 RID: 177173 RVA: 0x005E605C File Offset: 0x005E425C
		public static Offset<IBvbEnableHatredData> Pack(FlatBufferBuilder builder, IBvbEnableHatredDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbEnableHatredData>);
			}
			return IBvbEnableHatredData.CreateIBvbEnableHatredData(builder, _o.Type);
		}

		// Token: 0x04010450 RID: 66640
		private Table __p;
	}
}
