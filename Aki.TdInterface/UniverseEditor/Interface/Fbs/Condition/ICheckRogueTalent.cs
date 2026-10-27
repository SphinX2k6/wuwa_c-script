using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B1D RID: 19229
	public struct ICheckRogueTalent : IFlatbufferObject
	{
		// Token: 0x17008B78 RID: 35704
		// (get) Token: 0x0601E3E6 RID: 123878 RVA: 0x0043D564 File Offset: 0x0043B764
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E3E7 RID: 123879 RVA: 0x0043D571 File Offset: 0x0043B771
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E3E8 RID: 123880 RVA: 0x0043D578 File Offset: 0x0043B778
		public static ICheckRogueTalent GetRootAsICheckRogueTalent(ByteBuffer _bb)
		{
			return ICheckRogueTalent.GetRootAsICheckRogueTalent(_bb, default(ICheckRogueTalent));
		}

		// Token: 0x0601E3E9 RID: 123881 RVA: 0x0043D594 File Offset: 0x0043B794
		public static ICheckRogueTalent GetRootAsICheckRogueTalent(ByteBuffer _bb, ICheckRogueTalent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E3EA RID: 123882 RVA: 0x0043D5B1 File Offset: 0x0043B7B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E3EB RID: 123883 RVA: 0x0043D5C0 File Offset: 0x0043B7C0
		public ICheckRogueTalent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B79 RID: 35705
		// (get) Token: 0x0601E3EC RID: 123884 RVA: 0x0043D5D0 File Offset: 0x0043B7D0
		public ERogueStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERogueStateType.Talent;
				}
				return (ERogueStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B7A RID: 35706
		// (get) Token: 0x0601E3ED RID: 123885 RVA: 0x0043D60C File Offset: 0x0043B80C
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E3EE RID: 123886 RVA: 0x0043D648 File Offset: 0x0043B848
		public static Offset<ICheckRogueTalent> CreateICheckRogueTalent(FlatBufferBuilder builder, ERogueStateType Type = ERogueStateType.Talent, int Id = 0)
		{
			builder.StartTable(2);
			ICheckRogueTalent.AddId(builder, Id);
			ICheckRogueTalent.AddType(builder, Type);
			return ICheckRogueTalent.EndICheckRogueTalent(builder);
		}

		// Token: 0x0601E3EF RID: 123887 RVA: 0x0043D665 File Offset: 0x0043B865
		public static void StartICheckRogueTalent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E3F0 RID: 123888 RVA: 0x0043D66E File Offset: 0x0043B86E
		public static void AddType(FlatBufferBuilder builder, ERogueStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E3F1 RID: 123889 RVA: 0x0043D679 File Offset: 0x0043B879
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601E3F2 RID: 123890 RVA: 0x0043D684 File Offset: 0x0043B884
		public static Offset<ICheckRogueTalent> EndICheckRogueTalent(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRogueTalent>(builder.EndTable());
		}

		// Token: 0x0601E3F3 RID: 123891 RVA: 0x0043D694 File Offset: 0x0043B894
		public ICheckRogueTalentT UnPack()
		{
			ICheckRogueTalentT checkRogueTalentT = new ICheckRogueTalentT();
			this.UnPackTo(checkRogueTalentT);
			return checkRogueTalentT;
		}

		// Token: 0x0601E3F4 RID: 123892 RVA: 0x0043D6AF File Offset: 0x0043B8AF
		public void UnPackTo(ICheckRogueTalentT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0601E3F5 RID: 123893 RVA: 0x0043D6CC File Offset: 0x0043B8CC
		public static Offset<ICheckRogueTalent> Pack(FlatBufferBuilder builder, ICheckRogueTalentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckRogueTalent>);
			}
			return ICheckRogueTalent.CreateICheckRogueTalent(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400D3BD RID: 54205
		private Table __p;
	}
}
