using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D29 RID: 27945
	public struct IPlayMontage : IFlatbufferObject
	{
		// Token: 0x1700D020 RID: 53280
		// (get) Token: 0x0603149C RID: 201884 RVA: 0x006AF46D File Offset: 0x006AD66D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603149D RID: 201885 RVA: 0x006AF47A File Offset: 0x006AD67A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603149E RID: 201886 RVA: 0x006AF484 File Offset: 0x006AD684
		public static IPlayMontage GetRootAsIPlayMontage(ByteBuffer _bb)
		{
			return IPlayMontage.GetRootAsIPlayMontage(_bb, default(IPlayMontage));
		}

		// Token: 0x0603149F RID: 201887 RVA: 0x006AF4A0 File Offset: 0x006AD6A0
		public static IPlayMontage GetRootAsIPlayMontage(ByteBuffer _bb, IPlayMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060314A0 RID: 201888 RVA: 0x006AF4BD File Offset: 0x006AD6BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060314A1 RID: 201889 RVA: 0x006AF4CC File Offset: 0x006AD6CC
		public IPlayMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D021 RID: 53281
		// (get) Token: 0x060314A2 RID: 201890 RVA: 0x006AF4DC File Offset: 0x006AD6DC
		public int EntityId
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

		// Token: 0x1700D022 RID: 53282
		// (get) Token: 0x060314A3 RID: 201891 RVA: 0x006AF518 File Offset: 0x006AD718
		public IActionMontage? ActionMontage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IActionMontage?(default(IActionMontage).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D023 RID: 53283
		// (get) Token: 0x060314A4 RID: 201892 RVA: 0x006AF578 File Offset: 0x006AD778
		public string ExpressionMontage
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060314A5 RID: 201893 RVA: 0x006AF5AF File Offset: 0x006AD7AF
		public Span<byte> GetExpressionMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060314A6 RID: 201894 RVA: 0x006AF5BE File Offset: 0x006AD7BE
		public byte[] GetExpressionMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700D024 RID: 53284
		// (get) Token: 0x060314A7 RID: 201895 RVA: 0x006AF5CC File Offset: 0x006AD7CC
		public string MouthSequence
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060314A8 RID: 201896 RVA: 0x006AF604 File Offset: 0x006AD804
		public Span<byte> GetMouthSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060314A9 RID: 201897 RVA: 0x006AF614 File Offset: 0x006AD814
		public byte[] GetMouthSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700D025 RID: 53285
		// (get) Token: 0x060314AA RID: 201898 RVA: 0x006AF624 File Offset: 0x006AD824
		public int Duration
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D026 RID: 53286
		// (get) Token: 0x060314AB RID: 201899 RVA: 0x006AF664 File Offset: 0x006AD864
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060314AC RID: 201900 RVA: 0x006AF6A1 File Offset: 0x006AD8A1
		public static Offset<IPlayMontage> CreateIPlayMontage(FlatBufferBuilder builder, int EntityId = 0, Offset<IActionMontage> ActionMontageOffset = default(Offset<IActionMontage>), StringOffset ExpressionMontageOffset = default(StringOffset), StringOffset MouthSequenceOffset = default(StringOffset), int Duration = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IPlayMontage.AddDuration(builder, Duration);
			IPlayMontage.AddMouthSequence(builder, MouthSequenceOffset);
			IPlayMontage.AddExpressionMontage(builder, ExpressionMontageOffset);
			IPlayMontage.AddActionMontage(builder, ActionMontageOffset);
			IPlayMontage.AddEntityId(builder, EntityId);
			IPlayMontage.AddNullMask(builder, NullMask);
			return IPlayMontage.EndIPlayMontage(builder);
		}

		// Token: 0x060314AD RID: 201901 RVA: 0x006AF6DD File Offset: 0x006AD8DD
		public static void StartIPlayMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060314AE RID: 201902 RVA: 0x006AF6E6 File Offset: 0x006AD8E6
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x060314AF RID: 201903 RVA: 0x006AF6F1 File Offset: 0x006AD8F1
		public static void AddActionMontage(FlatBufferBuilder builder, Offset<IActionMontage> actionMontageOffset)
		{
			builder.AddOffset(1, actionMontageOffset.Value, 0);
		}

		// Token: 0x060314B0 RID: 201904 RVA: 0x006AF701 File Offset: 0x006AD901
		public static void AddExpressionMontage(FlatBufferBuilder builder, StringOffset expressionMontageOffset)
		{
			builder.AddOffset(2, expressionMontageOffset.Value, 0);
		}

		// Token: 0x060314B1 RID: 201905 RVA: 0x006AF711 File Offset: 0x006AD911
		public static void AddMouthSequence(FlatBufferBuilder builder, StringOffset mouthSequenceOffset)
		{
			builder.AddOffset(3, mouthSequenceOffset.Value, 0);
		}

		// Token: 0x060314B2 RID: 201906 RVA: 0x006AF721 File Offset: 0x006AD921
		public static void AddDuration(FlatBufferBuilder builder, int duration)
		{
			builder.AddInt(4, duration, 0);
		}

		// Token: 0x060314B3 RID: 201907 RVA: 0x006AF72C File Offset: 0x006AD92C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060314B4 RID: 201908 RVA: 0x006AF737 File Offset: 0x006AD937
		public static Offset<IPlayMontage> EndIPlayMontage(FlatBufferBuilder builder)
		{
			return new Offset<IPlayMontage>(builder.EndTable());
		}

		// Token: 0x060314B5 RID: 201909 RVA: 0x006AF744 File Offset: 0x006AD944
		public IPlayMontageT UnPack()
		{
			IPlayMontageT playMontageT = new IPlayMontageT();
			this.UnPackTo(playMontageT);
			return playMontageT;
		}

		// Token: 0x060314B6 RID: 201910 RVA: 0x006AF760 File Offset: 0x006AD960
		public void UnPackTo(IPlayMontageT _o)
		{
			_o.EntityId = this.EntityId;
			_o.ActionMontage = ((this.ActionMontage != null) ? this.ActionMontage.Value.UnPack() : null);
			_o.ExpressionMontage = this.ExpressionMontage;
			_o.MouthSequence = this.MouthSequence;
			_o.Duration = this.Duration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060314B7 RID: 201911 RVA: 0x006AF7D8 File Offset: 0x006AD9D8
		public static Offset<IPlayMontage> Pack(FlatBufferBuilder builder, IPlayMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayMontage>);
			}
			Offset<IActionMontage> actionMontageOffset = (_o.ActionMontage == null) ? default(Offset<IActionMontage>) : IActionMontage.Pack(builder, _o.ActionMontage);
			StringOffset expressionMontageOffset = (_o.ExpressionMontage == null) ? default(StringOffset) : builder.CreateString(_o.ExpressionMontage);
			StringOffset mouthSequenceOffset = (_o.MouthSequence == null) ? default(StringOffset) : builder.CreateString(_o.MouthSequence);
			return IPlayMontage.CreateIPlayMontage(builder, _o.EntityId, actionMontageOffset, expressionMontageOffset, mouthSequenceOffset, _o.Duration, _o.NullMask);
		}

		// Token: 0x040116B1 RID: 71345
		private Table __p;
	}
}
