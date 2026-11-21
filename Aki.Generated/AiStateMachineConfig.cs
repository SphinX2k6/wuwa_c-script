using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BCD RID: 3021
	public struct AiStateMachineConfig : IFlatbufferObject
	{
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06004C53 RID: 19539 RVA: 0x001F3CC8 File Offset: 0x001F1EC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004C54 RID: 19540 RVA: 0x001F3CD5 File Offset: 0x001F1ED5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004C55 RID: 19541 RVA: 0x001F3CDC File Offset: 0x001F1EDC
		public static AiStateMachineConfig GetRootAsAiStateMachineConfig(ByteBuffer _bb)
		{
			return AiStateMachineConfig.GetRootAsAiStateMachineConfig(_bb, default(AiStateMachineConfig));
		}

		// Token: 0x06004C56 RID: 19542 RVA: 0x001F3CF8 File Offset: 0x001F1EF8
		public static AiStateMachineConfig GetRootAsAiStateMachineConfig(ByteBuffer _bb, AiStateMachineConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x001F3D15 File Offset: 0x001F1F15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x001F3D24 File Offset: 0x001F1F24
		public AiStateMachineConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06004C59 RID: 19545 RVA: 0x001F3D34 File Offset: 0x001F1F34
		public string Id
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

		// Token: 0x06004C5A RID: 19546 RVA: 0x001F3D6B File Offset: 0x001F1F6B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x001F3D7A File Offset: 0x001F1F7A
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06004C5C RID: 19548 RVA: 0x001F3D94 File Offset: 0x001F1F94
		public string StateMachineJson
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

		// Token: 0x06004C5D RID: 19549 RVA: 0x001F3DCB File Offset: 0x001F1FCB
		public Span<byte> GetStateMachineJsonBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x001F3DDA File Offset: 0x001F1FDA
		public byte[] GetStateMachineJsonArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040050AE RID: 20654
		private Table __p;
	}
}
