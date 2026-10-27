using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064AD RID: 25773
	public struct ICommonTipTriggerDelegation : IFlatbufferObject
	{
		// Token: 0x1700BFC8 RID: 49096
		// (get) Token: 0x0602CAC0 RID: 182976 RVA: 0x00621BD9 File Offset: 0x0061FDD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CAC1 RID: 182977 RVA: 0x00621BE6 File Offset: 0x0061FDE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CAC2 RID: 182978 RVA: 0x00621BF0 File Offset: 0x0061FDF0
		public static ICommonTipTriggerDelegation GetRootAsICommonTipTriggerDelegation(ByteBuffer _bb)
		{
			return ICommonTipTriggerDelegation.GetRootAsICommonTipTriggerDelegation(_bb, default(ICommonTipTriggerDelegation));
		}

		// Token: 0x0602CAC3 RID: 182979 RVA: 0x00621C0C File Offset: 0x0061FE0C
		public static ICommonTipTriggerDelegation GetRootAsICommonTipTriggerDelegation(ByteBuffer _bb, ICommonTipTriggerDelegation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CAC4 RID: 182980 RVA: 0x00621C29 File Offset: 0x0061FE29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CAC5 RID: 182981 RVA: 0x00621C38 File Offset: 0x0061FE38
		public ICommonTipTriggerDelegation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFC9 RID: 49097
		// (get) Token: 0x0602CAC6 RID: 182982 RVA: 0x00621C48 File Offset: 0x0061FE48
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

		// Token: 0x1700BFCA RID: 49098
		// (get) Token: 0x0602CAC7 RID: 182983 RVA: 0x00621C84 File Offset: 0x0061FE84
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

		// Token: 0x0602CAC8 RID: 182984 RVA: 0x00621CBB File Offset: 0x0061FEBB
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602CAC9 RID: 182985 RVA: 0x00621CCA File Offset: 0x0061FECA
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700BFCB RID: 49099
		// (get) Token: 0x0602CACA RID: 182986 RVA: 0x00621CD8 File Offset: 0x0061FED8
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

		// Token: 0x0602CACB RID: 182987 RVA: 0x00621D0F File Offset: 0x0061FF0F
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602CACC RID: 182988 RVA: 0x00621D1E File Offset: 0x0061FF1E
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602CACD RID: 182989 RVA: 0x00621D2C File Offset: 0x0061FF2C
		public static Offset<ICommonTipTriggerDelegation> CreateICommonTipTriggerDelegation(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ICommonTipTriggerDelegation.AddTidSubText(builder, TidSubTextOffset);
			ICommonTipTriggerDelegation.AddTidMainText(builder, TidMainTextOffset);
			ICommonTipTriggerDelegation.AddType(builder, Type);
			return ICommonTipTriggerDelegation.EndICommonTipTriggerDelegation(builder);
		}

		// Token: 0x0602CACE RID: 182990 RVA: 0x00621D50 File Offset: 0x0061FF50
		public static void StartICommonTipTriggerDelegation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CACF RID: 182991 RVA: 0x00621D59 File Offset: 0x0061FF59
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CAD0 RID: 182992 RVA: 0x00621D64 File Offset: 0x0061FF64
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x0602CAD1 RID: 182993 RVA: 0x00621D74 File Offset: 0x0061FF74
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x0602CAD2 RID: 182994 RVA: 0x00621D84 File Offset: 0x0061FF84
		public static Offset<ICommonTipTriggerDelegation> EndICommonTipTriggerDelegation(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipTriggerDelegation>(builder.EndTable());
		}

		// Token: 0x0602CAD3 RID: 182995 RVA: 0x00621D94 File Offset: 0x0061FF94
		public ICommonTipTriggerDelegationT UnPack()
		{
			ICommonTipTriggerDelegationT commonTipTriggerDelegationT = new ICommonTipTriggerDelegationT();
			this.UnPackTo(commonTipTriggerDelegationT);
			return commonTipTriggerDelegationT;
		}

		// Token: 0x0602CAD4 RID: 182996 RVA: 0x00621DAF File Offset: 0x0061FFAF
		public void UnPackTo(ICommonTipTriggerDelegationT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x0602CAD5 RID: 182997 RVA: 0x00621DD8 File Offset: 0x0061FFD8
		public static Offset<ICommonTipTriggerDelegation> Pack(FlatBufferBuilder builder, ICommonTipTriggerDelegationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipTriggerDelegation>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			return ICommonTipTriggerDelegation.CreateICommonTipTriggerDelegation(builder, _o.Type, tidMainTextOffset, tidSubTextOffset);
		}

		// Token: 0x04010ABB RID: 68283
		private Table __p;
	}
}
