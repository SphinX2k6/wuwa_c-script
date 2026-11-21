using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E12 RID: 32274
	public struct IWhiteCatWarning : IFlatbufferObject
	{
		// Token: 0x1700F1BD RID: 61885
		// (get) Token: 0x0603A52F RID: 238895 RVA: 0x007DB719 File Offset: 0x007D9919
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A530 RID: 238896 RVA: 0x007DB726 File Offset: 0x007D9926
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A531 RID: 238897 RVA: 0x007DB730 File Offset: 0x007D9930
		public static IWhiteCatWarning GetRootAsIWhiteCatWarning(ByteBuffer _bb)
		{
			return IWhiteCatWarning.GetRootAsIWhiteCatWarning(_bb, default(IWhiteCatWarning));
		}

		// Token: 0x0603A532 RID: 238898 RVA: 0x007DB74C File Offset: 0x007D994C
		public static IWhiteCatWarning GetRootAsIWhiteCatWarning(ByteBuffer _bb, IWhiteCatWarning obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A533 RID: 238899 RVA: 0x007DB769 File Offset: 0x007D9969
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A534 RID: 238900 RVA: 0x007DB778 File Offset: 0x007D9978
		public IWhiteCatWarning __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1BE RID: 61886
		// (get) Token: 0x0603A535 RID: 238901 RVA: 0x007DB788 File Offset: 0x007D9988
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F1BF RID: 61887
		// (get) Token: 0x0603A536 RID: 238902 RVA: 0x007DB7C4 File Offset: 0x007D99C4
		public string WarningText
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

		// Token: 0x0603A537 RID: 238903 RVA: 0x007DB7FB File Offset: 0x007D99FB
		public Span<byte> GetWarningTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603A538 RID: 238904 RVA: 0x007DB80A File Offset: 0x007D9A0A
		public byte[] GetWarningTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0603A539 RID: 238905 RVA: 0x007DB818 File Offset: 0x007D9A18
		public static Offset<IWhiteCatWarning> CreateIWhiteCatWarning(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset WarningTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IWhiteCatWarning.AddWarningText(builder, WarningTextOffset);
			IWhiteCatWarning.AddType(builder, Type);
			return IWhiteCatWarning.EndIWhiteCatWarning(builder);
		}

		// Token: 0x0603A53A RID: 238906 RVA: 0x007DB835 File Offset: 0x007D9A35
		public static void StartIWhiteCatWarning(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603A53B RID: 238907 RVA: 0x007DB83E File Offset: 0x007D9A3E
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A53C RID: 238908 RVA: 0x007DB849 File Offset: 0x007D9A49
		public static void AddWarningText(FlatBufferBuilder builder, StringOffset warningTextOffset)
		{
			builder.AddOffset(1, warningTextOffset.Value, 0);
		}

		// Token: 0x0603A53D RID: 238909 RVA: 0x007DB859 File Offset: 0x007D9A59
		public static Offset<IWhiteCatWarning> EndIWhiteCatWarning(FlatBufferBuilder builder)
		{
			return new Offset<IWhiteCatWarning>(builder.EndTable());
		}

		// Token: 0x0603A53E RID: 238910 RVA: 0x007DB868 File Offset: 0x007D9A68
		public IWhiteCatWarningT UnPack()
		{
			IWhiteCatWarningT whiteCatWarningT = new IWhiteCatWarningT();
			this.UnPackTo(whiteCatWarningT);
			return whiteCatWarningT;
		}

		// Token: 0x0603A53F RID: 238911 RVA: 0x007DB883 File Offset: 0x007D9A83
		public void UnPackTo(IWhiteCatWarningT _o)
		{
			_o.Type = this.Type;
			_o.WarningText = this.WarningText;
		}

		// Token: 0x0603A540 RID: 238912 RVA: 0x007DB8A0 File Offset: 0x007D9AA0
		public static Offset<IWhiteCatWarning> Pack(FlatBufferBuilder builder, IWhiteCatWarningT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWhiteCatWarning>);
			}
			StringOffset warningTextOffset = (_o.WarningText == null) ? default(StringOffset) : builder.CreateString(_o.WarningText);
			return IWhiteCatWarning.CreateIWhiteCatWarning(builder, _o.Type, warningTextOffset);
		}

		// Token: 0x040135C0 RID: 79296
		private Table __p;
	}
}
