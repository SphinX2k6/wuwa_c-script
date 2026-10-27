using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C4 RID: 28868
	public struct ISheriffReasoning : IFlatbufferObject
	{
		// Token: 0x1700D673 RID: 54899
		// (get) Token: 0x06033214 RID: 209428 RVA: 0x006E50EE File Offset: 0x006E32EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033215 RID: 209429 RVA: 0x006E50FB File Offset: 0x006E32FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033216 RID: 209430 RVA: 0x006E5104 File Offset: 0x006E3304
		public static ISheriffReasoning GetRootAsISheriffReasoning(ByteBuffer _bb)
		{
			return ISheriffReasoning.GetRootAsISheriffReasoning(_bb, default(ISheriffReasoning));
		}

		// Token: 0x06033217 RID: 209431 RVA: 0x006E5120 File Offset: 0x006E3320
		public static ISheriffReasoning GetRootAsISheriffReasoning(ByteBuffer _bb, ISheriffReasoning obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033218 RID: 209432 RVA: 0x006E513D File Offset: 0x006E333D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033219 RID: 209433 RVA: 0x006E514C File Offset: 0x006E334C
		public ISheriffReasoning __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D674 RID: 54900
		// (get) Token: 0x0603321A RID: 209434 RVA: 0x006E515C File Offset: 0x006E335C
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D675 RID: 54901
		// (get) Token: 0x0603321B RID: 209435 RVA: 0x006E5198 File Offset: 0x006E3398
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603321C RID: 209436 RVA: 0x006E51D4 File Offset: 0x006E33D4
		public static Offset<ISheriffReasoning> CreateISheriffReasoning(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int Id = 0)
		{
			builder.StartTable(2);
			ISheriffReasoning.AddId(builder, Id);
			ISheriffReasoning.AddType(builder, Type);
			return ISheriffReasoning.EndISheriffReasoning(builder);
		}

		// Token: 0x0603321D RID: 209437 RVA: 0x006E51F1 File Offset: 0x006E33F1
		public static void StartISheriffReasoning(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603321E RID: 209438 RVA: 0x006E51FA File Offset: 0x006E33FA
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603321F RID: 209439 RVA: 0x006E5205 File Offset: 0x006E3405
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06033220 RID: 209440 RVA: 0x006E5210 File Offset: 0x006E3410
		public static Offset<ISheriffReasoning> EndISheriffReasoning(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffReasoning>(builder.EndTable());
		}

		// Token: 0x06033221 RID: 209441 RVA: 0x006E5220 File Offset: 0x006E3420
		public ISheriffReasoningT UnPack()
		{
			ISheriffReasoningT sheriffReasoningT = new ISheriffReasoningT();
			this.UnPackTo(sheriffReasoningT);
			return sheriffReasoningT;
		}

		// Token: 0x06033222 RID: 209442 RVA: 0x006E523B File Offset: 0x006E343B
		public void UnPackTo(ISheriffReasoningT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06033223 RID: 209443 RVA: 0x006E5258 File Offset: 0x006E3458
		public static Offset<ISheriffReasoning> Pack(FlatBufferBuilder builder, ISheriffReasoningT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffReasoning>);
			}
			return ISheriffReasoning.CreateISheriffReasoning(builder, _o.Type, _o.Id);
		}

		// Token: 0x04011B33 RID: 72499
		private Table __p;
	}
}
