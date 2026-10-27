using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200108B RID: 4235
	public struct RoverRogueTalentTree : IFlatbufferObject
	{
		// Token: 0x170034DB RID: 13531
		// (get) Token: 0x0600CF6D RID: 53101 RVA: 0x00309A70 File Offset: 0x00307C70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CF6E RID: 53102 RVA: 0x00309A7D File Offset: 0x00307C7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CF6F RID: 53103 RVA: 0x00309A84 File Offset: 0x00307C84
		public static RoverRogueTalentTree GetRootAsRoverRogueTalentTree(ByteBuffer _bb)
		{
			return RoverRogueTalentTree.GetRootAsRoverRogueTalentTree(_bb, default(RoverRogueTalentTree));
		}

		// Token: 0x0600CF70 RID: 53104 RVA: 0x00309AA0 File Offset: 0x00307CA0
		public static RoverRogueTalentTree GetRootAsRoverRogueTalentTree(ByteBuffer _bb, RoverRogueTalentTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CF71 RID: 53105 RVA: 0x00309ABD File Offset: 0x00307CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CF72 RID: 53106 RVA: 0x00309ACC File Offset: 0x00307CCC
		public RoverRogueTalentTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034DC RID: 13532
		// (get) Token: 0x0600CF73 RID: 53107 RVA: 0x00309ADC File Offset: 0x00307CDC
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

		// Token: 0x170034DD RID: 13533
		// (get) Token: 0x0600CF74 RID: 53108 RVA: 0x00309B18 File Offset: 0x00307D18
		public int Row
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

		// Token: 0x170034DE RID: 13534
		// (get) Token: 0x0600CF75 RID: 53109 RVA: 0x00309B54 File Offset: 0x00307D54
		public int Column
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

		// Token: 0x170034DF RID: 13535
		// (get) Token: 0x0600CF76 RID: 53110 RVA: 0x00309B90 File Offset: 0x00307D90
		public int Type
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

		// Token: 0x0600CF77 RID: 53111 RVA: 0x00309BD0 File Offset: 0x00307DD0
		public int PostId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x0600CF78 RID: 53112 RVA: 0x00309C10 File Offset: 0x00307E10
		public int PostIdLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CF79 RID: 53113 RVA: 0x00309C3C File Offset: 0x00307E3C
		public Span<int> GetPostIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600CF7A RID: 53114 RVA: 0x00309C4C File Offset: 0x00307E4C
		public int[] GetPostIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x0600CF7B RID: 53115 RVA: 0x00309C64 File Offset: 0x00307E64
		public int Consule
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

		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x0600CF7C RID: 53116 RVA: 0x00309CA4 File Offset: 0x00307EA4
		public int EffectTrigger
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

		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x0600CF7D RID: 53117 RVA: 0x00309CE4 File Offset: 0x00307EE4
		public int NextLevelTalentId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x0600CF7E RID: 53118 RVA: 0x00309D24 File Offset: 0x00307F24
		public string Name
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CF7F RID: 53119 RVA: 0x00309D5C File Offset: 0x00307F5C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600CF80 RID: 53120 RVA: 0x00309D6C File Offset: 0x00307F6C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x0600CF81 RID: 53121 RVA: 0x00309D84 File Offset: 0x00307F84
		public string Desc
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

		// Token: 0x0600CF82 RID: 53122 RVA: 0x00309DBC File Offset: 0x00307FBC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600CF83 RID: 53123 RVA: 0x00309DCC File Offset: 0x00307FCC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CF84 RID: 53124 RVA: 0x00309DE4 File Offset: 0x00307FE4
		public string Params(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x0600CF85 RID: 53125 RVA: 0x00309E20 File Offset: 0x00308020
		public int ParamsLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170034E7 RID: 13543
		// (get) Token: 0x0600CF86 RID: 53126 RVA: 0x00309E4C File Offset: 0x0030804C
		public string Icon
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

		// Token: 0x0600CF87 RID: 53127 RVA: 0x00309E84 File Offset: 0x00308084
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600CF88 RID: 53128 RVA: 0x00309E94 File Offset: 0x00308094
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CF89 RID: 53129 RVA: 0x00309EAC File Offset: 0x003080AC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamsIter()或GetParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Params()
		{
			return this.ParamsIter().ToArray<string>();
		}

		// Token: 0x0600CF8A RID: 53130 RVA: 0x00309EB9 File Offset: 0x003080B9
		[NullableContext(1)]
		public readonly IEnumerable<string> ParamsIter()
		{
			RoverRogueTalentTree.<ParamsIter>d__43 <ParamsIter>d__ = new RoverRogueTalentTree.<ParamsIter>d__43(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x0600CF8B RID: 53131 RVA: 0x00309ED0 File Offset: 0x003080D0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PostIdIter()或GetPostIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PostId()
		{
			RoverRogueTalentTree roverRogueTalentTree = this;
			return roverRogueTalentTree.GetPostIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CF8C RID: 53132 RVA: 0x00309EF4 File Offset: 0x003080F4
		[NullableContext(1)]
		public readonly IEnumerable<int> PostIdIter()
		{
			RoverRogueTalentTree.<PostIdIter>d__45 <PostIdIter>d__ = new RoverRogueTalentTree.<PostIdIter>d__45(-2);
			<PostIdIter>d__.<>3__<>4__this = this;
			return <PostIdIter>d__;
		}

		// Token: 0x04005198 RID: 20888
		private Table __p;
	}
}
