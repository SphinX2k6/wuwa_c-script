using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200438B RID: 17291
	public struct IMowBuffDistribute : IFlatbufferObject
	{
		// Token: 0x170076A3 RID: 30371
		// (get) Token: 0x0601870C RID: 100108 RVA: 0x0037BDE3 File Offset: 0x00379FE3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601870D RID: 100109 RVA: 0x0037BDF0 File Offset: 0x00379FF0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601870E RID: 100110 RVA: 0x0037BDF8 File Offset: 0x00379FF8
		public static IMowBuffDistribute GetRootAsIMowBuffDistribute(ByteBuffer _bb)
		{
			return IMowBuffDistribute.GetRootAsIMowBuffDistribute(_bb, default(IMowBuffDistribute));
		}

		// Token: 0x0601870F RID: 100111 RVA: 0x0037BE14 File Offset: 0x0037A014
		public static IMowBuffDistribute GetRootAsIMowBuffDistribute(ByteBuffer _bb, IMowBuffDistribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018710 RID: 100112 RVA: 0x0037BE31 File Offset: 0x0037A031
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018711 RID: 100113 RVA: 0x0037BE40 File Offset: 0x0037A040
		public IMowBuffDistribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076A4 RID: 30372
		// (get) Token: 0x06018712 RID: 100114 RVA: 0x0037BE50 File Offset: 0x0037A050
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

		// Token: 0x170076A5 RID: 30373
		// (get) Token: 0x06018713 RID: 100115 RVA: 0x0037BE8C File Offset: 0x0037A08C
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

		// Token: 0x06018714 RID: 100116 RVA: 0x0037BEC8 File Offset: 0x0037A0C8
		public static Offset<IMowBuffDistribute> CreateIMowBuffDistribute(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, int BoardId = 0)
		{
			builder.StartTable(2);
			IMowBuffDistribute.AddBoardId(builder, BoardId);
			IMowBuffDistribute.AddType(builder, Type);
			return IMowBuffDistribute.EndIMowBuffDistribute(builder);
		}

		// Token: 0x06018715 RID: 100117 RVA: 0x0037BEE5 File Offset: 0x0037A0E5
		public static void StartIMowBuffDistribute(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018716 RID: 100118 RVA: 0x0037BEEE File Offset: 0x0037A0EE
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018717 RID: 100119 RVA: 0x0037BEF9 File Offset: 0x0037A0F9
		public static void AddBoardId(FlatBufferBuilder builder, int boardId)
		{
			builder.AddInt(1, boardId, 0);
		}

		// Token: 0x06018718 RID: 100120 RVA: 0x0037BF04 File Offset: 0x0037A104
		public static Offset<IMowBuffDistribute> EndIMowBuffDistribute(FlatBufferBuilder builder)
		{
			return new Offset<IMowBuffDistribute>(builder.EndTable());
		}

		// Token: 0x06018719 RID: 100121 RVA: 0x0037BF14 File Offset: 0x0037A114
		public IMowBuffDistributeT UnPack()
		{
			IMowBuffDistributeT mowBuffDistributeT = new IMowBuffDistributeT();
			this.UnPackTo(mowBuffDistributeT);
			return mowBuffDistributeT;
		}

		// Token: 0x0601871A RID: 100122 RVA: 0x0037BF2F File Offset: 0x0037A12F
		public void UnPackTo(IMowBuffDistributeT _o)
		{
			_o.Type = this.Type;
			_o.BoardId = this.BoardId;
		}

		// Token: 0x0601871B RID: 100123 RVA: 0x0037BF4C File Offset: 0x0037A14C
		public static Offset<IMowBuffDistribute> Pack(FlatBufferBuilder builder, IMowBuffDistributeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMowBuffDistribute>);
			}
			return IMowBuffDistribute.CreateIMowBuffDistribute(builder, _o.Type, _o.BoardId);
		}

		// Token: 0x0400C33C RID: 49980
		private Table __p;
	}
}
