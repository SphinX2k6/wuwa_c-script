using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010CA RID: 4298
	public struct RogueHotEntryGroup : IFlatbufferObject
	{
		// Token: 0x17002FC0 RID: 12224
		// (get) Token: 0x0600C591 RID: 50577 RVA: 0x00301AE3 File Offset: 0x002FFCE3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C592 RID: 50578 RVA: 0x00301AF0 File Offset: 0x002FFCF0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C593 RID: 50579 RVA: 0x00301AF8 File Offset: 0x002FFCF8
		public static RogueHotEntryGroup GetRootAsRogueHotEntryGroup(ByteBuffer _bb)
		{
			return RogueHotEntryGroup.GetRootAsRogueHotEntryGroup(_bb, default(RogueHotEntryGroup));
		}

		// Token: 0x0600C594 RID: 50580 RVA: 0x00301B14 File Offset: 0x002FFD14
		public static RogueHotEntryGroup GetRootAsRogueHotEntryGroup(ByteBuffer _bb, RogueHotEntryGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C595 RID: 50581 RVA: 0x00301B31 File Offset: 0x002FFD31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C596 RID: 50582 RVA: 0x00301B40 File Offset: 0x002FFD40
		public RogueHotEntryGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FC1 RID: 12225
		// (get) Token: 0x0600C597 RID: 50583 RVA: 0x00301B50 File Offset: 0x002FFD50
		public int GroupId
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

		// Token: 0x0600C598 RID: 50584 RVA: 0x00301B8C File Offset: 0x002FFD8C
		public int Group1(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FC2 RID: 12226
		// (get) Token: 0x0600C599 RID: 50585 RVA: 0x00301BCC File Offset: 0x002FFDCC
		public int Group1Length
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C59A RID: 50586 RVA: 0x00301BF7 File Offset: 0x002FFDF7
		public Span<int> GetGroup1Bytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600C59B RID: 50587 RVA: 0x00301C06 File Offset: 0x002FFE06
		public int[] GetGroup1Array()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600C59C RID: 50588 RVA: 0x00301C20 File Offset: 0x002FFE20
		public int Group2(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FC3 RID: 12227
		// (get) Token: 0x0600C59D RID: 50589 RVA: 0x00301C60 File Offset: 0x002FFE60
		public int Group2Length
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C59E RID: 50590 RVA: 0x00301C8B File Offset: 0x002FFE8B
		public Span<int> GetGroup2Bytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C59F RID: 50591 RVA: 0x00301C9A File Offset: 0x002FFE9A
		public int[] GetGroup2Array()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600C5A0 RID: 50592 RVA: 0x00301CB4 File Offset: 0x002FFEB4
		public int Group3(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FC4 RID: 12228
		// (get) Token: 0x0600C5A1 RID: 50593 RVA: 0x00301CF4 File Offset: 0x002FFEF4
		public int Group3Length
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C5A2 RID: 50594 RVA: 0x00301D20 File Offset: 0x002FFF20
		public Span<int> GetGroup3Bytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C5A3 RID: 50595 RVA: 0x00301D30 File Offset: 0x002FFF30
		public int[] GetGroup3Array()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002FC5 RID: 12229
		// (get) Token: 0x0600C5A4 RID: 50596 RVA: 0x00301D48 File Offset: 0x002FFF48
		public int Rate
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

		// Token: 0x17002FC6 RID: 12230
		// (get) Token: 0x0600C5A5 RID: 50597 RVA: 0x00301D88 File Offset: 0x002FFF88
		public string RateColor
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

		// Token: 0x0600C5A6 RID: 50598 RVA: 0x00301DC0 File Offset: 0x002FFFC0
		public Span<byte> GetRateColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C5A7 RID: 50599 RVA: 0x00301DD0 File Offset: 0x002FFFD0
		public byte[] GetRateColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FC7 RID: 12231
		// (get) Token: 0x0600C5A8 RID: 50600 RVA: 0x00301DE8 File Offset: 0x002FFFE8
		public string SettleIcon
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

		// Token: 0x0600C5A9 RID: 50601 RVA: 0x00301E20 File Offset: 0x00300020
		public Span<byte> GetSettleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C5AA RID: 50602 RVA: 0x00301E30 File Offset: 0x00300030
		public byte[] GetSettleIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FC8 RID: 12232
		// (get) Token: 0x0600C5AB RID: 50603 RVA: 0x00301E48 File Offset: 0x00300048
		public string SettleTextColor
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

		// Token: 0x0600C5AC RID: 50604 RVA: 0x00301E80 File Offset: 0x00300080
		public Span<byte> GetSettleTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C5AD RID: 50605 RVA: 0x00301E90 File Offset: 0x00300090
		public byte[] GetSettleTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FC9 RID: 12233
		// (get) Token: 0x0600C5AE RID: 50606 RVA: 0x00301EA8 File Offset: 0x003000A8
		public int SettleAudioState
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C5AF RID: 50607 RVA: 0x00301EE5 File Offset: 0x003000E5
		[NullableContext(1)]
		public int[] Group1()
		{
			return this.GetGroup1Array();
		}

		// Token: 0x0600C5B0 RID: 50608 RVA: 0x00301EED File Offset: 0x003000ED
		[NullableContext(1)]
		public IEnumerable<int> Group1Iter()
		{
			RogueHotEntryGroup.<Group1Iter>d__42 <Group1Iter>d__ = new RogueHotEntryGroup.<Group1Iter>d__42(-2);
			<Group1Iter>d__.<>3__<>4__this = this;
			return <Group1Iter>d__;
		}

		// Token: 0x0600C5B1 RID: 50609 RVA: 0x00301F02 File Offset: 0x00300102
		[NullableContext(1)]
		public int[] Group2()
		{
			return this.GetGroup2Array();
		}

		// Token: 0x0600C5B2 RID: 50610 RVA: 0x00301F0A File Offset: 0x0030010A
		[NullableContext(1)]
		public IEnumerable<int> Group2Iter()
		{
			RogueHotEntryGroup.<Group2Iter>d__44 <Group2Iter>d__ = new RogueHotEntryGroup.<Group2Iter>d__44(-2);
			<Group2Iter>d__.<>3__<>4__this = this;
			return <Group2Iter>d__;
		}

		// Token: 0x0600C5B3 RID: 50611 RVA: 0x00301F1F File Offset: 0x0030011F
		[NullableContext(1)]
		public int[] Group3()
		{
			return this.GetGroup3Array();
		}

		// Token: 0x0600C5B4 RID: 50612 RVA: 0x00301F27 File Offset: 0x00300127
		[NullableContext(1)]
		public IEnumerable<int> Group3Iter()
		{
			RogueHotEntryGroup.<Group3Iter>d__46 <Group3Iter>d__ = new RogueHotEntryGroup.<Group3Iter>d__46(-2);
			<Group3Iter>d__.<>3__<>4__this = this;
			return <Group3Iter>d__;
		}

		// Token: 0x040056A7 RID: 22183
		private Table __p;
	}
}
