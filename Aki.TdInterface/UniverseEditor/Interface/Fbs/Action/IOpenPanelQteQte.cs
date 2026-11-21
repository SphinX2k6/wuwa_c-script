using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007379 RID: 29561
	public struct IOpenPanelQteQte : IFlatbufferObject
	{
		// Token: 0x1700D8E3 RID: 55523
		// (get) Token: 0x060339CF RID: 211407 RVA: 0x006F53C6 File Offset: 0x006F35C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060339D0 RID: 211408 RVA: 0x006F53D3 File Offset: 0x006F35D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060339D1 RID: 211409 RVA: 0x006F53DC File Offset: 0x006F35DC
		public static IOpenPanelQteQte GetRootAsIOpenPanelQteQte(ByteBuffer _bb)
		{
			return IOpenPanelQteQte.GetRootAsIOpenPanelQteQte(_bb, default(IOpenPanelQteQte));
		}

		// Token: 0x060339D2 RID: 211410 RVA: 0x006F53F8 File Offset: 0x006F35F8
		public static IOpenPanelQteQte GetRootAsIOpenPanelQteQte(ByteBuffer _bb, IOpenPanelQteQte obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060339D3 RID: 211411 RVA: 0x006F5415 File Offset: 0x006F3615
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060339D4 RID: 211412 RVA: 0x006F5424 File Offset: 0x006F3624
		public IOpenPanelQteQte __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8E4 RID: 55524
		// (get) Token: 0x060339D5 RID: 211413 RVA: 0x006F5434 File Offset: 0x006F3634
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

		// Token: 0x1700D8E5 RID: 55525
		// (get) Token: 0x060339D6 RID: 211414 RVA: 0x006F5470 File Offset: 0x006F3670
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

		// Token: 0x060339D7 RID: 211415 RVA: 0x006F54AC File Offset: 0x006F36AC
		public static Offset<IOpenPanelQteQte> CreateIOpenPanelQteQte(FlatBufferBuilder builder, EOpenQteType Type = EOpenQteType.PanelQte, int Id = 0)
		{
			builder.StartTable(2);
			IOpenPanelQteQte.AddId(builder, Id);
			IOpenPanelQteQte.AddType(builder, Type);
			return IOpenPanelQteQte.EndIOpenPanelQteQte(builder);
		}

		// Token: 0x060339D8 RID: 211416 RVA: 0x006F54C9 File Offset: 0x006F36C9
		public static void StartIOpenPanelQteQte(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060339D9 RID: 211417 RVA: 0x006F54D2 File Offset: 0x006F36D2
		public static void AddType(FlatBufferBuilder builder, EOpenQteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060339DA RID: 211418 RVA: 0x006F54DD File Offset: 0x006F36DD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060339DB RID: 211419 RVA: 0x006F54E8 File Offset: 0x006F36E8
		public static Offset<IOpenPanelQteQte> EndIOpenPanelQteQte(FlatBufferBuilder builder)
		{
			return new Offset<IOpenPanelQteQte>(builder.EndTable());
		}

		// Token: 0x060339DC RID: 211420 RVA: 0x006F54F8 File Offset: 0x006F36F8
		public IOpenPanelQteQteT UnPack()
		{
			IOpenPanelQteQteT openPanelQteQteT = new IOpenPanelQteQteT();
			this.UnPackTo(openPanelQteQteT);
			return openPanelQteQteT;
		}

		// Token: 0x060339DD RID: 211421 RVA: 0x006F5513 File Offset: 0x006F3713
		public void UnPackTo(IOpenPanelQteQteT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x060339DE RID: 211422 RVA: 0x006F5530 File Offset: 0x006F3730
		public static Offset<IOpenPanelQteQte> Pack(FlatBufferBuilder builder, IOpenPanelQteQteT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenPanelQteQte>);
			}
			return IOpenPanelQteQte.CreateIOpenPanelQteQte(builder, _o.Type, _o.Id);
		}

		// Token: 0x0401246E RID: 74862
		private Table __p;
	}
}
