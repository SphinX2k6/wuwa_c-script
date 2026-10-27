using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200700A RID: 28682
	public struct ISetJigsawFoundationType : IFlatbufferObject
	{
		// Token: 0x1700D506 RID: 54534
		// (get) Token: 0x06032BC1 RID: 207809 RVA: 0x006D873F File Offset: 0x006D693F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032BC2 RID: 207810 RVA: 0x006D874C File Offset: 0x006D694C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032BC3 RID: 207811 RVA: 0x006D8754 File Offset: 0x006D6954
		public static ISetJigsawFoundationType GetRootAsISetJigsawFoundationType(ByteBuffer _bb)
		{
			return ISetJigsawFoundationType.GetRootAsISetJigsawFoundationType(_bb, default(ISetJigsawFoundationType));
		}

		// Token: 0x06032BC4 RID: 207812 RVA: 0x006D8770 File Offset: 0x006D6970
		public static ISetJigsawFoundationType GetRootAsISetJigsawFoundationType(ByteBuffer _bb, ISetJigsawFoundationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032BC5 RID: 207813 RVA: 0x006D878D File Offset: 0x006D698D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032BC6 RID: 207814 RVA: 0x006D879C File Offset: 0x006D699C
		public ISetJigsawFoundationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D507 RID: 54535
		// (get) Token: 0x06032BC7 RID: 207815 RVA: 0x006D87AC File Offset: 0x006D69AC
		public ESetJigsawFoundationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetJigsawFoundationType.SetPieceState;
				}
				return (ESetJigsawFoundationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032BC8 RID: 207816 RVA: 0x006D87E8 File Offset: 0x006D69E8
		public static Offset<ISetJigsawFoundationType> CreateISetJigsawFoundationType(FlatBufferBuilder builder, ESetJigsawFoundationType Type = ESetJigsawFoundationType.SetPieceState)
		{
			builder.StartTable(1);
			ISetJigsawFoundationType.AddType(builder, Type);
			return ISetJigsawFoundationType.EndISetJigsawFoundationType(builder);
		}

		// Token: 0x06032BC9 RID: 207817 RVA: 0x006D87FE File Offset: 0x006D69FE
		public static void StartISetJigsawFoundationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032BCA RID: 207818 RVA: 0x006D8807 File Offset: 0x006D6A07
		public static void AddType(FlatBufferBuilder builder, ESetJigsawFoundationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032BCB RID: 207819 RVA: 0x006D8812 File Offset: 0x006D6A12
		public static Offset<ISetJigsawFoundationType> EndISetJigsawFoundationType(FlatBufferBuilder builder)
		{
			return new Offset<ISetJigsawFoundationType>(builder.EndTable());
		}

		// Token: 0x06032BCC RID: 207820 RVA: 0x006D8820 File Offset: 0x006D6A20
		public ISetJigsawFoundationTypeT UnPack()
		{
			ISetJigsawFoundationTypeT setJigsawFoundationTypeT = new ISetJigsawFoundationTypeT();
			this.UnPackTo(setJigsawFoundationTypeT);
			return setJigsawFoundationTypeT;
		}

		// Token: 0x06032BCD RID: 207821 RVA: 0x006D883B File Offset: 0x006D6A3B
		public void UnPackTo(ISetJigsawFoundationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032BCE RID: 207822 RVA: 0x006D884C File Offset: 0x006D6A4C
		public static Offset<ISetJigsawFoundationType> Pack(FlatBufferBuilder builder, ISetJigsawFoundationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetJigsawFoundationType>);
			}
			return ISetJigsawFoundationType.CreateISetJigsawFoundationType(builder, _o.Type);
		}

		// Token: 0x04011A2D RID: 72237
		private Table __p;
	}
}
