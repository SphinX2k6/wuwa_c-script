using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006889 RID: 26761
	public struct IBossPilingRandomBuff : IFlatbufferObject
	{
		// Token: 0x1700C4A8 RID: 50344
		// (get) Token: 0x0602DBE5 RID: 187365 RVA: 0x00640F02 File Offset: 0x0063F102
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DBE6 RID: 187366 RVA: 0x00640F0F File Offset: 0x0063F10F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DBE7 RID: 187367 RVA: 0x00640F18 File Offset: 0x0063F118
		public static IBossPilingRandomBuff GetRootAsIBossPilingRandomBuff(ByteBuffer _bb)
		{
			return IBossPilingRandomBuff.GetRootAsIBossPilingRandomBuff(_bb, default(IBossPilingRandomBuff));
		}

		// Token: 0x0602DBE8 RID: 187368 RVA: 0x00640F34 File Offset: 0x0063F134
		public static IBossPilingRandomBuff GetRootAsIBossPilingRandomBuff(ByteBuffer _bb, IBossPilingRandomBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DBE9 RID: 187369 RVA: 0x00640F51 File Offset: 0x0063F151
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DBEA RID: 187370 RVA: 0x00640F60 File Offset: 0x0063F160
		public IBossPilingRandomBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4A9 RID: 50345
		// (get) Token: 0x0602DBEB RID: 187371 RVA: 0x00640F70 File Offset: 0x0063F170
		public int BuffPoolId
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

		// Token: 0x0602DBEC RID: 187372 RVA: 0x00640FAC File Offset: 0x0063F1AC
		public static Offset<IBossPilingRandomBuff> CreateIBossPilingRandomBuff(FlatBufferBuilder builder, int BuffPoolId = 0)
		{
			builder.StartTable(1);
			IBossPilingRandomBuff.AddBuffPoolId(builder, BuffPoolId);
			return IBossPilingRandomBuff.EndIBossPilingRandomBuff(builder);
		}

		// Token: 0x0602DBED RID: 187373 RVA: 0x00640FC2 File Offset: 0x0063F1C2
		public static void StartIBossPilingRandomBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DBEE RID: 187374 RVA: 0x00640FCB File Offset: 0x0063F1CB
		public static void AddBuffPoolId(FlatBufferBuilder builder, int buffPoolId)
		{
			builder.AddInt(0, buffPoolId, 0);
		}

		// Token: 0x0602DBEF RID: 187375 RVA: 0x00640FD6 File Offset: 0x0063F1D6
		public static Offset<IBossPilingRandomBuff> EndIBossPilingRandomBuff(FlatBufferBuilder builder)
		{
			return new Offset<IBossPilingRandomBuff>(builder.EndTable());
		}

		// Token: 0x0602DBF0 RID: 187376 RVA: 0x00640FE4 File Offset: 0x0063F1E4
		public IBossPilingRandomBuffT UnPack()
		{
			IBossPilingRandomBuffT bossPilingRandomBuffT = new IBossPilingRandomBuffT();
			this.UnPackTo(bossPilingRandomBuffT);
			return bossPilingRandomBuffT;
		}

		// Token: 0x0602DBF1 RID: 187377 RVA: 0x00640FFF File Offset: 0x0063F1FF
		public void UnPackTo(IBossPilingRandomBuffT _o)
		{
			_o.BuffPoolId = this.BuffPoolId;
		}

		// Token: 0x0602DBF2 RID: 187378 RVA: 0x00641010 File Offset: 0x0063F210
		public static Offset<IBossPilingRandomBuff> Pack(FlatBufferBuilder builder, IBossPilingRandomBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBossPilingRandomBuff>);
			}
			return IBossPilingRandomBuff.CreateIBossPilingRandomBuff(builder, _o.BuffPoolId);
		}

		// Token: 0x0401156A RID: 71018
		private Table __p;
	}
}
