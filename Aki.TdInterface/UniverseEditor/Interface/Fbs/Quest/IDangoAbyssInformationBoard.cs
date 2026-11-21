using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041DB RID: 16859
	public struct IDangoAbyssInformationBoard : IFlatbufferObject
	{
		// Token: 0x170072E2 RID: 29410
		// (get) Token: 0x06017642 RID: 95810 RVA: 0x00358090 File Offset: 0x00356290
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017643 RID: 95811 RVA: 0x0035809D File Offset: 0x0035629D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017644 RID: 95812 RVA: 0x003580A4 File Offset: 0x003562A4
		public static IDangoAbyssInformationBoard GetRootAsIDangoAbyssInformationBoard(ByteBuffer _bb)
		{
			return IDangoAbyssInformationBoard.GetRootAsIDangoAbyssInformationBoard(_bb, default(IDangoAbyssInformationBoard));
		}

		// Token: 0x06017645 RID: 95813 RVA: 0x003580C0 File Offset: 0x003562C0
		public static IDangoAbyssInformationBoard GetRootAsIDangoAbyssInformationBoard(ByteBuffer _bb, IDangoAbyssInformationBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017646 RID: 95814 RVA: 0x003580DD File Offset: 0x003562DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017647 RID: 95815 RVA: 0x003580EC File Offset: 0x003562EC
		public IDangoAbyssInformationBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072E3 RID: 29411
		// (get) Token: 0x06017648 RID: 95816 RVA: 0x003580FC File Offset: 0x003562FC
		public EInformationBoardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInformationBoardType.DangoAbyss;
				}
				return (EInformationBoardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017649 RID: 95817 RVA: 0x00358138 File Offset: 0x00356338
		public static Offset<IDangoAbyssInformationBoard> CreateIDangoAbyssInformationBoard(FlatBufferBuilder builder, EInformationBoardType Type = EInformationBoardType.DangoAbyss)
		{
			builder.StartTable(1);
			IDangoAbyssInformationBoard.AddType(builder, Type);
			return IDangoAbyssInformationBoard.EndIDangoAbyssInformationBoard(builder);
		}

		// Token: 0x0601764A RID: 95818 RVA: 0x0035814E File Offset: 0x0035634E
		public static void StartIDangoAbyssInformationBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601764B RID: 95819 RVA: 0x00358157 File Offset: 0x00356357
		public static void AddType(FlatBufferBuilder builder, EInformationBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601764C RID: 95820 RVA: 0x00358162 File Offset: 0x00356362
		public static Offset<IDangoAbyssInformationBoard> EndIDangoAbyssInformationBoard(FlatBufferBuilder builder)
		{
			return new Offset<IDangoAbyssInformationBoard>(builder.EndTable());
		}

		// Token: 0x0601764D RID: 95821 RVA: 0x00358170 File Offset: 0x00356370
		public IDangoAbyssInformationBoardT UnPack()
		{
			IDangoAbyssInformationBoardT dangoAbyssInformationBoardT = new IDangoAbyssInformationBoardT();
			this.UnPackTo(dangoAbyssInformationBoardT);
			return dangoAbyssInformationBoardT;
		}

		// Token: 0x0601764E RID: 95822 RVA: 0x0035818B File Offset: 0x0035638B
		public void UnPackTo(IDangoAbyssInformationBoardT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601764F RID: 95823 RVA: 0x0035819C File Offset: 0x0035639C
		public static Offset<IDangoAbyssInformationBoard> Pack(FlatBufferBuilder builder, IDangoAbyssInformationBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoAbyssInformationBoard>);
			}
			return IDangoAbyssInformationBoard.CreateIDangoAbyssInformationBoard(builder, _o.Type);
		}

		// Token: 0x0400C0B3 RID: 49331
		private Table __p;
	}
}
