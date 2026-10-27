using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D4 RID: 26580
	public struct IFixFoundationRelation : IFlatbufferObject
	{
		// Token: 0x1700C553 RID: 50515
		// (get) Token: 0x0602E45D RID: 189533 RVA: 0x0065197A File Offset: 0x0064FB7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E45E RID: 189534 RVA: 0x00651987 File Offset: 0x0064FB87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E45F RID: 189535 RVA: 0x00651990 File Offset: 0x0064FB90
		public static IFixFoundationRelation GetRootAsIFixFoundationRelation(ByteBuffer _bb)
		{
			return IFixFoundationRelation.GetRootAsIFixFoundationRelation(_bb, default(IFixFoundationRelation));
		}

		// Token: 0x0602E460 RID: 189536 RVA: 0x006519AC File Offset: 0x0064FBAC
		public static IFixFoundationRelation GetRootAsIFixFoundationRelation(ByteBuffer _bb, IFixFoundationRelation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E461 RID: 189537 RVA: 0x006519C9 File Offset: 0x0064FBC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E462 RID: 189538 RVA: 0x006519D8 File Offset: 0x0064FBD8
		public IFixFoundationRelation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602E463 RID: 189539 RVA: 0x006519E8 File Offset: 0x0064FBE8
		public static void StartIFixFoundationRelation(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602E464 RID: 189540 RVA: 0x006519F1 File Offset: 0x0064FBF1
		public static Offset<IFixFoundationRelation> EndIFixFoundationRelation(FlatBufferBuilder builder)
		{
			return new Offset<IFixFoundationRelation>(builder.EndTable());
		}

		// Token: 0x0602E465 RID: 189541 RVA: 0x00651A00 File Offset: 0x0064FC00
		public IFixFoundationRelationT UnPack()
		{
			IFixFoundationRelationT fixFoundationRelationT = new IFixFoundationRelationT();
			this.UnPackTo(fixFoundationRelationT);
			return fixFoundationRelationT;
		}

		// Token: 0x0602E466 RID: 189542 RVA: 0x00651A1B File Offset: 0x0064FC1B
		public void UnPackTo(IFixFoundationRelationT _o)
		{
		}

		// Token: 0x0602E467 RID: 189543 RVA: 0x00651A20 File Offset: 0x0064FC20
		public static Offset<IFixFoundationRelation> Pack(FlatBufferBuilder builder, IFixFoundationRelationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixFoundationRelation>);
			}
			IFixFoundationRelation.StartIFixFoundationRelation(builder);
			return IFixFoundationRelation.EndIFixFoundationRelation(builder);
		}

		// Token: 0x04010EF2 RID: 69362
		private Table __p;
	}
}
