using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049B3 RID: 18867
	public struct IRollBlock2 : IFlatbufferObject
	{
		// Token: 0x17008413 RID: 33811
		// (get) Token: 0x0601C2EA RID: 115434 RVA: 0x003FACAA File Offset: 0x003F8EAA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C2EB RID: 115435 RVA: 0x003FACB7 File Offset: 0x003F8EB7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C2EC RID: 115436 RVA: 0x003FACC0 File Offset: 0x003F8EC0
		public static IRollBlock2 GetRootAsIRollBlock2(ByteBuffer _bb)
		{
			return IRollBlock2.GetRootAsIRollBlock2(_bb, default(IRollBlock2));
		}

		// Token: 0x0601C2ED RID: 115437 RVA: 0x003FACDC File Offset: 0x003F8EDC
		public static IRollBlock2 GetRootAsIRollBlock2(ByteBuffer _bb, IRollBlock2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C2EE RID: 115438 RVA: 0x003FACF9 File Offset: 0x003F8EF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C2EF RID: 115439 RVA: 0x003FAD08 File Offset: 0x003F8F08
		public IRollBlock2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008414 RID: 33812
		// (get) Token: 0x0601C2F0 RID: 115440 RVA: 0x003FAD18 File Offset: 0x003F8F18
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

		// Token: 0x17008415 RID: 33813
		// (get) Token: 0x0601C2F1 RID: 115441 RVA: 0x003FAD54 File Offset: 0x003F8F54
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

		// Token: 0x17008416 RID: 33814
		// (get) Token: 0x0601C2F2 RID: 115442 RVA: 0x003FAD90 File Offset: 0x003F8F90
		public ERollBlockLayType LayType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ERollBlockLayType.Left;
				}
				return (ERollBlockLayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008417 RID: 33815
		// (get) Token: 0x0601C2F3 RID: 115443 RVA: 0x003FADCC File Offset: 0x003F8FCC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C2F4 RID: 115444 RVA: 0x003FAE09 File Offset: 0x003F9009
		public static Offset<IRollBlock2> CreateIRollBlock2(FlatBufferBuilder builder, ERollBlockBlockType Type = ERollBlockBlockType.Block1, int BlockId = 0, ERollBlockLayType LayType = ERollBlockLayType.Left, byte NullMask = 0)
		{
			builder.StartTable(4);
			IRollBlock2.AddBlockId(builder, BlockId);
			IRollBlock2.AddNullMask(builder, NullMask);
			IRollBlock2.AddLayType(builder, LayType);
			IRollBlock2.AddType(builder, Type);
			return IRollBlock2.EndIRollBlock2(builder);
		}

		// Token: 0x0601C2F5 RID: 115445 RVA: 0x003FAE35 File Offset: 0x003F9035
		public static void StartIRollBlock2(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C2F6 RID: 115446 RVA: 0x003FAE3E File Offset: 0x003F903E
		public static void AddType(FlatBufferBuilder builder, ERollBlockBlockType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C2F7 RID: 115447 RVA: 0x003FAE49 File Offset: 0x003F9049
		public static void AddBlockId(FlatBufferBuilder builder, int blockId)
		{
			builder.AddInt(1, blockId, 0);
		}

		// Token: 0x0601C2F8 RID: 115448 RVA: 0x003FAE54 File Offset: 0x003F9054
		public static void AddLayType(FlatBufferBuilder builder, ERollBlockLayType layType)
		{
			builder.AddByte(2, (byte)layType, 0);
		}

		// Token: 0x0601C2F9 RID: 115449 RVA: 0x003FAE5F File Offset: 0x003F905F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601C2FA RID: 115450 RVA: 0x003FAE6A File Offset: 0x003F906A
		public static Offset<IRollBlock2> EndIRollBlock2(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlock2>(builder.EndTable());
		}

		// Token: 0x0601C2FB RID: 115451 RVA: 0x003FAE78 File Offset: 0x003F9078
		public IRollBlock2T UnPack()
		{
			IRollBlock2T rollBlock2T = new IRollBlock2T();
			this.UnPackTo(rollBlock2T);
			return rollBlock2T;
		}

		// Token: 0x0601C2FC RID: 115452 RVA: 0x003FAE93 File Offset: 0x003F9093
		public void UnPackTo(IRollBlock2T _o)
		{
			_o.Type = this.Type;
			_o.BlockId = this.BlockId;
			_o.LayType = this.LayType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C2FD RID: 115453 RVA: 0x003FAEC8 File Offset: 0x003F90C8
		public static Offset<IRollBlock2> Pack(FlatBufferBuilder builder, IRollBlock2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlock2>);
			}
			return IRollBlock2.CreateIRollBlock2(builder, _o.Type, _o.BlockId, _o.LayType, _o.NullMask);
		}

		// Token: 0x0400D001 RID: 53249
		private Table __p;
	}
}
