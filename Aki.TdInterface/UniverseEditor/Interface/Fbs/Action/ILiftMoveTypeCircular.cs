using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A02 RID: 27138
	public struct ILiftMoveTypeCircular : IFlatbufferObject
	{
		// Token: 0x1700C95A RID: 51546
		// (get) Token: 0x0602F7C9 RID: 194505 RVA: 0x006778D9 File Offset: 0x00675AD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F7CA RID: 194506 RVA: 0x006778E6 File Offset: 0x00675AE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F7CB RID: 194507 RVA: 0x006778F0 File Offset: 0x00675AF0
		public static ILiftMoveTypeCircular GetRootAsILiftMoveTypeCircular(ByteBuffer _bb)
		{
			return ILiftMoveTypeCircular.GetRootAsILiftMoveTypeCircular(_bb, default(ILiftMoveTypeCircular));
		}

		// Token: 0x0602F7CC RID: 194508 RVA: 0x0067790C File Offset: 0x00675B0C
		public static ILiftMoveTypeCircular GetRootAsILiftMoveTypeCircular(ByteBuffer _bb, ILiftMoveTypeCircular obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F7CD RID: 194509 RVA: 0x00677929 File Offset: 0x00675B29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F7CE RID: 194510 RVA: 0x00677938 File Offset: 0x00675B38
		public ILiftMoveTypeCircular __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C95B RID: 51547
		// (get) Token: 0x0602F7CF RID: 194511 RVA: 0x00677948 File Offset: 0x00675B48
		public ELiftMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiftMoveType.Default;
				}
				return (ELiftMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F7D0 RID: 194512 RVA: 0x00677984 File Offset: 0x00675B84
		public static Offset<ILiftMoveTypeCircular> CreateILiftMoveTypeCircular(FlatBufferBuilder builder, ELiftMoveType Type = ELiftMoveType.Default)
		{
			builder.StartTable(1);
			ILiftMoveTypeCircular.AddType(builder, Type);
			return ILiftMoveTypeCircular.EndILiftMoveTypeCircular(builder);
		}

		// Token: 0x0602F7D1 RID: 194513 RVA: 0x0067799A File Offset: 0x00675B9A
		public static void StartILiftMoveTypeCircular(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F7D2 RID: 194514 RVA: 0x006779A3 File Offset: 0x00675BA3
		public static void AddType(FlatBufferBuilder builder, ELiftMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F7D3 RID: 194515 RVA: 0x006779AE File Offset: 0x00675BAE
		public static Offset<ILiftMoveTypeCircular> EndILiftMoveTypeCircular(FlatBufferBuilder builder)
		{
			return new Offset<ILiftMoveTypeCircular>(builder.EndTable());
		}

		// Token: 0x0602F7D4 RID: 194516 RVA: 0x006779BC File Offset: 0x00675BBC
		public ILiftMoveTypeCircularT UnPack()
		{
			ILiftMoveTypeCircularT liftMoveTypeCircularT = new ILiftMoveTypeCircularT();
			this.UnPackTo(liftMoveTypeCircularT);
			return liftMoveTypeCircularT;
		}

		// Token: 0x0602F7D5 RID: 194517 RVA: 0x006779D7 File Offset: 0x00675BD7
		public void UnPackTo(ILiftMoveTypeCircularT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F7D6 RID: 194518 RVA: 0x006779E8 File Offset: 0x00675BE8
		public static Offset<ILiftMoveTypeCircular> Pack(FlatBufferBuilder builder, ILiftMoveTypeCircularT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiftMoveTypeCircular>);
			}
			return ILiftMoveTypeCircular.CreateILiftMoveTypeCircular(builder, _o.Type);
		}

		// Token: 0x04011202 RID: 70146
		private Table __p;
	}
}
