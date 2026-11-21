using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006392 RID: 25490
	public struct IBvbRecycleBoardCardData : IFlatbufferObject
	{
		// Token: 0x1700BC72 RID: 48242
		// (get) Token: 0x0602B49C RID: 177308 RVA: 0x005E6DBD File Offset: 0x005E4FBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B49D RID: 177309 RVA: 0x005E6DCA File Offset: 0x005E4FCA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B49E RID: 177310 RVA: 0x005E6DD4 File Offset: 0x005E4FD4
		public static IBvbRecycleBoardCardData GetRootAsIBvbRecycleBoardCardData(ByteBuffer _bb)
		{
			return IBvbRecycleBoardCardData.GetRootAsIBvbRecycleBoardCardData(_bb, default(IBvbRecycleBoardCardData));
		}

		// Token: 0x0602B49F RID: 177311 RVA: 0x005E6DF0 File Offset: 0x005E4FF0
		public static IBvbRecycleBoardCardData GetRootAsIBvbRecycleBoardCardData(ByteBuffer _bb, IBvbRecycleBoardCardData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B4A0 RID: 177312 RVA: 0x005E6E0D File Offset: 0x005E500D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B4A1 RID: 177313 RVA: 0x005E6E1C File Offset: 0x005E501C
		public IBvbRecycleBoardCardData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC73 RID: 48243
		// (get) Token: 0x0602B4A2 RID: 177314 RVA: 0x005E6E2C File Offset: 0x005E502C
		public EGoalActType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGoalActType.Deploy;
				}
				return (EGoalActType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B4A3 RID: 177315 RVA: 0x005E6E68 File Offset: 0x005E5068
		public static Offset<IBvbRecycleBoardCardData> CreateIBvbRecycleBoardCardData(FlatBufferBuilder builder, EGoalActType Type = EGoalActType.Deploy)
		{
			builder.StartTable(1);
			IBvbRecycleBoardCardData.AddType(builder, Type);
			return IBvbRecycleBoardCardData.EndIBvbRecycleBoardCardData(builder);
		}

		// Token: 0x0602B4A4 RID: 177316 RVA: 0x005E6E7E File Offset: 0x005E507E
		public static void StartIBvbRecycleBoardCardData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B4A5 RID: 177317 RVA: 0x005E6E87 File Offset: 0x005E5087
		public static void AddType(FlatBufferBuilder builder, EGoalActType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B4A6 RID: 177318 RVA: 0x005E6E92 File Offset: 0x005E5092
		public static Offset<IBvbRecycleBoardCardData> EndIBvbRecycleBoardCardData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbRecycleBoardCardData>(builder.EndTable());
		}

		// Token: 0x0602B4A7 RID: 177319 RVA: 0x005E6EA0 File Offset: 0x005E50A0
		public IBvbRecycleBoardCardDataT UnPack()
		{
			IBvbRecycleBoardCardDataT bvbRecycleBoardCardDataT = new IBvbRecycleBoardCardDataT();
			this.UnPackTo(bvbRecycleBoardCardDataT);
			return bvbRecycleBoardCardDataT;
		}

		// Token: 0x0602B4A8 RID: 177320 RVA: 0x005E6EBB File Offset: 0x005E50BB
		public void UnPackTo(IBvbRecycleBoardCardDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B4A9 RID: 177321 RVA: 0x005E6ECC File Offset: 0x005E50CC
		public static Offset<IBvbRecycleBoardCardData> Pack(FlatBufferBuilder builder, IBvbRecycleBoardCardDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbRecycleBoardCardData>);
			}
			return IBvbRecycleBoardCardData.CreateIBvbRecycleBoardCardData(builder, _o.Type);
		}

		// Token: 0x04010477 RID: 66679
		private Table __p;
	}
}
