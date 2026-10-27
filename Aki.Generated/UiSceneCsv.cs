using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001187 RID: 4487
	public struct UiSceneCsv : IFlatbufferObject
	{
		// Token: 0x17003D48 RID: 15688
		// (get) Token: 0x0600E670 RID: 58992 RVA: 0x0033F086 File Offset: 0x0033D286
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E671 RID: 58993 RVA: 0x0033F093 File Offset: 0x0033D293
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E672 RID: 58994 RVA: 0x0033F09C File Offset: 0x0033D29C
		public static UiSceneCsv GetRootAsUiSceneCsv(ByteBuffer _bb)
		{
			return UiSceneCsv.GetRootAsUiSceneCsv(_bb, default(UiSceneCsv));
		}

		// Token: 0x0600E673 RID: 58995 RVA: 0x0033F0B8 File Offset: 0x0033D2B8
		public static UiSceneCsv GetRootAsUiSceneCsv(ByteBuffer _bb, UiSceneCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E674 RID: 58996 RVA: 0x0033F0D5 File Offset: 0x0033D2D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E675 RID: 58997 RVA: 0x0033F0E4 File Offset: 0x0033D2E4
		public UiSceneCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D49 RID: 15689
		// (get) Token: 0x0600E676 RID: 58998 RVA: 0x0033F0F4 File Offset: 0x0033D2F4
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E677 RID: 58999 RVA: 0x0033F12B File Offset: 0x0033D32B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600E678 RID: 59000 RVA: 0x0033F13A File Offset: 0x0033D33A
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E679 RID: 59001 RVA: 0x0033F154 File Offset: 0x0033D354
		public string SceneList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D4A RID: 15690
		// (get) Token: 0x0600E67A RID: 59002 RVA: 0x0033F190 File Offset: 0x0033D390
		public int SceneListLength
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

		// Token: 0x17003D4B RID: 15691
		// (get) Token: 0x0600E67B RID: 59003 RVA: 0x0033F1BC File Offset: 0x0033D3BC
		public IntVector? WorldOffset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IntVector?(default(IntVector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003D4C RID: 15692
		// (get) Token: 0x0600E67C RID: 59004 RVA: 0x0033F21C File Offset: 0x0033D41C
		public string MainScene
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

		// Token: 0x0600E67D RID: 59005 RVA: 0x0033F254 File Offset: 0x0033D454
		public Span<byte> GetMainSceneBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E67E RID: 59006 RVA: 0x0033F264 File Offset: 0x0033D464
		public byte[] GetMainSceneArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E67F RID: 59007 RVA: 0x0033F27C File Offset: 0x0033D47C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SceneListIter()或GetSceneListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SceneList()
		{
			return this.SceneListIter().ToArray<string>();
		}

		// Token: 0x0600E680 RID: 59008 RVA: 0x0033F289 File Offset: 0x0033D489
		[NullableContext(1)]
		public readonly IEnumerable<string> SceneListIter()
		{
			UiSceneCsv.<SceneListIter>d__22 <SceneListIter>d__ = new UiSceneCsv.<SceneListIter>d__22(-2);
			<SceneListIter>d__.<>3__<>4__this = this;
			return <SceneListIter>d__;
		}

		// Token: 0x040052D0 RID: 21200
		private Table __p;
	}
}
