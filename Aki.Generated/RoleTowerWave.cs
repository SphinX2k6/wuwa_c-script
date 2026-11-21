using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200115C RID: 4444
	public struct RoleTowerWave : IFlatbufferObject
	{
		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x0600D332 RID: 54066 RVA: 0x00320455 File Offset: 0x0031E655
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D333 RID: 54067 RVA: 0x00320462 File Offset: 0x0031E662
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D334 RID: 54068 RVA: 0x0032046C File Offset: 0x0031E66C
		public static RoleTowerWave GetRootAsRoleTowerWave(ByteBuffer _bb)
		{
			return RoleTowerWave.GetRootAsRoleTowerWave(_bb, default(RoleTowerWave));
		}

		// Token: 0x0600D335 RID: 54069 RVA: 0x00320488 File Offset: 0x0031E688
		public static RoleTowerWave GetRootAsRoleTowerWave(ByteBuffer _bb, RoleTowerWave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D336 RID: 54070 RVA: 0x003204A5 File Offset: 0x0031E6A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D337 RID: 54071 RVA: 0x003204B4 File Offset: 0x0031E6B4
		public RoleTowerWave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x0600D338 RID: 54072 RVA: 0x003204C4 File Offset: 0x0031E6C4
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

		// Token: 0x17003483 RID: 13443
		// (get) Token: 0x0600D339 RID: 54073 RVA: 0x00320500 File Offset: 0x0031E700
		public int FloorId
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

		// Token: 0x17003484 RID: 13444
		// (get) Token: 0x0600D33A RID: 54074 RVA: 0x0032053C File Offset: 0x0031E73C
		public int WaveIndex
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

		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x0600D33B RID: 54075 RVA: 0x00320578 File Offset: 0x0031E778
		public string WaveName
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

		// Token: 0x0600D33C RID: 54076 RVA: 0x003205B0 File Offset: 0x0031E7B0
		public Span<byte> GetWaveNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D33D RID: 54077 RVA: 0x003205C0 File Offset: 0x0031E7C0
		public byte[] GetWaveNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x0600D33E RID: 54078 RVA: 0x003205D8 File Offset: 0x0031E7D8
		public string WaveShortName
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

		// Token: 0x0600D33F RID: 54079 RVA: 0x00320610 File Offset: 0x0031E810
		public Span<byte> GetWaveShortNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D340 RID: 54080 RVA: 0x00320620 File Offset: 0x0031E820
		public byte[] GetWaveShortNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005764 RID: 22372
		private Table __p;
	}
}
