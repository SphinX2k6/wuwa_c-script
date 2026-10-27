using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A81 RID: 14977
	public struct IBvbPlayerScore : IFlatbufferObject
	{
		// Token: 0x17006693 RID: 26259
		// (get) Token: 0x060144E1 RID: 83169 RVA: 0x002F6B69 File Offset: 0x002F4D69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060144E2 RID: 83170 RVA: 0x002F6B76 File Offset: 0x002F4D76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060144E3 RID: 83171 RVA: 0x002F6B80 File Offset: 0x002F4D80
		public static IBvbPlayerScore GetRootAsIBvbPlayerScore(ByteBuffer _bb)
		{
			return IBvbPlayerScore.GetRootAsIBvbPlayerScore(_bb, default(IBvbPlayerScore));
		}

		// Token: 0x060144E4 RID: 83172 RVA: 0x002F6B9C File Offset: 0x002F4D9C
		public static IBvbPlayerScore GetRootAsIBvbPlayerScore(ByteBuffer _bb, IBvbPlayerScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060144E5 RID: 83173 RVA: 0x002F6BB9 File Offset: 0x002F4DB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060144E6 RID: 83174 RVA: 0x002F6BC8 File Offset: 0x002F4DC8
		public IBvbPlayerScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006694 RID: 26260
		// (get) Token: 0x060144E7 RID: 83175 RVA: 0x002F6BD8 File Offset: 0x002F4DD8
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

		// Token: 0x060144E8 RID: 83176 RVA: 0x002F6C14 File Offset: 0x002F4E14
		public static Offset<IBvbPlayerScore> CreateIBvbPlayerScore(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbPlayerScore.AddType(builder, Type);
			return IBvbPlayerScore.EndIBvbPlayerScore(builder);
		}

		// Token: 0x060144E9 RID: 83177 RVA: 0x002F6C2A File Offset: 0x002F4E2A
		public static void StartIBvbPlayerScore(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060144EA RID: 83178 RVA: 0x002F6C33 File Offset: 0x002F4E33
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060144EB RID: 83179 RVA: 0x002F6C3E File Offset: 0x002F4E3E
		public static Offset<IBvbPlayerScore> EndIBvbPlayerScore(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerScore>(builder.EndTable());
		}

		// Token: 0x060144EC RID: 83180 RVA: 0x002F6C4C File Offset: 0x002F4E4C
		public IBvbPlayerScoreT UnPack()
		{
			IBvbPlayerScoreT bvbPlayerScoreT = new IBvbPlayerScoreT();
			this.UnPackTo(bvbPlayerScoreT);
			return bvbPlayerScoreT;
		}

		// Token: 0x060144ED RID: 83181 RVA: 0x002F6C67 File Offset: 0x002F4E67
		public void UnPackTo(IBvbPlayerScoreT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060144EE RID: 83182 RVA: 0x002F6C78 File Offset: 0x002F4E78
		public static Offset<IBvbPlayerScore> Pack(FlatBufferBuilder builder, IBvbPlayerScoreT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayerScore>);
			}
			return IBvbPlayerScore.CreateIBvbPlayerScore(builder, _o.Type);
		}

		// Token: 0x0400AEFC RID: 44796
		private Table __p;
	}
}
