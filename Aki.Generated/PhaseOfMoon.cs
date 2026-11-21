using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE3 RID: 4067
	public struct PhaseOfMoon : IFlatbufferObject
	{
		// Token: 0x170027DC RID: 10204
		// (get) Token: 0x0600B0BF RID: 45247 RVA: 0x002D4B60 File Offset: 0x002D2D60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B0C0 RID: 45248 RVA: 0x002D4B6D File Offset: 0x002D2D6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B0C1 RID: 45249 RVA: 0x002D4B74 File Offset: 0x002D2D74
		public static PhaseOfMoon GetRootAsPhaseOfMoon(ByteBuffer _bb)
		{
			return PhaseOfMoon.GetRootAsPhaseOfMoon(_bb, default(PhaseOfMoon));
		}

		// Token: 0x0600B0C2 RID: 45250 RVA: 0x002D4B90 File Offset: 0x002D2D90
		public static PhaseOfMoon GetRootAsPhaseOfMoon(ByteBuffer _bb, PhaseOfMoon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B0C3 RID: 45251 RVA: 0x002D4BAD File Offset: 0x002D2DAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B0C4 RID: 45252 RVA: 0x002D4BBC File Offset: 0x002D2DBC
		public PhaseOfMoon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027DD RID: 10205
		// (get) Token: 0x0600B0C5 RID: 45253 RVA: 0x002D4BCC File Offset: 0x002D2DCC
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

		// Token: 0x170027DE RID: 10206
		// (get) Token: 0x0600B0C6 RID: 45254 RVA: 0x002D4C08 File Offset: 0x002D2E08
		public int Reward
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170027DF RID: 10207
		// (get) Token: 0x0600B0C7 RID: 45255 RVA: 0x002D4C44 File Offset: 0x002D2E44
		public string BuffDes
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

		// Token: 0x0600B0C8 RID: 45256 RVA: 0x002D4C7B File Offset: 0x002D2E7B
		public Span<byte> GetBuffDesBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B0C9 RID: 45257 RVA: 0x002D4C8A File Offset: 0x002D2E8A
		public byte[] GetBuffDesArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170027E0 RID: 10208
		// (get) Token: 0x0600B0CA RID: 45258 RVA: 0x002D4CA4 File Offset: 0x002D2EA4
		public string BuffName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B0CB RID: 45259 RVA: 0x002D4CDC File Offset: 0x002D2EDC
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B0CC RID: 45260 RVA: 0x002D4CEC File Offset: 0x002D2EEC
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170027E1 RID: 10209
		// (get) Token: 0x0600B0CD RID: 45261 RVA: 0x002D4D04 File Offset: 0x002D2F04
		public string BuffTexture
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B0CE RID: 45262 RVA: 0x002D4D3C File Offset: 0x002D2F3C
		public Span<byte> GetBuffTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B0CF RID: 45263 RVA: 0x002D4D4C File Offset: 0x002D2F4C
		public byte[] GetBuffTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170027E2 RID: 10210
		// (get) Token: 0x0600B0D0 RID: 45264 RVA: 0x002D4D64 File Offset: 0x002D2F64
		public string Texture
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B0D1 RID: 45265 RVA: 0x002D4D9C File Offset: 0x002D2F9C
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B0D2 RID: 45266 RVA: 0x002D4DAC File Offset: 0x002D2FAC
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170027E3 RID: 10211
		// (get) Token: 0x0600B0D3 RID: 45267 RVA: 0x002D4DC4 File Offset: 0x002D2FC4
		public string RewardTexture
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B0D4 RID: 45268 RVA: 0x002D4DFC File Offset: 0x002D2FFC
		public Span<byte> GetRewardTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B0D5 RID: 45269 RVA: 0x002D4E0C File Offset: 0x002D300C
		public byte[] GetRewardTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170027E4 RID: 10212
		// (get) Token: 0x0600B0D6 RID: 45270 RVA: 0x002D4E24 File Offset: 0x002D3024
		public string MoonName
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B0D7 RID: 45271 RVA: 0x002D4E5C File Offset: 0x002D305C
		public Span<byte> GetMoonNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B0D8 RID: 45272 RVA: 0x002D4E6C File Offset: 0x002D306C
		public byte[] GetMoonNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170027E5 RID: 10213
		// (get) Token: 0x0600B0D9 RID: 45273 RVA: 0x002D4E84 File Offset: 0x002D3084
		public string MoonDes
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B0DA RID: 45274 RVA: 0x002D4EBC File Offset: 0x002D30BC
		public Span<byte> GetMoonDesBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B0DB RID: 45275 RVA: 0x002D4ECC File Offset: 0x002D30CC
		public byte[] GetMoonDesArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B0DC RID: 45276 RVA: 0x002D4EE4 File Offset: 0x002D30E4
		public string Talk(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027E6 RID: 10214
		// (get) Token: 0x0600B0DD RID: 45277 RVA: 0x002D4F20 File Offset: 0x002D3120
		public int TalkLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B0DE RID: 45278 RVA: 0x002D4F4C File Offset: 0x002D314C
		[NullableContext(1)]
		public string[] Talk()
		{
			return this.TalkIter().ToArray<string>();
		}

		// Token: 0x0600B0DF RID: 45279 RVA: 0x002D4F59 File Offset: 0x002D3159
		[NullableContext(1)]
		public IEnumerable<string> TalkIter()
		{
			PhaseOfMoon.<TalkIter>d__44 <TalkIter>d__ = new PhaseOfMoon.<TalkIter>d__44(-2);
			<TalkIter>d__.<>3__<>4__this = this;
			return <TalkIter>d__;
		}

		// Token: 0x040055AB RID: 21931
		private Table __p;
	}
}
