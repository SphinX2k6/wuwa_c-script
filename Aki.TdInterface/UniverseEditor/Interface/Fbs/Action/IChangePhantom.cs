using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006985 RID: 27013
	public struct IChangePhantom : IFlatbufferObject
	{
		// Token: 0x1700C6E1 RID: 50913
		// (get) Token: 0x0602E544 RID: 189764 RVA: 0x00653390 File Offset: 0x00651590
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E545 RID: 189765 RVA: 0x0065339D File Offset: 0x0065159D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E546 RID: 189766 RVA: 0x006533A4 File Offset: 0x006515A4
		public static IChangePhantom GetRootAsIChangePhantom(ByteBuffer _bb)
		{
			return IChangePhantom.GetRootAsIChangePhantom(_bb, default(IChangePhantom));
		}

		// Token: 0x0602E547 RID: 189767 RVA: 0x006533C0 File Offset: 0x006515C0
		public static IChangePhantom GetRootAsIChangePhantom(ByteBuffer _bb, IChangePhantom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E548 RID: 189768 RVA: 0x006533DD File Offset: 0x006515DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E549 RID: 189769 RVA: 0x006533EC File Offset: 0x006515EC
		public IChangePhantom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6E2 RID: 50914
		// (get) Token: 0x0602E54A RID: 189770 RVA: 0x006533FC File Offset: 0x006515FC
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E54B RID: 189771 RVA: 0x00653438 File Offset: 0x00651638
		public static Offset<IChangePhantom> CreateIChangePhantom(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			IChangePhantom.AddId(builder, Id);
			return IChangePhantom.EndIChangePhantom(builder);
		}

		// Token: 0x0602E54C RID: 189772 RVA: 0x0065344E File Offset: 0x0065164E
		public static void StartIChangePhantom(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E54D RID: 189773 RVA: 0x00653457 File Offset: 0x00651657
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602E54E RID: 189774 RVA: 0x00653462 File Offset: 0x00651662
		public static Offset<IChangePhantom> EndIChangePhantom(FlatBufferBuilder builder)
		{
			return new Offset<IChangePhantom>(builder.EndTable());
		}

		// Token: 0x0602E54F RID: 189775 RVA: 0x00653470 File Offset: 0x00651670
		public IChangePhantomT UnPack()
		{
			IChangePhantomT changePhantomT = new IChangePhantomT();
			this.UnPackTo(changePhantomT);
			return changePhantomT;
		}

		// Token: 0x0602E550 RID: 189776 RVA: 0x0065348B File Offset: 0x0065168B
		public void UnPackTo(IChangePhantomT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x0602E551 RID: 189777 RVA: 0x0065349C File Offset: 0x0065169C
		public static Offset<IChangePhantom> Pack(FlatBufferBuilder builder, IChangePhantomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangePhantom>);
			}
			return IChangePhantom.CreateIChangePhantom(builder, _o.Id);
		}

		// Token: 0x040116EC RID: 71404
		private Table __p;
	}
}
