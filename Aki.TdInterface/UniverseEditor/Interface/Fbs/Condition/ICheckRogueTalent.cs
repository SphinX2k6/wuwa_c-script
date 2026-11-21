using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005004 RID: 20484
	public struct ICheckRogueTalent : IFlatbufferObject
	{
		// Token: 0x17009288 RID: 37512
		// (get) Token: 0x0601FF71 RID: 130929 RVA: 0x0046FD10 File Offset: 0x0046DF10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FF72 RID: 130930 RVA: 0x0046FD1D File Offset: 0x0046DF1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FF73 RID: 130931 RVA: 0x0046FD24 File Offset: 0x0046DF24
		public static ICheckRogueTalent GetRootAsICheckRogueTalent(ByteBuffer _bb)
		{
			return ICheckRogueTalent.GetRootAsICheckRogueTalent(_bb, default(ICheckRogueTalent));
		}

		// Token: 0x0601FF74 RID: 130932 RVA: 0x0046FD40 File Offset: 0x0046DF40
		public static ICheckRogueTalent GetRootAsICheckRogueTalent(ByteBuffer _bb, ICheckRogueTalent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FF75 RID: 130933 RVA: 0x0046FD5D File Offset: 0x0046DF5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FF76 RID: 130934 RVA: 0x0046FD6C File Offset: 0x0046DF6C
		public ICheckRogueTalent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009289 RID: 37513
		// (get) Token: 0x0601FF77 RID: 130935 RVA: 0x0046FD7C File Offset: 0x0046DF7C
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

		// Token: 0x1700928A RID: 37514
		// (get) Token: 0x0601FF78 RID: 130936 RVA: 0x0046FDB8 File Offset: 0x0046DFB8
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

		// Token: 0x0601FF79 RID: 130937 RVA: 0x0046FDF4 File Offset: 0x0046DFF4
		public static Offset<ICheckRogueTalent> CreateICheckRogueTalent(FlatBufferBuilder builder, ERogueStateType Type = ERogueStateType.Talent, int Id = 0)
		{
			builder.StartTable(2);
			ICheckRogueTalent.AddId(builder, Id);
			ICheckRogueTalent.AddType(builder, Type);
			return ICheckRogueTalent.EndICheckRogueTalent(builder);
		}

		// Token: 0x0601FF7A RID: 130938 RVA: 0x0046FE11 File Offset: 0x0046E011
		public static void StartICheckRogueTalent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FF7B RID: 130939 RVA: 0x0046FE1A File Offset: 0x0046E01A
		public static void AddType(FlatBufferBuilder builder, ERogueStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FF7C RID: 130940 RVA: 0x0046FE25 File Offset: 0x0046E025
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601FF7D RID: 130941 RVA: 0x0046FE30 File Offset: 0x0046E030
		public static Offset<ICheckRogueTalent> EndICheckRogueTalent(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRogueTalent>(builder.EndTable());
		}

		// Token: 0x0601FF7E RID: 130942 RVA: 0x0046FE40 File Offset: 0x0046E040
		public ICheckRogueTalentT UnPack()
		{
			ICheckRogueTalentT checkRogueTalentT = new ICheckRogueTalentT();
			this.UnPackTo(checkRogueTalentT);
			return checkRogueTalentT;
		}

		// Token: 0x0601FF7F RID: 130943 RVA: 0x0046FE5B File Offset: 0x0046E05B
		public void UnPackTo(ICheckRogueTalentT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0601FF80 RID: 130944 RVA: 0x0046FE78 File Offset: 0x0046E078
		public static Offset<ICheckRogueTalent> Pack(FlatBufferBuilder builder, ICheckRogueTalentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckRogueTalent>);
			}
			return ICheckRogueTalent.CreateICheckRogueTalent(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400DEBC RID: 57020
		private Table __p;
	}
}
