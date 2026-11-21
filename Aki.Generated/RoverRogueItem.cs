using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001179 RID: 4473
	public struct RoverRogueItem : IFlatbufferObject
	{
		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x0600D603 RID: 54787 RVA: 0x00326496 File Offset: 0x00324696
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D604 RID: 54788 RVA: 0x003264A3 File Offset: 0x003246A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D605 RID: 54789 RVA: 0x003264AC File Offset: 0x003246AC
		public static RoverRogueItem GetRootAsRoverRogueItem(ByteBuffer _bb)
		{
			return RoverRogueItem.GetRootAsRoverRogueItem(_bb, default(RoverRogueItem));
		}

		// Token: 0x0600D606 RID: 54790 RVA: 0x003264C8 File Offset: 0x003246C8
		public static RoverRogueItem GetRootAsRoverRogueItem(ByteBuffer _bb, RoverRogueItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D607 RID: 54791 RVA: 0x003264E5 File Offset: 0x003246E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D608 RID: 54792 RVA: 0x003264F4 File Offset: 0x003246F4
		public RoverRogueItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003576 RID: 13686
		// (get) Token: 0x0600D609 RID: 54793 RVA: 0x00326504 File Offset: 0x00324704
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

		// Token: 0x17003577 RID: 13687
		// (get) Token: 0x0600D60A RID: 54794 RVA: 0x00326540 File Offset: 0x00324740
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

		// Token: 0x17003578 RID: 13688
		// (get) Token: 0x0600D60B RID: 54795 RVA: 0x0032657C File Offset: 0x0032477C
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

		// Token: 0x17003579 RID: 13689
		// (get) Token: 0x0600D60C RID: 54796 RVA: 0x003265B8 File Offset: 0x003247B8
		public bool Repeated
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700357A RID: 13690
		// (get) Token: 0x0600D60D RID: 54797 RVA: 0x003265F8 File Offset: 0x003247F8
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

		// Token: 0x0600D60E RID: 54798 RVA: 0x00326630 File Offset: 0x00324830
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D60F RID: 54799 RVA: 0x00326640 File Offset: 0x00324840
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x0600D610 RID: 54800 RVA: 0x00326658 File Offset: 0x00324858
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

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x0600D611 RID: 54801 RVA: 0x00326698 File Offset: 0x00324898
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

		// Token: 0x0600D612 RID: 54802 RVA: 0x003266D0 File Offset: 0x003248D0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D613 RID: 54803 RVA: 0x003266E0 File Offset: 0x003248E0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x0600D614 RID: 54804 RVA: 0x003266F8 File Offset: 0x003248F8
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

		// Token: 0x0600D615 RID: 54805 RVA: 0x00326730 File Offset: 0x00324930
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D616 RID: 54806 RVA: 0x00326740 File Offset: 0x00324940
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D617 RID: 54807 RVA: 0x00326758 File Offset: 0x00324958
		public string DescParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x0600D618 RID: 54808 RVA: 0x00326794 File Offset: 0x00324994
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

		// Token: 0x1700357F RID: 13695
		// (get) Token: 0x0600D619 RID: 54809 RVA: 0x003267C0 File Offset: 0x003249C0
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

		// Token: 0x0600D61A RID: 54810 RVA: 0x003267F8 File Offset: 0x003249F8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D61B RID: 54811 RVA: 0x00326808 File Offset: 0x00324A08
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x0600D61C RID: 54812 RVA: 0x00326820 File Offset: 0x00324A20
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

		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x0600D61D RID: 54813 RVA: 0x00326860 File Offset: 0x00324A60
		public bool ShowObtain
		{
			get
			{
				int num = this.__p.__offset(26);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600D61E RID: 54814 RVA: 0x003268A0 File Offset: 0x00324AA0
		[NullableContext(1)]
		public string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x0600D61F RID: 54815 RVA: 0x003268AD File Offset: 0x00324AAD
		[NullableContext(1)]
		public IEnumerable<string> DescParamsIter()
		{
			RoverRogueItem.<DescParamsIter>d__42 <DescParamsIter>d__ = new RoverRogueItem.<DescParamsIter>d__42(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x04005787 RID: 22407
		private Table __p;
	}
}
