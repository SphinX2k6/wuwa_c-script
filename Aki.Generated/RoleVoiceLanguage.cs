using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001162 RID: 4450
	public struct RoleVoiceLanguage : IFlatbufferObject
	{
		// Token: 0x170034A9 RID: 13481
		// (get) Token: 0x0600D3A4 RID: 54180 RVA: 0x0032133C File Offset: 0x0031F53C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D3A5 RID: 54181 RVA: 0x00321349 File Offset: 0x0031F549
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D3A6 RID: 54182 RVA: 0x00321350 File Offset: 0x0031F550
		public static RoleVoiceLanguage GetRootAsRoleVoiceLanguage(ByteBuffer _bb)
		{
			return RoleVoiceLanguage.GetRootAsRoleVoiceLanguage(_bb, default(RoleVoiceLanguage));
		}

		// Token: 0x0600D3A7 RID: 54183 RVA: 0x0032136C File Offset: 0x0031F56C
		public static RoleVoiceLanguage GetRootAsRoleVoiceLanguage(ByteBuffer _bb, RoleVoiceLanguage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D3A8 RID: 54184 RVA: 0x00321389 File Offset: 0x0031F589
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D3A9 RID: 54185 RVA: 0x00321398 File Offset: 0x0031F598
		public RoleVoiceLanguage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034AA RID: 13482
		// (get) Token: 0x0600D3AA RID: 54186 RVA: 0x003213A8 File Offset: 0x0031F5A8
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

		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x0600D3AB RID: 54187 RVA: 0x003213E4 File Offset: 0x0031F5E4
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

		// Token: 0x0600D3AC RID: 54188 RVA: 0x0032141B File Offset: 0x0031F61B
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D3AD RID: 54189 RVA: 0x0032142A File Offset: 0x0031F62A
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400576B RID: 22379
		private Table __p;
	}
}
