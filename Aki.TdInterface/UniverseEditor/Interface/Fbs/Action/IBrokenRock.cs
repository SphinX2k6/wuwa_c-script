using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006898 RID: 26776
	public struct IBrokenRock : IFlatbufferObject
	{
		// Token: 0x1700C4C2 RID: 50370
		// (get) Token: 0x0602DC59 RID: 187481 RVA: 0x00641BD0 File Offset: 0x0063FDD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DC5A RID: 187482 RVA: 0x00641BDD File Offset: 0x0063FDDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DC5B RID: 187483 RVA: 0x00641BE4 File Offset: 0x0063FDE4
		public static IBrokenRock GetRootAsIBrokenRock(ByteBuffer _bb)
		{
			return IBrokenRock.GetRootAsIBrokenRock(_bb, default(IBrokenRock));
		}

		// Token: 0x0602DC5C RID: 187484 RVA: 0x00641C00 File Offset: 0x0063FE00
		public static IBrokenRock GetRootAsIBrokenRock(ByteBuffer _bb, IBrokenRock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DC5D RID: 187485 RVA: 0x00641C1D File Offset: 0x0063FE1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DC5E RID: 187486 RVA: 0x00641C2C File Offset: 0x0063FE2C
		public IBrokenRock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4C3 RID: 50371
		// (get) Token: 0x0602DC5F RID: 187487 RVA: 0x00641C3C File Offset: 0x0063FE3C
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C4C4 RID: 50372
		// (get) Token: 0x0602DC60 RID: 187488 RVA: 0x00641C78 File Offset: 0x0063FE78
		public int Id
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

		// Token: 0x0602DC61 RID: 187489 RVA: 0x00641CB4 File Offset: 0x0063FEB4
		public static Offset<IBrokenRock> CreateIBrokenRock(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int Id = 0)
		{
			builder.StartTable(2);
			IBrokenRock.AddId(builder, Id);
			IBrokenRock.AddType(builder, Type);
			return IBrokenRock.EndIBrokenRock(builder);
		}

		// Token: 0x0602DC62 RID: 187490 RVA: 0x00641CD1 File Offset: 0x0063FED1
		public static void StartIBrokenRock(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DC63 RID: 187491 RVA: 0x00641CDA File Offset: 0x0063FEDA
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DC64 RID: 187492 RVA: 0x00641CE5 File Offset: 0x0063FEE5
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602DC65 RID: 187493 RVA: 0x00641CF0 File Offset: 0x0063FEF0
		public static Offset<IBrokenRock> EndIBrokenRock(FlatBufferBuilder builder)
		{
			return new Offset<IBrokenRock>(builder.EndTable());
		}

		// Token: 0x0602DC66 RID: 187494 RVA: 0x00641D00 File Offset: 0x0063FF00
		public IBrokenRockT UnPack()
		{
			IBrokenRockT brokenRockT = new IBrokenRockT();
			this.UnPackTo(brokenRockT);
			return brokenRockT;
		}

		// Token: 0x0602DC67 RID: 187495 RVA: 0x00641D1B File Offset: 0x0063FF1B
		public void UnPackTo(IBrokenRockT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602DC68 RID: 187496 RVA: 0x00641D38 File Offset: 0x0063FF38
		public static Offset<IBrokenRock> Pack(FlatBufferBuilder builder, IBrokenRockT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBrokenRock>);
			}
			return IBrokenRock.CreateIBrokenRock(builder, _o.Type, _o.Id);
		}

		// Token: 0x0401157F RID: 71039
		private Table __p;
	}
}
