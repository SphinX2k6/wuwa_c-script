using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200637D RID: 25469
	public struct IBvbBurnBuffTimeUpData : IFlatbufferObject
	{
		// Token: 0x1700BC5E RID: 48222
		// (get) Token: 0x0602B3F6 RID: 177142 RVA: 0x005E5DD5 File Offset: 0x005E3FD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B3F7 RID: 177143 RVA: 0x005E5DE2 File Offset: 0x005E3FE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B3F8 RID: 177144 RVA: 0x005E5DEC File Offset: 0x005E3FEC
		public static IBvbBurnBuffTimeUpData GetRootAsIBvbBurnBuffTimeUpData(ByteBuffer _bb)
		{
			return IBvbBurnBuffTimeUpData.GetRootAsIBvbBurnBuffTimeUpData(_bb, default(IBvbBurnBuffTimeUpData));
		}

		// Token: 0x0602B3F9 RID: 177145 RVA: 0x005E5E08 File Offset: 0x005E4008
		public static IBvbBurnBuffTimeUpData GetRootAsIBvbBurnBuffTimeUpData(ByteBuffer _bb, IBvbBurnBuffTimeUpData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B3FA RID: 177146 RVA: 0x005E5E25 File Offset: 0x005E4025
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B3FB RID: 177147 RVA: 0x005E5E34 File Offset: 0x005E4034
		public IBvbBurnBuffTimeUpData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC5F RID: 48223
		// (get) Token: 0x0602B3FC RID: 177148 RVA: 0x005E5E44 File Offset: 0x005E4044
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

		// Token: 0x0602B3FD RID: 177149 RVA: 0x005E5E80 File Offset: 0x005E4080
		public static Offset<IBvbBurnBuffTimeUpData> CreateIBvbBurnBuffTimeUpData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution)
		{
			builder.StartTable(1);
			IBvbBurnBuffTimeUpData.AddType(builder, Type);
			return IBvbBurnBuffTimeUpData.EndIBvbBurnBuffTimeUpData(builder);
		}

		// Token: 0x0602B3FE RID: 177150 RVA: 0x005E5E96 File Offset: 0x005E4096
		public static void StartIBvbBurnBuffTimeUpData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B3FF RID: 177151 RVA: 0x005E5E9F File Offset: 0x005E409F
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B400 RID: 177152 RVA: 0x005E5EAA File Offset: 0x005E40AA
		public static Offset<IBvbBurnBuffTimeUpData> EndIBvbBurnBuffTimeUpData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbBurnBuffTimeUpData>(builder.EndTable());
		}

		// Token: 0x0602B401 RID: 177153 RVA: 0x005E5EB8 File Offset: 0x005E40B8
		public IBvbBurnBuffTimeUpDataT UnPack()
		{
			IBvbBurnBuffTimeUpDataT bvbBurnBuffTimeUpDataT = new IBvbBurnBuffTimeUpDataT();
			this.UnPackTo(bvbBurnBuffTimeUpDataT);
			return bvbBurnBuffTimeUpDataT;
		}

		// Token: 0x0602B402 RID: 177154 RVA: 0x005E5ED3 File Offset: 0x005E40D3
		public void UnPackTo(IBvbBurnBuffTimeUpDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B403 RID: 177155 RVA: 0x005E5EE4 File Offset: 0x005E40E4
		public static Offset<IBvbBurnBuffTimeUpData> Pack(FlatBufferBuilder builder, IBvbBurnBuffTimeUpDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbBurnBuffTimeUpData>);
			}
			return IBvbBurnBuffTimeUpData.CreateIBvbBurnBuffTimeUpData(builder, _o.Type);
		}

		// Token: 0x0401044E RID: 66638
		private Table __p;
	}
}
