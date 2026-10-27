using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FFC RID: 4092
	public struct RogueResEffectTag : IFlatbufferObject
	{
		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x0600C1C9 RID: 49609 RVA: 0x002EB204 File Offset: 0x002E9404
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C1CA RID: 49610 RVA: 0x002EB211 File Offset: 0x002E9411
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C1CB RID: 49611 RVA: 0x002EB218 File Offset: 0x002E9418
		public static RogueResEffectTag GetRootAsRogueResEffectTag(ByteBuffer _bb)
		{
			return RogueResEffectTag.GetRootAsRogueResEffectTag(_bb, default(RogueResEffectTag));
		}

		// Token: 0x0600C1CC RID: 49612 RVA: 0x002EB234 File Offset: 0x002E9434
		public static RogueResEffectTag GetRootAsRogueResEffectTag(ByteBuffer _bb, RogueResEffectTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C1CD RID: 49613 RVA: 0x002EB251 File Offset: 0x002E9451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C1CE RID: 49614 RVA: 0x002EB260 File Offset: 0x002E9460
		public RogueResEffectTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x0600C1CF RID: 49615 RVA: 0x002EB270 File Offset: 0x002E9470
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

		// Token: 0x17003017 RID: 12311
		// (get) Token: 0x0600C1D0 RID: 49616 RVA: 0x002EB2AC File Offset: 0x002E94AC
		public string Tag
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

		// Token: 0x0600C1D1 RID: 49617 RVA: 0x002EB2E3 File Offset: 0x002E94E3
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C1D2 RID: 49618 RVA: 0x002EB2F2 File Offset: 0x002E94F2
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003018 RID: 12312
		// (get) Token: 0x0600C1D3 RID: 49619 RVA: 0x002EB30C File Offset: 0x002E950C
		public string Text
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

		// Token: 0x0600C1D4 RID: 49620 RVA: 0x002EB343 File Offset: 0x002E9543
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C1D5 RID: 49621 RVA: 0x002EB352 File Offset: 0x002E9552
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003019 RID: 12313
		// (get) Token: 0x0600C1D6 RID: 49622 RVA: 0x002EB36C File Offset: 0x002E956C
		public bool IsRatio
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700301A RID: 12314
		// (get) Token: 0x0600C1D7 RID: 49623 RVA: 0x002EB3AC File Offset: 0x002E95AC
		public string Icon
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

		// Token: 0x0600C1D8 RID: 49624 RVA: 0x002EB3E4 File Offset: 0x002E95E4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C1D9 RID: 49625 RVA: 0x002EB3F4 File Offset: 0x002E95F4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040050E4 RID: 20708
		private Table __p;
	}
}
