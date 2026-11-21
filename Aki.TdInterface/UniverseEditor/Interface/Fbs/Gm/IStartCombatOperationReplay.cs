using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B13 RID: 19219
	public struct IStartCombatOperationReplay : IFlatbufferObject
	{
		// Token: 0x170086C1 RID: 34497
		// (get) Token: 0x0601CF9C RID: 118684 RVA: 0x0041328D File Offset: 0x0041148D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CF9D RID: 118685 RVA: 0x0041329A File Offset: 0x0041149A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CF9E RID: 118686 RVA: 0x004132A4 File Offset: 0x004114A4
		public static IStartCombatOperationReplay GetRootAsIStartCombatOperationReplay(ByteBuffer _bb)
		{
			return IStartCombatOperationReplay.GetRootAsIStartCombatOperationReplay(_bb, default(IStartCombatOperationReplay));
		}

		// Token: 0x0601CF9F RID: 118687 RVA: 0x004132C0 File Offset: 0x004114C0
		public static IStartCombatOperationReplay GetRootAsIStartCombatOperationReplay(ByteBuffer _bb, IStartCombatOperationReplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CFA0 RID: 118688 RVA: 0x004132DD File Offset: 0x004114DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CFA1 RID: 118689 RVA: 0x004132EC File Offset: 0x004114EC
		public IStartCombatOperationReplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086C2 RID: 34498
		// (get) Token: 0x0601CFA2 RID: 118690 RVA: 0x004132FC File Offset: 0x004114FC
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

		// Token: 0x170086C3 RID: 34499
		// (get) Token: 0x0601CFA3 RID: 118691 RVA: 0x00413338 File Offset: 0x00411538
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

		// Token: 0x0601CFA4 RID: 118692 RVA: 0x0041336F File Offset: 0x0041156F
		public Span<byte> GetFileIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601CFA5 RID: 118693 RVA: 0x0041337E File Offset: 0x0041157E
		public byte[] GetFileIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601CFA6 RID: 118694 RVA: 0x0041338C File Offset: 0x0041158C
		public static Offset<IStartCombatOperationReplay> CreateIStartCombatOperationReplay(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, StringOffset FileIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IStartCombatOperationReplay.AddFileId(builder, FileIdOffset);
			IStartCombatOperationReplay.AddType(builder, Type);
			return IStartCombatOperationReplay.EndIStartCombatOperationReplay(builder);
		}

		// Token: 0x0601CFA7 RID: 118695 RVA: 0x004133A9 File Offset: 0x004115A9
		public static void StartIStartCombatOperationReplay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CFA8 RID: 118696 RVA: 0x004133B2 File Offset: 0x004115B2
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CFA9 RID: 118697 RVA: 0x004133BD File Offset: 0x004115BD
		public static void AddFileId(FlatBufferBuilder builder, StringOffset fileIdOffset)
		{
			builder.AddOffset(1, fileIdOffset.Value, 0);
		}

		// Token: 0x0601CFAA RID: 118698 RVA: 0x004133CD File Offset: 0x004115CD
		public static Offset<IStartCombatOperationReplay> EndIStartCombatOperationReplay(FlatBufferBuilder builder)
		{
			return new Offset<IStartCombatOperationReplay>(builder.EndTable());
		}

		// Token: 0x0601CFAB RID: 118699 RVA: 0x004133DC File Offset: 0x004115DC
		public IStartCombatOperationReplayT UnPack()
		{
			IStartCombatOperationReplayT startCombatOperationReplayT = new IStartCombatOperationReplayT();
			this.UnPackTo(startCombatOperationReplayT);
			return startCombatOperationReplayT;
		}

		// Token: 0x0601CFAC RID: 118700 RVA: 0x004133F7 File Offset: 0x004115F7
		public void UnPackTo(IStartCombatOperationReplayT _o)
		{
			_o.Type = this.Type;
			_o.FileId = this.FileId;
		}

		// Token: 0x0601CFAD RID: 118701 RVA: 0x00413414 File Offset: 0x00411614
		public static Offset<IStartCombatOperationReplay> Pack(FlatBufferBuilder builder, IStartCombatOperationReplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStartCombatOperationReplay>);
			}
			StringOffset fileIdOffset = (_o.FileId == null) ? default(StringOffset) : builder.CreateString(_o.FileId);
			return IStartCombatOperationReplay.CreateIStartCombatOperationReplay(builder, _o.Type, fileIdOffset);
		}

		// Token: 0x0400D2A5 RID: 53925
		private Table __p;
	}
}
