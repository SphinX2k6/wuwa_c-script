using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E1F RID: 28191
	public struct IReignsAddBuff : IFlatbufferObject
	{
		// Token: 0x1700D222 RID: 53794
		// (get) Token: 0x06031CFF RID: 204031 RVA: 0x006BE61A File Offset: 0x006BC81A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031D00 RID: 204032 RVA: 0x006BE627 File Offset: 0x006BC827
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031D01 RID: 204033 RVA: 0x006BE630 File Offset: 0x006BC830
		public static IReignsAddBuff GetRootAsIReignsAddBuff(ByteBuffer _bb)
		{
			return IReignsAddBuff.GetRootAsIReignsAddBuff(_bb, default(IReignsAddBuff));
		}

		// Token: 0x06031D02 RID: 204034 RVA: 0x006BE64C File Offset: 0x006BC84C
		public static IReignsAddBuff GetRootAsIReignsAddBuff(ByteBuffer _bb, IReignsAddBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031D03 RID: 204035 RVA: 0x006BE669 File Offset: 0x006BC869
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031D04 RID: 204036 RVA: 0x006BE678 File Offset: 0x006BC878
		public IReignsAddBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D223 RID: 53795
		// (get) Token: 0x06031D05 RID: 204037 RVA: 0x006BE688 File Offset: 0x006BC888
		public int BuffId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031D06 RID: 204038 RVA: 0x006BE6C4 File Offset: 0x006BC8C4
		public static Offset<IReignsAddBuff> CreateIReignsAddBuff(FlatBufferBuilder builder, int BuffId = 0)
		{
			builder.StartTable(1);
			IReignsAddBuff.AddBuffId(builder, BuffId);
			return IReignsAddBuff.EndIReignsAddBuff(builder);
		}

		// Token: 0x06031D07 RID: 204039 RVA: 0x006BE6DA File Offset: 0x006BC8DA
		public static void StartIReignsAddBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031D08 RID: 204040 RVA: 0x006BE6E3 File Offset: 0x006BC8E3
		public static void AddBuffId(FlatBufferBuilder builder, int buffId)
		{
			builder.AddInt(0, buffId, 0);
		}

		// Token: 0x06031D09 RID: 204041 RVA: 0x006BE6EE File Offset: 0x006BC8EE
		public static Offset<IReignsAddBuff> EndIReignsAddBuff(FlatBufferBuilder builder)
		{
			return new Offset<IReignsAddBuff>(builder.EndTable());
		}

		// Token: 0x06031D0A RID: 204042 RVA: 0x006BE6FC File Offset: 0x006BC8FC
		public IReignsAddBuffT UnPack()
		{
			IReignsAddBuffT reignsAddBuffT = new IReignsAddBuffT();
			this.UnPackTo(reignsAddBuffT);
			return reignsAddBuffT;
		}

		// Token: 0x06031D0B RID: 204043 RVA: 0x006BE717 File Offset: 0x006BC917
		public void UnPackTo(IReignsAddBuffT _o)
		{
			_o.BuffId = this.BuffId;
		}

		// Token: 0x06031D0C RID: 204044 RVA: 0x006BE728 File Offset: 0x006BC928
		public static Offset<IReignsAddBuff> Pack(FlatBufferBuilder builder, IReignsAddBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsAddBuff>);
			}
			return IReignsAddBuff.CreateIReignsAddBuff(builder, _o.BuffId);
		}

		// Token: 0x04011809 RID: 71689
		private Table __p;
	}
}
