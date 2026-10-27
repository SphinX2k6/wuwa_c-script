using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C12 RID: 27666
	public struct IOpenPanelQteQte : IFlatbufferObject
	{
		// Token: 0x1700CDC8 RID: 52680
		// (get) Token: 0x06030A7B RID: 199291 RVA: 0x0069B0CA File Offset: 0x006992CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030A7C RID: 199292 RVA: 0x0069B0D7 File Offset: 0x006992D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030A7D RID: 199293 RVA: 0x0069B0E0 File Offset: 0x006992E0
		public static IOpenPanelQteQte GetRootAsIOpenPanelQteQte(ByteBuffer _bb)
		{
			return IOpenPanelQteQte.GetRootAsIOpenPanelQteQte(_bb, default(IOpenPanelQteQte));
		}

		// Token: 0x06030A7E RID: 199294 RVA: 0x0069B0FC File Offset: 0x006992FC
		public static IOpenPanelQteQte GetRootAsIOpenPanelQteQte(ByteBuffer _bb, IOpenPanelQteQte obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030A7F RID: 199295 RVA: 0x0069B119 File Offset: 0x00699319
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030A80 RID: 199296 RVA: 0x0069B128 File Offset: 0x00699328
		public IOpenPanelQteQte __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDC9 RID: 52681
		// (get) Token: 0x06030A81 RID: 199297 RVA: 0x0069B138 File Offset: 0x00699338
		public EOpenQteType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOpenQteType.PanelQte;
				}
				return (EOpenQteType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CDCA RID: 52682
		// (get) Token: 0x06030A82 RID: 199298 RVA: 0x0069B174 File Offset: 0x00699374
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

		// Token: 0x06030A83 RID: 199299 RVA: 0x0069B1B0 File Offset: 0x006993B0
		public static Offset<IOpenPanelQteQte> CreateIOpenPanelQteQte(FlatBufferBuilder builder, EOpenQteType Type = EOpenQteType.PanelQte, int Id = 0)
		{
			builder.StartTable(2);
			IOpenPanelQteQte.AddId(builder, Id);
			IOpenPanelQteQte.AddType(builder, Type);
			return IOpenPanelQteQte.EndIOpenPanelQteQte(builder);
		}

		// Token: 0x06030A84 RID: 199300 RVA: 0x0069B1CD File Offset: 0x006993CD
		public static void StartIOpenPanelQteQte(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030A85 RID: 199301 RVA: 0x0069B1D6 File Offset: 0x006993D6
		public static void AddType(FlatBufferBuilder builder, EOpenQteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030A86 RID: 199302 RVA: 0x0069B1E1 File Offset: 0x006993E1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06030A87 RID: 199303 RVA: 0x0069B1EC File Offset: 0x006993EC
		public static Offset<IOpenPanelQteQte> EndIOpenPanelQteQte(FlatBufferBuilder builder)
		{
			return new Offset<IOpenPanelQteQte>(builder.EndTable());
		}

		// Token: 0x06030A88 RID: 199304 RVA: 0x0069B1FC File Offset: 0x006993FC
		public IOpenPanelQteQteT UnPack()
		{
			IOpenPanelQteQteT openPanelQteQteT = new IOpenPanelQteQteT();
			this.UnPackTo(openPanelQteQteT);
			return openPanelQteQteT;
		}

		// Token: 0x06030A89 RID: 199305 RVA: 0x0069B217 File Offset: 0x00699417
		public void UnPackTo(IOpenPanelQteQteT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06030A8A RID: 199306 RVA: 0x0069B234 File Offset: 0x00699434
		public static Offset<IOpenPanelQteQte> Pack(FlatBufferBuilder builder, IOpenPanelQteQteT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenPanelQteQte>);
			}
			return IOpenPanelQteQte.CreateIOpenPanelQteQte(builder, _o.Type, _o.Id);
		}

		// Token: 0x04011517 RID: 70935
		private Table __p;
	}
}
