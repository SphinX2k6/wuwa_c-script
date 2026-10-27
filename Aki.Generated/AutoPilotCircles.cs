using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B11 RID: 2833
	public struct AutoPilotCircles : IFlatbufferObject
	{
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060049B3 RID: 18867 RVA: 0x001DA590 File Offset: 0x001D8790
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060049B4 RID: 18868 RVA: 0x001DA59D File Offset: 0x001D879D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060049B5 RID: 18869 RVA: 0x001DA5A4 File Offset: 0x001D87A4
		public static AutoPilotCircles GetRootAsAutoPilotCircles(ByteBuffer _bb)
		{
			return AutoPilotCircles.GetRootAsAutoPilotCircles(_bb, default(AutoPilotCircles));
		}

		// Token: 0x060049B6 RID: 18870 RVA: 0x001DA5C0 File Offset: 0x001D87C0
		public static AutoPilotCircles GetRootAsAutoPilotCircles(ByteBuffer _bb, AutoPilotCircles obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060049B7 RID: 18871 RVA: 0x001DA5DD File Offset: 0x001D87DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060049B8 RID: 18872 RVA: 0x001DA5EC File Offset: 0x001D87EC
		public AutoPilotCircles __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060049B9 RID: 18873 RVA: 0x001DA5FC File Offset: 0x001D87FC
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

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060049BA RID: 18874 RVA: 0x001DA638 File Offset: 0x001D8838
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

		// Token: 0x060049BB RID: 18875 RVA: 0x001DA66F File Offset: 0x001D886F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x001DA67E File Offset: 0x001D887E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060049BD RID: 18877 RVA: 0x001DA698 File Offset: 0x001D8898
		public string Description
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

		// Token: 0x060049BE RID: 18878 RVA: 0x001DA6CF File Offset: 0x001D88CF
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x001DA6DE File Offset: 0x001D88DE
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060049C0 RID: 18880 RVA: 0x001DA6F8 File Offset: 0x001D88F8
		public int CreatorId
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

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060049C1 RID: 18881 RVA: 0x001DA738 File Offset: 0x001D8938
		public int MapId
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

		// Token: 0x060049C2 RID: 18882 RVA: 0x001DA778 File Offset: 0x001D8978
		public int WaySplines(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060049C3 RID: 18883 RVA: 0x001DA7B8 File Offset: 0x001D89B8
		public int WaySplinesLength
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

		// Token: 0x060049C4 RID: 18884 RVA: 0x001DA7E4 File Offset: 0x001D89E4
		public Span<int> GetWaySplinesBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060049C5 RID: 18885 RVA: 0x001DA7F4 File Offset: 0x001D89F4
		public int[] GetWaySplinesArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x060049C6 RID: 18886 RVA: 0x001DA80C File Offset: 0x001D8A0C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WaySplinesIter()或GetWaySplinesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WaySplines()
		{
			AutoPilotCircles autoPilotCircles = this;
			return autoPilotCircles.GetWaySplinesArray() ?? Array.Empty<int>();
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x001DA830 File Offset: 0x001D8A30
		[NullableContext(1)]
		public readonly IEnumerable<int> WaySplinesIter()
		{
			AutoPilotCircles.<WaySplinesIter>d__28 <WaySplinesIter>d__ = new AutoPilotCircles.<WaySplinesIter>d__28(-2);
			<WaySplinesIter>d__.<>3__<>4__this = this;
			return <WaySplinesIter>d__;
		}

		// Token: 0x04004AF9 RID: 19193
		private Table __p;
	}
}
