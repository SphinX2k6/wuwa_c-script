using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E16 RID: 3606
	public struct HonamiStoryBuffTemp : IFlatbufferObject
	{
		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06008545 RID: 34117 RVA: 0x00274482 File Offset: 0x00272682
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008546 RID: 34118 RVA: 0x0027448F File Offset: 0x0027268F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008547 RID: 34119 RVA: 0x00274498 File Offset: 0x00272698
		public static HonamiStoryBuffTemp GetRootAsHonamiStoryBuffTemp(ByteBuffer _bb)
		{
			return HonamiStoryBuffTemp.GetRootAsHonamiStoryBuffTemp(_bb, default(HonamiStoryBuffTemp));
		}

		// Token: 0x06008548 RID: 34120 RVA: 0x002744B4 File Offset: 0x002726B4
		public static HonamiStoryBuffTemp GetRootAsHonamiStoryBuffTemp(ByteBuffer _bb, HonamiStoryBuffTemp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008549 RID: 34121 RVA: 0x002744D1 File Offset: 0x002726D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600854A RID: 34122 RVA: 0x002744E0 File Offset: 0x002726E0
		public HonamiStoryBuffTemp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x0600854B RID: 34123 RVA: 0x002744F0 File Offset: 0x002726F0
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

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x0600854C RID: 34124 RVA: 0x0027452C File Offset: 0x0027272C
		public string Name
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

		// Token: 0x0600854D RID: 34125 RVA: 0x00274563 File Offset: 0x00272763
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600854E RID: 34126 RVA: 0x00274572 File Offset: 0x00272772
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x0600854F RID: 34127 RVA: 0x0027458C File Offset: 0x0027278C
		public string Desc
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

		// Token: 0x06008550 RID: 34128 RVA: 0x002745C3 File Offset: 0x002727C3
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008551 RID: 34129 RVA: 0x002745D2 File Offset: 0x002727D2
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06008552 RID: 34130 RVA: 0x002745EC File Offset: 0x002727EC
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06008553 RID: 34131 RVA: 0x00274628 File Offset: 0x00272828
		public int DescArgsLength
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

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06008554 RID: 34132 RVA: 0x00274654 File Offset: 0x00272854
		public string DescSimple
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

		// Token: 0x06008555 RID: 34133 RVA: 0x0027468C File Offset: 0x0027288C
		public Span<byte> GetDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008556 RID: 34134 RVA: 0x0027469C File Offset: 0x0027289C
		public byte[] GetDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06008557 RID: 34135 RVA: 0x002746B4 File Offset: 0x002728B4
		public string DescSimpleArgs(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06008558 RID: 34136 RVA: 0x002746F0 File Offset: 0x002728F0
		public int DescSimpleArgsLength
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

		// Token: 0x06008559 RID: 34137 RVA: 0x0027471C File Offset: 0x0027291C
		[NullableContext(1)]
		public string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x0600855A RID: 34138 RVA: 0x00274729 File Offset: 0x00272929
		[NullableContext(1)]
		public IEnumerable<string> DescArgsIter()
		{
			HonamiStoryBuffTemp.<DescArgsIter>d__29 <DescArgsIter>d__ = new HonamiStoryBuffTemp.<DescArgsIter>d__29(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x0600855B RID: 34139 RVA: 0x0027473E File Offset: 0x0027293E
		[NullableContext(1)]
		public string[] DescSimpleArgs()
		{
			return this.DescSimpleArgsIter().ToArray<string>();
		}

		// Token: 0x0600855C RID: 34140 RVA: 0x0027474B File Offset: 0x0027294B
		[NullableContext(1)]
		public IEnumerable<string> DescSimpleArgsIter()
		{
			HonamiStoryBuffTemp.<DescSimpleArgsIter>d__31 <DescSimpleArgsIter>d__ = new HonamiStoryBuffTemp.<DescSimpleArgsIter>d__31(-2);
			<DescSimpleArgsIter>d__.<>3__<>4__this = this;
			return <DescSimpleArgsIter>d__;
		}

		// Token: 0x0400538F RID: 21391
		private Table __p;
	}
}
