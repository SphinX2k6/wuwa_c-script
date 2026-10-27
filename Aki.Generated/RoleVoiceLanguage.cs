using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001067 RID: 4199
	public struct RoleVoiceLanguage : IFlatbufferObject
	{
		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x0600CBD1 RID: 52177 RVA: 0x00301A84 File Offset: 0x002FFC84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CBD2 RID: 52178 RVA: 0x00301A91 File Offset: 0x002FFC91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CBD3 RID: 52179 RVA: 0x00301A98 File Offset: 0x002FFC98
		public static RoleVoiceLanguage GetRootAsRoleVoiceLanguage(ByteBuffer _bb)
		{
			return RoleVoiceLanguage.GetRootAsRoleVoiceLanguage(_bb, default(RoleVoiceLanguage));
		}

		// Token: 0x0600CBD4 RID: 52180 RVA: 0x00301AB4 File Offset: 0x002FFCB4
		public static RoleVoiceLanguage GetRootAsRoleVoiceLanguage(ByteBuffer _bb, RoleVoiceLanguage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CBD5 RID: 52181 RVA: 0x00301AD1 File Offset: 0x002FFCD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CBD6 RID: 52182 RVA: 0x00301AE0 File Offset: 0x002FFCE0
		public RoleVoiceLanguage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x0600CBD7 RID: 52183 RVA: 0x00301AF0 File Offset: 0x002FFCF0
		public int LanguageId
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

		// Token: 0x1700339E RID: 13214
		// (get) Token: 0x0600CBD8 RID: 52184 RVA: 0x00301B2C File Offset: 0x002FFD2C
		public string Text
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

		// Token: 0x0600CBD9 RID: 52185 RVA: 0x00301B63 File Offset: 0x002FFD63
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CBDA RID: 52186 RVA: 0x00301B72 File Offset: 0x002FFD72
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400516C RID: 20844
		private Table __p;
	}
}
