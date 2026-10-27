using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060DA RID: 24794
	public struct IActorLookAtEmptyData : IFlatbufferObject
	{
		// Token: 0x1700B6B2 RID: 46770
		// (get) Token: 0x0602A588 RID: 173448 RVA: 0x005D61B4 File Offset: 0x005D43B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A589 RID: 173449 RVA: 0x005D61C1 File Offset: 0x005D43C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A58A RID: 173450 RVA: 0x005D61C8 File Offset: 0x005D43C8
		public static IActorLookAtEmptyData GetRootAsIActorLookAtEmptyData(ByteBuffer _bb)
		{
			return IActorLookAtEmptyData.GetRootAsIActorLookAtEmptyData(_bb, default(IActorLookAtEmptyData));
		}

		// Token: 0x0602A58B RID: 173451 RVA: 0x005D61E4 File Offset: 0x005D43E4
		public static IActorLookAtEmptyData GetRootAsIActorLookAtEmptyData(ByteBuffer _bb, IActorLookAtEmptyData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A58C RID: 173452 RVA: 0x005D6201 File Offset: 0x005D4401
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A58D RID: 173453 RVA: 0x005D6210 File Offset: 0x005D4410
		public IActorLookAtEmptyData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6B3 RID: 46771
		// (get) Token: 0x0602A58E RID: 173454 RVA: 0x005D6220 File Offset: 0x005D4420
		public EActorLookAtMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorLookAtMode.Talker;
				}
				return (EActorLookAtMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B6B4 RID: 46772
		// (get) Token: 0x0602A58F RID: 173455 RVA: 0x005D625C File Offset: 0x005D445C
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B6B5 RID: 46773
		// (get) Token: 0x0602A590 RID: 173456 RVA: 0x005D629C File Offset: 0x005D449C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A591 RID: 173457 RVA: 0x005D62D8 File Offset: 0x005D44D8
		public static Offset<IActorLookAtEmptyData> CreateIActorLookAtEmptyData(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker, bool Lock = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorLookAtEmptyData.AddNullMask(builder, NullMask);
			IActorLookAtEmptyData.AddLock(builder, Lock);
			IActorLookAtEmptyData.AddType(builder, Type);
			return IActorLookAtEmptyData.EndIActorLookAtEmptyData(builder);
		}

		// Token: 0x0602A592 RID: 173458 RVA: 0x005D62FC File Offset: 0x005D44FC
		public static void StartIActorLookAtEmptyData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A593 RID: 173459 RVA: 0x005D6305 File Offset: 0x005D4505
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A594 RID: 173460 RVA: 0x005D6310 File Offset: 0x005D4510
		public static void AddLock(FlatBufferBuilder builder, bool @lock)
		{
			builder.AddBool(1, @lock, false);
		}

		// Token: 0x0602A595 RID: 173461 RVA: 0x005D631B File Offset: 0x005D451B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A596 RID: 173462 RVA: 0x005D6326 File Offset: 0x005D4526
		public static Offset<IActorLookAtEmptyData> EndIActorLookAtEmptyData(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtEmptyData>(builder.EndTable());
		}

		// Token: 0x0602A597 RID: 173463 RVA: 0x005D6334 File Offset: 0x005D4534
		public IActorLookAtEmptyDataT UnPack()
		{
			IActorLookAtEmptyDataT actorLookAtEmptyDataT = new IActorLookAtEmptyDataT();
			this.UnPackTo(actorLookAtEmptyDataT);
			return actorLookAtEmptyDataT;
		}

		// Token: 0x0602A598 RID: 173464 RVA: 0x005D634F File Offset: 0x005D454F
		public void UnPackTo(IActorLookAtEmptyDataT _o)
		{
			_o.Type = this.Type;
			_o.Lock = this.Lock;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A599 RID: 173465 RVA: 0x005D6378 File Offset: 0x005D4578
		public static Offset<IActorLookAtEmptyData> Pack(FlatBufferBuilder builder, IActorLookAtEmptyDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtEmptyData>);
			}
			return IActorLookAtEmptyData.CreateIActorLookAtEmptyData(builder, _o.Type, _o.Lock, _o.NullMask);
		}

		// Token: 0x04010493 RID: 66707
		private Table __p;
	}
}
