using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007604 RID: 30212
	public struct IWhiteCatWarning : IFlatbufferObject
	{
		// Token: 0x1700E57F RID: 58751
		// (get) Token: 0x0603708A RID: 225418 RVA: 0x0077761D File Offset: 0x0077581D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603708B RID: 225419 RVA: 0x0077762A File Offset: 0x0077582A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603708C RID: 225420 RVA: 0x00777634 File Offset: 0x00775834
		public static IWhiteCatWarning GetRootAsIWhiteCatWarning(ByteBuffer _bb)
		{
			return IWhiteCatWarning.GetRootAsIWhiteCatWarning(_bb, default(IWhiteCatWarning));
		}

		// Token: 0x0603708D RID: 225421 RVA: 0x00777650 File Offset: 0x00775850
		public static IWhiteCatWarning GetRootAsIWhiteCatWarning(ByteBuffer _bb, IWhiteCatWarning obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603708E RID: 225422 RVA: 0x0077766D File Offset: 0x0077586D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603708F RID: 225423 RVA: 0x0077767C File Offset: 0x0077587C
		public IWhiteCatWarning __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E580 RID: 58752
		// (get) Token: 0x06037090 RID: 225424 RVA: 0x0077768C File Offset: 0x0077588C
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

		// Token: 0x1700E581 RID: 58753
		// (get) Token: 0x06037091 RID: 225425 RVA: 0x007776C8 File Offset: 0x007758C8
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

		// Token: 0x06037092 RID: 225426 RVA: 0x007776FF File Offset: 0x007758FF
		public Span<byte> GetWarningTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06037093 RID: 225427 RVA: 0x0077770E File Offset: 0x0077590E
		public byte[] GetWarningTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06037094 RID: 225428 RVA: 0x0077771C File Offset: 0x0077591C
		public static Offset<IWhiteCatWarning> CreateIWhiteCatWarning(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset WarningTextOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IWhiteCatWarning.AddWarningText(builder, WarningTextOffset);
			IWhiteCatWarning.AddType(builder, Type);
			return IWhiteCatWarning.EndIWhiteCatWarning(builder);
		}

		// Token: 0x06037095 RID: 225429 RVA: 0x00777739 File Offset: 0x00775939
		public static void StartIWhiteCatWarning(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06037096 RID: 225430 RVA: 0x00777742 File Offset: 0x00775942
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037097 RID: 225431 RVA: 0x0077774D File Offset: 0x0077594D
		public static void AddWarningText(FlatBufferBuilder builder, StringOffset warningTextOffset)
		{
			builder.AddOffset(1, warningTextOffset.Value, 0);
		}

		// Token: 0x06037098 RID: 225432 RVA: 0x0077775D File Offset: 0x0077595D
		public static Offset<IWhiteCatWarning> EndIWhiteCatWarning(FlatBufferBuilder builder)
		{
			return new Offset<IWhiteCatWarning>(builder.EndTable());
		}

		// Token: 0x06037099 RID: 225433 RVA: 0x0077776C File Offset: 0x0077596C
		public IWhiteCatWarningT UnPack()
		{
			IWhiteCatWarningT whiteCatWarningT = new IWhiteCatWarningT();
			this.UnPackTo(whiteCatWarningT);
			return whiteCatWarningT;
		}

		// Token: 0x0603709A RID: 225434 RVA: 0x00777787 File Offset: 0x00775987
		public void UnPackTo(IWhiteCatWarningT _o)
		{
			_o.Type = this.Type;
			_o.WarningText = this.WarningText;
		}

		// Token: 0x0603709B RID: 225435 RVA: 0x007777A4 File Offset: 0x007759A4
		public static Offset<IWhiteCatWarning> Pack(FlatBufferBuilder builder, IWhiteCatWarningT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWhiteCatWarning>);
			}
			StringOffset warningTextOffset = (_o.WarningText == null) ? default(StringOffset) : builder.CreateString(_o.WarningText);
			return IWhiteCatWarning.CreateIWhiteCatWarning(builder, _o.Type, warningTextOffset);
		}

		// Token: 0x04012576 RID: 75126
		private Table __p;
	}
}
