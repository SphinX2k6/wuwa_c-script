using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200454E RID: 17742
	public struct IRollBlockBase : IFlatbufferObject
	{
		// Token: 0x17007DDB RID: 32219
		// (get) Token: 0x0601AB33 RID: 109363 RVA: 0x003CED28 File Offset: 0x003CCF28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AB34 RID: 109364 RVA: 0x003CED35 File Offset: 0x003CCF35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AB35 RID: 109365 RVA: 0x003CED3C File Offset: 0x003CCF3C
		public static IRollBlockBase GetRootAsIRollBlockBase(ByteBuffer _bb)
		{
			return IRollBlockBase.GetRootAsIRollBlockBase(_bb, default(IRollBlockBase));
		}

		// Token: 0x0601AB36 RID: 109366 RVA: 0x003CED58 File Offset: 0x003CCF58
		public static IRollBlockBase GetRootAsIRollBlockBase(ByteBuffer _bb, IRollBlockBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AB37 RID: 109367 RVA: 0x003CED75 File Offset: 0x003CCF75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AB38 RID: 109368 RVA: 0x003CED84 File Offset: 0x003CCF84
		public IRollBlockBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DDC RID: 32220
		// (get) Token: 0x0601AB39 RID: 109369 RVA: 0x003CED94 File Offset: 0x003CCF94
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

		// Token: 0x17007DDD RID: 32221
		// (get) Token: 0x0601AB3A RID: 109370 RVA: 0x003CEDD0 File Offset: 0x003CCFD0
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

		// Token: 0x0601AB3B RID: 109371 RVA: 0x003CEE0C File Offset: 0x003CD00C
		public static Offset<IRollBlockBase> CreateIRollBlockBase(FlatBufferBuilder builder, ERollBlockBlockType Type = ERollBlockBlockType.Block1, int BlockId = 0)
		{
			builder.StartTable(2);
			IRollBlockBase.AddBlockId(builder, BlockId);
			IRollBlockBase.AddType(builder, Type);
			return IRollBlockBase.EndIRollBlockBase(builder);
		}

		// Token: 0x0601AB3C RID: 109372 RVA: 0x003CEE29 File Offset: 0x003CD029
		public static void StartIRollBlockBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AB3D RID: 109373 RVA: 0x003CEE32 File Offset: 0x003CD032
		public static void AddType(FlatBufferBuilder builder, ERollBlockBlockType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AB3E RID: 109374 RVA: 0x003CEE3D File Offset: 0x003CD03D
		public static void AddBlockId(FlatBufferBuilder builder, int blockId)
		{
			builder.AddInt(1, blockId, 0);
		}

		// Token: 0x0601AB3F RID: 109375 RVA: 0x003CEE48 File Offset: 0x003CD048
		public static Offset<IRollBlockBase> EndIRollBlockBase(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockBase>(builder.EndTable());
		}

		// Token: 0x0601AB40 RID: 109376 RVA: 0x003CEE58 File Offset: 0x003CD058
		public IRollBlockBaseT UnPack()
		{
			IRollBlockBaseT rollBlockBaseT = new IRollBlockBaseT();
			this.UnPackTo(rollBlockBaseT);
			return rollBlockBaseT;
		}

		// Token: 0x0601AB41 RID: 109377 RVA: 0x003CEE73 File Offset: 0x003CD073
		public void UnPackTo(IRollBlockBaseT _o)
		{
			_o.Type = this.Type;
			_o.BlockId = this.BlockId;
		}

		// Token: 0x0601AB42 RID: 109378 RVA: 0x003CEE90 File Offset: 0x003CD090
		public static Offset<IRollBlockBase> Pack(FlatBufferBuilder builder, IRollBlockBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockBase>);
			}
			return IRollBlockBase.CreateIRollBlockBase(builder, _o.Type, _o.BlockId);
		}

		// Token: 0x0400C5D7 RID: 50647
		private Table __p;
	}
}
