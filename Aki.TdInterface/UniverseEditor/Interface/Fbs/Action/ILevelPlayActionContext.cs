using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200709A RID: 28826
	public struct ILevelPlayActionContext : IFlatbufferObject
	{
		// Token: 0x1700D327 RID: 54055
		// (get) Token: 0x060320B1 RID: 204977 RVA: 0x006C63E1 File Offset: 0x006C45E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060320B2 RID: 204978 RVA: 0x006C63EE File Offset: 0x006C45EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060320B3 RID: 204979 RVA: 0x006C63F8 File Offset: 0x006C45F8
		public static ILevelPlayActionContext GetRootAsILevelPlayActionContext(ByteBuffer _bb)
		{
			return ILevelPlayActionContext.GetRootAsILevelPlayActionContext(_bb, default(ILevelPlayActionContext));
		}

		// Token: 0x060320B4 RID: 204980 RVA: 0x006C6414 File Offset: 0x006C4614
		public static ILevelPlayActionContext GetRootAsILevelPlayActionContext(ByteBuffer _bb, ILevelPlayActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060320B5 RID: 204981 RVA: 0x006C6431 File Offset: 0x006C4631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060320B6 RID: 204982 RVA: 0x006C6440 File Offset: 0x006C4640
		public ILevelPlayActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D328 RID: 54056
		// (get) Token: 0x060320B7 RID: 204983 RVA: 0x006C6450 File Offset: 0x006C4650
		public string Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060320B8 RID: 204984 RVA: 0x006C6487 File Offset: 0x006C4687
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060320B9 RID: 204985 RVA: 0x006C6496 File Offset: 0x006C4696
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D329 RID: 54057
		// (get) Token: 0x060320BA RID: 204986 RVA: 0x006C64A4 File Offset: 0x006C46A4
		public EDecisionBtType DecisionBtType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDecisionBtType.Bvb;
				}
				return (EDecisionBtType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D32A RID: 54058
		// (get) Token: 0x060320BB RID: 204987 RVA: 0x006C64E0 File Offset: 0x006C46E0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060320BC RID: 204988 RVA: 0x006C651C File Offset: 0x006C471C
		public static Offset<ILevelPlayActionContext> CreateILevelPlayActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset), EDecisionBtType DecisionBtType = EDecisionBtType.Bvb, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILevelPlayActionContext.AddType(builder, TypeOffset);
			ILevelPlayActionContext.AddNullMask(builder, NullMask);
			ILevelPlayActionContext.AddDecisionBtType(builder, DecisionBtType);
			return ILevelPlayActionContext.EndILevelPlayActionContext(builder);
		}

		// Token: 0x060320BD RID: 204989 RVA: 0x006C6540 File Offset: 0x006C4740
		public static void StartILevelPlayActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060320BE RID: 204990 RVA: 0x006C6549 File Offset: 0x006C4749
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x060320BF RID: 204991 RVA: 0x006C6559 File Offset: 0x006C4759
		public static void AddDecisionBtType(FlatBufferBuilder builder, EDecisionBtType decisionBtType)
		{
			builder.AddByte(1, (byte)decisionBtType, 0);
		}

		// Token: 0x060320C0 RID: 204992 RVA: 0x006C6564 File Offset: 0x006C4764
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060320C1 RID: 204993 RVA: 0x006C656F File Offset: 0x006C476F
		public static Offset<ILevelPlayActionContext> EndILevelPlayActionContext(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayActionContext>(builder.EndTable());
		}

		// Token: 0x060320C2 RID: 204994 RVA: 0x006C657C File Offset: 0x006C477C
		public ILevelPlayActionContextT UnPack()
		{
			ILevelPlayActionContextT levelPlayActionContextT = new ILevelPlayActionContextT();
			this.UnPackTo(levelPlayActionContextT);
			return levelPlayActionContextT;
		}

		// Token: 0x060320C3 RID: 204995 RVA: 0x006C6597 File Offset: 0x006C4797
		public void UnPackTo(ILevelPlayActionContextT _o)
		{
			_o.Type = this.Type;
			_o.DecisionBtType = this.DecisionBtType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060320C4 RID: 204996 RVA: 0x006C65C0 File Offset: 0x006C47C0
		public static Offset<ILevelPlayActionContext> Pack(FlatBufferBuilder builder, ILevelPlayActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return ILevelPlayActionContext.CreateILevelPlayActionContext(builder, typeOffset, _o.DecisionBtType, _o.NullMask);
		}

		// Token: 0x04012049 RID: 73801
		private Table __p;
	}
}
