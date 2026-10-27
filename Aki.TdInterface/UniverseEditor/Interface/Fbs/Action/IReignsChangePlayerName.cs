using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E28 RID: 28200
	public struct IReignsChangePlayerName : IFlatbufferObject
	{
		// Token: 0x1700D22D RID: 53805
		// (get) Token: 0x06031D3B RID: 204091 RVA: 0x006BEB3D File Offset: 0x006BCD3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031D3C RID: 204092 RVA: 0x006BEB4A File Offset: 0x006BCD4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031D3D RID: 204093 RVA: 0x006BEB54 File Offset: 0x006BCD54
		public static IReignsChangePlayerName GetRootAsIReignsChangePlayerName(ByteBuffer _bb)
		{
			return IReignsChangePlayerName.GetRootAsIReignsChangePlayerName(_bb, default(IReignsChangePlayerName));
		}

		// Token: 0x06031D3E RID: 204094 RVA: 0x006BEB70 File Offset: 0x006BCD70
		public static IReignsChangePlayerName GetRootAsIReignsChangePlayerName(ByteBuffer _bb, IReignsChangePlayerName obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031D3F RID: 204095 RVA: 0x006BEB8D File Offset: 0x006BCD8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031D40 RID: 204096 RVA: 0x006BEB9C File Offset: 0x006BCD9C
		public IReignsChangePlayerName __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D22E RID: 53806
		// (get) Token: 0x06031D41 RID: 204097 RVA: 0x006BEBAC File Offset: 0x006BCDAC
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

		// Token: 0x06031D42 RID: 204098 RVA: 0x006BEBE3 File Offset: 0x006BCDE3
		public Span<byte> GetPlayerNameIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06031D43 RID: 204099 RVA: 0x006BEBF2 File Offset: 0x006BCDF2
		public byte[] GetPlayerNameIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06031D44 RID: 204100 RVA: 0x006BEC00 File Offset: 0x006BCE00
		public static Offset<IReignsChangePlayerName> CreateIReignsChangePlayerName(FlatBufferBuilder builder, StringOffset PlayerNameIdOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IReignsChangePlayerName.AddPlayerNameId(builder, PlayerNameIdOffset);
			return IReignsChangePlayerName.EndIReignsChangePlayerName(builder);
		}

		// Token: 0x06031D45 RID: 204101 RVA: 0x006BEC16 File Offset: 0x006BCE16
		public static void StartIReignsChangePlayerName(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031D46 RID: 204102 RVA: 0x006BEC1F File Offset: 0x006BCE1F
		public static void AddPlayerNameId(FlatBufferBuilder builder, StringOffset playerNameIdOffset)
		{
			builder.AddOffset(0, playerNameIdOffset.Value, 0);
		}

		// Token: 0x06031D47 RID: 204103 RVA: 0x006BEC2F File Offset: 0x006BCE2F
		public static Offset<IReignsChangePlayerName> EndIReignsChangePlayerName(FlatBufferBuilder builder)
		{
			return new Offset<IReignsChangePlayerName>(builder.EndTable());
		}

		// Token: 0x06031D48 RID: 204104 RVA: 0x006BEC3C File Offset: 0x006BCE3C
		public IReignsChangePlayerNameT UnPack()
		{
			IReignsChangePlayerNameT reignsChangePlayerNameT = new IReignsChangePlayerNameT();
			this.UnPackTo(reignsChangePlayerNameT);
			return reignsChangePlayerNameT;
		}

		// Token: 0x06031D49 RID: 204105 RVA: 0x006BEC57 File Offset: 0x006BCE57
		public void UnPackTo(IReignsChangePlayerNameT _o)
		{
			_o.PlayerNameId = this.PlayerNameId;
		}

		// Token: 0x06031D4A RID: 204106 RVA: 0x006BEC68 File Offset: 0x006BCE68
		public static Offset<IReignsChangePlayerName> Pack(FlatBufferBuilder builder, IReignsChangePlayerNameT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsChangePlayerName>);
			}
			StringOffset playerNameIdOffset = (_o.PlayerNameId == null) ? default(StringOffset) : builder.CreateString(_o.PlayerNameId);
			return IReignsChangePlayerName.CreateIReignsChangePlayerName(builder, playerNameIdOffset);
		}

		// Token: 0x04011810 RID: 71696
		private Table __p;
	}
}
