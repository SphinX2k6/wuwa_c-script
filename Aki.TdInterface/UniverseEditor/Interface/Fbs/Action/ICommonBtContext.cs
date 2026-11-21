using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ACA RID: 27338
	public struct ICommonBtContext : IFlatbufferObject
	{
		// Token: 0x1700C8BF RID: 51391
		// (get) Token: 0x0602EEC9 RID: 192201 RVA: 0x00664445 File Offset: 0x00662645
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EECA RID: 192202 RVA: 0x00664452 File Offset: 0x00662652
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EECB RID: 192203 RVA: 0x0066445C File Offset: 0x0066265C
		public static ICommonBtContext GetRootAsICommonBtContext(ByteBuffer _bb)
		{
			return ICommonBtContext.GetRootAsICommonBtContext(_bb, default(ICommonBtContext));
		}

		// Token: 0x0602EECC RID: 192204 RVA: 0x00664478 File Offset: 0x00662678
		public static ICommonBtContext GetRootAsICommonBtContext(ByteBuffer _bb, ICommonBtContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EECD RID: 192205 RVA: 0x00664495 File Offset: 0x00662695
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EECE RID: 192206 RVA: 0x006644A4 File Offset: 0x006626A4
		public ICommonBtContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8C0 RID: 51392
		// (get) Token: 0x0602EECF RID: 192207 RVA: 0x006644B4 File Offset: 0x006626B4
		public EVarContext Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVarContext.None;
				}
				return (EVarContext)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C8C1 RID: 51393
		// (get) Token: 0x0602EED0 RID: 192208 RVA: 0x006644F0 File Offset: 0x006626F0
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

		// Token: 0x0602EED1 RID: 192209 RVA: 0x0066452C File Offset: 0x0066272C
		public static Offset<ICommonBtContext> CreateICommonBtContext(FlatBufferBuilder builder, EVarContext Type = EVarContext.None, int Id = 0)
		{
			builder.StartTable(2);
			ICommonBtContext.AddId(builder, Id);
			ICommonBtContext.AddType(builder, Type);
			return ICommonBtContext.EndICommonBtContext(builder);
		}

		// Token: 0x0602EED2 RID: 192210 RVA: 0x00664549 File Offset: 0x00662749
		public static void StartICommonBtContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EED3 RID: 192211 RVA: 0x00664552 File Offset: 0x00662752
		public static void AddType(FlatBufferBuilder builder, EVarContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EED4 RID: 192212 RVA: 0x0066455D File Offset: 0x0066275D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602EED5 RID: 192213 RVA: 0x00664568 File Offset: 0x00662768
		public static Offset<ICommonBtContext> EndICommonBtContext(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtContext>(builder.EndTable());
		}

		// Token: 0x0602EED6 RID: 192214 RVA: 0x00664578 File Offset: 0x00662778
		public ICommonBtContextT UnPack()
		{
			ICommonBtContextT commonBtContextT = new ICommonBtContextT();
			this.UnPackTo(commonBtContextT);
			return commonBtContextT;
		}

		// Token: 0x0602EED7 RID: 192215 RVA: 0x00664593 File Offset: 0x00662793
		public void UnPackTo(ICommonBtContextT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602EED8 RID: 192216 RVA: 0x006645B0 File Offset: 0x006627B0
		public static Offset<ICommonBtContext> Pack(FlatBufferBuilder builder, ICommonBtContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtContext>);
			}
			return ICommonBtContext.CreateICommonBtContext(builder, _o.Type, _o.Id);
		}

		// Token: 0x0401186A RID: 71786
		private Table __p;
	}
}
