using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B4 RID: 27060
	public struct ICharacterLookAtEmptyData : IFlatbufferObject
	{
		// Token: 0x1700C725 RID: 50981
		// (get) Token: 0x0602E6B0 RID: 190128 RVA: 0x00655A3E File Offset: 0x00653C3E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E6B1 RID: 190129 RVA: 0x00655A4B File Offset: 0x00653C4B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E6B2 RID: 190130 RVA: 0x00655A54 File Offset: 0x00653C54
		public static ICharacterLookAtEmptyData GetRootAsICharacterLookAtEmptyData(ByteBuffer _bb)
		{
			return ICharacterLookAtEmptyData.GetRootAsICharacterLookAtEmptyData(_bb, default(ICharacterLookAtEmptyData));
		}

		// Token: 0x0602E6B3 RID: 190131 RVA: 0x00655A70 File Offset: 0x00653C70
		public static ICharacterLookAtEmptyData GetRootAsICharacterLookAtEmptyData(ByteBuffer _bb, ICharacterLookAtEmptyData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E6B4 RID: 190132 RVA: 0x00655A8D File Offset: 0x00653C8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E6B5 RID: 190133 RVA: 0x00655A9C File Offset: 0x00653C9C
		public ICharacterLookAtEmptyData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C726 RID: 50982
		// (get) Token: 0x0602E6B6 RID: 190134 RVA: 0x00655AAC File Offset: 0x00653CAC
		public ECharacterLookAt Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECharacterLookAt.Empty;
				}
				return (ECharacterLookAt)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E6B7 RID: 190135 RVA: 0x00655AE8 File Offset: 0x00653CE8
		public static Offset<ICharacterLookAtEmptyData> CreateICharacterLookAtEmptyData(FlatBufferBuilder builder, ECharacterLookAt Type = ECharacterLookAt.Empty)
		{
			builder.StartTable(1);
			ICharacterLookAtEmptyData.AddType(builder, Type);
			return ICharacterLookAtEmptyData.EndICharacterLookAtEmptyData(builder);
		}

		// Token: 0x0602E6B8 RID: 190136 RVA: 0x00655AFE File Offset: 0x00653CFE
		public static void StartICharacterLookAtEmptyData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E6B9 RID: 190137 RVA: 0x00655B07 File Offset: 0x00653D07
		public static void AddType(FlatBufferBuilder builder, ECharacterLookAt type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E6BA RID: 190138 RVA: 0x00655B12 File Offset: 0x00653D12
		public static Offset<ICharacterLookAtEmptyData> EndICharacterLookAtEmptyData(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterLookAtEmptyData>(builder.EndTable());
		}

		// Token: 0x0602E6BB RID: 190139 RVA: 0x00655B20 File Offset: 0x00653D20
		public ICharacterLookAtEmptyDataT UnPack()
		{
			ICharacterLookAtEmptyDataT characterLookAtEmptyDataT = new ICharacterLookAtEmptyDataT();
			this.UnPackTo(characterLookAtEmptyDataT);
			return characterLookAtEmptyDataT;
		}

		// Token: 0x0602E6BC RID: 190140 RVA: 0x00655B3B File Offset: 0x00653D3B
		public void UnPackTo(ICharacterLookAtEmptyDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E6BD RID: 190141 RVA: 0x00655B4C File Offset: 0x00653D4C
		public static Offset<ICharacterLookAtEmptyData> Pack(FlatBufferBuilder builder, ICharacterLookAtEmptyDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterLookAtEmptyData>);
			}
			return ICharacterLookAtEmptyData.CreateICharacterLookAtEmptyData(builder, _o.Type);
		}

		// Token: 0x04011725 RID: 71461
		private Table __p;
	}
}
