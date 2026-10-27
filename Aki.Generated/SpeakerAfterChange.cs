using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010DB RID: 4315
	public struct SpeakerAfterChange : IFlatbufferObject
	{
		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x0600D7A6 RID: 55206 RVA: 0x0031D789 File Offset: 0x0031B989
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D7A7 RID: 55207 RVA: 0x0031D796 File Offset: 0x0031B996
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D7A8 RID: 55208 RVA: 0x0031D7A0 File Offset: 0x0031B9A0
		public static SpeakerAfterChange GetRootAsSpeakerAfterChange(ByteBuffer _bb)
		{
			return SpeakerAfterChange.GetRootAsSpeakerAfterChange(_bb, default(SpeakerAfterChange));
		}

		// Token: 0x0600D7A9 RID: 55209 RVA: 0x0031D7BC File Offset: 0x0031B9BC
		public static SpeakerAfterChange GetRootAsSpeakerAfterChange(ByteBuffer _bb, SpeakerAfterChange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D7AA RID: 55210 RVA: 0x0031D7D9 File Offset: 0x0031B9D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D7AB RID: 55211 RVA: 0x0031D7E8 File Offset: 0x0031B9E8
		public SpeakerAfterChange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x0600D7AC RID: 55212 RVA: 0x0031D7F8 File Offset: 0x0031B9F8
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

		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x0600D7AD RID: 55213 RVA: 0x0031D834 File Offset: 0x0031BA34
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

		// Token: 0x0600D7AE RID: 55214 RVA: 0x0031D86B File Offset: 0x0031BA6B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D7AF RID: 55215 RVA: 0x0031D87A File Offset: 0x0031BA7A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170037BB RID: 14267
		// (get) Token: 0x0600D7B0 RID: 55216 RVA: 0x0031D894 File Offset: 0x0031BA94
		public string Icon
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

		// Token: 0x0600D7B1 RID: 55217 RVA: 0x0031D8CB File Offset: 0x0031BACB
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D7B2 RID: 55218 RVA: 0x0031D8DA File Offset: 0x0031BADA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400520E RID: 21006
		private Table __p;
	}
}
