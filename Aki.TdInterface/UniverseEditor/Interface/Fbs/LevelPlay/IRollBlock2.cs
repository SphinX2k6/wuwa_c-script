using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200454B RID: 17739
	public struct IRollBlock2 : IFlatbufferObject
	{
		// Token: 0x17007DD2 RID: 32210
		// (get) Token: 0x0601AB15 RID: 109333 RVA: 0x003CEA0E File Offset: 0x003CCC0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AB16 RID: 109334 RVA: 0x003CEA1B File Offset: 0x003CCC1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AB17 RID: 109335 RVA: 0x003CEA24 File Offset: 0x003CCC24
		public static IRollBlock2 GetRootAsIRollBlock2(ByteBuffer _bb)
		{
			return IRollBlock2.GetRootAsIRollBlock2(_bb, default(IRollBlock2));
		}

		// Token: 0x0601AB18 RID: 109336 RVA: 0x003CEA40 File Offset: 0x003CCC40
		public static IRollBlock2 GetRootAsIRollBlock2(ByteBuffer _bb, IRollBlock2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AB19 RID: 109337 RVA: 0x003CEA5D File Offset: 0x003CCC5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AB1A RID: 109338 RVA: 0x003CEA6C File Offset: 0x003CCC6C
		public IRollBlock2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DD3 RID: 32211
		// (get) Token: 0x0601AB1B RID: 109339 RVA: 0x003CEA7C File Offset: 0x003CCC7C
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

		// Token: 0x17007DD4 RID: 32212
		// (get) Token: 0x0601AB1C RID: 109340 RVA: 0x003CEAB8 File Offset: 0x003CCCB8
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

		// Token: 0x17007DD5 RID: 32213
		// (get) Token: 0x0601AB1D RID: 109341 RVA: 0x003CEAF4 File Offset: 0x003CCCF4
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

		// Token: 0x17007DD6 RID: 32214
		// (get) Token: 0x0601AB1E RID: 109342 RVA: 0x003CEB30 File Offset: 0x003CCD30
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

		// Token: 0x0601AB1F RID: 109343 RVA: 0x003CEB6D File Offset: 0x003CCD6D
		public static Offset<IRollBlock2> CreateIRollBlock2(FlatBufferBuilder builder, ERollBlockBlockType Type = ERollBlockBlockType.Block1, int BlockId = 0, ERollBlockLayType LayType = ERollBlockLayType.Left, byte NullMask = 0)
		{
			builder.StartTable(4);
			IRollBlock2.AddBlockId(builder, BlockId);
			IRollBlock2.AddNullMask(builder, NullMask);
			IRollBlock2.AddLayType(builder, LayType);
			IRollBlock2.AddType(builder, Type);
			return IRollBlock2.EndIRollBlock2(builder);
		}

		// Token: 0x0601AB20 RID: 109344 RVA: 0x003CEB99 File Offset: 0x003CCD99
		public static void StartIRollBlock2(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601AB21 RID: 109345 RVA: 0x003CEBA2 File Offset: 0x003CCDA2
		public static void AddType(FlatBufferBuilder builder, ERollBlockBlockType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AB22 RID: 109346 RVA: 0x003CEBAD File Offset: 0x003CCDAD
		public static void AddBlockId(FlatBufferBuilder builder, int blockId)
		{
			builder.AddInt(1, blockId, 0);
		}

		// Token: 0x0601AB23 RID: 109347 RVA: 0x003CEBB8 File Offset: 0x003CCDB8
		public static void AddLayType(FlatBufferBuilder builder, ERollBlockLayType layType)
		{
			builder.AddByte(2, (byte)layType, 0);
		}

		// Token: 0x0601AB24 RID: 109348 RVA: 0x003CEBC3 File Offset: 0x003CCDC3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601AB25 RID: 109349 RVA: 0x003CEBCE File Offset: 0x003CCDCE
		public static Offset<IRollBlock2> EndIRollBlock2(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlock2>(builder.EndTable());
		}

		// Token: 0x0601AB26 RID: 109350 RVA: 0x003CEBDC File Offset: 0x003CCDDC
		public IRollBlock2T UnPack()
		{
			IRollBlock2T rollBlock2T = new IRollBlock2T();
			this.UnPackTo(rollBlock2T);
			return rollBlock2T;
		}

		// Token: 0x0601AB27 RID: 109351 RVA: 0x003CEBF7 File Offset: 0x003CCDF7
		public void UnPackTo(IRollBlock2T _o)
		{
			_o.Type = this.Type;
			_o.BlockId = this.BlockId;
			_o.LayType = this.LayType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601AB28 RID: 109352 RVA: 0x003CEC2C File Offset: 0x003CCE2C
		public static Offset<IRollBlock2> Pack(FlatBufferBuilder builder, IRollBlock2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlock2>);
			}
			return IRollBlock2.CreateIRollBlock2(builder, _o.Type, _o.BlockId, _o.LayType, _o.NullMask);
		}

		// Token: 0x0400C5D2 RID: 50642
		private Table __p;
	}
}
