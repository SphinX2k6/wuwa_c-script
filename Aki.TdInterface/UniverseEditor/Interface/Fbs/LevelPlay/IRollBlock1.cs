using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049B0 RID: 18864
	public struct IRollBlock1 : IFlatbufferObject
	{
		// Token: 0x1700840E RID: 33806
		// (get) Token: 0x0601C2D4 RID: 115412 RVA: 0x003FAAAA File Offset: 0x003F8CAA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C2D5 RID: 115413 RVA: 0x003FAAB7 File Offset: 0x003F8CB7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C2D6 RID: 115414 RVA: 0x003FAAC0 File Offset: 0x003F8CC0
		public static IRollBlock1 GetRootAsIRollBlock1(ByteBuffer _bb)
		{
			return IRollBlock1.GetRootAsIRollBlock1(_bb, default(IRollBlock1));
		}

		// Token: 0x0601C2D7 RID: 115415 RVA: 0x003FAADC File Offset: 0x003F8CDC
		public static IRollBlock1 GetRootAsIRollBlock1(ByteBuffer _bb, IRollBlock1 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C2D8 RID: 115416 RVA: 0x003FAAF9 File Offset: 0x003F8CF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C2D9 RID: 115417 RVA: 0x003FAB08 File Offset: 0x003F8D08
		public IRollBlock1 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700840F RID: 33807
		// (get) Token: 0x0601C2DA RID: 115418 RVA: 0x003FAB18 File Offset: 0x003F8D18
		public ERollBlockBlockType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERollBlockBlockType.Block1;
				}
				return (ERollBlockBlockType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008410 RID: 33808
		// (get) Token: 0x0601C2DB RID: 115419 RVA: 0x003FAB54 File Offset: 0x003F8D54
		public int BlockId
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

		// Token: 0x0601C2DC RID: 115420 RVA: 0x003FAB90 File Offset: 0x003F8D90
		public static Offset<IRollBlock1> CreateIRollBlock1(FlatBufferBuilder builder, ERollBlockBlockType Type = ERollBlockBlockType.Block1, int BlockId = 0)
		{
			builder.StartTable(2);
			IRollBlock1.AddBlockId(builder, BlockId);
			IRollBlock1.AddType(builder, Type);
			return IRollBlock1.EndIRollBlock1(builder);
		}

		// Token: 0x0601C2DD RID: 115421 RVA: 0x003FABAD File Offset: 0x003F8DAD
		public static void StartIRollBlock1(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C2DE RID: 115422 RVA: 0x003FABB6 File Offset: 0x003F8DB6
		public static void AddType(FlatBufferBuilder builder, ERollBlockBlockType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C2DF RID: 115423 RVA: 0x003FABC1 File Offset: 0x003F8DC1
		public static void AddBlockId(FlatBufferBuilder builder, int blockId)
		{
			builder.AddInt(1, blockId, 0);
		}

		// Token: 0x0601C2E0 RID: 115424 RVA: 0x003FABCC File Offset: 0x003F8DCC
		public static Offset<IRollBlock1> EndIRollBlock1(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlock1>(builder.EndTable());
		}

		// Token: 0x0601C2E1 RID: 115425 RVA: 0x003FABDC File Offset: 0x003F8DDC
		public IRollBlock1T UnPack()
		{
			IRollBlock1T rollBlock1T = new IRollBlock1T();
			this.UnPackTo(rollBlock1T);
			return rollBlock1T;
		}

		// Token: 0x0601C2E2 RID: 115426 RVA: 0x003FABF7 File Offset: 0x003F8DF7
		public void UnPackTo(IRollBlock1T _o)
		{
			_o.Type = this.Type;
			_o.BlockId = this.BlockId;
		}

		// Token: 0x0601C2E3 RID: 115427 RVA: 0x003FAC14 File Offset: 0x003F8E14
		public static Offset<IRollBlock1> Pack(FlatBufferBuilder builder, IRollBlock1T _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlock1>);
			}
			return IRollBlock1.CreateIRollBlock1(builder, _o.Type, _o.BlockId);
		}

		// Token: 0x0400CFFE RID: 53246
		private Table __p;
	}
}
