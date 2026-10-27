using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A63 RID: 14947
	public struct IBvbMaxBoardCardCount : IFlatbufferObject
	{
		// Token: 0x17006675 RID: 26229
		// (get) Token: 0x0601442D RID: 82989 RVA: 0x002F5CBC File Offset: 0x002F3EBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601442E RID: 82990 RVA: 0x002F5CC9 File Offset: 0x002F3EC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601442F RID: 82991 RVA: 0x002F5CD0 File Offset: 0x002F3ED0
		public static IBvbMaxBoardCardCount GetRootAsIBvbMaxBoardCardCount(ByteBuffer _bb)
		{
			return IBvbMaxBoardCardCount.GetRootAsIBvbMaxBoardCardCount(_bb, default(IBvbMaxBoardCardCount));
		}

		// Token: 0x06014430 RID: 82992 RVA: 0x002F5CEC File Offset: 0x002F3EEC
		public static IBvbMaxBoardCardCount GetRootAsIBvbMaxBoardCardCount(ByteBuffer _bb, IBvbMaxBoardCardCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014431 RID: 82993 RVA: 0x002F5D09 File Offset: 0x002F3F09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014432 RID: 82994 RVA: 0x002F5D18 File Offset: 0x002F3F18
		public IBvbMaxBoardCardCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006676 RID: 26230
		// (get) Token: 0x06014433 RID: 82995 RVA: 0x002F5D28 File Offset: 0x002F3F28
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

		// Token: 0x06014434 RID: 82996 RVA: 0x002F5D64 File Offset: 0x002F3F64
		public static Offset<IBvbMaxBoardCardCount> CreateIBvbMaxBoardCardCount(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbMaxBoardCardCount.AddType(builder, Type);
			return IBvbMaxBoardCardCount.EndIBvbMaxBoardCardCount(builder);
		}

		// Token: 0x06014435 RID: 82997 RVA: 0x002F5D7A File Offset: 0x002F3F7A
		public static void StartIBvbMaxBoardCardCount(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014436 RID: 82998 RVA: 0x002F5D83 File Offset: 0x002F3F83
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014437 RID: 82999 RVA: 0x002F5D8E File Offset: 0x002F3F8E
		public static Offset<IBvbMaxBoardCardCount> EndIBvbMaxBoardCardCount(FlatBufferBuilder builder)
		{
			return new Offset<IBvbMaxBoardCardCount>(builder.EndTable());
		}

		// Token: 0x06014438 RID: 83000 RVA: 0x002F5D9C File Offset: 0x002F3F9C
		public IBvbMaxBoardCardCountT UnPack()
		{
			IBvbMaxBoardCardCountT bvbMaxBoardCardCountT = new IBvbMaxBoardCardCountT();
			this.UnPackTo(bvbMaxBoardCardCountT);
			return bvbMaxBoardCardCountT;
		}

		// Token: 0x06014439 RID: 83001 RVA: 0x002F5DB7 File Offset: 0x002F3FB7
		public void UnPackTo(IBvbMaxBoardCardCountT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601443A RID: 83002 RVA: 0x002F5DC8 File Offset: 0x002F3FC8
		public static Offset<IBvbMaxBoardCardCount> Pack(FlatBufferBuilder builder, IBvbMaxBoardCardCountT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbMaxBoardCardCount>);
			}
			return IBvbMaxBoardCardCount.CreateIBvbMaxBoardCardCount(builder, _o.Type);
		}

		// Token: 0x0400AEE8 RID: 44776
		private Table __p;
	}
}
