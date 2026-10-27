using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200107E RID: 4222
	public struct RoverRogueItem : IFlatbufferObject
	{
		// Token: 0x17003468 RID: 13416
		// (get) Token: 0x0600CE30 RID: 52784 RVA: 0x00306E05 File Offset: 0x00305005
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CE31 RID: 52785 RVA: 0x00306E12 File Offset: 0x00305012
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CE32 RID: 52786 RVA: 0x00306E1C File Offset: 0x0030501C
		public static RoverRogueItem GetRootAsRoverRogueItem(ByteBuffer _bb)
		{
			return RoverRogueItem.GetRootAsRoverRogueItem(_bb, default(RoverRogueItem));
		}

		// Token: 0x0600CE33 RID: 52787 RVA: 0x00306E38 File Offset: 0x00305038
		public static RoverRogueItem GetRootAsRoverRogueItem(ByteBuffer _bb, RoverRogueItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CE34 RID: 52788 RVA: 0x00306E55 File Offset: 0x00305055
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CE35 RID: 52789 RVA: 0x00306E64 File Offset: 0x00305064
		public RoverRogueItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003469 RID: 13417
		// (get) Token: 0x0600CE36 RID: 52790 RVA: 0x00306E74 File Offset: 0x00305074
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

		// Token: 0x1700346A RID: 13418
		// (get) Token: 0x0600CE37 RID: 52791 RVA: 0x00306EB0 File Offset: 0x003050B0
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

		// Token: 0x1700346B RID: 13419
		// (get) Token: 0x0600CE38 RID: 52792 RVA: 0x00306EEC File Offset: 0x003050EC
		public int Classify
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700346C RID: 13420
		// (get) Token: 0x0600CE39 RID: 52793 RVA: 0x00306F28 File Offset: 0x00305128
		public bool Repeated
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700346D RID: 13421
		// (get) Token: 0x0600CE3A RID: 52794 RVA: 0x00306F68 File Offset: 0x00305168
		public string Type
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

		// Token: 0x0600CE3B RID: 52795 RVA: 0x00306FA0 File Offset: 0x003051A0
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CE3C RID: 52796 RVA: 0x00306FB0 File Offset: 0x003051B0
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700346E RID: 13422
		// (get) Token: 0x0600CE3D RID: 52797 RVA: 0x00306FC8 File Offset: 0x003051C8
		public int Quality
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

		// Token: 0x1700346F RID: 13423
		// (get) Token: 0x0600CE3E RID: 52798 RVA: 0x00307008 File Offset: 0x00305208
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

		// Token: 0x0600CE3F RID: 52799 RVA: 0x00307040 File Offset: 0x00305240
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CE40 RID: 52800 RVA: 0x00307050 File Offset: 0x00305250
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003470 RID: 13424
		// (get) Token: 0x0600CE41 RID: 52801 RVA: 0x00307068 File Offset: 0x00305268
		public string Desc
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

		// Token: 0x0600CE42 RID: 52802 RVA: 0x003070A0 File Offset: 0x003052A0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CE43 RID: 52803 RVA: 0x003070B0 File Offset: 0x003052B0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CE44 RID: 52804 RVA: 0x003070C8 File Offset: 0x003052C8
		public string DescParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003471 RID: 13425
		// (get) Token: 0x0600CE45 RID: 52805 RVA: 0x00307104 File Offset: 0x00305304
		public int DescParamsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003472 RID: 13426
		// (get) Token: 0x0600CE46 RID: 52806 RVA: 0x00307130 File Offset: 0x00305330
		public string Icon
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

		// Token: 0x0600CE47 RID: 52807 RVA: 0x00307168 File Offset: 0x00305368
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600CE48 RID: 52808 RVA: 0x00307178 File Offset: 0x00305378
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003473 RID: 13427
		// (get) Token: 0x0600CE49 RID: 52809 RVA: 0x00307190 File Offset: 0x00305390
		public int RoomPassedRequired
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

		// Token: 0x17003474 RID: 13428
		// (get) Token: 0x0600CE4A RID: 52810 RVA: 0x003071D0 File Offset: 0x003053D0
		public bool ShowObtain
		{
			get
			{
				int num = this.__p.__offset(26);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600CE4B RID: 52811 RVA: 0x00307210 File Offset: 0x00305410
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamsIter()或GetDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x0600CE4C RID: 52812 RVA: 0x0030721D File Offset: 0x0030541D
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamsIter()
		{
			RoverRogueItem.<DescParamsIter>d__42 <DescParamsIter>d__ = new RoverRogueItem.<DescParamsIter>d__42(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x04005188 RID: 20872
		private Table __p;
	}
}
