using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200120F RID: 4623
	public struct SoundBoxMark : IFlatbufferObject
	{
		// Token: 0x17003AF9 RID: 15097
		// (get) Token: 0x0600E4BD RID: 58557 RVA: 0x00348701 File Offset: 0x00346901
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E4BE RID: 58558 RVA: 0x0034870E File Offset: 0x0034690E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E4BF RID: 58559 RVA: 0x00348718 File Offset: 0x00346918
		public static SoundBoxMark GetRootAsSoundBoxMark(ByteBuffer _bb)
		{
			return SoundBoxMark.GetRootAsSoundBoxMark(_bb, default(SoundBoxMark));
		}

		// Token: 0x0600E4C0 RID: 58560 RVA: 0x00348734 File Offset: 0x00346934
		public static SoundBoxMark GetRootAsSoundBoxMark(ByteBuffer _bb, SoundBoxMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E4C1 RID: 58561 RVA: 0x00348751 File Offset: 0x00346951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E4C2 RID: 58562 RVA: 0x00348760 File Offset: 0x00346960
		public SoundBoxMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AFA RID: 15098
		// (get) Token: 0x0600E4C3 RID: 58563 RVA: 0x00348770 File Offset: 0x00346970
		public int MarkId
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

		// Token: 0x17003AFB RID: 15099
		// (get) Token: 0x0600E4C4 RID: 58564 RVA: 0x003487AC File Offset: 0x003469AC
		public string MarkPic
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

		// Token: 0x0600E4C5 RID: 58565 RVA: 0x003487E3 File Offset: 0x003469E3
		public Span<byte> GetMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E4C6 RID: 58566 RVA: 0x003487F2 File Offset: 0x003469F2
		public byte[] GetMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AFC RID: 15100
		// (get) Token: 0x0600E4C7 RID: 58567 RVA: 0x0034880C File Offset: 0x00346A0C
		public string MarkTitle
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

		// Token: 0x0600E4C8 RID: 58568 RVA: 0x00348843 File Offset: 0x00346A43
		public Span<byte> GetMarkTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E4C9 RID: 58569 RVA: 0x00348852 File Offset: 0x00346A52
		public byte[] GetMarkTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AFD RID: 15101
		// (get) Token: 0x0600E4CA RID: 58570 RVA: 0x0034886C File Offset: 0x00346A6C
		public string MarkDesc
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

		// Token: 0x0600E4CB RID: 58571 RVA: 0x003488A4 File Offset: 0x00346AA4
		public Span<byte> GetMarkDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E4CC RID: 58572 RVA: 0x003488B4 File Offset: 0x00346AB4
		public byte[] GetMarkDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AFE RID: 15102
		// (get) Token: 0x0600E4CD RID: 58573 RVA: 0x003488CC File Offset: 0x00346ACC
		public int ShowPriority
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

		// Token: 0x0600E4CE RID: 58574 RVA: 0x0034890C File Offset: 0x00346B0C
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003AFF RID: 15103
		// (get) Token: 0x0600E4CF RID: 58575 RVA: 0x0034894C File Offset: 0x00346B4C
		public int ShowRangeLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E4D0 RID: 58576 RVA: 0x00348978 File Offset: 0x00346B78
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600E4D1 RID: 58577 RVA: 0x00348988 File Offset: 0x00346B88
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003B00 RID: 15104
		// (get) Token: 0x0600E4D2 RID: 58578 RVA: 0x003489A0 File Offset: 0x00346BA0
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E4D3 RID: 58579 RVA: 0x003489E1 File Offset: 0x00346BE1
		[NullableContext(1)]
		public int[] ShowRange()
		{
			return this.GetShowRangeArray();
		}

		// Token: 0x0600E4D4 RID: 58580 RVA: 0x003489E9 File Offset: 0x00346BE9
		[NullableContext(1)]
		public IEnumerable<int> ShowRangeIter()
		{
			SoundBoxMark.<ShowRangeIter>d__32 <ShowRangeIter>d__ = new SoundBoxMark.<ShowRangeIter>d__32(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x0400584F RID: 22607
		private Table __p;
	}
}
