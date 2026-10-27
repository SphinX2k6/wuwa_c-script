using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F4D RID: 16205
	public struct IMowBuffDistribute : IFlatbufferObject
	{
		// Token: 0x170070B2 RID: 28850
		// (get) Token: 0x060170AA RID: 94378 RVA: 0x0035296F File Offset: 0x00350B6F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060170AB RID: 94379 RVA: 0x0035297C File Offset: 0x00350B7C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060170AC RID: 94380 RVA: 0x00352984 File Offset: 0x00350B84
		public static IMowBuffDistribute GetRootAsIMowBuffDistribute(ByteBuffer _bb)
		{
			return IMowBuffDistribute.GetRootAsIMowBuffDistribute(_bb, default(IMowBuffDistribute));
		}

		// Token: 0x060170AD RID: 94381 RVA: 0x003529A0 File Offset: 0x00350BA0
		public static IMowBuffDistribute GetRootAsIMowBuffDistribute(ByteBuffer _bb, IMowBuffDistribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060170AE RID: 94382 RVA: 0x003529BD File Offset: 0x00350BBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060170AF RID: 94383 RVA: 0x003529CC File Offset: 0x00350BCC
		public IMowBuffDistribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070B3 RID: 28851
		// (get) Token: 0x060170B0 RID: 94384 RVA: 0x003529DC File Offset: 0x00350BDC
		public EShowUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowUiType.All;
				}
				return (EShowUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170070B4 RID: 28852
		// (get) Token: 0x060170B1 RID: 94385 RVA: 0x00352A18 File Offset: 0x00350C18
		public int BoardId
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

		// Token: 0x060170B2 RID: 94386 RVA: 0x00352A54 File Offset: 0x00350C54
		public static Offset<IMowBuffDistribute> CreateIMowBuffDistribute(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, int BoardId = 0)
		{
			builder.StartTable(2);
			IMowBuffDistribute.AddBoardId(builder, BoardId);
			IMowBuffDistribute.AddType(builder, Type);
			return IMowBuffDistribute.EndIMowBuffDistribute(builder);
		}

		// Token: 0x060170B3 RID: 94387 RVA: 0x00352A71 File Offset: 0x00350C71
		public static void StartIMowBuffDistribute(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060170B4 RID: 94388 RVA: 0x00352A7A File Offset: 0x00350C7A
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060170B5 RID: 94389 RVA: 0x00352A85 File Offset: 0x00350C85
		public static void AddBoardId(FlatBufferBuilder builder, int boardId)
		{
			builder.AddInt(1, boardId, 0);
		}

		// Token: 0x060170B6 RID: 94390 RVA: 0x00352A90 File Offset: 0x00350C90
		public static Offset<IMowBuffDistribute> EndIMowBuffDistribute(FlatBufferBuilder builder)
		{
			return new Offset<IMowBuffDistribute>(builder.EndTable());
		}

		// Token: 0x060170B7 RID: 94391 RVA: 0x00352AA0 File Offset: 0x00350CA0
		public IMowBuffDistributeT UnPack()
		{
			IMowBuffDistributeT mowBuffDistributeT = new IMowBuffDistributeT();
			this.UnPackTo(mowBuffDistributeT);
			return mowBuffDistributeT;
		}

		// Token: 0x060170B8 RID: 94392 RVA: 0x00352ABB File Offset: 0x00350CBB
		public void UnPackTo(IMowBuffDistributeT _o)
		{
			_o.Type = this.Type;
			_o.BoardId = this.BoardId;
		}

		// Token: 0x060170B9 RID: 94393 RVA: 0x00352AD8 File Offset: 0x00350CD8
		public static Offset<IMowBuffDistribute> Pack(FlatBufferBuilder builder, IMowBuffDistributeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMowBuffDistribute>);
			}
			return IMowBuffDistribute.CreateIMowBuffDistribute(builder, _o.Type, _o.BoardId);
		}

		// Token: 0x0400B95E RID: 47454
		private Table __p;
	}
}
