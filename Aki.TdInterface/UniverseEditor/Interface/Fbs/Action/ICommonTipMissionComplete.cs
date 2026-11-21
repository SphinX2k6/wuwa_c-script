using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B0C RID: 27404
	public struct ICommonTipMissionComplete : IFlatbufferObject
	{
		// Token: 0x1700C93F RID: 51519
		// (get) Token: 0x0602F1D6 RID: 192982 RVA: 0x0066CE5A File Offset: 0x0066B05A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F1D7 RID: 192983 RVA: 0x0066CE67 File Offset: 0x0066B067
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F1D8 RID: 192984 RVA: 0x0066CE70 File Offset: 0x0066B070
		public static ICommonTipMissionComplete GetRootAsICommonTipMissionComplete(ByteBuffer _bb)
		{
			return ICommonTipMissionComplete.GetRootAsICommonTipMissionComplete(_bb, default(ICommonTipMissionComplete));
		}

		// Token: 0x0602F1D9 RID: 192985 RVA: 0x0066CE8C File Offset: 0x0066B08C
		public static ICommonTipMissionComplete GetRootAsICommonTipMissionComplete(ByteBuffer _bb, ICommonTipMissionComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F1DA RID: 192986 RVA: 0x0066CEA9 File Offset: 0x0066B0A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F1DB RID: 192987 RVA: 0x0066CEB8 File Offset: 0x0066B0B8
		public ICommonTipMissionComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C940 RID: 51520
		// (get) Token: 0x0602F1DC RID: 192988 RVA: 0x0066CEC8 File Offset: 0x0066B0C8
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

		// Token: 0x1700C941 RID: 51521
		// (get) Token: 0x0602F1DD RID: 192989 RVA: 0x0066CF04 File Offset: 0x0066B104
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

		// Token: 0x0602F1DE RID: 192990 RVA: 0x0066CF3B File Offset: 0x0066B13B
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F1DF RID: 192991 RVA: 0x0066CF4A File Offset: 0x0066B14A
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C942 RID: 51522
		// (get) Token: 0x0602F1E0 RID: 192992 RVA: 0x0066CF58 File Offset: 0x0066B158
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

		// Token: 0x0602F1E1 RID: 192993 RVA: 0x0066CF8F File Offset: 0x0066B18F
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602F1E2 RID: 192994 RVA: 0x0066CF9E File Offset: 0x0066B19E
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602F1E3 RID: 192995 RVA: 0x0066CFAC File Offset: 0x0066B1AC
		public static Offset<ICommonTipMissionComplete> CreateICommonTipMissionComplete(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ICommonTipMissionComplete.AddTidSubText(builder, TidSubTextOffset);
			ICommonTipMissionComplete.AddTidMainText(builder, TidMainTextOffset);
			ICommonTipMissionComplete.AddType(builder, Type);
			return ICommonTipMissionComplete.EndICommonTipMissionComplete(builder);
		}

		// Token: 0x0602F1E4 RID: 192996 RVA: 0x0066CFD0 File Offset: 0x0066B1D0
		public static void StartICommonTipMissionComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F1E5 RID: 192997 RVA: 0x0066CFD9 File Offset: 0x0066B1D9
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F1E6 RID: 192998 RVA: 0x0066CFE4 File Offset: 0x0066B1E4
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x0602F1E7 RID: 192999 RVA: 0x0066CFF4 File Offset: 0x0066B1F4
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x0602F1E8 RID: 193000 RVA: 0x0066D004 File Offset: 0x0066B204
		public static Offset<ICommonTipMissionComplete> EndICommonTipMissionComplete(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipMissionComplete>(builder.EndTable());
		}

		// Token: 0x0602F1E9 RID: 193001 RVA: 0x0066D014 File Offset: 0x0066B214
		public ICommonTipMissionCompleteT UnPack()
		{
			ICommonTipMissionCompleteT commonTipMissionCompleteT = new ICommonTipMissionCompleteT();
			this.UnPackTo(commonTipMissionCompleteT);
			return commonTipMissionCompleteT;
		}

		// Token: 0x0602F1EA RID: 193002 RVA: 0x0066D02F File Offset: 0x0066B22F
		public void UnPackTo(ICommonTipMissionCompleteT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x0602F1EB RID: 193003 RVA: 0x0066D058 File Offset: 0x0066B258
		public static Offset<ICommonTipMissionComplete> Pack(FlatBufferBuilder builder, ICommonTipMissionCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipMissionComplete>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			return ICommonTipMissionComplete.CreateICommonTipMissionComplete(builder, _o.Type, tidMainTextOffset, tidSubTextOffset);
		}

		// Token: 0x040118BF RID: 71871
		private Table __p;
	}
}
