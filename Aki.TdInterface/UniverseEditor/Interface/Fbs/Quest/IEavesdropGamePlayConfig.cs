using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004229 RID: 16937
	public struct IEavesdropGamePlayConfig : IFlatbufferObject
	{
		// Token: 0x17007369 RID: 29545
		// (get) Token: 0x060178A6 RID: 96422 RVA: 0x0035C210 File Offset: 0x0035A410
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060178A7 RID: 96423 RVA: 0x0035C21D File Offset: 0x0035A41D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060178A8 RID: 96424 RVA: 0x0035C224 File Offset: 0x0035A424
		public static IEavesdropGamePlayConfig GetRootAsIEavesdropGamePlayConfig(ByteBuffer _bb)
		{
			return IEavesdropGamePlayConfig.GetRootAsIEavesdropGamePlayConfig(_bb, default(IEavesdropGamePlayConfig));
		}

		// Token: 0x060178A9 RID: 96425 RVA: 0x0035C240 File Offset: 0x0035A440
		public static IEavesdropGamePlayConfig GetRootAsIEavesdropGamePlayConfig(ByteBuffer _bb, IEavesdropGamePlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060178AA RID: 96426 RVA: 0x0035C25D File Offset: 0x0035A45D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060178AB RID: 96427 RVA: 0x0035C26C File Offset: 0x0035A46C
		public IEavesdropGamePlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700736A RID: 29546
		// (get) Token: 0x060178AC RID: 96428 RVA: 0x0035C27C File Offset: 0x0035A47C
		public ESpecialGamePlayConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialGamePlayConfigType.Stalking;
				}
				return (ESpecialGamePlayConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700736B RID: 29547
		// (get) Token: 0x060178AD RID: 96429 RVA: 0x0035C2B8 File Offset: 0x0035A4B8
		public int EavesdropEntityId
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

		// Token: 0x1700736C RID: 29548
		// (get) Token: 0x060178AE RID: 96430 RVA: 0x0035C2F4 File Offset: 0x0035A4F4
		public int HintRangeEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700736D RID: 29549
		// (get) Token: 0x060178AF RID: 96431 RVA: 0x0035C330 File Offset: 0x0035A530
		public int ListenableRangeEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700736E RID: 29550
		// (get) Token: 0x060178B0 RID: 96432 RVA: 0x0035C370 File Offset: 0x0035A570
		public int TooCloseRangeEntityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700736F RID: 29551
		// (get) Token: 0x060178B1 RID: 96433 RVA: 0x0035C3B0 File Offset: 0x0035A5B0
		public int HintTag
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007370 RID: 29552
		// (get) Token: 0x060178B2 RID: 96434 RVA: 0x0035C3F0 File Offset: 0x0035A5F0
		public int ListenableTag
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007371 RID: 29553
		// (get) Token: 0x060178B3 RID: 96435 RVA: 0x0035C430 File Offset: 0x0035A630
		public int TooCloseTag
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007372 RID: 29554
		// (get) Token: 0x060178B4 RID: 96436 RVA: 0x0035C470 File Offset: 0x0035A670
		public int ListenedTag
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007373 RID: 29555
		// (get) Token: 0x060178B5 RID: 96437 RVA: 0x0035C4B0 File Offset: 0x0035A6B0
		public int EavesdroppingTag
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007374 RID: 29556
		// (get) Token: 0x060178B6 RID: 96438 RVA: 0x0035C4F0 File Offset: 0x0035A6F0
		public bool BlockInteractOnListen
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007375 RID: 29557
		// (get) Token: 0x060178B7 RID: 96439 RVA: 0x0035C530 File Offset: 0x0035A730
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060178B8 RID: 96440 RVA: 0x0035C570 File Offset: 0x0035A770
		public static Offset<IEavesdropGamePlayConfig> CreateIEavesdropGamePlayConfig(FlatBufferBuilder builder, ESpecialGamePlayConfigType Type = ESpecialGamePlayConfigType.Stalking, int EavesdropEntityId = 0, int HintRangeEntityId = 0, int ListenableRangeEntityId = 0, int TooCloseRangeEntityId = 0, int HintTag = 0, int ListenableTag = 0, int TooCloseTag = 0, int ListenedTag = 0, int EavesdroppingTag = 0, bool BlockInteractOnListen = false, byte NullMask = 0)
		{
			builder.StartTable(12);
			IEavesdropGamePlayConfig.AddEavesdroppingTag(builder, EavesdroppingTag);
			IEavesdropGamePlayConfig.AddListenedTag(builder, ListenedTag);
			IEavesdropGamePlayConfig.AddTooCloseTag(builder, TooCloseTag);
			IEavesdropGamePlayConfig.AddListenableTag(builder, ListenableTag);
			IEavesdropGamePlayConfig.AddHintTag(builder, HintTag);
			IEavesdropGamePlayConfig.AddTooCloseRangeEntityId(builder, TooCloseRangeEntityId);
			IEavesdropGamePlayConfig.AddListenableRangeEntityId(builder, ListenableRangeEntityId);
			IEavesdropGamePlayConfig.AddHintRangeEntityId(builder, HintRangeEntityId);
			IEavesdropGamePlayConfig.AddEavesdropEntityId(builder, EavesdropEntityId);
			IEavesdropGamePlayConfig.AddNullMask(builder, NullMask);
			IEavesdropGamePlayConfig.AddBlockInteractOnListen(builder, BlockInteractOnListen);
			IEavesdropGamePlayConfig.AddType(builder, Type);
			return IEavesdropGamePlayConfig.EndIEavesdropGamePlayConfig(builder);
		}

		// Token: 0x060178B9 RID: 96441 RVA: 0x0035C5E8 File Offset: 0x0035A7E8
		public static void StartIEavesdropGamePlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x060178BA RID: 96442 RVA: 0x0035C5F2 File Offset: 0x0035A7F2
		public static void AddType(FlatBufferBuilder builder, ESpecialGamePlayConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060178BB RID: 96443 RVA: 0x0035C5FD File Offset: 0x0035A7FD
		public static void AddEavesdropEntityId(FlatBufferBuilder builder, int eavesdropEntityId)
		{
			builder.AddInt(1, eavesdropEntityId, 0);
		}

		// Token: 0x060178BC RID: 96444 RVA: 0x0035C608 File Offset: 0x0035A808
		public static void AddHintRangeEntityId(FlatBufferBuilder builder, int hintRangeEntityId)
		{
			builder.AddInt(2, hintRangeEntityId, 0);
		}

		// Token: 0x060178BD RID: 96445 RVA: 0x0035C613 File Offset: 0x0035A813
		public static void AddListenableRangeEntityId(FlatBufferBuilder builder, int listenableRangeEntityId)
		{
			builder.AddInt(3, listenableRangeEntityId, 0);
		}

		// Token: 0x060178BE RID: 96446 RVA: 0x0035C61E File Offset: 0x0035A81E
		public static void AddTooCloseRangeEntityId(FlatBufferBuilder builder, int tooCloseRangeEntityId)
		{
			builder.AddInt(4, tooCloseRangeEntityId, 0);
		}

		// Token: 0x060178BF RID: 96447 RVA: 0x0035C629 File Offset: 0x0035A829
		public static void AddHintTag(FlatBufferBuilder builder, int hintTag)
		{
			builder.AddInt(5, hintTag, 0);
		}

		// Token: 0x060178C0 RID: 96448 RVA: 0x0035C634 File Offset: 0x0035A834
		public static void AddListenableTag(FlatBufferBuilder builder, int listenableTag)
		{
			builder.AddInt(6, listenableTag, 0);
		}

		// Token: 0x060178C1 RID: 96449 RVA: 0x0035C63F File Offset: 0x0035A83F
		public static void AddTooCloseTag(FlatBufferBuilder builder, int tooCloseTag)
		{
			builder.AddInt(7, tooCloseTag, 0);
		}

		// Token: 0x060178C2 RID: 96450 RVA: 0x0035C64A File Offset: 0x0035A84A
		public static void AddListenedTag(FlatBufferBuilder builder, int listenedTag)
		{
			builder.AddInt(8, listenedTag, 0);
		}

		// Token: 0x060178C3 RID: 96451 RVA: 0x0035C655 File Offset: 0x0035A855
		public static void AddEavesdroppingTag(FlatBufferBuilder builder, int eavesdroppingTag)
		{
			builder.AddInt(9, eavesdroppingTag, 0);
		}

		// Token: 0x060178C4 RID: 96452 RVA: 0x0035C661 File Offset: 0x0035A861
		public static void AddBlockInteractOnListen(FlatBufferBuilder builder, bool blockInteractOnListen)
		{
			builder.AddBool(10, blockInteractOnListen, false);
		}

		// Token: 0x060178C5 RID: 96453 RVA: 0x0035C66D File Offset: 0x0035A86D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x060178C6 RID: 96454 RVA: 0x0035C679 File Offset: 0x0035A879
		public static Offset<IEavesdropGamePlayConfig> EndIEavesdropGamePlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEavesdropGamePlayConfig>(builder.EndTable());
		}

		// Token: 0x060178C7 RID: 96455 RVA: 0x0035C688 File Offset: 0x0035A888
		public IEavesdropGamePlayConfigT UnPack()
		{
			IEavesdropGamePlayConfigT eavesdropGamePlayConfigT = new IEavesdropGamePlayConfigT();
			this.UnPackTo(eavesdropGamePlayConfigT);
			return eavesdropGamePlayConfigT;
		}

		// Token: 0x060178C8 RID: 96456 RVA: 0x0035C6A4 File Offset: 0x0035A8A4
		public void UnPackTo(IEavesdropGamePlayConfigT _o)
		{
			_o.Type = this.Type;
			_o.EavesdropEntityId = this.EavesdropEntityId;
			_o.HintRangeEntityId = this.HintRangeEntityId;
			_o.ListenableRangeEntityId = this.ListenableRangeEntityId;
			_o.TooCloseRangeEntityId = this.TooCloseRangeEntityId;
			_o.HintTag = this.HintTag;
			_o.ListenableTag = this.ListenableTag;
			_o.TooCloseTag = this.TooCloseTag;
			_o.ListenedTag = this.ListenedTag;
			_o.EavesdroppingTag = this.EavesdroppingTag;
			_o.BlockInteractOnListen = this.BlockInteractOnListen;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060178C9 RID: 96457 RVA: 0x0035C744 File Offset: 0x0035A944
		public static Offset<IEavesdropGamePlayConfig> Pack(FlatBufferBuilder builder, IEavesdropGamePlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEavesdropGamePlayConfig>);
			}
			return IEavesdropGamePlayConfig.CreateIEavesdropGamePlayConfig(builder, _o.Type, _o.EavesdropEntityId, _o.HintRangeEntityId, _o.ListenableRangeEntityId, _o.TooCloseRangeEntityId, _o.HintTag, _o.ListenableTag, _o.TooCloseTag, _o.ListenedTag, _o.EavesdroppingTag, _o.BlockInteractOnListen, _o.NullMask);
		}

		// Token: 0x0400C117 RID: 49431
		private Table __p;
	}
}
