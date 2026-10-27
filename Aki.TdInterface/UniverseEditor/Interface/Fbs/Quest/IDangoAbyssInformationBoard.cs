using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DC4 RID: 15812
	public struct IDangoAbyssInformationBoard : IFlatbufferObject
	{
		// Token: 0x17006D28 RID: 27944
		// (get) Token: 0x06016109 RID: 90377 RVA: 0x00330D08 File Offset: 0x0032EF08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601610A RID: 90378 RVA: 0x00330D15 File Offset: 0x0032EF15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601610B RID: 90379 RVA: 0x00330D1C File Offset: 0x0032EF1C
		public static IDangoAbyssInformationBoard GetRootAsIDangoAbyssInformationBoard(ByteBuffer _bb)
		{
			return IDangoAbyssInformationBoard.GetRootAsIDangoAbyssInformationBoard(_bb, default(IDangoAbyssInformationBoard));
		}

		// Token: 0x0601610C RID: 90380 RVA: 0x00330D38 File Offset: 0x0032EF38
		public static IDangoAbyssInformationBoard GetRootAsIDangoAbyssInformationBoard(ByteBuffer _bb, IDangoAbyssInformationBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601610D RID: 90381 RVA: 0x00330D55 File Offset: 0x0032EF55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601610E RID: 90382 RVA: 0x00330D64 File Offset: 0x0032EF64
		public IDangoAbyssInformationBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D29 RID: 27945
		// (get) Token: 0x0601610F RID: 90383 RVA: 0x00330D74 File Offset: 0x0032EF74
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

		// Token: 0x06016110 RID: 90384 RVA: 0x00330DB0 File Offset: 0x0032EFB0
		public static Offset<IDangoAbyssInformationBoard> CreateIDangoAbyssInformationBoard(FlatBufferBuilder builder, EInformationBoardType Type = EInformationBoardType.DangoAbyss)
		{
			builder.StartTable(1);
			IDangoAbyssInformationBoard.AddType(builder, Type);
			return IDangoAbyssInformationBoard.EndIDangoAbyssInformationBoard(builder);
		}

		// Token: 0x06016111 RID: 90385 RVA: 0x00330DC6 File Offset: 0x0032EFC6
		public static void StartIDangoAbyssInformationBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016112 RID: 90386 RVA: 0x00330DCF File Offset: 0x0032EFCF
		public static void AddType(FlatBufferBuilder builder, EInformationBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016113 RID: 90387 RVA: 0x00330DDA File Offset: 0x0032EFDA
		public static Offset<IDangoAbyssInformationBoard> EndIDangoAbyssInformationBoard(FlatBufferBuilder builder)
		{
			return new Offset<IDangoAbyssInformationBoard>(builder.EndTable());
		}

		// Token: 0x06016114 RID: 90388 RVA: 0x00330DE8 File Offset: 0x0032EFE8
		public IDangoAbyssInformationBoardT UnPack()
		{
			IDangoAbyssInformationBoardT dangoAbyssInformationBoardT = new IDangoAbyssInformationBoardT();
			this.UnPackTo(dangoAbyssInformationBoardT);
			return dangoAbyssInformationBoardT;
		}

		// Token: 0x06016115 RID: 90389 RVA: 0x00330E03 File Offset: 0x0032F003
		public void UnPackTo(IDangoAbyssInformationBoardT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016116 RID: 90390 RVA: 0x00330E14 File Offset: 0x0032F014
		public static Offset<IDangoAbyssInformationBoard> Pack(FlatBufferBuilder builder, IDangoAbyssInformationBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoAbyssInformationBoard>);
			}
			return IDangoAbyssInformationBoard.CreateIDangoAbyssInformationBoard(builder, _o.Type);
		}

		// Token: 0x0400B706 RID: 46854
		private Table __p;
	}
}
