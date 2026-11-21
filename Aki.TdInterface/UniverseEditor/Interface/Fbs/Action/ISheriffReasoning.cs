using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007890 RID: 30864
	public struct ISheriffReasoning : IFlatbufferObject
	{
		// Token: 0x1700E256 RID: 57942
		// (get) Token: 0x060364B6 RID: 222390 RVA: 0x007456FA File Offset: 0x007438FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060364B7 RID: 222391 RVA: 0x00745707 File Offset: 0x00743907
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060364B8 RID: 222392 RVA: 0x00745710 File Offset: 0x00743910
		public static ISheriffReasoning GetRootAsISheriffReasoning(ByteBuffer _bb)
		{
			return ISheriffReasoning.GetRootAsISheriffReasoning(_bb, default(ISheriffReasoning));
		}

		// Token: 0x060364B9 RID: 222393 RVA: 0x0074572C File Offset: 0x0074392C
		public static ISheriffReasoning GetRootAsISheriffReasoning(ByteBuffer _bb, ISheriffReasoning obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060364BA RID: 222394 RVA: 0x00745749 File Offset: 0x00743949
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060364BB RID: 222395 RVA: 0x00745758 File Offset: 0x00743958
		public ISheriffReasoning __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E257 RID: 57943
		// (get) Token: 0x060364BC RID: 222396 RVA: 0x00745768 File Offset: 0x00743968
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

		// Token: 0x1700E258 RID: 57944
		// (get) Token: 0x060364BD RID: 222397 RVA: 0x007457A4 File Offset: 0x007439A4
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

		// Token: 0x060364BE RID: 222398 RVA: 0x007457E0 File Offset: 0x007439E0
		public static Offset<ISheriffReasoning> CreateISheriffReasoning(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int Id = 0)
		{
			builder.StartTable(2);
			ISheriffReasoning.AddId(builder, Id);
			ISheriffReasoning.AddType(builder, Type);
			return ISheriffReasoning.EndISheriffReasoning(builder);
		}

		// Token: 0x060364BF RID: 222399 RVA: 0x007457FD File Offset: 0x007439FD
		public static void StartISheriffReasoning(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060364C0 RID: 222400 RVA: 0x00745806 File Offset: 0x00743A06
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060364C1 RID: 222401 RVA: 0x00745811 File Offset: 0x00743A11
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060364C2 RID: 222402 RVA: 0x0074581C File Offset: 0x00743A1C
		public static Offset<ISheriffReasoning> EndISheriffReasoning(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffReasoning>(builder.EndTable());
		}

		// Token: 0x060364C3 RID: 222403 RVA: 0x0074582C File Offset: 0x00743A2C
		public ISheriffReasoningT UnPack()
		{
			ISheriffReasoningT sheriffReasoningT = new ISheriffReasoningT();
			this.UnPackTo(sheriffReasoningT);
			return sheriffReasoningT;
		}

		// Token: 0x060364C4 RID: 222404 RVA: 0x00745847 File Offset: 0x00743A47
		public void UnPackTo(ISheriffReasoningT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x060364C5 RID: 222405 RVA: 0x00745864 File Offset: 0x00743A64
		public static Offset<ISheriffReasoning> Pack(FlatBufferBuilder builder, ISheriffReasoningT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffReasoning>);
			}
			return ISheriffReasoning.CreateISheriffReasoning(builder, _o.Type, _o.Id);
		}

		// Token: 0x04012B21 RID: 76577
		private Table __p;
	}
}
