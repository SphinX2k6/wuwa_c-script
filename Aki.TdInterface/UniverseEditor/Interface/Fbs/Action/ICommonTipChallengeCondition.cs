using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200648C RID: 25740
	public struct ICommonTipChallengeCondition : IFlatbufferObject
	{
		// Token: 0x1700BF8D RID: 49037
		// (get) Token: 0x0602C9B0 RID: 182704 RVA: 0x00620292 File Offset: 0x0061E492
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C9B1 RID: 182705 RVA: 0x0062029F File Offset: 0x0061E49F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C9B2 RID: 182706 RVA: 0x006202A8 File Offset: 0x0061E4A8
		public static ICommonTipChallengeCondition GetRootAsICommonTipChallengeCondition(ByteBuffer _bb)
		{
			return ICommonTipChallengeCondition.GetRootAsICommonTipChallengeCondition(_bb, default(ICommonTipChallengeCondition));
		}

		// Token: 0x0602C9B3 RID: 182707 RVA: 0x006202C4 File Offset: 0x0061E4C4
		public static ICommonTipChallengeCondition GetRootAsICommonTipChallengeCondition(ByteBuffer _bb, ICommonTipChallengeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C9B4 RID: 182708 RVA: 0x006202E1 File Offset: 0x0061E4E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C9B5 RID: 182709 RVA: 0x006202F0 File Offset: 0x0061E4F0
		public ICommonTipChallengeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF8E RID: 49038
		// (get) Token: 0x0602C9B6 RID: 182710 RVA: 0x00620300 File Offset: 0x0061E500
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

		// Token: 0x1700BF8F RID: 49039
		// (get) Token: 0x0602C9B7 RID: 182711 RVA: 0x0062033C File Offset: 0x0061E53C
		public string TidMainText
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

		// Token: 0x0602C9B8 RID: 182712 RVA: 0x00620373 File Offset: 0x0061E573
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602C9B9 RID: 182713 RVA: 0x00620382 File Offset: 0x0061E582
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700BF90 RID: 49040
		// (get) Token: 0x0602C9BA RID: 182714 RVA: 0x00620390 File Offset: 0x0061E590
		public string TidSubText
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

		// Token: 0x0602C9BB RID: 182715 RVA: 0x006203C7 File Offset: 0x0061E5C7
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602C9BC RID: 182716 RVA: 0x006203D6 File Offset: 0x0061E5D6
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602C9BD RID: 182717 RVA: 0x006203E4 File Offset: 0x0061E5E4
		public static Offset<ICommonTipChallengeCondition> CreateICommonTipChallengeCondition(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ICommonTipChallengeCondition.AddTidSubText(builder, TidSubTextOffset);
			ICommonTipChallengeCondition.AddTidMainText(builder, TidMainTextOffset);
			ICommonTipChallengeCondition.AddType(builder, Type);
			return ICommonTipChallengeCondition.EndICommonTipChallengeCondition(builder);
		}

		// Token: 0x0602C9BE RID: 182718 RVA: 0x00620408 File Offset: 0x0061E608
		public static void StartICommonTipChallengeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C9BF RID: 182719 RVA: 0x00620411 File Offset: 0x0061E611
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C9C0 RID: 182720 RVA: 0x0062041C File Offset: 0x0061E61C
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x0602C9C1 RID: 182721 RVA: 0x0062042C File Offset: 0x0061E62C
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x0602C9C2 RID: 182722 RVA: 0x0062043C File Offset: 0x0061E63C
		public static Offset<ICommonTipChallengeCondition> EndICommonTipChallengeCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipChallengeCondition>(builder.EndTable());
		}

		// Token: 0x0602C9C3 RID: 182723 RVA: 0x0062044C File Offset: 0x0061E64C
		public ICommonTipChallengeConditionT UnPack()
		{
			ICommonTipChallengeConditionT commonTipChallengeConditionT = new ICommonTipChallengeConditionT();
			this.UnPackTo(commonTipChallengeConditionT);
			return commonTipChallengeConditionT;
		}

		// Token: 0x0602C9C4 RID: 182724 RVA: 0x00620467 File Offset: 0x0061E667
		public void UnPackTo(ICommonTipChallengeConditionT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x0602C9C5 RID: 182725 RVA: 0x00620490 File Offset: 0x0061E690
		public static Offset<ICommonTipChallengeCondition> Pack(FlatBufferBuilder builder, ICommonTipChallengeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipChallengeCondition>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			return ICommonTipChallengeCondition.CreateICommonTipChallengeCondition(builder, _o.Type, tidMainTextOffset, tidSubTextOffset);
		}

		// Token: 0x04010A98 RID: 68248
		private Table __p;
	}
}
