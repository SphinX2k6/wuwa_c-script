using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A3 RID: 29603
	public struct IOpenSystemBoardWithReturnType : IFlatbufferObject
	{
		// Token: 0x1700D97B RID: 55675
		// (get) Token: 0x06033C41 RID: 212033 RVA: 0x006FBBDD File Offset: 0x006F9DDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033C42 RID: 212034 RVA: 0x006FBBEA File Offset: 0x006F9DEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033C43 RID: 212035 RVA: 0x006FBBF4 File Offset: 0x006F9DF4
		public static IOpenSystemBoardWithReturnType GetRootAsIOpenSystemBoardWithReturnType(ByteBuffer _bb)
		{
			return IOpenSystemBoardWithReturnType.GetRootAsIOpenSystemBoardWithReturnType(_bb, default(IOpenSystemBoardWithReturnType));
		}

		// Token: 0x06033C44 RID: 212036 RVA: 0x006FBC10 File Offset: 0x006F9E10
		public static IOpenSystemBoardWithReturnType GetRootAsIOpenSystemBoardWithReturnType(ByteBuffer _bb, IOpenSystemBoardWithReturnType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033C45 RID: 212037 RVA: 0x006FBC2D File Offset: 0x006F9E2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033C46 RID: 212038 RVA: 0x006FBC3C File Offset: 0x006F9E3C
		public IOpenSystemBoardWithReturnType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D97C RID: 55676
		// (get) Token: 0x06033C47 RID: 212039 RVA: 0x006FBC4C File Offset: 0x006F9E4C
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

		// Token: 0x06033C48 RID: 212040 RVA: 0x006FBC88 File Offset: 0x006F9E88
		public static Offset<IOpenSystemBoardWithReturnType> CreateIOpenSystemBoardWithReturnType(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop)
		{
			builder.StartTable(1);
			IOpenSystemBoardWithReturnType.AddType(builder, Type);
			return IOpenSystemBoardWithReturnType.EndIOpenSystemBoardWithReturnType(builder);
		}

		// Token: 0x06033C49 RID: 212041 RVA: 0x006FBC9E File Offset: 0x006F9E9E
		public static void StartIOpenSystemBoardWithReturnType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033C4A RID: 212042 RVA: 0x006FBCA7 File Offset: 0x006F9EA7
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033C4B RID: 212043 RVA: 0x006FBCB2 File Offset: 0x006F9EB2
		public static Offset<IOpenSystemBoardWithReturnType> EndIOpenSystemBoardWithReturnType(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSystemBoardWithReturnType>(builder.EndTable());
		}

		// Token: 0x06033C4C RID: 212044 RVA: 0x006FBCC0 File Offset: 0x006F9EC0
		public IOpenSystemBoardWithReturnTypeT UnPack()
		{
			IOpenSystemBoardWithReturnTypeT openSystemBoardWithReturnTypeT = new IOpenSystemBoardWithReturnTypeT();
			this.UnPackTo(openSystemBoardWithReturnTypeT);
			return openSystemBoardWithReturnTypeT;
		}

		// Token: 0x06033C4D RID: 212045 RVA: 0x006FBCDB File Offset: 0x006F9EDB
		public void UnPackTo(IOpenSystemBoardWithReturnTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033C4E RID: 212046 RVA: 0x006FBCEC File Offset: 0x006F9EEC
		public static Offset<IOpenSystemBoardWithReturnType> Pack(FlatBufferBuilder builder, IOpenSystemBoardWithReturnTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenSystemBoardWithReturnType>);
			}
			return IOpenSystemBoardWithReturnType.CreateIOpenSystemBoardWithReturnType(builder, _o.Type);
		}

		// Token: 0x040124C6 RID: 74950
		private Table __p;
	}
}
