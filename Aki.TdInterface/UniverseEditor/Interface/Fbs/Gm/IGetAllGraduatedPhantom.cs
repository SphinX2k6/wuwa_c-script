using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004654 RID: 18004
	public struct IGetAllGraduatedPhantom : IFlatbufferObject
	{
		// Token: 0x17007FCC RID: 32716
		// (get) Token: 0x0601B48B RID: 111755 RVA: 0x003E1AD8 File Offset: 0x003DFCD8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B48C RID: 111756 RVA: 0x003E1AE5 File Offset: 0x003DFCE5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B48D RID: 111757 RVA: 0x003E1AEC File Offset: 0x003DFCEC
		public static IGetAllGraduatedPhantom GetRootAsIGetAllGraduatedPhantom(ByteBuffer _bb)
		{
			return IGetAllGraduatedPhantom.GetRootAsIGetAllGraduatedPhantom(_bb, default(IGetAllGraduatedPhantom));
		}

		// Token: 0x0601B48E RID: 111758 RVA: 0x003E1B08 File Offset: 0x003DFD08
		public static IGetAllGraduatedPhantom GetRootAsIGetAllGraduatedPhantom(ByteBuffer _bb, IGetAllGraduatedPhantom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B48F RID: 111759 RVA: 0x003E1B25 File Offset: 0x003DFD25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B490 RID: 111760 RVA: 0x003E1B34 File Offset: 0x003DFD34
		public IGetAllGraduatedPhantom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FCD RID: 32717
		// (get) Token: 0x0601B491 RID: 111761 RVA: 0x003E1B44 File Offset: 0x003DFD44
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B492 RID: 111762 RVA: 0x003E1B80 File Offset: 0x003DFD80
		public static Offset<IGetAllGraduatedPhantom> CreateIGetAllGraduatedPhantom(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IGetAllGraduatedPhantom.AddType(builder, Type);
			return IGetAllGraduatedPhantom.EndIGetAllGraduatedPhantom(builder);
		}

		// Token: 0x0601B493 RID: 111763 RVA: 0x003E1B96 File Offset: 0x003DFD96
		public static void StartIGetAllGraduatedPhantom(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B494 RID: 111764 RVA: 0x003E1B9F File Offset: 0x003DFD9F
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B495 RID: 111765 RVA: 0x003E1BAA File Offset: 0x003DFDAA
		public static Offset<IGetAllGraduatedPhantom> EndIGetAllGraduatedPhantom(FlatBufferBuilder builder)
		{
			return new Offset<IGetAllGraduatedPhantom>(builder.EndTable());
		}

		// Token: 0x0601B496 RID: 111766 RVA: 0x003E1BB8 File Offset: 0x003DFDB8
		public IGetAllGraduatedPhantomT UnPack()
		{
			IGetAllGraduatedPhantomT getAllGraduatedPhantomT = new IGetAllGraduatedPhantomT();
			this.UnPackTo(getAllGraduatedPhantomT);
			return getAllGraduatedPhantomT;
		}

		// Token: 0x0601B497 RID: 111767 RVA: 0x003E1BD3 File Offset: 0x003DFDD3
		public void UnPackTo(IGetAllGraduatedPhantomT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B498 RID: 111768 RVA: 0x003E1BE4 File Offset: 0x003DFDE4
		public static Offset<IGetAllGraduatedPhantom> Pack(FlatBufferBuilder builder, IGetAllGraduatedPhantomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGetAllGraduatedPhantom>);
			}
			return IGetAllGraduatedPhantom.CreateIGetAllGraduatedPhantom(builder, _o.Type);
		}

		// Token: 0x0400C7D2 RID: 51154
		private Table __p;
	}
}
