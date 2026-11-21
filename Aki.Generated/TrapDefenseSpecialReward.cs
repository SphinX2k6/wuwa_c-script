using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012A5 RID: 4773
	public struct TrapDefenseSpecialReward : IFlatbufferObject
	{
		// Token: 0x17003FE3 RID: 16355
		// (get) Token: 0x0600F1F8 RID: 61944 RVA: 0x003659DC File Offset: 0x00363BDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F1F9 RID: 61945 RVA: 0x003659E9 File Offset: 0x00363BE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F1FA RID: 61946 RVA: 0x003659F0 File Offset: 0x00363BF0
		public static TrapDefenseSpecialReward GetRootAsTrapDefenseSpecialReward(ByteBuffer _bb)
		{
			return TrapDefenseSpecialReward.GetRootAsTrapDefenseSpecialReward(_bb, default(TrapDefenseSpecialReward));
		}

		// Token: 0x0600F1FB RID: 61947 RVA: 0x00365A0C File Offset: 0x00363C0C
		public static TrapDefenseSpecialReward GetRootAsTrapDefenseSpecialReward(ByteBuffer _bb, TrapDefenseSpecialReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F1FC RID: 61948 RVA: 0x00365A29 File Offset: 0x00363C29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F1FD RID: 61949 RVA: 0x00365A38 File Offset: 0x00363C38
		public TrapDefenseSpecialReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003FE4 RID: 16356
		// (get) Token: 0x0600F1FE RID: 61950 RVA: 0x00365A48 File Offset: 0x00363C48
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

		// Token: 0x17003FE5 RID: 16357
		// (get) Token: 0x0600F1FF RID: 61951 RVA: 0x00365A84 File Offset: 0x00363C84
		public int ActivityId
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

		// Token: 0x17003FE6 RID: 16358
		// (get) Token: 0x0600F200 RID: 61952 RVA: 0x00365AC0 File Offset: 0x00363CC0
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003FE7 RID: 16359
		// (get) Token: 0x0600F201 RID: 61953 RVA: 0x00365AFC File Offset: 0x00363CFC
		public int Target
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003FE8 RID: 16360
		// (get) Token: 0x0600F202 RID: 61954 RVA: 0x00365B3C File Offset: 0x00363D3C
		public int NeedItemId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003FE9 RID: 16361
		// (get) Token: 0x0600F203 RID: 61955 RVA: 0x00365B7C File Offset: 0x00363D7C
		public string Desc
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

		// Token: 0x0600F204 RID: 61956 RVA: 0x00365BB4 File Offset: 0x00363DB4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600F205 RID: 61957 RVA: 0x00365BC4 File Offset: 0x00363DC4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040058F8 RID: 22776
		private Table __p;
	}
}
