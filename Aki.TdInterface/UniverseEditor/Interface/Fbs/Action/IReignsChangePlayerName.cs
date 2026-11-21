using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A6 RID: 30118
	public struct IReignsChangePlayerName : IFlatbufferObject
	{
		// Token: 0x1700DD7C RID: 56700
		// (get) Token: 0x06034D51 RID: 216401 RVA: 0x0071A4C5 File Offset: 0x007186C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034D52 RID: 216402 RVA: 0x0071A4D2 File Offset: 0x007186D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034D53 RID: 216403 RVA: 0x0071A4DC File Offset: 0x007186DC
		public static IReignsChangePlayerName GetRootAsIReignsChangePlayerName(ByteBuffer _bb)
		{
			return IReignsChangePlayerName.GetRootAsIReignsChangePlayerName(_bb, default(IReignsChangePlayerName));
		}

		// Token: 0x06034D54 RID: 216404 RVA: 0x0071A4F8 File Offset: 0x007186F8
		public static IReignsChangePlayerName GetRootAsIReignsChangePlayerName(ByteBuffer _bb, IReignsChangePlayerName obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034D55 RID: 216405 RVA: 0x0071A515 File Offset: 0x00718715
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034D56 RID: 216406 RVA: 0x0071A524 File Offset: 0x00718724
		public IReignsChangePlayerName __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD7D RID: 56701
		// (get) Token: 0x06034D57 RID: 216407 RVA: 0x0071A534 File Offset: 0x00718734
		public string PlayerNameId
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

		// Token: 0x06034D58 RID: 216408 RVA: 0x0071A56B File Offset: 0x0071876B
		public Span<byte> GetPlayerNameIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06034D59 RID: 216409 RVA: 0x0071A57A File Offset: 0x0071877A
		public byte[] GetPlayerNameIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06034D5A RID: 216410 RVA: 0x0071A588 File Offset: 0x00718788
		public static Offset<IReignsChangePlayerName> CreateIReignsChangePlayerName(FlatBufferBuilder builder, StringOffset PlayerNameIdOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IReignsChangePlayerName.AddPlayerNameId(builder, PlayerNameIdOffset);
			return IReignsChangePlayerName.EndIReignsChangePlayerName(builder);
		}

		// Token: 0x06034D5B RID: 216411 RVA: 0x0071A59E File Offset: 0x0071879E
		public static void StartIReignsChangePlayerName(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034D5C RID: 216412 RVA: 0x0071A5A7 File Offset: 0x007187A7
		public static void AddPlayerNameId(FlatBufferBuilder builder, StringOffset playerNameIdOffset)
		{
			builder.AddOffset(0, playerNameIdOffset.Value, 0);
		}

		// Token: 0x06034D5D RID: 216413 RVA: 0x0071A5B7 File Offset: 0x007187B7
		public static Offset<IReignsChangePlayerName> EndIReignsChangePlayerName(FlatBufferBuilder builder)
		{
			return new Offset<IReignsChangePlayerName>(builder.EndTable());
		}

		// Token: 0x06034D5E RID: 216414 RVA: 0x0071A5C4 File Offset: 0x007187C4
		public IReignsChangePlayerNameT UnPack()
		{
			IReignsChangePlayerNameT reignsChangePlayerNameT = new IReignsChangePlayerNameT();
			this.UnPackTo(reignsChangePlayerNameT);
			return reignsChangePlayerNameT;
		}

		// Token: 0x06034D5F RID: 216415 RVA: 0x0071A5DF File Offset: 0x007187DF
		public void UnPackTo(IReignsChangePlayerNameT _o)
		{
			_o.PlayerNameId = this.PlayerNameId;
		}

		// Token: 0x06034D60 RID: 216416 RVA: 0x0071A5F0 File Offset: 0x007187F0
		public static Offset<IReignsChangePlayerName> Pack(FlatBufferBuilder builder, IReignsChangePlayerNameT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsChangePlayerName>);
			}
			StringOffset playerNameIdOffset = (_o.PlayerNameId == null) ? default(StringOffset) : builder.CreateString(_o.PlayerNameId);
			return IReignsChangePlayerName.CreateIReignsChangePlayerName(builder, playerNameIdOffset);
		}

		// Token: 0x04012790 RID: 75664
		private Table __p;
	}
}
