using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006314 RID: 25364
	public struct IChangePhantom : IFlatbufferObject
	{
		// Token: 0x1700BD57 RID: 48471
		// (get) Token: 0x0602BDDB RID: 179675 RVA: 0x00608384 File Offset: 0x00606584
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BDDC RID: 179676 RVA: 0x00608391 File Offset: 0x00606591
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BDDD RID: 179677 RVA: 0x00608398 File Offset: 0x00606598
		public static IChangePhantom GetRootAsIChangePhantom(ByteBuffer _bb)
		{
			return IChangePhantom.GetRootAsIChangePhantom(_bb, default(IChangePhantom));
		}

		// Token: 0x0602BDDE RID: 179678 RVA: 0x006083B4 File Offset: 0x006065B4
		public static IChangePhantom GetRootAsIChangePhantom(ByteBuffer _bb, IChangePhantom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BDDF RID: 179679 RVA: 0x006083D1 File Offset: 0x006065D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BDE0 RID: 179680 RVA: 0x006083E0 File Offset: 0x006065E0
		public IChangePhantom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD58 RID: 48472
		// (get) Token: 0x0602BDE1 RID: 179681 RVA: 0x006083F0 File Offset: 0x006065F0
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

		// Token: 0x0602BDE2 RID: 179682 RVA: 0x0060842C File Offset: 0x0060662C
		public static Offset<IChangePhantom> CreateIChangePhantom(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			IChangePhantom.AddId(builder, Id);
			return IChangePhantom.EndIChangePhantom(builder);
		}

		// Token: 0x0602BDE3 RID: 179683 RVA: 0x00608442 File Offset: 0x00606642
		public static void StartIChangePhantom(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BDE4 RID: 179684 RVA: 0x0060844B File Offset: 0x0060664B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602BDE5 RID: 179685 RVA: 0x00608456 File Offset: 0x00606656
		public static Offset<IChangePhantom> EndIChangePhantom(FlatBufferBuilder builder)
		{
			return new Offset<IChangePhantom>(builder.EndTable());
		}

		// Token: 0x0602BDE6 RID: 179686 RVA: 0x00608464 File Offset: 0x00606664
		public IChangePhantomT UnPack()
		{
			IChangePhantomT changePhantomT = new IChangePhantomT();
			this.UnPackTo(changePhantomT);
			return changePhantomT;
		}

		// Token: 0x0602BDE7 RID: 179687 RVA: 0x0060847F File Offset: 0x0060667F
		public void UnPackTo(IChangePhantomT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x0602BDE8 RID: 179688 RVA: 0x00608490 File Offset: 0x00606690
		public static Offset<IChangePhantom> Pack(FlatBufferBuilder builder, IChangePhantomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangePhantom>);
			}
			return IChangePhantom.CreateIChangePhantom(builder, _o.Id);
		}

		// Token: 0x040108D6 RID: 67798
		private Table __p;
	}
}
