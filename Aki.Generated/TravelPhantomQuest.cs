using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012A8 RID: 4776
	public struct TravelPhantomQuest : IFlatbufferObject
	{
		// Token: 0x1700400C RID: 16396
		// (get) Token: 0x0600F25E RID: 62046 RVA: 0x00366827 File Offset: 0x00364A27
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F25F RID: 62047 RVA: 0x00366834 File Offset: 0x00364A34
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F260 RID: 62048 RVA: 0x0036683C File Offset: 0x00364A3C
		public static TravelPhantomQuest GetRootAsTravelPhantomQuest(ByteBuffer _bb)
		{
			return TravelPhantomQuest.GetRootAsTravelPhantomQuest(_bb, default(TravelPhantomQuest));
		}

		// Token: 0x0600F261 RID: 62049 RVA: 0x00366858 File Offset: 0x00364A58
		public static TravelPhantomQuest GetRootAsTravelPhantomQuest(ByteBuffer _bb, TravelPhantomQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F262 RID: 62050 RVA: 0x00366875 File Offset: 0x00364A75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F263 RID: 62051 RVA: 0x00366884 File Offset: 0x00364A84
		public TravelPhantomQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700400D RID: 16397
		// (get) Token: 0x0600F264 RID: 62052 RVA: 0x00366894 File Offset: 0x00364A94
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

		// Token: 0x1700400E RID: 16398
		// (get) Token: 0x0600F265 RID: 62053 RVA: 0x003668D0 File Offset: 0x00364AD0
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

		// Token: 0x1700400F RID: 16399
		// (get) Token: 0x0600F266 RID: 62054 RVA: 0x0036690C File Offset: 0x00364B0C
		public int MapMarkId
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

		// Token: 0x17004010 RID: 16400
		// (get) Token: 0x0600F267 RID: 62055 RVA: 0x00366948 File Offset: 0x00364B48
		public int Sort
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

		// Token: 0x17004011 RID: 16401
		// (get) Token: 0x0600F268 RID: 62056 RVA: 0x00366988 File Offset: 0x00364B88
		public int AreaId
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

		// Token: 0x17004012 RID: 16402
		// (get) Token: 0x0600F269 RID: 62057 RVA: 0x003669C8 File Offset: 0x00364BC8
		public int QuestId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004013 RID: 16403
		// (get) Token: 0x0600F26A RID: 62058 RVA: 0x00366A08 File Offset: 0x00364C08
		public string Name
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

		// Token: 0x0600F26B RID: 62059 RVA: 0x00366A40 File Offset: 0x00364C40
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600F26C RID: 62060 RVA: 0x00366A50 File Offset: 0x00364C50
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17004014 RID: 16404
		// (get) Token: 0x0600F26D RID: 62061 RVA: 0x00366A68 File Offset: 0x00364C68
		public string LockName
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

		// Token: 0x0600F26E RID: 62062 RVA: 0x00366AA0 File Offset: 0x00364CA0
		public Span<byte> GetLockNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600F26F RID: 62063 RVA: 0x00366AB0 File Offset: 0x00364CB0
		public byte[] GetLockNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17004015 RID: 16405
		// (get) Token: 0x0600F270 RID: 62064 RVA: 0x00366AC8 File Offset: 0x00364CC8
		public int QuestReward
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004016 RID: 16406
		// (get) Token: 0x0600F271 RID: 62065 RVA: 0x00366B08 File Offset: 0x00364D08
		public string Texture
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F272 RID: 62066 RVA: 0x00366B40 File Offset: 0x00364D40
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600F273 RID: 62067 RVA: 0x00366B50 File Offset: 0x00364D50
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17004017 RID: 16407
		// (get) Token: 0x0600F274 RID: 62068 RVA: 0x00366B68 File Offset: 0x00364D68
		public string UnlockTips
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F275 RID: 62069 RVA: 0x00366BA0 File Offset: 0x00364DA0
		public Span<byte> GetUnlockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600F276 RID: 62070 RVA: 0x00366BB0 File Offset: 0x00364DB0
		public byte[] GetUnlockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17004018 RID: 16408
		// (get) Token: 0x0600F277 RID: 62071 RVA: 0x00366BC8 File Offset: 0x00364DC8
		public string MapDesc
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F278 RID: 62072 RVA: 0x00366C00 File Offset: 0x00364E00
		public Span<byte> GetMapDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600F279 RID: 62073 RVA: 0x00366C10 File Offset: 0x00364E10
		public byte[] GetMapDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x040058FB RID: 22779
		private Table __p;
	}
}
