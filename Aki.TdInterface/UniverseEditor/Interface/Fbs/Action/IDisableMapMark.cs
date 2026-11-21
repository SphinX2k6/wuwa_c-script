using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C50 RID: 27728
	public struct IDisableMapMark : IFlatbufferObject
	{
		// Token: 0x1700CB41 RID: 52033
		// (get) Token: 0x0602FBB9 RID: 195513 RVA: 0x0068020C File Offset: 0x0067E40C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FBBA RID: 195514 RVA: 0x00680219 File Offset: 0x0067E419
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FBBB RID: 195515 RVA: 0x00680220 File Offset: 0x0067E420
		public static IDisableMapMark GetRootAsIDisableMapMark(ByteBuffer _bb)
		{
			return IDisableMapMark.GetRootAsIDisableMapMark(_bb, default(IDisableMapMark));
		}

		// Token: 0x0602FBBC RID: 195516 RVA: 0x0068023C File Offset: 0x0067E43C
		public static IDisableMapMark GetRootAsIDisableMapMark(ByteBuffer _bb, IDisableMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FBBD RID: 195517 RVA: 0x00680259 File Offset: 0x0067E459
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FBBE RID: 195518 RVA: 0x00680268 File Offset: 0x0067E468
		public IDisableMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB42 RID: 52034
		// (get) Token: 0x0602FBBF RID: 195519 RVA: 0x00680278 File Offset: 0x0067E478
		public EMapMarkState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMapMarkState.Show;
				}
				return (EMapMarkState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB43 RID: 52035
		// (get) Token: 0x0602FBC0 RID: 195520 RVA: 0x006802B4 File Offset: 0x0067E4B4
		public int MarkId
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

		// Token: 0x0602FBC1 RID: 195521 RVA: 0x006802F0 File Offset: 0x0067E4F0
		public static Offset<IDisableMapMark> CreateIDisableMapMark(FlatBufferBuilder builder, EMapMarkState Type = EMapMarkState.Show, int MarkId = 0)
		{
			builder.StartTable(2);
			IDisableMapMark.AddMarkId(builder, MarkId);
			IDisableMapMark.AddType(builder, Type);
			return IDisableMapMark.EndIDisableMapMark(builder);
		}

		// Token: 0x0602FBC2 RID: 195522 RVA: 0x0068030D File Offset: 0x0067E50D
		public static void StartIDisableMapMark(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FBC3 RID: 195523 RVA: 0x00680316 File Offset: 0x0067E516
		public static void AddType(FlatBufferBuilder builder, EMapMarkState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FBC4 RID: 195524 RVA: 0x00680321 File Offset: 0x0067E521
		public static void AddMarkId(FlatBufferBuilder builder, int markId)
		{
			builder.AddInt(1, markId, 0);
		}

		// Token: 0x0602FBC5 RID: 195525 RVA: 0x0068032C File Offset: 0x0067E52C
		public static Offset<IDisableMapMark> EndIDisableMapMark(FlatBufferBuilder builder)
		{
			return new Offset<IDisableMapMark>(builder.EndTable());
		}

		// Token: 0x0602FBC6 RID: 195526 RVA: 0x0068033C File Offset: 0x0067E53C
		public IDisableMapMarkT UnPack()
		{
			IDisableMapMarkT disableMapMarkT = new IDisableMapMarkT();
			this.UnPackTo(disableMapMarkT);
			return disableMapMarkT;
		}

		// Token: 0x0602FBC7 RID: 195527 RVA: 0x00680357 File Offset: 0x0067E557
		public void UnPackTo(IDisableMapMarkT _o)
		{
			_o.Type = this.Type;
			_o.MarkId = this.MarkId;
		}

		// Token: 0x0602FBC8 RID: 195528 RVA: 0x00680374 File Offset: 0x0067E574
		public static Offset<IDisableMapMark> Pack(FlatBufferBuilder builder, IDisableMapMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableMapMark>);
			}
			return IDisableMapMark.CreateIDisableMapMark(builder, _o.Type, _o.MarkId);
		}

		// Token: 0x04011A6A RID: 72298
		private Table __p;
	}
}
