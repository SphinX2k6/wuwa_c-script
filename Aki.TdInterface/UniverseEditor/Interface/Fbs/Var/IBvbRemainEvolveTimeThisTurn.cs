using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E5F RID: 15967
	public struct IBvbRemainEvolveTimeThisTurn : IFlatbufferObject
	{
		// Token: 0x17006BC6 RID: 27590
		// (get) Token: 0x0601580F RID: 88079 RVA: 0x00319ECD File Offset: 0x003180CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015810 RID: 88080 RVA: 0x00319EDA File Offset: 0x003180DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015811 RID: 88081 RVA: 0x00319EE4 File Offset: 0x003180E4
		public static IBvbRemainEvolveTimeThisTurn GetRootAsIBvbRemainEvolveTimeThisTurn(ByteBuffer _bb)
		{
			return IBvbRemainEvolveTimeThisTurn.GetRootAsIBvbRemainEvolveTimeThisTurn(_bb, default(IBvbRemainEvolveTimeThisTurn));
		}

		// Token: 0x06015812 RID: 88082 RVA: 0x00319F00 File Offset: 0x00318100
		public static IBvbRemainEvolveTimeThisTurn GetRootAsIBvbRemainEvolveTimeThisTurn(ByteBuffer _bb, IBvbRemainEvolveTimeThisTurn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015813 RID: 88083 RVA: 0x00319F1D File Offset: 0x0031811D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015814 RID: 88084 RVA: 0x00319F2C File Offset: 0x0031812C
		public IBvbRemainEvolveTimeThisTurn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BC7 RID: 27591
		// (get) Token: 0x06015815 RID: 88085 RVA: 0x00319F3C File Offset: 0x0031813C
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

		// Token: 0x06015816 RID: 88086 RVA: 0x00319F78 File Offset: 0x00318178
		public static Offset<IBvbRemainEvolveTimeThisTurn> CreateIBvbRemainEvolveTimeThisTurn(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbRemainEvolveTimeThisTurn.AddType(builder, Type);
			return IBvbRemainEvolveTimeThisTurn.EndIBvbRemainEvolveTimeThisTurn(builder);
		}

		// Token: 0x06015817 RID: 88087 RVA: 0x00319F8E File Offset: 0x0031818E
		public static void StartIBvbRemainEvolveTimeThisTurn(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015818 RID: 88088 RVA: 0x00319F97 File Offset: 0x00318197
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015819 RID: 88089 RVA: 0x00319FA2 File Offset: 0x003181A2
		public static Offset<IBvbRemainEvolveTimeThisTurn> EndIBvbRemainEvolveTimeThisTurn(FlatBufferBuilder builder)
		{
			return new Offset<IBvbRemainEvolveTimeThisTurn>(builder.EndTable());
		}

		// Token: 0x0601581A RID: 88090 RVA: 0x00319FB0 File Offset: 0x003181B0
		public IBvbRemainEvolveTimeThisTurnT UnPack()
		{
			IBvbRemainEvolveTimeThisTurnT bvbRemainEvolveTimeThisTurnT = new IBvbRemainEvolveTimeThisTurnT();
			this.UnPackTo(bvbRemainEvolveTimeThisTurnT);
			return bvbRemainEvolveTimeThisTurnT;
		}

		// Token: 0x0601581B RID: 88091 RVA: 0x00319FCB File Offset: 0x003181CB
		public void UnPackTo(IBvbRemainEvolveTimeThisTurnT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601581C RID: 88092 RVA: 0x00319FDC File Offset: 0x003181DC
		public static Offset<IBvbRemainEvolveTimeThisTurn> Pack(FlatBufferBuilder builder, IBvbRemainEvolveTimeThisTurnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbRemainEvolveTimeThisTurn>);
			}
			return IBvbRemainEvolveTimeThisTurn.CreateIBvbRemainEvolveTimeThisTurn(builder, _o.Type);
		}

		// Token: 0x0400B820 RID: 47136
		private Table __p;
	}
}
