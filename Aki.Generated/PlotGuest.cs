using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F4C RID: 3916
	public struct PlotGuest : IFlatbufferObject
	{
		// Token: 0x17002A95 RID: 10901
		// (get) Token: 0x0600B249 RID: 45641 RVA: 0x002C938C File Offset: 0x002C758C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B24A RID: 45642 RVA: 0x002C9399 File Offset: 0x002C7599
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B24B RID: 45643 RVA: 0x002C93A0 File Offset: 0x002C75A0
		public static PlotGuest GetRootAsPlotGuest(ByteBuffer _bb)
		{
			return PlotGuest.GetRootAsPlotGuest(_bb, default(PlotGuest));
		}

		// Token: 0x0600B24C RID: 45644 RVA: 0x002C93BC File Offset: 0x002C75BC
		public static PlotGuest GetRootAsPlotGuest(ByteBuffer _bb, PlotGuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B24D RID: 45645 RVA: 0x002C93D9 File Offset: 0x002C75D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B24E RID: 45646 RVA: 0x002C93E8 File Offset: 0x002C75E8
		public PlotGuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A96 RID: 10902
		// (get) Token: 0x0600B24F RID: 45647 RVA: 0x002C93F8 File Offset: 0x002C75F8
		public int GuestID
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

		// Token: 0x17002A97 RID: 10903
		// (get) Token: 0x0600B250 RID: 45648 RVA: 0x002C9434 File Offset: 0x002C7634
		public string HeadIconPath
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

		// Token: 0x0600B251 RID: 45649 RVA: 0x002C946B File Offset: 0x002C766B
		public Span<byte> GetHeadIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B252 RID: 45650 RVA: 0x002C947A File Offset: 0x002C767A
		public byte[] GetHeadIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A98 RID: 10904
		// (get) Token: 0x0600B253 RID: 45651 RVA: 0x002C9494 File Offset: 0x002C7694
		public string Name
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

		// Token: 0x0600B254 RID: 45652 RVA: 0x002C94CB File Offset: 0x002C76CB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B255 RID: 45653 RVA: 0x002C94DA File Offset: 0x002C76DA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B256 RID: 45654 RVA: 0x002C94F4 File Offset: 0x002C76F4
		public int SpeakerID(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A99 RID: 10905
		// (get) Token: 0x0600B257 RID: 45655 RVA: 0x002C9534 File Offset: 0x002C7734
		public int SpeakerIDLength
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

		// Token: 0x0600B258 RID: 45656 RVA: 0x002C9560 File Offset: 0x002C7760
		public Span<int> GetSpeakerIDBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600B259 RID: 45657 RVA: 0x002C9570 File Offset: 0x002C7770
		public int[] GetSpeakerIDArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002A9A RID: 10906
		// (get) Token: 0x0600B25A RID: 45658 RVA: 0x002C9588 File Offset: 0x002C7788
		public string FxColor
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

		// Token: 0x0600B25B RID: 45659 RVA: 0x002C95C0 File Offset: 0x002C77C0
		public Span<byte> GetFxColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B25C RID: 45660 RVA: 0x002C95D0 File Offset: 0x002C77D0
		public byte[] GetFxColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B25D RID: 45661 RVA: 0x002C95E8 File Offset: 0x002C77E8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpeakerIDIter()或GetSpeakerIDBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpeakerID()
		{
			PlotGuest plotGuest = this;
			return plotGuest.GetSpeakerIDArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B25E RID: 45662 RVA: 0x002C960C File Offset: 0x002C780C
		[NullableContext(1)]
		public readonly IEnumerable<int> SpeakerIDIter()
		{
			PlotGuest.<SpeakerIDIter>d__28 <SpeakerIDIter>d__ = new PlotGuest.<SpeakerIDIter>d__28(-2);
			<SpeakerIDIter>d__.<>3__<>4__this = this;
			return <SpeakerIDIter>d__;
		}

		// Token: 0x04005019 RID: 20505
		private Table __p;
	}
}
