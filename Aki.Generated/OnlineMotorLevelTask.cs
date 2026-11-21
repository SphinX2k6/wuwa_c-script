using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F89 RID: 3977
	public struct OnlineMotorLevelTask : IFlatbufferObject
	{
		// Token: 0x17002487 RID: 9351
		// (get) Token: 0x0600A7A5 RID: 42917 RVA: 0x002C04C8 File Offset: 0x002BE6C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A7A6 RID: 42918 RVA: 0x002C04D5 File Offset: 0x002BE6D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A7A7 RID: 42919 RVA: 0x002C04DC File Offset: 0x002BE6DC
		public static OnlineMotorLevelTask GetRootAsOnlineMotorLevelTask(ByteBuffer _bb)
		{
			return OnlineMotorLevelTask.GetRootAsOnlineMotorLevelTask(_bb, default(OnlineMotorLevelTask));
		}

		// Token: 0x0600A7A8 RID: 42920 RVA: 0x002C04F8 File Offset: 0x002BE6F8
		public static OnlineMotorLevelTask GetRootAsOnlineMotorLevelTask(ByteBuffer _bb, OnlineMotorLevelTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A7A9 RID: 42921 RVA: 0x002C0515 File Offset: 0x002BE715
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A7AA RID: 42922 RVA: 0x002C0524 File Offset: 0x002BE724
		public OnlineMotorLevelTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002488 RID: 9352
		// (get) Token: 0x0600A7AB RID: 42923 RVA: 0x002C0534 File Offset: 0x002BE734
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

		// Token: 0x17002489 RID: 9353
		// (get) Token: 0x0600A7AC RID: 42924 RVA: 0x002C0570 File Offset: 0x002BE770
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

		// Token: 0x1700248A RID: 9354
		// (get) Token: 0x0600A7AD RID: 42925 RVA: 0x002C05AC File Offset: 0x002BE7AC
		public int DropId
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

		// Token: 0x1700248B RID: 9355
		// (get) Token: 0x0600A7AE RID: 42926 RVA: 0x002C05E8 File Offset: 0x002BE7E8
		public int LevelId
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

		// Token: 0x1700248C RID: 9356
		// (get) Token: 0x0600A7AF RID: 42927 RVA: 0x002C0628 File Offset: 0x002BE828
		public int PlayCount
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

		// Token: 0x1700248D RID: 9357
		// (get) Token: 0x0600A7B0 RID: 42928 RVA: 0x002C0668 File Offset: 0x002BE868
		public string PlayCountDes
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

		// Token: 0x0600A7B1 RID: 42929 RVA: 0x002C06A0 File Offset: 0x002BE8A0
		public Span<byte> GetPlayCountDesBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A7B2 RID: 42930 RVA: 0x002C06B0 File Offset: 0x002BE8B0
		public byte[] GetPlayCountDesArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700248E RID: 9358
		// (get) Token: 0x0600A7B3 RID: 42931 RVA: 0x002C06C8 File Offset: 0x002BE8C8
		public int Champion
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700248F RID: 9359
		// (get) Token: 0x0600A7B4 RID: 42932 RVA: 0x002C0708 File Offset: 0x002BE908
		public string ChampionDes
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

		// Token: 0x0600A7B5 RID: 42933 RVA: 0x002C0740 File Offset: 0x002BE940
		public Span<byte> GetChampionDesBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A7B6 RID: 42934 RVA: 0x002C0750 File Offset: 0x002BE950
		public byte[] GetChampionDesArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002490 RID: 9360
		// (get) Token: 0x0600A7B7 RID: 42935 RVA: 0x002C0768 File Offset: 0x002BE968
		public int SpeedLap
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

		// Token: 0x17002491 RID: 9361
		// (get) Token: 0x0600A7B8 RID: 42936 RVA: 0x002C07A8 File Offset: 0x002BE9A8
		public string SpeedLapDes
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

		// Token: 0x0600A7B9 RID: 42937 RVA: 0x002C07E0 File Offset: 0x002BE9E0
		public Span<byte> GetSpeedLapDesBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A7BA RID: 42938 RVA: 0x002C07F0 File Offset: 0x002BE9F0
		public byte[] GetSpeedLapDesArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002492 RID: 9362
		// (get) Token: 0x0600A7BB RID: 42939 RVA: 0x002C0808 File Offset: 0x002BEA08
		public int FirstRunner
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002493 RID: 9363
		// (get) Token: 0x0600A7BC RID: 42940 RVA: 0x002C0848 File Offset: 0x002BEA48
		public string FirstRunnerDes
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

		// Token: 0x0600A7BD RID: 42941 RVA: 0x002C0880 File Offset: 0x002BEA80
		public Span<byte> GetFirstRunnerDesBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A7BE RID: 42942 RVA: 0x002C0890 File Offset: 0x002BEA90
		public byte[] GetFirstRunnerDesArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0400553D RID: 21821
		private Table __p;
	}
}
