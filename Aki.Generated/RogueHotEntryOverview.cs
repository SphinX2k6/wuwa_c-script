using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE3 RID: 4067
	public struct RogueHotEntryOverview : IFlatbufferObject
	{
		// Token: 0x17002F4F RID: 12111
		// (get) Token: 0x0600BF6B RID: 49003 RVA: 0x002E5B1D File Offset: 0x002E3D1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BF6C RID: 49004 RVA: 0x002E5B2A File Offset: 0x002E3D2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF6D RID: 49005 RVA: 0x002E5B34 File Offset: 0x002E3D34
		public static RogueHotEntryOverview GetRootAsRogueHotEntryOverview(ByteBuffer _bb)
		{
			return RogueHotEntryOverview.GetRootAsRogueHotEntryOverview(_bb, default(RogueHotEntryOverview));
		}

		// Token: 0x0600BF6E RID: 49006 RVA: 0x002E5B50 File Offset: 0x002E3D50
		public static RogueHotEntryOverview GetRootAsRogueHotEntryOverview(ByteBuffer _bb, RogueHotEntryOverview obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF6F RID: 49007 RVA: 0x002E5B6D File Offset: 0x002E3D6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF70 RID: 49008 RVA: 0x002E5B7C File Offset: 0x002E3D7C
		public RogueHotEntryOverview __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F50 RID: 12112
		// (get) Token: 0x0600BF71 RID: 49009 RVA: 0x002E5B8C File Offset: 0x002E3D8C
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

		// Token: 0x17002F51 RID: 12113
		// (get) Token: 0x0600BF72 RID: 49010 RVA: 0x002E5BC8 File Offset: 0x002E3DC8
		public int Type
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

		// Token: 0x0600BF73 RID: 49011 RVA: 0x002E5C04 File Offset: 0x002E3E04
		public bool ParamShowPercent(int j)
		{
			int num = this.__p.__offset(8);
			return num != 0 && this.__p.bb.Get(this.__p.__vector(num) + j) > 0;
		}

		// Token: 0x17002F52 RID: 12114
		// (get) Token: 0x0600BF74 RID: 49012 RVA: 0x002E5C44 File Offset: 0x002E3E44
		public int ParamShowPercentLength
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

		// Token: 0x0600BF75 RID: 49013 RVA: 0x002E5C6F File Offset: 0x002E3E6F
		public Span<bool> GetParamShowPercentBytes()
		{
			return this.__p.__vector_as_span<bool>(8, 1);
		}

		// Token: 0x0600BF76 RID: 49014 RVA: 0x002E5C7E File Offset: 0x002E3E7E
		public bool[] GetParamShowPercentArray()
		{
			return this.__p.__vector_as_array<bool>(8) ?? Array.Empty<bool>();
		}

		// Token: 0x0600BF77 RID: 49015 RVA: 0x002E5C98 File Offset: 0x002E3E98
		public string Desc(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F53 RID: 12115
		// (get) Token: 0x0600BF78 RID: 49016 RVA: 0x002E5CD4 File Offset: 0x002E3ED4
		public int DescLength
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

		// Token: 0x17002F54 RID: 12116
		// (get) Token: 0x0600BF79 RID: 49017 RVA: 0x002E5D00 File Offset: 0x002E3F00
		public int SortId
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

		// Token: 0x0600BF7A RID: 49018 RVA: 0x002E5D3D File Offset: 0x002E3F3D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescIter()或GetDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Desc()
		{
			return this.DescIter().ToArray<string>();
		}

		// Token: 0x0600BF7B RID: 49019 RVA: 0x002E5D4A File Offset: 0x002E3F4A
		[NullableContext(1)]
		public readonly IEnumerable<string> DescIter()
		{
			RogueHotEntryOverview.<DescIter>d__23 <DescIter>d__ = new RogueHotEntryOverview.<DescIter>d__23(-2);
			<DescIter>d__.<>3__<>4__this = this;
			return <DescIter>d__;
		}

		// Token: 0x0600BF7C RID: 49020 RVA: 0x002E5D60 File Offset: 0x002E3F60
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamShowPercentIter()或GetParamShowPercentBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly bool[] ParamShowPercent()
		{
			RogueHotEntryOverview rogueHotEntryOverview = this;
			return rogueHotEntryOverview.GetParamShowPercentArray() ?? Array.Empty<bool>();
		}

		// Token: 0x0600BF7D RID: 49021 RVA: 0x002E5D84 File Offset: 0x002E3F84
		[NullableContext(1)]
		public readonly IEnumerable<bool> ParamShowPercentIter()
		{
			RogueHotEntryOverview.<ParamShowPercentIter>d__25 <ParamShowPercentIter>d__ = new RogueHotEntryOverview.<ParamShowPercentIter>d__25(-2);
			<ParamShowPercentIter>d__.<>3__<>4__this = this;
			return <ParamShowPercentIter>d__;
		}

		// Token: 0x040050C0 RID: 20672
		private Table __p;
	}
}
