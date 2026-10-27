using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001099 RID: 4249
	public struct SettleReward : IFlatbufferObject
	{
		// Token: 0x17003535 RID: 13621
		// (get) Token: 0x0600D05D RID: 53341 RVA: 0x0030B995 File Offset: 0x00309B95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D05E RID: 53342 RVA: 0x0030B9A2 File Offset: 0x00309BA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D05F RID: 53343 RVA: 0x0030B9AC File Offset: 0x00309BAC
		public static SettleReward GetRootAsSettleReward(ByteBuffer _bb)
		{
			return SettleReward.GetRootAsSettleReward(_bb, default(SettleReward));
		}

		// Token: 0x0600D060 RID: 53344 RVA: 0x0030B9C8 File Offset: 0x00309BC8
		public static SettleReward GetRootAsSettleReward(ByteBuffer _bb, SettleReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D061 RID: 53345 RVA: 0x0030B9E5 File Offset: 0x00309BE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D062 RID: 53346 RVA: 0x0030B9F4 File Offset: 0x00309BF4
		public SettleReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003536 RID: 13622
		// (get) Token: 0x0600D063 RID: 53347 RVA: 0x0030BA04 File Offset: 0x00309C04
		public int ActivityId
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

		// Token: 0x17003537 RID: 13623
		// (get) Token: 0x0600D064 RID: 53348 RVA: 0x0030BA40 File Offset: 0x00309C40
		public int PhotoReward
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

		// Token: 0x17003538 RID: 13624
		// (get) Token: 0x0600D065 RID: 53349 RVA: 0x0030BA7C File Offset: 0x00309C7C
		public int PhotoRewardFemale
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

		// Token: 0x17003539 RID: 13625
		// (get) Token: 0x0600D066 RID: 53350 RVA: 0x0030BAB8 File Offset: 0x00309CB8
		public int SkinReward
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700353A RID: 13626
		// (get) Token: 0x0600D067 RID: 53351 RVA: 0x0030BAF8 File Offset: 0x00309CF8
		public string MalePhotoPath
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

		// Token: 0x0600D068 RID: 53352 RVA: 0x0030BB30 File Offset: 0x00309D30
		public Span<byte> GetMalePhotoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D069 RID: 53353 RVA: 0x0030BB40 File Offset: 0x00309D40
		public byte[] GetMalePhotoPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700353B RID: 13627
		// (get) Token: 0x0600D06A RID: 53354 RVA: 0x0030BB58 File Offset: 0x00309D58
		public string FemalePhotoPath
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

		// Token: 0x0600D06B RID: 53355 RVA: 0x0030BB90 File Offset: 0x00309D90
		public Span<byte> GetFemalePhotoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D06C RID: 53356 RVA: 0x0030BBA0 File Offset: 0x00309DA0
		public byte[] GetFemalePhotoPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040051A6 RID: 20902
		private Table __p;
	}
}
