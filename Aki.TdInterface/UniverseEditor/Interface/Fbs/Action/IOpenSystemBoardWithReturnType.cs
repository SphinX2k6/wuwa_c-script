using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C3C RID: 27708
	public struct IOpenSystemBoardWithReturnType : IFlatbufferObject
	{
		// Token: 0x1700CE60 RID: 52832
		// (get) Token: 0x06030CE8 RID: 199912 RVA: 0x006A171D File Offset: 0x0069F91D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030CE9 RID: 199913 RVA: 0x006A172A File Offset: 0x0069F92A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030CEA RID: 199914 RVA: 0x006A1734 File Offset: 0x0069F934
		public static IOpenSystemBoardWithReturnType GetRootAsIOpenSystemBoardWithReturnType(ByteBuffer _bb)
		{
			return IOpenSystemBoardWithReturnType.GetRootAsIOpenSystemBoardWithReturnType(_bb, default(IOpenSystemBoardWithReturnType));
		}

		// Token: 0x06030CEB RID: 199915 RVA: 0x006A1750 File Offset: 0x0069F950
		public static IOpenSystemBoardWithReturnType GetRootAsIOpenSystemBoardWithReturnType(ByteBuffer _bb, IOpenSystemBoardWithReturnType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030CEC RID: 199916 RVA: 0x006A176D File Offset: 0x0069F96D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030CED RID: 199917 RVA: 0x006A177C File Offset: 0x0069F97C
		public IOpenSystemBoardWithReturnType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE61 RID: 52833
		// (get) Token: 0x06030CEE RID: 199918 RVA: 0x006A178C File Offset: 0x0069F98C
		public ESystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemType.Shop;
				}
				return (ESystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030CEF RID: 199919 RVA: 0x006A17C8 File Offset: 0x0069F9C8
		public static Offset<IOpenSystemBoardWithReturnType> CreateIOpenSystemBoardWithReturnType(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop)
		{
			builder.StartTable(1);
			IOpenSystemBoardWithReturnType.AddType(builder, Type);
			return IOpenSystemBoardWithReturnType.EndIOpenSystemBoardWithReturnType(builder);
		}

		// Token: 0x06030CF0 RID: 199920 RVA: 0x006A17DE File Offset: 0x0069F9DE
		public static void StartIOpenSystemBoardWithReturnType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030CF1 RID: 199921 RVA: 0x006A17E7 File Offset: 0x0069F9E7
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030CF2 RID: 199922 RVA: 0x006A17F2 File Offset: 0x0069F9F2
		public static Offset<IOpenSystemBoardWithReturnType> EndIOpenSystemBoardWithReturnType(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSystemBoardWithReturnType>(builder.EndTable());
		}

		// Token: 0x06030CF3 RID: 199923 RVA: 0x006A1800 File Offset: 0x0069FA00
		public IOpenSystemBoardWithReturnTypeT UnPack()
		{
			IOpenSystemBoardWithReturnTypeT openSystemBoardWithReturnTypeT = new IOpenSystemBoardWithReturnTypeT();
			this.UnPackTo(openSystemBoardWithReturnTypeT);
			return openSystemBoardWithReturnTypeT;
		}

		// Token: 0x06030CF4 RID: 199924 RVA: 0x006A181B File Offset: 0x0069FA1B
		public void UnPackTo(IOpenSystemBoardWithReturnTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030CF5 RID: 199925 RVA: 0x006A182C File Offset: 0x0069FA2C
		public static Offset<IOpenSystemBoardWithReturnType> Pack(FlatBufferBuilder builder, IOpenSystemBoardWithReturnTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenSystemBoardWithReturnType>);
			}
			return IOpenSystemBoardWithReturnType.CreateIOpenSystemBoardWithReturnType(builder, _o.Type);
		}

		// Token: 0x0401156F RID: 71023
		private Table __p;
	}
}
