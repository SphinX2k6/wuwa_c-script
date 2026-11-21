using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006350 RID: 25424
	public struct IAvgSolarSchoolExpression : IFlatbufferObject
	{
		// Token: 0x1700BBF7 RID: 48119
		// (get) Token: 0x0602B1DD RID: 176605 RVA: 0x005E045C File Offset: 0x005DE65C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B1DE RID: 176606 RVA: 0x005E0469 File Offset: 0x005DE669
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B1DF RID: 176607 RVA: 0x005E0470 File Offset: 0x005DE670
		public static IAvgSolarSchoolExpression GetRootAsIAvgSolarSchoolExpression(ByteBuffer _bb)
		{
			return IAvgSolarSchoolExpression.GetRootAsIAvgSolarSchoolExpression(_bb, default(IAvgSolarSchoolExpression));
		}

		// Token: 0x0602B1E0 RID: 176608 RVA: 0x005E048C File Offset: 0x005DE68C
		public static IAvgSolarSchoolExpression GetRootAsIAvgSolarSchoolExpression(ByteBuffer _bb, IAvgSolarSchoolExpression obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B1E1 RID: 176609 RVA: 0x005E04A9 File Offset: 0x005DE6A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B1E2 RID: 176610 RVA: 0x005E04B8 File Offset: 0x005DE6B8
		public IAvgSolarSchoolExpression __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBF8 RID: 48120
		// (get) Token: 0x0602B1E3 RID: 176611 RVA: 0x005E04C8 File Offset: 0x005DE6C8
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

		// Token: 0x1700BBF9 RID: 48121
		// (get) Token: 0x0602B1E4 RID: 176612 RVA: 0x005E0504 File Offset: 0x005DE704
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

		// Token: 0x0602B1E5 RID: 176613 RVA: 0x005E053B File Offset: 0x005DE73B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602B1E6 RID: 176614 RVA: 0x005E054A File Offset: 0x005DE74A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700BBFA RID: 48122
		// (get) Token: 0x0602B1E7 RID: 176615 RVA: 0x005E0558 File Offset: 0x005DE758
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

		// Token: 0x0602B1E8 RID: 176616 RVA: 0x005E058F File Offset: 0x005DE78F
		public Span<byte> GetBodyAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602B1E9 RID: 176617 RVA: 0x005E059E File Offset: 0x005DE79E
		public byte[] GetBodyAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700BBFB RID: 48123
		// (get) Token: 0x0602B1EA RID: 176618 RVA: 0x005E05AC File Offset: 0x005DE7AC
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

		// Token: 0x0602B1EB RID: 176619 RVA: 0x005E05E4 File Offset: 0x005DE7E4
		public Span<byte> GetMouthAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602B1EC RID: 176620 RVA: 0x005E05F4 File Offset: 0x005DE7F4
		public byte[] GetMouthAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700BBFC RID: 48124
		// (get) Token: 0x0602B1ED RID: 176621 RVA: 0x005E0604 File Offset: 0x005DE804
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

		// Token: 0x0602B1EE RID: 176622 RVA: 0x005E063C File Offset: 0x005DE83C
		public Span<byte> GetMouthOpenSmallAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602B1EF RID: 176623 RVA: 0x005E064C File Offset: 0x005DE84C
		public byte[] GetMouthOpenSmallAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700BBFD RID: 48125
		// (get) Token: 0x0602B1F0 RID: 176624 RVA: 0x005E065C File Offset: 0x005DE85C
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

		// Token: 0x0602B1F1 RID: 176625 RVA: 0x005E0694 File Offset: 0x005DE894
		public Span<byte> GetMouthOpenLargeAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0602B1F2 RID: 176626 RVA: 0x005E06A4 File Offset: 0x005DE8A4
		public byte[] GetMouthOpenLargeAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700BBFE RID: 48126
		// (get) Token: 0x0602B1F3 RID: 176627 RVA: 0x005E06B4 File Offset: 0x005DE8B4
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

		// Token: 0x0602B1F4 RID: 176628 RVA: 0x005E06EC File Offset: 0x005DE8EC
		public Span<byte> GetEyeAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0602B1F5 RID: 176629 RVA: 0x005E06FC File Offset: 0x005DE8FC
		public byte[] GetEyeAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700BBFF RID: 48127
		// (get) Token: 0x0602B1F6 RID: 176630 RVA: 0x005E070C File Offset: 0x005DE90C
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

		// Token: 0x0602B1F7 RID: 176631 RVA: 0x005E0744 File Offset: 0x005DE944
		public Span<byte> GetBlinkAnimationBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0602B1F8 RID: 176632 RVA: 0x005E0754 File Offset: 0x005DE954
		public byte[] GetBlinkAnimationArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x0602B1F9 RID: 176633 RVA: 0x005E0764 File Offset: 0x005DE964
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

		// Token: 0x0602B1FA RID: 176634 RVA: 0x005E07BB File Offset: 0x005DE9BB
		public static void StartIAvgSolarSchoolExpression(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602B1FB RID: 176635 RVA: 0x005E07C4 File Offset: 0x005DE9C4
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602B1FC RID: 176636 RVA: 0x005E07CF File Offset: 0x005DE9CF
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0602B1FD RID: 176637 RVA: 0x005E07DF File Offset: 0x005DE9DF
		public static void AddBodyAnimation(FlatBufferBuilder builder, StringOffset bodyAnimationOffset)
		{
			builder.AddOffset(2, bodyAnimationOffset.Value, 0);
		}

		// Token: 0x0602B1FE RID: 176638 RVA: 0x005E07EF File Offset: 0x005DE9EF
		public static void AddMouthAnimation(FlatBufferBuilder builder, StringOffset mouthAnimationOffset)
		{
			builder.AddOffset(3, mouthAnimationOffset.Value, 0);
		}

		// Token: 0x0602B1FF RID: 176639 RVA: 0x005E07FF File Offset: 0x005DE9FF
		public static void AddMouthOpenSmallAnimation(FlatBufferBuilder builder, StringOffset mouthOpenSmallAnimationOffset)
		{
			builder.AddOffset(4, mouthOpenSmallAnimationOffset.Value, 0);
		}

		// Token: 0x0602B200 RID: 176640 RVA: 0x005E080F File Offset: 0x005DEA0F
		public static void AddMouthOpenLargeAnimation(FlatBufferBuilder builder, StringOffset mouthOpenLargeAnimationOffset)
		{
			builder.AddOffset(5, mouthOpenLargeAnimationOffset.Value, 0);
		}

		// Token: 0x0602B201 RID: 176641 RVA: 0x005E081F File Offset: 0x005DEA1F
		public static void AddEyeAnimation(FlatBufferBuilder builder, StringOffset eyeAnimationOffset)
		{
			builder.AddOffset(6, eyeAnimationOffset.Value, 0);
		}

		// Token: 0x0602B202 RID: 176642 RVA: 0x005E082F File Offset: 0x005DEA2F
		public static void AddBlinkAnimation(FlatBufferBuilder builder, StringOffset blinkAnimationOffset)
		{
			builder.AddOffset(7, blinkAnimationOffset.Value, 0);
		}

		// Token: 0x0602B203 RID: 176643 RVA: 0x005E083F File Offset: 0x005DEA3F
		public static Offset<IAvgSolarSchoolExpression> EndIAvgSolarSchoolExpression(FlatBufferBuilder builder)
		{
			return new Offset<IAvgSolarSchoolExpression>(builder.EndTable());
		}

		// Token: 0x0602B204 RID: 176644 RVA: 0x005E084C File Offset: 0x005DEA4C
		public IAvgSolarSchoolExpressionT UnPack()
		{
			IAvgSolarSchoolExpressionT avgSolarSchoolExpressionT = new IAvgSolarSchoolExpressionT();
			this.UnPackTo(avgSolarSchoolExpressionT);
			return avgSolarSchoolExpressionT;
		}

		// Token: 0x0602B205 RID: 176645 RVA: 0x005E0868 File Offset: 0x005DEA68
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

		// Token: 0x0602B206 RID: 176646 RVA: 0x005E08D8 File Offset: 0x005DEAD8
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

		// Token: 0x04010413 RID: 66579
		private Table __p;
	}
}
