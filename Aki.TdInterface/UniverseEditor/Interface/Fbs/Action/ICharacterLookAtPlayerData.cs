using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069BA RID: 27066
	public struct ICharacterLookAtPlayerData : IFlatbufferObject
	{
		// Token: 0x1700C72D RID: 50989
		// (get) Token: 0x0602E6D8 RID: 190168 RVA: 0x00655DB6 File Offset: 0x00653FB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E6D9 RID: 190169 RVA: 0x00655DC3 File Offset: 0x00653FC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E6DA RID: 190170 RVA: 0x00655DCC File Offset: 0x00653FCC
		public static ICharacterLookAtPlayerData GetRootAsICharacterLookAtPlayerData(ByteBuffer _bb)
		{
			return ICharacterLookAtPlayerData.GetRootAsICharacterLookAtPlayerData(_bb, default(ICharacterLookAtPlayerData));
		}

		// Token: 0x0602E6DB RID: 190171 RVA: 0x00655DE8 File Offset: 0x00653FE8
		public static ICharacterLookAtPlayerData GetRootAsICharacterLookAtPlayerData(ByteBuffer _bb, ICharacterLookAtPlayerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E6DC RID: 190172 RVA: 0x00655E05 File Offset: 0x00654005
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E6DD RID: 190173 RVA: 0x00655E14 File Offset: 0x00654014
		public ICharacterLookAtPlayerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C72E RID: 50990
		// (get) Token: 0x0602E6DE RID: 190174 RVA: 0x00655E24 File Offset: 0x00654024
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

		// Token: 0x0602E6DF RID: 190175 RVA: 0x00655E60 File Offset: 0x00654060
		public static Offset<ICharacterLookAtPlayerData> CreateICharacterLookAtPlayerData(FlatBufferBuilder builder, ECharacterLookAt Type = ECharacterLookAt.Empty)
		{
			builder.StartTable(1);
			ICharacterLookAtPlayerData.AddType(builder, Type);
			return ICharacterLookAtPlayerData.EndICharacterLookAtPlayerData(builder);
		}

		// Token: 0x0602E6E0 RID: 190176 RVA: 0x00655E76 File Offset: 0x00654076
		public static void StartICharacterLookAtPlayerData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E6E1 RID: 190177 RVA: 0x00655E7F File Offset: 0x0065407F
		public static void AddType(FlatBufferBuilder builder, ECharacterLookAt type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E6E2 RID: 190178 RVA: 0x00655E8A File Offset: 0x0065408A
		public static Offset<ICharacterLookAtPlayerData> EndICharacterLookAtPlayerData(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterLookAtPlayerData>(builder.EndTable());
		}

		// Token: 0x0602E6E3 RID: 190179 RVA: 0x00655E98 File Offset: 0x00654098
		public ICharacterLookAtPlayerDataT UnPack()
		{
			ICharacterLookAtPlayerDataT characterLookAtPlayerDataT = new ICharacterLookAtPlayerDataT();
			this.UnPackTo(characterLookAtPlayerDataT);
			return characterLookAtPlayerDataT;
		}

		// Token: 0x0602E6E4 RID: 190180 RVA: 0x00655EB3 File Offset: 0x006540B3
		public void UnPackTo(ICharacterLookAtPlayerDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E6E5 RID: 190181 RVA: 0x00655EC4 File Offset: 0x006540C4
		public static Offset<ICharacterLookAtPlayerData> Pack(FlatBufferBuilder builder, ICharacterLookAtPlayerDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterLookAtPlayerData>);
			}
			return ICharacterLookAtPlayerData.CreateICharacterLookAtPlayerData(builder, _o.Type);
		}

		// Token: 0x0401172A RID: 71466
		private Table __p;
	}
}
