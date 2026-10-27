using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D19 RID: 23833
	public struct IAvgSolarSchoolExpression : IFlatbufferObject
	{
		// Token: 0x1700B296 RID: 45718
		// (get) Token: 0x06028B73 RID: 166771 RVA: 0x005979EC File Offset: 0x00595BEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028B74 RID: 166772 RVA: 0x005979F9 File Offset: 0x00595BF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028B75 RID: 166773 RVA: 0x00597A00 File Offset: 0x00595C00
		public static IAvgSolarSchoolExpression GetRootAsIAvgSolarSchoolExpression(ByteBuffer _bb)
		{
			return IAvgSolarSchoolExpression.GetRootAsIAvgSolarSchoolExpression(_bb, default(IAvgSolarSchoolExpression));
		}

		// Token: 0x06028B76 RID: 166774 RVA: 0x00597A1C File Offset: 0x00595C1C
		public static IAvgSolarSchoolExpression GetRootAsIAvgSolarSchoolExpression(ByteBuffer _bb, IAvgSolarSchoolExpression obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028B77 RID: 166775 RVA: 0x00597A39 File Offset: 0x00595C39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028B78 RID: 166776 RVA: 0x00597A48 File Offset: 0x00595C48
		public IAvgSolarSchoolExpression __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B297 RID: 45719
		// (get) Token: 0x06028B79 RID: 166777 RVA: 0x00597A58 File Offset: 0x00595C58
		public int Id
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

		// Token: 0x1700B298 RID: 45720
		// (get) Token: 0x06028B7A RID: 166778 RVA: 0x00597A94 File Offset: 0x00595C94
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028B7B RID: 166779 RVA: 0x00597ACB File Offset: 0x00595CCB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06028B7C RID: 166780 RVA: 0x00597ADA File Offset: 0x00595CDA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B299 RID: 45721
		// (get) Token: 0x06028B7D RID: 166781 RVA: 0x00597AE8 File Offset: 0x00595CE8
		public string BodyAnimation
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

		// Token: 0x06028B7E RID: 166782 RVA: 0x00597B1F File Offset: 0x00595D1F
		public Span<byte> GetBodyAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06028B7F RID: 166783 RVA: 0x00597B2E File Offset: 0x00595D2E
		public byte[] GetBodyAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700B29A RID: 45722
		// (get) Token: 0x06028B80 RID: 166784 RVA: 0x00597B3C File Offset: 0x00595D3C
		public string MouthAnimation
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

		// Token: 0x06028B81 RID: 166785 RVA: 0x00597B74 File Offset: 0x00595D74
		public Span<byte> GetMouthAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06028B82 RID: 166786 RVA: 0x00597B84 File Offset: 0x00595D84
		public byte[] GetMouthAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700B29B RID: 45723
		// (get) Token: 0x06028B83 RID: 166787 RVA: 0x00597B94 File Offset: 0x00595D94
		public string MouthOpenSmallAnimation
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028B84 RID: 166788 RVA: 0x00597BCC File Offset: 0x00595DCC
		public Span<byte> GetMouthOpenSmallAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06028B85 RID: 166789 RVA: 0x00597BDC File Offset: 0x00595DDC
		public byte[] GetMouthOpenSmallAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700B29C RID: 45724
		// (get) Token: 0x06028B86 RID: 166790 RVA: 0x00597BEC File Offset: 0x00595DEC
		public string MouthOpenLargeAnimation
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028B87 RID: 166791 RVA: 0x00597C24 File Offset: 0x00595E24
		public Span<byte> GetMouthOpenLargeAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06028B88 RID: 166792 RVA: 0x00597C34 File Offset: 0x00595E34
		public byte[] GetMouthOpenLargeAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700B29D RID: 45725
		// (get) Token: 0x06028B89 RID: 166793 RVA: 0x00597C44 File Offset: 0x00595E44
		public string EyeAnimation
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028B8A RID: 166794 RVA: 0x00597C7C File Offset: 0x00595E7C
		public Span<byte> GetEyeAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06028B8B RID: 166795 RVA: 0x00597C8C File Offset: 0x00595E8C
		public byte[] GetEyeAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700B29E RID: 45726
		// (get) Token: 0x06028B8C RID: 166796 RVA: 0x00597C9C File Offset: 0x00595E9C
		public string BlinkAnimation
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028B8D RID: 166797 RVA: 0x00597CD4 File Offset: 0x00595ED4
		public Span<byte> GetBlinkAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06028B8E RID: 166798 RVA: 0x00597CE4 File Offset: 0x00595EE4
		public byte[] GetBlinkAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x06028B8F RID: 166799 RVA: 0x00597CF4 File Offset: 0x00595EF4
		public static Offset<IAvgSolarSchoolExpression> CreateIAvgSolarSchoolExpression(FlatBufferBuilder builder, int Id = 0, StringOffset NameOffset = default(StringOffset), StringOffset BodyAnimationOffset = default(StringOffset), StringOffset MouthAnimationOffset = default(StringOffset), StringOffset MouthOpenSmallAnimationOffset = default(StringOffset), StringOffset MouthOpenLargeAnimationOffset = default(StringOffset), StringOffset EyeAnimationOffset = default(StringOffset), StringOffset BlinkAnimationOffset = default(StringOffset))
		{
			builder.StartTable(8);
			IAvgSolarSchoolExpression.AddBlinkAnimation(builder, BlinkAnimationOffset);
			IAvgSolarSchoolExpression.AddEyeAnimation(builder, EyeAnimationOffset);
			IAvgSolarSchoolExpression.AddMouthOpenLargeAnimation(builder, MouthOpenLargeAnimationOffset);
			IAvgSolarSchoolExpression.AddMouthOpenSmallAnimation(builder, MouthOpenSmallAnimationOffset);
			IAvgSolarSchoolExpression.AddMouthAnimation(builder, MouthAnimationOffset);
			IAvgSolarSchoolExpression.AddBodyAnimation(builder, BodyAnimationOffset);
			IAvgSolarSchoolExpression.AddName(builder, NameOffset);
			IAvgSolarSchoolExpression.AddId(builder, Id);
			return IAvgSolarSchoolExpression.EndIAvgSolarSchoolExpression(builder);
		}

		// Token: 0x06028B90 RID: 166800 RVA: 0x00597D4B File Offset: 0x00595F4B
		public static void StartIAvgSolarSchoolExpression(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06028B91 RID: 166801 RVA: 0x00597D54 File Offset: 0x00595F54
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06028B92 RID: 166802 RVA: 0x00597D5F File Offset: 0x00595F5F
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x06028B93 RID: 166803 RVA: 0x00597D6F File Offset: 0x00595F6F
		public static void AddBodyAnimation(FlatBufferBuilder builder, StringOffset bodyAnimationOffset)
		{
			builder.AddOffset(2, bodyAnimationOffset.Value, 0);
		}

		// Token: 0x06028B94 RID: 166804 RVA: 0x00597D7F File Offset: 0x00595F7F
		public static void AddMouthAnimation(FlatBufferBuilder builder, StringOffset mouthAnimationOffset)
		{
			builder.AddOffset(3, mouthAnimationOffset.Value, 0);
		}

		// Token: 0x06028B95 RID: 166805 RVA: 0x00597D8F File Offset: 0x00595F8F
		public static void AddMouthOpenSmallAnimation(FlatBufferBuilder builder, StringOffset mouthOpenSmallAnimationOffset)
		{
			builder.AddOffset(4, mouthOpenSmallAnimationOffset.Value, 0);
		}

		// Token: 0x06028B96 RID: 166806 RVA: 0x00597D9F File Offset: 0x00595F9F
		public static void AddMouthOpenLargeAnimation(FlatBufferBuilder builder, StringOffset mouthOpenLargeAnimationOffset)
		{
			builder.AddOffset(5, mouthOpenLargeAnimationOffset.Value, 0);
		}

		// Token: 0x06028B97 RID: 166807 RVA: 0x00597DAF File Offset: 0x00595FAF
		public static void AddEyeAnimation(FlatBufferBuilder builder, StringOffset eyeAnimationOffset)
		{
			builder.AddOffset(6, eyeAnimationOffset.Value, 0);
		}

		// Token: 0x06028B98 RID: 166808 RVA: 0x00597DBF File Offset: 0x00595FBF
		public static void AddBlinkAnimation(FlatBufferBuilder builder, StringOffset blinkAnimationOffset)
		{
			builder.AddOffset(7, blinkAnimationOffset.Value, 0);
		}

		// Token: 0x06028B99 RID: 166809 RVA: 0x00597DCF File Offset: 0x00595FCF
		public static Offset<IAvgSolarSchoolExpression> EndIAvgSolarSchoolExpression(FlatBufferBuilder builder)
		{
			return new Offset<IAvgSolarSchoolExpression>(builder.EndTable());
		}

		// Token: 0x06028B9A RID: 166810 RVA: 0x00597DDC File Offset: 0x00595FDC
		public IAvgSolarSchoolExpressionT UnPack()
		{
			IAvgSolarSchoolExpressionT avgSolarSchoolExpressionT = new IAvgSolarSchoolExpressionT();
			this.UnPackTo(avgSolarSchoolExpressionT);
			return avgSolarSchoolExpressionT;
		}

		// Token: 0x06028B9B RID: 166811 RVA: 0x00597DF8 File Offset: 0x00595FF8
		public void UnPackTo(IAvgSolarSchoolExpressionT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.BodyAnimation = this.BodyAnimation;
			_o.MouthAnimation = this.MouthAnimation;
			_o.MouthOpenSmallAnimation = this.MouthOpenSmallAnimation;
			_o.MouthOpenLargeAnimation = this.MouthOpenLargeAnimation;
			_o.EyeAnimation = this.EyeAnimation;
			_o.BlinkAnimation = this.BlinkAnimation;
		}

		// Token: 0x06028B9C RID: 166812 RVA: 0x00597E68 File Offset: 0x00596068
		public static Offset<IAvgSolarSchoolExpression> Pack(FlatBufferBuilder builder, IAvgSolarSchoolExpressionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAvgSolarSchoolExpression>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset bodyAnimationOffset = (_o.BodyAnimation == null) ? default(StringOffset) : builder.CreateString(_o.BodyAnimation);
			StringOffset mouthAnimationOffset = (_o.MouthAnimation == null) ? default(StringOffset) : builder.CreateString(_o.MouthAnimation);
			StringOffset mouthOpenSmallAnimationOffset = (_o.MouthOpenSmallAnimation == null) ? default(StringOffset) : builder.CreateString(_o.MouthOpenSmallAnimation);
			StringOffset mouthOpenLargeAnimationOffset = (_o.MouthOpenLargeAnimation == null) ? default(StringOffset) : builder.CreateString(_o.MouthOpenLargeAnimation);
			StringOffset eyeAnimationOffset = (_o.EyeAnimation == null) ? default(StringOffset) : builder.CreateString(_o.EyeAnimation);
			StringOffset blinkAnimationOffset = (_o.BlinkAnimation == null) ? default(StringOffset) : builder.CreateString(_o.BlinkAnimation);
			return IAvgSolarSchoolExpression.CreateIAvgSolarSchoolExpression(builder, _o.Id, nameOffset, bodyAnimationOffset, mouthAnimationOffset, mouthOpenSmallAnimationOffset, mouthOpenLargeAnimationOffset, eyeAnimationOffset, blinkAnimationOffset);
		}

		// Token: 0x0400F6C1 RID: 63169
		private Table __p;
	}
}
