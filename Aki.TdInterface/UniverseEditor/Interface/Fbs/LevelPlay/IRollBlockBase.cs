using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049B6 RID: 18870
	public struct IRollBlockBase : IFlatbufferObject
	{
		// Token: 0x1700841C RID: 33820
		// (get) Token: 0x0601C308 RID: 115464 RVA: 0x003FAFC4 File Offset: 0x003F91C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C309 RID: 115465 RVA: 0x003FAFD1 File Offset: 0x003F91D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C30A RID: 115466 RVA: 0x003FAFD8 File Offset: 0x003F91D8
		public static IRollBlockBase GetRootAsIRollBlockBase(ByteBuffer _bb)
		{
			return IRollBlockBase.GetRootAsIRollBlockBase(_bb, default(IRollBlockBase));
		}

		// Token: 0x0601C30B RID: 115467 RVA: 0x003FAFF4 File Offset: 0x003F91F4
		public static IRollBlockBase GetRootAsIRollBlockBase(ByteBuffer _bb, IRollBlockBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C30C RID: 115468 RVA: 0x003FB011 File Offset: 0x003F9211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C30D RID: 115469 RVA: 0x003FB020 File Offset: 0x003F9220
		public IRollBlockBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700841D RID: 33821
		// (get) Token: 0x0601C30E RID: 115470 RVA: 0x003FB030 File Offset: 0x003F9230
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

		// Token: 0x1700841E RID: 33822
		// (get) Token: 0x0601C30F RID: 115471 RVA: 0x003FB06C File Offset: 0x003F926C
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

		// Token: 0x0601C310 RID: 115472 RVA: 0x003FB0A8 File Offset: 0x003F92A8
		public static Offset<IRollBlockBase> CreateIRollBlockBase(FlatBufferBuilder builder, ERollBlockBlockType Type = ERollBlockBlockType.Block1, int BlockId = 0)
		{
			builder.StartTable(2);
			IRollBlockBase.AddBlockId(builder, BlockId);
			IRollBlockBase.AddType(builder, Type);
			return IRollBlockBase.EndIRollBlockBase(builder);
		}

		// Token: 0x0601C311 RID: 115473 RVA: 0x003FB0C5 File Offset: 0x003F92C5
		public static void StartIRollBlockBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C312 RID: 115474 RVA: 0x003FB0CE File Offset: 0x003F92CE
		public static void AddType(FlatBufferBuilder builder, ERollBlockBlockType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C313 RID: 115475 RVA: 0x003FB0D9 File Offset: 0x003F92D9
		public static void AddBlockId(FlatBufferBuilder builder, int blockId)
		{
			builder.AddInt(1, blockId, 0);
		}

		// Token: 0x0601C314 RID: 115476 RVA: 0x003FB0E4 File Offset: 0x003F92E4
		public static Offset<IRollBlockBase> EndIRollBlockBase(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockBase>(builder.EndTable());
		}

		// Token: 0x0601C315 RID: 115477 RVA: 0x003FB0F4 File Offset: 0x003F92F4
		public IRollBlockBaseT UnPack()
		{
			IRollBlockBaseT rollBlockBaseT = new IRollBlockBaseT();
			this.UnPackTo(rollBlockBaseT);
			return rollBlockBaseT;
		}

		// Token: 0x0601C316 RID: 115478 RVA: 0x003FB10F File Offset: 0x003F930F
		public void UnPackTo(IRollBlockBaseT _o)
		{
			_o.Type = this.Type;
			_o.BlockId = this.BlockId;
		}

		// Token: 0x0601C317 RID: 115479 RVA: 0x003FB12C File Offset: 0x003F932C
		public static Offset<IRollBlockBase> Pack(FlatBufferBuilder builder, IRollBlockBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockBase>);
			}
			return IRollBlockBase.CreateIRollBlockBase(builder, _o.Type, _o.BlockId);
		}

		// Token: 0x0400D006 RID: 53254
		private Table __p;
	}
}
