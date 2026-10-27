using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E25 RID: 28197
	public struct IReignsChangeBackground : IFlatbufferObject
	{
		// Token: 0x1700D228 RID: 53800
		// (get) Token: 0x06031D23 RID: 204067 RVA: 0x006BE909 File Offset: 0x006BCB09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031D24 RID: 204068 RVA: 0x006BE916 File Offset: 0x006BCB16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031D25 RID: 204069 RVA: 0x006BE920 File Offset: 0x006BCB20
		public static IReignsChangeBackground GetRootAsIReignsChangeBackground(ByteBuffer _bb)
		{
			return IReignsChangeBackground.GetRootAsIReignsChangeBackground(_bb, default(IReignsChangeBackground));
		}

		// Token: 0x06031D26 RID: 204070 RVA: 0x006BE93C File Offset: 0x006BCB3C
		public static IReignsChangeBackground GetRootAsIReignsChangeBackground(ByteBuffer _bb, IReignsChangeBackground obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031D27 RID: 204071 RVA: 0x006BE959 File Offset: 0x006BCB59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031D28 RID: 204072 RVA: 0x006BE968 File Offset: 0x006BCB68
		public IReignsChangeBackground __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D229 RID: 53801
		// (get) Token: 0x06031D29 RID: 204073 RVA: 0x006BE978 File Offset: 0x006BCB78
		public string Background
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

		// Token: 0x06031D2A RID: 204074 RVA: 0x006BE9AF File Offset: 0x006BCBAF
		public Span<byte> GetBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06031D2B RID: 204075 RVA: 0x006BE9BE File Offset: 0x006BCBBE
		public byte[] GetBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D22A RID: 53802
		// (get) Token: 0x06031D2C RID: 204076 RVA: 0x006BE9CC File Offset: 0x006BCBCC
		public EReignsBackgroundChangeMode ChangeMode
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EReignsBackgroundChangeMode.Instant;
				}
				return (EReignsBackgroundChangeMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031D2D RID: 204077 RVA: 0x006BEA08 File Offset: 0x006BCC08
		public static Offset<IReignsChangeBackground> CreateIReignsChangeBackground(FlatBufferBuilder builder, StringOffset BackgroundOffset = default(StringOffset), EReignsBackgroundChangeMode ChangeMode = EReignsBackgroundChangeMode.Instant)
		{
			builder.StartTable(2);
			IReignsChangeBackground.AddBackground(builder, BackgroundOffset);
			IReignsChangeBackground.AddChangeMode(builder, ChangeMode);
			return IReignsChangeBackground.EndIReignsChangeBackground(builder);
		}

		// Token: 0x06031D2E RID: 204078 RVA: 0x006BEA25 File Offset: 0x006BCC25
		public static void StartIReignsChangeBackground(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031D2F RID: 204079 RVA: 0x006BEA2E File Offset: 0x006BCC2E
		public static void AddBackground(FlatBufferBuilder builder, StringOffset backgroundOffset)
		{
			builder.AddOffset(0, backgroundOffset.Value, 0);
		}

		// Token: 0x06031D30 RID: 204080 RVA: 0x006BEA3E File Offset: 0x006BCC3E
		public static void AddChangeMode(FlatBufferBuilder builder, EReignsBackgroundChangeMode changeMode)
		{
			builder.AddByte(1, (byte)changeMode, 0);
		}

		// Token: 0x06031D31 RID: 204081 RVA: 0x006BEA49 File Offset: 0x006BCC49
		public static Offset<IReignsChangeBackground> EndIReignsChangeBackground(FlatBufferBuilder builder)
		{
			return new Offset<IReignsChangeBackground>(builder.EndTable());
		}

		// Token: 0x06031D32 RID: 204082 RVA: 0x006BEA58 File Offset: 0x006BCC58
		public IReignsChangeBackgroundT UnPack()
		{
			IReignsChangeBackgroundT reignsChangeBackgroundT = new IReignsChangeBackgroundT();
			this.UnPackTo(reignsChangeBackgroundT);
			return reignsChangeBackgroundT;
		}

		// Token: 0x06031D33 RID: 204083 RVA: 0x006BEA73 File Offset: 0x006BCC73
		public void UnPackTo(IReignsChangeBackgroundT _o)
		{
			_o.Background = this.Background;
			_o.ChangeMode = this.ChangeMode;
		}

		// Token: 0x06031D34 RID: 204084 RVA: 0x006BEA90 File Offset: 0x006BCC90
		public static Offset<IReignsChangeBackground> Pack(FlatBufferBuilder builder, IReignsChangeBackgroundT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsChangeBackground>);
			}
			StringOffset backgroundOffset = (_o.Background == null) ? default(StringOffset) : builder.CreateString(_o.Background);
			return IReignsChangeBackground.CreateIReignsChangeBackground(builder, backgroundOffset, _o.ChangeMode);
		}

		// Token: 0x0401180D RID: 71693
		private Table __p;
	}
}
