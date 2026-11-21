using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E54 RID: 28244
	public struct IFixFoundationRelation : IFlatbufferObject
	{
		// Token: 0x1700CF09 RID: 53001
		// (get) Token: 0x06030CA3 RID: 199843 RVA: 0x0069F0BE File Offset: 0x0069D2BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030CA4 RID: 199844 RVA: 0x0069F0CB File Offset: 0x0069D2CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030CA5 RID: 199845 RVA: 0x0069F0D4 File Offset: 0x0069D2D4
		public static IFixFoundationRelation GetRootAsIFixFoundationRelation(ByteBuffer _bb)
		{
			return IFixFoundationRelation.GetRootAsIFixFoundationRelation(_bb, default(IFixFoundationRelation));
		}

		// Token: 0x06030CA6 RID: 199846 RVA: 0x0069F0F0 File Offset: 0x0069D2F0
		public static IFixFoundationRelation GetRootAsIFixFoundationRelation(ByteBuffer _bb, IFixFoundationRelation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030CA7 RID: 199847 RVA: 0x0069F10D File Offset: 0x0069D30D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030CA8 RID: 199848 RVA: 0x0069F11C File Offset: 0x0069D31C
		public IFixFoundationRelation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06030CA9 RID: 199849 RVA: 0x0069F12C File Offset: 0x0069D32C
		public static void StartIFixFoundationRelation(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06030CAA RID: 199850 RVA: 0x0069F135 File Offset: 0x0069D335
		public static Offset<IFixFoundationRelation> EndIFixFoundationRelation(FlatBufferBuilder builder)
		{
			return new Offset<IFixFoundationRelation>(builder.EndTable());
		}

		// Token: 0x06030CAB RID: 199851 RVA: 0x0069F144 File Offset: 0x0069D344
		public IFixFoundationRelationT UnPack()
		{
			IFixFoundationRelationT fixFoundationRelationT = new IFixFoundationRelationT();
			this.UnPackTo(fixFoundationRelationT);
			return fixFoundationRelationT;
		}

		// Token: 0x06030CAC RID: 199852 RVA: 0x0069F15F File Offset: 0x0069D35F
		public void UnPackTo(IFixFoundationRelationT _o)
		{
		}

		// Token: 0x06030CAD RID: 199853 RVA: 0x0069F164 File Offset: 0x0069D364
		public static Offset<IFixFoundationRelation> Pack(FlatBufferBuilder builder, IFixFoundationRelationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixFoundationRelation>);
			}
			IFixFoundationRelation.StartIFixFoundationRelation(builder);
			return IFixFoundationRelation.EndIFixFoundationRelation(builder);
		}

		// Token: 0x04011D24 RID: 72996
		private Table __p;
	}
}
