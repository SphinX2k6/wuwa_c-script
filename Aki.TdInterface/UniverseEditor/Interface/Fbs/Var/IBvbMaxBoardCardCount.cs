using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E3E RID: 15934
	public struct IBvbMaxBoardCardCount : IFlatbufferObject
	{
		// Token: 0x17006BA5 RID: 27557
		// (get) Token: 0x06015749 RID: 87881 RVA: 0x00318EA8 File Offset: 0x003170A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601574A RID: 87882 RVA: 0x00318EB5 File Offset: 0x003170B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601574B RID: 87883 RVA: 0x00318EBC File Offset: 0x003170BC
		public static IBvbMaxBoardCardCount GetRootAsIBvbMaxBoardCardCount(ByteBuffer _bb)
		{
			return IBvbMaxBoardCardCount.GetRootAsIBvbMaxBoardCardCount(_bb, default(IBvbMaxBoardCardCount));
		}

		// Token: 0x0601574C RID: 87884 RVA: 0x00318ED8 File Offset: 0x003170D8
		public static IBvbMaxBoardCardCount GetRootAsIBvbMaxBoardCardCount(ByteBuffer _bb, IBvbMaxBoardCardCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601574D RID: 87885 RVA: 0x00318EF5 File Offset: 0x003170F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601574E RID: 87886 RVA: 0x00318F04 File Offset: 0x00317104
		public IBvbMaxBoardCardCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BA6 RID: 27558
		// (get) Token: 0x0601574F RID: 87887 RVA: 0x00318F14 File Offset: 0x00317114
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015750 RID: 87888 RVA: 0x00318F50 File Offset: 0x00317150
		public static Offset<IBvbMaxBoardCardCount> CreateIBvbMaxBoardCardCount(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbMaxBoardCardCount.AddType(builder, Type);
			return IBvbMaxBoardCardCount.EndIBvbMaxBoardCardCount(builder);
		}

		// Token: 0x06015751 RID: 87889 RVA: 0x00318F66 File Offset: 0x00317166
		public static void StartIBvbMaxBoardCardCount(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015752 RID: 87890 RVA: 0x00318F6F File Offset: 0x0031716F
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015753 RID: 87891 RVA: 0x00318F7A File Offset: 0x0031717A
		public static Offset<IBvbMaxBoardCardCount> EndIBvbMaxBoardCardCount(FlatBufferBuilder builder)
		{
			return new Offset<IBvbMaxBoardCardCount>(builder.EndTable());
		}

		// Token: 0x06015754 RID: 87892 RVA: 0x00318F88 File Offset: 0x00317188
		public IBvbMaxBoardCardCountT UnPack()
		{
			IBvbMaxBoardCardCountT bvbMaxBoardCardCountT = new IBvbMaxBoardCardCountT();
			this.UnPackTo(bvbMaxBoardCardCountT);
			return bvbMaxBoardCardCountT;
		}

		// Token: 0x06015755 RID: 87893 RVA: 0x00318FA3 File Offset: 0x003171A3
		public void UnPackTo(IBvbMaxBoardCardCountT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015756 RID: 87894 RVA: 0x00318FB4 File Offset: 0x003171B4
		public static Offset<IBvbMaxBoardCardCount> Pack(FlatBufferBuilder builder, IBvbMaxBoardCardCountT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbMaxBoardCardCount>);
			}
			return IBvbMaxBoardCardCount.CreateIBvbMaxBoardCardCount(builder, _o.Type);
		}

		// Token: 0x0400B80A RID: 47114
		private Table __p;
	}
}
