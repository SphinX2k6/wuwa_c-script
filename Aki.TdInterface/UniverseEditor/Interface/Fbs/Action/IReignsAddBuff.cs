using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200759D RID: 30109
	public struct IReignsAddBuff : IFlatbufferObject
	{
		// Token: 0x1700DD71 RID: 56689
		// (get) Token: 0x06034D15 RID: 216341 RVA: 0x00719FA2 File Offset: 0x007181A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034D16 RID: 216342 RVA: 0x00719FAF File Offset: 0x007181AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034D17 RID: 216343 RVA: 0x00719FB8 File Offset: 0x007181B8
		public static IReignsAddBuff GetRootAsIReignsAddBuff(ByteBuffer _bb)
		{
			return IReignsAddBuff.GetRootAsIReignsAddBuff(_bb, default(IReignsAddBuff));
		}

		// Token: 0x06034D18 RID: 216344 RVA: 0x00719FD4 File Offset: 0x007181D4
		public static IReignsAddBuff GetRootAsIReignsAddBuff(ByteBuffer _bb, IReignsAddBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034D19 RID: 216345 RVA: 0x00719FF1 File Offset: 0x007181F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034D1A RID: 216346 RVA: 0x0071A000 File Offset: 0x00718200
		public IReignsAddBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD72 RID: 56690
		// (get) Token: 0x06034D1B RID: 216347 RVA: 0x0071A010 File Offset: 0x00718210
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

		// Token: 0x06034D1C RID: 216348 RVA: 0x0071A04C File Offset: 0x0071824C
		public static Offset<IReignsAddBuff> CreateIReignsAddBuff(FlatBufferBuilder builder, int BuffId = 0)
		{
			builder.StartTable(1);
			IReignsAddBuff.AddBuffId(builder, BuffId);
			return IReignsAddBuff.EndIReignsAddBuff(builder);
		}

		// Token: 0x06034D1D RID: 216349 RVA: 0x0071A062 File Offset: 0x00718262
		public static void StartIReignsAddBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034D1E RID: 216350 RVA: 0x0071A06B File Offset: 0x0071826B
		public static void AddBuffId(FlatBufferBuilder builder, int buffId)
		{
			builder.AddInt(0, buffId, 0);
		}

		// Token: 0x06034D1F RID: 216351 RVA: 0x0071A076 File Offset: 0x00718276
		public static Offset<IReignsAddBuff> EndIReignsAddBuff(FlatBufferBuilder builder)
		{
			return new Offset<IReignsAddBuff>(builder.EndTable());
		}

		// Token: 0x06034D20 RID: 216352 RVA: 0x0071A084 File Offset: 0x00718284
		public IReignsAddBuffT UnPack()
		{
			IReignsAddBuffT reignsAddBuffT = new IReignsAddBuffT();
			this.UnPackTo(reignsAddBuffT);
			return reignsAddBuffT;
		}

		// Token: 0x06034D21 RID: 216353 RVA: 0x0071A09F File Offset: 0x0071829F
		public void UnPackTo(IReignsAddBuffT _o)
		{
			_o.BuffId = this.BuffId;
		}

		// Token: 0x06034D22 RID: 216354 RVA: 0x0071A0B0 File Offset: 0x007182B0
		public static Offset<IReignsAddBuff> Pack(FlatBufferBuilder builder, IReignsAddBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsAddBuff>);
			}
			return IReignsAddBuff.CreateIReignsAddBuff(builder, _o.BuffId);
		}

		// Token: 0x04012789 RID: 75657
		private Table __p;
	}
}
