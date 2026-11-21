using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004995 RID: 18837
	public struct INoBustResult : IFlatbufferObject
	{
		// Token: 0x170083DF RID: 33759
		// (get) Token: 0x0601C1EA RID: 115178 RVA: 0x003F934C File Offset: 0x003F754C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C1EB RID: 115179 RVA: 0x003F9359 File Offset: 0x003F7559
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C1EC RID: 115180 RVA: 0x003F9360 File Offset: 0x003F7560
		public static INoBustResult GetRootAsINoBustResult(ByteBuffer _bb)
		{
			return INoBustResult.GetRootAsINoBustResult(_bb, default(INoBustResult));
		}

		// Token: 0x0601C1ED RID: 115181 RVA: 0x003F937C File Offset: 0x003F757C
		public static INoBustResult GetRootAsINoBustResult(ByteBuffer _bb, INoBustResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C1EE RID: 115182 RVA: 0x003F9399 File Offset: 0x003F7599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C1EF RID: 115183 RVA: 0x003F93A8 File Offset: 0x003F75A8
		public INoBustResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083E0 RID: 33760
		// (get) Token: 0x0601C1F0 RID: 115184 RVA: 0x003F93B8 File Offset: 0x003F75B8
		public EDartSkillResultType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartSkillResultType.NoBust;
				}
				return (EDartSkillResultType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170083E1 RID: 33761
		// (get) Token: 0x0601C1F1 RID: 115185 RVA: 0x003F93F4 File Offset: 0x003F75F4
		public int Probability
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

		// Token: 0x0601C1F2 RID: 115186 RVA: 0x003F9430 File Offset: 0x003F7630
		public static Offset<INoBustResult> CreateINoBustResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust, int Probability = 0)
		{
			builder.StartTable(2);
			INoBustResult.AddProbability(builder, Probability);
			INoBustResult.AddType(builder, Type);
			return INoBustResult.EndINoBustResult(builder);
		}

		// Token: 0x0601C1F3 RID: 115187 RVA: 0x003F944D File Offset: 0x003F764D
		public static void StartINoBustResult(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C1F4 RID: 115188 RVA: 0x003F9456 File Offset: 0x003F7656
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C1F5 RID: 115189 RVA: 0x003F9461 File Offset: 0x003F7661
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(1, probability, 0);
		}

		// Token: 0x0601C1F6 RID: 115190 RVA: 0x003F946C File Offset: 0x003F766C
		public static Offset<INoBustResult> EndINoBustResult(FlatBufferBuilder builder)
		{
			return new Offset<INoBustResult>(builder.EndTable());
		}

		// Token: 0x0601C1F7 RID: 115191 RVA: 0x003F947C File Offset: 0x003F767C
		public INoBustResultT UnPack()
		{
			INoBustResultT noBustResultT = new INoBustResultT();
			this.UnPackTo(noBustResultT);
			return noBustResultT;
		}

		// Token: 0x0601C1F8 RID: 115192 RVA: 0x003F9497 File Offset: 0x003F7697
		public void UnPackTo(INoBustResultT _o)
		{
			_o.Type = this.Type;
			_o.Probability = this.Probability;
		}

		// Token: 0x0601C1F9 RID: 115193 RVA: 0x003F94B4 File Offset: 0x003F76B4
		public static Offset<INoBustResult> Pack(FlatBufferBuilder builder, INoBustResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoBustResult>);
			}
			return INoBustResult.CreateINoBustResult(builder, _o.Type, _o.Probability);
		}

		// Token: 0x0400CFE2 RID: 53218
		private Table __p;
	}
}
