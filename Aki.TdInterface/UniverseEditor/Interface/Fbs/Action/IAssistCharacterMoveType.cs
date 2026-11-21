using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006805 RID: 26629
	public struct IAssistCharacterMoveType : IFlatbufferObject
	{
		// Token: 0x1700C3BF RID: 50111
		// (get) Token: 0x0602D7C9 RID: 186313 RVA: 0x0063A2B8 File Offset: 0x006384B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D7CA RID: 186314 RVA: 0x0063A2C5 File Offset: 0x006384C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D7CB RID: 186315 RVA: 0x0063A2CC File Offset: 0x006384CC
		public static IAssistCharacterMoveType GetRootAsIAssistCharacterMoveType(ByteBuffer _bb)
		{
			return IAssistCharacterMoveType.GetRootAsIAssistCharacterMoveType(_bb, default(IAssistCharacterMoveType));
		}

		// Token: 0x0602D7CC RID: 186316 RVA: 0x0063A2E8 File Offset: 0x006384E8
		public static IAssistCharacterMoveType GetRootAsIAssistCharacterMoveType(ByteBuffer _bb, IAssistCharacterMoveType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D7CD RID: 186317 RVA: 0x0063A305 File Offset: 0x00638505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D7CE RID: 186318 RVA: 0x0063A314 File Offset: 0x00638514
		public IAssistCharacterMoveType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3C0 RID: 50112
		// (get) Token: 0x0602D7CF RID: 186319 RVA: 0x0063A324 File Offset: 0x00638524
		public EAssistCharacterMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAssistCharacterMoveType.Navigation;
				}
				return (EAssistCharacterMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D7D0 RID: 186320 RVA: 0x0063A360 File Offset: 0x00638560
		public static Offset<IAssistCharacterMoveType> CreateIAssistCharacterMoveType(FlatBufferBuilder builder, EAssistCharacterMoveType Type = EAssistCharacterMoveType.Navigation)
		{
			builder.StartTable(1);
			IAssistCharacterMoveType.AddType(builder, Type);
			return IAssistCharacterMoveType.EndIAssistCharacterMoveType(builder);
		}

		// Token: 0x0602D7D1 RID: 186321 RVA: 0x0063A376 File Offset: 0x00638576
		public static void StartIAssistCharacterMoveType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D7D2 RID: 186322 RVA: 0x0063A37F File Offset: 0x0063857F
		public static void AddType(FlatBufferBuilder builder, EAssistCharacterMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D7D3 RID: 186323 RVA: 0x0063A38A File Offset: 0x0063858A
		public static Offset<IAssistCharacterMoveType> EndIAssistCharacterMoveType(FlatBufferBuilder builder)
		{
			return new Offset<IAssistCharacterMoveType>(builder.EndTable());
		}

		// Token: 0x0602D7D4 RID: 186324 RVA: 0x0063A398 File Offset: 0x00638598
		public IAssistCharacterMoveTypeT UnPack()
		{
			IAssistCharacterMoveTypeT assistCharacterMoveTypeT = new IAssistCharacterMoveTypeT();
			this.UnPackTo(assistCharacterMoveTypeT);
			return assistCharacterMoveTypeT;
		}

		// Token: 0x0602D7D5 RID: 186325 RVA: 0x0063A3B3 File Offset: 0x006385B3
		public void UnPackTo(IAssistCharacterMoveTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D7D6 RID: 186326 RVA: 0x0063A3C4 File Offset: 0x006385C4
		public static Offset<IAssistCharacterMoveType> Pack(FlatBufferBuilder builder, IAssistCharacterMoveTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAssistCharacterMoveType>);
			}
			return IAssistCharacterMoveType.CreateIAssistCharacterMoveType(builder, _o.Type);
		}

		// Token: 0x040114B9 RID: 70841
		private Table __p;
	}
}
