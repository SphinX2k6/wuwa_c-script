using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046AB RID: 18091
	public struct IStartCombatOperationReplay : IFlatbufferObject
	{
		// Token: 0x17008080 RID: 32896
		// (get) Token: 0x0601B7C7 RID: 112583 RVA: 0x003E6FF1 File Offset: 0x003E51F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B7C8 RID: 112584 RVA: 0x003E6FFE File Offset: 0x003E51FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B7C9 RID: 112585 RVA: 0x003E7008 File Offset: 0x003E5208
		public static IStartCombatOperationReplay GetRootAsIStartCombatOperationReplay(ByteBuffer _bb)
		{
			return IStartCombatOperationReplay.GetRootAsIStartCombatOperationReplay(_bb, default(IStartCombatOperationReplay));
		}

		// Token: 0x0601B7CA RID: 112586 RVA: 0x003E7024 File Offset: 0x003E5224
		public static IStartCombatOperationReplay GetRootAsIStartCombatOperationReplay(ByteBuffer _bb, IStartCombatOperationReplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B7CB RID: 112587 RVA: 0x003E7041 File Offset: 0x003E5241
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B7CC RID: 112588 RVA: 0x003E7050 File Offset: 0x003E5250
		public IStartCombatOperationReplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008081 RID: 32897
		// (get) Token: 0x0601B7CD RID: 112589 RVA: 0x003E7060 File Offset: 0x003E5260
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008082 RID: 32898
		// (get) Token: 0x0601B7CE RID: 112590 RVA: 0x003E709C File Offset: 0x003E529C
		public string FileId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B7CF RID: 112591 RVA: 0x003E70D3 File Offset: 0x003E52D3
		public Span<byte> GetFileIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601B7D0 RID: 112592 RVA: 0x003E70E2 File Offset: 0x003E52E2
		public byte[] GetFileIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601B7D1 RID: 112593 RVA: 0x003E70F0 File Offset: 0x003E52F0
		public static Offset<IStartCombatOperationReplay> CreateIStartCombatOperationReplay(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, StringOffset FileIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IStartCombatOperationReplay.AddFileId(builder, FileIdOffset);
			IStartCombatOperationReplay.AddType(builder, Type);
			return IStartCombatOperationReplay.EndIStartCombatOperationReplay(builder);
		}

		// Token: 0x0601B7D2 RID: 112594 RVA: 0x003E710D File Offset: 0x003E530D
		public static void StartIStartCombatOperationReplay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B7D3 RID: 112595 RVA: 0x003E7116 File Offset: 0x003E5316
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B7D4 RID: 112596 RVA: 0x003E7121 File Offset: 0x003E5321
		public static void AddFileId(FlatBufferBuilder builder, StringOffset fileIdOffset)
		{
			builder.AddOffset(1, fileIdOffset.Value, 0);
		}

		// Token: 0x0601B7D5 RID: 112597 RVA: 0x003E7131 File Offset: 0x003E5331
		public static Offset<IStartCombatOperationReplay> EndIStartCombatOperationReplay(FlatBufferBuilder builder)
		{
			return new Offset<IStartCombatOperationReplay>(builder.EndTable());
		}

		// Token: 0x0601B7D6 RID: 112598 RVA: 0x003E7140 File Offset: 0x003E5340
		public IStartCombatOperationReplayT UnPack()
		{
			IStartCombatOperationReplayT startCombatOperationReplayT = new IStartCombatOperationReplayT();
			this.UnPackTo(startCombatOperationReplayT);
			return startCombatOperationReplayT;
		}

		// Token: 0x0601B7D7 RID: 112599 RVA: 0x003E715B File Offset: 0x003E535B
		public void UnPackTo(IStartCombatOperationReplayT _o)
		{
			_o.Type = this.Type;
			_o.FileId = this.FileId;
		}

		// Token: 0x0601B7D8 RID: 112600 RVA: 0x003E7178 File Offset: 0x003E5378
		public static Offset<IStartCombatOperationReplay> Pack(FlatBufferBuilder builder, IStartCombatOperationReplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStartCombatOperationReplay>);
			}
			StringOffset fileIdOffset = (_o.FileId == null) ? default(StringOffset) : builder.CreateString(_o.FileId);
			return IStartCombatOperationReplay.CreateIStartCombatOperationReplay(builder, _o.Type, fileIdOffset);
		}

		// Token: 0x0400C876 RID: 51318
		private Table __p;
	}
}
