using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C22 RID: 3106
	public struct EffectSave : IFlatbufferObject
	{
		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x060067A2 RID: 26530 RVA: 0x002202D0 File Offset: 0x0021E4D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060067A3 RID: 26531 RVA: 0x002202DD File Offset: 0x0021E4DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060067A4 RID: 26532 RVA: 0x002202E4 File Offset: 0x0021E4E4
		public static EffectSave GetRootAsEffectSave(ByteBuffer _bb)
		{
			return EffectSave.GetRootAsEffectSave(_bb, default(EffectSave));
		}

		// Token: 0x060067A5 RID: 26533 RVA: 0x00220300 File Offset: 0x0021E500
		public static EffectSave GetRootAsEffectSave(ByteBuffer _bb, EffectSave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060067A6 RID: 26534 RVA: 0x0022031D File Offset: 0x0021E51D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060067A7 RID: 26535 RVA: 0x0022032C File Offset: 0x0021E52C
		public EffectSave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x060067A8 RID: 26536 RVA: 0x0022033C File Offset: 0x0021E53C
		public int EffectId
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

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x060067A9 RID: 26537 RVA: 0x00220378 File Offset: 0x0021E578
		public string EffectPath
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

		// Token: 0x060067AA RID: 26538 RVA: 0x002203AF File Offset: 0x0021E5AF
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060067AB RID: 26539 RVA: 0x002203BE File Offset: 0x0021E5BE
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C62 RID: 19554
		private Table __p;
	}
}
