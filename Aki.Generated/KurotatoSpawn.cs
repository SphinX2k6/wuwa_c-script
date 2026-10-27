using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB3 RID: 3507
	public struct KurotatoSpawn : IFlatbufferObject
	{
		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x06008B8C RID: 35724 RVA: 0x002723A1 File Offset: 0x002705A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008B8D RID: 35725 RVA: 0x002723AE File Offset: 0x002705AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008B8E RID: 35726 RVA: 0x002723B8 File Offset: 0x002705B8
		public static KurotatoSpawn GetRootAsKurotatoSpawn(ByteBuffer _bb)
		{
			return KurotatoSpawn.GetRootAsKurotatoSpawn(_bb, default(KurotatoSpawn));
		}

		// Token: 0x06008B8F RID: 35727 RVA: 0x002723D4 File Offset: 0x002705D4
		public static KurotatoSpawn GetRootAsKurotatoSpawn(ByteBuffer _bb, KurotatoSpawn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008B90 RID: 35728 RVA: 0x002723F1 File Offset: 0x002705F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008B91 RID: 35729 RVA: 0x00272400 File Offset: 0x00270600
		public KurotatoSpawn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x06008B92 RID: 35730 RVA: 0x00272410 File Offset: 0x00270610
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

		// Token: 0x06008B93 RID: 35731 RVA: 0x0027244C File Offset: 0x0027064C
		public int MonsterIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x06008B94 RID: 35732 RVA: 0x0027248C File Offset: 0x0027068C
		public int MonsterIdsLength
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

		// Token: 0x06008B95 RID: 35733 RVA: 0x002724B7 File Offset: 0x002706B7
		public Span<int> GetMonsterIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008B96 RID: 35734 RVA: 0x002724C6 File Offset: 0x002706C6
		public int[] GetMonsterIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008B97 RID: 35735 RVA: 0x002724E0 File Offset: 0x002706E0
		public int WaypointIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x06008B98 RID: 35736 RVA: 0x00272520 File Offset: 0x00270720
		public int WaypointIdsLength
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

		// Token: 0x06008B99 RID: 35737 RVA: 0x0027254B File Offset: 0x0027074B
		public Span<int> GetWaypointIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008B9A RID: 35738 RVA: 0x0027255A File Offset: 0x0027075A
		public int[] GetWaypointIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06008B9B RID: 35739 RVA: 0x00272574 File Offset: 0x00270774
		public bool WaypointLoop(int j)
		{
			int num = this.__p.__offset(10);
			return num != 0 && this.__p.bb.Get(this.__p.__vector(num) + j) > 0;
		}

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x06008B9C RID: 35740 RVA: 0x002725B8 File Offset: 0x002707B8
		public int WaypointLoopLength
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

		// Token: 0x06008B9D RID: 35741 RVA: 0x002725E4 File Offset: 0x002707E4
		public Span<bool> GetWaypointLoopBytes()
		{
			return this.__p.__vector_as_span<bool>(10, 1);
		}

		// Token: 0x06008B9E RID: 35742 RVA: 0x002725F4 File Offset: 0x002707F4
		public bool[] GetWaypointLoopArray()
		{
			return this.__p.__vector_as_array<bool>(10) ?? Array.Empty<bool>();
		}

		// Token: 0x06008B9F RID: 35743 RVA: 0x0027260C File Offset: 0x0027080C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterIdsIter()或GetMonsterIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MonsterIds()
		{
			KurotatoSpawn kurotatoSpawn = this;
			return kurotatoSpawn.GetMonsterIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008BA0 RID: 35744 RVA: 0x00272630 File Offset: 0x00270830
		[NullableContext(1)]
		public readonly IEnumerable<int> MonsterIdsIter()
		{
			KurotatoSpawn.<MonsterIdsIter>d__26 <MonsterIdsIter>d__ = new KurotatoSpawn.<MonsterIdsIter>d__26(-2);
			<MonsterIdsIter>d__.<>3__<>4__this = this;
			return <MonsterIdsIter>d__;
		}

		// Token: 0x06008BA1 RID: 35745 RVA: 0x00272648 File Offset: 0x00270848
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WaypointIdsIter()或GetWaypointIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WaypointIds()
		{
			KurotatoSpawn kurotatoSpawn = this;
			return kurotatoSpawn.GetWaypointIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008BA2 RID: 35746 RVA: 0x0027266C File Offset: 0x0027086C
		[NullableContext(1)]
		public readonly IEnumerable<int> WaypointIdsIter()
		{
			KurotatoSpawn.<WaypointIdsIter>d__28 <WaypointIdsIter>d__ = new KurotatoSpawn.<WaypointIdsIter>d__28(-2);
			<WaypointIdsIter>d__.<>3__<>4__this = this;
			return <WaypointIdsIter>d__;
		}

		// Token: 0x06008BA3 RID: 35747 RVA: 0x00272684 File Offset: 0x00270884
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WaypointLoopIter()或GetWaypointLoopBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly bool[] WaypointLoop()
		{
			KurotatoSpawn kurotatoSpawn = this;
			return kurotatoSpawn.GetWaypointLoopArray() ?? Array.Empty<bool>();
		}

		// Token: 0x06008BA4 RID: 35748 RVA: 0x002726A8 File Offset: 0x002708A8
		[NullableContext(1)]
		public readonly IEnumerable<bool> WaypointLoopIter()
		{
			KurotatoSpawn.<WaypointLoopIter>d__30 <WaypointLoopIter>d__ = new KurotatoSpawn.<WaypointLoopIter>d__30(-2);
			<WaypointLoopIter>d__.<>3__<>4__this = this;
			return <WaypointLoopIter>d__;
		}

		// Token: 0x04004E45 RID: 20037
		private Table __p;
	}
}
